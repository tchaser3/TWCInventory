<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EnterInventoryInformation
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
        Me.lblFormTitle = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtQuantity = New System.Windows.Forms.TextBox()
        Me.txtPartNumber = New System.Windows.Forms.TextBox()
        Me.txtProjectID = New System.Windows.Forms.TextBox()
        Me.cboTransactionID = New System.Windows.Forms.ComboBox()
        Me.btnMainMenu = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtDataEntryComplete = New System.Windows.Forms.TextBox()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtDate = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtMSRNumber = New System.Windows.Forms.TextBox()
        Me.btnMenusButton = New System.Windows.Forms.Button()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog()
        Me.dgvBatchTransactions = New System.Windows.Forms.DataGridView()
        Me.btnProcess = New System.Windows.Forms.Button()
        Me.txtTransactionID = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtWarehouseID = New System.Windows.Forms.TextBox()
        CType(Me.dgvBatchTransactions, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblFormTitle
        '
        Me.lblFormTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFormTitle.Location = New System.Drawing.Point(16, 11)
        Me.lblFormTitle.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblFormTitle.Name = "lblFormTitle"
        Me.lblFormTitle.Size = New System.Drawing.Size(1501, 54)
        Me.lblFormTitle.TabIndex = 23
        Me.lblFormTitle.Text = "Update Inventory"
        Me.lblFormTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(43, 319)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(133, 26)
        Me.Label4.TabIndex = 22
        Me.Label4.Text = "Qty"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(43, 278)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(133, 26)
        Me.Label3.TabIndex = 21
        Me.Label3.Text = "Part Number"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(43, 213)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(133, 26)
        Me.Label2.TabIndex = 20
        Me.Label2.Text = "Project ID"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(43, 117)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(133, 26)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "Transaction ID"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtQuantity
        '
        Me.txtQuantity.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtQuantity.Location = New System.Drawing.Point(184, 319)
        Me.txtQuantity.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtQuantity.Name = "txtQuantity"
        Me.txtQuantity.Size = New System.Drawing.Size(160, 22)
        Me.txtQuantity.TabIndex = 5
        '
        'txtPartNumber
        '
        Me.txtPartNumber.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtPartNumber.Location = New System.Drawing.Point(184, 278)
        Me.txtPartNumber.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtPartNumber.Multiline = True
        Me.txtPartNumber.Name = "txtPartNumber"
        Me.txtPartNumber.Size = New System.Drawing.Size(160, 32)
        Me.txtPartNumber.TabIndex = 4
        '
        'txtProjectID
        '
        Me.txtProjectID.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtProjectID.Location = New System.Drawing.Point(184, 213)
        Me.txtProjectID.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtProjectID.Name = "txtProjectID"
        Me.txtProjectID.Size = New System.Drawing.Size(160, 22)
        Me.txtProjectID.TabIndex = 2
        '
        'cboTransactionID
        '
        Me.cboTransactionID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboTransactionID.FormattingEnabled = True
        Me.cboTransactionID.Location = New System.Drawing.Point(184, 118)
        Me.cboTransactionID.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cboTransactionID.Name = "cboTransactionID"
        Me.cboTransactionID.Size = New System.Drawing.Size(160, 24)
        Me.cboTransactionID.TabIndex = 0
        '
        'btnMainMenu
        '
        Me.btnMainMenu.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMainMenu.Location = New System.Drawing.Point(407, 336)
        Me.btnMainMenu.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnMainMenu.Name = "btnMainMenu"
        Me.btnMainMenu.Size = New System.Drawing.Size(197, 78)
        Me.btnMainMenu.TabIndex = 9
        Me.btnMainMenu.Text = "Main Menu"
        Me.btnMainMenu.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.Location = New System.Drawing.Point(407, 421)
        Me.btnClose.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(197, 78)
        Me.btnClose.TabIndex = 10
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(16, 378)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(160, 44)
        Me.Label5.TabIndex = 25
        Me.Label5.Text = "Data Entry Complete"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtDataEntryComplete
        '
        Me.txtDataEntryComplete.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDataEntryComplete.Location = New System.Drawing.Point(184, 389)
        Me.txtDataEntryComplete.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtDataEntryComplete.Name = "txtDataEntryComplete"
        Me.txtDataEntryComplete.Size = New System.Drawing.Size(160, 22)
        Me.txtDataEntryComplete.TabIndex = 6
        '
        'btnAdd
        '
        Me.btnAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.Location = New System.Drawing.Point(407, 92)
        Me.btnAdd.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(197, 78)
        Me.btnAdd.TabIndex = 7
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'Label11
        '
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(43, 180)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(133, 26)
        Me.Label11.TabIndex = 37
        Me.Label11.Text = "Date"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtDate
        '
        Me.txtDate.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDate.Location = New System.Drawing.Point(184, 180)
        Me.txtDate.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtDate.Name = "txtDate"
        Me.txtDate.Size = New System.Drawing.Size(160, 22)
        Me.txtDate.TabIndex = 1
        '
        'Label12
        '
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(43, 245)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(133, 26)
        Me.Label12.TabIndex = 39
        Me.Label12.Text = "MSR Number"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtMSRNumber
        '
        Me.txtMSRNumber.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtMSRNumber.Location = New System.Drawing.Point(184, 245)
        Me.txtMSRNumber.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtMSRNumber.Name = "txtMSRNumber"
        Me.txtMSRNumber.Size = New System.Drawing.Size(160, 22)
        Me.txtMSRNumber.TabIndex = 3
        '
        'btnMenusButton
        '
        Me.btnMenusButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMenusButton.Location = New System.Drawing.Point(407, 255)
        Me.btnMenusButton.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnMenusButton.Name = "btnMenusButton"
        Me.btnMenusButton.Size = New System.Drawing.Size(197, 78)
        Me.btnMenusButton.TabIndex = 8
        Me.btnMenusButton.Text = "Receive Menu"
        Me.btnMenusButton.UseVisualStyleBackColor = True
        '
        'PrintDialog1
        '
        Me.PrintDialog1.UseEXDialog = True
        '
        'dgvBatchTransactions
        '
        Me.dgvBatchTransactions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvBatchTransactions.Location = New System.Drawing.Point(675, 92)
        Me.dgvBatchTransactions.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.dgvBatchTransactions.Name = "dgvBatchTransactions"
        Me.dgvBatchTransactions.Size = New System.Drawing.Size(843, 406)
        Me.dgvBatchTransactions.TabIndex = 40
        '
        'btnProcess
        '
        Me.btnProcess.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnProcess.Location = New System.Drawing.Point(407, 175)
        Me.btnProcess.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnProcess.Name = "btnProcess"
        Me.btnProcess.Size = New System.Drawing.Size(197, 78)
        Me.btnProcess.TabIndex = 41
        Me.btnProcess.Text = "Process"
        Me.btnProcess.UseVisualStyleBackColor = True
        '
        'txtTransactionID
        '
        Me.txtTransactionID.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtTransactionID.Location = New System.Drawing.Point(184, 151)
        Me.txtTransactionID.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtTransactionID.Name = "txtTransactionID"
        Me.txtTransactionID.Size = New System.Drawing.Size(160, 22)
        Me.txtTransactionID.TabIndex = 42
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(43, 352)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(133, 26)
        Me.Label6.TabIndex = 44
        Me.Label6.Text = "Warehouse ID"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtWarehouseID
        '
        Me.txtWarehouseID.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtWarehouseID.Location = New System.Drawing.Point(184, 352)
        Me.txtWarehouseID.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtWarehouseID.Name = "txtWarehouseID"
        Me.txtWarehouseID.ReadOnly = True
        Me.txtWarehouseID.Size = New System.Drawing.Size(160, 22)
        Me.txtWarehouseID.TabIndex = 43
        '
        'EnterInventoryInformation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1544, 513)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtWarehouseID)
        Me.Controls.Add(Me.txtTransactionID)
        Me.Controls.Add(Me.btnProcess)
        Me.Controls.Add(Me.dgvBatchTransactions)
        Me.Controls.Add(Me.btnMenusButton)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.txtMSRNumber)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.txtDate)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtDataEntryComplete)
        Me.Controls.Add(Me.lblFormTitle)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtQuantity)
        Me.Controls.Add(Me.txtPartNumber)
        Me.Controls.Add(Me.txtProjectID)
        Me.Controls.Add(Me.cboTransactionID)
        Me.Controls.Add(Me.btnMainMenu)
        Me.Controls.Add(Me.btnClose)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "EnterInventoryInformation"
        Me.Text = "EnterInventoryInformation"
        CType(Me.dgvBatchTransactions, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblFormTitle As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtQuantity As System.Windows.Forms.TextBox
    Friend WithEvents txtPartNumber As System.Windows.Forms.TextBox
    Friend WithEvents txtProjectID As System.Windows.Forms.TextBox
    Friend WithEvents cboTransactionID As System.Windows.Forms.ComboBox
    Friend WithEvents btnMainMenu As System.Windows.Forms.Button
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtDataEntryComplete As System.Windows.Forms.TextBox
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtDate As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtMSRNumber As System.Windows.Forms.TextBox
    Friend WithEvents btnMenusButton As System.Windows.Forms.Button
    Friend WithEvents PrintDocument1 As System.Drawing.Printing.PrintDocument
    Friend WithEvents PrintDialog1 As System.Windows.Forms.PrintDialog
    Friend WithEvents dgvBatchTransactions As System.Windows.Forms.DataGridView
    Friend WithEvents btnProcess As System.Windows.Forms.Button
    Friend WithEvents txtTransactionID As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtWarehouseID As System.Windows.Forms.TextBox
End Class
