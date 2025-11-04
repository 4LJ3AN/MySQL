Public Class AttendanceItemControl
    Public Sub New()
        InitializeComponent()
        Me.Height = 60 ' More height for better spacing
        Me.BorderStyle = BorderStyle.FixedSingle
        Me.Margin = New Padding(0, 5, 0, 5) ' More vertical spacing
        Me.Anchor = AnchorStyles.Left Or AnchorStyles.Right Or AnchorStyles.Top
        Me.BackColor = Color.White
    End Sub

    Public Sub SetAttendanceData(attendanceDate As Date, data As AttendanceData)
        Me.Controls.Clear()

        ' Use a table layout for better organization
        Dim mainPanel As New Panel() With {
            .Dock = DockStyle.Fill,
            .Padding = New Padding(10)
        }

        ' Date and Day (Left Section)
        Dim lblDate As New Label() With {
            .Text = attendanceDate.ToString("MMM dd, yyyy"),
            .Location = New Point(15, 8),
            .Width = 120,
            .Font = New Font("Arial", 10, FontStyle.Bold),
            .ForeColor = Color.DarkSlateGray
        }

        Dim lblDay As New Label() With {
            .Text = attendanceDate.ToString("dddd"),
            .Location = New Point(15, 28),
            .Width = 120,
            .Font = New Font("Arial", 9),
            .ForeColor = Color.Gray
        }

        ' Status with better styling (Middle Section)
        Dim lblStatus As New Label() With {
            .Text = data.Status.ToUpper(),
            .Location = New Point(150, 15),
            .Size = New Size(80, 30),
            .TextAlign = ContentAlignment.MiddleCenter,
            .Font = New Font("Arial", 9, FontStyle.Bold),
            .ForeColor = Color.White
        }

        ' Time information (Right Section)
        Dim lblTime As New Label() With {
            .Text = GetTimeText(data),
            .Location = New Point(250, 8),
            .Width = 180,
            .Font = New Font("Arial", 9, FontStyle.Regular),
            .ForeColor = Color.DimGray
        }

        Dim lblOT As New Label() With {
            .Text = GetOTText(data),
            .Location = New Point(250, 28),
            .Width = 180,
            .Font = New Font("Arial", 9, FontStyle.Regular),
            .ForeColor = If(data.OTHours > 0, Color.DarkOrange, Color.DimGray)
        }

        ' Additional info label for holidays/absent
        If data.Status = "Holiday" Or data.Status = "Absent" Then
            Dim lblInfo As New Label() With {
                .Text = GetAdditionalInfo(data),
                .Location = New Point(450, 15),
                .Width = 120,
                .Font = New Font("Arial", 9, FontStyle.Italic),
                .ForeColor = Color.Gray,
                .TextAlign = ContentAlignment.MiddleRight
            }
            mainPanel.Controls.Add(lblInfo)
        Else
            ' Hours summary for present/late
            Dim lblHours As New Label() With {
                .Text = $"{data.TotalHours:F1} total hours",
                .Location = New Point(450, 15),
                .Width = 120,
                .Font = New Font("Arial", 9, FontStyle.Regular),
                .ForeColor = Color.DimGray,
                .TextAlign = ContentAlignment.MiddleRight
            }
            mainPanel.Controls.Add(lblHours)
        End If

        ' Set status-specific styling
        SetStatusStyling(lblStatus, data.Status)

        ' Add all controls
        mainPanel.Controls.AddRange({lblDate, lblDay, lblStatus, lblTime, lblOT})
        Me.Controls.Add(mainPanel)
    End Sub

    Private Function GetTimeText(data As AttendanceData) As String
        Select Case data.Status
            Case "Present", "Late"
                Return $"🕒 {data.TimeIn} - {data.TimeOut}"
            Case "Absent"
                Return "❌ No attendance record"
            Case "Holiday"
                Return "🎉 Sunday - Day Off"
            Case Else
                Return "📝 N/A"
        End Select
    End Function

    Private Function GetOTText(data As AttendanceData) As String
        If data.Status = "Present" Or data.Status = "Late" Then
            If data.OTHours > 0 Then
                Return $"🔥 {data.OTHours:F1} overtime hours"
            Else
                Return "✅ Regular hours"
            End If
        Else
            Return ""
        End If
    End Function

    Private Function GetAdditionalInfo(data As AttendanceData) As String
        Select Case data.Status
            Case "Holiday" : Return "🌴 Weekend"
            Case "Absent" : Return "📋 No record"
            Case Else : Return ""
        End Select
    End Function

    Private Sub SetStatusStyling(lblStatus As Label, status As String)
        Select Case status
            Case "Present"
                lblStatus.BackColor = Color.FromArgb(76, 175, 80) ' Nice green
                Me.BackColor = Color.FromArgb(240, 255, 240)
            Case "Late"
                lblStatus.BackColor = Color.FromArgb(255, 152, 0) ' Orange
                Me.BackColor = Color.FromArgb(255, 248, 225)
            Case "Absent"
                lblStatus.BackColor = Color.FromArgb(244, 67, 54) ' Red
                Me.BackColor = Color.FromArgb(255, 235, 238)
            Case "Holiday"
                lblStatus.BackColor = Color.FromArgb(33, 150, 243) ' Blue
                Me.BackColor = Color.FromArgb(227, 242, 253)
        End Select

        ' Add rounded corners effect (visual only)
        lblStatus.Font = New Font("Arial", 9, FontStyle.Bold)
    End Sub
End Class