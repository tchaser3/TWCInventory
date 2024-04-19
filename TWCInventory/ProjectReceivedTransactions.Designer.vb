<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ProjectReceivedTransactions
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
        Me.btnRunReport = New System.Windows.Forms.Button()
        Me.btnMainMenu = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnFindProjectID = New System.Windows.Forms.Button()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.txtFindProjectID = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtQuantity = New System.Windows.Forms.TextBox()
        Me.txtPartNumber = New System.Windows.Forms.TextBox()
        Me.cboTransactionID = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtProjectID = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtPartDescription = New System.Windows.Forms.TextBox()
        Me.cboPartNumber = New System.Windows.Forms.ComboBox()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtDate = New System.Windows.Forms.TextBox()
        Me.btnReceiveMenu = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtWarehouseID = New System.Windows.Forms.TextBox()
        Me.dgvSearchResults = New System.Windows.Forms.DataGridView()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtMSRNumber = New System.Windows.Forms.TextBox()
        CType(Me.dgvSearchResults, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnRunReport
        '
        Me.btnRunReport.Enabled = False
        Me.btnRunReport.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRunReport.Location = New System.Drawing.Point(335, 147)
        Me.btnRunReport.Name = "btnRunReport"
        Me.btnRunReport.Size = New System.Drawing.Size(171, 65)
        Me.btnRunReport.TabIndex = 3
        Me.btnRunReport.Text = "Run Report"
        Me.btnRunReport.UseVisualStyleBackColor = True
        '
        'btnMainMenu
        '
        Me.btnMainMenu.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMainMenu.Location = New System.Drawing.Point(335, 291)
        Me.btnMainMenu.Name = "btnMainMenu"
        Me.btnMainMenu.Size = New System.Drawing.Size(171, 65)
        Me.btnMainMenu.TabIndex = 5
        Me.btnMainMenu.Text = "Main Menu"
        Me.btnMainMenu.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.Location = New System.Drawing.Point(335, 362)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(171, 65)
        Me.btnClose.TabIndex = 6
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'btnFindProjectID
        '
        Me.btnFindProjectID.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFindProjectID.Location = New System.Drawing.Point(335, 82)
        Me.btnFindProjectID.Name = "btnFindProjectID"
        Me.btnFindProjectID.Size = New System.Drawing.Size(169, 42)
        Me.btnFindProjectID.TabIndex = 2
        Me.btnFindProjectID.Text = "Find Project ID"
        Me.btnFindProjectID.UseVisualStyleBackColor = True
        '
        'Label18
        '
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(63, 94)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(132, 21)
        Me.Label18.TabIndex = 94
        Me.Label18.Text = "Enter Project ID"
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtFindProjectID
        '
        Me.txtFindProjectID.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtFindProjectID.Location = New System.Drawing.Point(201, 94)
        Me.txtFindProjectID.Name = "txtFindProjectID"
        Me.txtFindProjectID.Size = New System.Drawing.Size(121, 20)
        Me.txtFindProjectID.TabIndex = 0
        '
        'Label11
        '
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(12, 9)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(902, 46)
        Me.Label11.TabIndex = 92
        Me.Label11.Text = "Project Parts Received"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(48, 496)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(100, 21)
        Me.Label9.TabIndex = 101
        Me.Label9.Text = "Qty"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label10
        '
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(48, 298)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(100, 21)
        Me.Label10.TabIndex = 100
        Me.Label10.Text = "Part Number"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtQuantity
        '
        Me.txtQuantity.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtQuantity.Location = New System.Drawing.Point(154, 496)
        Me.txtQuantity.Name = "txtQuantity"
        Me.txtQuantity.ReadOnly = True
        Me.txtQuantity.Size = New System.Drawing.Size(121, 20)
        Me.txtQuantity.TabIndex = 98
        '
        'txtPartNumber
        '
        Me.txtPartNumber.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtPartNumber.Location = New System.Drawing.Point(154, 298)
        Me.txtPartNumber.Multiline = True
        Me.txtPartNumber.Name = "txtPartNumber"
        Me.txtPartNumber.ReadOnly = True
        Me.txtPartNumber.Size = New System.Drawing.Size(121, 27)
        Me.txtPartNumber.TabIndex = 97
        '
        'cboTransactionID
        '
        Me.cboTransactionID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboTransactionID.FormattingEnabled = True
        Me.cboTransactionID.Location = New System.Drawing.Point(154, 164)
        Me.cboTransactionID.Name = "cboTransactionID"
        Me.cboTransactionID.Size = New System.Drawing.Size(121, 21)
        Me.cboTransactionID.TabIndex = 96
        Me.cboTransactionID.Visible = False
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(48, 231)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 21)
        Me.Label1.TabIndex = 103
        Me.Label1.Text = "Project ID"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtProjectID
        '
        Me.txtProjectID.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtProjectID.Location = New System.Drawing.Point(154, 231)
        Me.txtProjectID.Multiline = True
        Me.txtProjectID.Name = "txtProjectID"
        Me.txtProjectID.ReadOnly = True
        Me.txtProjectID.Size = New System.Drawing.Size(121, 27)
        Me.txtProjectID.TabIndex = 102
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(48, 425)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(100, 21)
        Me.Label3.TabIndex = 105
        Me.Label3.Text = "Description"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtPartDescription
        '
        Me.txtPartDescription.Location = New System.Drawing.Point(154, 400)
        Me.txtPartDescription.Multiline = True
        Me.txtPartDescription.Name = "txtPartDescription"
        Me.txtPartDescription.ReadOnly = True
        Me.txtPartDescription.Size = New System.Drawing.Size(121, 82)
        Me.txtPartDescription.TabIndex = 104
        '
        'cboPartNumber
        '
        Me.cboPartNumber.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboPartNumber.FormattingEnabled = True
        Me.cboPartNumber.Location = New System.Drawing.Point(154, 191)
        Me.cboPartNumber.Name = "cboPartNumber"
        Me.cboPartNumber.Size = New System.Drawing.Size(121, 21)
        Me.cboPartNumber.TabIndex = 106
        Me.cboPartNumber.Visible = False
        '
        'PrintDocument1
        '
        '
        'PrintDialog1
        '
        Me.PrintDialog1.UseEXDialog = True
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(48, 364)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(100, 21)
        Me.Label4.TabIndex = 112
        Me.Label4.Text = "Date"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtDate
        '
        Me.txtDate.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDate.Location = New System.Drawing.Point(154, 364)
        Me.txtDate.Multiline = True
        Me.txtDate.Name = "txtDate"
        Me.txtDate.ReadOnly = True
        Me.txtDate.Size = New System.Drawing.Size(121, 27)
        Me.txtDate.TabIndex = 111
        '
        'btnReceiveMenu
        '
        Me.btnReceiveMenu.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReceiveMenu.Location = New System.Drawing.Point(335, 218)
        Me.btnReceiveMenu.Name = "btnReceiveMenu"
        Me.btnReceiveMenu.Size = New System.Drawing.Size(171, 65)
        Me.btnReceiveMenu.TabIndex = 4
        Me.btnReceiveMenu.Text = "Receive Menu"
        Me.btnReceiveMenu.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(48, 331)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(100, 21)
        Me.Label5.TabIndex = 114
        Me.Label5.Text = "Warehouse ID"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtWarehouseID
        '
        Me.txtWarehouseID.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtWarehouseID.Location = New System.Drawing.Point(154, 331)
        Me.txtWarehouseID.Multiline = True
        Me.txtWarehouseID.Name = "txtWarehouseID"
        Me.txtWarehouseID.ReadOnly = True
        Me.txtWarehouseID.Size = New System.Drawing.Size(121, 27)
        Me.txtWarehouseID.TabIndex = 113
        '
        'dgvSearchResults
        '
        Me.dgvSearchResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvSearchResults.Location = New System.Drawing.Point(539, 147)
        Me.dgvSearchResults.Name = "dgvSearchResults"
        Me.dgvSearchResults.Size = New System.Drawing.Size(375, 359)
        Me.dgvSearchResults.TabIndex = 220
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(48, 265)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(100, 21)
        Me.Label6.TabIndex = 222
        Me.Label6.Text = "MSR Number"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtMSRNumber
        '
        Me.txtMSRNumber.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtMSRNumber.Location = New System.Drawing.Point(154, 265)
        Me.txtMSRNumber.Multiline = True
        Me.txtMSRNumber.Name = "txtMSRNumber"
        Me.txtMSRNumber.ReadOnly = True
        Me.txtMSRNumber.Size = New System.Drawing.Size(121, 27)
        Me.txtMSRNumber.TabIndex = 221
        '
        'ProjectReceivedTransactions
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(938, 544)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtMSRNumber)
        Me.Controls.Add(Me.dgvSearchResults)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtWarehouseID)
        Me.Controls.Add(Me.btnReceiveMenu)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtDate)
        Me.Controls.Add(Me.cboPartNumber)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtPartDescription)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtProjectID)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txtQuantity)
        Me.Controls.Add(Me.txtPartNumber)
        Me.Controls.Add(Me.cboTransactionID)
        Me.Controls.Add(Me.btnFindProjectID)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.txtFindProjectID)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.btnRunReport)
        Me.Controls.Add(Me.btnMainMenu)
        Me.Controls.Add(Me.btnClose)
        Me.Name = "ProjectReceivedTransactions"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ProjectReceivedTransactions"
        CType(Me.dgvSearchResults, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnRunReport As System.Windows.Forms.Button
    Friend WithEvents btnMainMenu As System.Windows.Forms.Button
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents btnFindProjectID As System.Windows.Forms.Button
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents txtFindProjectID As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtQuantity As System.Windows.Forms.TextBox
    Friend WithEvents txtPartNumber As System.Windows.Forms.TextBox
    Friend WithEvents cboTransactionID As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtProjectID As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtPartDescription As System.Windows.Forms.TextBox
    Friend WithEvents cboPartNumber As System.Windows.Forms.ComboBox
    Friend WithEvents PrintDocument1 As System.Drawing.Printing.PrintDocument
    Friend WithEvents PrintDialog1 As System.Windows.Forms.PrintDialog
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtDate As System.Windows.Forms.TextBox
    Friend WithEvents btnReceiveMenu As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtWarehouseID As System.Windows.Forms.TextBox
    Friend WithEvents dgvSearchResults As System.Windows.Forms.DataGridView
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtMSRNumber As System.Windows.Forms.TextBox
End Class
