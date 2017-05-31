Public Class ArticuloForm
    Dim operacion_ As String
    Dim MiArticulo As New Articulo

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

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        MiArticulo.Codigo = txtCodigo.Text
        MiArticulo.descripcion = txtDescripcion.Text
        MiArticulo.unidad = cbbxUnidad.SelectedIndex
        MiArticulo.stock = txtStock.Text
        MiArticulo.costo = txtCosto.Text
        MiArticulo.iva = cbbxIva.SelectedIndex
        txtVenta.Text = MiArticulo.venta

        Select Case operacion_
            Case "Alta"
                lst.Add(MiArticulo)

            Case "Baja"
                lst.RemoveAt(indice_)

            Case "Modifica"
                lst.Item(indice_).Codigo = MiArticulo.Codigo
                lst.Item(indice_).descripcion = MiArticulo.descripcion
                lst.Item(indice_).stock = MiArticulo.stock
                lst.Item(indice_).unidad = MiArticulo.unidad
                lst.Item(indice_).utilidad = MiArticulo.utilidad
                lst.Item(indice_).iva = MiArticulo.iva

        End Select
        Me.Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

End Class
