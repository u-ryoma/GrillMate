Imports Microsoft.Data.SqlClient

Public Class staffForm

    Dim conn As New SqlConnection("Server=.\SQLEXPRESS01;Database=GrillMate;Trusted_Connection=True;TrustServerCertificate=True")
    Dim i As Integer
    Dim dr As SqlDataReader
    Dim selectedRowIndex As Integer = -1



    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        dateTime.Text = Date.Now.ToString("MMMM dd, yyyy hh:mm:ss tt")

    End Sub




    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim msgResult As DialogResult = MessageBox.Show("Are you sure you want to logout?", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
        If msgResult = DialogResult.Yes Then
            Me.Close()
            Login.Show()
        End If

    End Sub






    Public Sub switchPanel(ByVal panel As Form)
        Panel1.Controls.Clear()  ' Clear existing controls in the panel
        panel.TopLevel = False   ' Set the form to be non-top-level
        panel.FormBorderStyle = FormBorderStyle.None  ' Remove borders
        panel.Dock = DockStyle.Fill  ' Dock the form to fill the panel
        Panel1.Controls.Add(panel)  ' Add the form to the panel's controls
        Panel1.Tag = panel  ' Optionally set the panel's tag to the form
        panel.Show()  ' Show the form
    End Sub

    Private Sub OrderHistorybtn_Click(sender As Object, e As EventArgs) Handles OrderHistorybtn.Click
        switchPanel(New History_staff())  ' Instantiating a new form to be displayed in the panel
    End Sub

    Private Sub Deliverybtn_Click(sender As Object, e As EventArgs) Handles Delivirybtn.Click
        switchPanel(New Delivery_staff())  ' Same here, instantiate a new form for delivery
    End Sub

    Private Sub Reservationbtn_Click(sender As Object, e As EventArgs) Handles Reservationbtn.Click
        switchPanel(New Reservation_staff())  ' Instantiate a new reservation form
    End Sub

    Private Sub Orderbtn_Click(sender As Object, e As EventArgs) Handles Orderbtn.Click
        switchPanel(New Ordering_staff())
    End Sub
End Class
