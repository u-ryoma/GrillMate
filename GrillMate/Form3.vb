Imports Microsoft.Data.SqlClient

Public Class staffForm

    Dim conn As New SqlConnection("Server=.\SQLEXPRESS01;Database=GrillMate;Trusted_Connection=True;TrustServerCertificate=True")
    Dim i As Integer
    Dim dr As SqlDataReader

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles logoutBtn.Click
        Me.Close()
        Login.Show()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        tD.Text = DateTime.Now.ToString("MMMM dd, yyyy hh:mm:ss tt")
    End Sub

    Private Sub staffForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DGV_load()
    End Sub


    Public Sub DGV_load()
        DataGridView1.Rows.Clear()
        Try
            conn.Open()
            Dim cmd As New SqlCommand("SELECT * FROM Grillm", conn)
            dr = cmd.ExecuteReader
            While dr.Read
                DataGridView1.Rows.Add(dr.Item("Product Number"), dr.Item("Product Name"), dr.Item("Price"), dr.Item("Group"))
            End While
            dr.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()
        End Try



    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        DataGridView1.Rows.Clear()
        Try
            conn.Open()
            Dim cmd As New SqlCommand("SELECT * FROM Grillm WHERE [Product Number] LIKE '%' + @searchText + '%' OR [Product Name] LIKE '%' + @searchText + '%'", conn)
            cmd.Parameters.AddWithValue("@searchText", txtSearch.Text)
            dr = cmd.ExecuteReader
            While dr.Read
                DataGridView1.Rows.Add(dr.Item("Product Number"), dr.Item("Product Name"), dr.Item("Price"), dr.Item("Group"))
            End While
            dr.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

End Class