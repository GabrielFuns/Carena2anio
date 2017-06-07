<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPersona
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
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
        Me.Label15 = New System.Windows.Forms.Label
        Me.cbbxProvincia = New System.Windows.Forms.ComboBox
        Me.txtCodigo = New System.Windows.Forms.TextBox
        Me.txtDNI = New System.Windows.Forms.TextBox
        Me.txtClave = New System.Windows.Forms.TextBox
        Me.txtEstadoClave = New System.Windows.Forms.TextBox
        Me.txtNombre = New System.Windows.Forms.TextBox
        Me.txtDireccion = New System.Windows.Forms.TextBox
        Me.txtLocalidad = New System.Windows.Forms.TextBox
        Me.txtPostal = New System.Windows.Forms.TextBox
        Me.txtDependencias = New System.Windows.Forms.TextBox
        Me.txtCierre = New System.Windows.Forms.TextBox
        Me.ACEPTAR = New System.Windows.Forms.Button
        Me.CANCELAR = New System.Windows.Forms.Button
        Me.Label16 = New System.Windows.Forms.Label
        Me.txtIncripcion = New System.Windows.Forms.TextBox
        Me.buscarcuitcuil = New System.Windows.Forms.Button
        Me.cbbxCuil = New System.Windows.Forms.ComboBox
        Me.txtPersona = New System.Windows.Forms.TextBox
        Me.txtTipoDNI = New System.Windows.Forms.TextBox
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(7, 44)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(18, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ID"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(7, 69)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(117, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Numero de Documento"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(7, 123)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(101, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Tipo de Documento"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(7, 151)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(70, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Tipo Persona"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(7, 176)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(58, 13)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Tipo Clave"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(7, 201)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(70, 13)
        Me.Label7.TabIndex = 8
        Me.Label7.Text = "Estado Clave"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(7, 227)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(92, 13)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Apellido y Nombre"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(7, 254)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(52, 13)
        Me.Label9.TabIndex = 6
        Me.Label9.Text = "Direccion"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(7, 280)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(53, 13)
        Me.Label10.TabIndex = 5
        Me.Label10.Text = "Localidad"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(10, 307)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(51, 13)
        Me.Label11.TabIndex = 10
        Me.Label11.Text = "Provincia"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(10, 333)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(72, 13)
        Me.Label12.TabIndex = 11
        Me.Label12.Text = "Codigo Postal"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(10, 360)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(85, 13)
        Me.Label13.TabIndex = 12
        Me.Label13.Text = "ID Dependencia"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(10, 388)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(57, 13)
        Me.Label14.TabIndex = 13
        Me.Label14.Text = "Mes Cierre"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label15.Font = New System.Drawing.Font("Engravers MT", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.Red
        Me.Label15.Location = New System.Drawing.Point(68, 9)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(283, 25)
        Me.Label15.TabIndex = 14
        Me.Label15.Text = """ ABM-PERSONAS """
        '
        'cbbxProvincia
        '
        Me.cbbxProvincia.FormattingEnabled = True
        Me.cbbxProvincia.Location = New System.Drawing.Point(142, 303)
        Me.cbbxProvincia.Name = "cbbxProvincia"
        Me.cbbxProvincia.Size = New System.Drawing.Size(179, 21)
        Me.cbbxProvincia.TabIndex = 15
        '
        'txtCodigo
        '
        Me.txtCodigo.Location = New System.Drawing.Point(142, 41)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.ReadOnly = True
        Me.txtCodigo.Size = New System.Drawing.Size(100, 20)
        Me.txtCodigo.TabIndex = 16
        '
        'txtDNI
        '
        Me.txtDNI.Location = New System.Drawing.Point(142, 66)
        Me.txtDNI.Name = "txtDNI"
        Me.txtDNI.Size = New System.Drawing.Size(100, 20)
        Me.txtDNI.TabIndex = 17
        '
        'txtClave
        '
        Me.txtClave.Location = New System.Drawing.Point(142, 173)
        Me.txtClave.Name = "txtClave"
        Me.txtClave.Size = New System.Drawing.Size(100, 20)
        Me.txtClave.TabIndex = 21
        '
        'txtEstadoClave
        '
        Me.txtEstadoClave.Location = New System.Drawing.Point(142, 198)
        Me.txtEstadoClave.Name = "txtEstadoClave"
        Me.txtEstadoClave.Size = New System.Drawing.Size(100, 20)
        Me.txtEstadoClave.TabIndex = 22
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(142, 224)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(251, 20)
        Me.txtNombre.TabIndex = 23
        '
        'txtDireccion
        '
        Me.txtDireccion.Location = New System.Drawing.Point(142, 251)
        Me.txtDireccion.Name = "txtDireccion"
        Me.txtDireccion.Size = New System.Drawing.Size(209, 20)
        Me.txtDireccion.TabIndex = 24
        '
        'txtLocalidad
        '
        Me.txtLocalidad.Location = New System.Drawing.Point(142, 277)
        Me.txtLocalidad.Name = "txtLocalidad"
        Me.txtLocalidad.Size = New System.Drawing.Size(209, 20)
        Me.txtLocalidad.TabIndex = 25
        '
        'txtPostal
        '
        Me.txtPostal.Location = New System.Drawing.Point(142, 330)
        Me.txtPostal.Name = "txtPostal"
        Me.txtPostal.Size = New System.Drawing.Size(100, 20)
        Me.txtPostal.TabIndex = 26
        '
        'txtDependencias
        '
        Me.txtDependencias.Location = New System.Drawing.Point(142, 357)
        Me.txtDependencias.Name = "txtDependencias"
        Me.txtDependencias.Size = New System.Drawing.Size(100, 20)
        Me.txtDependencias.TabIndex = 27
        '
        'txtCierre
        '
        Me.txtCierre.Location = New System.Drawing.Point(142, 385)
        Me.txtCierre.Name = "txtCierre"
        Me.txtCierre.Size = New System.Drawing.Size(100, 20)
        Me.txtCierre.TabIndex = 28
        '
        'ACEPTAR
        '
        Me.ACEPTAR.Location = New System.Drawing.Point(113, 473)
        Me.ACEPTAR.Name = "ACEPTAR"
        Me.ACEPTAR.Size = New System.Drawing.Size(75, 23)
        Me.ACEPTAR.TabIndex = 29
        Me.ACEPTAR.Text = "ACEPTAR"
        Me.ACEPTAR.UseVisualStyleBackColor = True
        '
        'CANCELAR
        '
        Me.CANCELAR.Location = New System.Drawing.Point(208, 473)
        Me.CANCELAR.Name = "CANCELAR"
        Me.CANCELAR.Size = New System.Drawing.Size(75, 23)
        Me.CANCELAR.TabIndex = 30
        Me.CANCELAR.Text = "CANCELAR"
        Me.CANCELAR.UseVisualStyleBackColor = True
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(7, 419)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(106, 13)
        Me.Label16.TabIndex = 34
        Me.Label16.Text = "Fecha de Inscripcion"
        '
        'txtIncripcion
        '
        Me.txtIncripcion.Location = New System.Drawing.Point(142, 416)
        Me.txtIncripcion.Name = "txtIncripcion"
        Me.txtIncripcion.Size = New System.Drawing.Size(100, 20)
        Me.txtIncripcion.TabIndex = 35
        '
        'buscarcuitcuil
        '
        Me.buscarcuitcuil.Location = New System.Drawing.Point(1, 91)
        Me.buscarcuitcuil.Name = "buscarcuitcuil"
        Me.buscarcuitcuil.Size = New System.Drawing.Size(135, 23)
        Me.buscarcuitcuil.TabIndex = 37
        Me.buscarcuitcuil.Text = "Buscar CUIT/CUIL"
        Me.buscarcuitcuil.UseVisualStyleBackColor = True
        '
        'cbbxCuil
        '
        Me.cbbxCuil.FormattingEnabled = True
        Me.cbbxCuil.Location = New System.Drawing.Point(142, 91)
        Me.cbbxCuil.Name = "cbbxCuil"
        Me.cbbxCuil.Size = New System.Drawing.Size(121, 21)
        Me.cbbxCuil.TabIndex = 38
        '
        'txtPersona
        '
        Me.txtPersona.Location = New System.Drawing.Point(142, 148)
        Me.txtPersona.Name = "txtPersona"
        Me.txtPersona.Size = New System.Drawing.Size(100, 20)
        Me.txtPersona.TabIndex = 40
        '
        'txtTipoDNI
        '
        Me.txtTipoDNI.Location = New System.Drawing.Point(142, 120)
        Me.txtTipoDNI.Name = "txtTipoDNI"
        Me.txtTipoDNI.Size = New System.Drawing.Size(100, 20)
        Me.txtTipoDNI.TabIndex = 39
        '
        'frmPersona
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(405, 521)
        Me.Controls.Add(Me.txtPersona)
        Me.Controls.Add(Me.txtTipoDNI)
        Me.Controls.Add(Me.cbbxCuil)
        Me.Controls.Add(Me.buscarcuitcuil)
        Me.Controls.Add(Me.txtIncripcion)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.CANCELAR)
        Me.Controls.Add(Me.ACEPTAR)
        Me.Controls.Add(Me.txtCierre)
        Me.Controls.Add(Me.txtDependencias)
        Me.Controls.Add(Me.txtPostal)
        Me.Controls.Add(Me.txtLocalidad)
        Me.Controls.Add(Me.txtDireccion)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.txtEstadoClave)
        Me.Controls.Add(Me.txtClave)
        Me.Controls.Add(Me.txtDNI)
        Me.Controls.Add(Me.txtCodigo)
        Me.Controls.Add(Me.cbbxProvincia)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmPersona"
        Me.Text = "Form2"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents cbbxProvincia As System.Windows.Forms.ComboBox
    Friend WithEvents txtCodigo As System.Windows.Forms.TextBox
    Friend WithEvents txtDNI As System.Windows.Forms.TextBox
    Friend WithEvents txtClave As System.Windows.Forms.TextBox
    Friend WithEvents txtEstadoClave As System.Windows.Forms.TextBox
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    Friend WithEvents txtDireccion As System.Windows.Forms.TextBox
    Friend WithEvents txtLocalidad As System.Windows.Forms.TextBox
    Friend WithEvents txtPostal As System.Windows.Forms.TextBox
    Friend WithEvents txtDependencias As System.Windows.Forms.TextBox
    Friend WithEvents txtCierre As System.Windows.Forms.TextBox
    Friend WithEvents ACEPTAR As System.Windows.Forms.Button
    Friend WithEvents CANCELAR As System.Windows.Forms.Button
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents txtIncripcion As System.Windows.Forms.TextBox
    Friend WithEvents buscarcuitcuil As System.Windows.Forms.Button
    Friend WithEvents cbbxCuil As System.Windows.Forms.ComboBox
    Friend WithEvents txtPersona As System.Windows.Forms.TextBox
    Friend WithEvents txtTipoDNI As System.Windows.Forms.TextBox
End Class
