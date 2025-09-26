


Public Class adminForm





    Private Sub BackButton_Click(sender As Object, e As EventArgs) Handles BackButton.Click
        Dim msgResult As DialogResult = MessageBox.Show("Are you sure you want to logout?", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
        If msgResult = DialogResult.Yes Then
            Me.Close()
            Login.Show()
        End If
    End Sub



    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        timeDate.Text = DateTime.Now.ToString("MMMM dd, yyyy hh:mm:ss tt")
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

    Private Sub Managebtn_Click(sender As Object, e As EventArgs) Handles Managebtn.Click
        switchPanel(New Manage_Admin())  ' Instantiating a new form to be displayed in the panel

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles ReportBtn.Click
        switchPanel(New Report_Admin())
    End Sub
End Class