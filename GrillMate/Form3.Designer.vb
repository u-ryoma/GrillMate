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
        SplitContainer1 = New SplitContainer()
        txtbox_quantity = New TextBox()
        btn_add = New Button()
        Button1 = New Button()
        lblChange = New Label()
        Label7 = New Label()
        txtbox_amountPd = New TextBox()
        Label6 = New Label()
        totalAmt = New Label()
        Label4 = New Label()
        btn_remove = New Button()
        btn_pay = New Button()
        ComboBox1 = New ComboBox()
        Label3 = New Label()
        Label2 = New Label()
        item_listbox = New ListBox()
        Label1 = New Label()
        dateTime = New Label()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        CType(SplitContainer1, ComponentModel.ISupportInitialize).BeginInit()
        SplitContainer1.Panel1.SuspendLayout()
        SplitContainer1.Panel2.SuspendLayout()
        SplitContainer1.SuspendLayout()
        SuspendLayout()
        ' 
        ' logoutBtn
        ' 
        logoutBtn.Location = New Point(0, 0)
        logoutBtn.Name = "logoutBtn"
        logoutBtn.Size = New Size(75, 23)
        logoutBtn.TabIndex = 32
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
        DataGridView1.AllowUserToResizeColumns = False
        DataGridView1.AllowUserToResizeRows = False
        DataGridView1.BackgroundColor = Color.White
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Columns.AddRange(New DataGridViewColumn() {Column1, Column2, Column3, Column4})
        DataGridView1.Location = New Point(3, 184)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.ReadOnly = True
        DataGridView1.RowHeadersVisible = False
        DataGridView1.RowHeadersWidth = 62
        DataGridView1.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        DataGridView1.Size = New Size(1048, 515)
        DataGridView1.TabIndex = 28
        ' 
        ' Column1
        ' 
        Column1.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Column1.HeaderText = "Product Number"
        Column1.MinimumWidth = 8
        Column1.Name = "Column1"
        Column1.ReadOnly = True
        Column1.Width = 241
        ' 
        ' Column2
        ' 
        Column2.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        Column2.HeaderText = "Product Name"
        Column2.MinimumWidth = 8
        Column2.Name = "Column2"
        Column2.ReadOnly = True
        ' 
        ' Column3
        ' 
        Column3.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Column3.HeaderText = "Price"
        Column3.MinimumWidth = 8
        Column3.Name = "Column3"
        Column3.ReadOnly = True
        Column3.Width = 114
        ' 
        ' Column4
        ' 
        Column4.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Column4.HeaderText = "Group"
        Column4.MinimumWidth = 8
        Column4.Name = "Column4"
        Column4.ReadOnly = True
        Column4.Width = 133
        ' 
        ' txtSearch
        ' 
        txtSearch.Location = New Point(3, 118)
        txtSearch.Name = "txtSearch"
        txtSearch.Size = New Size(1048, 45)
        txtSearch.TabIndex = 29
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(3, 77)
        Label5.Name = "Label5"
        Label5.Size = New Size(101, 38)
        Label5.TabIndex = 30
        Label5.Text = "Search"
        ' 
        ' SplitContainer1
        ' 
        SplitContainer1.Dock = DockStyle.Fill
        SplitContainer1.Location = New Point(0, 0)
        SplitContainer1.Name = "SplitContainer1"
        ' 
        ' SplitContainer1.Panel1
        ' 
        SplitContainer1.Panel1.Controls.Add(txtbox_quantity)
        SplitContainer1.Panel1.Controls.Add(btn_add)
        SplitContainer1.Panel1.Controls.Add(Button1)
        SplitContainer1.Panel1.Controls.Add(Label5)
        SplitContainer1.Panel1.Controls.Add(DataGridView1)
        SplitContainer1.Panel1.Controls.Add(txtSearch)
        ' 
        ' SplitContainer1.Panel2
        ' 
        SplitContainer1.Panel2.Controls.Add(lblChange)
        SplitContainer1.Panel2.Controls.Add(Label7)
        SplitContainer1.Panel2.Controls.Add(txtbox_amountPd)
        SplitContainer1.Panel2.Controls.Add(Label6)
        SplitContainer1.Panel2.Controls.Add(totalAmt)
        SplitContainer1.Panel2.Controls.Add(Label4)
        SplitContainer1.Panel2.Controls.Add(btn_remove)
        SplitContainer1.Panel2.Controls.Add(btn_pay)
        SplitContainer1.Panel2.Controls.Add(ComboBox1)
        SplitContainer1.Panel2.Controls.Add(Label3)
        SplitContainer1.Panel2.Controls.Add(Label2)
        SplitContainer1.Panel2.Controls.Add(item_listbox)
        SplitContainer1.Panel2.Controls.Add(Label1)
        SplitContainer1.Panel2.Controls.Add(dateTime)
        SplitContainer1.Size = New Size(1898, 1024)
        SplitContainer1.SplitterDistance = 1468
        SplitContainer1.TabIndex = 31
        ' 
        ' txtbox_quantity
        ' 
        txtbox_quantity.Location = New Point(817, 723)
        txtbox_quantity.Name = "txtbox_quantity"
        txtbox_quantity.Size = New Size(131, 45)
        txtbox_quantity.TabIndex = 33
        ' 
        ' btn_add
        ' 
        btn_add.Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btn_add.Location = New Point(963, 726)
        btn_add.Name = "btn_add"
        btn_add.Size = New Size(88, 42)
        btn_add.TabIndex = 32
        btn_add.Text = "Add"
        btn_add.UseVisualStyleBackColor = True
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(3, 926)
        Button1.Name = "Button1"
        Button1.Size = New Size(138, 44)
        Button1.TabIndex = 31
        Button1.Text = "Logout"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' lblChange
        ' 
        lblChange.AutoSize = True
        lblChange.Font = New Font("Segoe UI Semibold", 11.0F, FontStyle.Bold)
        lblChange.ForeColor = SystemColors.ActiveCaptionText
        lblChange.Location = New Point(106, 613)
        lblChange.Name = "lblChange"
        lblChange.Size = New Size(54, 30)
        lblChange.TabIndex = 45
        lblChange.Text = "0.00"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI Semibold", 11.0F, FontStyle.Bold)
        Label7.ForeColor = SystemColors.ActiveCaptionText
        Label7.Location = New Point(12, 613)
        Label7.Name = "Label7"
        Label7.Size = New Size(100, 30)
        Label7.TabIndex = 44
        Label7.Text = "Change :"
        ' 
        ' txtbox_amountPd
        ' 
        txtbox_amountPd.Font = New Font("Segoe UI Semibold", 11.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtbox_amountPd.Location = New Point(21, 527)
        txtbox_amountPd.Name = "txtbox_amountPd"
        txtbox_amountPd.Size = New Size(111, 37)
        txtbox_amountPd.TabIndex = 43
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI Semibold", 11.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(12, 494)
        Label6.Name = "Label6"
        Label6.Size = New Size(143, 30)
        Label6.TabIndex = 42
        Label6.Text = "Amount paid"
        ' 
        ' totalAmt
        ' 
        totalAmt.AutoSize = True
        totalAmt.Font = New Font("Segoe UI Semibold", 11.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        totalAmt.ForeColor = SystemColors.ActiveCaptionText
        totalAmt.Location = New Point(93, 431)
        totalAmt.Name = "totalAmt"
        totalAmt.Size = New Size(54, 30)
        totalAmt.TabIndex = 38
        totalAmt.Text = "0.00"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI Semibold", 11.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(12, 431)
        Label4.Name = "Label4"
        Label4.Size = New Size(72, 30)
        Label4.TabIndex = 41
        Label4.Text = "Total: "
        ' 
        ' btn_remove
        ' 
        btn_remove.Font = New Font("Segoe UI Semibold", 9.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btn_remove.Location = New Point(336, 364)
        btn_remove.Name = "btn_remove"
        btn_remove.Size = New Size(87, 34)
        btn_remove.TabIndex = 40
        btn_remove.Text = "Remove"
        btn_remove.UseVisualStyleBackColor = True
        ' 
        ' btn_pay
        ' 
        btn_pay.Font = New Font("Segoe UI Semibold", 11.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btn_pay.Location = New Point(22, 804)
        btn_pay.Name = "btn_pay"
        btn_pay.Size = New Size(125, 37)
        btn_pay.TabIndex = 39
        btn_pay.Text = "Pay"
        btn_pay.UseVisualStyleBackColor = True
        ' 
        ' ComboBox1
        ' 
        ComboBox1.Font = New Font("Segoe UI Semibold", 11.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        ComboBox1.FormattingEnabled = True
        ComboBox1.Items.AddRange(New Object() {"Cash", "Gcash"})
        ComboBox1.Location = New Point(22, 732)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(110, 38)
        ComboBox1.TabIndex = 37
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI Semibold", 9.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = SystemColors.ActiveCaptionText
        Label3.Location = New Point(12, 701)
        Label3.Name = "Label3"
        Label3.Size = New Size(154, 25)
        Label3.TabIndex = 36
        Label3.Text = "Payment method"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = SystemColors.ActiveCaptionText
        Label2.Location = New Point(12, 198)
        Label2.Name = "Label2"
        Label2.Size = New Size(63, 28)
        Label2.TabIndex = 35
        Label2.Text = "Items"
        ' 
        ' item_listbox
        ' 
        item_listbox.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        item_listbox.FormattingEnabled = True
        item_listbox.ItemHeight = 25
        item_listbox.Location = New Point(12, 229)
        item_listbox.Name = "item_listbox"
        item_listbox.Size = New Size(411, 129)
        item_listbox.TabIndex = 34
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.ForeColor = SystemColors.ActiveCaptionText
        Label1.Location = New Point(176, 77)
        Label1.Name = "Label1"
        Label1.Size = New Size(95, 38)
        Label1.TabIndex = 33
        Label1.Text = "Billing"
        ' 
        ' dateTime
        ' 
        dateTime.AutoSize = True
        dateTime.Location = New Point(3, 932)
        dateTime.Name = "dateTime"
        dateTime.Size = New Size(96, 38)
        dateTime.TabIndex = 32
        dateTime.Text = "Label1"
        ' 
        ' staffForm
        ' 
        AutoScaleDimensions = New SizeF(16F, 38F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1898, 1024)
        Controls.Add(SplitContainer1)
        Controls.Add(tD)
        Controls.Add(logoutBtn)
        Font = New Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Margin = New Padding(5)
        Name = "staffForm"
        StartPosition = FormStartPosition.CenterScreen
        Text = "GrillMate.Staff"
        WindowState = FormWindowState.Maximized
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        SplitContainer1.Panel1.ResumeLayout(False)
        SplitContainer1.Panel1.PerformLayout()
        SplitContainer1.Panel2.ResumeLayout(False)
        SplitContainer1.Panel2.PerformLayout()
        CType(SplitContainer1, ComponentModel.ISupportInitialize).EndInit()
        SplitContainer1.ResumeLayout(False)
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
    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents Button1 As Button
    Friend WithEvents dateTime As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents item_listbox As ListBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btn_add As Button
    Friend WithEvents btn_pay As Button
    Friend WithEvents totalAmt As Label
    Friend WithEvents btn_remove As Button
    Friend WithEvents txtbox_quantity As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtbox_amountPd As TextBox
    Friend WithEvents lblChange As Label
    Friend WithEvents Label7 As Label
End Class
