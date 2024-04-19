<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class IssueInventory
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
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnViewProjectIssuedParts = New System.Windows.Forms.Button()
        Me.btnIssueMaterial = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnIssuePickList = New System.Windows.Forms.Button()
        Me.btnCreatePickList = New System.Windows.Forms.Button()
        Me.btnPartNumberDateSearch = New System.Windows.Forms.Button()
        Me.btnDateRangePartsIssuedSearch = New System.Windows.Forms.Button()
        Me.btnPartDescriptionDateSearch = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnMainMenu
        '
        Me.btnMainMenu.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMainMenu.Location = New System.Drawing.Point(174, 220)
        Me.btnMainMenu.Name = "btnMainMenu"
        Me.btnMainMenu.Size = New System.Drawing.Size(152, 62)
        Me.btnMainMenu.TabIndex = 7
        Me.btnMainMenu.Text = "Main Menu"
        Me.btnMainMenu.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.Location = New System.Drawing.Point(337, 220)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(152, 62)
        Me.btnClose.TabIndex = 8
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'btnViewProjectIssuedParts
        '
        Me.btnViewProjectIssuedParts.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnViewProjectIssuedParts.Location = New System.Drawing.Point(12, 154)
        Me.btnViewProjectIssuedParts.Name = "btnViewProjectIssuedParts"
        Me.btnViewProjectIssuedParts.Size = New System.Drawing.Size(152, 62)
        Me.btnViewProjectIssuedParts.TabIndex = 3
        Me.btnViewProjectIssuedParts.Text = "View Project Issued Parts"
        Me.btnViewProjectIssuedParts.UseVisualStyleBackColor = True
        '
        'btnIssueMaterial
        '
        Me.btnIssueMaterial.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnIssueMaterial.Location = New System.Drawing.Point(12, 86)
        Me.btnIssueMaterial.Name = "btnIssueMaterial"
        Me.btnIssueMaterial.Size = New System.Drawing.Size(152, 62)
        Me.btnIssueMaterial.TabIndex = 0
        Me.btnIssueMaterial.Text = "Issue Material"
        Me.btnIssueMaterial.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(477, 35)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "Issue Inventory Menu"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnIssuePickList
        '
        Me.btnIssuePickList.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnIssuePickList.Location = New System.Drawing.Point(337, 84)
        Me.btnIssuePickList.Name = "btnIssuePickList"
        Me.btnIssuePickList.Size = New System.Drawing.Size(152, 62)
        Me.btnIssuePickList.TabIndex = 2
        Me.btnIssuePickList.Text = "Issue Pick List"
        Me.btnIssuePickList.UseVisualStyleBackColor = True
        '
        'btnCreatePickList
        '
        Me.btnCreatePickList.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCreatePickList.Location = New System.Drawing.Point(174, 86)
        Me.btnCreatePickList.Name = "btnCreatePickList"
        Me.btnCreatePickList.Size = New System.Drawing.Size(152, 62)
        Me.btnCreatePickList.TabIndex = 1
        Me.btnCreatePickList.Text = "Create Pick List"
        Me.btnCreatePickList.UseVisualStyleBackColor = True
        '
        'btnPartNumberDateSearch
        '
        Me.btnPartNumberDateSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPartNumberDateSearch.Location = New System.Drawing.Point(337, 152)
        Me.btnPartNumberDateSearch.Name = "btnPartNumberDateSearch"
        Me.btnPartNumberDateSearch.Size = New System.Drawing.Size(152, 62)
        Me.btnPartNumberDateSearch.TabIndex = 5
        Me.btnPartNumberDateSearch.Text = "Part Number Date Search"
        Me.btnPartNumberDateSearch.UseVisualStyleBackColor = True
        '
        'btnDateRangePartsIssuedSearch
        '
        Me.btnDateRangePartsIssuedSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDateRangePartsIssuedSearch.Location = New System.Drawing.Point(174, 154)
        Me.btnDateRangePartsIssuedSearch.Name = "btnDateRangePartsIssuedSearch"
        Me.btnDateRangePartsIssuedSearch.Size = New System.Drawing.Size(152, 62)
        Me.btnDateRangePartsIssuedSearch.TabIndex = 4
        Me.btnDateRangePartsIssuedSearch.Text = "Date Range Parts Issued Search"
        Me.btnDateRangePartsIssuedSearch.UseVisualStyleBackColor = True
        '
        'btnPartDescriptionDateSearch
        '
        Me.btnPartDescriptionDateSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPartDescriptionDateSearch.Location = New System.Drawing.Point(12, 220)
        Me.btnPartDescriptionDateSearch.Name = "btnPartDescriptionDateSearch"
        Me.btnPartDescriptionDateSearch.Size = New System.Drawing.Size(152, 62)
        Me.btnPartDescriptionDateSearch.TabIndex = 6
        Me.btnPartDescriptionDateSearch.Text = "Part Description Date Search"
        Me.btnPartDescriptionDateSearch.UseVisualStyleBackColor = True
        '
        'IssueInventory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(501, 299)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnPartNumberDateSearch)
        Me.Controls.Add(Me.btnDateRangePartsIssuedSearch)
        Me.Controls.Add(Me.btnPartDescriptionDateSearch)
        Me.Controls.Add(Me.btnIssuePickList)
        Me.Controls.Add(Me.btnCreatePickList)
        Me.Controls.Add(Me.btnViewProjectIssuedParts)
        Me.Controls.Add(Me.btnIssueMaterial)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnMainMenu)
        Me.Controls.Add(Me.btnClose)
        Me.Name = "IssueInventory"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "IssueInventory"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnMainMenu As System.Windows.Forms.Button
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents btnViewProjectIssuedParts As System.Windows.Forms.Button
    Friend WithEvents btnIssueMaterial As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnIssuePickList As System.Windows.Forms.Button
    Friend WithEvents btnCreatePickList As System.Windows.Forms.Button
    Friend WithEvents btnPartNumberDateSearch As System.Windows.Forms.Button
    Friend WithEvents btnDateRangePartsIssuedSearch As System.Windows.Forms.Button
    Friend WithEvents btnPartDescriptionDateSearch As System.Windows.Forms.Button
End Class
