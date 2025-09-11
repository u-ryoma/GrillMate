
Imports Microsoft.Data.SqlClient

Public Class adminForm

    Dim conn As New SqlConnection("Server=.\SQLEXPRESS01;Database=GrillMate;Trusted_Connection=True;TrustServerCertificate=True")
    Dim i As Integer
    Dim dr As SqlDataReader


    Private Sub BackButton_Click(sender As Object, e As EventArgs) Handles BackButton.Click
        Me.Close()
        Login.Show()
    End Sub



    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        timeDate.Text = DateTime.Now.ToString("MMMM dd, yyyy hh:mm:ss tt")
    End Sub


    Public Sub save()
        Try
            If conn.State = ConnectionState.Closed Then
                conn.Open()
            End If

            Dim cmd As New SqlCommand("INSERT INTO Grillm ([Product Number], [Product Name], [Price], [Group]) 
                                   VALUES (@ProductNumber, @ProductName, @Price, @Group)", conn)

            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@ProductNumber", txtPrdNum.Text)
            cmd.Parameters.AddWithValue("@ProductName", txtPrdName.Text)
            cmd.Parameters.AddWithValue("@Price", txtPrice.Text)
            cmd.Parameters.AddWithValue("@Group", cmb_boxGrp.Text)

            i = cmd.ExecuteNonQuery()

            If i > 0 Then
                MsgBox("Record Saved!", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MsgBox("Record Not Saved", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            If conn.State = ConnectionState.Open Then
                conn.Close()
            End If
        End Try
        clear()
    End Sub

    Private Sub saveBtn_Click(sender As Object, e As EventArgs) Handles saveBtn.Click
        save()
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

    Private Sub adminForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DGV_load()
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        txtPrdNum.Text = DataGridView1.CurrentRow.Cells(0).Value
        txtPrdName.Text = DataGridView1.CurrentRow.Cells(1).Value
        txtPrice.Text = DataGridView1.CurrentRow.Cells(2).Value
        cmb_boxGrp.Text = DataGridView1.CurrentRow.Cells(3).Value
        txtPrdNum.ReadOnly = True
        saveBtn.Enabled = False
    End Sub

    Public Sub clear()
        txtPrdNum.Clear()
        txtPrdName.Clear()
        txtPrice.Clear()
        cmb_boxGrp.SelectedIndex = -1
    End Sub


    Public Sub edit()
        Try
            If conn.State = ConnectionState.Closed Then
                conn.Open()
            End If

            Dim cmd As New SqlCommand("UPDATE Grillm SET [Product Number] = @ProductNumber, [Product Name] = @ProductName, [Price] = @Price, [Group] = @Group WHERE [Product Number] = @ProductNumber", conn)

            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@ProductNumber", txtPrdNum.Text)
            cmd.Parameters.AddWithValue("@ProductName", txtPrdName.Text)
            cmd.Parameters.AddWithValue("@Price", txtPrice.Text)
            cmd.Parameters.AddWithValue("@Group", cmb_boxGrp.Text)

            i = cmd.ExecuteNonQuery()

            If i > 0 Then
                MsgBox("Record Updated!", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MsgBox("Record Not Updated", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            If conn.State = ConnectionState.Open Then
                conn.Close()
            End If
        End Try
        clear()
        DGV_load()
    End Sub


    Private Sub updBtn_Click(sender As Object, e As EventArgs) Handles updBtn.Click
        edit()
    End Sub

    Public Sub delete()
        If MsgBox("You sure you want to delete this record?", MsgBoxStyle.Question + vbYesNo) = vbYes Then
            Try
                If conn.State = ConnectionState.Closed Then
                    conn.Open()
                End If

                Dim cmd As New SqlCommand("DELETE FROM   Grillm WHERE [Product Number] = @ProductNumber", conn)
                cmd.Parameters.Clear()
                cmd.Parameters.AddWithValue("@ProductNumber", txtPrdNum.Text)


                i = cmd.ExecuteNonQuery()

                If i > 0 Then
                    MsgBox("Record Deleted!", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MsgBox("Delete failed!", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If

            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                If conn.State = ConnectionState.Open Then
                    conn.Close()
                End If
            End Try
            clear()
            DGV_load()
        End If


    End Sub
    Private Sub dltBtn_Click(sender As Object, e As EventArgs) Handles dltBtn.Click
        delete()
    End Sub

    Private Sub clrBtn_Click(sender As Object, e As EventArgs) Handles clrBtn.Click
        clear()
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