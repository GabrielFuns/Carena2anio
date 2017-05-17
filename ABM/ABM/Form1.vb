Imports System.Xml
Public Class Form1

    Private Sub btnAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregar.Click 'evento
        Agregar()
        ListBox1.ClearSelected()
    End Sub

    Private Sub Agregar() 'metodo
        If TextBox1.Text = Nothing Or TextBox1.Text = " " Then Exit Sub
        ListBox1.Items.Add(TextBox1.Text)
        TextBox1.Clear()
        TextBox1.Focus()
    End Sub

    Private Sub Modificar() 'metodo
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

    Private Sub btnBorrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBorrar.Click ' evento
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
        Modificar()
        ListBox1.ClearSelected()
    End Sub

    Private Sub ListBox1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ListBox1.Click
        TextBox1.Text = ListBox1.SelectedItem
        btnModificar.Enabled = True
        btnAgregar.Enabled = False
        btnBorrar.Enabled = True
    End Sub

    Private Sub Form1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Click ' eventos
        ListBox1.ClearSelected()
        btnModificar.Enabled = False
        btnAgregar.Enabled = True
        btnBorrar.Enabled = False
    End Sub

    Private Sub btnMayuscula_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMayuscula.Click ' eventos
        Mayuscula()
    End Sub

    Private Sub Mayuscula() ' metodo
        For i As Integer = 0 To ListBox1.Items.Count - 1
            ListBox1.Items.Item(i) = ListBox1.Items.Item(i).ToString.ToUpper
        Next
        ListBox1.ClearSelected()
    End Sub
    Private Sub TextBox1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox1.KeyPress 'eventos

        If ListBox1.SelectedItem - 1 Then
            If e.KeyChar = Chr(Keys.Enter) Then btnAgregar_Click(sender, e)
        Else
            If e.KeyChar = Chr(Keys.Enter) Then btnModificar_Click(sender, e)
        End If

    End Sub

    Private Sub btnEnumerar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEnumerar.Click
        For i As Integer = 0 To ListBox1.Items.Count - 1
            ListBox1.Items.Item(i) = CStr(i + 1) + " " + ListBox1.Items.Item(i).ToString
        Next
    End Sub

    Private Sub btnGrabarXML_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGrabarXML.Click

        Dim ruta As String = CurDir.Substring(0, CurDir().Length - 9)
        Dim escritor As New XmlTextWriter(ruta + "Lista.xml", System.Text.Encoding.UTF8)
        escritor.WriteStartDocument(True)
        escritor.Formatting = Formatting.Indented
        escritor.Indentation = 4
        escritor.WriteStartElement("Elemento")
        For x As Integer = 0 To ListBox1.Items.Count - 1
            escritor.WriteStartElement("Nombre")
            escritor.WriteString(ListBox1.Items.Item(x))
            escritor.WriteEndElement()
        Next
        escritor.WriteEndElement()
        escritor.WriteEndDocument()
        escritor.Close()

    End Sub
End Class
