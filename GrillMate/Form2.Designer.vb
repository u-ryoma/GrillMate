<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class adminForm
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
        BackButton = New Button()
        Timer1 = New Timer(components)
        timeDate = New Label()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        txtPrdNum = New TextBox()
        txtPrdName = New TextBox()
        txtPrice = New TextBox()
        cmb_boxGrp = New ComboBox()
        saveBtn = New Button()
        updBtn = New Button()
        dltBtn = New Button()
        clrBtn = New Button()
        Label5 = New Label()
        txtSearch = New TextBox()
        DataGridView1 = New DataGridView()
        Column1 = New DataGridViewTextBoxColumn()
        Column2 = New DataGridViewTextBoxColumn()
        Column3 = New DataGridViewTextBoxColumn()
        Column4 = New DataGridViewTextBoxColumn()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' BackButton
        ' 
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
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(25, 96)
        Label1.Name = "Label1"
        Label1.Size = New Size(107, 25)
        Label1.TabIndex = 13
        Label1.Text = "Product No."
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(25, 186)
        Label2.Name = "Label2"
        Label2.Size = New Size(126, 25)
        Label2.TabIndex = 14
        Label2.Text = "Product Name"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(25, 267)
        Label3.Name = "Label3"
        Label3.Size = New Size(49, 25)
        Label3.TabIndex = 15
        Label3.Text = "Price"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(25, 357)
        Label4.Name = "Label4"
        Label4.Size = New Size(129, 25)
        Label4.TabIndex = 16
        Label4.Text = "Product Group"
        ' 
        ' txtPrdNum
        ' 
        txtPrdNum.Location = New Point(53, 124)
        txtPrdNum.Name = "txtPrdNum"
        txtPrdNum.Size = New Size(244, 31)
        txtPrdNum.TabIndex = 17
        ' 
        ' txtPrdName
        ' 
        txtPrdName.Location = New Point(53, 222)
        txtPrdName.Name = "txtPrdName"
        txtPrdName.Size = New Size(244, 31)
        txtPrdName.TabIndex = 18
        ' 
        ' txtPrice
        ' 
        txtPrice.Location = New Point(53, 300)
        txtPrice.Name = "txtPrice"
        txtPrice.Size = New Size(244, 31)
        txtPrice.TabIndex = 19
        ' 
        ' cmb_boxGrp
        ' 
        cmb_boxGrp.FormattingEnabled = True
        cmb_boxGrp.Items.AddRange(New Object() {"Sizzling meals", "Ice cream ", "Takoyaki", "Burgers", "Hotdog Sandwich ", "Samgyup", "Unli wings", "Milktea"})
        cmb_boxGrp.Location = New Point(53, 390)
        cmb_boxGrp.Name = "cmb_boxGrp"
        cmb_boxGrp.Size = New Size(244, 33)
        cmb_boxGrp.TabIndex = 20
        ' 
        ' saveBtn
        ' 
        saveBtn.BackColor = Color.FromArgb(CByte(128), CByte(255), CByte(128))
        saveBtn.Location = New Point(53, 477)
        saveBtn.Name = "saveBtn"
        saveBtn.Size = New Size(86, 44)
        saveBtn.TabIndex = 21
        saveBtn.Text = "Save"
        saveBtn.UseVisualStyleBackColor = False
        ' 
        ' updBtn
        ' 
        updBtn.BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(128))
        updBtn.Location = New Point(172, 477)
        updBtn.Name = "updBtn"
        updBtn.Size = New Size(86, 44)
        updBtn.TabIndex = 22
        updBtn.Text = "Update"
        updBtn.UseVisualStyleBackColor = False
        ' 
        ' dltBtn
        ' 
        dltBtn.BackColor = Color.Red
        dltBtn.Location = New Point(53, 547)
        dltBtn.Name = "dltBtn"
        dltBtn.Size = New Size(86, 44)
        dltBtn.TabIndex = 23
        dltBtn.Text = "Delete"
        dltBtn.UseVisualStyleBackColor = False
        ' 
        ' clrBtn
        ' 
        clrBtn.Location = New Point(172, 547)
        clrBtn.Name = "clrBtn"
        clrBtn.Size = New Size(86, 44)
        clrBtn.TabIndex = 24
        clrBtn.Text = "Clear"
        clrBtn.UseVisualStyleBackColor = True
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(397, 99)
        Label5.Name = "Label5"
        Label5.Size = New Size(64, 25)
        Label5.TabIndex = 25
        Label5.Text = "Search"
        ' 
        ' txtSearch
        ' 
        txtSearch.Location = New Point(397, 124)
        txtSearch.Name = "txtSearch"
        txtSearch.Size = New Size(411, 31)
        txtSearch.TabIndex = 26
        ' 
        ' DataGridView1
        ' 
        DataGridView1.BackgroundColor = Color.White
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Columns.AddRange(New DataGridViewColumn() {Column1, Column2, Column3, Column4})
        DataGridView1.Location = New Point(390, 186)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersVisible = False
        DataGridView1.RowHeadersWidth = 62
        DataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        DataGridView1.Size = New Size(734, 408)
        DataGridView1.TabIndex = 27
        ' 
        ' Column1
        ' 
        Column1.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Column1.HeaderText = "Product Number"
        Column1.MinimumWidth = 8
        Column1.Name = "Column1"
        Column1.Width = 180
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
        Column3.Width = 85
        ' 
        ' Column4
        ' 
        Column4.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Column4.HeaderText = "Group"
        Column4.MinimumWidth = 8
        Column4.Name = "Column4"
        Column4.Width = 98
        ' 
        ' adminForm
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1898, 994)
        Controls.Add(DataGridView1)
        Controls.Add(txtSearch)
        Controls.Add(Label5)
        Controls.Add(clrBtn)
        Controls.Add(dltBtn)
        Controls.Add(updBtn)
        Controls.Add(saveBtn)
        Controls.Add(cmb_boxGrp)
        Controls.Add(txtPrice)
        Controls.Add(txtPrdName)
        Controls.Add(txtPrdNum)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(timeDate)
        Controls.Add(BackButton)
        MaximizeBox = False
        MinimizeBox = False
        Name = "adminForm"
        Text = "GrillMate.Admin"
        WindowState = FormWindowState.Maximized
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents BackButton As Button
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Timer1 As Timer
    Friend WithEvents timeDate As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtPrdNum As TextBox
    Friend WithEvents txtPrdName As TextBox
    Friend WithEvents txtPrice As TextBox
    Friend WithEvents cmb_boxGrp As ComboBox
    Friend WithEvents saveBtn As Button
    Friend WithEvents updBtn As Button
    Friend WithEvents dltBtn As Button
    Friend WithEvents clrBtn As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
End Class
