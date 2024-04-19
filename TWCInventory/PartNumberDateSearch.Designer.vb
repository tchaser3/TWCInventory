<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PartNumberDateSearch
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
        Me.btnMainMenu = New System.Windows.Forms.Button()
        Me.btnReceiveMenu = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtPartDescription = New System.Windows.Forms.TextBox()
        Me.cboPartNumber = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtProjectID = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtWarehouseID = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtDate = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtMSRNumber = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtPartNumber = New System.Windows.Forms.TextBox()
        Me.cboTransactionID = New System.Windows.Forms.ComboBox()
        Me.txtQuantity = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtEnterStartDate = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtEnterEndDate = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtEnterPartNumber = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.btnFindParts = New System.Windows.Forms.Button()
        Me.btnRunReport = New System.Windows.Forms.Button()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog()
        Me.dgvSearchResults = New System.Windows.Forms.DataGridView()
        CType(Me.dgvSearchResults, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnMainMenu
        '
        Me.btnMainMenu.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMainMenu.Location = New System.Drawing.Point(344, 337)
        Me.btnMainMenu.Name = "btnMainMenu"
        Me.btnMainMenu.Size = New System.Drawing.Size(152, 62)
        Me.btnMainMenu.TabIndex = 6
        Me.btnMainMenu.Text = "Main Menu"
        Me.btnMainMenu.UseVisualStyleBackColor = True
        '
        'btnReceiveMenu
        '
        Me.btnReceiveMenu.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReceiveMenu.Location = New System.Drawing.Point(344, 269)
        Me.btnReceiveMenu.Name = "btnReceiveMenu"
        Me.btnReceiveMenu.Size = New System.Drawing.Size(152, 62)
        Me.btnReceiveMenu.TabIndex = 5
        Me.btnReceiveMenu.Text = "Receive Menu"
        Me.btnReceiveMenu.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.Location = New System.Drawing.Point(344, 405)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(152, 62)
        Me.btnClose.TabIndex = 7
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(66, 519)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(100, 21)
        Me.Label3.TabIndex = 179
        Me.Label3.Text = "Description"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtPartDescription
        '
        Me.txtPartDescription.Location = New System.Drawing.Point(172, 512)
        Me.txtPartDescription.Multiline = True
        Me.txtPartDescription.Name = "txtPartDescription"
        Me.txtPartDescription.ReadOnly = True
        Me.txtPartDescription.Size = New System.Drawing.Size(121, 28)
        Me.txtPartDescription.TabIndex = 178
        '
        'cboPartNumber
        '
        Me.cboPartNumber.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboPartNumber.FormattingEnabled = True
        Me.cboPartNumber.Location = New System.Drawing.Point(172, 485)
        Me.cboPartNumber.Name = "cboPartNumber"
        Me.cboPartNumber.Size = New System.Drawing.Size(121, 21)
        Me.cboPartNumber.TabIndex = 177
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(66, 268)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 21)
        Me.Label2.TabIndex = 176
        Me.Label2.Text = "Project ID"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtProjectID
        '
        Me.txtProjectID.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtProjectID.Location = New System.Drawing.Point(172, 268)
        Me.txtProjectID.Multiline = True
        Me.txtProjectID.Name = "txtProjectID"
        Me.txtProjectID.ReadOnly = True
        Me.txtProjectID.Size = New System.Drawing.Size(121, 27)
        Me.txtProjectID.TabIndex = 175
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(66, 374)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(100, 21)
        Me.Label5.TabIndex = 174
        Me.Label5.Text = "Warehouse ID"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtWarehouseID
        '
        Me.txtWarehouseID.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtWarehouseID.Location = New System.Drawing.Point(172, 374)
        Me.txtWarehouseID.Multiline = True
        Me.txtWarehouseID.Name = "txtWarehouseID"
        Me.txtWarehouseID.ReadOnly = True
        Me.txtWarehouseID.Size = New System.Drawing.Size(121, 27)
        Me.txtWarehouseID.TabIndex = 173
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(66, 412)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(100, 21)
        Me.Label4.TabIndex = 172
        Me.Label4.Text = "Date"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtDate
        '
        Me.txtDate.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDate.Location = New System.Drawing.Point(172, 412)
        Me.txtDate.Multiline = True
        Me.txtDate.Name = "txtDate"
        Me.txtDate.ReadOnly = True
        Me.txtDate.Size = New System.Drawing.Size(121, 27)
        Me.txtDate.TabIndex = 171
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(66, 308)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 21)
        Me.Label1.TabIndex = 170
        Me.Label1.Text = "MSR Number"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtMSRNumber
        '
        Me.txtMSRNumber.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtMSRNumber.Location = New System.Drawing.Point(172, 308)
        Me.txtMSRNumber.Multiline = True
        Me.txtMSRNumber.Name = "txtMSRNumber"
        Me.txtMSRNumber.ReadOnly = True
        Me.txtMSRNumber.Size = New System.Drawing.Size(121, 27)
        Me.txtMSRNumber.TabIndex = 169
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(66, 445)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(100, 21)
        Me.Label9.TabIndex = 168
        Me.Label9.Text = "Qty"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label10
        '
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(66, 341)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(100, 21)
        Me.Label10.TabIndex = 167
        Me.Label10.Text = "Part Number"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtPartNumber
        '
        Me.txtPartNumber.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtPartNumber.Location = New System.Drawing.Point(172, 341)
        Me.txtPartNumber.Multiline = True
        Me.txtPartNumber.Name = "txtPartNumber"
        Me.txtPartNumber.ReadOnly = True
        Me.txtPartNumber.Size = New System.Drawing.Size(121, 27)
        Me.txtPartNumber.TabIndex = 165
        '
        'cboTransactionID
        '
        Me.cboTransactionID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboTransactionID.FormattingEnabled = True
        Me.cboTransactionID.Location = New System.Drawing.Point(172, 241)
        Me.cboTransactionID.Name = "cboTransactionID"
        Me.cboTransactionID.Size = New System.Drawing.Size(121, 21)
        Me.cboTransactionID.TabIndex = 164
        '
        'txtQuantity
        '
        Me.txtQuantity.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtQuantity.Location = New System.Drawing.Point(172, 445)
        Me.txtQuantity.Name = "txtQuantity"
        Me.txtQuantity.ReadOnly = True
        Me.txtQuantity.Size = New System.Drawing.Size(121, 20)
        Me.txtQuantity.TabIndex = 166
        '
        'Label11
        '
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(12, 18)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(920, 46)
        Me.Label11.TabIndex = 180
        Me.Label11.Text = "Part Number Date Search"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(66, 122)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(100, 21)
        Me.Label6.TabIndex = 186
        Me.Label6.Text = "Start Date"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtEnterStartDate
        '
        Me.txtEnterStartDate.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtEnterStartDate.Location = New System.Drawing.Point(172, 122)
        Me.txtEnterStartDate.Multiline = True
        Me.txtEnterStartDate.Name = "txtEnterStartDate"
        Me.txtEnterStartDate.Size = New System.Drawing.Size(121, 27)
        Me.txtEnterStartDate.TabIndex = 0
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(66, 157)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(100, 21)
        Me.Label7.TabIndex = 184
        Me.Label7.Text = "End Date"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtEnterEndDate
        '
        Me.txtEnterEndDate.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtEnterEndDate.Location = New System.Drawing.Point(172, 157)
        Me.txtEnterEndDate.Multiline = True
        Me.txtEnterEndDate.Name = "txtEnterEndDate"
        Me.txtEnterEndDate.Size = New System.Drawing.Size(121, 27)
        Me.txtEnterEndDate.TabIndex = 1
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(66, 190)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(100, 21)
        Me.Label8.TabIndex = 182
        Me.Label8.Text = "Part Number"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtEnterPartNumber
        '
        Me.txtEnterPartNumber.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtEnterPartNumber.Location = New System.Drawing.Point(172, 190)
        Me.txtEnterPartNumber.Multiline = True
        Me.txtEnterPartNumber.Name = "txtEnterPartNumber"
        Me.txtEnterPartNumber.Size = New System.Drawing.Size(121, 27)
        Me.txtEnterPartNumber.TabIndex = 2
        '
        'Label12
        '
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(69, 64)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(224, 46)
        Me.Label12.TabIndex = 187
        Me.Label12.Text = "Enter Search Ctiteria"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnFindParts
        '
        Me.btnFindParts.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFindParts.Location = New System.Drawing.Point(344, 122)
        Me.btnFindParts.Name = "btnFindParts"
        Me.btnFindParts.Size = New System.Drawing.Size(152, 62)
        Me.btnFindParts.TabIndex = 3
        Me.btnFindParts.Text = "Find Parts"
        Me.btnFindParts.UseVisualStyleBackColor = True
        '
        'btnRunReport
        '
        Me.btnRunReport.Enabled = False
        Me.btnRunReport.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRunReport.Location = New System.Drawing.Point(344, 201)
        Me.btnRunReport.Name = "btnRunReport"
        Me.btnRunReport.Size = New System.Drawing.Size(152, 62)
        Me.btnRunReport.TabIndex = 4
        Me.btnRunReport.Text = "Run Report"
        Me.btnRunReport.UseVisualStyleBackColor = True
        '
        'PrintDocument1
        '
        '
        'PrintDialog1
        '
        Me.PrintDialog1.UseEXDialog = True
        '
        'dgvSearchResults
        '
        Me.dgvSearchResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvSearchResults.Location = New System.Drawing.Point(557, 122)
        Me.dgvSearchResults.Name = "dgvSearchResults"
        Me.dgvSearchResults.Size = New System.Drawing.Size(375, 418)
        Me.dgvSearchResults.TabIndex = 218
        '
        'PartNumberDateSearch
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(957, 574)
        Me.ControlBox = False
        Me.Controls.Add(Me.dgvSearchResults)
        Me.Controls.Add(Me.btnRunReport)
        Me.Controls.Add(Me.btnFindParts)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtEnterStartDate)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtEnterEndDate)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtEnterPartNumber)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtPartDescription)
        Me.Controls.Add(Me.cboPartNumber)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtProjectID)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtWarehouseID)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtDate)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtMSRNumber)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txtPartNumber)
        Me.Controls.Add(Me.cboTransactionID)
        Me.Controls.Add(Me.txtQuantity)
        Me.Controls.Add(Me.btnMainMenu)
        Me.Controls.Add(Me.btnReceiveMenu)
        Me.Controls.Add(Me.btnClose)
        Me.Name = "PartNumberDateSearch"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PartNumberDateSearch"
        CType(Me.dgvSearchResults, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnMainMenu As System.Windows.Forms.Button
    Friend WithEvents btnReceiveMenu As System.Windows.Forms.Button
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtPartDescription As System.Windows.Forms.TextBox
    Friend WithEvents cboPartNumber As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtProjectID As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtWarehouseID As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtDate As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtMSRNumber As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtPartNumber As System.Windows.Forms.TextBox
    Friend WithEvents cboTransactionID As System.Windows.Forms.ComboBox
    Friend WithEvents txtQuantity As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtEnterStartDate As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtEnterEndDate As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtEnterPartNumber As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents btnFindParts As System.Windows.Forms.Button
    Friend WithEvents btnRunReport As System.Windows.Forms.Button
    Friend WithEvents PrintDocument1 As System.Drawing.Printing.PrintDocument
    Friend WithEvents PrintDialog1 As System.Windows.Forms.PrintDialog
    Friend WithEvents dgvSearchResults As System.Windows.Forms.DataGridView
End Class
