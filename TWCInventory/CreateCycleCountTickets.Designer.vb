<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CreateCycleCountTickets
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
        Me.btnAdminMenu = New System.Windows.Forms.Button()
        Me.btnCreateTickets = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cboMainPartID = New System.Windows.Forms.ComboBox()
        Me.txtTablePartNumber = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtInventoryPartNumber = New System.Windows.Forms.TextBox()
        Me.cboInventoryPartID = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtCycleCountPartNumber = New System.Windows.Forms.TextBox()
        Me.cboCycleCountTransactionID = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtCycleCountDate = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtCycleCountTimesCounted = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtStoredTimesCounted = New System.Windows.Forms.TextBox()
        Me.cboTimesCountedTransactionID = New System.Windows.Forms.ComboBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtTablePartDescription = New System.Windows.Forms.TextBox()
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.SuspendLayout()
        '
        'btnClose
        '
        Me.btnClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.Location = New System.Drawing.Point(371, 224)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(168, 56)
        Me.btnClose.TabIndex = 0
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'btnAdminMenu
        '
        Me.btnAdminMenu.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdminMenu.Location = New System.Drawing.Point(371, 162)
        Me.btnAdminMenu.Name = "btnAdminMenu"
        Me.btnAdminMenu.Size = New System.Drawing.Size(168, 56)
        Me.btnAdminMenu.TabIndex = 1
        Me.btnAdminMenu.Text = "Admin Menu"
        Me.btnAdminMenu.UseVisualStyleBackColor = True
        '
        'btnCreateTickets
        '
        Me.btnCreateTickets.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCreateTickets.Location = New System.Drawing.Point(371, 100)
        Me.btnCreateTickets.Name = "btnCreateTickets"
        Me.btnCreateTickets.Size = New System.Drawing.Size(168, 56)
        Me.btnCreateTickets.TabIndex = 2
        Me.btnCreateTickets.Text = "Create Tickets"
        Me.btnCreateTickets.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(527, 36)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Create Cycle Tickets"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cboMainPartID
        '
        Me.cboMainPartID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboMainPartID.FormattingEnabled = True
        Me.cboMainPartID.Location = New System.Drawing.Point(136, 100)
        Me.cboMainPartID.Name = "cboMainPartID"
        Me.cboMainPartID.Size = New System.Drawing.Size(121, 21)
        Me.cboMainPartID.TabIndex = 4
        '
        'txtTablePartNumber
        '
        Me.txtTablePartNumber.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtTablePartNumber.Location = New System.Drawing.Point(136, 128)
        Me.txtTablePartNumber.Name = "txtTablePartNumber"
        Me.txtTablePartNumber.ReadOnly = True
        Me.txtTablePartNumber.Size = New System.Drawing.Size(121, 20)
        Me.txtTablePartNumber.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(30, 100)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 23)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Part ID"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(30, 128)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(100, 23)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Part Number"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(30, 252)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(100, 23)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Part Number"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(30, 224)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(100, 23)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Transaction ID"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtInventoryPartNumber
        '
        Me.txtInventoryPartNumber.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtInventoryPartNumber.Location = New System.Drawing.Point(136, 252)
        Me.txtInventoryPartNumber.Name = "txtInventoryPartNumber"
        Me.txtInventoryPartNumber.ReadOnly = True
        Me.txtInventoryPartNumber.Size = New System.Drawing.Size(121, 20)
        Me.txtInventoryPartNumber.TabIndex = 9
        '
        'cboInventoryPartID
        '
        Me.cboInventoryPartID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboInventoryPartID.FormattingEnabled = True
        Me.cboInventoryPartID.Location = New System.Drawing.Point(136, 224)
        Me.cboInventoryPartID.Name = "cboInventoryPartID"
        Me.cboInventoryPartID.Size = New System.Drawing.Size(121, 21)
        Me.cboInventoryPartID.TabIndex = 8
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(30, 327)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(100, 23)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "Part Number"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(30, 299)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(100, 23)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "Transaction ID"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtCycleCountPartNumber
        '
        Me.txtCycleCountPartNumber.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCycleCountPartNumber.Location = New System.Drawing.Point(136, 327)
        Me.txtCycleCountPartNumber.Name = "txtCycleCountPartNumber"
        Me.txtCycleCountPartNumber.ReadOnly = True
        Me.txtCycleCountPartNumber.Size = New System.Drawing.Size(121, 20)
        Me.txtCycleCountPartNumber.TabIndex = 13
        '
        'cboCycleCountTransactionID
        '
        Me.cboCycleCountTransactionID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboCycleCountTransactionID.FormattingEnabled = True
        Me.cboCycleCountTransactionID.Location = New System.Drawing.Point(136, 299)
        Me.cboCycleCountTransactionID.Name = "cboCycleCountTransactionID"
        Me.cboCycleCountTransactionID.Size = New System.Drawing.Size(121, 21)
        Me.cboCycleCountTransactionID.TabIndex = 12
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(30, 350)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(100, 23)
        Me.Label8.TabIndex = 17
        Me.Label8.Text = "Date"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtCycleCountDate
        '
        Me.txtCycleCountDate.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCycleCountDate.Location = New System.Drawing.Point(136, 350)
        Me.txtCycleCountDate.Name = "txtCycleCountDate"
        Me.txtCycleCountDate.ReadOnly = True
        Me.txtCycleCountDate.Size = New System.Drawing.Size(121, 20)
        Me.txtCycleCountDate.TabIndex = 16
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(30, 373)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(100, 23)
        Me.Label9.TabIndex = 19
        Me.Label9.Text = "Times Counted"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtCycleCountTimesCounted
        '
        Me.txtCycleCountTimesCounted.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCycleCountTimesCounted.Location = New System.Drawing.Point(136, 373)
        Me.txtCycleCountTimesCounted.Name = "txtCycleCountTimesCounted"
        Me.txtCycleCountTimesCounted.ReadOnly = True
        Me.txtCycleCountTimesCounted.Size = New System.Drawing.Size(121, 20)
        Me.txtCycleCountTimesCounted.TabIndex = 18
        '
        'Label10
        '
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(314, 335)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(100, 23)
        Me.Label10.TabIndex = 23
        Me.Label10.Text = "Times Counted"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label11
        '
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(314, 307)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(100, 23)
        Me.Label11.TabIndex = 22
        Me.Label11.Text = "Transaction ID"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtStoredTimesCounted
        '
        Me.txtStoredTimesCounted.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtStoredTimesCounted.Location = New System.Drawing.Point(420, 335)
        Me.txtStoredTimesCounted.Name = "txtStoredTimesCounted"
        Me.txtStoredTimesCounted.ReadOnly = True
        Me.txtStoredTimesCounted.Size = New System.Drawing.Size(121, 20)
        Me.txtStoredTimesCounted.TabIndex = 21
        '
        'cboTimesCountedTransactionID
        '
        Me.cboTimesCountedTransactionID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboTimesCountedTransactionID.FormattingEnabled = True
        Me.cboTimesCountedTransactionID.Location = New System.Drawing.Point(420, 307)
        Me.cboTimesCountedTransactionID.Name = "cboTimesCountedTransactionID"
        Me.cboTimesCountedTransactionID.Size = New System.Drawing.Size(121, 21)
        Me.cboTimesCountedTransactionID.TabIndex = 20
        '
        'Label12
        '
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(30, 154)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(100, 23)
        Me.Label12.TabIndex = 25
        Me.Label12.Text = "Part Description"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtTablePartDescription
        '
        Me.txtTablePartDescription.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtTablePartDescription.Location = New System.Drawing.Point(136, 154)
        Me.txtTablePartDescription.Name = "txtTablePartDescription"
        Me.txtTablePartDescription.ReadOnly = True
        Me.txtTablePartDescription.Size = New System.Drawing.Size(121, 20)
        Me.txtTablePartDescription.TabIndex = 24
        '
        'PrintDialog1
        '
        Me.PrintDialog1.UseEXDialog = True
        '
        'PrintDocument1
        '
        '
        'CreateCycleCountTickets
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(556, 424)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.txtTablePartDescription)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.txtStoredTimesCounted)
        Me.Controls.Add(Me.cboTimesCountedTransactionID)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtCycleCountTimesCounted)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtCycleCountDate)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtCycleCountPartNumber)
        Me.Controls.Add(Me.cboCycleCountTransactionID)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtInventoryPartNumber)
        Me.Controls.Add(Me.cboInventoryPartID)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtTablePartNumber)
        Me.Controls.Add(Me.cboMainPartID)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnCreateTickets)
        Me.Controls.Add(Me.btnAdminMenu)
        Me.Controls.Add(Me.btnClose)
        Me.Name = "CreateCycleCountTickets"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CreateCycleCountTickets"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents btnAdminMenu As System.Windows.Forms.Button
    Friend WithEvents btnCreateTickets As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cboMainPartID As System.Windows.Forms.ComboBox
    Friend WithEvents txtTablePartNumber As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtInventoryPartNumber As System.Windows.Forms.TextBox
    Friend WithEvents cboInventoryPartID As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtCycleCountPartNumber As System.Windows.Forms.TextBox
    Friend WithEvents cboCycleCountTransactionID As System.Windows.Forms.ComboBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtCycleCountDate As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtCycleCountTimesCounted As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtStoredTimesCounted As System.Windows.Forms.TextBox
    Friend WithEvents cboTimesCountedTransactionID As System.Windows.Forms.ComboBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtTablePartDescription As System.Windows.Forms.TextBox
    Friend WithEvents PrintDialog1 As System.Windows.Forms.PrintDialog
    Friend WithEvents PrintDocument1 As System.Drawing.Printing.PrintDocument
End Class
