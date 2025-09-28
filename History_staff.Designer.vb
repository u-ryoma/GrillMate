<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class History_staff
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
        DataGridView1 = New DataGridView()
        Column1 = New DataGridViewTextBoxColumn()
        Column2 = New DataGridViewTextBoxColumn()
        Column6 = New DataGridViewTextBoxColumn()
        Column4 = New DataGridViewTextBoxColumn()
        Column7 = New DataGridViewTextBoxColumn()
        Column8 = New DataGridViewTextBoxColumn()
        Column9 = New DataGridViewTextBoxColumn()
        Column10 = New DataGridViewTextBoxColumn()
        TotalOfGridView = New Label()
        Panel1.SuspendLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(TotalOfGridView)
        Panel1.Controls.Add(DataGridView1)
        Panel1.Location = New Point(60, 64)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1720, 690)
        Panel1.TabIndex = 59
        ' 
        ' DataGridView1
        ' 
        DataGridView1.AllowUserToAddRows = False
        DataGridView1.AllowUserToDeleteRows = False
        DataGridView1.AllowUserToResizeColumns = False
        DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        DataGridView1.BackgroundColor = SystemColors.ButtonFace
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Columns.AddRange(New DataGridViewColumn() {Column1, Column2, Column6, Column4, Column7, Column8, Column9, Column10})
        DataGridView1.Location = New Point(21, 28)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.ReadOnly = True
        DataGridView1.RowHeadersVisible = False
        DataGridView1.RowHeadersWidth = 62
        DataGridView1.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        DataGridView1.Size = New Size(1386, 595)
        DataGridView1.TabIndex = 1
        ' 
        ' Column1
        ' 
        Column1.HeaderText = "TransactionID"
        Column1.MinimumWidth = 8
        Column1.Name = "Column1"
        Column1.ReadOnly = True
        Column1.Width = 154
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
        ' TotalOfGridView
        ' 
        TotalOfGridView.AutoSize = True
        TotalOfGridView.Font = New Font("Segoe UI Semibold", 14.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        TotalOfGridView.Location = New Point(21, 639)
        TotalOfGridView.Name = "TotalOfGridView"
        TotalOfGridView.Size = New Size(96, 38)
        TotalOfGridView.TabIndex = 11
        TotalOfGridView.Text = "P 0.00"
        ' 
        ' History_staff
        ' 
        AutoScaleDimensions = New SizeF(10.0F, 25.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1898, 964)
        Controls.Add(Panel1)
        Name = "History_staff"
        Text = "History_staff"
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
    Friend WithEvents TotalOfGridView As Label
End Class
