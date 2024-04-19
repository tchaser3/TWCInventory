<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CreateVendorReturnsID
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
        Me.cboTransactionID = New System.Windows.Forms.ComboBox()
        Me.txtCreatedTransactionID = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'cboTransactionID
        '
        Me.cboTransactionID.FormattingEnabled = True
        Me.cboTransactionID.Location = New System.Drawing.Point(54, 13)
        Me.cboTransactionID.Name = "cboTransactionID"
        Me.cboTransactionID.Size = New System.Drawing.Size(121, 21)
        Me.cboTransactionID.TabIndex = 0
        '
        'txtCreatedTransactionID
        '
        Me.txtCreatedTransactionID.Location = New System.Drawing.Point(54, 53)
        Me.txtCreatedTransactionID.Name = "txtCreatedTransactionID"
        Me.txtCreatedTransactionID.Size = New System.Drawing.Size(121, 20)
        Me.txtCreatedTransactionID.TabIndex = 1
        '
        'CreateVendorReturnsID
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(224, 110)
        Me.Controls.Add(Me.txtCreatedTransactionID)
        Me.Controls.Add(Me.cboTransactionID)
        Me.Name = "CreateVendorReturnsID"
        Me.Text = "CreateVendorReturnsID"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cboTransactionID As System.Windows.Forms.ComboBox
    Friend WithEvents txtCreatedTransactionID As System.Windows.Forms.TextBox
End Class
