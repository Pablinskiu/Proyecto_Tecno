'Librerias de sql'
Imports System.Data.SqlClient
Public Class admin
    'Creacion de nueva conexion y sentencia'
    Dim con As SqlConnection = New SqlConnection(My.Settings.conexion)
    Dim sentencia As String
    'Creacion de una clase para que ejecute la sentencia'
    Public Sub Ejecutarsql(ByVal sql As String)

        Try
            Dim cmd As New SqlCommand(sql, con)
            con.Open()
            cmd.ExecuteNonQuery()
            con.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btn_regresar.Click
        'Boton para regresar al Login'
        Form1.Show()
        Me.Close()
    End Sub

    Private Sub admin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btn_cargar_Click(sender As Object, e As EventArgs) Handles btn_cargar.Click
        'Declaramos las variables para que muestre la tabla en el datagridview'
        Dim con As New SqlConnection(My.Settings.conexion)
        Dim sql As String = "Select id,  nombre, correo, pais, ocupacion from usuarios2"
        Dim cmd As New SqlCommand(sql, con)

        Try
            Dim da As New SqlDataAdapter(cmd)
            Dim ds As New DataSet
            da.Fill(ds, "usuarios2")

            Me.DGV1.DataSource = ds.Tables("usuarios2")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btn_insertar_Click(sender As Object, e As EventArgs) Handles btn_insertar.Click
        'Llamamos a la sentencia para que inserte un valor nuevo en los diferentes campos que queremos llenar'
        sentencia = "Insert into usuarios2 values (" + txt_id.Text + ", '" + txt_nombre.Text + "','" + txt_correo.Text + "','" + txt_pais.Text + "','" + txt_ocupacion.Text + "') "

        Ejecutarsql(sentencia)
        Try
            Dim da As New SqlDataAdapter("Select * from usuarios2", con)
            Dim ds As New DataSet
            da.Fill(ds)
            Me.DGV1.DataSource = ds.Tables(0)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btn_borrar_Click(sender As Object, e As EventArgs) Handles btn_borrar.Click
        sentencia = "Delete usuarios2 Where id=" + txt_id.Text + ""
        Ejecutarsql(sentencia)
        Try
            Dim da As New SqlDataAdapter("Select * from usuarios2", con)
            Dim ds As New DataSet
            da.Fill(ds)
            Me.DGV1.DataSource = ds.Tables(0)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btn_editar_Click(sender As Object, e As EventArgs) Handles btn_editar.Click
        sentencia = "Update usuarios2 set nombre='" + txt_nombre.Text + "',correo='" + txt_correo.Text + "',pais='" + txt_pais.Text + "',ocupacion='" + txt_ocupacion.Text + "'  Where id= " + txt_id.Text + ""
        Ejecutarsql(sentencia)
        Try
            Dim da As New SqlDataAdapter("Select *from usuarios2", con)
            Dim ds As New DataSet
            da.Fill(ds)
            Me.DGV1.DataSource = ds.Tables(0)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btn_limpiar_Click(sender As Object, e As EventArgs) Handles btn_limpiar.Click
        txt_id.Text = ""
        txt_nombre.Text = ""
        txt_correo.Text = ""
        txt_pais.Text = ""
        txt_ocupacion.Text = ""
    End Sub
End Class