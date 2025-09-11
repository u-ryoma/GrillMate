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
        logoutBtn = New Button()
        tD = New Label()
        Timer1 = New Timer(components)
        DataGridView1 = New DataGridView()
        Column1 = New DataGridViewTextBoxColumn()
        Column2 = New DataGridViewTextBoxColumn()
        Column3 = New DataGridViewTextBoxColumn()
        Column4 = New DataGridViewTextBoxColumn()
        txtSearch = New TextBox()
        Label5 = New Label()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' logoutBtn
        ' 
        logoutBtn.Location = New Point(12, 920)
        logoutBtn.Name = "logoutBtn"
        logoutBtn.Size = New Size(122, 44)
        logoutBtn.TabIndex = 0
        logoutBtn.Text = "Logout"
        logoutBtn.UseVisualStyleBackColor = True
        ' 
        ' tD
        ' 
        tD.AutoSize = True
        tD.Location = New Point(1418, 926)
        tD.Name = "tD"
        tD.Size = New Size(96, 38)
        tD.TabIndex = 1
        tD.Text = "Label1"
        ' 
        ' Timer1
        ' 
        Timer1.Enabled = True
        Timer1.Interval = 1000
        ' 
        ' DataGridView1
        ' 
        DataGridView1.BackgroundColor = Color.White
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Columns.AddRange(New DataGridViewColumn() {Column1, Column2, Column3, Column4})
        DataGridView1.Location = New Point(172, 315)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersVisible = False
        DataGridView1.RowHeadersWidth = 62
        DataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        DataGridView1.Size = New Size(872, 408)
        DataGridView1.TabIndex = 28
        ' 
        ' Column1
        ' 
        Column1.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Column1.HeaderText = "Product Number"
        Column1.MinimumWidth = 8
        Column1.Name = "Column1"
        Column1.Width = 241
        ' 
        ' Column2
        ' 
        Column2.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        Column2.HeaderText = "Product Name"
        Column2.MinimumWidth = 8
        Column2.Name = "Column2"
        ' 
        ' Column3
        ' 
        Column3.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Column3.HeaderText = "Price"
        Column3.MinimumWidth = 8
        Column3.Name = "Column3"
        Column3.Width = 114
        ' 
        ' Column4
        ' 
        Column4.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Column4.HeaderText = "Group"
        Column4.MinimumWidth = 8
        Column4.Name = "Column4"
        Column4.Width = 133
        ' 
        ' txtSearch
        ' 
        txtSearch.Location = New Point(172, 250)
        txtSearch.Name = "txtSearch"
        txtSearch.Size = New Size(411, 45)
        txtSearch.TabIndex = 29
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(172, 196)
        Label5.Name = "Label5"
        Label5.Size = New Size(101, 38)
        Label5.TabIndex = 30
        Label5.Text = "Search"
        ' 
        ' staffForm
        ' 
        AutoScaleDimensions = New SizeF(16.0F, 38.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1898, 994)
        Controls.Add(Label5)
        Controls.Add(txtSearch)
        Controls.Add(DataGridView1)
        Controls.Add(tD)
        Controls.Add(logoutBtn)
        Font = New Font("Segoe UI Semibold", 14.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Margin = New Padding(5)
        MaximizeBox = False
        MinimizeBox = False
        Name = "staffForm"
        StartPosition = FormStartPosition.CenterScreen
        Text = "GrillMate.Staff"
        WindowState = FormWindowState.Maximized
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents backBtn As Button
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents timeDate As Label
    Friend WithEvents logoutBtn As Button
    Friend WithEvents tD As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents Label5 As Label
End Class
