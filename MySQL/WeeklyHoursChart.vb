Imports System.Drawing
Imports System.Windows.Forms

Public Class WeeklyHoursChart
    Inherits Panel

    Private _hoursData As New Dictionary(Of String, Double) From {
        {"Mon", 0}, {"Tue", 0}, {"Wed", 0}, {"Thu", 0}, {"Fri", 0}, {"Sat", 0}
    }

    Public Property BarColor As Color = Color.SteelBlue
    Public Property AxisColor As Color = Color.Black
    Public Property TextColor As Color = Color.Black
    Public Property YStep As Double = 2.0 ' Interval for Y-axis grid lines
    Public Property AutoScale As Boolean = True ' Enable dynamic scaling

    ' Update data dynamically
    Public Sub SetHoursData(data As Dictionary(Of String, Double))
        For Each day In _hoursData.Keys.ToList()
            If data.ContainsKey(day) Then
                _hoursData(day) = data(day)
            Else
                _hoursData(day) = 0
            End If
        Next
        Me.Invalidate() ' Refresh the chart
    End Sub

    Protected Overrides Sub OnPaint(e As PaintEventArgs)
        MyBase.OnPaint(e)
        Dim g As Graphics = e.Graphics
        g.SmoothingMode = Drawing2D.SmoothingMode.AntiAlias
        g.Clear(Me.BackColor)

        Dim margin As Integer = 50 ' space for Y labels
        Dim chartWidth As Integer = Me.Width - margin - 20
        Dim chartHeight As Integer = Me.Height - margin - 20
        Dim barWidth As Integer = CInt(chartWidth / _hoursData.Count * 0.4) ' smaller bars
        Dim gap As Integer = CInt(chartWidth / _hoursData.Count * 0.6) ' bigger gaps

        ' Determine MaxHours dynamically if AutoScale is enabled
        Dim maxValue As Double = If(_hoursData.Values.Count > 0, _hoursData.Values.Max(), 8)
        Dim MaxHours As Double
        If AutoScale Then
            ' Round up to nearest multiple of YStep and add one extra step for headroom
            MaxHours = (Math.Ceiling(maxValue / YStep) + 1) * YStep
            If MaxHours = 0 Then MaxHours = YStep ' prevent zero MaxHours
        Else
            MaxHours = 8
        End If

        ' Draw axes
        Dim axisPen As New Pen(AxisColor, 2)
        g.DrawLine(axisPen, margin, 10, margin, chartHeight + 10) ' Y axis
        g.DrawLine(axisPen, margin, chartHeight + 10, chartWidth + margin, chartHeight + 10) ' X axis

        ' Draw Y-axis grid lines and labels
        Dim steps As Integer = CInt(Math.Ceiling(MaxHours / YStep))
        For i As Integer = 0 To steps
            Dim yVal As Double = i * YStep
            Dim yPos As Integer = chartHeight + 10 - CInt((yVal / MaxHours) * chartHeight)

            ' Grid line
            Using gridPen As New Pen(Color.LightGray, 1)
                gridPen.DashStyle = Drawing2D.DashStyle.Dash
                g.DrawLine(gridPen, margin, yPos, chartWidth + margin, yPos)
            End Using

            ' Y label
            Dim yLabel As String = yVal.ToString("0.#")
            Dim sf As New StringFormat() With {.Alignment = StringAlignment.Far, .LineAlignment = StringAlignment.Center}
            g.DrawString(yLabel, Me.Font, New SolidBrush(TextColor), margin - 5, yPos, sf)
        Next

        ' Draw bars and day labels
        Dim iBar As Integer = 0
        For Each kvp In _hoursData
            Dim day As String = kvp.Key
            Dim hours As Double = kvp.Value
            Dim barHeight As Integer = CInt((hours / MaxHours) * chartHeight)
            Dim barX As Integer = margin + iBar * (barWidth + gap)
            Dim barY As Integer = (chartHeight + 10) - barHeight

            Using brush As New SolidBrush(BarColor)
                g.FillRectangle(brush, barX, barY, barWidth, barHeight)
            End Using

            ' Draw day labels below X axis
            Dim sf As New StringFormat() With {.Alignment = StringAlignment.Center}
            g.DrawString(day, Me.Font, New SolidBrush(TextColor),
                CSng(barX + barWidth / 2), CSng(chartHeight + 12), sf)

            iBar += 1
        Next
    End Sub

End Class
