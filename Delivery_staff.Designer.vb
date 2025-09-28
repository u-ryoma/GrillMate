<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Delivery_staff
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
        Label1 = New Label()
        Panel1 = New Panel()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(15, 26)
        Label1.Name = "Label1"
        Label1.Size = New Size(75, 25)
        Label1.TabIndex = 0
        Label1.Text = "Delivery"
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(Label1)
        Panel1.Location = New Point(1, 33)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1059, 511)
        Panel1.TabIndex = 1
        ' 
        ' Delivery_staff
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1072, 575)
        Controls.Add(Panel1)
        Name = "Delivery_staff"
        Text = "Delivery_staff"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
End Class
