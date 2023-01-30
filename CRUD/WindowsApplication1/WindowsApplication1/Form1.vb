'librerias de sql'
Imports System.Data.SqlClient

Public Class Form1
    'declaracion de conexion'
    Dim con As conexion = New conexion

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load



    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btn_ingreso.Click
        'Creacion de variables para seleccionar los usuarios que estan ingresados en la tabla usuarios, con su respectiva contraseña y su roll'
        Dim a = admin
        Dim verificar = "Update usuarios Set usuario=usuario Where usuario='" + txt_usuario.Text + "' and contraseña=" + txt_contraseña.Text + " and roll='Administrador'"

        Dim verificar1 = "Update usuarios Set usuario=usuario Where usuario='" + txt_usuario.Text + "' and contraseña=" + txt_contraseña.Text + " and roll='Secretari@'"

        Dim verificar2 = "Update usuarios Set usuario=usuario Where usuario='" + txt_usuario.Text + "' and contraseña=" + txt_contraseña.Text + " and roll='Usuario'"



        'Condicion del IF para mostrarnos el roll que sera'
        If (con.Verificacion(verificar)) Then
            'Roll de administrador'
            Me.Hide()
            admin.Show()


        ElseIf (con.Verificacion(verificar1)) Then
            'Roll de secretari@'
            Me.Hide()
            admin.Show()
            a.btn_borrar.Visible = False

        ElseIf (con.Verificacion(verificar2)) Then
            'Roll de usuario'
            Me.Hide()
            admin.Show()
            a.btn_borrar.Visible = False
            a.btn_insertar.Visible = False
            a.btn_editar.Visible = False
            a.Label2.Visible = False
            a.Label3.Visible = False
            a.Label4.Visible = False
            a.Label6.Visible = False
            a.Label7.Visible = False
            a.txt_id.Visible = False
            a.txt_nombre.Visible = False
            a.txt_correo.Visible = False
            a.txt_pais.Visible = False
            a.txt_ocupacion.Visible = False
        Else
            'Mensaje por si el usuario y/o la contraseña no existen'
            MessageBox.Show("La contraseña o el usuario es incorrecta")
        End If



    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btn_cerrar.Click
        'Boton para cerrar el programa'
        Me.Close()
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        txt_usuario.Text = ""
        txt_contraseña.Text = ""
    End Sub
End Class
