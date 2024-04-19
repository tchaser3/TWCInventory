<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ViewLastTransaction
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
        Me.btnAdministrativeMenu = New System.Windows.Forms.Button()
        Me.cboTransactionID = New System.Windows.Forms.ComboBox()
        Me.txtEmployeeID = New System.Windows.Forms.TextBox()
        Me.txtDate = New System.Windows.Forms.TextBox()
        Me.txtLastTransactionSummary = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtNumberOfLastTransactions = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnFindTransaction = New System.Windows.Forms.Button()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnClose
        '
        Me.btnClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.Location = New System.Drawing.Point(384, 333)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(155, 67)
        Me.btnClose.TabIndex = 9
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'btnMainMenu
        '
        Me.btnMainMenu.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMainMenu.Location = New System.Drawing.Point(384, 260)
        Me.btnMainMenu.Name = "btnMainMenu"
        Me.btnMainMenu.Size = New System.Drawing.Size(155, 67)
        Me.btnMainMenu.TabIndex = 10
        Me.btnMainMenu.Text = "Main Menu"
        Me.btnMainMenu.UseVisualStyleBackColor = True
        '
        'btnAdministrativeMenu
        '
        Me.btnAdministrativeMenu.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdministrativeMenu.Location = New System.Drawing.Point(384, 187)
        Me.btnAdministrativeMenu.Name = "btnAdministrativeMenu"
        Me.btnAdministrativeMenu.Size = New System.Drawing.Size(155, 67)
        Me.btnAdministrativeMenu.TabIndex = 11
        Me.btnAdministrativeMenu.Text = "Administrative Menu"
        Me.btnAdministrativeMenu.UseVisualStyleBackColor = True
        '
        'cboTransactionID
        '
        Me.cboTransactionID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboTransactionID.FormattingEnabled = True
        Me.cboTransactionID.Location = New System.Drawing.Point(184, 205)
        Me.cboTransactionID.Name = "cboTransactionID"
        Me.cboTransactionID.Size = New System.Drawing.Size(155, 21)
        Me.cboTransactionID.TabIndex = 12
        Me.cboTransactionID.Visible = False
        '
        'txtEmployeeID
        '
        Me.txtEmployeeID.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtEmployeeID.Location = New System.Drawing.Point(184, 233)
        Me.txtEmployeeID.Name = "txtEmployeeID"
        Me.txtEmployeeID.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtEmployeeID.ReadOnly = True
        Me.txtEmployeeID.Size = New System.Drawing.Size(155, 20)
        Me.txtEmployeeID.TabIndex = 13
        '
        'txtDate
        '
        Me.txtDate.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDate.Location = New System.Drawing.Point(184, 260)
        Me.txtDate.Name = "txtDate"
        Me.txtDate.ReadOnly = True
        Me.txtDate.Size = New System.Drawing.Size(155, 20)
        Me.txtDate.TabIndex = 14
        '
        'txtLastTransactionSummary
        '
        Me.txtLastTransactionSummary.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtLastTransactionSummary.Location = New System.Drawing.Point(184, 287)
        Me.txtLastTransactionSummary.Multiline = True
        Me.txtLastTransactionSummary.Name = "txtLastTransactionSummary"
        Me.txtLastTransactionSummary.ReadOnly = True
        Me.txtLastTransactionSummary.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtLastTransactionSummary.Size = New System.Drawing.Size(155, 125)
        Me.txtLastTransactionSummary.TabIndex = 15
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(69, 230)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 23)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Employee ID"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(69, 260)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 23)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "Date"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(69, 320)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(100, 49)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = "Last Transaction Summary"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(12, 9)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(527, 55)
        Me.Label4.TabIndex = 19
        Me.Label4.Text = "Last Transactions For Current Employee"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtNumberOfLastTransactions
        '
        Me.txtNumberOfLastTransactions.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNumberOfLastTransactions.Location = New System.Drawing.Point(184, 106)
        Me.txtNumberOfLastTransactions.Name = "txtNumberOfLastTransactions"
        Me.txtNumberOfLastTransactions.Size = New System.Drawing.Size(155, 20)
        Me.txtNumberOfLastTransactions.TabIndex = 20
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(31, 99)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(138, 48)
        Me.Label5.TabIndex = 21
        Me.Label5.Text = "Enter The Number Of Last Transactions"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnFindTransaction
        '
        Me.btnFindTransaction.Location = New System.Drawing.Point(358, 102)
        Me.btnFindTransaction.Name = "btnFindTransaction"
        Me.btnFindTransaction.Size = New System.Drawing.Size(75, 23)
        Me.btnFindTransaction.TabIndex = 22
        Me.btnFindTransaction.Text = "Find Transactions"
        Me.btnFindTransaction.UseVisualStyleBackColor = True
        '
        'btnNext
        '
        Me.btnNext.Location = New System.Drawing.Point(263, 434)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(75, 23)
        Me.btnNext.TabIndex = 23
        Me.btnNext.Text = "Next"
        Me.btnNext.UseVisualStyleBackColor = True
        '
        'btnBack
        '
        Me.btnBack.Location = New System.Drawing.Point(129, 434)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(75, 23)
        Me.btnBack.TabIndex = 24
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'ViewLastTransaction
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(551, 471)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.btnFindTransaction)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtNumberOfLastTransactions)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtLastTransactionSummary)
        Me.Controls.Add(Me.txtDate)
        Me.Controls.Add(Me.txtEmployeeID)
        Me.Controls.Add(Me.cboTransactionID)
        Me.Controls.Add(Me.btnAdministrativeMenu)
        Me.Controls.Add(Me.btnMainMenu)
        Me.Controls.Add(Me.btnClose)
        Me.Name = "ViewLastTransaction"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ViewLastTransaction"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents btnMainMenu As System.Windows.Forms.Button
    Friend WithEvents btnAdministrativeMenu As System.Windows.Forms.Button
    Friend WithEvents cboTransactionID As System.Windows.Forms.ComboBox
    Friend WithEvents txtEmployeeID As System.Windows.Forms.TextBox
    Friend WithEvents txtDate As System.Windows.Forms.TextBox
    Friend WithEvents txtLastTransactionSummary As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtNumberOfLastTransactions As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents btnFindTransaction As System.Windows.Forms.Button
    Friend WithEvents btnNext As System.Windows.Forms.Button
    Friend WithEvents btnBack As System.Windows.Forms.Button
End Class
