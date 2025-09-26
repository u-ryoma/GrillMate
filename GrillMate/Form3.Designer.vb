<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class staffForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(staffForm))
        Label1 = New Label()
        Button5 = New Button()
        Reservationbtn = New Button()
        Delivirybtn = New Button()
        OrderHistorybtn = New Button()
        Orderbtn = New Button()
        Button1 = New Button()
        dateTime = New Label()
        Timer1 = New Timer(components)
        Panel1 = New Panel()
        PictureBox1 = New PictureBox()
        Panel1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.Location = New Point(0, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(100, 23)
        Label1.TabIndex = 64
        ' 
        ' Button5
        ' 
        Button5.BackColor = Color.DarkRed
        Button5.Font = New Font("Segoe UI Semibold", 10F, FontStyle.Bold)
        Button5.ForeColor = Color.White
        Button5.Location = New Point(1668, 2)
        Button5.Name = "Button5"
        Button5.Size = New Size(236, 57)
        Button5.TabIndex = 49
        Button5.Text = "asda"
        Button5.UseVisualStyleBackColor = False
        ' 
        ' Reservationbtn
        ' 
        Reservationbtn.BackColor = Color.DarkRed
        Reservationbtn.Font = New Font("Segoe UI Semibold", 10F, FontStyle.Bold)
        Reservationbtn.ForeColor = Color.White
        Reservationbtn.Location = New Point(1257, 2)
        Reservationbtn.Name = "Reservationbtn"
        Reservationbtn.Size = New Size(413, 57)
        Reservationbtn.TabIndex = 48
        Reservationbtn.Text = "Reservation"
        Reservationbtn.UseVisualStyleBackColor = False
        ' 
        ' Delivirybtn
        ' 
        Delivirybtn.BackColor = Color.DarkRed
        Delivirybtn.Font = New Font("Segoe UI Semibold", 10F, FontStyle.Bold)
        Delivirybtn.ForeColor = Color.White
        Delivirybtn.Location = New Point(849, 2)
        Delivirybtn.Name = "Delivirybtn"
        Delivirybtn.Size = New Size(413, 57)
        Delivirybtn.TabIndex = 47
        Delivirybtn.Text = "Delivery"
        Delivirybtn.UseVisualStyleBackColor = False
        ' 
        ' OrderHistorybtn
        ' 
        OrderHistorybtn.BackColor = Color.DarkRed
        OrderHistorybtn.Font = New Font("Segoe UI Semibold", 10F, FontStyle.Bold)
        OrderHistorybtn.ForeColor = Color.White
        OrderHistorybtn.Location = New Point(445, 2)
        OrderHistorybtn.Name = "OrderHistorybtn"
        OrderHistorybtn.Size = New Size(445, 57)
        OrderHistorybtn.TabIndex = 46
        OrderHistorybtn.Text = "History"
        OrderHistorybtn.UseVisualStyleBackColor = False
        ' 
        ' Orderbtn
        ' 
        Orderbtn.BackColor = Color.DarkRed
        Orderbtn.Font = New Font("Segoe UI Semibold", 10F, FontStyle.Bold)
        Orderbtn.ForeColor = Color.White
        Orderbtn.Location = New Point(7, 2)
        Orderbtn.Name = "Orderbtn"
        Orderbtn.Size = New Size(445, 57)
        Orderbtn.TabIndex = 45
        Orderbtn.Text = "Order"
        Orderbtn.UseVisualStyleBackColor = False
        ' 
        ' Button1
        ' 
        Button1.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button1.Location = New Point(0, 911)
        Button1.Name = "Button1"
        Button1.Size = New Size(138, 44)
        Button1.TabIndex = 42
        Button1.Text = "Logout"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' dateTime
        ' 
        dateTime.AutoSize = True
        dateTime.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        dateTime.Location = New Point(1520, 923)
        dateTime.Name = "dateTime"
        dateTime.Size = New Size(88, 32)
        dateTime.TabIndex = 50
        dateTime.Text = "Label1"
        ' 
        ' Timer1
        ' 
        Timer1.Enabled = True
        Timer1.Interval = 1000
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.DarkGray
        Panel1.Controls.Add(PictureBox1)
        Panel1.ForeColor = Color.Black
        Panel1.Location = New Point(7, 65)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1891, 840)
        Panel1.TabIndex = 65
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Anchor = AnchorStyles.None
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(3, 3)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(1887, 834)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' staffForm
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.DarkGray
        ClientSize = New Size(1898, 964)
        Controls.Add(Panel1)
        Controls.Add(dateTime)
        Controls.Add(Button5)
        Controls.Add(Reservationbtn)
        Controls.Add(Delivirybtn)
        Controls.Add(OrderHistorybtn)
        Controls.Add(Orderbtn)
        Controls.Add(Button1)
        Controls.Add(Label1)
        MaximizeBox = False
        MinimizeBox = False
        Name = "staffForm"
        StartPosition = FormStartPosition.CenterScreen
        Text = "GrillMate.Staff"
        WindowState = FormWindowState.Maximized
        Panel1.ResumeLayout(False)
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Button5 As Button
    Friend WithEvents Reservationbtn As Button
    Friend WithEvents Delivirybtn As Button
    Friend WithEvents OrderHistorybtn As Button
    Friend WithEvents Orderbtn As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents dateTime As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox1 As PictureBox
End Class
