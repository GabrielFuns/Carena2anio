Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        TextBox1.MaxLength = 320
    End Sub

    Private Sub TextBox1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox1.KeyPress
        Dim pos As Integer = TextBox1.SelectionStart
        Dim ultima As Char = TextBox1.Text.Substring(TextBox1.Text.Length - 1, 1)

        If Not Char.IsControl(e.KeyChar) And Not Char.IsNumber(e.KeyChar) And Not Char.IsLetter(e.KeyChar) And Not e.KeyChar = "." And Not e.KeyChar = "-" And Not e.KeyChar = "_" And Not e.KeyChar = "@" Then
            e.Handled = True
        End If

        If e.KeyChar = "." And TextBox1.Text.IndexOf(".") > -1 Then
            e.Handled = True
            MsgBox("Solo se permite 1 punto")
            Exit Sub
        End If

        If ultima = "@" And pos = 64 Then
            e.Handled = True
            MsgBox("No puede ser mas largo el Nombre de usuario")
        End If

    End Sub

    Private Sub TextBox1_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox1.Validated
        Dim primera As Char = TextBox1.Text.Substring(0, 1)
        Dim ultima As Char = TextBox1.Text.Substring(TextBox1.Text.Length - 1, 1)

        If primera = "@" Or primera = "." Then
            MsgBox("No se permite ese caracter en esa pocicion.")
            Exit Sub
        End If

        If ultima = "@" Or ultima = "." Then
            MsgBox("No se permite ese caracter en esa pocicion.")
            Exit Sub
        End If
    End Sub
End Class
