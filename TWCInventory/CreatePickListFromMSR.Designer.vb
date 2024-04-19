<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CreatePickListFromMSR
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
        Me.btnIssueInventoryMenu = New System.Windows.Forms.Button()
        Me.btnCreatePickListMenu = New System.Windows.Forms.Button()
        Me.btnMainMenu = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnProcess = New System.Windows.Forms.Button()
        Me.btnFindMSRNumber = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtEnterMSRNumber = New System.Windows.Forms.TextBox()
        Me.cboReceiveTransactionID = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtReceiveMSRNumber = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtReceiveTWCProjectID = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtReceiveQuantity = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtReceivePartNumber = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.PartsReceivedGridView = New System.Windows.Forms.DataGridView()
        CType(Me.PartsReceivedGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnClose
        '
        Me.btnClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.Location = New System.Drawing.Point(581, 452)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(152, 62)
        Me.btnClose.TabIndex = 22
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'btnIssueInventoryMenu
        '
        Me.btnIssueInventoryMenu.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnIssueInventoryMenu.Location = New System.Drawing.Point(581, 315)
        Me.btnIssueInventoryMenu.Name = "btnIssueInventoryMenu"
        Me.btnIssueInventoryMenu.Size = New System.Drawing.Size(152, 62)
        Me.btnIssueInventoryMenu.TabIndex = 23
        Me.btnIssueInventoryMenu.Text = "Issue Inventory Menu"
        Me.btnIssueInventoryMenu.UseVisualStyleBackColor = True
        '
        'btnCreatePickListMenu
        '
        Me.btnCreatePickListMenu.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCreatePickListMenu.Location = New System.Drawing.Point(581, 247)
        Me.btnCreatePickListMenu.Name = "btnCreatePickListMenu"
        Me.btnCreatePickListMenu.Size = New System.Drawing.Size(152, 62)
        Me.btnCreatePickListMenu.TabIndex = 24
        Me.btnCreatePickListMenu.Text = "Create Pick List Menu"
        Me.btnCreatePickListMenu.UseVisualStyleBackColor = True
        '
        'btnMainMenu
        '
        Me.btnMainMenu.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMainMenu.Location = New System.Drawing.Point(581, 384)
        Me.btnMainMenu.Name = "btnMainMenu"
        Me.btnMainMenu.Size = New System.Drawing.Size(152, 62)
        Me.btnMainMenu.TabIndex = 25
        Me.btnMainMenu.Text = "Main Menu"
        Me.btnMainMenu.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(737, 35)
        Me.Label1.TabIndex = 26
        Me.Label1.Text = "Create Pick List From MSR"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnProcess
        '
        Me.btnProcess.Enabled = False
        Me.btnProcess.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnProcess.Location = New System.Drawing.Point(581, 179)
        Me.btnProcess.Name = "btnProcess"
        Me.btnProcess.Size = New System.Drawing.Size(152, 62)
        Me.btnProcess.TabIndex = 27
        Me.btnProcess.Text = "Process"
        Me.btnProcess.UseVisualStyleBackColor = True
        '
        'btnFindMSRNumber
        '
        Me.btnFindMSRNumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFindMSRNumber.Location = New System.Drawing.Point(442, 81)
        Me.btnFindMSRNumber.Name = "btnFindMSRNumber"
        Me.btnFindMSRNumber.Size = New System.Drawing.Size(110, 33)
        Me.btnFindMSRNumber.TabIndex = 28
        Me.btnFindMSRNumber.Text = "Find MSR"
        Me.btnFindMSRNumber.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(149, 86)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(160, 23)
        Me.Label2.TabIndex = 29
        Me.Label2.Text = "Enter MSR Number"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtEnterMSRNumber
        '
        Me.txtEnterMSRNumber.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtEnterMSRNumber.Location = New System.Drawing.Point(326, 88)
        Me.txtEnterMSRNumber.Name = "txtEnterMSRNumber"
        Me.txtEnterMSRNumber.Size = New System.Drawing.Size(100, 20)
        Me.txtEnterMSRNumber.TabIndex = 30
        '
        'cboReceiveTransactionID
        '
        Me.cboReceiveTransactionID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboReceiveTransactionID.FormattingEnabled = True
        Me.cboReceiveTransactionID.Location = New System.Drawing.Point(277, 149)
        Me.cboReceiveTransactionID.Name = "cboReceiveTransactionID"
        Me.cboReceiveTransactionID.Size = New System.Drawing.Size(121, 21)
        Me.cboReceiveTransactionID.TabIndex = 31
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(100, 149)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(160, 23)
        Me.Label3.TabIndex = 32
        Me.Label3.Text = "Transaction ID"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtReceiveMSRNumber
        '
        Me.txtReceiveMSRNumber.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtReceiveMSRNumber.Location = New System.Drawing.Point(277, 176)
        Me.txtReceiveMSRNumber.Name = "txtReceiveMSRNumber"
        Me.txtReceiveMSRNumber.ReadOnly = True
        Me.txtReceiveMSRNumber.Size = New System.Drawing.Size(121, 20)
        Me.txtReceiveMSRNumber.TabIndex = 34
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(100, 174)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(160, 23)
        Me.Label4.TabIndex = 33
        Me.Label4.Text = "MSR Number"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtReceiveTWCProjectID
        '
        Me.txtReceiveTWCProjectID.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtReceiveTWCProjectID.Location = New System.Drawing.Point(277, 230)
        Me.txtReceiveTWCProjectID.Name = "txtReceiveTWCProjectID"
        Me.txtReceiveTWCProjectID.ReadOnly = True
        Me.txtReceiveTWCProjectID.Size = New System.Drawing.Size(121, 20)
        Me.txtReceiveTWCProjectID.TabIndex = 36
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(100, 228)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(160, 23)
        Me.Label5.TabIndex = 35
        Me.Label5.Text = "TWC Project ID"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtReceiveQuantity
        '
        Me.txtReceiveQuantity.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtReceiveQuantity.Location = New System.Drawing.Point(277, 256)
        Me.txtReceiveQuantity.Name = "txtReceiveQuantity"
        Me.txtReceiveQuantity.ReadOnly = True
        Me.txtReceiveQuantity.Size = New System.Drawing.Size(121, 20)
        Me.txtReceiveQuantity.TabIndex = 38
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(100, 254)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(160, 23)
        Me.Label6.TabIndex = 37
        Me.Label6.Text = "Quantity"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtReceivePartNumber
        '
        Me.txtReceivePartNumber.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtReceivePartNumber.Location = New System.Drawing.Point(277, 202)
        Me.txtReceivePartNumber.Name = "txtReceivePartNumber"
        Me.txtReceivePartNumber.ReadOnly = True
        Me.txtReceivePartNumber.Size = New System.Drawing.Size(121, 20)
        Me.txtReceivePartNumber.TabIndex = 40
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(100, 200)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(160, 23)
        Me.Label7.TabIndex = 39
        Me.Label7.Text = "Part Number"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'PartsReceivedGridView
        '
        Me.PartsReceivedGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.PartsReceivedGridView.Location = New System.Drawing.Point(17, 307)
        Me.PartsReceivedGridView.Name = "PartsReceivedGridView"
        Me.PartsReceivedGridView.Size = New System.Drawing.Size(535, 265)
        Me.PartsReceivedGridView.TabIndex = 41
        '
        'CreatePickListFromMSR
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(761, 595)
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
        Me.Controls.Add(Me.txtEnterMSRNumber)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnFindMSRNumber)
        Me.Controls.Add(Me.btnProcess)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnMainMenu)
        Me.Controls.Add(Me.btnCreatePickListMenu)
        Me.Controls.Add(Me.btnIssueInventoryMenu)
        Me.Controls.Add(Me.btnClose)
        Me.Name = "CreatePickListFromMSR"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CreatePickListFromMSR"
        CType(Me.PartsReceivedGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents btnIssueInventoryMenu As System.Windows.Forms.Button
    Friend WithEvents btnCreatePickListMenu As System.Windows.Forms.Button
    Friend WithEvents btnMainMenu As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnProcess As System.Windows.Forms.Button
    Friend WithEvents btnFindMSRNumber As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtEnterMSRNumber As System.Windows.Forms.TextBox
    Friend WithEvents cboReceiveTransactionID As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtReceiveMSRNumber As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtReceiveTWCProjectID As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtReceiveQuantity As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtReceivePartNumber As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents PartsReceivedGridView As System.Windows.Forms.DataGridView
End Class
