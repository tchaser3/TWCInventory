<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StockAdjustmentDateReport
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
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtAdjustWarehouseID = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtAdjustDate = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtEndDate = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtStartDate = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtDescription = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtPartNumber = New System.Windows.Forms.TextBox()
        Me.cboPartID = New System.Windows.Forms.ComboBox()
        Me.txtAdjustReason = New System.Windows.Forms.TextBox()
        Me.txtAdjustQuantity = New System.Windows.Forms.TextBox()
        Me.txtAdjustEmployeeID = New System.Windows.Forms.TextBox()
        Me.txtAdjustPartNumber = New System.Windows.Forms.TextBox()
        Me.cboAdjustTransactionID = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnRunReport = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnMainMenu = New System.Windows.Forms.Button()
        Me.btnAdministrationMenu = New System.Windows.Forms.Button()
        Me.btnFindTransactions = New System.Windows.Forms.Button()
        Me.dgvSearchResults = New System.Windows.Forms.DataGridView()
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        CType(Me.dgvSearchResults, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label13
        '
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(421, 445)
        Me.Label13.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(175, 28)
        Me.Label13.TabIndex = 90
        Me.Label13.Text = "Warehouse ID"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtAdjustWarehouseID
        '
        Me.txtAdjustWarehouseID.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtAdjustWarehouseID.Location = New System.Drawing.Point(617, 449)
        Me.txtAdjustWarehouseID.Margin = New System.Windows.Forms.Padding(4)
        Me.txtAdjustWarehouseID.Name = "txtAdjustWarehouseID"
        Me.txtAdjustWarehouseID.ReadOnly = True
        Me.txtAdjustWarehouseID.Size = New System.Drawing.Size(197, 22)
        Me.txtAdjustWarehouseID.TabIndex = 89
        '
        'Label12
        '
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(435, 243)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(175, 28)
        Me.Label12.TabIndex = 88
        Me.Label12.Text = "Date"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtAdjustDate
        '
        Me.txtAdjustDate.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtAdjustDate.Location = New System.Drawing.Point(617, 243)
        Me.txtAdjustDate.Margin = New System.Windows.Forms.Padding(4)
        Me.txtAdjustDate.Name = "txtAdjustDate"
        Me.txtAdjustDate.ReadOnly = True
        Me.txtAdjustDate.Size = New System.Drawing.Size(197, 22)
        Me.txtAdjustDate.TabIndex = 77
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(367, 91)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(112, 28)
        Me.Label7.TabIndex = 87
        Me.Label7.Text = "End Date"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtEndDate
        '
        Me.txtEndDate.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtEndDate.Location = New System.Drawing.Point(487, 95)
        Me.txtEndDate.Margin = New System.Windows.Forms.Padding(4)
        Me.txtEndDate.Name = "txtEndDate"
        Me.txtEndDate.Size = New System.Drawing.Size(197, 22)
        Me.txtEndDate.TabIndex = 66
        '
        'Label11
        '
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(37, 91)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(117, 28)
        Me.Label11.TabIndex = 85
        Me.Label11.Text = "Start Date"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtStartDate
        '
        Me.txtStartDate.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtStartDate.Location = New System.Drawing.Point(162, 95)
        Me.txtStartDate.Margin = New System.Windows.Forms.Padding(4)
        Me.txtStartDate.Name = "txtStartDate"
        Me.txtStartDate.Size = New System.Drawing.Size(197, 22)
        Me.txtStartDate.TabIndex = 65
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(37, 404)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(175, 28)
        Me.Label2.TabIndex = 84
        Me.Label2.Text = "Description"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtDescription
        '
        Me.txtDescription.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDescription.Location = New System.Drawing.Point(233, 408)
        Me.txtDescription.Margin = New System.Windows.Forms.Padding(4)
        Me.txtDescription.Name = "txtDescription"
        Me.txtDescription.ReadOnly = True
        Me.txtDescription.Size = New System.Drawing.Size(197, 22)
        Me.txtDescription.TabIndex = 70
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(37, 376)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(175, 28)
        Me.Label8.TabIndex = 82
        Me.Label8.Text = "Part Number"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(435, 330)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(175, 28)
        Me.Label5.TabIndex = 81
        Me.Label5.Text = "Reason"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(51, 311)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(175, 28)
        Me.Label4.TabIndex = 79
        Me.Label4.Text = "Quantity"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(51, 279)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(175, 28)
        Me.Label3.TabIndex = 78
        Me.Label3.Text = "Employee ID"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label10
        '
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(51, 247)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(175, 28)
        Me.Label10.TabIndex = 76
        Me.Label10.Text = "Part Number"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtPartNumber
        '
        Me.txtPartNumber.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtPartNumber.Location = New System.Drawing.Point(233, 380)
        Me.txtPartNumber.Margin = New System.Windows.Forms.Padding(4)
        Me.txtPartNumber.Name = "txtPartNumber"
        Me.txtPartNumber.ReadOnly = True
        Me.txtPartNumber.Size = New System.Drawing.Size(197, 22)
        Me.txtPartNumber.TabIndex = 69
        '
        'cboPartID
        '
        Me.cboPartID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboPartID.FormattingEnabled = True
        Me.cboPartID.Location = New System.Drawing.Point(233, 345)
        Me.cboPartID.Margin = New System.Windows.Forms.Padding(4)
        Me.cboPartID.Name = "cboPartID"
        Me.cboPartID.Size = New System.Drawing.Size(197, 24)
        Me.cboPartID.TabIndex = 68
        '
        'txtAdjustReason
        '
        Me.txtAdjustReason.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtAdjustReason.Location = New System.Drawing.Point(617, 282)
        Me.txtAdjustReason.Margin = New System.Windows.Forms.Padding(4)
        Me.txtAdjustReason.Multiline = True
        Me.txtAdjustReason.Name = "txtAdjustReason"
        Me.txtAdjustReason.ReadOnly = True
        Me.txtAdjustReason.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtAdjustReason.Size = New System.Drawing.Size(197, 158)
        Me.txtAdjustReason.TabIndex = 80
        '
        'txtAdjustQuantity
        '
        Me.txtAdjustQuantity.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtAdjustQuantity.Location = New System.Drawing.Point(233, 311)
        Me.txtAdjustQuantity.Margin = New System.Windows.Forms.Padding(4)
        Me.txtAdjustQuantity.Name = "txtAdjustQuantity"
        Me.txtAdjustQuantity.ReadOnly = True
        Me.txtAdjustQuantity.Size = New System.Drawing.Size(197, 22)
        Me.txtAdjustQuantity.TabIndex = 75
        '
        'txtAdjustEmployeeID
        '
        Me.txtAdjustEmployeeID.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtAdjustEmployeeID.Location = New System.Drawing.Point(233, 279)
        Me.txtAdjustEmployeeID.Margin = New System.Windows.Forms.Padding(4)
        Me.txtAdjustEmployeeID.Name = "txtAdjustEmployeeID"
        Me.txtAdjustEmployeeID.ReadOnly = True
        Me.txtAdjustEmployeeID.Size = New System.Drawing.Size(197, 22)
        Me.txtAdjustEmployeeID.TabIndex = 74
        '
        'txtAdjustPartNumber
        '
        Me.txtAdjustPartNumber.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtAdjustPartNumber.Location = New System.Drawing.Point(233, 247)
        Me.txtAdjustPartNumber.Margin = New System.Windows.Forms.Padding(4)
        Me.txtAdjustPartNumber.Name = "txtAdjustPartNumber"
        Me.txtAdjustPartNumber.ReadOnly = True
        Me.txtAdjustPartNumber.Size = New System.Drawing.Size(197, 22)
        Me.txtAdjustPartNumber.TabIndex = 73
        '
        'cboAdjustTransactionID
        '
        Me.cboAdjustTransactionID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboAdjustTransactionID.FormattingEnabled = True
        Me.cboAdjustTransactionID.Location = New System.Drawing.Point(233, 213)
        Me.cboAdjustTransactionID.Margin = New System.Windows.Forms.Padding(4)
        Me.cboAdjustTransactionID.Name = "cboAdjustTransactionID"
        Me.cboAdjustTransactionID.Size = New System.Drawing.Size(197, 24)
        Me.cboAdjustTransactionID.TabIndex = 72
        Me.cboAdjustTransactionID.Visible = False
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(13, 19)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(1033, 46)
        Me.Label1.TabIndex = 64
        Me.Label1.Text = "Stock Adjustment Date Report"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnRunReport
        '
        Me.btnRunReport.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRunReport.Location = New System.Drawing.Point(843, 109)
        Me.btnRunReport.Margin = New System.Windows.Forms.Padding(4)
        Me.btnRunReport.Name = "btnRunReport"
        Me.btnRunReport.Size = New System.Drawing.Size(203, 60)
        Me.btnRunReport.TabIndex = 60
        Me.btnRunReport.Text = "Run Report"
        Me.btnRunReport.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.Location = New System.Drawing.Point(843, 317)
        Me.btnClose.Margin = New System.Windows.Forms.Padding(4)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(203, 62)
        Me.btnClose.TabIndex = 63
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'btnMainMenu
        '
        Me.btnMainMenu.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMainMenu.Location = New System.Drawing.Point(843, 247)
        Me.btnMainMenu.Margin = New System.Windows.Forms.Padding(4)
        Me.btnMainMenu.Name = "btnMainMenu"
        Me.btnMainMenu.Size = New System.Drawing.Size(203, 62)
        Me.btnMainMenu.TabIndex = 62
        Me.btnMainMenu.Text = "Main Menu"
        Me.btnMainMenu.UseVisualStyleBackColor = True
        '
        'btnAdministrationMenu
        '
        Me.btnAdministrationMenu.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdministrationMenu.Location = New System.Drawing.Point(843, 177)
        Me.btnAdministrationMenu.Margin = New System.Windows.Forms.Padding(4)
        Me.btnAdministrationMenu.Name = "btnAdministrationMenu"
        Me.btnAdministrationMenu.Size = New System.Drawing.Size(203, 62)
        Me.btnAdministrationMenu.TabIndex = 61
        Me.btnAdministrationMenu.Text = "Administration Menu"
        Me.btnAdministrationMenu.UseVisualStyleBackColor = True
        '
        'btnFindTransactions
        '
        Me.btnFindTransactions.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFindTransactions.Location = New System.Drawing.Point(700, 78)
        Me.btnFindTransactions.Name = "btnFindTransactions"
        Me.btnFindTransactions.Size = New System.Drawing.Size(125, 56)
        Me.btnFindTransactions.TabIndex = 91
        Me.btnFindTransactions.Text = "Find Transactions"
        Me.btnFindTransactions.UseVisualStyleBackColor = True
        '
        'dgvSearchResults
        '
        Me.dgvSearchResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvSearchResults.Location = New System.Drawing.Point(19, 142)
        Me.dgvSearchResults.Name = "dgvSearchResults"
        Me.dgvSearchResults.RowTemplate.Height = 24
        Me.dgvSearchResults.Size = New System.Drawing.Size(806, 350)
        Me.dgvSearchResults.TabIndex = 92
        '
        'PrintDialog1
        '
        Me.PrintDialog1.UseEXDialog = True
        '
        'StockAdjustmentDateReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1063, 504)
        Me.ControlBox = False
        Me.Controls.Add(Me.dgvSearchResults)
        Me.Controls.Add(Me.btnFindTransactions)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.txtAdjustWarehouseID)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.txtAdjustDate)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtEndDate)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.txtStartDate)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtDescription)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txtPartNumber)
        Me.Controls.Add(Me.cboPartID)
        Me.Controls.Add(Me.txtAdjustReason)
        Me.Controls.Add(Me.txtAdjustQuantity)
        Me.Controls.Add(Me.txtAdjustEmployeeID)
        Me.Controls.Add(Me.txtAdjustPartNumber)
        Me.Controls.Add(Me.cboAdjustTransactionID)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnRunReport)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnMainMenu)
        Me.Controls.Add(Me.btnAdministrationMenu)
        Me.Name = "StockAdjustmentDateReport"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "StockAdjustmentDateReport"
        CType(Me.dgvSearchResults, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txtAdjustWarehouseID As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtAdjustDate As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtEndDate As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtStartDate As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtDescription As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtPartNumber As System.Windows.Forms.TextBox
    Friend WithEvents cboPartID As System.Windows.Forms.ComboBox
    Friend WithEvents txtAdjustReason As System.Windows.Forms.TextBox
    Friend WithEvents txtAdjustQuantity As System.Windows.Forms.TextBox
    Friend WithEvents txtAdjustEmployeeID As System.Windows.Forms.TextBox
    Friend WithEvents txtAdjustPartNumber As System.Windows.Forms.TextBox
    Friend WithEvents cboAdjustTransactionID As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnRunReport As System.Windows.Forms.Button
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents btnMainMenu As System.Windows.Forms.Button
    Friend WithEvents btnAdministrationMenu As System.Windows.Forms.Button
    Friend WithEvents btnFindTransactions As System.Windows.Forms.Button
    Friend WithEvents dgvSearchResults As System.Windows.Forms.DataGridView
    Friend WithEvents PrintDialog1 As System.Windows.Forms.PrintDialog
    Friend WithEvents PrintDocument1 As System.Drawing.Printing.PrintDocument
End Class
