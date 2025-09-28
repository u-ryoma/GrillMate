<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class adminForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.

    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(adminForm))
        BackButton = New Button()
        Timer1 = New Timer(components)
        timeDate = New Label()
        Managebtn = New Button()
        ReportBtn = New Button()
        Panel1 = New Panel()
        PictureBox1 = New PictureBox()
        Panel1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' BackButton
        ' 
        BackButton.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        BackButton.Location = New Point(3, 923)
        BackButton.Name = "BackButton"
        BackButton.Size = New Size(112, 53)
        BackButton.TabIndex = 9
        BackButton.Text = "Logout"
        BackButton.UseVisualStyleBackColor = True
        ' 
        ' Timer1
        ' 
        Timer1.Enabled = True
        Timer1.Interval = 1000
        ' 
        ' timeDate
        ' 
        timeDate.AutoSize = True
        timeDate.Font = New Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        timeDate.Location = New Point(1463, 938)
        timeDate.Name = "timeDate"
        timeDate.Size = New Size(151, 38)
        timeDate.TabIndex = 12
        timeDate.Text = "Date/Time"
        ' 
        ' Managebtn
        ' 
        Managebtn.BackColor = Color.DarkRed
        Managebtn.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Managebtn.ForeColor = Color.White
        Managebtn.Location = New Point(14, 6)
        Managebtn.Name = "Managebtn"
        Managebtn.Size = New Size(290, 43)
        Managebtn.TabIndex = 35
        Managebtn.Text = "Manage"
        Managebtn.UseVisualStyleBackColor = False
        ' 
        ' ReportBtn
        ' 
        ReportBtn.BackColor = Color.DarkRed
        ReportBtn.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        ReportBtn.ForeColor = Color.White
        ReportBtn.Location = New Point(301, 6)
        ReportBtn.Name = "ReportBtn"
        ReportBtn.Size = New Size(290, 43)
        ReportBtn.TabIndex = 36
        ReportBtn.Text = "Reports"
        ReportBtn.UseVisualStyleBackColor = False
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(PictureBox1)
        Panel1.Location = New Point(12, 55)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1874, 862)
        Panel1.TabIndex = 37
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(2, 3)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(1878, 856)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' adminForm
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.DarkGray
        ClientSize = New Size(1374, 820)
        Controls.Add(Panel1)
        Controls.Add(ReportBtn)
        Controls.Add(Managebtn)
        Controls.Add(timeDate)
        Controls.Add(BackButton)
        MaximizeBox = False
        MinimizeBox = False
        Name = "adminForm"
        Text = "GrillMate.Admin"
        WindowState = FormWindowState.Maximized
        Panel1.ResumeLayout(False)
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents BackButton As Button
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Timer1 As Timer
    Friend WithEvents timeDate As Label
    Friend WithEvents Managebtn As Button
    Friend WithEvents ReportBtn As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox1 As PictureBox
End Class