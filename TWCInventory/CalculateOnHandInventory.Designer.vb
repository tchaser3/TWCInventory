<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CalculateOnHandInventory
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
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtQTYOnHand = New System.Windows.Forms.TextBox()
        Me.txtPartDescription = New System.Windows.Forms.TextBox()
        Me.txtPartNumber = New System.Windows.Forms.TextBox()
        Me.cboPartID = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtReceivedPartNumber = New System.Windows.Forms.TextBox()
        Me.cboReceivedTransactionID = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtIssuedPartNumber = New System.Windows.Forms.TextBox()
        Me.cboIssuedTransactionID = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtReceivedQty = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtIssuedQty = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnMainMenu
        '
        Me.btnMainMenu.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMainMenu.Location = New System.Drawing.Point(584, 180)
        Me.btnMainMenu.Name = "btnMainMenu"
        Me.btnMainMenu.Size = New System.Drawing.Size(181, 63)
        Me.btnMainMenu.TabIndex = 34
        Me.btnMainMenu.Text = "Main Menu"
        Me.btnMainMenu.UseVisualStyleBackColor = True
        '
        'btnUpdate
        '
        Me.btnUpdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdate.Location = New System.Drawing.Point(584, 111)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(181, 63)
        Me.btnUpdate.TabIndex = 32
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(39, 253)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(100, 21)
        Me.Label4.TabIndex = 31
        Me.Label4.Text = "Qty On Hand"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(39, 191)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(100, 21)
        Me.Label3.TabIndex = 30
        Me.Label3.Text = "Description"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(39, 140)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 21)
        Me.Label2.TabIndex = 29
        Me.Label2.Text = "Part Number"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(39, 111)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 21)
        Me.Label1.TabIndex = 28
        Me.Label1.Text = "Part ID"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtQTYOnHand
        '
        Me.txtQTYOnHand.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtQTYOnHand.Location = New System.Drawing.Point(145, 254)
        Me.txtQTYOnHand.Name = "txtQTYOnHand"
        Me.txtQTYOnHand.Size = New System.Drawing.Size(121, 20)
        Me.txtQTYOnHand.TabIndex = 27
        '
        'txtPartDescription
        '
        Me.txtPartDescription.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtPartDescription.Location = New System.Drawing.Point(145, 166)
        Me.txtPartDescription.Multiline = True
        Me.txtPartDescription.Name = "txtPartDescription"
        Me.txtPartDescription.Size = New System.Drawing.Size(121, 82)
        Me.txtPartDescription.TabIndex = 26
        '
        'txtPartNumber
        '
        Me.txtPartNumber.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtPartNumber.Location = New System.Drawing.Point(145, 140)
        Me.txtPartNumber.Name = "txtPartNumber"
        Me.txtPartNumber.Size = New System.Drawing.Size(121, 20)
        Me.txtPartNumber.TabIndex = 25
        '
        'cboPartID
        '
        Me.cboPartID.FormattingEnabled = True
        Me.cboPartID.Location = New System.Drawing.Point(145, 112)
        Me.cboPartID.Name = "cboPartID"
        Me.cboPartID.Size = New System.Drawing.Size(121, 21)
        Me.cboPartID.TabIndex = 24
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(310, 139)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(100, 21)
        Me.Label5.TabIndex = 38
        Me.Label5.Text = "Part Number"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(310, 110)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(100, 21)
        Me.Label6.TabIndex = 37
        Me.Label6.Text = "Transaction ID"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtReceivedPartNumber
        '
        Me.txtReceivedPartNumber.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtReceivedPartNumber.Location = New System.Drawing.Point(416, 139)
        Me.txtReceivedPartNumber.Name = "txtReceivedPartNumber"
        Me.txtReceivedPartNumber.Size = New System.Drawing.Size(121, 20)
        Me.txtReceivedPartNumber.TabIndex = 36
        '
        'cboReceivedTransactionID
        '
        Me.cboReceivedTransactionID.FormattingEnabled = True
        Me.cboReceivedTransactionID.Location = New System.Drawing.Point(416, 111)
        Me.cboReceivedTransactionID.Name = "cboReceivedTransactionID"
        Me.cboReceivedTransactionID.Size = New System.Drawing.Size(121, 21)
        Me.cboReceivedTransactionID.TabIndex = 35
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(310, 255)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(100, 21)
        Me.Label7.TabIndex = 42
        Me.Label7.Text = "Part Number"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(310, 226)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(100, 21)
        Me.Label8.TabIndex = 41
        Me.Label8.Text = "Transaction ID"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtIssuedPartNumber
        '
        Me.txtIssuedPartNumber.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtIssuedPartNumber.Location = New System.Drawing.Point(416, 255)
        Me.txtIssuedPartNumber.Name = "txtIssuedPartNumber"
        Me.txtIssuedPartNumber.Size = New System.Drawing.Size(121, 20)
        Me.txtIssuedPartNumber.TabIndex = 40
        '
        'cboIssuedTransactionID
        '
        Me.cboIssuedTransactionID.FormattingEnabled = True
        Me.cboIssuedTransactionID.Location = New System.Drawing.Point(416, 227)
        Me.cboIssuedTransactionID.Name = "cboIssuedTransactionID"
        Me.cboIssuedTransactionID.Size = New System.Drawing.Size(121, 21)
        Me.cboIssuedTransactionID.TabIndex = 39
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(310, 165)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(100, 21)
        Me.Label9.TabIndex = 44
        Me.Label9.Text = "Qty"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtReceivedQty
        '
        Me.txtReceivedQty.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtReceivedQty.Location = New System.Drawing.Point(416, 165)
        Me.txtReceivedQty.Name = "txtReceivedQty"
        Me.txtReceivedQty.Size = New System.Drawing.Size(121, 20)
        Me.txtReceivedQty.TabIndex = 43
        '
        'Label10
        '
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(310, 291)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(100, 21)
        Me.Label10.TabIndex = 46
        Me.Label10.Text = "Qty"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtIssuedQty
        '
        Me.txtIssuedQty.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtIssuedQty.Location = New System.Drawing.Point(416, 291)
        Me.txtIssuedQty.Name = "txtIssuedQty"
        Me.txtIssuedQty.Size = New System.Drawing.Size(121, 20)
        Me.txtIssuedQty.TabIndex = 45
        '
        'Label11
        '
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(12, 9)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(753, 53)
        Me.Label11.TabIndex = 47
        Me.Label11.Text = "Create On Hand Inventory"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnClose
        '
        Me.btnClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.Location = New System.Drawing.Point(584, 249)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(181, 63)
        Me.btnClose.TabIndex = 48
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'CalculateOnHandInventory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(777, 340)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txtIssuedQty)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtReceivedQty)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtIssuedPartNumber)
        Me.Controls.Add(Me.cboIssuedTransactionID)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtReceivedPartNumber)
        Me.Controls.Add(Me.cboReceivedTransactionID)
        Me.Controls.Add(Me.btnMainMenu)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtQTYOnHand)
        Me.Controls.Add(Me.txtPartDescription)
        Me.Controls.Add(Me.txtPartNumber)
        Me.Controls.Add(Me.cboPartID)
        Me.Name = "CalculateOnHandInventory"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CalculateOnHandInventory"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnMainMenu As System.Windows.Forms.Button
    Friend WithEvents btnUpdate As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtQTYOnHand As System.Windows.Forms.TextBox
    Friend WithEvents txtPartDescription As System.Windows.Forms.TextBox
    Friend WithEvents txtPartNumber As System.Windows.Forms.TextBox
    Friend WithEvents cboPartID As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtReceivedPartNumber As System.Windows.Forms.TextBox
    Friend WithEvents cboReceivedTransactionID As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtIssuedPartNumber As System.Windows.Forms.TextBox
    Friend WithEvents cboIssuedTransactionID As System.Windows.Forms.ComboBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtReceivedQty As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtIssuedQty As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents btnClose As System.Windows.Forms.Button
End Class
