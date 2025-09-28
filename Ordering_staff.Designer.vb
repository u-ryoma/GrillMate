<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Ordering_staff
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
        Label2 = New Label()
        Label6 = New Label()
        Label5 = New Label()
        DataGridView1 = New DataGridView()
        Column1 = New DataGridViewTextBoxColumn()
        Column2 = New DataGridViewTextBoxColumn()
        Column3 = New DataGridViewTextBoxColumn()
        Column4 = New DataGridViewTextBoxColumn()
        txtbox_quantity = New TextBox()
        btn_add = New Button()
        txtSearch = New TextBox()
        Panel1 = New Panel()
        Label9 = New Label()
        cmb_tableno = New ComboBox()
        Label3 = New Label()
        btn_remove = New Button()
        item_listbox = New ListBox()
        totalAmt = New Label()
        Label8 = New Label()
        Label4 = New Label()
        txtbox_amountPd = New TextBox()
        lblChange = New Label()
        Label7 = New Label()
        btn_pay = New Button()
        cmbPaymentMethod = New ComboBox()
        Label1 = New Label()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = SystemColors.ActiveCaptionText
        Label2.Location = New Point(1384, 112)
        Label2.Name = "Label2"
        Label2.Size = New Size(63, 28)
        Label2.TabIndex = 53
        Label2.Text = "Items"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(1392, 477)
        Label6.Name = "Label6"
        Label6.Size = New Size(143, 30)
        Label6.TabIndex = 60
        Label6.Text = "Amount paid"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(12, 5)
        Label5.Name = "Label5"
        Label5.Size = New Size(82, 30)
        Label5.TabIndex = 41
        Label5.Text = "Search"
        ' 
        ' DataGridView1
        ' 
        DataGridView1.AllowUserToResizeColumns = False
        DataGridView1.AllowUserToResizeRows = False
        DataGridView1.BackgroundColor = Color.White
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Columns.AddRange(New DataGridViewColumn() {Column1, Column2, Column3, Column4})
        DataGridView1.Location = New Point(12, 75)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.ReadOnly = True
        DataGridView1.RowHeadersVisible = False
        DataGridView1.RowHeadersWidth = 62
        DataGridView1.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        DataGridView1.Size = New Size(1048, 515)
        DataGridView1.TabIndex = 39
        ' 
        ' Column1
        ' 
        Column1.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Column1.HeaderText = "Product Number"
        Column1.MinimumWidth = 8
        Column1.Name = "Column1"
        Column1.ReadOnly = True
        Column1.Width = 180
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
        Column3.Width = 85
        ' 
        ' Column4
        ' 
        Column4.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Column4.HeaderText = "Group"
        Column4.MinimumWidth = 8
        Column4.Name = "Column4"
        Column4.ReadOnly = True
        Column4.Width = 98
        ' 
        ' txtbox_quantity
        ' 
        txtbox_quantity.Location = New Point(880, 642)
        txtbox_quantity.Name = "txtbox_quantity"
        txtbox_quantity.Size = New Size(86, 31)
        txtbox_quantity.TabIndex = 44
        ' 
        ' btn_add
        ' 
        btn_add.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btn_add.Location = New Point(972, 642)
        btn_add.Name = "btn_add"
        btn_add.Size = New Size(88, 31)
        btn_add.TabIndex = 43
        btn_add.Text = "ADD"
        btn_add.UseVisualStyleBackColor = True
        ' 
        ' txtSearch
        ' 
        txtSearch.Location = New Point(12, 38)
        txtSearch.Name = "txtSearch"
        txtSearch.Size = New Size(1048, 31)
        txtSearch.TabIndex = 40
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.DarkGray
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(Label9)
        Panel1.Controls.Add(cmb_tableno)
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(btn_remove)
        Panel1.Controls.Add(item_listbox)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(totalAmt)
        Panel1.Controls.Add(Label6)
        Panel1.Controls.Add(Label8)
        Panel1.Controls.Add(Label4)
        Panel1.Controls.Add(txtbox_amountPd)
        Panel1.Controls.Add(lblChange)
        Panel1.Controls.Add(Label5)
        Panel1.Controls.Add(Label7)
        Panel1.Controls.Add(DataGridView1)
        Panel1.Controls.Add(txtbox_quantity)
        Panel1.Controls.Add(btn_add)
        Panel1.Controls.Add(txtSearch)
        Panel1.Controls.Add(btn_pay)
        Panel1.Controls.Add(cmbPaymentMethod)
        Panel1.Location = New Point(12, 31)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1865, 894)
        Panel1.TabIndex = 66
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Location = New Point(880, 614)
        Label9.Name = "Label9"
        Label9.Size = New Size(80, 25)
        Label9.TabIndex = 66
        Label9.Text = "Quantity"
        ' 
        ' cmb_tableno
        ' 
        cmb_tableno.FormattingEnabled = True
        cmb_tableno.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6"})
        cmb_tableno.Location = New Point(1390, 333)
        cmb_tableno.Name = "cmb_tableno"
        cmb_tableno.Size = New Size(123, 33)
        cmb_tableno.TabIndex = 64
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = SystemColors.ActiveCaptionText
        Label3.Location = New Point(1384, 646)
        Label3.Name = "Label3"
        Label3.Size = New Size(154, 25)
        Label3.TabIndex = 54
        Label3.Text = "Payment method"
        ' 
        ' btn_remove
        ' 
        btn_remove.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btn_remove.Location = New Point(1714, 287)
        btn_remove.Name = "btn_remove"
        btn_remove.Size = New Size(87, 34)
        btn_remove.TabIndex = 58
        btn_remove.Text = "Remove"
        btn_remove.UseVisualStyleBackColor = True
        ' 
        ' item_listbox
        ' 
        item_listbox.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        item_listbox.FormattingEnabled = True
        item_listbox.ItemHeight = 25
        item_listbox.Location = New Point(1390, 152)
        item_listbox.Name = "item_listbox"
        item_listbox.Size = New Size(411, 129)
        item_listbox.TabIndex = 52
        ' 
        ' totalAmt
        ' 
        totalAmt.AutoSize = True
        totalAmt.Font = New Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        totalAmt.ForeColor = SystemColors.ActiveCaptionText
        totalAmt.Location = New Point(1468, 431)
        totalAmt.Name = "totalAmt"
        totalAmt.Size = New Size(54, 30)
        totalAmt.TabIndex = 56
        totalAmt.Text = "0.00"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label8.ForeColor = SystemColors.ActiveCaptionText
        Label8.Location = New Point(1511, 9)
        Label8.Name = "Label8"
        Label8.Size = New Size(87, 32)
        Label8.TabIndex = 51
        Label8.Text = "Billing"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(1390, 431)
        Label4.Name = "Label4"
        Label4.Size = New Size(72, 30)
        Label4.TabIndex = 59
        Label4.Text = "Total: "
        ' 
        ' txtbox_amountPd
        ' 
        txtbox_amountPd.Font = New Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtbox_amountPd.Location = New Point(1392, 524)
        txtbox_amountPd.Name = "txtbox_amountPd"
        txtbox_amountPd.Size = New Size(111, 37)
        txtbox_amountPd.TabIndex = 61
        ' 
        ' lblChange
        ' 
        lblChange.AutoSize = True
        lblChange.Font = New Font("Segoe UI Semibold", 11F, FontStyle.Bold)
        lblChange.ForeColor = SystemColors.ActiveCaptionText
        lblChange.Location = New Point(1481, 580)
        lblChange.Name = "lblChange"
        lblChange.Size = New Size(54, 30)
        lblChange.TabIndex = 63
        lblChange.Text = "0.00"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI Semibold", 11F, FontStyle.Bold)
        Label7.ForeColor = SystemColors.ActiveCaptionText
        Label7.Location = New Point(1384, 580)
        Label7.Name = "Label7"
        Label7.Size = New Size(100, 30)
        Label7.TabIndex = 62
        Label7.Text = "Change :"
        ' 
        ' btn_pay
        ' 
        btn_pay.Font = New Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btn_pay.Location = New Point(1382, 770)
        btn_pay.Name = "btn_pay"
        btn_pay.Size = New Size(125, 37)
        btn_pay.TabIndex = 57
        btn_pay.Text = "Pay"
        btn_pay.UseVisualStyleBackColor = True
        ' 
        ' cmbPaymentMethod
        ' 
        cmbPaymentMethod.Font = New Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        cmbPaymentMethod.FormattingEnabled = True
        cmbPaymentMethod.Items.AddRange(New Object() {"Cash", "Gcash"})
        cmbPaymentMethod.Location = New Point(1383, 694)
        cmbPaymentMethod.Name = "cmbPaymentMethod"
        cmbPaymentMethod.Size = New Size(110, 38)
        cmbPaymentMethod.TabIndex = 55
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(1392, 305)
        Label1.Name = "Label1"
        Label1.Size = New Size(59, 25)
        Label1.TabIndex = 67
        Label1.Text = "Table:"
        ' 
        ' Ordering_staff
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.DarkGray
        ClientSize = New Size(1898, 994)
        Controls.Add(Panel1)
        Name = "Ordering_staff"
        Text = "Ordering_staff"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Label2 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents txtbox_quantity As TextBox
    Friend WithEvents btn_add As Button
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents btn_remove As Button
    Friend WithEvents item_listbox As ListBox
    Friend WithEvents totalAmt As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtbox_amountPd As TextBox
    Friend WithEvents lblChange As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents btn_pay As Button
    Friend WithEvents cmbPaymentMethod As ComboBox
    Friend WithEvents cmb_tableno As ComboBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label1 As Label
End Class
