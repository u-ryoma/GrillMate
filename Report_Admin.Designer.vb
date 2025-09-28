<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Report_Admin
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
        Panel1 = New Panel()
        TotalOfGridView = New Label()
        Label4 = New Label()
        dtmpDateTo = New DateTimePicker()
        dtmpFromDate = New DateTimePicker()
        Label3 = New Label()
        cmbPayMethod = New ComboBox()
        Label2 = New Label()
        Label1 = New Label()
        txtbSearch = New TextBox()
        DataGridView1 = New DataGridView()
        Column1 = New DataGridViewTextBoxColumn()
        Column2 = New DataGridViewTextBoxColumn()
        Column6 = New DataGridViewTextBoxColumn()
        Column4 = New DataGridViewTextBoxColumn()
        Column7 = New DataGridViewTextBoxColumn()
        Column8 = New DataGridViewTextBoxColumn()
        Column9 = New DataGridViewTextBoxColumn()
        Column10 = New DataGridViewTextBoxColumn()
        chkAllDates = New CheckBox()
        Panel1.SuspendLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(chkAllDates)
        Panel1.Controls.Add(TotalOfGridView)
        Panel1.Controls.Add(Label4)
        Panel1.Controls.Add(dtmpDateTo)
        Panel1.Controls.Add(dtmpFromDate)
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(cmbPayMethod)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(txtbSearch)
        Panel1.Controls.Add(DataGridView1)
        Panel1.Location = New Point(20, 62)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1835, 816)
        Panel1.TabIndex = 0
        ' 
        ' TotalOfGridView
        ' 
        TotalOfGridView.AutoSize = True
        TotalOfGridView.Font = New Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        TotalOfGridView.Location = New Point(16, 763)
        TotalOfGridView.Name = "TotalOfGridView"
        TotalOfGridView.Size = New Size(96, 38)
        TotalOfGridView.TabIndex = 10
        TotalOfGridView.Text = "P 0.00"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(1417, 37)
        Label4.Name = "Label4"
        Label4.Size = New Size(30, 25)
        Label4.TabIndex = 8
        Label4.Text = "To"
        ' 
        ' dtmpDateTo
        ' 
        dtmpDateTo.Location = New Point(1453, 34)
        dtmpDateTo.Name = "dtmpDateTo"
        dtmpDateTo.Size = New Size(300, 31)
        dtmpDateTo.TabIndex = 7
        ' 
        ' dtmpFromDate
        ' 
        dtmpFromDate.Location = New Point(1118, 33)
        dtmpFromDate.Name = "dtmpFromDate"
        dtmpFromDate.Size = New Size(293, 31)
        dtmpFromDate.TabIndex = 6
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(955, 5)
        Label3.Name = "Label3"
        Label3.Size = New Size(122, 25)
        Label3.TabIndex = 5
        Label3.Text = "Filter by date"
        ' 
        ' cmbPayMethod
        ' 
        cmbPayMethod.FormattingEnabled = True
        cmbPayMethod.Location = New Point(701, 32)
        cmbPayMethod.Name = "cmbPayMethod"
        cmbPayMethod.Size = New Size(182, 33)
        cmbPayMethod.TabIndex = 4
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(682, 6)
        Label2.Name = "Label2"
        Label2.Size = New Size(228, 25)
        Label2.TabIndex = 3
        Label2.Text = "Filter by Payment Method"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(16, 6)
        Label1.Name = "Label1"
        Label1.Size = New Size(66, 25)
        Label1.TabIndex = 1
        Label1.Text = "Search"
        ' 
        ' txtbSearch
        ' 
        txtbSearch.Location = New Point(16, 34)
        txtbSearch.Name = "txtbSearch"
        txtbSearch.Size = New Size(622, 31)
        txtbSearch.TabIndex = 2
        ' 
        ' DataGridView1
        ' 
        DataGridView1.AllowUserToAddRows = False
        DataGridView1.AllowUserToDeleteRows = False
        DataGridView1.AllowUserToResizeColumns = False
        DataGridView1.AllowUserToResizeRows = False
        DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        DataGridView1.BackgroundColor = SystemColors.Window
        DataGridView1.ColumnHeadersHeight = 34
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        DataGridView1.Columns.AddRange(New DataGridViewColumn() {Column1, Column2, Column6, Column4, Column7, Column8, Column9, Column10})
        DataGridView1.Location = New Point(16, 71)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.ReadOnly = True
        DataGridView1.RowHeadersVisible = False
        DataGridView1.RowHeadersWidth = 62
        DataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        DataGridView1.ShowCellToolTips = False
        DataGridView1.Size = New Size(1737, 674)
        DataGridView1.TabIndex = 1
        ' 
        ' Column1
        ' 
        Column1.HeaderText = "Transaction ID"
        Column1.MinimumWidth = 8
        Column1.Name = "Column1"
        Column1.ReadOnly = True
        Column1.Width = 159
        ' 
        ' Column2
        ' 
        Column2.HeaderText = "Items"
        Column2.MinimumWidth = 8
        Column2.Name = "Column2"
        Column2.ReadOnly = True
        Column2.Width = 92
        ' 
        ' Column6
        ' 
        Column6.HeaderText = "Total"
        Column6.MinimumWidth = 8
        Column6.Name = "Column6"
        Column6.ReadOnly = True
        Column6.Width = 85
        ' 
        ' Column4
        ' 
        Column4.HeaderText = "Table Number"
        Column4.MinimumWidth = 8
        Column4.Name = "Column4"
        Column4.ReadOnly = True
        Column4.Width = 158
        ' 
        ' Column7
        ' 
        Column7.HeaderText = "Amount Paid"
        Column7.MinimumWidth = 8
        Column7.Name = "Column7"
        Column7.ReadOnly = True
        Column7.Width = 151
        ' 
        ' Column8
        ' 
        Column8.HeaderText = "Change"
        Column8.MinimumWidth = 8
        Column8.Name = "Column8"
        Column8.ReadOnly = True
        Column8.Width = 108
        ' 
        ' Column9
        ' 
        Column9.HeaderText = "Payment Method"
        Column9.MinimumWidth = 8
        Column9.Name = "Column9"
        Column9.ReadOnly = True
        Column9.Width = 184
        ' 
        ' Column10
        ' 
        Column10.HeaderText = "Transaction Date"
        Column10.MinimumWidth = 8
        Column10.Name = "Column10"
        Column10.ReadOnly = True
        Column10.Width = 178
        ' 
        ' chkAllDates
        ' 
        chkAllDates.AutoSize = True
        chkAllDates.Location = New Point(955, 33)
        chkAllDates.Name = "chkAllDates"
        chkAllDates.Size = New Size(157, 29)
        chkAllDates.TabIndex = 11
        chkAllDates.Text = "Show All Dates"
        chkAllDates.UseVisualStyleBackColor = True
        ' 
        ' Report_Admin
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1898, 994)
        Controls.Add(Panel1)
        Name = "Report_Admin"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents Column8 As DataGridViewTextBoxColumn
    Friend WithEvents Column9 As DataGridViewTextBoxColumn
    Friend WithEvents Column10 As DataGridViewTextBoxColumn
    Friend WithEvents Label3 As Label
    Friend WithEvents cmbPayMethod As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtbSearch As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents dtmpDateTo As DateTimePicker
    Friend WithEvents dtmpFromDate As DateTimePicker
    Friend WithEvents TotalOfGridView As Label
    Friend WithEvents chkAllDates As CheckBox
End Class
