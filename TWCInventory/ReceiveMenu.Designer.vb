<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ReceiveMenu
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnReceiveMSROrder = New System.Windows.Forms.Button()
        Me.btnViewReceivedProjectParts = New System.Windows.Forms.Button()
        Me.btnViewArchiveReceivedMenu = New System.Windows.Forms.Button()
        Me.btnSearchPartsByMSRNumber = New System.Windows.Forms.Button()
        Me.btnSearchPartsByDescription = New System.Windows.Forms.Button()
        Me.btnSearchPartsByDate = New System.Windows.Forms.Button()
        Me.btnPartNumberDateSearch = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnClose
        '
        Me.btnClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.Location = New System.Drawing.Point(347, 226)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(152, 62)
        Me.btnClose.TabIndex = 8
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'btnMainMenu
        '
        Me.btnMainMenu.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMainMenu.Location = New System.Drawing.Point(183, 226)
        Me.btnMainMenu.Name = "btnMainMenu"
        Me.btnMainMenu.Size = New System.Drawing.Size(152, 62)
        Me.btnMainMenu.TabIndex = 7
        Me.btnMainMenu.Text = "Main Menu"
        Me.btnMainMenu.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(16, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(483, 35)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Receive Inventory Menu"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnReceiveMSROrder
        '
        Me.btnReceiveMSROrder.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReceiveMSROrder.Location = New System.Drawing.Point(16, 82)
        Me.btnReceiveMSROrder.Name = "btnReceiveMSROrder"
        Me.btnReceiveMSROrder.Size = New System.Drawing.Size(152, 62)
        Me.btnReceiveMSROrder.TabIndex = 0
        Me.btnReceiveMSROrder.Text = "Receive MSR Order"
        Me.btnReceiveMSROrder.UseVisualStyleBackColor = True
        '
        'btnViewReceivedProjectParts
        '
        Me.btnViewReceivedProjectParts.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnViewReceivedProjectParts.Location = New System.Drawing.Point(183, 82)
        Me.btnViewReceivedProjectParts.Name = "btnViewReceivedProjectParts"
        Me.btnViewReceivedProjectParts.Size = New System.Drawing.Size(152, 62)
        Me.btnViewReceivedProjectParts.TabIndex = 1
        Me.btnViewReceivedProjectParts.Text = "View Received Project Parts"
        Me.btnViewReceivedProjectParts.UseVisualStyleBackColor = True
        '
        'btnViewArchiveReceivedMenu
        '
        Me.btnViewArchiveReceivedMenu.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnViewArchiveReceivedMenu.Location = New System.Drawing.Point(16, 226)
        Me.btnViewArchiveReceivedMenu.Name = "btnViewArchiveReceivedMenu"
        Me.btnViewArchiveReceivedMenu.Size = New System.Drawing.Size(152, 62)
        Me.btnViewArchiveReceivedMenu.TabIndex = 6
        Me.btnViewArchiveReceivedMenu.Text = "View Archive Received Menu"
        Me.btnViewArchiveReceivedMenu.UseVisualStyleBackColor = True
        '
        'btnSearchPartsByMSRNumber
        '
        Me.btnSearchPartsByMSRNumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearchPartsByMSRNumber.Location = New System.Drawing.Point(347, 82)
        Me.btnSearchPartsByMSRNumber.Name = "btnSearchPartsByMSRNumber"
        Me.btnSearchPartsByMSRNumber.Size = New System.Drawing.Size(152, 62)
        Me.btnSearchPartsByMSRNumber.TabIndex = 2
        Me.btnSearchPartsByMSRNumber.Text = "Search Parts by MSR Number"
        Me.btnSearchPartsByMSRNumber.UseVisualStyleBackColor = True
        '
        'btnSearchPartsByDescription
        '
        Me.btnSearchPartsByDescription.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearchPartsByDescription.Location = New System.Drawing.Point(347, 155)
        Me.btnSearchPartsByDescription.Name = "btnSearchPartsByDescription"
        Me.btnSearchPartsByDescription.Size = New System.Drawing.Size(152, 62)
        Me.btnSearchPartsByDescription.TabIndex = 5
        Me.btnSearchPartsByDescription.Text = "Search By Date and Description"
        Me.btnSearchPartsByDescription.UseVisualStyleBackColor = True
        '
        'btnSearchPartsByDate
        '
        Me.btnSearchPartsByDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearchPartsByDate.Location = New System.Drawing.Point(16, 155)
        Me.btnSearchPartsByDate.Name = "btnSearchPartsByDate"
        Me.btnSearchPartsByDate.Size = New System.Drawing.Size(152, 62)
        Me.btnSearchPartsByDate.TabIndex = 3
        Me.btnSearchPartsByDate.Text = "Search Parts By Date"
        Me.btnSearchPartsByDate.UseVisualStyleBackColor = True
        '
        'btnPartNumberDateSearch
        '
        Me.btnPartNumberDateSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPartNumberDateSearch.Location = New System.Drawing.Point(183, 155)
        Me.btnPartNumberDateSearch.Name = "btnPartNumberDateSearch"
        Me.btnPartNumberDateSearch.Size = New System.Drawing.Size(152, 62)
        Me.btnPartNumberDateSearch.TabIndex = 4
        Me.btnPartNumberDateSearch.Text = "Part Number Date Search"
        Me.btnPartNumberDateSearch.UseVisualStyleBackColor = True
        '
        'ReceiveMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(522, 320)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnSearchPartsByDescription)
        Me.Controls.Add(Me.btnSearchPartsByDate)
        Me.Controls.Add(Me.btnPartNumberDateSearch)
        Me.Controls.Add(Me.btnViewArchiveReceivedMenu)
        Me.Controls.Add(Me.btnSearchPartsByMSRNumber)
        Me.Controls.Add(Me.btnViewReceivedProjectParts)
        Me.Controls.Add(Me.btnReceiveMSROrder)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnMainMenu)
        Me.Controls.Add(Me.btnClose)
        Me.Name = "ReceiveMenu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ReceiveMenu"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents btnMainMenu As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnReceiveMSROrder As System.Windows.Forms.Button
    Friend WithEvents btnViewReceivedProjectParts As System.Windows.Forms.Button
    Friend WithEvents btnViewArchiveReceivedMenu As System.Windows.Forms.Button
    Friend WithEvents btnSearchPartsByMSRNumber As System.Windows.Forms.Button
    Friend WithEvents btnSearchPartsByDescription As System.Windows.Forms.Button
    Friend WithEvents btnSearchPartsByDate As System.Windows.Forms.Button
    Friend WithEvents btnPartNumberDateSearch As System.Windows.Forms.Button
End Class
