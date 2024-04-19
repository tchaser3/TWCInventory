<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PartProjectTransactionReport
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
        Me.btnReportMenu = New System.Windows.Forms.Button()
        Me.btnMainMenu = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txtTransactionQuantity = New System.Windows.Forms.TextBox()
        Me.txtTransactionPartNumber = New System.Windows.Forms.TextBox()
        Me.cboTransactionID = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtPartDescription = New System.Windows.Forms.TextBox()
        Me.cboPartNumber = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtTransactionProjectID = New System.Windows.Forms.TextBox()
        Me.btnFindPartNumber = New System.Windows.Forms.Button()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.txtFindPartNumber = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtTransactionWarehouseID = New System.Windows.Forms.TextBox()
        Me.dgvSearchResults = New System.Windows.Forms.DataGridView()
        Me.btnRunReport = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtTransactionMSRNumber = New System.Windows.Forms.TextBox()
        CType(Me.dgvSearchResults, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnReportMenu
        '
        Me.btnReportMenu.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReportMenu.Location = New System.Drawing.Point(866, 299)
        Me.btnReportMenu.Margin = New System.Windows.Forms.Padding(4)
        Me.btnReportMenu.Name = "btnReportMenu"
        Me.btnReportMenu.Size = New System.Drawing.Size(228, 80)
        Me.btnReportMenu.TabIndex = 51
        Me.btnReportMenu.Text = "Report Menu"
        Me.btnReportMenu.UseVisualStyleBackColor = True
        '
        'btnMainMenu
        '
        Me.btnMainMenu.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMainMenu.Location = New System.Drawing.Point(866, 386)
        Me.btnMainMenu.Margin = New System.Windows.Forms.Padding(4)
        Me.btnMainMenu.Name = "btnMainMenu"
        Me.btnMainMenu.Size = New System.Drawing.Size(228, 80)
        Me.btnMainMenu.TabIndex = 50
        Me.btnMainMenu.Text = "Main Menu"
        Me.btnMainMenu.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.Location = New System.Drawing.Point(866, 474)
        Me.btnClose.Margin = New System.Windows.Forms.Padding(4)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(228, 80)
        Me.btnClose.TabIndex = 49
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'Label15
        '
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(85, 449)
        Me.Label15.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(133, 26)
        Me.Label15.TabIndex = 106
        Me.Label15.Text = "Qty"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label16
        '
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(85, 409)
        Me.Label16.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(133, 26)
        Me.Label16.TabIndex = 105
        Me.Label16.Text = "Part Number"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label17
        '
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(85, 374)
        Me.Label17.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(133, 26)
        Me.Label17.TabIndex = 104
        Me.Label17.Text = "Transaction ID"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtTransactionQuantity
        '
        Me.txtTransactionQuantity.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtTransactionQuantity.Location = New System.Drawing.Point(227, 449)
        Me.txtTransactionQuantity.Margin = New System.Windows.Forms.Padding(4)
        Me.txtTransactionQuantity.Name = "txtTransactionQuantity"
        Me.txtTransactionQuantity.ReadOnly = True
        Me.txtTransactionQuantity.Size = New System.Drawing.Size(160, 22)
        Me.txtTransactionQuantity.TabIndex = 103
        '
        'txtTransactionPartNumber
        '
        Me.txtTransactionPartNumber.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtTransactionPartNumber.Location = New System.Drawing.Point(227, 409)
        Me.txtTransactionPartNumber.Margin = New System.Windows.Forms.Padding(4)
        Me.txtTransactionPartNumber.Multiline = True
        Me.txtTransactionPartNumber.Name = "txtTransactionPartNumber"
        Me.txtTransactionPartNumber.ReadOnly = True
        Me.txtTransactionPartNumber.Size = New System.Drawing.Size(160, 32)
        Me.txtTransactionPartNumber.TabIndex = 102
        '
        'cboTransactionID
        '
        Me.cboTransactionID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboTransactionID.FormattingEnabled = True
        Me.cboTransactionID.Location = New System.Drawing.Point(227, 375)
        Me.cboTransactionID.Margin = New System.Windows.Forms.Padding(4)
        Me.cboTransactionID.Name = "cboTransactionID"
        Me.cboTransactionID.Size = New System.Drawing.Size(160, 24)
        Me.cboTransactionID.TabIndex = 101
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(85, 235)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(133, 26)
        Me.Label3.TabIndex = 94
        Me.Label3.Text = "Description"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(85, 166)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(133, 26)
        Me.Label5.TabIndex = 92
        Me.Label5.Text = "Part Number"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtPartDescription
        '
        Me.txtPartDescription.Location = New System.Drawing.Point(227, 204)
        Me.txtPartDescription.Margin = New System.Windows.Forms.Padding(4)
        Me.txtPartDescription.Multiline = True
        Me.txtPartDescription.Name = "txtPartDescription"
        Me.txtPartDescription.ReadOnly = True
        Me.txtPartDescription.Size = New System.Drawing.Size(160, 100)
        Me.txtPartDescription.TabIndex = 91
        '
        'cboPartNumber
        '
        Me.cboPartNumber.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboPartNumber.FormattingEnabled = True
        Me.cboPartNumber.Location = New System.Drawing.Point(227, 167)
        Me.cboPartNumber.Margin = New System.Windows.Forms.Padding(4)
        Me.cboPartNumber.Name = "cboPartNumber"
        Me.cboPartNumber.Size = New System.Drawing.Size(160, 24)
        Me.cboPartNumber.TabIndex = 89
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(85, 478)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(133, 26)
        Me.Label4.TabIndex = 108
        Me.Label4.Text = "Project ID"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtTransactionProjectID
        '
        Me.txtTransactionProjectID.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtTransactionProjectID.Location = New System.Drawing.Point(227, 478)
        Me.txtTransactionProjectID.Margin = New System.Windows.Forms.Padding(4)
        Me.txtTransactionProjectID.Name = "txtTransactionProjectID"
        Me.txtTransactionProjectID.ReadOnly = True
        Me.txtTransactionProjectID.Size = New System.Drawing.Size(160, 22)
        Me.txtTransactionProjectID.TabIndex = 107
        '
        'btnFindPartNumber
        '
        Me.btnFindPartNumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFindPartNumber.Location = New System.Drawing.Point(675, 94)
        Me.btnFindPartNumber.Margin = New System.Windows.Forms.Padding(4)
        Me.btnFindPartNumber.Name = "btnFindPartNumber"
        Me.btnFindPartNumber.Size = New System.Drawing.Size(203, 52)
        Me.btnFindPartNumber.TabIndex = 112
        Me.btnFindPartNumber.Text = "Find Part Number"
        Me.btnFindPartNumber.UseVisualStyleBackColor = True
        '
        'Label18
        '
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(317, 108)
        Me.Label18.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(176, 26)
        Me.Label18.TabIndex = 111
        Me.Label18.Text = "Enter Part Number"
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtFindPartNumber
        '
        Me.txtFindPartNumber.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtFindPartNumber.Location = New System.Drawing.Point(501, 108)
        Me.txtFindPartNumber.Margin = New System.Windows.Forms.Padding(4)
        Me.txtFindPartNumber.Name = "txtFindPartNumber"
        Me.txtFindPartNumber.Size = New System.Drawing.Size(160, 22)
        Me.txtFindPartNumber.TabIndex = 110
        '
        'Label11
        '
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(13, 9)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(1164, 57)
        Me.Label11.TabIndex = 109
        Me.Label11.Text = "Part Transaction Report"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PrintDialog1
        '
        Me.PrintDialog1.UseEXDialog = True
        '
        'PrintDocument1
        '
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(85, 510)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(133, 26)
        Me.Label1.TabIndex = 114
        Me.Label1.Text = "Warehouse ID"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtTransactionWarehouseID
        '
        Me.txtTransactionWarehouseID.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtTransactionWarehouseID.Location = New System.Drawing.Point(227, 510)
        Me.txtTransactionWarehouseID.Margin = New System.Windows.Forms.Padding(4)
        Me.txtTransactionWarehouseID.Name = "txtTransactionWarehouseID"
        Me.txtTransactionWarehouseID.ReadOnly = True
        Me.txtTransactionWarehouseID.Size = New System.Drawing.Size(160, 22)
        Me.txtTransactionWarehouseID.TabIndex = 113
        '
        'dgvSearchResults
        '
        Me.dgvSearchResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvSearchResults.Location = New System.Drawing.Point(13, 167)
        Me.dgvSearchResults.Margin = New System.Windows.Forms.Padding(4)
        Me.dgvSearchResults.Name = "dgvSearchResults"
        Me.dgvSearchResults.Size = New System.Drawing.Size(827, 464)
        Me.dgvSearchResults.TabIndex = 221
        '
        'btnRunReport
        '
        Me.btnRunReport.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRunReport.Location = New System.Drawing.Point(866, 211)
        Me.btnRunReport.Margin = New System.Windows.Forms.Padding(4)
        Me.btnRunReport.Name = "btnRunReport"
        Me.btnRunReport.Size = New System.Drawing.Size(228, 80)
        Me.btnRunReport.TabIndex = 222
        Me.btnRunReport.Text = "Run Report"
        Me.btnRunReport.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(85, 545)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(133, 26)
        Me.Label2.TabIndex = 224
        Me.Label2.Text = "MSR Number"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtTransactionMSRNumber
        '
        Me.txtTransactionMSRNumber.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtTransactionMSRNumber.Location = New System.Drawing.Point(227, 545)
        Me.txtTransactionMSRNumber.Margin = New System.Windows.Forms.Padding(4)
        Me.txtTransactionMSRNumber.Name = "txtTransactionMSRNumber"
        Me.txtTransactionMSRNumber.ReadOnly = True
        Me.txtTransactionMSRNumber.Size = New System.Drawing.Size(160, 22)
        Me.txtTransactionMSRNumber.TabIndex = 223
        '
        'PartProjectTransactionReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1120, 644)
        Me.ControlBox = False
        Me.Controls.Add(Me.dgvSearchResults)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtTransactionMSRNumber)
        Me.Controls.Add(Me.btnRunReport)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtTransactionWarehouseID)
        Me.Controls.Add(Me.btnFindPartNumber)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.txtFindPartNumber)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtTransactionProjectID)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.txtTransactionQuantity)
        Me.Controls.Add(Me.txtTransactionPartNumber)
        Me.Controls.Add(Me.cboTransactionID)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtPartDescription)
        Me.Controls.Add(Me.cboPartNumber)
        Me.Controls.Add(Me.btnReportMenu)
        Me.Controls.Add(Me.btnMainMenu)
        Me.Controls.Add(Me.btnClose)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "PartProjectTransactionReport"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PartProjectTransactionReport"
        CType(Me.dgvSearchResults, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnReportMenu As System.Windows.Forms.Button
    Friend WithEvents btnMainMenu As System.Windows.Forms.Button
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents txtTransactionQuantity As System.Windows.Forms.TextBox
    Friend WithEvents txtTransactionPartNumber As System.Windows.Forms.TextBox
    Friend WithEvents cboTransactionID As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtPartDescription As System.Windows.Forms.TextBox
    Friend WithEvents cboPartNumber As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtTransactionProjectID As System.Windows.Forms.TextBox
    Friend WithEvents btnFindPartNumber As System.Windows.Forms.Button
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents txtFindPartNumber As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents PrintDialog1 As System.Windows.Forms.PrintDialog
    Friend WithEvents PrintDocument1 As System.Drawing.Printing.PrintDocument
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtTransactionWarehouseID As System.Windows.Forms.TextBox
    Friend WithEvents dgvSearchResults As System.Windows.Forms.DataGridView
    Friend WithEvents btnRunReport As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtTransactionMSRNumber As System.Windows.Forms.TextBox
End Class
