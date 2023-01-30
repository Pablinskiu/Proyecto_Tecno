<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class admin
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
        Me.btn_regresar = New System.Windows.Forms.Button()
        Me.txt_id = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DGV1 = New System.Windows.Forms.DataGridView()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_nombre = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_correo = New System.Windows.Forms.TextBox()
        Me.btn_insertar = New System.Windows.Forms.Button()
        Me.btn_cargar = New System.Windows.Forms.Button()
        Me.btn_borrar = New System.Windows.Forms.Button()
        Me.btn_editar = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txt_ocupacion = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txt_pais = New System.Windows.Forms.TextBox()
        Me.btn_limpiar = New System.Windows.Forms.Button()
        CType(Me.DGV1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("MV Boli", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(37, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(97, 21)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Bienvenido"
        '
        'btn_regresar
        '
        Me.btn_regresar.Location = New System.Drawing.Point(663, 518)
        Me.btn_regresar.Name = "btn_regresar"
        Me.btn_regresar.Size = New System.Drawing.Size(88, 31)
        Me.btn_regresar.TabIndex = 4
        Me.btn_regresar.Text = "Regresar"
        Me.btn_regresar.UseVisualStyleBackColor = True
        '
        'txt_id
        '
        Me.txt_id.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.txt_id.Location = New System.Drawing.Point(152, 85)
        Me.txt_id.Name = "txt_id"
        Me.txt_id.Size = New System.Drawing.Size(175, 20)
        Me.txt_id.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("MV Boli", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(37, 84)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(33, 21)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Id:"
        '
        'DGV1
        '
        Me.DGV1.AllowUserToAddRows = False
        Me.DGV1.AllowUserToDeleteRows = False
        Me.DGV1.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DGV1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV1.Location = New System.Drawing.Point(363, 75)
        Me.DGV1.Name = "DGV1"
        Me.DGV1.ReadOnly = True
        Me.DGV1.Size = New System.Drawing.Size(388, 220)
        Me.DGV1.TabIndex = 7
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("MV Boli", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(37, 131)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(82, 21)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Nombre:"
        '
        'txt_nombre
        '
        Me.txt_nombre.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.txt_nombre.Location = New System.Drawing.Point(152, 132)
        Me.txt_nombre.Name = "txt_nombre"
        Me.txt_nombre.Size = New System.Drawing.Size(175, 20)
        Me.txt_nombre.TabIndex = 8
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("MV Boli", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(37, 182)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(71, 21)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Correo:"
        '
        'txt_correo
        '
        Me.txt_correo.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.txt_correo.Location = New System.Drawing.Point(152, 182)
        Me.txt_correo.Name = "txt_correo"
        Me.txt_correo.Size = New System.Drawing.Size(175, 20)
        Me.txt_correo.TabIndex = 10
        '
        'btn_insertar
        '
        Me.btn_insertar.Location = New System.Drawing.Point(35, 334)
        Me.btn_insertar.Name = "btn_insertar"
        Me.btn_insertar.Size = New System.Drawing.Size(88, 31)
        Me.btn_insertar.TabIndex = 12
        Me.btn_insertar.Text = "Insertar"
        Me.btn_insertar.UseVisualStyleBackColor = True
        '
        'btn_cargar
        '
        Me.btn_cargar.Location = New System.Drawing.Point(141, 334)
        Me.btn_cargar.Name = "btn_cargar"
        Me.btn_cargar.Size = New System.Drawing.Size(88, 31)
        Me.btn_cargar.TabIndex = 13
        Me.btn_cargar.Text = "Cargar"
        Me.btn_cargar.UseVisualStyleBackColor = True
        '
        'btn_borrar
        '
        Me.btn_borrar.Location = New System.Drawing.Point(247, 334)
        Me.btn_borrar.Name = "btn_borrar"
        Me.btn_borrar.Size = New System.Drawing.Size(88, 31)
        Me.btn_borrar.TabIndex = 14
        Me.btn_borrar.Text = "Borrar"
        Me.btn_borrar.UseVisualStyleBackColor = True
        '
        'btn_editar
        '
        Me.btn_editar.Location = New System.Drawing.Point(35, 389)
        Me.btn_editar.Name = "btn_editar"
        Me.btn_editar.Size = New System.Drawing.Size(88, 31)
        Me.btn_editar.TabIndex = 15
        Me.btn_editar.Text = "Editar"
        Me.btn_editar.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("MV Boli", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(39, 271)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(98, 21)
        Me.Label6.TabIndex = 19
        Me.Label6.Text = "Ocupacion:"
        '
        'txt_ocupacion
        '
        Me.txt_ocupacion.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.txt_ocupacion.Location = New System.Drawing.Point(154, 272)
        Me.txt_ocupacion.Name = "txt_ocupacion"
        Me.txt_ocupacion.Size = New System.Drawing.Size(175, 20)
        Me.txt_ocupacion.TabIndex = 18
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("MV Boli", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(39, 224)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(51, 21)
        Me.Label7.TabIndex = 17
        Me.Label7.Text = "Pais:"
        '
        'txt_pais
        '
        Me.txt_pais.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.txt_pais.Location = New System.Drawing.Point(154, 225)
        Me.txt_pais.Name = "txt_pais"
        Me.txt_pais.Size = New System.Drawing.Size(175, 20)
        Me.txt_pais.TabIndex = 16
        '
        'btn_limpiar
        '
        Me.btn_limpiar.Location = New System.Drawing.Point(141, 389)
        Me.btn_limpiar.Name = "btn_limpiar"
        Me.btn_limpiar.Size = New System.Drawing.Size(88, 31)
        Me.btn_limpiar.TabIndex = 20
        Me.btn_limpiar.Text = "Limpiar"
        Me.btn_limpiar.UseVisualStyleBackColor = True
        '
        'admin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(763, 561)
        Me.Controls.Add(Me.btn_limpiar)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txt_ocupacion)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txt_pais)
        Me.Controls.Add(Me.btn_editar)
        Me.Controls.Add(Me.btn_borrar)
        Me.Controls.Add(Me.btn_cargar)
        Me.Controls.Add(Me.btn_insertar)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txt_correo)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txt_nombre)
        Me.Controls.Add(Me.DGV1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txt_id)
        Me.Controls.Add(Me.btn_regresar)
        Me.Controls.Add(Me.Label1)
        Me.Name = "admin"
        Me.Text = "admin"
        CType(Me.DGV1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents btn_regresar As Button
    Friend WithEvents txt_id As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents DGV1 As DataGridView
    Friend WithEvents Label3 As Label
    Friend WithEvents txt_nombre As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txt_correo As TextBox
    Friend WithEvents btn_insertar As Button
    Friend WithEvents btn_cargar As Button
    Friend WithEvents btn_borrar As Button
    Friend WithEvents btn_editar As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents txt_ocupacion As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txt_pais As TextBox
    Friend WithEvents btn_limpiar As Button
End Class
