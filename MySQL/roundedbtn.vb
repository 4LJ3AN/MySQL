Imports System.Drawing.Drawing2D

Public Class RoundedButton
    Inherits Button

    ' ====== PROPERTIES ======
    Public Property BorderRadius As Integer = 20
    Public Property BorderColor As Color = Color.Gray
    Public Property BorderSize As Integer = 1

    Public Property HoverColor As Color = Color.LightGray
    Public Property ClickColor As Color = Color.DarkGray
    Public Property SelectedColor As Color = Color.Silver

    Private isHovered As Boolean = False
    Private isPressed As Boolean = False
    Private isSelected As Boolean = False

    ' Shared reference to the last clicked button
    Private Shared lastClicked As RoundedButton = Nothing
    Private selectionTimer As Timer

    Public Sub New()
        Me.FlatStyle = FlatStyle.Flat
        Me.FlatAppearance.BorderSize = 0
        Me.DoubleBuffered = True

        ' Initialize timer to auto-clear selection
        selectionTimer = New Timer()
        selectionTimer.Interval = 300 ' 300ms - enough time to see the click effect
        selectionTimer.Enabled = False
        AddHandler selectionTimer.Tick, AddressOf SelectionTimer_Tick
    End Sub

    Private Sub SelectionTimer_Tick(sender As Object, e As EventArgs)
        selectionTimer.Stop()
        ClearSelection()
    End Sub

    ' Method to clear selection state
    Public Sub ClearSelection()
        isSelected = False
        If lastClicked Is Me Then
            lastClicked = Nothing
        End If
        Me.Invalidate()
    End Sub

    ' ====== EVENTS ======
    Protected Overrides Sub OnMouseEnter(e As EventArgs)
        MyBase.OnMouseEnter(e)
        isHovered = True
        Me.Invalidate()
    End Sub

    Protected Overrides Sub OnMouseLeave(e As EventArgs)
        MyBase.OnMouseLeave(e)
        isHovered = False
        Me.Invalidate()
    End Sub

    Protected Overrides Sub OnMouseDown(mevent As MouseEventArgs)
        MyBase.OnMouseDown(mevent)
        isPressed = True
        Me.Invalidate()
    End Sub

    Protected Overrides Sub OnMouseUp(mevent As MouseEventArgs)
        MyBase.OnMouseUp(mevent)
        isPressed = False

        ' Mark this button as selected, deselect previous
        If lastClicked IsNot Nothing AndAlso lastClicked IsNot Me Then
            lastClicked.ClearSelection()
        End If

        lastClicked = Me
        isSelected = True
        Me.Invalidate()

        ' Start timer to auto-clear selection
        selectionTimer.Start()
    End Sub

    ' ====== PAINT ======
    Protected Overrides Sub OnPaint(e As PaintEventArgs)
        e.Graphics.SmoothingMode = SmoothingMode.AntiAlias

        Dim rect As New Rectangle(0, 0, Me.Width - 1, Me.Height - 1)
        Dim path As GraphicsPath = GetRoundedPath(rect, BorderRadius)
        Me.Region = New Region(path)

        ' Determine fill color
        Dim fillColor As Color = Me.BackColor
        If isPressed Then
            fillColor = ClickColor
        ElseIf isSelected Then
            fillColor = SelectedColor
        ElseIf isHovered Then
            fillColor = HoverColor
        End If

        ' Fill button
        Using brush As New SolidBrush(fillColor)
            e.Graphics.FillPath(brush, path)
        End Using

        ' Border
        If BorderSize > 0 Then
            Using pen As New Pen(BorderColor, BorderSize)
                pen.Alignment = PenAlignment.Inset
                e.Graphics.DrawPath(pen, path)
            End Using
        End If

        ' Text
        TextRenderer.DrawText(e.Graphics, Me.Text, Me.Font, rect, Me.ForeColor,
                              TextFormatFlags.HorizontalCenter Or TextFormatFlags.VerticalCenter)
    End Sub

    Private Function GetRoundedPath(rect As Rectangle, radius As Integer) As GraphicsPath
        Dim path As New GraphicsPath()
        Dim d As Integer = radius * 2
        path.StartFigure()
        path.AddArc(rect.X, rect.Y, d, d, 180, 90)
        path.AddArc(rect.Right - d, rect.Y, d, d, 270, 90)
        path.AddArc(rect.Right - d, rect.Bottom - d, d, d, 0, 90)
        path.AddArc(rect.X, rect.Bottom - d, d, d, 90, 90)
        path.CloseFigure()
        Return path
    End Function

    Protected Overrides Sub Dispose(disposing As Boolean)
        If disposing Then
            selectionTimer?.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub
End Class