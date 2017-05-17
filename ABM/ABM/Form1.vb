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
        '= AppDomain.CurrentDomain.BaseDirectory

        'Creamos el objeto escritor para crear y grabar el xml.
        Dim escritor As New XmlTextWriter(ruta + "Lista.xml", System.Text.Encoding.UTF8)

        'Configuración para la tabulación y el formateo.
        escritor.WriteStartDocument(True)
        escritor.Formatting = Formatting.Indented
        escritor.Indentation = 4

        'escribo el elemento Lista <Elemento>
        escritor.WriteStartElement("Elemento")

        For x As Integer = 0 To ListBox1.Items.Count - 1
            'Escribo el elemento Nombre <Nombre>.
            escritor.WriteStartElement("Nombre")
            'Escribo la cadena que va en elemento Nombre.
            escritor.WriteString(ListBox1.Items.Item(x))
            'Cierro el elemneto nombre <Nombre>
            escritor.WriteEndElement()
        Next

        'Cierro el elemento alumnos </lista>
        escritor.WriteEndElement()
        'Graba en el disco.
        escritor.WriteEndDocument()
        'Cierra el objeto escritor creado para manipular el xml.
        escritor.Close()

    End Sub

    Private Sub btnLeerXML_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLeerXML.Click
        Leer_xml()
    End Sub
    Private Sub Leer_xml()
        Dim xmld As New XmlDocument
        Dim ListaNodos As XmlNodeList
        Dim nodo As XmlNode

        'Esto me da la ruta ../Debug/Bin/ sino lo entienden ponga la ruta absoluta algo asi como C:\..
        Dim ruta As String '= AppDomain.CurrentDomain.BaseDirectory
        ruta = CurDir().Substring(0, CurDir().Length - 9)

        'Cargamos el documento XML
        xmld.Load(ruta & "Lista.xml")

        'Cargamos la lista de nodos Nombre, observe que hay que colocar el nivel
        'superior alumnos respetando minúsculas y mayúsculas sino no anda.
        ListaNodos = xmld.SelectNodes("/Elemento/Nombre")

        'Recorremos cada nodo con un for para recorrer colecciones,
        'osea padron es una coleccion de nombres.
        'A medida que recuperamos un nombre lo agregamos al ListBox.
        For Each nodo In ListaNodos

            'Aca se agrega en el ListBox.
            ListBox1.Items.Add(nodo.InnerText)

        Next

    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Leer_xml()
    End Sub
End Class
