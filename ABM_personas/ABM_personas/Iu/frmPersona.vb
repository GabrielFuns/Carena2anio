Public Class frmPersona
    Dim operacion_ As String
    Dim persona As New PersonaClass
    Public Property operacion() As String
        Get
            Return operacion_
        End Get
        Set(ByVal value As String)
            operacion_ = value
        End Set
    End Property
    Dim indice_ As Byte
    Public Property indice() As Byte
        Get
            Return indice_
        End Get
        Set(ByVal value As Byte)
            indice_ = value
        End Set
    End Property

    Private Sub ACEPTAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ACEPTAR.Click
        persona.numerodocumento = CInt(txtDNI.Text)
        persona.tipodocumento = txtTipoDNI.Text
        persona.tipopersona = txtPersona.Text
        persona.tipoclave = txtClave.Text
        persona.estadoclave = txtEstadoClave.Text
        persona.nombreapellido = txtNombre.Text
        persona.direccion = txtDireccion.Text
        persona.localidad = txtLocalidad.Text
        persona.idprovincia = cbbxProvincia.SelectedItem
        persona.codpostal = CInt(txtPostal.Text)
        persona.IdDependencia = txtDependencias.Text
        persona.mescierre = txtCierre.Text
        persona.fechadeinscripcion = txtIncripcion.Text

        Select Case operacion_
            Case "Alta"
                lst.Add(persona)

            Case "Baja"
                lst.RemoveAt(indice_)

            Case "Modificar"
                lst.Item(indice_).id = persona.id
                lst.Item(indice_).descripcion = MiArticulo.descripcion
                lst.Item(indice_).stock = MiArticulo.stock
                lst.Item(indice_).unidad = MiArticulo.unidad
                lst.Item(indice_).utilidad = MiArticulo.utilidad
                lst.Item(indice_).iva = MiArticulo.iva

        End Select

    End Sub

    Private Sub CANCELAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CANCELAR.Click
        Me.Close()
    End Sub
    Private Sub ComboBox1_SelectionChangeCommitted(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbbxProvincia.SelectionChangeCommitted

        persona.datosCuit(cbbxCuil.SelectedItem.ToString)

        If persona.idprovincia > 0 Then
            cbbxProvincia.SelectedIndex = CInt(persona.idprovincia)
        End If

        txtLocalidad.Text = persona.localidad
        txtPostal.Text = persona.codpostal
        txtDependencias.Text = persona.IdDependencia
        txtCierre.Text = persona.mescierre

    End Sub


    Private Sub buscarcuitcuil_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles buscarcuitcuil.Click
        cbbxCuil.DataSource = persona.listaCuits(txtDNI.Text)

        If cbbxCuil.Items.Count = 1 Then
            llenarForm()
        End If

    End Sub
    Private Sub llenarForm()
        txtCodigo.Text = persona.numerodocumento
        'de persona a formulario
    End Sub
End Class