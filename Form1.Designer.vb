<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Login
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Label1 = New Label()
        Label2 = New Label()
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        Button1 = New Button()
        CheckBox1 = New CheckBox()
        Label3 = New Label()
        Button2 = New Button()
        PictureBox1 = New PictureBox()
        rstPass = New Button()
        Panel1 = New Panel()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(81, 203)
        Label1.Name = "Label1"
        Label1.Size = New Size(105, 25)
        Label1.TabIndex = 0
        Label1.Text = "Username: "
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(85, 236)
        Label2.Name = "Label2"
        Label2.Size = New Size(94, 25)
        Label2.TabIndex = 1
        Label2.Text = "Password:"
        ' 
        ' TextBox1
        ' 
        TextBox1.BackColor = SystemColors.Window
        TextBox1.Location = New Point(183, 197)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(201, 31)
        TextBox1.TabIndex = 2
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(182, 233)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(201, 31)
        TextBox2.TabIndex = 3
        ' 
        ' Button1
        ' 
        Button1.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold Or FontStyle.Underline, GraphicsUnit.Point, CByte(0))
        Button1.Location = New Point(162, 305)
        Button1.Name = "Button1"
        Button1.Size = New Size(112, 34)
        Button1.TabIndex = 4
        Button1.Text = "Login"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' CheckBox1
        ' 
        CheckBox1.AutoSize = True
        CheckBox1.Font = New Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        CheckBox1.Location = New Point(182, 270)
        CheckBox1.Name = "CheckBox1"
        CheckBox1.Size = New Size(158, 29)
        CheckBox1.TabIndex = 5
        CheckBox1.Text = "Show Password"
        CheckBox1.UseVisualStyleBackColor = True
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Impact", 20F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(143, 136)
        Label3.Name = "Label3"
        Label3.Size = New Size(267, 48)
        Label3.TabIndex = 6
        Label3.Text = "Mookbang Grill"
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.IndianRed
        Button2.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold Or FontStyle.Underline, GraphicsUnit.Point, CByte(0))
        Button2.Location = New Point(276, 305)
        Button2.Name = "Button2"
        Button2.Size = New Size(107, 34)
        Button2.TabIndex = 7
        Button2.Text = "Cancel"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources._541676697_1410484700011907_136284718760142683_n
        PictureBox1.Location = New Point(102, 35)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(321, 98)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 8
        PictureBox1.TabStop = False
        ' 
        ' rstPass
        ' 
        rstPass.Font = New Font("Segoe UI", 6F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        rstPass.Location = New Point(200, 345)
        rstPass.Name = "rstPass"
        rstPass.Size = New Size(140, 25)
        rstPass.TabIndex = 9
        rstPass.Text = "Reset Password"
        rstPass.UseVisualStyleBackColor = True
        ' 
        ' Panel1
        ' 
        Panel1.Anchor = AnchorStyles.None
        Panel1.Controls.Add(rstPass)
        Panel1.Controls.Add(PictureBox1)
        Panel1.Controls.Add(Button2)
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(CheckBox1)
        Panel1.Controls.Add(Button1)
        Panel1.Controls.Add(TextBox2)
        Panel1.Controls.Add(TextBox1)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(Label1)
        Panel1.Location = New Point(140, 12)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(540, 405)
        Panel1.TabIndex = 10
        ' 
        ' Login
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.Control
        ClientSize = New Size(800, 450)
        Controls.Add(Panel1)
        DoubleBuffered = True
        Name = "Login"
        StartPosition = FormStartPosition.CenterScreen
        Text = "  Login"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents rstPass As Button
    Friend WithEvents Panel1 As Panel

End Class
