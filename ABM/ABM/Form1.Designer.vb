<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.ListBox1 = New System.Windows.Forms.ListBox
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.btnAgregar = New System.Windows.Forms.Button
        Me.btnBorrar = New System.Windows.Forms.Button
        Me.btnModificar = New System.Windows.Forms.Button
        Me.btnLeerXML = New System.Windows.Forms.Button
        Me.btnGrabarXML = New System.Windows.Forms.Button
        Me.btnMayuscula = New System.Windows.Forms.Button
        Me.btnEnumerar = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(12, 15)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(392, 290)
        Me.ListBox1.TabIndex = 0
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(12, 312)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(392, 20)
        Me.TextBox1.TabIndex = 1
        '
        'btnAgregar
        '
        Me.btnAgregar.Location = New System.Drawing.Point(411, 15)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(105, 23)
        Me.btnAgregar.TabIndex = 2
        Me.btnAgregar.Text = "Agregar"
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'btnBorrar
        '
        Me.btnBorrar.Enabled = False
        Me.btnBorrar.Location = New System.Drawing.Point(411, 44)
        Me.btnBorrar.Name = "btnBorrar"
        Me.btnBorrar.Size = New System.Drawing.Size(105, 23)
        Me.btnBorrar.TabIndex = 3
        Me.btnBorrar.Text = "Borrar"
        Me.btnBorrar.UseVisualStyleBackColor = True
        '
        'btnModificar
        '
        Me.btnModificar.Enabled = False
        Me.btnModificar.Location = New System.Drawing.Point(411, 73)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(105, 23)
        Me.btnModificar.TabIndex = 4
        Me.btnModificar.Text = "Modificar"
        Me.btnModificar.UseVisualStyleBackColor = True
        '
        'btnLeerXML
        '
        Me.btnLeerXML.Location = New System.Drawing.Point(411, 102)
        Me.btnLeerXML.Name = "btnLeerXML"
        Me.btnLeerXML.Size = New System.Drawing.Size(105, 23)
        Me.btnLeerXML.TabIndex = 5
        Me.btnLeerXML.Text = "Leer XML"
        Me.btnLeerXML.UseVisualStyleBackColor = True
        '
        'btnGrabarXML
        '
        Me.btnGrabarXML.Location = New System.Drawing.Point(411, 131)
        Me.btnGrabarXML.Name = "btnGrabarXML"
        Me.btnGrabarXML.Size = New System.Drawing.Size(105, 23)
        Me.btnGrabarXML.TabIndex = 6
        Me.btnGrabarXML.Text = "Grabar XML"
        Me.btnGrabarXML.UseVisualStyleBackColor = True
        '
        'btnMayuscula
        '
        Me.btnMayuscula.Location = New System.Drawing.Point(411, 160)
        Me.btnMayuscula.Name = "btnMayuscula"
        Me.btnMayuscula.Size = New System.Drawing.Size(105, 23)
        Me.btnMayuscula.TabIndex = 7
        Me.btnMayuscula.Text = "Mayuscula"
        Me.btnMayuscula.UseVisualStyleBackColor = True
        '
        'btnEnumerar
        '
        Me.btnEnumerar.Location = New System.Drawing.Point(411, 189)
        Me.btnEnumerar.Name = "btnEnumerar"
        Me.btnEnumerar.Size = New System.Drawing.Size(105, 23)
        Me.btnEnumerar.TabIndex = 8
        Me.btnEnumerar.Text = "Enumerar"
        Me.btnEnumerar.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(528, 361)
        Me.Controls.Add(Me.btnEnumerar)
        Me.Controls.Add(Me.btnMayuscula)
        Me.Controls.Add(Me.btnGrabarXML)
        Me.Controls.Add(Me.btnLeerXML)
        Me.Controls.Add(Me.btnModificar)
        Me.Controls.Add(Me.btnBorrar)
        Me.Controls.Add(Me.btnAgregar)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.ListBox1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents btnAgregar As System.Windows.Forms.Button
    Friend WithEvents btnBorrar As System.Windows.Forms.Button
    Friend WithEvents btnModificar As System.Windows.Forms.Button
    Friend WithEvents btnLeerXML As System.Windows.Forms.Button
    Friend WithEvents btnGrabarXML As System.Windows.Forms.Button
    Friend WithEvents btnMayuscula As System.Windows.Forms.Button
    Friend WithEvents btnEnumerar As System.Windows.Forms.Button

End Class
