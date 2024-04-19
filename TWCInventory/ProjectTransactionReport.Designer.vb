<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ProjectTransactionReport
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
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnMainMenu = New System.Windows.Forms.Button()
        Me.btnReportMenu = New System.Windows.Forms.Button()
        Me.btnRunReport = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtEnterProjectID = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cboPartNumber = New System.Windows.Forms.ComboBox()
        Me.txtTransactionProjectID = New System.Windows.Forms.TextBox()
        Me.cboTransactionID = New System.Windows.Forms.ComboBox()
        Me.txtTransactionPartNumber = New System.Windows.Forms.TextBox()
        Me.txtTransactionQuantity = New System.Windows.Forms.TextBox()
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.txtPartDescription = New System.Windows.Forms.TextBox()
        Me.btnSearchProjectID = New System.Windows.Forms.Button()
        Me.txtTransactionWarehouseID = New System.Windows.Forms.TextBox()
        Me.txtProjectID = New System.Windows.Forms.TextBox()
        Me.cboInternalID = New System.Windows.Forms.ComboBox()
        Me.dgvSearchResults = New System.Windows.Forms.DataGridView()
        Me.txtTransactionMSRNumber = New System.Windows.Forms.TextBox()
        Me.btnProjectMenu = New System.Windows.Forms.Button()
        CType(Me.dgvSearchResults, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnClose
        '
        Me.btnClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.Location = New System.Drawing.Point(828, 470)
        Me.btnClose.Margin = New System.Windows.Forms.Padding(4)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(200, 80)
        Me.btnClose.TabIndex = 6
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'btnMainMenu
        '
        Me.btnMainMenu.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMainMenu.Location = New System.Drawing.Point(828, 382)
        Me.btnMainMenu.Margin = New System.Windows.Forms.Padding(4)
        Me.btnMainMenu.Name = "btnMainMenu"
        Me.btnMainMenu.Size = New System.Drawing.Size(200, 80)
        Me.btnMainMenu.TabIndex = 5
        Me.btnMainMenu.Text = "Main Menu"
        Me.btnMainMenu.UseVisualStyleBackColor = True
        '
        'btnReportMenu
        '
        Me.btnReportMenu.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReportMenu.Location = New System.Drawing.Point(828, 295)
        Me.btnReportMenu.Margin = New System.Windows.Forms.Padding(4)
        Me.btnReportMenu.Name = "btnReportMenu"
        Me.btnReportMenu.Size = New System.Drawing.Size(200, 80)
        Me.btnReportMenu.TabIndex = 4
        Me.btnReportMenu.Text = "Report Menu"
        Me.btnReportMenu.UseVisualStyleBackColor = True
        '
        'btnRunReport
        '
        Me.btnRunReport.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRunReport.Location = New System.Drawing.Point(828, 121)
        Me.btnRunReport.Margin = New System.Windows.Forms.Padding(4)
        Me.btnRunReport.Name = "btnRunReport"
        Me.btnRunReport.Size = New System.Drawing.Size(200, 80)
        Me.btnRunReport.TabIndex = 2
        Me.btnRunReport.Text = "Run Report"
        Me.btnRunReport.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(17, 11)
        Me.Label1.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(1011, 53)
        Me.Label1.TabIndex = 47
        Me.Label1.Text = "Project Transaction Report"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtEnterProjectID
        '
        Me.txtEnterProjectID.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtEnterProjectID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEnterProjectID.Location = New System.Drawing.Point(339, 101)
        Me.txtEnterProjectID.Margin = New System.Windows.Forms.Padding(4)
        Me.txtEnterProjectID.Name = "txtEnterProjectID"
        Me.txtEnterProjectID.Size = New System.Drawing.Size(183, 26)
        Me.txtEnterProjectID.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(147, 100)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(184, 28)
        Me.Label2.TabIndex = 49
        Me.Label2.Text = "Enter Project ID"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cboPartNumber
        '
        Me.cboPartNumber.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboPartNumber.FormattingEnabled = True
        Me.cboPartNumber.Location = New System.Drawing.Point(223, 177)
        Me.cboPartNumber.Margin = New System.Windows.Forms.Padding(4)
        Me.cboPartNumber.Name = "cboPartNumber"
        Me.cboPartNumber.Size = New System.Drawing.Size(160, 24)
        Me.cboPartNumber.TabIndex = 50
        '
        'txtTransactionProjectID
        '
        Me.txtTransactionProjectID.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtTransactionProjectID.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTransactionProjectID.Location = New System.Drawing.Point(223, 354)
        Me.txtTransactionProjectID.Margin = New System.Windows.Forms.Padding(4)
        Me.txtTransactionProjectID.Name = "txtTransactionProjectID"
        Me.txtTransactionProjectID.ReadOnly = True
        Me.txtTransactionProjectID.Size = New System.Drawing.Size(160, 23)
        Me.txtTransactionProjectID.TabIndex = 55
        '
        'cboTransactionID
        '
        Me.cboTransactionID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboTransactionID.FormattingEnabled = True
        Me.cboTransactionID.Location = New System.Drawing.Point(225, 291)
        Me.cboTransactionID.Margin = New System.Windows.Forms.Padding(4)
        Me.cboTransactionID.Name = "cboTransactionID"
        Me.cboTransactionID.Size = New System.Drawing.Size(160, 24)
        Me.cboTransactionID.TabIndex = 54
        '
        'txtTransactionPartNumber
        '
        Me.txtTransactionPartNumber.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtTransactionPartNumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTransactionPartNumber.Location = New System.Drawing.Point(225, 386)
        Me.txtTransactionPartNumber.Margin = New System.Windows.Forms.Padding(4)
        Me.txtTransactionPartNumber.Name = "txtTransactionPartNumber"
        Me.txtTransactionPartNumber.ReadOnly = True
        Me.txtTransactionPartNumber.Size = New System.Drawing.Size(160, 23)
        Me.txtTransactionPartNumber.TabIndex = 58
        '
        'txtTransactionQuantity
        '
        Me.txtTransactionQuantity.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtTransactionQuantity.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTransactionQuantity.Location = New System.Drawing.Point(225, 418)
        Me.txtTransactionQuantity.Margin = New System.Windows.Forms.Padding(4)
        Me.txtTransactionQuantity.Name = "txtTransactionQuantity"
        Me.txtTransactionQuantity.ReadOnly = True
        Me.txtTransactionQuantity.Size = New System.Drawing.Size(160, 23)
        Me.txtTransactionQuantity.TabIndex = 60
        '
        'PrintDialog1
        '
        Me.PrintDialog1.UseEXDialog = True
        '
        'PrintDocument1
        '
        '
        'txtPartDescription
        '
        Me.txtPartDescription.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtPartDescription.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPartDescription.Location = New System.Drawing.Point(223, 219)
        Me.txtPartDescription.Margin = New System.Windows.Forms.Padding(4)
        Me.txtPartDescription.Name = "txtPartDescription"
        Me.txtPartDescription.ReadOnly = True
        Me.txtPartDescription.Size = New System.Drawing.Size(160, 23)
        Me.txtPartDescription.TabIndex = 62
        '
        'btnSearchProjectID
        '
        Me.btnSearchProjectID.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearchProjectID.Location = New System.Drawing.Point(539, 89)
        Me.btnSearchProjectID.Margin = New System.Windows.Forms.Padding(4)
        Me.btnSearchProjectID.Name = "btnSearchProjectID"
        Me.btnSearchProjectID.Size = New System.Drawing.Size(167, 47)
        Me.btnSearchProjectID.TabIndex = 1
        Me.btnSearchProjectID.Text = "Search"
        Me.btnSearchProjectID.UseVisualStyleBackColor = True
        '
        'txtTransactionWarehouseID
        '
        Me.txtTransactionWarehouseID.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtTransactionWarehouseID.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTransactionWarehouseID.Location = New System.Drawing.Point(226, 322)
        Me.txtTransactionWarehouseID.Margin = New System.Windows.Forms.Padding(4)
        Me.txtTransactionWarehouseID.Name = "txtTransactionWarehouseID"
        Me.txtTransactionWarehouseID.ReadOnly = True
        Me.txtTransactionWarehouseID.Size = New System.Drawing.Size(160, 23)
        Me.txtTransactionWarehouseID.TabIndex = 224
        '
        'txtProjectID
        '
        Me.txtProjectID.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtProjectID.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtProjectID.Location = New System.Drawing.Point(223, 535)
        Me.txtProjectID.Margin = New System.Windows.Forms.Padding(4)
        Me.txtProjectID.Name = "txtProjectID"
        Me.txtProjectID.ReadOnly = True
        Me.txtProjectID.Size = New System.Drawing.Size(160, 23)
        Me.txtProjectID.TabIndex = 228
        '
        'cboInternalID
        '
        Me.cboInternalID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboInternalID.FormattingEnabled = True
        Me.cboInternalID.Location = New System.Drawing.Point(223, 493)
        Me.cboInternalID.Margin = New System.Windows.Forms.Padding(4)
        Me.cboInternalID.Name = "cboInternalID"
        Me.cboInternalID.Size = New System.Drawing.Size(160, 24)
        Me.cboInternalID.TabIndex = 226
        '
        'dgvSearchResults
        '
        Me.dgvSearchResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvSearchResults.Location = New System.Drawing.Point(23, 146)
        Me.dgvSearchResults.Margin = New System.Windows.Forms.Padding(4)
        Me.dgvSearchResults.Name = "dgvSearchResults"
        Me.dgvSearchResults.Size = New System.Drawing.Size(777, 427)
        Me.dgvSearchResults.TabIndex = 223
        '
        'txtTransactionMSRNumber
        '
        Me.txtTransactionMSRNumber.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtTransactionMSRNumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTransactionMSRNumber.Location = New System.Drawing.Point(223, 449)
        Me.txtTransactionMSRNumber.Margin = New System.Windows.Forms.Padding(4)
        Me.txtTransactionMSRNumber.Name = "txtTransactionMSRNumber"
        Me.txtTransactionMSRNumber.ReadOnly = True
        Me.txtTransactionMSRNumber.Size = New System.Drawing.Size(160, 23)
        Me.txtTransactionMSRNumber.TabIndex = 229
        '
        'btnProjectMenu
        '
        Me.btnProjectMenu.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnProjectMenu.Location = New System.Drawing.Point(828, 209)
        Me.btnProjectMenu.Margin = New System.Windows.Forms.Padding(4)
        Me.btnProjectMenu.Name = "btnProjectMenu"
        Me.btnProjectMenu.Size = New System.Drawing.Size(200, 80)
        Me.btnProjectMenu.TabIndex = 3
        Me.btnProjectMenu.Text = "Project Menu"
        Me.btnProjectMenu.UseVisualStyleBackColor = True
        '
        'ProjectTransactionReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1050, 586)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnProjectMenu)
        Me.Controls.Add(Me.dgvSearchResults)
        Me.Controls.Add(Me.txtTransactionMSRNumber)
        Me.Controls.Add(Me.txtProjectID)
        Me.Controls.Add(Me.cboInternalID)
        Me.Controls.Add(Me.txtTransactionWarehouseID)
        Me.Controls.Add(Me.btnSearchProjectID)
        Me.Controls.Add(Me.txtPartDescription)
        Me.Controls.Add(Me.txtTransactionQuantity)
        Me.Controls.Add(Me.txtTransactionPartNumber)
        Me.Controls.Add(Me.txtTransactionProjectID)
        Me.Controls.Add(Me.cboTransactionID)
        Me.Controls.Add(Me.cboPartNumber)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtEnterProjectID)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnRunReport)
        Me.Controls.Add(Me.btnReportMenu)
        Me.Controls.Add(Me.btnMainMenu)
        Me.Controls.Add(Me.btnClose)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "ProjectTransactionReport"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ProjectTransactionReport"
        CType(Me.dgvSearchResults, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents btnMainMenu As System.Windows.Forms.Button
    Friend WithEvents btnReportMenu As System.Windows.Forms.Button
    Friend WithEvents btnRunReport As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtEnterProjectID As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cboPartNumber As System.Windows.Forms.ComboBox
    Friend WithEvents txtTransactionProjectID As System.Windows.Forms.TextBox
    Friend WithEvents cboTransactionID As System.Windows.Forms.ComboBox
    Friend WithEvents txtTransactionPartNumber As System.Windows.Forms.TextBox
    Friend WithEvents txtTransactionQuantity As System.Windows.Forms.TextBox
    Friend WithEvents PrintDialog1 As System.Windows.Forms.PrintDialog
    Friend WithEvents PrintDocument1 As System.Drawing.Printing.PrintDocument
    Friend WithEvents txtPartDescription As System.Windows.Forms.TextBox
    Friend WithEvents btnSearchProjectID As System.Windows.Forms.Button
    Friend WithEvents txtTransactionWarehouseID As System.Windows.Forms.TextBox
    Friend WithEvents txtProjectID As System.Windows.Forms.TextBox
    Friend WithEvents cboInternalID As System.Windows.Forms.ComboBox
    Friend WithEvents dgvSearchResults As System.Windows.Forms.DataGridView
    Friend WithEvents txtTransactionMSRNumber As System.Windows.Forms.TextBox
    Friend WithEvents btnProjectMenu As System.Windows.Forms.Button
End Class
