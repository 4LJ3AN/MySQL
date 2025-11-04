Imports System.Runtime.InteropServices
Imports MySQL.Data.MySqlClient
Imports System.Diagnostics

Public Class EmployeePayslip
    Private updatingDate As Boolean = False

    Private Sub payslip_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SetupPayrollDatePicker()
    End Sub

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

                ' Prevent duplicates for this month’s 15th
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

                ' Get all employees
                Dim empCmd As New MySqlCommand("SELECT employeeid, hourlyrate FROM employees", conn)
                Using reader As MySqlDataReader = empCmd.ExecuteReader()
                    While reader.Read()
                        Dim empId As Integer = reader("employeeid")
                        Dim hourlyRate As Double = reader("hourlyrate")

                        ' Compute Gross Pay (1st–15th of current month)
                        Dim grossPay As Double = ComputeGrossPay(empId, conn)
                        Dim totalDeductions As Double = CalculateDeductions(grossPay)
                        Dim netPay As Double = grossPay - totalDeductions

                        ' Insert payslip
                        Dim insertCmd As New MySqlCommand("
                        INSERT INTO payslips (employeeid, grosspay, deductions, netpay, generated_on)
                        VALUES (@empid, @gross, @ded, @net, NOW());
                    ", conn)
                        insertCmd.Parameters.AddWithValue("@empid", empId)
                        insertCmd.Parameters.AddWithValue("@gross", grossPay)
                        insertCmd.Parameters.AddWithValue("@ded", totalDeductions)
                        insertCmd.Parameters.AddWithValue("@net", netPay)

                        insertCmd.ExecuteNonQuery()
                        Debug.WriteLine($"[INFO] Payslip generated for Employee {empId}: Gross={grossPay:F2}, Deductions={totalDeductions:F2}, Net={netPay:F2}")
                    End While
                End Using

                Debug.WriteLine("[INFO] All payslips generated successfully.")
            End Using

        Catch ex As Exception
            Debug.WriteLine($"[ERROR] Error generating payslips: {ex.Message}")
        End Try
    End Sub

    ' ---------------------------
    ' Helper Functions
    ' ---------------------------

    Private Function CalculateDeductions(grossPay As Double) As Double
        Dim incomeTax As Double = grossPay * 0.1
        Dim pagibig As Double = grossPay * 0.01
        Dim sss As Double = grossPay * 0.02
        Return incomeTax + pagibig + sss
    End Function

    Private Function ComputeGrossPay(empId As Integer, conn As MySqlConnection) As Double
        Dim startDate As New Date(Date.Now.Year, Date.Now.Month, 1)
        Dim endDate As New Date(Date.Now.Year, Date.Now.Month, 15)

        Dim cmd As New MySqlCommand("
        SELECT SUM(totalhours) 
        FROM attendance 
        WHERE employeeid = @empid 
        AND date BETWEEN @startDate AND @endDate;
    ", conn)
        cmd.Parameters.AddWithValue("@empid", empId)
        cmd.Parameters.AddWithValue("@startDate", startDate.ToString("yyyy-MM-dd"))
        cmd.Parameters.AddWithValue("@endDate", endDate.ToString("yyyy-MM-dd"))

        Dim totalHoursObj = cmd.ExecuteScalar()
        Dim totalHours As Double = If(IsDBNull(totalHoursObj), 0, Convert.ToDouble(totalHoursObj))

        ' Compute gross pay
        Dim hourlyRateCmd As New MySqlCommand("
        SELECT hourlyrate FROM employees WHERE employeeid = @empid;
    ", conn)
        hourlyRateCmd.Parameters.AddWithValue("@empid", empId)
        Dim hourlyRate As Double = Convert.ToDouble(hourlyRateCmd.ExecuteScalar())

        Return totalHours * hourlyRate
    End Function

    Private Sub SetupPayrollDatePicker()
        DateTimePicker1.Format = DateTimePickerFormat.Custom
        DateTimePicker1.CustomFormat = "MMMM yyyy"
        DateTimePicker1.ShowUpDown = False
        DateTimePicker1.TabStop = False

        DateTimePicker1.Value = New DateTime(DateTime.Now.Year, DateTime.Now.Month, 15)
        DateTimePicker1.MinDate = New DateTime(2000, 1, 15)
        DateTimePicker1.MaxDate = New DateTime(2030, 12, 15)
    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged
        ' Prevent recursive calls
        If updatingDate Then Return

        ' Always force the day to be 15th
        If DateTimePicker1.Value.Day <> 15 Then
            updatingDate = True
            DateTimePicker1.Value = New DateTime(DateTimePicker1.Value.Year, DateTimePicker1.Value.Month, 15)
            updatingDate = False
        End If
    End Sub

    Private Sub DateTimePicker1_CloseUp(sender As Object, e As EventArgs) Handles DateTimePicker1.CloseUp
        ' Ensure day is 15th when calendar closes
        If DateTimePicker1.Value.Day <> 15 Then
            updatingDate = True
            DateTimePicker1.Value = New DateTime(DateTimePicker1.Value.Year, DateTimePicker1.Value.Month, 15)
            updatingDate = False
        End If
    End Sub

    ' Property to get the selected payroll date (always 15th)
    Public ReadOnly Property SelectedPayrollDate As DateTime
        Get
            Return DateTimePicker1.Value
        End Get
    End Property

    ' Property to get just the month/year for display
    Public ReadOnly Property SelectedPayrollMonthYear As String
        Get
            Return DateTimePicker1.Value.ToString("MMMM yyyy")
        End Get
    End Property

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
        attendanceForm.empIDlbl.Text = "Employee ID: " + empIDlbl.Text.Replace("Employee ID: ", "").Trim()
        attendanceForm.welcomelbl.Text = "Logged in as " + welcomelbl.Text.Replace("Logged in as ", "").Trim()
        attendanceForm.positionlbl.Text = "Position: " + positionlbl.Text.Replace("Position: ", "").Trim()
        attendanceForm.Location = Me.Location
        attendanceForm.Show()
        Me.Hide()
    End Sub

    Private Sub profile_Click(sender As Object, e As EventArgs) Handles profile.Click
        Dim profileForm As New EmployeeProfile()
        profileForm.empIDlbl.Text = "Employee ID: " + empIDlbl.Text.Replace("Employee ID: ", "").Trim()
        profileForm.welcomelbl.Text = "Logged in as " + welcomelbl.Text.Replace("Logged in as ", "").Trim()
        profileForm.positionlbl.Text = "Position: " + positionlbl.Text.Replace("Position: ", "").Trim()
        profileForm.StartPosition = FormStartPosition.Manual
        profileForm.Location = Me.Location
        profileForm.Show()
        Me.Hide()
    End Sub

    Private Sub checkInbtn_Click_1(sender As Object, e As EventArgs) Handles checkInbtn.Click
        Dim empCheckInForm As New EmployeeCheckIn()
        empCheckInForm.empIDlbl.Text = "Employee ID: " + empIDlbl.Text.Replace("Employee ID: ", "").Trim()
        empCheckInForm.welcomelbl.Text = "Logged in as " + welcomelbl.Text.Replace("Logged in as ", "").Trim()
        empCheckInForm.positionlbl.Text = "Position: " + positionlbl.Text.Replace("Position: ", "").Trim()
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
End Class