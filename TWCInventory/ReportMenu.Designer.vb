<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ReportMenu
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
        Me.btnOnHandReport = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnCompleteInventoryReport = New System.Windows.Forms.Button()
        Me.btnViewTimeWarnerTransactions = New System.Windows.Forms.Button()
        Me.btnProjectTransactionReport = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnClose
        '
        Me.btnClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.Location = New System.Drawing.Point(528, 197)
        Me.btnClose.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(228, 80)
        Me.btnClose.TabIndex = 5
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'btnMainMenu
        '
        Me.btnMainMenu.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMainMenu.Location = New System.Drawing.Point(272, 197)
        Me.btnMainMenu.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnMainMenu.Name = "btnMainMenu"
        Me.btnMainMenu.Size = New System.Drawing.Size(228, 80)
        Me.btnMainMenu.TabIndex = 4
        Me.btnMainMenu.Text = "Main Menu"
        Me.btnMainMenu.UseVisualStyleBackColor = True
        '
        'btnOnHandReport
        '
        Me.btnOnHandReport.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOnHandReport.Location = New System.Drawing.Point(16, 98)
        Me.btnOnHandReport.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnOnHandReport.Name = "btnOnHandReport"
        Me.btnOnHandReport.Size = New System.Drawing.Size(228, 80)
        Me.btnOnHandReport.TabIndex = 0
        Me.btnOnHandReport.Text = "Part Project Transaction Report"
        Me.btnOnHandReport.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(16, 11)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(740, 57)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Report Menu"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnCompleteInventoryReport
        '
        Me.btnCompleteInventoryReport.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCompleteInventoryReport.Location = New System.Drawing.Point(272, 98)
        Me.btnCompleteInventoryReport.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnCompleteInventoryReport.Name = "btnCompleteInventoryReport"
        Me.btnCompleteInventoryReport.Size = New System.Drawing.Size(228, 80)
        Me.btnCompleteInventoryReport.TabIndex = 1
        Me.btnCompleteInventoryReport.Text = "Complete Inventory Report"
        Me.btnCompleteInventoryReport.UseVisualStyleBackColor = True
        '
        'btnViewTimeWarnerTransactions
        '
        Me.btnViewTimeWarnerTransactions.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnViewTimeWarnerTransactions.Location = New System.Drawing.Point(528, 100)
        Me.btnViewTimeWarnerTransactions.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnViewTimeWarnerTransactions.Name = "btnViewTimeWarnerTransactions"
        Me.btnViewTimeWarnerTransactions.Size = New System.Drawing.Size(228, 80)
        Me.btnViewTimeWarnerTransactions.TabIndex = 2
        Me.btnViewTimeWarnerTransactions.Text = "View Time Warner Transactions"
        Me.btnViewTimeWarnerTransactions.UseVisualStyleBackColor = True
        '
        'btnProjectTransactionReport
        '
        Me.btnProjectTransactionReport.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnProjectTransactionReport.Location = New System.Drawing.Point(16, 197)
        Me.btnProjectTransactionReport.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnProjectTransactionReport.Name = "btnProjectTransactionReport"
        Me.btnProjectTransactionReport.Size = New System.Drawing.Size(228, 80)
        Me.btnProjectTransactionReport.TabIndex = 3
        Me.btnProjectTransactionReport.Text = "Project Transaction Report"
        Me.btnProjectTransactionReport.UseVisualStyleBackColor = True
        '
        'ReportMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(777, 321)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnProjectTransactionReport)
        Me.Controls.Add(Me.btnViewTimeWarnerTransactions)
        Me.Controls.Add(Me.btnCompleteInventoryReport)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnOnHandReport)
        Me.Controls.Add(Me.btnMainMenu)
        Me.Controls.Add(Me.btnClose)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "ReportMenu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ReportMenu"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents btnMainMenu As System.Windows.Forms.Button
    Friend WithEvents btnOnHandReport As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnCompleteInventoryReport As System.Windows.Forms.Button
    Friend WithEvents btnViewTimeWarnerTransactions As System.Windows.Forms.Button
    Friend WithEvents btnProjectTransactionReport As System.Windows.Forms.Button
End Class
