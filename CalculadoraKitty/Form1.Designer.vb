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
        Me.txtDisplay = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Bt7 = New System.Windows.Forms.Button()
        Me.Bt9 = New System.Windows.Forms.Button()
        Me.Bt8 = New System.Windows.Forms.Button()
        Me.Bt4 = New System.Windows.Forms.Button()
        Me.Bt5 = New System.Windows.Forms.Button()
        Me.Bt6 = New System.Windows.Forms.Button()
        Me.Bt1 = New System.Windows.Forms.Button()
        Me.Bt2 = New System.Windows.Forms.Button()
        Me.Bt3 = New System.Windows.Forms.Button()
        Me.Bt0 = New System.Windows.Forms.Button()
        Me.igual = New System.Windows.Forms.Button()
        Me.multiplicar = New System.Windows.Forms.Button()
        Me.restar = New System.Windows.Forms.Button()
        Me.sumar = New System.Windows.Forms.Button()
        Me.dividir = New System.Windows.Forms.Button()
        Me.borrar = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtDisplay
        '
        Me.txtDisplay.Font = New System.Drawing.Font("Comic Sans MS", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDisplay.Location = New System.Drawing.Point(11, 61)
        Me.txtDisplay.Name = "txtDisplay"
        Me.txtDisplay.Size = New System.Drawing.Size(204, 48)
        Me.txtDisplay.TabIndex = 0
        Me.txtDisplay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.CalculadoraKitty.My.Resources.Resources.ip
        Me.PictureBox1.Location = New System.Drawing.Point(11, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(204, 43)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'Bt7
        '
        Me.Bt7.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Bt7.Location = New System.Drawing.Point(11, 157)
        Me.Bt7.Name = "Bt7"
        Me.Bt7.Size = New System.Drawing.Size(48, 36)
        Me.Bt7.TabIndex = 2
        Me.Bt7.Text = "7"
        Me.Bt7.UseVisualStyleBackColor = True
        '
        'Bt9
        '
        Me.Bt9.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Bt9.Location = New System.Drawing.Point(119, 157)
        Me.Bt9.Name = "Bt9"
        Me.Bt9.Size = New System.Drawing.Size(48, 36)
        Me.Bt9.TabIndex = 3
        Me.Bt9.Text = "9"
        Me.Bt9.UseVisualStyleBackColor = True
        '
        'Bt8
        '
        Me.Bt8.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Bt8.Location = New System.Drawing.Point(66, 157)
        Me.Bt8.Name = "Bt8"
        Me.Bt8.Size = New System.Drawing.Size(48, 36)
        Me.Bt8.TabIndex = 4
        Me.Bt8.Text = "8"
        Me.Bt8.UseVisualStyleBackColor = True
        '
        'Bt4
        '
        Me.Bt4.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Bt4.Location = New System.Drawing.Point(11, 199)
        Me.Bt4.Name = "Bt4"
        Me.Bt4.Size = New System.Drawing.Size(48, 36)
        Me.Bt4.TabIndex = 5
        Me.Bt4.Text = "4"
        Me.Bt4.UseVisualStyleBackColor = True
        '
        'Bt5
        '
        Me.Bt5.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Bt5.Location = New System.Drawing.Point(66, 199)
        Me.Bt5.Name = "Bt5"
        Me.Bt5.Size = New System.Drawing.Size(48, 36)
        Me.Bt5.TabIndex = 6
        Me.Bt5.Text = "5"
        Me.Bt5.UseVisualStyleBackColor = True
        '
        'Bt6
        '
        Me.Bt6.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Bt6.Location = New System.Drawing.Point(119, 199)
        Me.Bt6.Name = "Bt6"
        Me.Bt6.Size = New System.Drawing.Size(48, 36)
        Me.Bt6.TabIndex = 7
        Me.Bt6.Text = "6"
        Me.Bt6.UseVisualStyleBackColor = True
        '
        'Bt1
        '
        Me.Bt1.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Bt1.Location = New System.Drawing.Point(11, 241)
        Me.Bt1.Name = "Bt1"
        Me.Bt1.Size = New System.Drawing.Size(48, 36)
        Me.Bt1.TabIndex = 8
        Me.Bt1.Text = "1"
        Me.Bt1.UseVisualStyleBackColor = True
        '
        'Bt2
        '
        Me.Bt2.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Bt2.Location = New System.Drawing.Point(66, 241)
        Me.Bt2.Name = "Bt2"
        Me.Bt2.Size = New System.Drawing.Size(48, 36)
        Me.Bt2.TabIndex = 9
        Me.Bt2.Text = "2"
        Me.Bt2.UseVisualStyleBackColor = True
        '
        'Bt3
        '
        Me.Bt3.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Bt3.Location = New System.Drawing.Point(119, 241)
        Me.Bt3.Name = "Bt3"
        Me.Bt3.Size = New System.Drawing.Size(48, 36)
        Me.Bt3.TabIndex = 10
        Me.Bt3.Text = "3"
        Me.Bt3.UseVisualStyleBackColor = True
        '
        'Bt0
        '
        Me.Bt0.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Bt0.Location = New System.Drawing.Point(11, 286)
        Me.Bt0.Name = "Bt0"
        Me.Bt0.Size = New System.Drawing.Size(101, 36)
        Me.Bt0.TabIndex = 11
        Me.Bt0.Text = "0"
        Me.Bt0.UseVisualStyleBackColor = True
        '
        'igual
        '
        Me.igual.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.igual.Location = New System.Drawing.Point(119, 286)
        Me.igual.Name = "igual"
        Me.igual.Size = New System.Drawing.Size(96, 36)
        Me.igual.TabIndex = 12
        Me.igual.Text = "="
        Me.igual.UseVisualStyleBackColor = True
        '
        'multiplicar
        '
        Me.multiplicar.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.multiplicar.Location = New System.Drawing.Point(167, 157)
        Me.multiplicar.Name = "multiplicar"
        Me.multiplicar.Size = New System.Drawing.Size(48, 36)
        Me.multiplicar.TabIndex = 13
        Me.multiplicar.Text = "X"
        Me.multiplicar.UseVisualStyleBackColor = True
        '
        'restar
        '
        Me.restar.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.restar.Location = New System.Drawing.Point(167, 199)
        Me.restar.Name = "restar"
        Me.restar.Size = New System.Drawing.Size(48, 36)
        Me.restar.TabIndex = 14
        Me.restar.Text = "-"
        Me.restar.UseVisualStyleBackColor = True
        '
        'sumar
        '
        Me.sumar.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sumar.Location = New System.Drawing.Point(167, 241)
        Me.sumar.Name = "sumar"
        Me.sumar.Size = New System.Drawing.Size(48, 36)
        Me.sumar.TabIndex = 15
        Me.sumar.Text = "+"
        Me.sumar.UseVisualStyleBackColor = True
        '
        'dividir
        '
        Me.dividir.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dividir.Location = New System.Drawing.Point(167, 115)
        Me.dividir.Name = "dividir"
        Me.dividir.Size = New System.Drawing.Size(48, 36)
        Me.dividir.TabIndex = 16
        Me.dividir.Text = "/"
        Me.dividir.UseVisualStyleBackColor = True
        '
        'borrar
        '
        Me.borrar.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.borrar.Location = New System.Drawing.Point(12, 115)
        Me.borrar.Name = "borrar"
        Me.borrar.Size = New System.Drawing.Size(155, 36)
        Me.borrar.TabIndex = 17
        Me.borrar.Text = "C"
        Me.borrar.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(220, 334)
        Me.Controls.Add(Me.borrar)
        Me.Controls.Add(Me.dividir)
        Me.Controls.Add(Me.sumar)
        Me.Controls.Add(Me.restar)
        Me.Controls.Add(Me.multiplicar)
        Me.Controls.Add(Me.igual)
        Me.Controls.Add(Me.Bt0)
        Me.Controls.Add(Me.Bt3)
        Me.Controls.Add(Me.Bt2)
        Me.Controls.Add(Me.Bt1)
        Me.Controls.Add(Me.Bt6)
        Me.Controls.Add(Me.Bt5)
        Me.Controls.Add(Me.Bt4)
        Me.Controls.Add(Me.Bt8)
        Me.Controls.Add(Me.Bt9)
        Me.Controls.Add(Me.Bt7)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.txtDisplay)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.Text = "EVA1.CamilaBormann"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtDisplay As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Bt7 As Button
    Friend WithEvents Bt9 As Button
    Friend WithEvents Bt8 As Button
    Friend WithEvents Bt4 As Button
    Friend WithEvents Bt5 As Button
    Friend WithEvents Bt6 As Button
    Friend WithEvents Bt1 As Button
    Friend WithEvents Bt2 As Button
    Friend WithEvents Bt3 As Button
    Friend WithEvents Bt0 As Button
    Friend WithEvents igual As Button
    Friend WithEvents multiplicar As Button
    Friend WithEvents restar As Button
    Friend WithEvents sumar As Button
    Friend WithEvents dividir As Button
    Friend WithEvents borrar As Button
End Class
