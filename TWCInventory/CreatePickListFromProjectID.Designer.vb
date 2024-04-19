<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CreatePickListFromProjectID
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
        Me.PartsReceivedGridView = New System.Windows.Forms.DataGridView()
        Me.txtReceivePartNumber = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtReceiveQuantity = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtReceiveTWCProjectID = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtReceiveMSRNumber = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cboReceiveTransactionID = New System.Windows.Forms.ComboBox()
        Me.txtEnterProjectID = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnFindMSRNumber = New System.Windows.Forms.Button()
        Me.btnProcess = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnMainMenu = New System.Windows.Forms.Button()
        Me.btnCreatePickListMenu = New System.Windows.Forms.Button()
        Me.btnIssueInventoryMenu = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        CType(Me.PartsReceivedGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PartsReceivedGridView
        '
        Me.PartsReceivedGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.PartsReceivedGridView.Location = New System.Drawing.Point(23, 378)
        Me.PartsReceivedGridView.Margin = New System.Windows.Forms.Padding(4)
        Me.PartsReceivedGridView.Name = "PartsReceivedGridView"
        Me.PartsReceivedGridView.Size = New System.Drawing.Size(536, 326)
        Me.PartsReceivedGridView.TabIndex = 61
        '
        'txtReceivePartNumber
        '
        Me.txtReceivePartNumber.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtReceivePartNumber.Location = New System.Drawing.Point(260, 252)
        Me.txtReceivePartNumber.Margin = New System.Windows.Forms.Padding(4)
        Me.txtReceivePartNumber.Name = "txtReceivePartNumber"
        Me.txtReceivePartNumber.ReadOnly = True
        Me.txtReceivePartNumber.Size = New System.Drawing.Size(160, 22)
        Me.txtReceivePartNumber.TabIndex = 60
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(24, 249)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(213, 28)
        Me.Label7.TabIndex = 59
        Me.Label7.Text = "Part Number"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtReceiveQuantity
        '
        Me.txtReceiveQuantity.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtReceiveQuantity.Location = New System.Drawing.Point(260, 318)
        Me.txtReceiveQuantity.Margin = New System.Windows.Forms.Padding(4)
        Me.txtReceiveQuantity.Name = "txtReceiveQuantity"
        Me.txtReceiveQuantity.ReadOnly = True
        Me.txtReceiveQuantity.Size = New System.Drawing.Size(160, 22)
        Me.txtReceiveQuantity.TabIndex = 58
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(24, 316)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(213, 28)
        Me.Label6.TabIndex = 57
        Me.Label6.Text = "Quantity"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtReceiveTWCProjectID
        '
        Me.txtReceiveTWCProjectID.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtReceiveTWCProjectID.Location = New System.Drawing.Point(260, 286)
        Me.txtReceiveTWCProjectID.Margin = New System.Windows.Forms.Padding(4)
        Me.txtReceiveTWCProjectID.Name = "txtReceiveTWCProjectID"
        Me.txtReceiveTWCProjectID.ReadOnly = True
        Me.txtReceiveTWCProjectID.Size = New System.Drawing.Size(160, 22)
        Me.txtReceiveTWCProjectID.TabIndex = 56
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(24, 284)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(213, 28)
        Me.Label5.TabIndex = 55
        Me.Label5.Text = "TWC Project ID"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtReceiveMSRNumber
        '
        Me.txtReceiveMSRNumber.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtReceiveMSRNumber.Location = New System.Drawing.Point(260, 220)
        Me.txtReceiveMSRNumber.Margin = New System.Windows.Forms.Padding(4)
        Me.txtReceiveMSRNumber.Name = "txtReceiveMSRNumber"
        Me.txtReceiveMSRNumber.ReadOnly = True
        Me.txtReceiveMSRNumber.Size = New System.Drawing.Size(160, 22)
        Me.txtReceiveMSRNumber.TabIndex = 54
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(24, 217)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(213, 28)
        Me.Label4.TabIndex = 53
        Me.Label4.Text = "MSR Number"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(24, 186)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(213, 28)
        Me.Label3.TabIndex = 52
        Me.Label3.Text = "Transaction ID"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cboReceiveTransactionID
        '
        Me.cboReceiveTransactionID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboReceiveTransactionID.FormattingEnabled = True
        Me.cboReceiveTransactionID.Location = New System.Drawing.Point(260, 186)
        Me.cboReceiveTransactionID.Margin = New System.Windows.Forms.Padding(4)
        Me.cboReceiveTransactionID.Name = "cboReceiveTransactionID"
        Me.cboReceiveTransactionID.Size = New System.Drawing.Size(160, 24)
        Me.cboReceiveTransactionID.TabIndex = 51
        '
        'txtEnterProjectID
        '
        Me.txtEnterProjectID.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtEnterProjectID.Location = New System.Drawing.Point(326, 111)
        Me.txtEnterProjectID.Margin = New System.Windows.Forms.Padding(4)
        Me.txtEnterProjectID.Name = "txtEnterProjectID"
        Me.txtEnterProjectID.Size = New System.Drawing.Size(132, 22)
        Me.txtEnterProjectID.TabIndex = 50
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(90, 109)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(213, 28)
        Me.Label2.TabIndex = 49
        Me.Label2.Text = "Enter Project ID"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnFindMSRNumber
        '
        Me.btnFindMSRNumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFindMSRNumber.Location = New System.Drawing.Point(480, 103)
        Me.btnFindMSRNumber.Margin = New System.Windows.Forms.Padding(4)
        Me.btnFindMSRNumber.Name = "btnFindMSRNumber"
        Me.btnFindMSRNumber.Size = New System.Drawing.Size(147, 41)
        Me.btnFindMSRNumber.TabIndex = 48
        Me.btnFindMSRNumber.Text = "Find Project ID"
        Me.btnFindMSRNumber.UseVisualStyleBackColor = True
        '
        'btnProcess
        '
        Me.btnProcess.Enabled = False
        Me.btnProcess.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnProcess.Location = New System.Drawing.Point(598, 291)
        Me.btnProcess.Margin = New System.Windows.Forms.Padding(4)
        Me.btnProcess.Name = "btnProcess"
        Me.btnProcess.Size = New System.Drawing.Size(162, 76)
        Me.btnProcess.TabIndex = 47
        Me.btnProcess.Text = "Process"
        Me.btnProcess.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(16, 11)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(754, 43)
        Me.Label1.TabIndex = 46
        Me.Label1.Text = "Create Pick List From Project ID"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnMainMenu
        '
        Me.btnMainMenu.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMainMenu.Location = New System.Drawing.Point(598, 544)
        Me.btnMainMenu.Margin = New System.Windows.Forms.Padding(4)
        Me.btnMainMenu.Name = "btnMainMenu"
        Me.btnMainMenu.Size = New System.Drawing.Size(162, 76)
        Me.btnMainMenu.TabIndex = 45
        Me.btnMainMenu.Text = "Main Menu"
        Me.btnMainMenu.UseVisualStyleBackColor = True
        '
        'btnCreatePickListMenu
        '
        Me.btnCreatePickListMenu.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCreatePickListMenu.Location = New System.Drawing.Point(598, 375)
        Me.btnCreatePickListMenu.Margin = New System.Windows.Forms.Padding(4)
        Me.btnCreatePickListMenu.Name = "btnCreatePickListMenu"
        Me.btnCreatePickListMenu.Size = New System.Drawing.Size(162, 76)
        Me.btnCreatePickListMenu.TabIndex = 44
        Me.btnCreatePickListMenu.Text = "Create Pick List Menu"
        Me.btnCreatePickListMenu.UseVisualStyleBackColor = True
        '
        'btnIssueInventoryMenu
        '
        Me.btnIssueInventoryMenu.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnIssueInventoryMenu.Location = New System.Drawing.Point(598, 459)
        Me.btnIssueInventoryMenu.Margin = New System.Windows.Forms.Padding(4)
        Me.btnIssueInventoryMenu.Name = "btnIssueInventoryMenu"
        Me.btnIssueInventoryMenu.Size = New System.Drawing.Size(162, 76)
        Me.btnIssueInventoryMenu.TabIndex = 43
        Me.btnIssueInventoryMenu.Text = "Issue Inventory Menu"
        Me.btnIssueInventoryMenu.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.Location = New System.Drawing.Point(598, 627)
        Me.btnClose.Margin = New System.Windows.Forms.Padding(4)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(162, 76)
        Me.btnClose.TabIndex = 42
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'CreatePickListFromProjectID
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(802, 731)
        Me.ControlBox = False
        Me.Controls.Add(Me.PartsReceivedGridView)
        Me.Controls.Add(Me.txtReceivePartNumber)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtReceiveQuantity)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtReceiveTWCProjectID)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtReceiveMSRNumber)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cboReceiveTransactionID)
        Me.Controls.Add(Me.txtEnterProjectID)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnFindMSRNumber)
        Me.Controls.Add(Me.btnProcess)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnMainMenu)
        Me.Controls.Add(Me.btnCreatePickListMenu)
        Me.Controls.Add(Me.btnIssueInventoryMenu)
        Me.Controls.Add(Me.btnClose)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "CreatePickListFromProjectID"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CreatePickListFromProjectID"
        CType(Me.PartsReceivedGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PartsReceivedGridView As System.Windows.Forms.DataGridView
    Friend WithEvents txtReceivePartNumber As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtReceiveQuantity As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtReceiveTWCProjectID As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtReceiveMSRNumber As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cboReceiveTransactionID As System.Windows.Forms.ComboBox
    Friend WithEvents txtEnterProjectID As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnFindMSRNumber As System.Windows.Forms.Button
    Friend WithEvents btnProcess As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnMainMenu As System.Windows.Forms.Button
    Friend WithEvents btnCreatePickListMenu As System.Windows.Forms.Button
    Friend WithEvents btnIssueInventoryMenu As System.Windows.Forms.Button
    Friend WithEvents btnClose As System.Windows.Forms.Button
End Class
