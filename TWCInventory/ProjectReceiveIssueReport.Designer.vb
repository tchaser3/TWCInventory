<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ProjectReceiveIssueReport
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
        Me.btnProjectMenu = New System.Windows.Forms.Button()
        Me.btnMainMenu = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnRunReport = New System.Windows.Forms.Button()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtProjectName = New System.Windows.Forms.TextBox()
        Me.btnProjectFind = New System.Windows.Forms.Button()
        Me.txtFindProject = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtProjectTWCID = New System.Windows.Forms.TextBox()
        Me.cboProjectTransactionID = New System.Windows.Forms.ComboBox()
        Me.btnProjectNext = New System.Windows.Forms.Button()
        Me.btnProjectBack = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtTransactionInternalProjectID = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtTransactionProjectID = New System.Windows.Forms.TextBox()
        Me.cboTransactionID = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtTransactionDate = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtTransactionPartNumber = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtTransactionQTY = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.btnPartNext = New System.Windows.Forms.Button()
        Me.btnPartBack = New System.Windows.Forms.Button()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtPartDescription = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtPartNumber = New System.Windows.Forms.TextBox()
        Me.cboPartID = New System.Windows.Forms.ComboBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txtInternalProjectID = New System.Windows.Forms.TextBox()
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.SuspendLayout()
        '
        'btnProjectMenu
        '
        Me.btnProjectMenu.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnProjectMenu.Location = New System.Drawing.Point(580, 200)
        Me.btnProjectMenu.Name = "btnProjectMenu"
        Me.btnProjectMenu.Size = New System.Drawing.Size(181, 63)
        Me.btnProjectMenu.TabIndex = 9
        Me.btnProjectMenu.Text = "Project Menu"
        Me.btnProjectMenu.UseVisualStyleBackColor = True
        '
        'btnMainMenu
        '
        Me.btnMainMenu.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMainMenu.Location = New System.Drawing.Point(580, 269)
        Me.btnMainMenu.Name = "btnMainMenu"
        Me.btnMainMenu.Size = New System.Drawing.Size(181, 63)
        Me.btnMainMenu.TabIndex = 10
        Me.btnMainMenu.Text = "Main Menu"
        Me.btnMainMenu.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.Location = New System.Drawing.Point(580, 336)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(181, 63)
        Me.btnClose.TabIndex = 11
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'btnRunReport
        '
        Me.btnRunReport.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRunReport.Location = New System.Drawing.Point(580, 131)
        Me.btnRunReport.Name = "btnRunReport"
        Me.btnRunReport.Size = New System.Drawing.Size(181, 63)
        Me.btnRunReport.TabIndex = 8
        Me.btnRunReport.Text = "Run Report"
        Me.btnRunReport.UseVisualStyleBackColor = True
        '
        'lblTitle
        '
        Me.lblTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(12, 9)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(749, 55)
        Me.lblTitle.TabIndex = 28
        Me.lblTitle.Text = "Create\View Projects"
        Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(24, 243)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(100, 21)
        Me.Label4.TabIndex = 45
        Me.Label4.Text = "Project Name"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtProjectName
        '
        Me.txtProjectName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtProjectName.Location = New System.Drawing.Point(130, 205)
        Me.txtProjectName.Multiline = True
        Me.txtProjectName.Name = "txtProjectName"
        Me.txtProjectName.ReadOnly = True
        Me.txtProjectName.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal
        Me.txtProjectName.Size = New System.Drawing.Size(121, 98)
        Me.txtProjectName.TabIndex = 38
        '
        'btnProjectFind
        '
        Me.btnProjectFind.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnProjectFind.Location = New System.Drawing.Point(72, 425)
        Me.btnProjectFind.Name = "btnProjectFind"
        Me.btnProjectFind.Size = New System.Drawing.Size(121, 47)
        Me.btnProjectFind.TabIndex = 40
        Me.btnProjectFind.Text = "Find"
        Me.btnProjectFind.UseVisualStyleBackColor = True
        '
        'txtFindProject
        '
        Me.txtFindProject.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtFindProject.Location = New System.Drawing.Point(27, 389)
        Me.txtFindProject.Name = "txtFindProject"
        Me.txtFindProject.Size = New System.Drawing.Size(219, 20)
        Me.txtFindProject.TabIndex = 39
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(22, 342)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(224, 42)
        Me.Label3.TabIndex = 44
        Me.Label3.Text = "Find Project"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(24, 179)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 21)
        Me.Label2.TabIndex = 43
        Me.Label2.Text = "Project ID"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtProjectTWCID
        '
        Me.txtProjectTWCID.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtProjectTWCID.Location = New System.Drawing.Point(130, 179)
        Me.txtProjectTWCID.Name = "txtProjectTWCID"
        Me.txtProjectTWCID.ReadOnly = True
        Me.txtProjectTWCID.Size = New System.Drawing.Size(121, 20)
        Me.txtProjectTWCID.TabIndex = 37
        '
        'cboProjectTransactionID
        '
        Me.cboProjectTransactionID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboProjectTransactionID.FormattingEnabled = True
        Me.cboProjectTransactionID.Location = New System.Drawing.Point(130, 128)
        Me.cboProjectTransactionID.Name = "cboProjectTransactionID"
        Me.cboProjectTransactionID.Size = New System.Drawing.Size(121, 21)
        Me.cboProjectTransactionID.TabIndex = 41
        Me.cboProjectTransactionID.Visible = False
        '
        'btnProjectNext
        '
        Me.btnProjectNext.Enabled = False
        Me.btnProjectNext.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnProjectNext.Location = New System.Drawing.Point(152, 500)
        Me.btnProjectNext.Name = "btnProjectNext"
        Me.btnProjectNext.Size = New System.Drawing.Size(75, 23)
        Me.btnProjectNext.TabIndex = 47
        Me.btnProjectNext.Text = "Next"
        Me.btnProjectNext.UseVisualStyleBackColor = True
        '
        'btnProjectBack
        '
        Me.btnProjectBack.Enabled = False
        Me.btnProjectBack.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnProjectBack.Location = New System.Drawing.Point(27, 500)
        Me.btnProjectBack.Name = "btnProjectBack"
        Me.btnProjectBack.Size = New System.Drawing.Size(75, 23)
        Me.btnProjectBack.TabIndex = 46
        Me.btnProjectBack.Text = "Back"
        Me.btnProjectBack.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(299, 218)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 21)
        Me.Label1.TabIndex = 53
        Me.Label1.Text = "Internal ID"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtTransactionInternalProjectID
        '
        Me.txtTransactionInternalProjectID.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtTransactionInternalProjectID.Location = New System.Drawing.Point(405, 214)
        Me.txtTransactionInternalProjectID.Multiline = True
        Me.txtTransactionInternalProjectID.Name = "txtTransactionInternalProjectID"
        Me.txtTransactionInternalProjectID.ReadOnly = True
        Me.txtTransactionInternalProjectID.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal
        Me.txtTransactionInternalProjectID.Size = New System.Drawing.Size(121, 25)
        Me.txtTransactionInternalProjectID.TabIndex = 49
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(299, 188)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(100, 21)
        Me.Label6.TabIndex = 52
        Me.Label6.Text = "Project ID"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtTransactionProjectID
        '
        Me.txtTransactionProjectID.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtTransactionProjectID.Location = New System.Drawing.Point(405, 188)
        Me.txtTransactionProjectID.Name = "txtTransactionProjectID"
        Me.txtTransactionProjectID.ReadOnly = True
        Me.txtTransactionProjectID.Size = New System.Drawing.Size(121, 20)
        Me.txtTransactionProjectID.TabIndex = 48
        '
        'cboTransactionID
        '
        Me.cboTransactionID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboTransactionID.FormattingEnabled = True
        Me.cboTransactionID.Location = New System.Drawing.Point(405, 160)
        Me.cboTransactionID.Name = "cboTransactionID"
        Me.cboTransactionID.Size = New System.Drawing.Size(121, 21)
        Me.cboTransactionID.TabIndex = 50
        Me.cboTransactionID.Visible = False
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(299, 245)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(100, 21)
        Me.Label8.TabIndex = 55
        Me.Label8.Text = "Date"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtTransactionDate
        '
        Me.txtTransactionDate.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtTransactionDate.Location = New System.Drawing.Point(405, 245)
        Me.txtTransactionDate.Name = "txtTransactionDate"
        Me.txtTransactionDate.ReadOnly = True
        Me.txtTransactionDate.Size = New System.Drawing.Size(121, 20)
        Me.txtTransactionDate.TabIndex = 54
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(299, 271)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(100, 21)
        Me.Label9.TabIndex = 57
        Me.Label9.Text = "Part Number"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtTransactionPartNumber
        '
        Me.txtTransactionPartNumber.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtTransactionPartNumber.Location = New System.Drawing.Point(405, 271)
        Me.txtTransactionPartNumber.Name = "txtTransactionPartNumber"
        Me.txtTransactionPartNumber.ReadOnly = True
        Me.txtTransactionPartNumber.Size = New System.Drawing.Size(121, 20)
        Me.txtTransactionPartNumber.TabIndex = 56
        '
        'Label10
        '
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(299, 297)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(100, 21)
        Me.Label10.TabIndex = 59
        Me.Label10.Text = "Quantity"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtTransactionQTY
        '
        Me.txtTransactionQTY.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtTransactionQTY.Location = New System.Drawing.Point(405, 297)
        Me.txtTransactionQTY.Name = "txtTransactionQTY"
        Me.txtTransactionQTY.ReadOnly = True
        Me.txtTransactionQTY.Size = New System.Drawing.Size(121, 20)
        Me.txtTransactionQTY.TabIndex = 58
        '
        'Label11
        '
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(302, 84)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(224, 73)
        Me.Label11.TabIndex = 60
        Me.Label11.Text = "Project Part Transaction"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label12
        '
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(27, 74)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(224, 42)
        Me.Label12.TabIndex = 61
        Me.Label12.Text = "Project Information"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnPartNext
        '
        Me.btnPartNext.Enabled = False
        Me.btnPartNext.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPartNext.Location = New System.Drawing.Point(451, 323)
        Me.btnPartNext.Name = "btnPartNext"
        Me.btnPartNext.Size = New System.Drawing.Size(75, 23)
        Me.btnPartNext.TabIndex = 63
        Me.btnPartNext.Text = "Next"
        Me.btnPartNext.UseVisualStyleBackColor = True
        '
        'btnPartBack
        '
        Me.btnPartBack.Enabled = False
        Me.btnPartBack.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPartBack.Location = New System.Drawing.Point(307, 323)
        Me.btnPartBack.Name = "btnPartBack"
        Me.btnPartBack.Size = New System.Drawing.Size(75, 23)
        Me.btnPartBack.TabIndex = 62
        Me.btnPartBack.Text = "Back"
        Me.btnPartBack.UseVisualStyleBackColor = True
        '
        'Label13
        '
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(311, 376)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(224, 73)
        Me.Label13.TabIndex = 70
        Me.Label13.Text = "Project Part Transaction"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label14
        '
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(299, 517)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(100, 38)
        Me.Label14.TabIndex = 69
        Me.Label14.Text = "Part Description"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtPartDescription
        '
        Me.txtPartDescription.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtPartDescription.Location = New System.Drawing.Point(405, 506)
        Me.txtPartDescription.Multiline = True
        Me.txtPartDescription.Name = "txtPartDescription"
        Me.txtPartDescription.ReadOnly = True
        Me.txtPartDescription.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal
        Me.txtPartDescription.Size = New System.Drawing.Size(121, 58)
        Me.txtPartDescription.TabIndex = 65
        '
        'Label15
        '
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(299, 480)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(100, 21)
        Me.Label15.TabIndex = 68
        Me.Label15.Text = "Part Number"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtPartNumber
        '
        Me.txtPartNumber.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtPartNumber.Location = New System.Drawing.Point(405, 480)
        Me.txtPartNumber.Name = "txtPartNumber"
        Me.txtPartNumber.ReadOnly = True
        Me.txtPartNumber.Size = New System.Drawing.Size(121, 20)
        Me.txtPartNumber.TabIndex = 64
        '
        'cboPartID
        '
        Me.cboPartID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboPartID.FormattingEnabled = True
        Me.cboPartID.Location = New System.Drawing.Point(405, 453)
        Me.cboPartID.Name = "cboPartID"
        Me.cboPartID.Size = New System.Drawing.Size(121, 21)
        Me.cboPartID.TabIndex = 66
        Me.cboPartID.Visible = False
        '
        'Label17
        '
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(12, 155)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(112, 21)
        Me.Label17.TabIndex = 72
        Me.Label17.Text = "Internal ID"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtInternalProjectID
        '
        Me.txtInternalProjectID.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtInternalProjectID.Location = New System.Drawing.Point(130, 155)
        Me.txtInternalProjectID.Name = "txtInternalProjectID"
        Me.txtInternalProjectID.ReadOnly = True
        Me.txtInternalProjectID.Size = New System.Drawing.Size(121, 20)
        Me.txtInternalProjectID.TabIndex = 71
        '
        'PrintDialog1
        '
        Me.PrintDialog1.UseEXDialog = True
        '
        'PrintDocument1
        '
        '
        'ProjectReceiveIssueReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(777, 576)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.txtInternalProjectID)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.txtPartDescription)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.txtPartNumber)
        Me.Controls.Add(Me.cboPartID)
        Me.Controls.Add(Me.btnPartNext)
        Me.Controls.Add(Me.btnPartBack)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txtTransactionQTY)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtTransactionPartNumber)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtTransactionDate)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtTransactionInternalProjectID)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtTransactionProjectID)
        Me.Controls.Add(Me.cboTransactionID)
        Me.Controls.Add(Me.btnProjectNext)
        Me.Controls.Add(Me.btnProjectBack)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtProjectName)
        Me.Controls.Add(Me.btnProjectFind)
        Me.Controls.Add(Me.txtFindProject)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtProjectTWCID)
        Me.Controls.Add(Me.cboProjectTransactionID)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.btnProjectMenu)
        Me.Controls.Add(Me.btnMainMenu)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnRunReport)
        Me.Name = "ProjectReceiveIssueReport"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ProjectReceiveIssueReport"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnProjectMenu As System.Windows.Forms.Button
    Friend WithEvents btnMainMenu As System.Windows.Forms.Button
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents btnRunReport As System.Windows.Forms.Button
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtProjectName As System.Windows.Forms.TextBox
    Friend WithEvents btnProjectFind As System.Windows.Forms.Button
    Friend WithEvents txtFindProject As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtProjectTWCID As System.Windows.Forms.TextBox
    Friend WithEvents cboProjectTransactionID As System.Windows.Forms.ComboBox
    Friend WithEvents btnProjectNext As System.Windows.Forms.Button
    Friend WithEvents btnProjectBack As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtTransactionInternalProjectID As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtTransactionProjectID As System.Windows.Forms.TextBox
    Friend WithEvents cboTransactionID As System.Windows.Forms.ComboBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtTransactionDate As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtTransactionPartNumber As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtTransactionQTY As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents btnPartNext As System.Windows.Forms.Button
    Friend WithEvents btnPartBack As System.Windows.Forms.Button
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txtPartDescription As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents txtPartNumber As System.Windows.Forms.TextBox
    Friend WithEvents cboPartID As System.Windows.Forms.ComboBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents txtInternalProjectID As System.Windows.Forms.TextBox
    Friend WithEvents PrintDialog1 As System.Windows.Forms.PrintDialog
    Friend WithEvents PrintDocument1 As System.Drawing.Printing.PrintDocument
End Class
