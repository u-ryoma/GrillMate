Imports Microsoft.Data.SqlClient
Public Class History_staff

    Public Sub DGV_load()
        DataGridView1.Rows.Clear()
        Dim conn As New SqlConnection("Server=.\SQLEXPRESS01;Database=GrillMate;Trusted_Connection=True;TrustServerCertificate=True")
        Dim dr As SqlDataReader

        Try
            conn.Open()
            Dim cmd As New SqlCommand("SELECT * FROM billingM", conn)
            dr = cmd.ExecuteReader()

            Dim totalSum As Decimal = 0

            While dr.Read
                DataGridView1.Rows.Add(
                    dr("TransactID"),
                    dr("Items"),
                    dr("Total"),
                    dr("TableNumber"),
                    dr("AmountPaid"),
                    dr("Change"),
                    dr("PaymentMethod"),
                    dr("TransactionDate")
                )

                ' ✅ Add up total for each row
                totalSum += Convert.ToDecimal(dr("Total"))
            End While

            dr.Close()

            ' ✅ Update total label at the bottom
            TotalOfGridView.Text = "Total : ₱ " & totalSum.ToString("N2")

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub History_staff_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DGV_load()
    End Sub

End Class
