
Imports MySql.Data.MySqlClient
Public Class Form2
    Dim conn As MySqlConnection
    Dim SQL As String
    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles ButtonLogin.Click
        Try
            Dim myCommand As New MySqlCommand
            Dim myReader As MySqlDataReader

            conn = New MySqlConnection()
            conn.ConnectionString = "server=localhost;user id=root;" &
                                "password=;database=test"

            If conn.State = ConnectionState.Closed Then conn.Open()
            SQL = "select * from login where Username = '" & TextBoxUserName.Text & "' and Password = '" & TextBoxPassword.Text & "'"
            myCommand = New MySqlCommand(Sql, conn)
            myReader = myCommand.ExecuteReader
            If myReader.HasRows Then
                MDIParent1.Show()
                Me.Visible = False
            Else
                myReader.Close()
                MessageBox.Show("Login gagal, username atau Password salah", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                TextBoxUserName.Text = "    "
                TextBoxPassword.Text = ""
                TextBoxUsername.Focus()
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub ButtonBatal_Click(sender As Object, e As EventArgs) Handles ButtonBatal.Click
        Form1.Close()
        Me.Close()
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Form3.Show()
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class