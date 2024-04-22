
Imports MySql.Data.MySqlClient
Public Class Form3

    Dim conn As MySqlConnection
    Dim SQL As String
    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form1.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim myCommand As New MySqlCommand

        conn = New MySqlConnection()
        conn.ConnectionString = "server=localhost;user id=root;" &
                                "password=;database=db_perpustakaan"
        Try
            If TextBoxPassword.Text = TextBoxRetype.Text Then
                conn.Open()
                SQL = "INSERT INTO Login (Username, Password) VALUES " &
                      "('" & TextBoxUserName.Text & "', '" & TextBoxPassword.Text & "')"

                myCommand.Connection = conn
                myCommand.CommandText = SQL
                myCommand.ExecuteNonQuery()

                MsgBox("Data baru tersimpan")

                conn.Close()
                Me.Close()
            Else
                MsgBox("RETYPE PASSWORD TIDAK SAMA DENGAN PASSWORD")
                TextBoxUsername.Focus()
            End If
        Catch myerror As MySqlException
            MessageBox.Show("Error: " & myerror.Message)
        Finally
            conn.Dispose()
        End Try
    End Sub
End Class