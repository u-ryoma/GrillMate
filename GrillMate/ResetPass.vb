Imports Microsoft.Data.SqlClient

Public Class restPass

    Private connectionString As String = "Server=.\SQLEXPRESS01;Database=GrillMate;Trusted_Connection=True;TrustServerCertificate=True"

    Private Sub cancelBtn_Click(sender As Object, e As EventArgs) Handles cancelBtn.Click
        Me.Hide()
        Login.Show()
    End Sub

    Private Sub resetBtn_Click(sender As Object, e As EventArgs) Handles resetBtn.Click
        Dim username As String = txtUserName.Text.Trim()
        Dim oldPass As String = txtPass.Text.Trim()
        Dim newPass As String = txtNewPass.Text.Trim()
        Dim confirmPass As String = txtConfPass.Text.Trim()

        ' Basic validation
        If username = "" Or oldPass = "" Or newPass = "" Or confirmPass = "" Then
            MessageBox.Show("⚠ Please fill all fields.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Password complexity check
        If newPass.Length < 6 Then
            MessageBox.Show("New password must be at least 6 characters.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Check if new passwords match
        If newPass <> confirmPass Then
            MessageBox.Show("New passwords do not match.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        ' Check if old password matches
        If Not CheckOldPassword(username, oldPass) Then
            MessageBox.Show("Old password is incorrect.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        ' Update password
        If UpdatePassword(username, newPass) Then
            MessageBox.Show("Password updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtUserName.Clear()
            txtPass.Clear()
            txtNewPass.Clear()
            txtConfPass.Clear()
        Else
            MessageBox.Show("Failed to update password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    ' Check old password function
    Private Function CheckOldPassword(username As String, oldPass As String) As Boolean
        Try
            Using conn As New SqlConnection(connectionString)
                conn.Open()
                Dim query As String = "SELECT COUNT(*) FROM gUser WHERE Username=@u AND Password=@p"
                Using cmd As New SqlCommand(query, conn)
                    cmd.Parameters.Add("@u", SqlDbType.VarChar).Value = username
                    cmd.Parameters.Add("@p", SqlDbType.VarChar).Value = oldPass
                    Dim count As Integer = Convert.ToInt32(cmd.ExecuteScalar())
                    Return count > 0
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error checking old password: " & ex.Message)
            Return False
        End Try
    End Function

    ' Update password function
    Private Function UpdatePassword(username As String, newPass As String) As Boolean
        Try
            Using conn As New SqlConnection(connectionString)
                conn.Open()
                Dim query As String = "UPDATE gUser SET Password=@p WHERE Username=@u"
                Using cmd As New SqlCommand(query, conn)
                    cmd.Parameters.Add("@u", SqlDbType.VarChar).Value = username
                    cmd.Parameters.Add("@p", SqlDbType.VarChar).Value = newPass
                    Dim rows As Integer = cmd.ExecuteNonQuery()
                    Return rows > 0
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error updating password: " & ex.Message)
            Return False
        End Try
    End Function

    Private Sub txtPass_TextChanged(sender As Object, e As EventArgs) Handles txtPass.TextChanged
        txtPass.PasswordChar = "*"c
    End Sub

    Private Sub txtNewPass_TextChanged(sender As Object, e As EventArgs) Handles txtNewPass.TextChanged
        txtNewPass.PasswordChar = "*"c
    End Sub

    Private Sub txtConfPass_TextChanged(sender As Object, e As EventArgs) Handles txtConfPass.TextChanged
        txtConfPass.PasswordChar = "*"c
    End Sub
End Class