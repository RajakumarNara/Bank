<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSMTLList
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    '<System.Diagnostics.DebuggerNonUserCode()> _
    'Protected Overrides Sub Dispose(ByVal disposing As Boolean)
    '    Try
    '        If disposing AndAlso components IsNot Nothing Then
    '            components.Dispose()
    '        End If
    '    Finally
    '        MyBase.Dispose(disposing)
    '    End Try
    'End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSMTLList))
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.btnAdd = New BankControls.NewButton
        Me.NewButton1 = New BankControls.NewButton
        Me.btnLoanTran = New BankControls.NewButton
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.txtSearchText = New BankControls.TextControl
        Me.Label2 = New System.Windows.Forms.Label
        Me.cmbSearchBy = New System.Windows.Forms.ComboBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.lvLoanList = New System.Windows.Forms.ListView
        Me.ColumnHeader1 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader2 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader7 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader4 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader16 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader5 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader10 = New System.Windows.Forms.ColumnHeader
        Me.NewButton6 = New BankControls.NewButton
        Me.btnRefreshList = New BankControls.NewButton
        Me.GroupBox2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.LightYellow
        Me.GroupBox2.Controls.Add(Me.btnAdd)
        Me.GroupBox2.Controls.Add(Me.NewButton1)
        Me.GroupBox2.Controls.Add(Me.btnLoanTran)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(200, 436)
        Me.GroupBox2.TabIndex = 16
        Me.GroupBox2.TabStop = False
        '
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.Color.LightYellow
        Me.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnAdd.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.ForeColor = System.Drawing.Color.Black
        Me.btnAdd.GotFocusColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(189, Byte), Integer))
        Me.btnAdd.Image = CType(resources.GetObject("btnAdd.Image"), System.Drawing.Image)
        Me.btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAdd.Location = New System.Drawing.Point(10, 94)
        Me.btnAdd.LostFocusColour = System.Drawing.Color.LightYellow
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(184, 40)
        Me.btnAdd.TabIndex = 10
        Me.btnAdd.Text = "&New SMTL Account"
        Me.btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAdd.UseVisualStyleBackColor = False
        '
        'NewButton1
        '
        Me.NewButton1.BackColor = System.Drawing.Color.LightYellow
        Me.NewButton1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.NewButton1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.NewButton1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NewButton1.ForeColor = System.Drawing.Color.Black
        Me.NewButton1.GotFocusColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(189, Byte), Integer))
        Me.NewButton1.Image = CType(resources.GetObject("NewButton1.Image"), System.Drawing.Image)
        Me.NewButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.NewButton1.Location = New System.Drawing.Point(10, 30)
        Me.NewButton1.LostFocusColour = System.Drawing.Color.LightYellow
        Me.NewButton1.Name = "NewButton1"
        Me.NewButton1.Size = New System.Drawing.Size(184, 40)
        Me.NewButton1.TabIndex = 9
        Me.NewButton1.Text = "SMTL &Transaction"
        Me.NewButton1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.NewButton1.UseVisualStyleBackColor = False
        '
        'btnLoanTran
        '
        Me.btnLoanTran.BackColor = System.Drawing.Color.LightYellow
        Me.btnLoanTran.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLoanTran.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnLoanTran.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnLoanTran.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLoanTran.ForeColor = System.Drawing.Color.Black
        Me.btnLoanTran.GotFocusColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(189, Byte), Integer))
        Me.btnLoanTran.Location = New System.Drawing.Point(10, 158)
        Me.btnLoanTran.LostFocusColour = System.Drawing.Color.LightYellow
        Me.btnLoanTran.Name = "btnLoanTran"
        Me.btnLoanTran.Size = New System.Drawing.Size(178, 40)
        Me.btnLoanTran.TabIndex = 8
        Me.btnLoanTran.Text = " SMTL Transaction Details"
        Me.btnLoanTran.UseVisualStyleBackColor = False
        Me.btnLoanTran.Visible = False
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.txtSearchText)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.cmbSearchBy)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Location = New System.Drawing.Point(218, 21)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(784, 48)
        Me.Panel1.TabIndex = 17
        '
        'txtSearchText
        '
        Me.txtSearchText.AlphaNumeric = True
        Me.txtSearchText.BlankSpace = True
        Me.txtSearchText.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearchText.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtSearchText.Location = New System.Drawing.Point(512, 8)
        Me.txtSearchText.LostFocusColour = System.Drawing.Color.Empty
        Me.txtSearchText.Mandatory = False
        Me.txtSearchText.MaxLength = 30
        Me.txtSearchText.Name = "txtSearchText"
        Me.txtSearchText.Size = New System.Drawing.Size(193, 23)
        Me.txtSearchText.SpecialChar = True
        Me.txtSearchText.TabIndex = 58
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(408, 8)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 16)
        Me.Label2.TabIndex = 57
        Me.Label2.Text = "Search Text :"
        '
        'cmbSearchBy
        '
        Me.cmbSearchBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbSearchBy.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbSearchBy.Items.AddRange(New Object() {"Name", "ODNumber", "Status"})
        Me.cmbSearchBy.Location = New System.Drawing.Point(136, 8)
        Me.cmbSearchBy.Name = "cmbSearchBy"
        Me.cmbSearchBy.Size = New System.Drawing.Size(184, 24)
        Me.cmbSearchBy.TabIndex = 56
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(47, 8)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(86, 16)
        Me.Label9.TabIndex = 55
        Me.Label9.Text = "Search By :"
        '
        'lvLoanList
        '
        Me.lvLoanList.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader7, Me.ColumnHeader4, Me.ColumnHeader16, Me.ColumnHeader5, Me.ColumnHeader10})
        Me.lvLoanList.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvLoanList.FullRowSelect = True
        Me.lvLoanList.GridLines = True
        Me.lvLoanList.Location = New System.Drawing.Point(218, 87)
        Me.lvLoanList.Name = "lvLoanList"
        Me.lvLoanList.Size = New System.Drawing.Size(784, 361)
        Me.lvLoanList.Sorting = System.Windows.Forms.SortOrder.Ascending
        Me.lvLoanList.TabIndex = 18
        Me.lvLoanList.UseCompatibleStateImageBehavior = False
        Me.lvLoanList.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "SMTL Number"
        Me.ColumnHeader1.Width = 106
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Name"
        Me.ColumnHeader2.Width = 221
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "SMTL Limit"
        Me.ColumnHeader7.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader7.Width = 90
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Balance"
        Me.ColumnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader4.Width = 101
        '
        'ColumnHeader16
        '
        Me.ColumnHeader16.Text = "Interest  "
        Me.ColumnHeader16.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader16.Width = 102
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Status"
        Me.ColumnHeader5.Width = 74
        '
        'ColumnHeader10
        '
        Me.ColumnHeader10.Text = "ROI"
        Me.ColumnHeader10.Width = 69
        '
        'NewButton6
        '
        Me.NewButton6.BackColor = System.Drawing.Color.LightYellow
        Me.NewButton6.Cursor = System.Windows.Forms.Cursors.Hand
        Me.NewButton6.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.NewButton6.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.NewButton6.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NewButton6.ForeColor = System.Drawing.Color.Black
        Me.NewButton6.GotFocusColour = System.Drawing.Color.IndianRed
        Me.NewButton6.Location = New System.Drawing.Point(890, 468)
        Me.NewButton6.LostFocusColour = System.Drawing.Color.LightYellow
        Me.NewButton6.Name = "NewButton6"
        Me.NewButton6.Size = New System.Drawing.Size(112, 40)
        Me.NewButton6.TabIndex = 19
        Me.NewButton6.Text = "&Close"
        Me.NewButton6.UseVisualStyleBackColor = False
        '
        'btnRefreshList
        '
        Me.btnRefreshList.BackColor = System.Drawing.Color.LightYellow
        Me.btnRefreshList.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRefreshList.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnRefreshList.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnRefreshList.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRefreshList.ForeColor = System.Drawing.Color.Black
        Me.btnRefreshList.GotFocusColour = System.Drawing.Color.IndianRed
        Me.btnRefreshList.Location = New System.Drawing.Point(759, 468)
        Me.btnRefreshList.LostFocusColour = System.Drawing.Color.LightYellow
        Me.btnRefreshList.Name = "btnRefreshList"
        Me.btnRefreshList.Size = New System.Drawing.Size(112, 40)
        Me.btnRefreshList.TabIndex = 20
        Me.btnRefreshList.Text = "&Refresh"
        Me.btnRefreshList.UseVisualStyleBackColor = False
        '
        'frmSMTLList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightYellow
        Me.ClientSize = New System.Drawing.Size(1014, 518)
        Me.Controls.Add(Me.btnRefreshList)
        Me.Controls.Add(Me.NewButton6)
        Me.Controls.Add(Me.lvLoanList)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Name = "frmSMTLList"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SMTL List"
        Me.GroupBox2.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents btnAdd As BankControls.NewButton
    Friend WithEvents NewButton1 As BankControls.NewButton
    Friend WithEvents btnLoanTran As BankControls.NewButton
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents txtSearchText As BankControls.TextControl
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cmbSearchBy As System.Windows.Forms.ComboBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents lvLoanList As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader7 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader16 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader10 As System.Windows.Forms.ColumnHeader
    Friend WithEvents NewButton6 As BankControls.NewButton
    Friend WithEvents btnRefreshList As BankControls.NewButton
End Class
