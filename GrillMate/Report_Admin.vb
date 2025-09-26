Imports Microsoft.Data.SqlClient
Public Class Report_Admin


    Private Sub Report_Admin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DGV_load()
    End Sub
    Public Sub DGV_load()
        DataGridView1.Rows.Clear()
        Dim conn As New SqlConnection("Server=.\SQLEXPRESS01;Database=GrillMate;Trusted_Connection=True;TrustServerCertificate=True")
        Dim i As Integer
        Dim dr As SqlDataReader
        Dim selectedRowIndex As Integer = -1

        Try
            conn.Open()
            Dim cmd As New SqlCommand("SELECT * FROM billingM", conn)
            dr = cmd.ExecuteReader
            While dr.Read
                DataGridView1.Rows.Add(dr.Item("TransactID"), dr.Item("Items"), dr.Item("Total"), dr.Item("TableNumber"), dr.Item("AmountPaid"), dr.Item("Change"), dr.Item("PaymentMethod"), dr.Item("TransactionDate"))
            End While
            dr.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub
End Class