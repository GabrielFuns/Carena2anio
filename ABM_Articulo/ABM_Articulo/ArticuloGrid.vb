Public Class ArticuloGrid

    Private Sub btnAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregar.Click
        ArticuloForm.operacion = "Alta"
        ArticuloForm.Show()
    End Sub

    Private Sub btnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminar.Click
        ArticuloForm.operacion = "Baja"
        ArticuloForm.indice = DataGridView1.CurrentRow.Index
        ArticuloForm.Show()
    End Sub

    Private Sub btnModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificar.Click
        ArticuloForm.operacion = "Modifica"
        ArticuloForm.indice = DataGridView1.CurrentRow.Index
        llenarForm1()
        ArticuloForm.Show()
    End Sub

    Private Sub btnCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCerrar.Click
        End
    End Sub
    Private Sub llenarForm1()
        ArticuloForm.txtCodigo.Text = DataGridView1.CurrentRow.Cells(0).Value.ToString
    End Sub


End Class