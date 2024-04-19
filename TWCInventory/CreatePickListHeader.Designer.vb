<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CreatePickListHeader
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
        Me.txtDate = New System.Windows.Forms.TextBox()
        Me.txtOrderIssued = New System.Windows.Forms.TextBox()
        Me.txtProjectID = New System.Windows.Forms.TextBox()
        Me.cboPickListID = New System.Windows.Forms.ComboBox()
        Me.txtMSRNumber = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'txtDate
        '
        Me.txtDate.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDate.Location = New System.Drawing.Point(29, 103)
        Me.txtDate.Name = "txtDate"
        Me.txtDate.ReadOnly = True
        Me.txtDate.Size = New System.Drawing.Size(121, 20)
        Me.txtDate.TabIndex = 50
        '
        'txtOrderIssued
        '
        Me.txtOrderIssued.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtOrderIssued.Location = New System.Drawing.Point(29, 131)
        Me.txtOrderIssued.Name = "txtOrderIssued"
        Me.txtOrderIssued.ReadOnly = True
        Me.txtOrderIssued.Size = New System.Drawing.Size(121, 20)
        Me.txtOrderIssued.TabIndex = 46
        '
        'txtProjectID
        '
        Me.txtProjectID.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtProjectID.Location = New System.Drawing.Point(29, 77)
        Me.txtProjectID.Name = "txtProjectID"
        Me.txtProjectID.ReadOnly = True
        Me.txtProjectID.Size = New System.Drawing.Size(121, 20)
        Me.txtProjectID.TabIndex = 44
        '
        'cboPickListID
        '
        Me.cboPickListID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboPickListID.FormattingEnabled = True
        Me.cboPickListID.Location = New System.Drawing.Point(29, 50)
        Me.cboPickListID.Name = "cboPickListID"
        Me.cboPickListID.Size = New System.Drawing.Size(121, 21)
        Me.cboPickListID.TabIndex = 41
        '
        'txtMSRNumber
        '
        Me.txtMSRNumber.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtMSRNumber.Location = New System.Drawing.Point(29, 157)
        Me.txtMSRNumber.Name = "txtMSRNumber"
        Me.txtMSRNumber.ReadOnly = True
        Me.txtMSRNumber.Size = New System.Drawing.Size(121, 20)
        Me.txtMSRNumber.TabIndex = 51
        '
        'CreatePickListHeader
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(183, 208)
        Me.Controls.Add(Me.txtMSRNumber)
        Me.Controls.Add(Me.txtDate)
        Me.Controls.Add(Me.txtOrderIssued)
        Me.Controls.Add(Me.txtProjectID)
        Me.Controls.Add(Me.cboPickListID)
        Me.Name = "CreatePickListHeader"
        Me.Text = "CreatePickListHeader"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtDate As System.Windows.Forms.TextBox
    Friend WithEvents txtOrderIssued As System.Windows.Forms.TextBox
    Friend WithEvents txtProjectID As System.Windows.Forms.TextBox
    Friend WithEvents cboPickListID As System.Windows.Forms.ComboBox
    Friend WithEvents txtMSRNumber As System.Windows.Forms.TextBox
End Class
