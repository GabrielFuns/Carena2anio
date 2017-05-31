<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ArticuloForm
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
        Me.cbbxIva = New System.Windows.Forms.ComboBox
        Me.cbbxUnidad = New System.Windows.Forms.ComboBox
        Me.txtVenta = New System.Windows.Forms.TextBox
        Me.txtUtilidad = New System.Windows.Forms.TextBox
        Me.txtCosto = New System.Windows.Forms.TextBox
        Me.txtStock = New System.Windows.Forms.TextBox
        Me.txtDescripcion = New System.Windows.Forms.TextBox
        Me.txtCodigo = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Button1 = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'cbbxIva
        '
        Me.cbbxIva.FormattingEnabled = True
        Me.cbbxIva.Location = New System.Drawing.Point(160, 173)
        Me.cbbxIva.Name = "cbbxIva"
        Me.cbbxIva.Size = New System.Drawing.Size(136, 21)
        Me.cbbxIva.TabIndex = 15
        '
        'cbbxUnidad
        '
        Me.cbbxUnidad.FormattingEnabled = True
        Me.cbbxUnidad.Location = New System.Drawing.Point(160, 94)
        Me.cbbxUnidad.Name = "cbbxUnidad"
        Me.cbbxUnidad.Size = New System.Drawing.Size(136, 21)
        Me.cbbxUnidad.TabIndex = 14
        '
        'txtVenta
        '
        Me.txtVenta.Location = New System.Drawing.Point(160, 226)
        Me.txtVenta.Name = "txtVenta"
        Me.txtVenta.Size = New System.Drawing.Size(136, 20)
        Me.txtVenta.TabIndex = 13
        '
        'txtUtilidad
        '
        Me.txtUtilidad.Location = New System.Drawing.Point(160, 200)
        Me.txtUtilidad.Name = "txtUtilidad"
        Me.txtUtilidad.Size = New System.Drawing.Size(136, 20)
        Me.txtUtilidad.TabIndex = 12
        '
        'txtCosto
        '
        Me.txtCosto.Location = New System.Drawing.Point(160, 147)
        Me.txtCosto.Name = "txtCosto"
        Me.txtCosto.Size = New System.Drawing.Size(136, 20)
        Me.txtCosto.TabIndex = 11
        '
        'txtStock
        '
        Me.txtStock.Location = New System.Drawing.Point(160, 121)
        Me.txtStock.Name = "txtStock"
        Me.txtStock.Size = New System.Drawing.Size(136, 20)
        Me.txtStock.TabIndex = 10
        '
        'txtDescripcion
        '
        Me.txtDescripcion.Location = New System.Drawing.Point(160, 68)
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(136, 20)
        Me.txtDescripcion.TabIndex = 9
        '
        'txtCodigo
        '
        Me.txtCodigo.Location = New System.Drawing.Point(160, 42)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(136, 20)
        Me.txtCodigo.TabIndex = 8
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 45)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(52, 15)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Codigo"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 71)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(83, 15)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "Descripcion"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 97)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 15)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = "Unidad"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(12, 124)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(42, 15)
        Me.Label4.TabIndex = 19
        Me.Label4.Text = "Stock"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(12, 150)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(43, 15)
        Me.Label5.TabIndex = 20
        Me.Label5.Text = "Costo"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(12, 229)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(43, 15)
        Me.Label6.TabIndex = 21
        Me.Label6.Text = "Venta"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(12, 176)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(25, 15)
        Me.Label7.TabIndex = 21
        Me.Label7.Text = "Iva"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(12, 203)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(57, 15)
        Me.Label8.TabIndex = 22
        Me.Label8.Text = "Utilidad"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(221, 275)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 23
        Me.Button1.Text = "Cancelar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(140, 275)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 24
        Me.Button2.Text = "Aceptar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'ArticuloForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(308, 310)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cbbxIva)
        Me.Controls.Add(Me.cbbxUnidad)
        Me.Controls.Add(Me.txtVenta)
        Me.Controls.Add(Me.txtUtilidad)
        Me.Controls.Add(Me.txtCosto)
        Me.Controls.Add(Me.txtStock)
        Me.Controls.Add(Me.txtDescripcion)
        Me.Controls.Add(Me.txtCodigo)
        Me.Name = "ArticuloForm"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cbbxIva As System.Windows.Forms.ComboBox
    Friend WithEvents cbbxUnidad As System.Windows.Forms.ComboBox
    Friend WithEvents txtVenta As System.Windows.Forms.TextBox
    Friend WithEvents txtUtilidad As System.Windows.Forms.TextBox
    Friend WithEvents txtCosto As System.Windows.Forms.TextBox
    Friend WithEvents txtStock As System.Windows.Forms.TextBox
    Friend WithEvents txtDescripcion As System.Windows.Forms.TextBox
    Friend WithEvents txtCodigo As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button

End Class
