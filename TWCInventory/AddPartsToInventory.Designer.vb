<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddPartsToInventory
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
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtTimeWarnerPart = New System.Windows.Forms.TextBox()
        Me.txtPartDescription = New System.Windows.Forms.TextBox()
        Me.txtPartNumber = New System.Windows.Forms.TextBox()
        Me.cboPartID = New System.Windows.Forms.ComboBox()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnAdministrationMenu = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnMainMenu = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtPrice = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtActive = New System.Windows.Forms.TextBox()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnPartNumberReport = New System.Windows.Forms.Button()
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.txtFindParts = New System.Windows.Forms.TextBox()
        Me.btnFindAllParts = New System.Windows.Forms.Button()
        Me.btnFindSpecificParts = New System.Windows.Forms.Button()
        Me.dgvSearchResults = New System.Windows.Forms.DataGridView()
        CType(Me.dgvSearchResults, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(80, 357)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(133, 26)
        Me.Label4.TabIndex = 19
        Me.Label4.Text = "TW Part"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(80, 281)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(133, 26)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = "Description"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(80, 218)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(133, 26)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "Part Number"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(80, 182)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(133, 26)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Part ID"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtTimeWarnerPart
        '
        Me.txtTimeWarnerPart.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtTimeWarnerPart.Location = New System.Drawing.Point(221, 358)
        Me.txtTimeWarnerPart.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtTimeWarnerPart.Name = "txtTimeWarnerPart"
        Me.txtTimeWarnerPart.ReadOnly = True
        Me.txtTimeWarnerPart.Size = New System.Drawing.Size(160, 22)
        Me.txtTimeWarnerPart.TabIndex = 3
        '
        'txtPartDescription
        '
        Me.txtPartDescription.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtPartDescription.Location = New System.Drawing.Point(221, 250)
        Me.txtPartDescription.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtPartDescription.Multiline = True
        Me.txtPartDescription.Name = "txtPartDescription"
        Me.txtPartDescription.Size = New System.Drawing.Size(160, 100)
        Me.txtPartDescription.TabIndex = 2
        '
        'txtPartNumber
        '
        Me.txtPartNumber.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtPartNumber.Location = New System.Drawing.Point(221, 218)
        Me.txtPartNumber.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtPartNumber.Name = "txtPartNumber"
        Me.txtPartNumber.Size = New System.Drawing.Size(160, 22)
        Me.txtPartNumber.TabIndex = 1
        '
        'cboPartID
        '
        Me.cboPartID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboPartID.FormattingEnabled = True
        Me.cboPartID.Location = New System.Drawing.Point(221, 184)
        Me.cboPartID.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cboPartID.Name = "cboPartID"
        Me.cboPartID.Size = New System.Drawing.Size(160, 24)
        Me.cboPartID.TabIndex = 0
        '
        'btnAdd
        '
        Me.btnAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.Location = New System.Drawing.Point(582, 131)
        Me.btnAdd.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(170, 77)
        Me.btnAdd.TabIndex = 6
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnAdministrationMenu
        '
        Me.btnAdministrationMenu.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdministrationMenu.Location = New System.Drawing.Point(582, 297)
        Me.btnAdministrationMenu.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnAdministrationMenu.Name = "btnAdministrationMenu"
        Me.btnAdministrationMenu.Size = New System.Drawing.Size(170, 77)
        Me.btnAdministrationMenu.TabIndex = 8
        Me.btnAdministrationMenu.Text = "Administration Menu"
        Me.btnAdministrationMenu.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(16, 11)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(620, 65)
        Me.Label5.TabIndex = 22
        Me.Label5.Text = "Add Part Number to Inventory"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnMainMenu
        '
        Me.btnMainMenu.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMainMenu.Location = New System.Drawing.Point(582, 382)
        Me.btnMainMenu.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnMainMenu.Name = "btnMainMenu"
        Me.btnMainMenu.Size = New System.Drawing.Size(170, 77)
        Me.btnMainMenu.TabIndex = 9
        Me.btnMainMenu.Text = "Main Menu"
        Me.btnMainMenu.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(80, 393)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(133, 26)
        Me.Label6.TabIndex = 25
        Me.Label6.Text = "Price"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtPrice
        '
        Me.txtPrice.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtPrice.Location = New System.Drawing.Point(221, 394)
        Me.txtPrice.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtPrice.Name = "txtPrice"
        Me.txtPrice.ReadOnly = True
        Me.txtPrice.Size = New System.Drawing.Size(160, 22)
        Me.txtPrice.TabIndex = 4
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(80, 425)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(133, 26)
        Me.Label7.TabIndex = 27
        Me.Label7.Text = "Active"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtActive
        '
        Me.txtActive.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtActive.Location = New System.Drawing.Point(221, 426)
        Me.txtActive.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtActive.Name = "txtActive"
        Me.txtActive.ReadOnly = True
        Me.txtActive.Size = New System.Drawing.Size(160, 22)
        Me.txtActive.TabIndex = 5
        '
        'btnClose
        '
        Me.btnClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.Location = New System.Drawing.Point(582, 467)
        Me.btnClose.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(170, 77)
        Me.btnClose.TabIndex = 10
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'btnPartNumberReport
        '
        Me.btnPartNumberReport.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPartNumberReport.Location = New System.Drawing.Point(582, 214)
        Me.btnPartNumberReport.Margin = New System.Windows.Forms.Padding(4)
        Me.btnPartNumberReport.Name = "btnPartNumberReport"
        Me.btnPartNumberReport.Size = New System.Drawing.Size(170, 77)
        Me.btnPartNumberReport.TabIndex = 7
        Me.btnPartNumberReport.Text = "Part Number Report"
        Me.btnPartNumberReport.UseVisualStyleBackColor = True
        '
        'PrintDialog1
        '
        Me.PrintDialog1.UseEXDialog = True
        '
        'PrintDocument1
        '
        '
        'txtFindParts
        '
        Me.txtFindParts.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtFindParts.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFindParts.Location = New System.Drawing.Point(40, 115)
        Me.txtFindParts.Name = "txtFindParts"
        Me.txtFindParts.Size = New System.Drawing.Size(153, 27)
        Me.txtFindParts.TabIndex = 244
        '
        'btnFindAllParts
        '
        Me.btnFindAllParts.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFindAllParts.Location = New System.Drawing.Point(396, 96)
        Me.btnFindAllParts.Name = "btnFindAllParts"
        Me.btnFindAllParts.Size = New System.Drawing.Size(153, 61)
        Me.btnFindAllParts.TabIndex = 243
        Me.btnFindAllParts.Text = "Find All Parts"
        Me.btnFindAllParts.UseVisualStyleBackColor = True
        '
        'btnFindSpecificParts
        '
        Me.btnFindSpecificParts.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFindSpecificParts.Location = New System.Drawing.Point(216, 96)
        Me.btnFindSpecificParts.Name = "btnFindSpecificParts"
        Me.btnFindSpecificParts.Size = New System.Drawing.Size(153, 61)
        Me.btnFindSpecificParts.TabIndex = 242
        Me.btnFindSpecificParts.Text = "Find Specific Parts"
        Me.btnFindSpecificParts.UseVisualStyleBackColor = True
        '
        'dgvSearchResults
        '
        Me.dgvSearchResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvSearchResults.Location = New System.Drawing.Point(10, 182)
        Me.dgvSearchResults.Margin = New System.Windows.Forms.Padding(4)
        Me.dgvSearchResults.Name = "dgvSearchResults"
        Me.dgvSearchResults.Size = New System.Drawing.Size(556, 360)
        Me.dgvSearchResults.TabIndex = 245
        '
        'AddPartsToInventory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(774, 555)
        Me.ControlBox = False
        Me.Controls.Add(Me.dgvSearchResults)
        Me.Controls.Add(Me.txtFindParts)
        Me.Controls.Add(Me.btnFindAllParts)
        Me.Controls.Add(Me.btnFindSpecificParts)
        Me.Controls.Add(Me.btnPartNumberReport)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtActive)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtPrice)
        Me.Controls.Add(Me.btnMainMenu)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.btnAdministrationMenu)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtTimeWarnerPart)
        Me.Controls.Add(Me.txtPartDescription)
        Me.Controls.Add(Me.txtPartNumber)
        Me.Controls.Add(Me.cboPartID)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "AddPartsToInventory"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AddPartsToInventory"
        CType(Me.dgvSearchResults, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtTimeWarnerPart As System.Windows.Forms.TextBox
    Friend WithEvents txtPartDescription As System.Windows.Forms.TextBox
    Friend WithEvents txtPartNumber As System.Windows.Forms.TextBox
    Friend WithEvents cboPartID As System.Windows.Forms.ComboBox
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents btnAdministrationMenu As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents btnMainMenu As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtPrice As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtActive As System.Windows.Forms.TextBox
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents btnPartNumberReport As System.Windows.Forms.Button
    Friend WithEvents PrintDialog1 As System.Windows.Forms.PrintDialog
    Friend WithEvents PrintDocument1 As System.Drawing.Printing.PrintDocument
    Friend WithEvents txtFindParts As System.Windows.Forms.TextBox
    Friend WithEvents btnFindAllParts As System.Windows.Forms.Button
    Friend WithEvents btnFindSpecificParts As System.Windows.Forms.Button
    Friend WithEvents dgvSearchResults As System.Windows.Forms.DataGridView
End Class
