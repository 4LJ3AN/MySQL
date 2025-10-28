Imports System.Runtime.InteropServices

Public Class EmployeePayslip
    Private updatingDate As Boolean = False

    Private Sub payslip_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SetupPayrollDatePicker()
    End Sub

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

    Private Sub dashb_Click(sender As Object, e As EventArgs) Handles dashb.Click
        Dim empDashboardForm As New EmployeeDashboard
        empDashboardForm.StartPosition = FormStartPosition.Manual
        empDashboardForm.Location = Location
        empDashboardForm.Show()
        Hide()

    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Dim landing As New LandingForm
        landing.StartPosition = FormStartPosition.Manual
        landing.Location = Me.Location

        landing.Show()
        Close()
    End Sub

    Private Sub attendance_Click(sender As Object, e As EventArgs) Handles attendance.Click
        Dim attendanceForm As New EmployeeAttendance
        attendanceForm.StartPosition = FormStartPosition.Manual
        attendanceForm.Location = Location
        attendanceForm.Show()
        Hide()
    End Sub

    Private Sub checkIn_Click(sender As Object, e As EventArgs) Handles checkInbtn.Click
        Dim checkInForm As New EmployeeCheckIn
        checkInForm.StartPosition = FormStartPosition.Manual
        checkInForm.Location = Location
        checkInForm.Show()
        Hide()
    End Sub

    Private Sub profile_Click(sender As Object, e As EventArgs) Handles profile.Click
        Dim profileForm As New EmployeeProfile()
        profileForm.StartPosition = FormStartPosition.Manual
        profileForm.Location = Me.Location
        profileForm.Show()
        Me.Hide()
    End Sub
End Class