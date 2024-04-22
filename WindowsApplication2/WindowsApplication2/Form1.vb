Imports MySql.Data.MySqlClient

Public Class Form1

    Dim conn As MySqlConnection
    Dim Sql As String
    Dim Jekel As String

    Function cekSkalar()
        Dim myCommand As New MySqlCommand

        conn = New MySqlConnection()
        conn.ConnectionString = "server=localhost;user id=root;" &
                                "password=;database=db_perpustakaan"
        conn.Open()
        myCommand.Connection = conn
        Sql = "Select*from databuku where KodeBuku='123';"
        myCommand.CommandText = Sql
        Dim A As String = myCommand.ExecuteScalar()
        Return A
    End Function

    Sub Kosongkan()
        TextBoxJudul.Text = ""
        TextBoxKodeBuku.Text = ""
        TextBoxPenerbit.Text = ""
        TextBoxPenulis.Text = ""
        TextBoxTahun.Text = ""
    End Sub

    Sub DataLoad()
        Dim MyCommand As New MySqlCommand
        Dim MyAdapter As New MySqlDataAdapter
        Dim MyData As New DataTable

        conn = New MySqlConnection
        conn.ConnectionString = "server=localhost;user id=root;password=;database=db_perpustakaan;"

        Try
            If conn.State = ConnectionState.Closed Then conn.Open()
            Sql = "Select*From databuku;"

            MyCommand.Connection = conn
            MyCommand.CommandText = Sql

            MyAdapter.SelectCommand = MyCommand
            MyAdapter.Fill(MyData)
            With DataGridViewDataBuku
                .DataSource = MyData
                .AllowUserToAddRows = False
                .AllowUserToDeleteRows = False
                .ReadOnly = True

                .Columns(0).HeaderText = "Kode Buku"
                .Columns(1).HeaderText = "Judul"
                .Columns(2).HeaderText = "Penulis"
                .Columns(3).HeaderText = "Penerbit"
                .Columns(4).HeaderText = "Tahun"
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



    Private Sub ButtonTambah_Click(sender As Object, e As EventArgs) Handles ButtonTambah.Click
        Dim myCommand As New MySqlCommand

        conn = New MySqlConnection()
        conn.ConnectionString = "server=localhost;user id=root;" &
                                "password=;database=db_perpustakaan"
        Try
            conn.Open()
            myCommand.Connection = conn
            Sql = "Select*from databuku where KodeBuku='" & TextBoxKodeBuku.Text & "';"
            myCommand.CommandText = Sql
            Dim A As String = myCommand.ExecuteScalar
            If A Is cekSkalar() Then
                Sql = "INSERT INTO databuku (KodeBuku, Judul,Penulis,Penerbit,Tahun) VALUES " &
                  "('" & TextBoxKodeBuku.Text & "', '" & TextBoxJudul.Text & "','" & TextBoxPenulis.Text & "','" & TextBoxPenerbit.Text & "','" & TextBoxTahun.Text & "')"

                myCommand.Connection = conn
                myCommand.CommandText = Sql
                myCommand.ExecuteNonQuery()

                MsgBox("Data baru tersimpan")
            Else
                MessageBox.Show("Data Dengan Kode Buku : " & TextBoxKodeBuku.Text & "Sudah ada")
            End If

            Kosongkan()
            DataLoad()

            conn.Close()
        Catch myerror As MySqlException
            MessageBox.Show("Error: " & myerror.Message)
        Finally
            conn.Dispose()
        End Try
    End Sub

    Private Sub ButtonSimpan_Click(sender As Object, e As EventArgs) Handles ButtonSimpan.Click
        Dim myCommand As New MySqlCommand

        conn = New MySqlConnection()
        conn.ConnectionString = "server=localhost;user id=root;" &
                                "password=;database=db_perpustakaan"
        Try
            conn.Open()

            Sql = "Update databuku SET Judul=" & "'" & TextBoxJudul.Text & "',Penulis='" & TextBoxPenulis.Text & "',Penerbit='" & TextBoxPenerbit.Text & "',Tahun='" & TextBoxTahun.Text & "' where KodeBuku='" & TextBoxKodeBuku.Text & "'"
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

    Private Sub DataGridViewDataBuku_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewDataBuku.CellContentClick
        TextBoxKodeBuku.Text = DataGridViewDataBuku.CurrentRow.Cells(0).Value
        TextBoxJudul.Text = DataGridViewDataBuku.CurrentRow.Cells(1).Value
        TextBoxPenulis.Text = DataGridViewDataBuku.CurrentRow.Cells(2).Value
        TextBoxPenerbit.Text = DataGridViewDataBuku.CurrentRow.Cells(3).Value
        TextBoxTahun.Text = DataGridViewDataBuku.CurrentRow.Cells(4).Value
    End Sub

    Private Sub GroupBox2_Enter(sender As Object, e As EventArgs) Handles GroupBox2.Enter

    End Sub

    Private Sub ButtonDelete_Click(sender As Object, e As EventArgs) Handles ButtonDelete.Click
        Dim myCommand As New MySqlCommand

        conn = New MySqlConnection()
        conn.ConnectionString = "server=localhost;user id=root;" &
                                "password=;database=db_perpustakaan"
        Try
            conn.Open()
            Sql = "Delete from databuku where KodeBuku='" & TextBoxKodeBuku.Text & "';"
            myCommand.Connection = conn
            myCommand.CommandText = Sql
            myCommand.ExecuteNonQuery()

            MsgBox("Data Berhasil Di Hapus")

            Kosongkan()
            DataLoad()

            conn.Close()
        Catch myerror As MySqlException
            MessageBox.Show("Error: " & myerror.Message)
        Finally
            conn.Dispose()
        End Try

    End Sub



    Private Sub ButtonEdit_Click(sender As Object, e As EventArgs) Handles ButtonEdit.Click
        Me.Close()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DataLoad()
    End Sub

    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Form2.Visible = True
        Form2.TextBoxUserName.Text = ""
        Form2.TextBoxPassword.Text = ""
    End Sub
End Class
