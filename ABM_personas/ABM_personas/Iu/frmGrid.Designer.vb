<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGrid
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.FechadeinscripcionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.IdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.NumerodocumentoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.IdprovinciaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CodpostalDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.IdDependenciaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.MescierreDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TipodocumentoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TipopersonaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.EstadoclaveDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.NombreapellidoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DireccionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.LocalidadDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.NombreprovinciaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TipoclaveDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.IdpersonaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PersonaClassBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton
        Me.ToolStripButton3 = New System.Windows.Forms.ToolStripButton
        Me.ToolStripButton4 = New System.Windows.Forms.ToolStripButton
        Me.Panel1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PersonaClassBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.ToolStrip1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(577, 92)
        Me.Panel1.TabIndex = 0
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton1, Me.ToolStripButton2, Me.ToolStripButton3, Me.ToolStripButton4})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 67)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(577, 25)
        Me.ToolStrip1.TabIndex = 0
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Panel2.Controls.Add(Me.DataGridView1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 92)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(577, 285)
        Me.Panel2.TabIndex = 1
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.FechadeinscripcionDataGridViewTextBoxColumn, Me.IdDataGridViewTextBoxColumn, Me.NumerodocumentoDataGridViewTextBoxColumn, Me.IdprovinciaDataGridViewTextBoxColumn, Me.CodpostalDataGridViewTextBoxColumn, Me.IdDependenciaDataGridViewTextBoxColumn, Me.MescierreDataGridViewTextBoxColumn, Me.TipodocumentoDataGridViewTextBoxColumn, Me.TipopersonaDataGridViewTextBoxColumn, Me.EstadoclaveDataGridViewTextBoxColumn, Me.NombreapellidoDataGridViewTextBoxColumn, Me.DireccionDataGridViewTextBoxColumn, Me.LocalidadDataGridViewTextBoxColumn, Me.NombreprovinciaDataGridViewTextBoxColumn, Me.TipoclaveDataGridViewTextBoxColumn, Me.IdpersonaDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.PersonaClassBindingSource
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.Location = New System.Drawing.Point(0, 0)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(577, 285)
        Me.DataGridView1.TabIndex = 0
        '
        'FechadeinscripcionDataGridViewTextBoxColumn
        '
        Me.FechadeinscripcionDataGridViewTextBoxColumn.DataPropertyName = "fechadeinscripcion"
        Me.FechadeinscripcionDataGridViewTextBoxColumn.HeaderText = "fechadeinscripcion"
        Me.FechadeinscripcionDataGridViewTextBoxColumn.Name = "FechadeinscripcionDataGridViewTextBoxColumn"
        Me.FechadeinscripcionDataGridViewTextBoxColumn.ReadOnly = True
        '
        'IdDataGridViewTextBoxColumn
        '
        Me.IdDataGridViewTextBoxColumn.DataPropertyName = "id"
        Me.IdDataGridViewTextBoxColumn.HeaderText = "id"
        Me.IdDataGridViewTextBoxColumn.Name = "IdDataGridViewTextBoxColumn"
        Me.IdDataGridViewTextBoxColumn.ReadOnly = True
        '
        'NumerodocumentoDataGridViewTextBoxColumn
        '
        Me.NumerodocumentoDataGridViewTextBoxColumn.DataPropertyName = "numerodocumento"
        Me.NumerodocumentoDataGridViewTextBoxColumn.HeaderText = "numerodocumento"
        Me.NumerodocumentoDataGridViewTextBoxColumn.Name = "NumerodocumentoDataGridViewTextBoxColumn"
        Me.NumerodocumentoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'IdprovinciaDataGridViewTextBoxColumn
        '
        Me.IdprovinciaDataGridViewTextBoxColumn.DataPropertyName = "idprovincia"
        Me.IdprovinciaDataGridViewTextBoxColumn.HeaderText = "idprovincia"
        Me.IdprovinciaDataGridViewTextBoxColumn.Name = "IdprovinciaDataGridViewTextBoxColumn"
        Me.IdprovinciaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CodpostalDataGridViewTextBoxColumn
        '
        Me.CodpostalDataGridViewTextBoxColumn.DataPropertyName = "codpostal"
        Me.CodpostalDataGridViewTextBoxColumn.HeaderText = "codpostal"
        Me.CodpostalDataGridViewTextBoxColumn.Name = "CodpostalDataGridViewTextBoxColumn"
        Me.CodpostalDataGridViewTextBoxColumn.ReadOnly = True
        '
        'IdDependenciaDataGridViewTextBoxColumn
        '
        Me.IdDependenciaDataGridViewTextBoxColumn.DataPropertyName = "IdDependencia"
        Me.IdDependenciaDataGridViewTextBoxColumn.HeaderText = "IdDependencia"
        Me.IdDependenciaDataGridViewTextBoxColumn.Name = "IdDependenciaDataGridViewTextBoxColumn"
        Me.IdDependenciaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'MescierreDataGridViewTextBoxColumn
        '
        Me.MescierreDataGridViewTextBoxColumn.DataPropertyName = "mescierre"
        Me.MescierreDataGridViewTextBoxColumn.HeaderText = "mescierre"
        Me.MescierreDataGridViewTextBoxColumn.Name = "MescierreDataGridViewTextBoxColumn"
        Me.MescierreDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TipodocumentoDataGridViewTextBoxColumn
        '
        Me.TipodocumentoDataGridViewTextBoxColumn.DataPropertyName = "tipodocumento"
        Me.TipodocumentoDataGridViewTextBoxColumn.HeaderText = "tipodocumento"
        Me.TipodocumentoDataGridViewTextBoxColumn.Name = "TipodocumentoDataGridViewTextBoxColumn"
        Me.TipodocumentoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TipopersonaDataGridViewTextBoxColumn
        '
        Me.TipopersonaDataGridViewTextBoxColumn.DataPropertyName = "tipopersona"
        Me.TipopersonaDataGridViewTextBoxColumn.HeaderText = "tipopersona"
        Me.TipopersonaDataGridViewTextBoxColumn.Name = "TipopersonaDataGridViewTextBoxColumn"
        Me.TipopersonaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'EstadoclaveDataGridViewTextBoxColumn
        '
        Me.EstadoclaveDataGridViewTextBoxColumn.DataPropertyName = "estadoclave"
        Me.EstadoclaveDataGridViewTextBoxColumn.HeaderText = "estadoclave"
        Me.EstadoclaveDataGridViewTextBoxColumn.Name = "EstadoclaveDataGridViewTextBoxColumn"
        Me.EstadoclaveDataGridViewTextBoxColumn.ReadOnly = True
        '
        'NombreapellidoDataGridViewTextBoxColumn
        '
        Me.NombreapellidoDataGridViewTextBoxColumn.DataPropertyName = "nombreapellido"
        Me.NombreapellidoDataGridViewTextBoxColumn.HeaderText = "nombreapellido"
        Me.NombreapellidoDataGridViewTextBoxColumn.Name = "NombreapellidoDataGridViewTextBoxColumn"
        Me.NombreapellidoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DireccionDataGridViewTextBoxColumn
        '
        Me.DireccionDataGridViewTextBoxColumn.DataPropertyName = "direccion"
        Me.DireccionDataGridViewTextBoxColumn.HeaderText = "direccion"
        Me.DireccionDataGridViewTextBoxColumn.Name = "DireccionDataGridViewTextBoxColumn"
        Me.DireccionDataGridViewTextBoxColumn.ReadOnly = True
        '
        'LocalidadDataGridViewTextBoxColumn
        '
        Me.LocalidadDataGridViewTextBoxColumn.DataPropertyName = "localidad"
        Me.LocalidadDataGridViewTextBoxColumn.HeaderText = "localidad"
        Me.LocalidadDataGridViewTextBoxColumn.Name = "LocalidadDataGridViewTextBoxColumn"
        Me.LocalidadDataGridViewTextBoxColumn.ReadOnly = True
        '
        'NombreprovinciaDataGridViewTextBoxColumn
        '
        Me.NombreprovinciaDataGridViewTextBoxColumn.DataPropertyName = "nombreprovincia"
        Me.NombreprovinciaDataGridViewTextBoxColumn.HeaderText = "nombreprovincia"
        Me.NombreprovinciaDataGridViewTextBoxColumn.Name = "NombreprovinciaDataGridViewTextBoxColumn"
        Me.NombreprovinciaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TipoclaveDataGridViewTextBoxColumn
        '
        Me.TipoclaveDataGridViewTextBoxColumn.DataPropertyName = "tipoclave"
        Me.TipoclaveDataGridViewTextBoxColumn.HeaderText = "tipoclave"
        Me.TipoclaveDataGridViewTextBoxColumn.Name = "TipoclaveDataGridViewTextBoxColumn"
        Me.TipoclaveDataGridViewTextBoxColumn.ReadOnly = True
        '
        'IdpersonaDataGridViewTextBoxColumn
        '
        Me.IdpersonaDataGridViewTextBoxColumn.DataPropertyName = "idpersona"
        Me.IdpersonaDataGridViewTextBoxColumn.HeaderText = "idpersona"
        Me.IdpersonaDataGridViewTextBoxColumn.Name = "IdpersonaDataGridViewTextBoxColumn"
        Me.IdpersonaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PersonaClassBindingSource
        '
        Me.PersonaClassBindingSource.DataSource = GetType(WindowsApplication1.PersonaClass)
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.WindowsApplication1.My.Resources.Resources.personas
        Me.PictureBox1.Location = New System.Drawing.Point(3, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(71, 61)
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.Image = Global.WindowsApplication1.My.Resources.Resources.agregar
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(48, 22)
        Me.ToolStripButton1.Text = "Alta"
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.Image = Global.WindowsApplication1.My.Resources.Resources.eliminar
        Me.ToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.Size = New System.Drawing.Size(49, 22)
        Me.ToolStripButton2.Text = "Baja"
        '
        'ToolStripButton3
        '
        Me.ToolStripButton3.Image = Global.WindowsApplication1.My.Resources.Resources.modificar
        Me.ToolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton3.Name = "ToolStripButton3"
        Me.ToolStripButton3.Size = New System.Drawing.Size(78, 22)
        Me.ToolStripButton3.Text = "Modificar"
        '
        'ToolStripButton4
        '
        Me.ToolStripButton4.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripButton4.Image = Global.WindowsApplication1.My.Resources.Resources.salir1
        Me.ToolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton4.Name = "ToolStripButton4"
        Me.ToolStripButton4.Size = New System.Drawing.Size(49, 22)
        Me.ToolStripButton4.Text = "Salir"
        '
        'frmGrid
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(577, 377)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "frmGrid"
        Me.Text = "frmGrid"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PersonaClassBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents FechadeinscripcionDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IdDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NumerodocumentoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IdprovinciaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CodpostalDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IdDependenciaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MescierreDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TipodocumentoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TipopersonaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EstadoclaveDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NombreapellidoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DireccionDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LocalidadDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NombreprovinciaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TipoclaveDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IdpersonaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PersonaClassBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ToolStripButton2 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton3 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton4 As System.Windows.Forms.ToolStripButton
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
End Class
