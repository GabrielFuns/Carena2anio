Public Class frmGrid

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
        frmPersona.operacion = "Alta"
        frmPersona.Show()
    End Sub

    Private Sub ToolStripButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton2.Click
        frmPersona.operacion = "Baja"
        frmPersona.indice = DataGridView1.CurrentRow.Index
        frmPersona.Show()
    End Sub

    Private Sub ToolStripButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton3.Click
        frmPersona.operacion = "Modificar"
        frmPersona.indice = DataGridView1.CurrentRow.Index
        llenarGrid()
        frmPersona.Show()
    End Sub

    Private Sub llenarGrid()
        frmPersona.txtCodigo.Text = DataGridView1.CurrentRow.Cells(0).Value.ToString
    End Sub
End Class
