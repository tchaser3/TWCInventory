<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UseMaterialFromIssued
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
        Me.btnUseMenu = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtProjectIDForSearch = New System.Windows.Forms.TextBox()
        Me.btnFind = New System.Windows.Forms.Button()
        Me.dgvSearchResults = New System.Windows.Forms.DataGridView()
        Me.cboInternalProjectID = New System.Windows.Forms.ComboBox()
        Me.txtTWCProjectID = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtTransactionInternalID = New System.Windows.Forms.TextBox()
        Me.cboTransactionID = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtTransactionTWCProjectID = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtTransactionPartNumber = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtTransactionQuantity = New System.Windows.Forms.TextBox()
        Me.btnProcess = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtTransactionWarehouseID = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtPartDescription = New System.Windows.Forms.TextBox()
        Me.cboPartNumber = New System.Windows.Forms.ComboBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtTransactionDate = New System.Windows.Forms.TextBox()
        CType(Me.dgvSearchResults, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnClose
        '
        Me.btnClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.Location = New System.Drawing.Point(515, 557)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(152, 62)
        Me.btnClose.TabIndex = 14
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'btnMainMenu
        '
        Me.btnMainMenu.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMainMenu.Location = New System.Drawing.Point(515, 489)
        Me.btnMainMenu.Name = "btnMainMenu"
        Me.btnMainMenu.Size = New System.Drawing.Size(152, 62)
        Me.btnMainMenu.TabIndex = 15
        Me.btnMainMenu.Text = "Main Menu"
        Me.btnMainMenu.UseVisualStyleBackColor = True
        '
        'btnUseMenu
        '
        Me.btnUseMenu.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUseMenu.Location = New System.Drawing.Point(515, 421)
        Me.btnUseMenu.Name = "btnUseMenu"
        Me.btnUseMenu.Size = New System.Drawing.Size(152, 62)
        Me.btnUseMenu.TabIndex = 16
        Me.btnUseMenu.Text = "Use Menu"
        Me.btnUseMenu.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(13, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(654, 48)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "Show Useage From Material Issued"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(122, 93)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(137, 23)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "Enter Project ID"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtProjectIDForSearch
        '
        Me.txtProjectIDForSearch.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtProjectIDForSearch.Location = New System.Drawing.Point(265, 93)
        Me.txtProjectIDForSearch.Name = "txtProjectIDForSearch"
        Me.txtProjectIDForSearch.Size = New System.Drawing.Size(124, 20)
        Me.txtProjectIDForSearch.TabIndex = 19
        '
        'btnFind
        '
        Me.btnFind.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFind.Location = New System.Drawing.Point(404, 84)
        Me.btnFind.Name = "btnFind"
        Me.btnFind.Size = New System.Drawing.Size(98, 36)
        Me.btnFind.TabIndex = 20
        Me.btnFind.Text = "Find"
        Me.btnFind.UseVisualStyleBackColor = True
        '
        'dgvSearchResults
        '
        Me.dgvSearchResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvSearchResults.Location = New System.Drawing.Point(18, 353)
        Me.dgvSearchResults.Name = "dgvSearchResults"
        Me.dgvSearchResults.Size = New System.Drawing.Size(474, 265)
        Me.dgvSearchResults.TabIndex = 21
        '
        'cboInternalProjectID
        '
        Me.cboInternalProjectID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboInternalProjectID.FormattingEnabled = True
        Me.cboInternalProjectID.Location = New System.Drawing.Point(157, 157)
        Me.cboInternalProjectID.Name = "cboInternalProjectID"
        Me.cboInternalProjectID.Size = New System.Drawing.Size(121, 21)
        Me.cboInternalProjectID.TabIndex = 22
        '
        'txtTWCProjectID
        '
        Me.txtTWCProjectID.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtTWCProjectID.Location = New System.Drawing.Point(157, 184)
        Me.txtTWCProjectID.Name = "txtTWCProjectID"
        Me.txtTWCProjectID.ReadOnly = True
        Me.txtTWCProjectID.Size = New System.Drawing.Size(124, 20)
        Me.txtTWCProjectID.TabIndex = 23
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 157)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(137, 23)
        Me.Label3.TabIndex = 24
        Me.Label3.Text = "Internal Project ID"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(12, 184)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(137, 23)
        Me.Label4.TabIndex = 25
        Me.Label4.Text = "TWC Project ID"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(321, 184)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(137, 23)
        Me.Label5.TabIndex = 29
        Me.Label5.Text = "Internal Project ID"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(321, 157)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(137, 23)
        Me.Label6.TabIndex = 28
        Me.Label6.Text = "Transaction ID"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtTransactionInternalID
        '
        Me.txtTransactionInternalID.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtTransactionInternalID.Location = New System.Drawing.Point(466, 184)
        Me.txtTransactionInternalID.Name = "txtTransactionInternalID"
        Me.txtTransactionInternalID.ReadOnly = True
        Me.txtTransactionInternalID.Size = New System.Drawing.Size(124, 20)
        Me.txtTransactionInternalID.TabIndex = 27
        '
        'cboTransactionID
        '
        Me.cboTransactionID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboTransactionID.FormattingEnabled = True
        Me.cboTransactionID.Location = New System.Drawing.Point(466, 157)
        Me.cboTransactionID.Name = "cboTransactionID"
        Me.cboTransactionID.Size = New System.Drawing.Size(121, 21)
        Me.cboTransactionID.TabIndex = 26
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(321, 210)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(137, 23)
        Me.Label7.TabIndex = 31
        Me.Label7.Text = "TWC Project ID"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtTransactionTWCProjectID
        '
        Me.txtTransactionTWCProjectID.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtTransactionTWCProjectID.Location = New System.Drawing.Point(466, 210)
        Me.txtTransactionTWCProjectID.Name = "txtTransactionTWCProjectID"
        Me.txtTransactionTWCProjectID.ReadOnly = True
        Me.txtTransactionTWCProjectID.Size = New System.Drawing.Size(124, 20)
        Me.txtTransactionTWCProjectID.TabIndex = 30
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(321, 236)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(137, 23)
        Me.Label8.TabIndex = 33
        Me.Label8.Text = "Part Number"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtTransactionPartNumber
        '
        Me.txtTransactionPartNumber.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtTransactionPartNumber.Location = New System.Drawing.Point(466, 236)
        Me.txtTransactionPartNumber.Name = "txtTransactionPartNumber"
        Me.txtTransactionPartNumber.ReadOnly = True
        Me.txtTransactionPartNumber.Size = New System.Drawing.Size(124, 20)
        Me.txtTransactionPartNumber.TabIndex = 32
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(321, 262)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(137, 23)
        Me.Label9.TabIndex = 35
        Me.Label9.Text = "Quantity"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtTransactionQuantity
        '
        Me.txtTransactionQuantity.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtTransactionQuantity.Location = New System.Drawing.Point(466, 262)
        Me.txtTransactionQuantity.Name = "txtTransactionQuantity"
        Me.txtTransactionQuantity.ReadOnly = True
        Me.txtTransactionQuantity.Size = New System.Drawing.Size(124, 20)
        Me.txtTransactionQuantity.TabIndex = 34
        '
        'btnProcess
        '
        Me.btnProcess.Enabled = False
        Me.btnProcess.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnProcess.Location = New System.Drawing.Point(515, 353)
        Me.btnProcess.Name = "btnProcess"
        Me.btnProcess.Size = New System.Drawing.Size(152, 62)
        Me.btnProcess.TabIndex = 36
        Me.btnProcess.Text = "Process"
        Me.btnProcess.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(321, 288)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(137, 23)
        Me.Label10.TabIndex = 38
        Me.Label10.Text = "Warehouse ID"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtTransactionWarehouseID
        '
        Me.txtTransactionWarehouseID.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtTransactionWarehouseID.Location = New System.Drawing.Point(466, 288)
        Me.txtTransactionWarehouseID.Name = "txtTransactionWarehouseID"
        Me.txtTransactionWarehouseID.ReadOnly = True
        Me.txtTransactionWarehouseID.Size = New System.Drawing.Size(124, 20)
        Me.txtTransactionWarehouseID.TabIndex = 37
        '
        'Label11
        '
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(12, 263)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(137, 23)
        Me.Label11.TabIndex = 42
        Me.Label11.Text = "Description"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label12
        '
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(12, 236)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(137, 23)
        Me.Label12.TabIndex = 41
        Me.Label12.Text = "Part Number"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtPartDescription
        '
        Me.txtPartDescription.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtPartDescription.Location = New System.Drawing.Point(157, 263)
        Me.txtPartDescription.Name = "txtPartDescription"
        Me.txtPartDescription.ReadOnly = True
        Me.txtPartDescription.Size = New System.Drawing.Size(124, 20)
        Me.txtPartDescription.TabIndex = 40
        '
        'cboPartNumber
        '
        Me.cboPartNumber.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboPartNumber.FormattingEnabled = True
        Me.cboPartNumber.Location = New System.Drawing.Point(157, 236)
        Me.cboPartNumber.Name = "cboPartNumber"
        Me.cboPartNumber.Size = New System.Drawing.Size(121, 21)
        Me.cboPartNumber.TabIndex = 39
        '
        'Label13
        '
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(321, 312)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(137, 23)
        Me.Label13.TabIndex = 44
        Me.Label13.Text = "Date"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtTransactionDate
        '
        Me.txtTransactionDate.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtTransactionDate.Location = New System.Drawing.Point(466, 314)
        Me.txtTransactionDate.Name = "txtTransactionDate"
        Me.txtTransactionDate.ReadOnly = True
        Me.txtTransactionDate.Size = New System.Drawing.Size(124, 20)
        Me.txtTransactionDate.TabIndex = 43
        '
        'UseMaterialFromIssued
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(679, 644)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.txtTransactionDate)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.txtPartDescription)
        Me.Controls.Add(Me.cboPartNumber)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txtTransactionWarehouseID)
        Me.Controls.Add(Me.btnProcess)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtTransactionQuantity)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtTransactionPartNumber)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtTransactionTWCProjectID)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtTransactionInternalID)
        Me.Controls.Add(Me.cboTransactionID)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtTWCProjectID)
        Me.Controls.Add(Me.cboInternalProjectID)
        Me.Controls.Add(Me.dgvSearchResults)
        Me.Controls.Add(Me.btnFind)
        Me.Controls.Add(Me.txtProjectIDForSearch)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnUseMenu)
        Me.Controls.Add(Me.btnMainMenu)
        Me.Controls.Add(Me.btnClose)
        Me.Name = "UseMaterialFromIssued"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "UseMaterialFromIssued"
        CType(Me.dgvSearchResults, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents btnMainMenu As System.Windows.Forms.Button
    Friend WithEvents btnUseMenu As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtProjectIDForSearch As System.Windows.Forms.TextBox
    Friend WithEvents btnFind As System.Windows.Forms.Button
    Friend WithEvents dgvSearchResults As System.Windows.Forms.DataGridView
    Friend WithEvents cboInternalProjectID As System.Windows.Forms.ComboBox
    Friend WithEvents txtTWCProjectID As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtTransactionInternalID As System.Windows.Forms.TextBox
    Friend WithEvents cboTransactionID As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtTransactionTWCProjectID As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtTransactionPartNumber As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtTransactionQuantity As System.Windows.Forms.TextBox
    Friend WithEvents btnProcess As System.Windows.Forms.Button
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtTransactionWarehouseID As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtPartDescription As System.Windows.Forms.TextBox
    Friend WithEvents cboPartNumber As System.Windows.Forms.ComboBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txtTransactionDate As System.Windows.Forms.TextBox
End Class
