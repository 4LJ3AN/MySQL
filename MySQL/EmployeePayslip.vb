Imports System.Diagnostics
Imports System.IO
Imports System.Runtime.InteropServices
Imports iTextSharp.text
Imports iTextSharp.text.pdf
Imports iTextSharp.text.pdf.draw
Imports MySQL.Data.MySqlClient

Public Class EmployeePayslip

    ' ===========================================================
    ' = FETCH FULL EMPLOYEE NAME BY ID
    ' ===========================================================
    Private Function GetEmployeeFullName(empId As String) As String
        Dim fullName As String = ""

        Try
            Using conn As MySqlConnection = (New DatabaseConnection).GetConnection()
                conn.Open()

                Dim query As String = "
                    SELECT TRIM(CONCAT(fname, ' ',
                        IFNULL(CONCAT(mname, ' '), ''),
                        lname)) AS full_name
                    FROM employees
                    WHERE id = @empid;
                "

                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@empid", empId)
                    Dim result As Object = cmd.ExecuteScalar()

                    fullName = If(result IsNot Nothing AndAlso Not IsDBNull(result),
                                  result.ToString(),
                                  "Unknown Employee")
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show($"Error fetching employee name: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        Return fullName
    End Function

    ' ===========================================================
    ' = FORM LOAD
    ' ===========================================================
    Private Sub EmployeePayslip_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        namelbl.Text = GetEmployeeFullName(empIDlbl.Text.Replace("Employee ID: ", "").Trim())
        idlbl.Text = empIDlbl.Text.Replace("Employee ID: ", "").Trim()
        poslbl.Text = positionlbl.Text.Replace("Position: ", "").Trim()
        CheckAndGeneratePayslips()
        LoadPayslipRecords(empIDlbl.Text.Replace("Employee ID: ", "").Trim())
        TogglePayslipDetails(False)
    End Sub

    ' ===========================================================
    ' = PAYSLIP AUTO-GENERATION (Runs only on the 15th)
    ' ===========================================================
    Public Sub CheckAndGeneratePayslips()
        Dim today As Date = Date.Now
        If today.Day = 15 Then
            GeneratePayslipsForAllEmployees()
        Else
            Debug.WriteLine("[INFO] Today is not the 15th. Payslips will not be generated.")
        End If
    End Sub

    Private Sub GeneratePayslipsForAllEmployees()
        Try
            Using conn As MySqlConnection = (New DatabaseConnection).GetConnection()
                conn.Open()

                Dim checkCmd As New MySqlCommand("
                    SELECT COUNT(*) FROM payslips 
                    WHERE MONTH(generated_on) = MONTH(CURDATE())
                    AND YEAR(generated_on) = YEAR(CURDATE());
                ", conn)

                Dim existing As Integer = Convert.ToInt32(checkCmd.ExecuteScalar())
                If existing > 0 Then
                    Debug.WriteLine("[INFO] Payslips already generated for this month’s 15th.")
                    Return
                End If

                Dim empCmd As New MySqlCommand("SELECT id, hourlyrate FROM employees", conn)
                Using reader As MySqlDataReader = empCmd.ExecuteReader()
                    Dim empList As New List(Of Tuple(Of Integer, Double))
                    While reader.Read()
                        empList.Add(New Tuple(Of Integer, Double)(reader("id"), reader("hourlyrate")))
                    End While
                    reader.Close()

                    For Each emp In empList
                        Dim empId As Integer = emp.Item1
                        Dim hourlyRate As Double = emp.Item2
                        Dim basicHours As Double = 0.0
                        Dim otHours As Double = 0.0

                        Dim grossPay As Double = ComputeGrossPay(empId, hourlyRate, conn, basicHours, otHours)
                        Dim incomeTax As Double = grossPay * 0.1
                        Dim pagibig As Double = grossPay * 0.01
                        Dim sss As Double = grossPay * 0.02
                        Dim totalDeductions As Double = incomeTax + pagibig + sss
                        Dim netPay As Double = grossPay - totalDeductions
                        Dim startDate As New Date(Date.Now.Year, Date.Now.Month, 1)
                        Dim endDate As New Date(Date.Now.Year, Date.Now.Month, 15)

                        Dim insertCmd As New MySqlCommand("
                            INSERT INTO payslips 
                                (employeeid, basic_hours, ot_hours, gross_pay, income_tax, pagibig, sss, total_deductions, net_pay, generated_on, period_start, period_end)
                            VALUES 
                                (@empid, @basic, @ot, @gross, @tax, @pagibig, @sss, @ded, @net, NOW(), @periodStart, @periodEnd);
                        ", conn)

                        insertCmd.Parameters.AddWithValue("@empid", empId)
                        insertCmd.Parameters.AddWithValue("@basic", basicHours)
                        insertCmd.Parameters.AddWithValue("@ot", otHours)
                        insertCmd.Parameters.AddWithValue("@gross", grossPay)
                        insertCmd.Parameters.AddWithValue("@tax", incomeTax)
                        insertCmd.Parameters.AddWithValue("@pagibig", pagibig)
                        insertCmd.Parameters.AddWithValue("@sss", sss)
                        insertCmd.Parameters.AddWithValue("@ded", totalDeductions)
                        insertCmd.Parameters.AddWithValue("@net", netPay)
                        insertCmd.Parameters.AddWithValue("@periodStart", startDate)
                        insertCmd.Parameters.AddWithValue("@periodEnd", endDate)
                        insertCmd.ExecuteNonQuery()
                    Next
                End Using
            End Using

        Catch ex As Exception
            Debug.WriteLine($"[ERROR] Error generating payslips: {ex.Message}")
        End Try
    End Sub

    ' ===========================================================
    ' = GROSS PAY CALCULATION
    ' ===========================================================
    Private Function ComputeGrossPay(empId As Integer, hourlyRate As Double, conn As MySqlConnection, ByRef basicHours As Double, ByRef otHours As Double) As Double
        Dim startDate As New Date(Date.Now.Year, Date.Now.Month, 1)
        Dim endDate As New Date(Date.Now.Year, Date.Now.Month, 15)

        Dim cmd As New MySqlCommand("
            SELECT timein, timeout, totalhours
            FROM attendance 
            WHERE id = @empid 
            AND date BETWEEN @startDate AND @endDate;
        ", conn)
        cmd.Parameters.AddWithValue("@empid", empId)
        cmd.Parameters.AddWithValue("@startDate", startDate.ToString("yyyy-MM-dd"))
        cmd.Parameters.AddWithValue("@endDate", endDate.ToString("yyyy-MM-dd"))

        basicHours = 0.0
        otHours = 0.0

        Using reader As MySqlDataReader = cmd.ExecuteReader()
            While reader.Read()
                If Not IsDBNull(reader("timein")) Then
                    Dim timeIn As DateTime = Convert.ToDateTime(reader("timein"))
                    Dim timeOut As DateTime = If(IsDBNull(reader("timeout")), timeIn.AddHours(6), Convert.ToDateTime(reader("timeout")))
                    Dim totalHours As Double = If(IsDBNull(reader("totalhours")), (timeOut - timeIn).TotalHours, Convert.ToDouble(reader("totalhours")))
                    Dim regularHours As Double = Math.Min(totalHours, 8)
                    Dim overtimeHours As Double = Math.Max(0, totalHours - 8)

                    basicHours += regularHours
                    otHours += overtimeHours
                End If
            End While
        End Using

        Return (basicHours * hourlyRate) + (otHours * hourlyRate * 1.25)
    End Function

    ' ===========================================================
    ' = LOAD PAYSLIP DATA TO FORM
    ' ===========================================================
    Private Sub LoadPayslipData(payslipId As Integer)
        Try
            Using conn As MySqlConnection = (New DatabaseConnection).GetConnection()
                conn.Open()

                Dim query As String = "
                    SELECT gross_pay, basic_hours, ot_hours,
                           income_tax, pagibig, sss, total_deductions, net_pay,
                           period_start, period_end, e.hourlyrate
                    FROM payslips p
                    JOIN employees e ON p.employeeid = e.id
                    WHERE payslip_id = @payslipId;
                "

                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@payslipId", payslipId)
                    Using reader As MySqlDataReader = cmd.ExecuteReader()
                        If reader.Read() Then
                            Dim hourlyRate As Double = Convert.ToDouble(reader("hourlyrate"))
                            Dim basicHours As Double = Convert.ToDouble(reader("basic_hours"))
                            Dim otHours As Double = Convert.ToDouble(reader("ot_hours"))
                            Dim basicPay As Double = basicHours * hourlyRate
                            Dim otPay As Double = otHours * hourlyRate * 1.25

                            lblBasicHours.Text = $"{basicHours:N2} hrs"
                            lblOTHours.Text = $"{otHours:N2} hrs"
                            lblBasicPay.Text = $"₱{basicPay:N2}"
                            lblOTPay.Text = $"₱{otPay:N2}"
                            lblGrossPay.Text = $"₱{Convert.ToDecimal(reader("gross_pay")):N2}"
                            lblIncomeTax.Text = $"₱{Convert.ToDecimal(reader("income_tax")):N2}"
                            lblPagibig.Text = $"₱{Convert.ToDecimal(reader("pagibig")):N2}"
                            lblSSS.Text = $"₱{Convert.ToDecimal(reader("sss")):N2}"
                            lblTotalDeductions.Text = $"₱{Convert.ToDecimal(reader("total_deductions")):N2}"
                            lblNetPay.Text = $"₱{Convert.ToDecimal(reader("net_pay")):N2}"
                            lblPayPeriodStart.Text = Convert.ToDateTime(reader("period_start")).ToString("MMMM dd, yyyy")
                            lblPayPeriodEnd.Text = Convert.ToDateTime(reader("period_end")).ToString("MMMM dd, yyyy")

                            TogglePayslipDetails(True)
                        End If
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show($"Error loading payslip data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' ===========================================================
    ' = LOAD PAYSLIP RECORDS TO COMBOBOX
    ' ===========================================================
    Private Sub LoadPayslipRecords(employeeId As String)
        Try
            Using conn As MySqlConnection = (New DatabaseConnection).GetConnection()
                conn.Open()

                Dim query As String = "
                    SELECT payslip_id, period_start, period_end 
                    FROM payslips 
                    WHERE employeeid = @employeeid 
                    ORDER BY period_start DESC;
                "

                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@employeeid", employeeId)
                    Using reader As MySqlDataReader = cmd.ExecuteReader()
                        cmbPayslipRecords.Items.Clear()

                        If reader.HasRows Then
                            While reader.Read()
                                Dim startDate As Date = Convert.ToDateTime(reader("period_start"))
                                Dim endDate As Date = Convert.ToDateTime(reader("period_end"))
                                Dim payslipId As Integer = Convert.ToInt32(reader("payslip_id"))

                                ' Show only readable date range
                                cmbPayslipRecords.Items.Add(New With {
                                    .Text = $"{startDate:MMMM dd, yyyy} - {endDate:MMMM dd, yyyy}",
                                    .Id = payslipId
                                })
                            End While

                            cmbPayslipRecords.DisplayMember = "Text"
                            cmbPayslipRecords.ValueMember = "Id"
                            cmbPayslipRecords.DropDownStyle = ComboBoxStyle.DropDownList
                        Else
                            cmbPayslipRecords.Items.Add("No payslip records.")
                            cmbPayslipRecords.DropDownStyle = ComboBoxStyle.DropDownList
                        End If
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show($"Error loading payslip records: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' ===========================================================
    ' = HANDLE SELECTION CHANGE
    ' ===========================================================
    Private Sub cmbPayslipRecords_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbPayslipRecords.SelectedIndexChanged
        If TypeOf cmbPayslipRecords.SelectedItem IsNot String AndAlso cmbPayslipRecords.SelectedItem IsNot Nothing Then
            Dim item = cmbPayslipRecords.SelectedItem
            Dim payslipId As Integer = item.Id

            lblPayslipId.Text = payslipId.ToString()
            lblPayslipId.Visible = False
            LoadPayslipData(payslipId)
        End If
    End Sub

    ' ===========================================================
    ' = TOGGLE VISIBILITY
    ' ===========================================================
    Private Sub TogglePayslipDetails(isVisible As Boolean)
        lblGrossPay.Visible = isVisible
        lblBasicHours.Visible = isVisible
        lblBasicPay.Visible = isVisible
        lblOTHours.Visible = isVisible
        lblOTPay.Visible = isVisible
        lblIncomeTax.Visible = isVisible
        lblPagibig.Visible = isVisible
        lblSSS.Visible = isVisible
        lblTotalDeductions.Visible = isVisible
        lblNetPay.Visible = isVisible
        lblPayPeriodStart.Visible = isVisible
        lblPayPeriodEnd.Visible = isVisible
    End Sub

    ' ===========================================================
    ' = FORM NAVIGATION (same as before)
    ' ===========================================================
    Private Sub dashboard_Click(sender As Object, e As EventArgs) Handles dashb.Click
        Dim empDashboardForm As New EmployeeDashboard()
        empDashboardForm.empIDlbl.Text = "Employee ID: " + empIDlbl.Text.Replace("Employee ID: ", "").Trim()
        empDashboardForm.welcomelbl.Text = "Logged in as " + welcomelbl.Text.Replace("Logged in as ", "").Trim()
        empDashboardForm.positionlbl.Text = "Position: " + positionlbl.Text.Replace("Position: ", "").Trim()
        empDashboardForm.StartPosition = FormStartPosition.Manual
        empDashboardForm.Location = Me.Location
        empDashboardForm.Show()
        Me.Hide()
    End Sub

    Private Sub attendance_Click(sender As Object, e As EventArgs) Handles attendance.Click
        Dim attendanceForm As New EmployeeAttendance()
        attendanceForm.empIDlbl.Text = empIDlbl.Text
        attendanceForm.welcomelbl.Text = welcomelbl.Text
        attendanceForm.positionlbl.Text = positionlbl.Text
        attendanceForm.Location = Me.Location
        attendanceForm.Show()
        Me.Hide()
    End Sub

    Private Sub profile_Click(sender As Object, e As EventArgs) Handles profile.Click
        Dim profileForm As New EmployeeProfile()
        profileForm.empIDlbl.Text = empIDlbl.Text
        profileForm.welcomelbl.Text = welcomelbl.Text
        profileForm.positionlbl.Text = positionlbl.Text
        profileForm.StartPosition = FormStartPosition.Manual
        profileForm.Location = Me.Location
        profileForm.Show()
        Me.Hide()
    End Sub

    Private Sub checkInbtn_Click_1(sender As Object, e As EventArgs) Handles checkInbtn.Click
        Dim empCheckInForm As New EmployeeCheckIn()
        empCheckInForm.empIDlbl.Text = empIDlbl.Text
        empCheckInForm.welcomelbl.Text = welcomelbl.Text
        empCheckInForm.positionlbl.Text = positionlbl.Text
        empCheckInForm.StartPosition = FormStartPosition.Manual
        empCheckInForm.Location = Me.Location
        empCheckInForm.Show()
        Me.Hide()
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Dim landing As New LandingForm
        landing.StartPosition = FormStartPosition.Manual
        landing.Location = Me.Location
        landing.Show()
        Close()
    End Sub

    Dim fontPath As String = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Fonts), "arial.ttf")
    Dim bf As iTextSharp.text.pdf.BaseFont = iTextSharp.text.pdf.BaseFont.CreateFont(fontPath, iTextSharp.text.pdf.BaseFont.IDENTITY_H, iTextSharp.text.pdf.BaseFont.EMBEDDED)
    Dim normalFont As New iTextSharp.text.Font(bf, 12)

    Private Sub btnGeneratePDF_Click(sender As Object, e As EventArgs) Handles btnGeneratePDF.Click

        If String.IsNullOrEmpty(lblPayslipId.Text) OrElse lblPayslipId.Text = "N/A" Then
            MessageBox.Show("Please select a payslip record first.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        ' Optional: double-check if the ID exists in ComboBox items (compatible with anonymous types)
        Dim validIdFound As Boolean = False
        For Each item In cmbPayslipRecords.Items
            Dim idProp = item.GetType().GetProperty("Id")
            If idProp IsNot Nothing AndAlso idProp.GetValue(item).ToString() = lblPayslipId.Text Then
                validIdFound = True
                Exit For
            End If
        Next

        If Not validIdFound Then
            MessageBox.Show("Please select a valid payslip record first.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Try
            ' === Ensure a payslip is selected ===
            If String.IsNullOrEmpty(lblPayslipId.Text) Then
                MessageBox.Show("Please select a payslip record first.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Return
            End If

            ' === Create folder if not exists ===
            Dim folderPath As String = Path.Combine(Application.StartupPath, "Payslips")
            If Not Directory.Exists(folderPath) Then
                Directory.CreateDirectory(folderPath)
            End If

            ' === Create file path ===
            Dim filePath As String = Path.Combine(folderPath, $"Payslip_{lblPayslipId.Text}.pdf")

            ' === Create PDF document ===
            Dim doc As New Document(PageSize.A4, 50, 50, 50, 50)
            PdfWriter.GetInstance(doc, New FileStream(filePath, FileMode.Create))
            doc.Open()

            ' === Proper Unicode font that supports ₱ ===
            Dim fontPath As String = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Fonts), "arial.ttf")
            Dim bf As iTextSharp.text.pdf.BaseFont = iTextSharp.text.pdf.BaseFont.CreateFont(fontPath, iTextSharp.text.pdf.BaseFont.IDENTITY_H, iTextSharp.text.pdf.BaseFont.EMBEDDED)

            Dim titleFont As New iTextSharp.text.Font(bf, 16, iTextSharp.text.Font.BOLD)
            Dim labelFont As New iTextSharp.text.Font(bf, 12, iTextSharp.text.Font.BOLD)
            Dim valueFont As New iTextSharp.text.Font(bf, 12)

            ' === Helper function to safely format currency ===
            Dim formatPeso As Func(Of String, String) = Function(value As String)
                                                            If String.IsNullOrWhiteSpace(value) Then Return "₱0.00"
                                                            If value.Trim().StartsWith("₱") Then
                                                                Return value.Trim()
                                                            Else
                                                                Return "₱" & value.Trim()
                                                            End If
                                                        End Function

            ' === Centered Header ===
            Dim header As New Paragraph("Employee Payslip", titleFont)
            header.Alignment = Element.ALIGN_CENTER
            doc.Add(header)

            Dim genDate As New Paragraph($"Generated on {DateTime.Now:MMMM dd, yyyy}", valueFont)
            genDate.Alignment = Element.ALIGN_CENTER
            doc.Add(genDate)
            doc.Add(New Paragraph(" "))
            doc.Add(New Paragraph(New Chunk(New LineSeparator())))

            ' === Centered Employee Info ===
            Dim empInfo As New Paragraph("Employee Information", labelFont)
            empInfo.Alignment = Element.ALIGN_CENTER
            doc.Add(empInfo)
            doc.Add(New Paragraph($"Employee Name: {namelbl.Text}", valueFont))
            doc.Add(New Paragraph($"Pay Period: {lblPayPeriodStart.Text} - {lblPayPeriodEnd.Text}", valueFont))
            doc.Add(New Paragraph(" "))
            doc.Add(New Paragraph(New Chunk(New LineSeparator())))

            ' === Earnings ===
            Dim earningsTitle As New Paragraph("Earnings", labelFont)
            earningsTitle.Alignment = Element.ALIGN_CENTER
            doc.Add(earningsTitle)
            doc.Add(New Paragraph($"Basic Hours: {lblBasicHours.Text}", valueFont))
            doc.Add(New Paragraph($"Overtime Hours: {lblOTHours.Text}", valueFont))
            doc.Add(New Paragraph($"Basic Pay: {formatPeso(lblBasicPay.Text)}", valueFont))
            doc.Add(New Paragraph($"Overtime Pay: {formatPeso(lblOTPay.Text)}", valueFont))
            doc.Add(New Paragraph($"Gross Pay: {formatPeso(lblGrossPay.Text)}", valueFont))
            doc.Add(New Paragraph(" "))
            doc.Add(New Paragraph(New Chunk(New LineSeparator())))

            ' === Deductions ===
            Dim dedTitle As New Paragraph("Deductions", labelFont)
            dedTitle.Alignment = Element.ALIGN_CENTER
            doc.Add(dedTitle)
            doc.Add(New Paragraph($"Income Tax: {formatPeso(lblIncomeTax.Text)}", valueFont))
            doc.Add(New Paragraph($"Pag-IBIG: {formatPeso(lblPagibig.Text)}", valueFont))
            doc.Add(New Paragraph($"SSS: {formatPeso(lblSSS.Text)}", valueFont))
            doc.Add(New Paragraph($"Total Deductions: {formatPeso(lblTotalDeductions.Text)}", valueFont))
            doc.Add(New Paragraph(" "))
            doc.Add(New Paragraph(New Chunk(New LineSeparator())))

            ' === Net Pay (centered + bold) ===
            Dim netPay As New Paragraph($"Net Pay: {formatPeso(lblNetPay.Text)}", labelFont)
            netPay.Alignment = Element.ALIGN_CENTER
            doc.Add(netPay)

            doc.Close()
            MessageBox.Show($"Payslip PDF generated successfully at: {filePath}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

            ' === Open file automatically ===
            Process.Start(New ProcessStartInfo() With {
                .FileName = filePath,
                .UseShellExecute = True
            })

        Catch ex As Exception
            MessageBox.Show($"Error generating PDF: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

End Class
