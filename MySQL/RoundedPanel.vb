Imports System.Drawing.Drawing2D

Public Class RoundedPanel
    Inherits Panel

    Protected Overrides Sub OnPaint(e As PaintEventArgs)
        MyBase.OnPaint(e)

        Dim radius As Integer = 25  ' Corner roundness
        Dim borderThickness As Integer = 2  ' Border thickness

        ' Enable smooth edges
        e.Graphics.SmoothingMode = SmoothingMode.AntiAlias

        ' Fix: shrink drawing area to avoid cutting off bottom/right borders
        Dim rect As New Rectangle(0, 0, Me.Width - 1, Me.Height - 1)

        ' Build rounded path
        Using path As New GraphicsPath()
            path.StartFigure()
            path.AddArc(New Rectangle(rect.X, rect.Y, radius, radius), 180, 90)
            path.AddArc(New Rectangle(rect.Right - radius, rect.Y, radius, radius), 270, 90)
            path.AddArc(New Rectangle(rect.Right - radius, rect.Bottom - radius, radius, radius), 0, 90)
            path.AddArc(New Rectangle(rect.X, rect.Bottom - radius, radius, radius), 90, 90)
            path.CloseFigure()

            ' Set rounded region (actual panel shape)
            Me.Region = New Region(path)

            ' Fill background to remove border artifacts
            Using brush As New SolidBrush(Me.BackColor)
                e.Graphics.FillPath(brush, path)
            End Using

            ' Draw the consistent border (shifted inside by 1 pixel)
            Using pen As New Pen(Color.Gray, borderThickness)
                pen.Alignment = PenAlignment.Inset  ' Fix: ensures border fully visible inside
                e.Graphics.DrawPath(pen, path)
            End Using
        End Using
    End Sub
End Class
