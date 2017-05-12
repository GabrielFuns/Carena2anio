Public Class Form1
    Dim pos As Integer = 0
    Dim cuenta As Integer = 0
    Dim dominio As Integer = 0
    Dim flag As Boolean = False
    Dim ultima As Char = Nothing

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        TextBox1.MaxLength = 320
    End Sub

    Private Sub TextBox1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox1.KeyPress

        If Not Char.IsControl(e.KeyChar) And Not Char.IsNumber(e.KeyChar) And Not Char.IsLetter(e.KeyChar) And Not e.KeyChar = "." And Not e.KeyChar = "-" And Not e.KeyChar = "_" And Not e.KeyChar = "@" Then
            e.Handled = True
        End If
        pos = TextBox1.SelectionStart
        If pos > 1 Then
            ultima = TextBox1.Text.Substring(TextBox1.Text.Length - 1, 1)
        End If
        If ultima = "@" Then
            flag = True
        End If

        If flag = False Then
            cuenta += 1
        End If

        If flag = True Then
            dominio += 1
        End If

        If cuenta = 65 Then
            e.Handled = True
            MsgBox("No puede ser mas largo el Nombre de usuario")
            Exit Sub
        End If

        If dominio = 255 Then
            e.Handled = True
            MsgBox("No puede ser mas largo el Dominio")
            Exit Sub
        End If

        If e.KeyChar = "." And TextBox1.Text.IndexOf(".") > -1 Then
            e.Handled = True
        End If

        If flag = True And dominio = 1 And e.KeyChar = "." Then
            e.Handled = True
            MsgBox("No se permite Punto en esa pocicion")
        End If

        If flag = False And cuenta = 1 And e.KeyChar = "@" Then
            e.Handled = True
            MsgBox("No se permite @ en esa pocicion")
        End If

        If flag = False And cuenta = 1 And e.KeyChar = "." Then
            e.Handled = True
            MsgBox("No se permite Punto en esa pocicion")
        End If

        If flag = True And ultima = "." Then
            e.Handled = True
            MsgBox("No se permite Punto en esa pocicion")
        End If

        If flag = True And ultima = "@" Then
            e.Handled = True
            MsgBox("No se permite @ en esa pocicion")
        End If

        If flag = False And ultima = "." Then
            e.Handled = True
            MsgBox("No se permite Punto en esa pocicion")
        End If

    End Sub
End Class
