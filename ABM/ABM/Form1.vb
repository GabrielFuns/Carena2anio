Public Class Form1

    Private Sub btnAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregar.Click
        Agregar()
    End Sub
    Private Sub Agregar()
        If TextBox1.Text = Nothing Or TextBox1.Text = " " Then Exit Sub
        ListBox1.Items.Add(TextBox1.Text)
        TextBox1.Clear()
        TextBox1.Focus()
    End Sub
    Private Sub btnBorrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBorrar.Click
        If ListBox1.SelectedIndex = -1 Then Exit Sub
        If TextBox1.Text = Nothing Or TextBox1.Text = " " Then Exit Sub
        ListBox1.Items.RemoveAt(ListBox1.SelectedIndex)
        TextBox1.Clear()
        TextBox1.Focus()
        ListBox1.ClearSelected()
        btnModificar.Enabled = False
        btnAgregar.Enabled = True
        btnBorrar.Enabled = False
    End Sub

    Private Sub btnModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificar.Click
        If ListBox1.SelectedIndex = -1 Then Exit Sub
        'Dim seleccionado As Integer = ListBox1.SelectedIndex
        'ListBox1.Items.Insert(seleccionado, TextBox1.Text)
        'ListBox1.Items.RemoveAt(ListBox1.SelectedIndex)
        ListBox1.Items.Item(ListBox1.SelectedIndex) = TextBox1.Text
        TextBox1.Clear()
        TextBox1.Focus()
        btnModificar.Enabled = False
        btnAgregar.Enabled = True
        btnBorrar.Enabled = False
    End Sub

    Private Sub ListBox1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ListBox1.Click
        TextBox1.Text = ListBox1.SelectedItem
        btnModificar.Enabled = True
        btnAgregar.Enabled = False
        btnBorrar.Enabled = True
    End Sub

    Private Sub Form1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Click
        ListBox1.ClearSelected()
        btnModificar.Enabled = False
        btnAgregar.Enabled = True
        btnBorrar.Enabled = False
    End Sub

    Private Sub btnMayuscula_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMayuscula.Click

    End Sub

    Private Sub TextBox1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBox1.KeyDown
        If e.KeyCode = Keys.Enter Then
            Agregar()
        End If
    End Sub
End Class
