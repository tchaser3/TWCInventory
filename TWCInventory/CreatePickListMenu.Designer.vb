<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CreatePickListMenu
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
        Me.btnCreatePickListFromProjectID = New System.Windows.Forms.Button()
        Me.btnCreatePickListFromMSR = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnIssueInventoryMenu = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnCreatePickListFromProjectID
        '
        Me.btnCreatePickListFromProjectID.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCreatePickListFromProjectID.Location = New System.Drawing.Point(179, 74)
        Me.btnCreatePickListFromProjectID.Name = "btnCreatePickListFromProjectID"
        Me.btnCreatePickListFromProjectID.Size = New System.Drawing.Size(152, 62)
        Me.btnCreatePickListFromProjectID.TabIndex = 17
        Me.btnCreatePickListFromProjectID.Text = "Create Pick List From Project ID"
        Me.btnCreatePickListFromProjectID.UseVisualStyleBackColor = True
        '
        'btnCreatePickListFromMSR
        '
        Me.btnCreatePickListFromMSR.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCreatePickListFromMSR.Location = New System.Drawing.Point(12, 72)
        Me.btnCreatePickListFromMSR.Name = "btnCreatePickListFromMSR"
        Me.btnCreatePickListFromMSR.Size = New System.Drawing.Size(152, 62)
        Me.btnCreatePickListFromMSR.TabIndex = 16
        Me.btnCreatePickListFromMSR.Text = "Create Pick List From MSR"
        Me.btnCreatePickListFromMSR.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(318, 35)
        Me.Label1.TabIndex = 22
        Me.Label1.Text = "Create Pick List Menu"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnIssueInventoryMenu
        '
        Me.btnIssueInventoryMenu.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnIssueInventoryMenu.Location = New System.Drawing.Point(11, 142)
        Me.btnIssueInventoryMenu.Name = "btnIssueInventoryMenu"
        Me.btnIssueInventoryMenu.Size = New System.Drawing.Size(152, 62)
        Me.btnIssueInventoryMenu.TabIndex = 20
        Me.btnIssueInventoryMenu.Text = "Issue Inventory Menu"
        Me.btnIssueInventoryMenu.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.Location = New System.Drawing.Point(178, 142)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(152, 62)
        Me.btnClose.TabIndex = 21
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'CreatePickListMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(346, 225)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnCreatePickListFromProjectID)
        Me.Controls.Add(Me.btnCreatePickListFromMSR)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnIssueInventoryMenu)
        Me.Controls.Add(Me.btnClose)
        Me.Name = "CreatePickListMenu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CreatePickListMenu"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnCreatePickListFromProjectID As System.Windows.Forms.Button
    Friend WithEvents btnCreatePickListFromMSR As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnIssueInventoryMenu As System.Windows.Forms.Button
    Friend WithEvents btnClose As System.Windows.Forms.Button
End Class
