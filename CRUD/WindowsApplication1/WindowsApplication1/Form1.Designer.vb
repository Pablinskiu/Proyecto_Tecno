<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_usuario = New System.Windows.Forms.TextBox()
        Me.btn_ingreso = New System.Windows.Forms.Button()
        Me.txt_contraseña = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btn_cerrar = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Modern No. 20", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(176, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(105, 36)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Login"
        '
        'txt_usuario
        '
        Me.txt_usuario.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.txt_usuario.Location = New System.Drawing.Point(149, 95)
        Me.txt_usuario.Name = "txt_usuario"
        Me.txt_usuario.Size = New System.Drawing.Size(183, 20)
        Me.txt_usuario.TabIndex = 1
        '
        'btn_ingreso
        '
        Me.btn_ingreso.Location = New System.Drawing.Point(160, 252)
        Me.btn_ingreso.Name = "btn_ingreso"
        Me.btn_ingreso.Size = New System.Drawing.Size(75, 23)
        Me.btn_ingreso.TabIndex = 2
        Me.btn_ingreso.Text = "Ingreso"
        Me.btn_ingreso.UseVisualStyleBackColor = True
        '
        'txt_contraseña
        '
        Me.txt_contraseña.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.txt_contraseña.Location = New System.Drawing.Point(149, 153)
        Me.txt_contraseña.Name = "txt_contraseña"
        Me.txt_contraseña.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txt_contraseña.Size = New System.Drawing.Size(183, 20)
        Me.txt_contraseña.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(73, 97)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 18)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Usuario:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(49, 153)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(94, 18)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Contraseña:"
        '
        'btn_cerrar
        '
        Me.btn_cerrar.Location = New System.Drawing.Point(257, 252)
        Me.btn_cerrar.Name = "btn_cerrar"
        Me.btn_cerrar.Size = New System.Drawing.Size(75, 23)
        Me.btn_cerrar.TabIndex = 6
        Me.btn_cerrar.Text = "Cerrar"
        Me.btn_cerrar.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(206, 298)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "Limpiar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(453, 333)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btn_cerrar)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txt_contraseña)
        Me.Controls.Add(Me.btn_ingreso)
        Me.Controls.Add(Me.txt_usuario)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txt_usuario As TextBox
    Friend WithEvents btn_ingreso As Button
    Friend WithEvents txt_contraseña As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btn_cerrar As Button
    Friend WithEvents Button1 As Button
End Class
