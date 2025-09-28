Imports Microsoft.Data.SqlClient

Public Class Report_Admin
    Private connectionString As String = "Server=.\SQLEXPRESS01;Database=GrillMate;Trusted_Connection=True;TrustServerCertificate=True"

    Private Sub Report_Admin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        cmbPayMethod.Items.Clear()
        cmbPayMethod.Items.Add("All")
        cmbPayMethod.Items.Add("Cash")
        cmbPayMethod.Items.Add("GCash")
        cmbPayMethod.SelectedIndex = 0


        dtmpFromDate.Value = Date.Today
        dtmpDateTo.Value = Date.Today


        LoadData()
    End Sub


    Private Sub LoadData()
        DataGridView1.Rows.Clear()
        Dim query As String = "SELECT * FROM billingM WHERE 1=1"


        If txtbSearch.Text.Trim() <> "" Then
            query &= " AND (TransactID LIKE @search OR Items LIKE @search OR TableNumber LIKE @search)"
        End If


        If cmbPayMethod.Text <> "All" AndAlso cmbPayMethod.Text <> "" Then
            query &= " AND PaymentMethod = @paymentMethod"
        End If


        If Not chkAllDates.Checked Then
            query &= " AND CAST(TransactionDate AS DATE) BETWEEN @dateFrom AND @dateTo"
        End If

        Using conn As New SqlConnection(connectionString)
            Try
                conn.Open()
                Dim cmd As New SqlCommand(query, conn)


                If txtbSearch.Text.Trim() <> "" Then
                    cmd.Parameters.AddWithValue("@search", "%" & txtbSearch.Text.Trim() & "%")
                End If

                If cmbPayMethod.Text <> "All" AndAlso cmbPayMethod.Text <> "" Then
                    cmd.Parameters.AddWithValue("@paymentMethod", cmbPayMethod.Text)
                End If

                ' Add date params only if filter is active
                If Not chkAllDates.Checked Then
                    cmd.Parameters.AddWithValue("@dateFrom", dtmpFromDate.Value.Date)
                    cmd.Parameters.AddWithValue("@dateTo", dtmpDateTo.Value.Date)
                End If

                Dim dr As SqlDataReader = cmd.ExecuteReader()
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

                    totalSum += Convert.ToDecimal(dr("Total"))
                End While


                TotalOfGridView.Text = "Total : ₱ " & totalSum.ToString("N2")

                dr.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End Using
    End Sub


    Private Sub txtbSearch_TextChanged(sender As Object, e As EventArgs) Handles txtbSearch.TextChanged
        LoadData()
    End Sub

    Private Sub cmbPayMethod_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbPayMethod.SelectedIndexChanged
        LoadData()
    End Sub

    Private Sub dtmpFromDate_ValueChanged(sender As Object, e As EventArgs) Handles dtmpFromDate.ValueChanged
        LoadData()
    End Sub

    Private Sub dtmpDateTo_ValueChanged(sender As Object, e As EventArgs) Handles dtmpDateTo.ValueChanged
        LoadData()
    End Sub

    Private Sub chkAllDates_CheckedChanged(sender As Object, e As EventArgs) Handles chkAllDates.CheckedChanged
        LoadData()
    End Sub
End Class

