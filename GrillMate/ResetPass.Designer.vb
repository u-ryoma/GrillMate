<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class restPass
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
        resetBtn = New Button()
        cancelBtn = New Button()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        txtUserName = New TextBox()
        txtPass = New TextBox()
        txtNewPass = New TextBox()
        txtConfPass = New TextBox()
        SuspendLayout()
        ' 
        ' resetBtn
        ' 
        resetBtn.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        resetBtn.Location = New Point(134, 262)
        resetBtn.Name = "resetBtn"
        resetBtn.Size = New Size(92, 31)
        resetBtn.TabIndex = 0
        resetBtn.Text = "Reset"
        resetBtn.UseVisualStyleBackColor = True
        ' 
        ' cancelBtn
        ' 
        cancelBtn.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold Or FontStyle.Underline, GraphicsUnit.Point, CByte(0))
        cancelBtn.Location = New Point(246, 262)
        cancelBtn.Name = "cancelBtn"
        cancelBtn.Size = New Size(92, 31)
        cancelBtn.TabIndex = 1
        cancelBtn.Text = "Cancel"
        cancelBtn.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(52, 65)
        Label1.Name = "Label1"
        Label1.Size = New Size(105, 25)
        Label1.TabIndex = 2
        Label1.Text = "Username : "
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(52, 108)
        Label2.Name = "Label2"
        Label2.Size = New Size(96, 25)
        Label2.TabIndex = 3
        Label2.Text = "Password :"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(52, 147)
        Label3.Name = "Label3"
        Label3.Size = New Size(136, 25)
        Label3.TabIndex = 4
        Label3.Text = "New Password :"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(52, 188)
        Label4.Name = "Label4"
        Label4.Size = New Size(165, 25)
        Label4.TabIndex = 5
        Label4.Text = "Confirm Password :"
        ' 
        ' txtUserName
        ' 
        txtUserName.Location = New Point(166, 63)
        txtUserName.Name = "txtUserName"
        txtUserName.Size = New Size(172, 31)
        txtUserName.TabIndex = 6
        ' 
        ' txtPass
        ' 
        txtPass.Location = New Point(166, 108)
        txtPass.Name = "txtPass"
        txtPass.Size = New Size(172, 31)
        txtPass.TabIndex = 7
        ' 
        ' txtNewPass
        ' 
        txtNewPass.Location = New Point(194, 147)
        txtNewPass.Name = "txtNewPass"
        txtNewPass.Size = New Size(172, 31)
        txtNewPass.TabIndex = 8
        ' 
        ' txtConfPass
        ' 
        txtConfPass.Location = New Point(223, 185)
        txtConfPass.Name = "txtConfPass"
        txtConfPass.Size = New Size(172, 31)
        txtConfPass.TabIndex = 9
        ' 
        ' restPass
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(478, 344)
        ControlBox = False
        Controls.Add(txtConfPass)
        Controls.Add(txtNewPass)
        Controls.Add(txtPass)
        Controls.Add(txtUserName)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(cancelBtn)
        Controls.Add(resetBtn)
        Name = "restPass"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Reset Password"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents resetBtn As Button
    Friend WithEvents cancelBtn As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtUserName As TextBox
    Friend WithEvents txtPass As TextBox
    Friend WithEvents txtNewPass As TextBox
    Friend WithEvents txtConfPass As TextBox
End Class
