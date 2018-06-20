<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMemberAddressPrinting
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
        Me.btnAddAll = New System.Windows.Forms.Button
        Me.btnAddSelected = New System.Windows.Forms.Button
        Me.btnRemoveAll = New System.Windows.Forms.Button
        Me.btnRemoveSelected = New System.Windows.Forms.Button
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.lvSelectedMembers = New System.Windows.Forms.ListView
        Me.ColumnHeader3 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader4 = New System.Windows.Forms.ColumnHeader
        Me.lvAllMembers = New System.Windows.Forms.ListView
        Me.ColumnHeader1 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader2 = New System.Windows.Forms.ColumnHeader
        Me.rbAllMembers = New System.Windows.Forms.RadioButton
        Me.rbActiveMembers = New System.Windows.Forms.RadioButton
        Me.rbInActiveMembers = New System.Windows.Forms.RadioButton
        Me.btnPrintPreview = New System.Windows.Forms.Button
        Me.btnPrint = New System.Windows.Forms.Button
        Me.btnClose = New System.Windows.Forms.Button
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnAddAll
        '
        Me.btnAddAll.Font = New System.Drawing.Font("Verdana", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddAll.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnAddAll.Location = New System.Drawing.Point(448, 84)
        Me.btnAddAll.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnAddAll.Name = "btnAddAll"
        Me.btnAddAll.Size = New System.Drawing.Size(129, 45)
        Me.btnAddAll.TabIndex = 2
        Me.btnAddAll.Text = "Add all "
        Me.btnAddAll.UseVisualStyleBackColor = True
        '
        'btnAddSelected
        '
        Me.btnAddSelected.Font = New System.Drawing.Font("Verdana", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddSelected.Location = New System.Drawing.Point(448, 159)
        Me.btnAddSelected.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnAddSelected.Name = "btnAddSelected"
        Me.btnAddSelected.Size = New System.Drawing.Size(129, 45)
        Me.btnAddSelected.TabIndex = 3
        Me.btnAddSelected.Text = "Add"
        Me.btnAddSelected.UseVisualStyleBackColor = True
        '
        'btnRemoveAll
        '
        Me.btnRemoveAll.Font = New System.Drawing.Font("Verdana", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRemoveAll.Location = New System.Drawing.Point(448, 298)
        Me.btnRemoveAll.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnRemoveAll.Name = "btnRemoveAll"
        Me.btnRemoveAll.Size = New System.Drawing.Size(129, 45)
        Me.btnRemoveAll.TabIndex = 7
        Me.btnRemoveAll.Text = "Remove all"
        Me.btnRemoveAll.UseVisualStyleBackColor = True
        '
        'btnRemoveSelected
        '
        Me.btnRemoveSelected.Font = New System.Drawing.Font("Verdana", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRemoveSelected.Location = New System.Drawing.Point(448, 230)
        Me.btnRemoveSelected.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnRemoveSelected.Name = "btnRemoveSelected"
        Me.btnRemoveSelected.Size = New System.Drawing.Size(129, 45)
        Me.btnRemoveSelected.TabIndex = 6
        Me.btnRemoveSelected.Text = "Remove"
        Me.btnRemoveSelected.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.GhostWhite
        Me.GroupBox1.Controls.Add(Me.ProgressBar1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.lvSelectedMembers)
        Me.GroupBox1.Controls.Add(Me.lvAllMembers)
        Me.GroupBox1.Controls.Add(Me.btnRemoveSelected)
        Me.GroupBox1.Controls.Add(Me.btnRemoveAll)
        Me.GroupBox1.Controls.Add(Me.btnAddAll)
        Me.GroupBox1.Controls.Add(Me.btnAddSelected)
        Me.GroupBox1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(16, 120)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.GroupBox1.Size = New System.Drawing.Size(1008, 432)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Member List"
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(22, 396)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(966, 23)
        Me.ProgressBar1.TabIndex = 8
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(716, 30)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(153, 14)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Selected members list"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(132, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(113, 14)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "All members list"
        '
        'lvSelectedMembers
        '
        Me.lvSelectedMembers.AllowColumnReorder = True
        Me.lvSelectedMembers.BackColor = System.Drawing.Color.GhostWhite
        Me.lvSelectedMembers.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lvSelectedMembers.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader3, Me.ColumnHeader4})
        Me.lvSelectedMembers.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvSelectedMembers.FullRowSelect = True
        Me.lvSelectedMembers.GridLines = True
        Me.lvSelectedMembers.HideSelection = False
        Me.lvSelectedMembers.Location = New System.Drawing.Point(610, 49)
        Me.lvSelectedMembers.Name = "lvSelectedMembers"
        Me.lvSelectedMembers.Size = New System.Drawing.Size(378, 329)
        Me.lvSelectedMembers.Sorting = System.Windows.Forms.SortOrder.Ascending
        Me.lvSelectedMembers.TabIndex = 4
        Me.lvSelectedMembers.UseCompatibleStateImageBehavior = False
        Me.lvSelectedMembers.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Member No"
        Me.ColumnHeader3.Width = 95
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Name"
        Me.ColumnHeader4.Width = 260
        '
        'lvAllMembers
        '
        Me.lvAllMembers.AllowColumnReorder = True
        Me.lvAllMembers.BackColor = System.Drawing.Color.GhostWhite
        Me.lvAllMembers.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lvAllMembers.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2})
        Me.lvAllMembers.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvAllMembers.FullRowSelect = True
        Me.lvAllMembers.GridLines = True
        Me.lvAllMembers.HideSelection = False
        Me.lvAllMembers.Location = New System.Drawing.Point(22, 49)
        Me.lvAllMembers.Name = "lvAllMembers"
        Me.lvAllMembers.Size = New System.Drawing.Size(391, 329)
        Me.lvAllMembers.Sorting = System.Windows.Forms.SortOrder.Ascending
        Me.lvAllMembers.TabIndex = 1
        Me.lvAllMembers.UseCompatibleStateImageBehavior = False
        Me.lvAllMembers.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Member No"
        Me.ColumnHeader1.Width = 95
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Name"
        Me.ColumnHeader2.Width = 260
        '
        'rbAllMembers
        '
        Me.rbAllMembers.AutoSize = True
        Me.rbAllMembers.Checked = True
        Me.rbAllMembers.Location = New System.Drawing.Point(29, 12)
        Me.rbAllMembers.Name = "rbAllMembers"
        Me.rbAllMembers.Size = New System.Drawing.Size(101, 18)
        Me.rbAllMembers.TabIndex = 0
        Me.rbAllMembers.TabStop = True
        Me.rbAllMembers.Text = "All members"
        Me.rbAllMembers.UseVisualStyleBackColor = True
        '
        'rbActiveMembers
        '
        Me.rbActiveMembers.AutoSize = True
        Me.rbActiveMembers.Location = New System.Drawing.Point(62, 51)
        Me.rbActiveMembers.Name = "rbActiveMembers"
        Me.rbActiveMembers.Size = New System.Drawing.Size(124, 18)
        Me.rbActiveMembers.TabIndex = 1
        Me.rbActiveMembers.Text = "Active members"
        Me.rbActiveMembers.UseVisualStyleBackColor = True
        '
        'rbInActiveMembers
        '
        Me.rbInActiveMembers.AutoSize = True
        Me.rbInActiveMembers.Location = New System.Drawing.Point(98, 88)
        Me.rbInActiveMembers.Name = "rbInActiveMembers"
        Me.rbInActiveMembers.Size = New System.Drawing.Size(137, 18)
        Me.rbInActiveMembers.TabIndex = 2
        Me.rbInActiveMembers.Text = "Inactive members"
        Me.rbInActiveMembers.UseVisualStyleBackColor = True
        '
        'btnPrintPreview
        '
        Me.btnPrintPreview.Font = New System.Drawing.Font("Verdana", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrintPreview.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnPrintPreview.Location = New System.Drawing.Point(276, 558)
        Me.btnPrintPreview.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnPrintPreview.Name = "btnPrintPreview"
        Me.btnPrintPreview.Size = New System.Drawing.Size(129, 45)
        Me.btnPrintPreview.TabIndex = 4
        Me.btnPrintPreview.Text = "Preview"
        Me.btnPrintPreview.UseVisualStyleBackColor = True
        '
        'btnPrint
        '
        Me.btnPrint.BackgroundImage = Global.BAS.Resources.printer
        Me.btnPrint.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnPrint.Font = New System.Drawing.Font("Verdana", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrint.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnPrint.Location = New System.Drawing.Point(462, 558)
        Me.btnPrint.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(129, 45)
        Me.btnPrint.TabIndex = 5
        Me.btnPrint.Text = "Print"
        Me.btnPrint.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.BackgroundImage = Global.BAS.Resources.actionCancel
        Me.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnClose.Font = New System.Drawing.Font("Verdana", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnClose.Location = New System.Drawing.Point(635, 558)
        Me.btnClose.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(129, 45)
        Me.btnClose.TabIndex = 6
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'BackgroundWorker1
        '
        Me.BackgroundWorker1.WorkerReportsProgress = True
        Me.BackgroundWorker1.WorkerSupportsCancellation = True
        '
        'frmMemberAddressPrinting
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.GhostWhite
        Me.ClientSize = New System.Drawing.Size(1041, 615)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnPrint)
        Me.Controls.Add(Me.btnPrintPreview)
        Me.Controls.Add(Me.rbInActiveMembers)
        Me.Controls.Add(Me.rbActiveMembers)
        Me.Controls.Add(Me.rbAllMembers)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Name = "frmMemberAddressPrinting"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Member Address Printing"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnAddAll As System.Windows.Forms.Button
    Friend WithEvents btnAddSelected As System.Windows.Forms.Button
    Friend WithEvents btnRemoveAll As System.Windows.Forms.Button
    Friend WithEvents btnRemoveSelected As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents rbAllMembers As System.Windows.Forms.RadioButton
    Friend WithEvents rbActiveMembers As System.Windows.Forms.RadioButton
    Friend WithEvents rbInActiveMembers As System.Windows.Forms.RadioButton
    Friend WithEvents btnPrintPreview As System.Windows.Forms.Button
    Friend WithEvents btnPrint As System.Windows.Forms.Button
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents lvAllMembers As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents lvSelectedMembers As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
End Class
