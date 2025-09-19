Imports Microsoft.Data.SqlClient

Public Class staffForm

    Dim conn As New SqlConnection("Server=.\SQLEXPRESS01;Database=GrillMate;Trusted_Connection=True;TrustServerCertificate=True")
    Dim i As Integer
    Dim dr As SqlDataReader
    Dim selectedRowIndex As Integer = -1



    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        dateTime.Text = Date.Now.ToString("MMMM dd, yyyy hh:mm:ss tt")
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


            Dim cmd As New SqlCommand("SELECT * FROM Grillm WHERE LEFT([Product Number], 2) LIKE @searchText OR LEFT([Product Name], 2) LIKE @searchText", conn)


            Dim searchText As String = txtSearch.Text
            If searchText.Length >= 2 Then

                cmd.Parameters.AddWithValue("@searchText", searchText.Substring(0, 2) + "%")
            Else

                cmd.Parameters.AddWithValue("@searchText", searchText + "%")
            End If

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

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim msgResult As DialogResult = MessageBox.Show("Are you sure you want to logout?", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
        If msgresult = DialogResult.Yes Then
            Me.Close()
            Login.Show()
        End If

    End Sub




    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick

        If e.RowIndex >= 0 Then
            selectedRowIndex = e.RowIndex
        End If
    End Sub

    Private Sub btn_add_Click(sender As Object, e As EventArgs) Handles btn_add.Click


        Try
            If selectedRowIndex >= 0 AndAlso selectedRowIndex < DataGridView1.Rows.Count Then
                Dim selectedRow As DataGridViewRow = DataGridView1.Rows(selectedRowIndex)
                Dim productName As String = selectedRow.Cells(1).Value.ToString()
                Dim price As Decimal = Decimal.Parse(selectedRow.Cells(2).Value.ToString())
                Dim quantity As Integer = 1

                If Not String.IsNullOrWhiteSpace(txtbox_quantity.Text) Then
                    If Integer.TryParse(txtbox_quantity.Text, quantity) = False OrElse quantity <= 0 Then
                        quantity = 1
                    End If
                End If

                Dim subtotal As Decimal = price * quantity
                Dim listItem As String = productName & " - " & price.ToString("N2") & " x " & quantity & " = " & subtotal.ToString("N2")
                item_listbox.Items.Add(listItem)
                UpdateTotal()
            Else
                MessageBox.Show("Please select a product first!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information
                                )
            End If
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
        txtbox_quantity.Clear()
    End Sub

    Private Sub btn_remove_Click(sender As Object, e As EventArgs) Handles btn_remove.Click
        If item_listbox.SelectedIndex <> -1 Then
            item_listbox.Items.RemoveAt(item_listbox.SelectedIndex)
            UpdateTotal()
        Else
            MessageBox.Show("Please select an item to remove!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub


    Private Sub UpdateTotal()
        Dim total As Decimal = 0
        For Each item As String In item_listbox.Items

            Dim parts() As String = item.Split("="c)
            If parts.Length = 2 Then
                Dim subtotalStr As String = parts(1).Trim()
                Dim subtotal As Decimal
                If Decimal.TryParse(subtotalStr, subtotal) Then
                    total += subtotal

                End If

            End If

        Next
        totalAmt.Text = total.ToString("N2")

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtbox_amountPd.TextChanged
        Dim totalAmtValue As String = totalAmt.Text.Replace("P", "").Trim()
        Dim totalAmount As Decimal
        If Decimal.TryParse(totalAmt.Text, totalAmount) Then
            Dim amountPaid As Decimal
            ' Ensure amount paid is valid
            If Decimal.TryParse(txtbox_amountPd.Text, amountPaid) Then
                ' Calculate the change
                Dim change As Decimal = amountPaid - totalAmount
                ' Update change label
                lblChange.Text = "P" & change.ToString("N2")
            Else
                lblChange.Text = "P 0.00" ' If invalid, display zero change
            End If
        Else
            lblChange.Text = " P 0.00" ' If total is invalid, display zero change
        End If
    End Sub
End Class