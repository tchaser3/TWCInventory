<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class VendorReturns
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
        Me.btnAdministrationMenu = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnReturnMaterial = New System.Windows.Forms.Button()
        Me.cboReturnTransactionID = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtReturnPartNumber = New System.Windows.Forms.TextBox()
        Me.txtReturnDate = New System.Windows.Forms.TextBox()
        Me.txtReturnEmployeeID = New System.Windows.Forms.TextBox()
        Me.txtReturnQuantity = New System.Windows.Forms.TextBox()
        Me.txtReturnWarehouseID = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cboInventoryPartID = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtInventoryPartNumber = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtInventoryWarehouseID = New System.Windows.Forms.TextBox()
        Me.txtInventoryQuantity = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtMoreReturns = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btnClose
        '
        Me.btnClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.Location = New System.Drawing.Point(322, 301)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(181, 63)
        Me.btnClose.TabIndex = 14
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'btnMainMenu
        '
        Me.btnMainMenu.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMainMenu.Location = New System.Drawing.Point(322, 233)
        Me.btnMainMenu.Name = "btnMainMenu"
        Me.btnMainMenu.Size = New System.Drawing.Size(181, 63)
        Me.btnMainMenu.TabIndex = 13
        Me.btnMainMenu.Text = "Main Menu"
        Me.btnMainMenu.UseVisualStyleBackColor = True
        '
        'btnAdministrationMenu
        '
        Me.btnAdministrationMenu.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdministrationMenu.Location = New System.Drawing.Point(322, 166)
        Me.btnAdministrationMenu.Name = "btnAdministrationMenu"
        Me.btnAdministrationMenu.Size = New System.Drawing.Size(181, 63)
        Me.btnAdministrationMenu.TabIndex = 12
        Me.btnAdministrationMenu.Text = "Administration Menu"
        Me.btnAdministrationMenu.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(13, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(490, 31)
        Me.Label1.TabIndex = 32
        Me.Label1.Text = "Return Material To Vendor"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnReturnMaterial
        '
        Me.btnReturnMaterial.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReturnMaterial.Location = New System.Drawing.Point(322, 97)
        Me.btnReturnMaterial.Name = "btnReturnMaterial"
        Me.btnReturnMaterial.Size = New System.Drawing.Size(181, 63)
        Me.btnReturnMaterial.TabIndex = 11
        Me.btnReturnMaterial.Text = "Return Material"
        Me.btnReturnMaterial.UseVisualStyleBackColor = True
        '
        'cboReturnTransactionID
        '
        Me.cboReturnTransactionID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboReturnTransactionID.FormattingEnabled = True
        Me.cboReturnTransactionID.Location = New System.Drawing.Point(160, 86)
        Me.cboReturnTransactionID.Name = "cboReturnTransactionID"
        Me.cboReturnTransactionID.Size = New System.Drawing.Size(121, 21)
        Me.cboReturnTransactionID.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(26, 84)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(128, 23)
        Me.Label2.TabIndex = 35
        Me.Label2.Text = "Transaction ID"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtReturnPartNumber
        '
        Me.txtReturnPartNumber.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtReturnPartNumber.Location = New System.Drawing.Point(160, 120)
        Me.txtReturnPartNumber.Name = "txtReturnPartNumber"
        Me.txtReturnPartNumber.Size = New System.Drawing.Size(121, 20)
        Me.txtReturnPartNumber.TabIndex = 1
        '
        'txtReturnDate
        '
        Me.txtReturnDate.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtReturnDate.Location = New System.Drawing.Point(160, 145)
        Me.txtReturnDate.Name = "txtReturnDate"
        Me.txtReturnDate.ReadOnly = True
        Me.txtReturnDate.Size = New System.Drawing.Size(121, 20)
        Me.txtReturnDate.TabIndex = 2
        '
        'txtReturnEmployeeID
        '
        Me.txtReturnEmployeeID.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtReturnEmployeeID.Location = New System.Drawing.Point(160, 171)
        Me.txtReturnEmployeeID.Name = "txtReturnEmployeeID"
        Me.txtReturnEmployeeID.ReadOnly = True
        Me.txtReturnEmployeeID.Size = New System.Drawing.Size(121, 20)
        Me.txtReturnEmployeeID.TabIndex = 3
        '
        'txtReturnQuantity
        '
        Me.txtReturnQuantity.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtReturnQuantity.Location = New System.Drawing.Point(160, 197)
        Me.txtReturnQuantity.Name = "txtReturnQuantity"
        Me.txtReturnQuantity.Size = New System.Drawing.Size(121, 20)
        Me.txtReturnQuantity.TabIndex = 4
        '
        'txtReturnWarehouseID
        '
        Me.txtReturnWarehouseID.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtReturnWarehouseID.Location = New System.Drawing.Point(160, 223)
        Me.txtReturnWarehouseID.Name = "txtReturnWarehouseID"
        Me.txtReturnWarehouseID.ReadOnly = True
        Me.txtReturnWarehouseID.Size = New System.Drawing.Size(121, 20)
        Me.txtReturnWarehouseID.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(26, 120)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(128, 23)
        Me.Label3.TabIndex = 41
        Me.Label3.Text = "Part Number"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(26, 143)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(128, 23)
        Me.Label4.TabIndex = 42
        Me.Label4.Text = "Date"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(26, 169)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(128, 23)
        Me.Label5.TabIndex = 43
        Me.Label5.Text = "Employee ID"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(26, 197)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(128, 23)
        Me.Label6.TabIndex = 44
        Me.Label6.Text = "Quantity"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(26, 221)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(128, 23)
        Me.Label7.TabIndex = 45
        Me.Label7.Text = "Warehouse ID"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(26, 295)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(128, 23)
        Me.Label8.TabIndex = 47
        Me.Label8.Text = "Part ID"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cboInventoryPartID
        '
        Me.cboInventoryPartID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboInventoryPartID.FormattingEnabled = True
        Me.cboInventoryPartID.Location = New System.Drawing.Point(160, 297)
        Me.cboInventoryPartID.Name = "cboInventoryPartID"
        Me.cboInventoryPartID.Size = New System.Drawing.Size(121, 21)
        Me.cboInventoryPartID.TabIndex = 7
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(26, 324)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(128, 23)
        Me.Label9.TabIndex = 49
        Me.Label9.Text = "Part Number"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtInventoryPartNumber
        '
        Me.txtInventoryPartNumber.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtInventoryPartNumber.Location = New System.Drawing.Point(160, 324)
        Me.txtInventoryPartNumber.Name = "txtInventoryPartNumber"
        Me.txtInventoryPartNumber.ReadOnly = True
        Me.txtInventoryPartNumber.Size = New System.Drawing.Size(121, 20)
        Me.txtInventoryPartNumber.TabIndex = 8
        '
        'Label10
        '
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(26, 374)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(128, 23)
        Me.Label10.TabIndex = 53
        Me.Label10.Text = "Warehouse ID"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label11
        '
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(26, 350)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(128, 23)
        Me.Label11.TabIndex = 52
        Me.Label11.Text = "Quantity"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtInventoryWarehouseID
        '
        Me.txtInventoryWarehouseID.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtInventoryWarehouseID.Location = New System.Drawing.Point(160, 376)
        Me.txtInventoryWarehouseID.Name = "txtInventoryWarehouseID"
        Me.txtInventoryWarehouseID.ReadOnly = True
        Me.txtInventoryWarehouseID.Size = New System.Drawing.Size(121, 20)
        Me.txtInventoryWarehouseID.TabIndex = 10
        '
        'txtInventoryQuantity
        '
        Me.txtInventoryQuantity.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtInventoryQuantity.Location = New System.Drawing.Point(160, 350)
        Me.txtInventoryQuantity.Name = "txtInventoryQuantity"
        Me.txtInventoryQuantity.ReadOnly = True
        Me.txtInventoryQuantity.Size = New System.Drawing.Size(121, 20)
        Me.txtInventoryQuantity.TabIndex = 9
        '
        'Label12
        '
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(26, 249)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(128, 23)
        Me.Label12.TabIndex = 55
        Me.Label12.Text = "More Returns"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtMoreReturns
        '
        Me.txtMoreReturns.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtMoreReturns.Location = New System.Drawing.Point(160, 249)
        Me.txtMoreReturns.Name = "txtMoreReturns"
        Me.txtMoreReturns.Size = New System.Drawing.Size(121, 20)
        Me.txtMoreReturns.TabIndex = 6
        '
        'VendorReturns
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(548, 433)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.txtMoreReturns)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.txtInventoryWarehouseID)
        Me.Controls.Add(Me.txtInventoryQuantity)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtInventoryPartNumber)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.cboInventoryPartID)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtReturnWarehouseID)
        Me.Controls.Add(Me.txtReturnQuantity)
        Me.Controls.Add(Me.txtReturnEmployeeID)
        Me.Controls.Add(Me.txtReturnDate)
        Me.Controls.Add(Me.txtReturnPartNumber)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cboReturnTransactionID)
        Me.Controls.Add(Me.btnReturnMaterial)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnMainMenu)
        Me.Controls.Add(Me.btnAdministrationMenu)
        Me.Name = "VendorReturns"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "VendorReturns"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents btnMainMenu As System.Windows.Forms.Button
    Friend WithEvents btnAdministrationMenu As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnReturnMaterial As System.Windows.Forms.Button
    Friend WithEvents cboReturnTransactionID As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtReturnPartNumber As System.Windows.Forms.TextBox
    Friend WithEvents txtReturnDate As System.Windows.Forms.TextBox
    Friend WithEvents txtReturnEmployeeID As System.Windows.Forms.TextBox
    Friend WithEvents txtReturnQuantity As System.Windows.Forms.TextBox
    Friend WithEvents txtReturnWarehouseID As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents cboInventoryPartID As System.Windows.Forms.ComboBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtInventoryPartNumber As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtInventoryWarehouseID As System.Windows.Forms.TextBox
    Friend WithEvents txtInventoryQuantity As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtMoreReturns As System.Windows.Forms.TextBox
End Class
