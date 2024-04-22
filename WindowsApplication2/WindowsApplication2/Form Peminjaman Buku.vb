Imports MySql.Data.MySqlClient

Public Class Form4
    Dim conn As MySqlConnection
    Dim Sql As String
    Dim Jekel As String

    Function CekKodeBuku()
        Dim myCommand As New MySqlCommand

        conn = New MySqlConnection()
        conn.ConnectionString = "server=localhost;user id=root;" &
                                "password=;database=test"
        conn.Open()
        myCommand.Connection = conn
        Sql = "Select*from databuku where KodeBuku='" & TextBoxKodeBuku.Text & "';"
        myCommand.CommandText = Sql
        Dim A As String = myCommand.ExecuteScalar
        If A = cekSkalar() Then
            Return "Tidak Ada"
        End If

        Return "Ada"

        conn.Close()
    End Function

    Function CekNoAnggota()
        Dim myCommand As New MySqlCommand

        conn = New MySqlConnection()
        conn.ConnectionString = "server=localhost;user id=root;" &
                                "password=;database=test"
        conn.Open()
        myCommand.Connection = conn
        Sql = "Select*from anggota where NoAnggota='" & TextBoxNoAnggota.Text & "';"
        myCommand.CommandText = Sql
        Dim A As String = myCommand.ExecuteScalar
        If A = cekSkalar() Then
            Return "Tidak Ada"
        End If

        Return "Ada"

        conn.Close()
    End Function

    Function cekSkalar()
        Dim myCommand As New MySqlCommand

        conn = New MySqlConnection()
        conn.ConnectionString = "server=localhost;user id=root;" &
                                "password=;database=test"
        conn.Open()
        myCommand.Connection = conn
        Sql = "Select*from databuku where KodeBuku='123';"
        myCommand.CommandText = Sql
        Dim A As String = myCommand.ExecuteScalar()
        Return A
    End Function

    Sub kosongkan()
        TextBoxKodeBuku.Text = ""
        TextBoxNoAnggota.Text = ""
        TextBoxHarga.Text = ""
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
    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DataLoad()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles ButtonPinjam.Click

        If CekKodeBuku() = "Tidak Ada" Then
            MessageBox.Show("Kode Buku Tidak ada")
            TextBoxKodeBuku.Focus()
        ElseIf CekNoAnggota() = "Tidak Ada" Then
            MessageBox.Show("No Anggota Tidak ada")
            TextBoxNoAnggota.Focus()
        Else
            Dim myCommand As New MySqlCommand
            conn = New MySqlConnection()
            conn.ConnectionString = "server=localhost;user id=root;" &
                                    "password=;database=test"
            Try
                conn.Open()
                myCommand.Connection = conn

                Sql = "INSERT INTO datatransaksi (NoAnggota,KodeBuku,TanggalPengambilan,TanggalPengembalian,Harga) VALUES " &
                      "('" & TextBoxNoAnggota.Text & "', '" & TextBoxKodeBuku.Text & "','" & DateTimePickerPengambilan.Text & "','" & DateTimePickerPengembalian.Text & "','" & TextBoxHarga.Text & "');"

                myCommand.Connection = conn
                myCommand.CommandText = Sql
                myCommand.ExecuteNonQuery()

                MsgBox("Data baru tersimpan")

                kosongkan()
                DataLoad()

                conn.Close()
            Catch myerror As MySqlException
                MessageBox.Show("Error: " & myerror.Message)
            Finally
                conn.Dispose()
            End Try
        End If




    End Sub

    Private Sub ButtonCancel_Click(sender As Object, e As EventArgs) Handles ButtonCancel.Click
        Me.Close()
    End Sub

    Private Sub TextBoxKodeBuku_TextChanged(sender As Object, e As EventArgs) Handles TextBoxKodeBuku.TextChanged
        TextBoxHarga.Text = "10000"
    End Sub

    Private Sub DataGridViewDataBuku_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewDataBuku.CellContentClick

    End Sub
End Class