Public Class wriButton
    Inherits Button
    Private flag As Boolean = False
    Public Sub New()
        MyBase.New()
        Me.Font = New Font(SystemFonts.DefaultFont.Name, 9.5F)
    End Sub
    Protected Overrides Sub OnMouseClick(e As MouseEventArgs)
        MyBase.OnMouseClick(e)
        If (flag = False) Then
            flag = True
            Me.BackColor = Color.Yellow
        Else
            flag = False
            Me.BackColor = Nothing
        End If
    End Sub

End Class
