Imports MySql.Data.MySqlClient

Public Class Form5

    Dim conn As MySqlConnection
    Dim Sql As String
    Dim Jekel As String

    Sub Kosongkan()
        TextBoxNoTransaksi.Text = ""
        TextBoxDenda.Text = ""

    End Sub

    Sub DataLoad()
        Dim MyCommand As New MySqlCommand
        Dim MyAdapter As New MySqlDataAdapter
        Dim MyData As New DataTable

        conn = New MySqlConnection
        conn.ConnectionString = "server=localhost;user id=root;password=;database=test;"

        Try
            If conn.State = ConnectionState.Closed Then conn.Open()
            Sql = "Select*From datatransaksi;"

            MyCommand.Connection = conn
            MyCommand.CommandText = Sql

            MyAdapter.SelectCommand = MyCommand
            MyAdapter.Fill(MyData)
            With DataGridViewDataBuku
                .DataSource = MyData
                .AllowUserToAddRows = False
                .AllowUserToDeleteRows = False
                .ReadOnly = True

                .Columns(0).HeaderText = "NoTransaksi"
                .Columns(1).HeaderText = "No anggota"
                .Columns(2).HeaderText = "Kode Buku"
                .Columns(3).HeaderText = "Tanggal Pengambilan"
                .Columns(4).HeaderText = "Tanggal Pengembalian"
                .Columns(0).Width = 50
                .Columns(1).Width = 100
                .Columns(2).Width = 100
                .Columns(3).Width = 100
                .Columns(4).Width = 50
            End With

            conn.Close()
        Catch myerror As MySqlException
            MessageBox.Show("Error: " & myerror.Message)
        Finally
            conn.Dispose()
        End Try
    End Sub

    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DataLoad()
    End Sub

    Private Sub DataGridViewDataBuku_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewDataBuku.CellContentClick
        TextBoxNoTransaksi.Text = DataGridViewDataBuku.CurrentRow.Cells(0).Value
        TextBoxDenda.Text = 0
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim myCommand As New MySqlCommand

        conn = New MySqlConnection()
        conn.ConnectionString = "server=localhost;user id=root;" &
                                "password=;database=test"
        Try
            conn.Open()
            myCommand.Connection = conn

            Sql = "delete from datatransaksi where noTransaksi='" & TextBoxNoTransaksi.Text & "';"

            myCommand.Connection = conn
            myCommand.CommandText = Sql
            myCommand.ExecuteNonQuery()

            conn.Close()

            MsgBox("Buku Berhasil dikembalikan")



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