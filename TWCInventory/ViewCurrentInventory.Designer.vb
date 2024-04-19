<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ViewCurrentInventory
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
        Me.cboPartNumber = New System.Windows.Forms.ComboBox()
        Me.txtPartID = New System.Windows.Forms.TextBox()
        Me.txtPartDescription = New System.Windows.Forms.TextBox()
        Me.txtQTYResponible = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtEnterPartNumber = New System.Windows.Forms.TextBox()
        Me.btnFindPartNumber = New System.Windows.Forms.Button()
        Me.btnOnHandReport = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnKeyWordSearch = New System.Windows.Forms.Button()
        Me.txtKeyWordSearch = New System.Windows.Forms.TextBox()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.btnResetForm = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnClose
        '
        Me.btnClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.Location = New System.Drawing.Point(294, 341)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(148, 63)
        Me.btnClose.TabIndex = 3
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'btnMainMenu
        '
        Me.btnMainMenu.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMainMenu.Location = New System.Drawing.Point(294, 273)
        Me.btnMainMenu.Name = "btnMainMenu"
        Me.btnMainMenu.Size = New System.Drawing.Size(148, 63)
        Me.btnMainMenu.TabIndex = 2
        Me.btnMainMenu.Text = "Main Menu"
        Me.btnMainMenu.UseVisualStyleBackColor = True
        '
        'cboPartNumber
        '
        Me.cboPartNumber.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboPartNumber.FormattingEnabled = True
        Me.cboPartNumber.Location = New System.Drawing.Point(138, 96)
        Me.cboPartNumber.Name = "cboPartNumber"
        Me.cboPartNumber.Size = New System.Drawing.Size(121, 21)
        Me.cboPartNumber.TabIndex = 4
        '
        'txtPartID
        '
        Me.txtPartID.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtPartID.Location = New System.Drawing.Point(138, 124)
        Me.txtPartID.Name = "txtPartID"
        Me.txtPartID.ReadOnly = True
        Me.txtPartID.Size = New System.Drawing.Size(121, 20)
        Me.txtPartID.TabIndex = 5
        '
        'txtPartDescription
        '
        Me.txtPartDescription.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtPartDescription.Location = New System.Drawing.Point(138, 150)
        Me.txtPartDescription.Multiline = True
        Me.txtPartDescription.Name = "txtPartDescription"
        Me.txtPartDescription.ReadOnly = True
        Me.txtPartDescription.Size = New System.Drawing.Size(121, 82)
        Me.txtPartDescription.TabIndex = 6
        '
        'txtQTYResponible
        '
        Me.txtQTYResponible.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtQTYResponible.Location = New System.Drawing.Point(138, 238)
        Me.txtQTYResponible.Name = "txtQTYResponible"
        Me.txtQTYResponible.ReadOnly = True
        Me.txtQTYResponible.Size = New System.Drawing.Size(121, 20)
        Me.txtQTYResponible.TabIndex = 7
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(32, 95)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 21)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Part Number"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(32, 124)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 21)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Part ID"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(32, 175)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(100, 21)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Description"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(32, 237)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(100, 21)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Qty On Hand"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(12, 9)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(642, 43)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "View On Hand Inventory"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(476, 81)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(171, 50)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Find A Part Number"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtEnterPartNumber
        '
        Me.txtEnterPartNumber.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtEnterPartNumber.Location = New System.Drawing.Point(481, 150)
        Me.txtEnterPartNumber.Name = "txtEnterPartNumber"
        Me.txtEnterPartNumber.Size = New System.Drawing.Size(166, 20)
        Me.txtEnterPartNumber.TabIndex = 4
        '
        'btnFindPartNumber
        '
        Me.btnFindPartNumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFindPartNumber.Location = New System.Drawing.Point(494, 180)
        Me.btnFindPartNumber.Name = "btnFindPartNumber"
        Me.btnFindPartNumber.Size = New System.Drawing.Size(141, 52)
        Me.btnFindPartNumber.TabIndex = 5
        Me.btnFindPartNumber.Text = "Find Part Number"
        Me.btnFindPartNumber.UseVisualStyleBackColor = True
        '
        'btnOnHandReport
        '
        Me.btnOnHandReport.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOnHandReport.Location = New System.Drawing.Point(294, 138)
        Me.btnOnHandReport.Name = "btnOnHandReport"
        Me.btnOnHandReport.Size = New System.Drawing.Size(148, 63)
        Me.btnOnHandReport.TabIndex = 1
        Me.btnOnHandReport.Text = "On Hand Report"
        Me.btnOnHandReport.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.Location = New System.Drawing.Point(294, 71)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(148, 63)
        Me.btnAdd.TabIndex = 0
        Me.btnAdd.Text = "Add Part Number"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnKeyWordSearch
        '
        Me.btnKeyWordSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnKeyWordSearch.Location = New System.Drawing.Point(494, 303)
        Me.btnKeyWordSearch.Name = "btnKeyWordSearch"
        Me.btnKeyWordSearch.Size = New System.Drawing.Size(141, 52)
        Me.btnKeyWordSearch.TabIndex = 7
        Me.btnKeyWordSearch.Text = "Key Word Search"
        Me.btnKeyWordSearch.UseVisualStyleBackColor = True
        '
        'txtKeyWordSearch
        '
        Me.txtKeyWordSearch.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtKeyWordSearch.Location = New System.Drawing.Point(481, 273)
        Me.txtKeyWordSearch.Name = "txtKeyWordSearch"
        Me.txtKeyWordSearch.Size = New System.Drawing.Size(166, 20)
        Me.txtKeyWordSearch.TabIndex = 6
        '
        'btnNext
        '
        Me.btnNext.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNext.Location = New System.Drawing.Point(184, 284)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(75, 23)
        Me.btnNext.TabIndex = 14
        Me.btnNext.Text = "Next"
        Me.btnNext.UseVisualStyleBackColor = True
        '
        'btnBack
        '
        Me.btnBack.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.Location = New System.Drawing.Point(57, 284)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(75, 23)
        Me.btnBack.TabIndex = 15
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'btnResetForm
        '
        Me.btnResetForm.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnResetForm.Location = New System.Drawing.Point(294, 207)
        Me.btnResetForm.Name = "btnResetForm"
        Me.btnResetForm.Size = New System.Drawing.Size(148, 63)
        Me.btnResetForm.TabIndex = 16
        Me.btnResetForm.Text = "Reset Form"
        Me.btnResetForm.UseVisualStyleBackColor = True
        '
        'ViewCurrentInventory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(666, 415)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnResetForm)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.btnKeyWordSearch)
        Me.Controls.Add(Me.txtKeyWordSearch)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.btnOnHandReport)
        Me.Controls.Add(Me.btnFindPartNumber)
        Me.Controls.Add(Me.txtEnterPartNumber)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtQTYResponible)
        Me.Controls.Add(Me.txtPartDescription)
        Me.Controls.Add(Me.txtPartID)
        Me.Controls.Add(Me.cboPartNumber)
        Me.Controls.Add(Me.btnMainMenu)
        Me.Controls.Add(Me.btnClose)
        Me.Name = "ViewCurrentInventory"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ViewOnHandInventory"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents btnMainMenu As System.Windows.Forms.Button
    Friend WithEvents cboPartNumber As System.Windows.Forms.ComboBox
    Friend WithEvents txtPartID As System.Windows.Forms.TextBox
    Friend WithEvents txtPartDescription As System.Windows.Forms.TextBox
    Friend WithEvents txtQTYResponible As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtEnterPartNumber As System.Windows.Forms.TextBox
    Friend WithEvents btnFindPartNumber As System.Windows.Forms.Button
    Friend WithEvents btnOnHandReport As System.Windows.Forms.Button
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents btnKeyWordSearch As System.Windows.Forms.Button
    Friend WithEvents txtKeyWordSearch As System.Windows.Forms.TextBox
    Friend WithEvents btnNext As System.Windows.Forms.Button
    Friend WithEvents btnBack As System.Windows.Forms.Button
    Friend WithEvents btnResetForm As System.Windows.Forms.Button
End Class
