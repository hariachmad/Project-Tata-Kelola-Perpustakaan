Imports MySql.Data.MySqlClient

Public Class Form6

    Dim conn As MySqlConnection
    Dim Sql As String
    Dim Jekel As String

    Sub Kosongkan()
        TextBoxNamaLengkap.Text = ""
        TextBoxAlamat.Text = ""
        TextBoxNoKtp.Text = ""
        TextBoxNoAnggota.Text = ""
    End Sub

    Sub DataLoad()
        Dim MyCommand As New MySqlCommand
        Dim MyAdapter As New MySqlDataAdapter
        Dim MyData As New DataTable

        conn = New MySqlConnection
        conn.ConnectionString = "server=localhost;user id=root;password=;database=test;"

        Try
            If conn.State = ConnectionState.Closed Then conn.Open()
            Sql = "Select*From anggota;"

            MyCommand.Connection = conn
            MyCommand.CommandText = Sql

            MyAdapter.SelectCommand = MyCommand
            MyAdapter.Fill(MyData)
            With DataGridView1
                .DataSource = MyData
                .AllowUserToAddRows = False
                .AllowUserToDeleteRows = False
                .ReadOnly = True

                .Columns(0).HeaderText = "NoAnggota"
                .Columns(1).HeaderText = "NoKtp"
                .Columns(2).HeaderText = "NamaLenglap"
                .Columns(3).HeaderText = "Alamat"
                .Columns(0).Width = 50
                .Columns(1).Width = 100
                .Columns(2).Width = 100
                .Columns(3).Width = 100
            End With

            conn.Close()
        Catch myerror As MySqlException
            MessageBox.Show("Error: " & myerror.Message)
        Finally
            conn.Dispose()
        End Try
    End Sub

    Private Sub Form6_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DataLoad()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim myCommand As New MySqlCommand

        conn = New MySqlConnection()
        conn.ConnectionString = "server=localhost;user id=root;" &
                                "password=;database=test"
        Try
            conn.Open()
            myCommand.Connection = conn

            Sql = "INSERT INTO anggota (NoAnggota, NoKtp,NamaLengkap,Alamat) VALUES " &
                  "('" & TextBoxNoAnggota.Text & "', '" & TextBoxNoKtp.Text & "','" & TextBoxNamaLengkap.Text & "','" & TextBoxAlamat.Text & "');"

            myCommand.Connection = conn
                myCommand.CommandText = Sql
                myCommand.ExecuteNonQuery()

            MsgBox("Data baru tersimpan")

            Kosongkan()
            DataLoad()

            conn.Close()
        Catch myerror As MySqlException
            MessageBox.Show("Error: " & myerror.Message)
        Finally
            conn.Dispose()
        End Try
    End Sub
End Class