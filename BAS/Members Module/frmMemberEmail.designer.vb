<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMemberEmail
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
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.rbAllMembers = New System.Windows.Forms.RadioButton()
        Me.rbInActiveMembers = New System.Windows.Forms.RadioButton()
        Me.BtnSend = New System.Windows.Forms.Button()
        Me.GbAttachments = New System.Windows.Forms.GroupBox()
        Me.btnAddSelected = New System.Windows.Forms.Button()
        Me.lvAllMembers = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lvSelectedMembers = New System.Windows.Forms.ListView()
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.btnRemoveSelected = New System.Windows.Forms.Button()
        Me.btnRemoveAll = New System.Windows.Forms.Button()
        Me.btnAddAll = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Button1 = New System.Windows.Forms.Button()
        Me.rbActiveMembers = New System.Windows.Forms.RadioButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtBody = New System.Windows.Forms.TextBox()
        Me.txtSubject = New System.Windows.Forms.TextBox()
        Me.lblMessage = New System.Windows.Forms.Label()
        Me.DataGridViewImageColumn2 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.DataGridViewImageColumn3 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.DataGridViewImageColumn4 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.DataGridViewImageColumn1 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.ColmAttach = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.ColmFileName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColmDelete = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.dgvAttachment = New System.Windows.Forms.DataGridView()
        Me.colmAttachFile = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.colmFile = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colmDeleteFile = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.GbAttachments.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dgvAttachment, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnClose
        '
        Me.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnClose.Font = New System.Drawing.Font("Verdana", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.ForeColor = System.Drawing.Color.Red
        Me.btnClose.Location = New System.Drawing.Point(916, 575)
        Me.btnClose.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(84, 28)
        Me.btnClose.TabIndex = 9
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
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
        'rbInActiveMembers
        '
        Me.rbInActiveMembers.AutoSize = True
        Me.rbInActiveMembers.Location = New System.Drawing.Point(305, 12)
        Me.rbInActiveMembers.Name = "rbInActiveMembers"
        Me.rbInActiveMembers.Size = New System.Drawing.Size(137, 18)
        Me.rbInActiveMembers.TabIndex = 2
        Me.rbInActiveMembers.Text = "Inactive members"
        Me.rbInActiveMembers.UseVisualStyleBackColor = True
        '
        'BtnSend
        '
        Me.BtnSend.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSend.ForeColor = System.Drawing.Color.Green
        Me.BtnSend.Location = New System.Drawing.Point(828, 575)
        Me.BtnSend.Name = "BtnSend"
        Me.BtnSend.Size = New System.Drawing.Size(75, 28)
        Me.BtnSend.TabIndex = 6
        Me.BtnSend.Text = "Send"
        Me.BtnSend.UseVisualStyleBackColor = True
        '
        'GbAttachments
        '
        Me.GbAttachments.Controls.Add(Me.dgvAttachment)
        Me.GbAttachments.Location = New System.Drawing.Point(6, 414)
        Me.GbAttachments.Name = "GbAttachments"
        Me.GbAttachments.Size = New System.Drawing.Size(436, 155)
        Me.GbAttachments.TabIndex = 4
        Me.GbAttachments.TabStop = False
        Me.GbAttachments.Text = "Attachments"
        '
        'btnAddSelected
        '
        Me.btnAddSelected.Font = New System.Drawing.Font("Verdana", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddSelected.Location = New System.Drawing.Point(451, 139)
        Me.btnAddSelected.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnAddSelected.Name = "btnAddSelected"
        Me.btnAddSelected.Size = New System.Drawing.Size(108, 29)
        Me.btnAddSelected.TabIndex = 3
        Me.btnAddSelected.Text = "Add"
        Me.btnAddSelected.UseVisualStyleBackColor = True
        '
        'lvAllMembers
        '
        Me.lvAllMembers.AllowColumnReorder = True
        Me.lvAllMembers.BackColor = System.Drawing.Color.GhostWhite
        Me.lvAllMembers.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lvAllMembers.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader5})
        Me.lvAllMembers.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvAllMembers.FullRowSelect = True
        Me.lvAllMembers.GridLines = True
        Me.lvAllMembers.HideSelection = False
        Me.lvAllMembers.Location = New System.Drawing.Point(22, 49)
        Me.lvAllMembers.Name = "lvAllMembers"
        Me.lvAllMembers.ShowItemToolTips = True
        Me.lvAllMembers.Size = New System.Drawing.Size(413, 317)
        Me.lvAllMembers.Sorting = System.Windows.Forms.SortOrder.Ascending
        Me.lvAllMembers.TabIndex = 1
        Me.lvAllMembers.UseCompatibleStateImageBehavior = False
        Me.lvAllMembers.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Member No"
        Me.ColumnHeader1.Width = 90
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Name"
        Me.ColumnHeader2.Width = 155
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Email id"
        Me.ColumnHeader5.Width = 163
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
        Me.GroupBox1.Location = New System.Drawing.Point(7, 36)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.GroupBox1.Size = New System.Drawing.Size(1008, 372)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Member List"
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(451, 312)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(107, 18)
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
        Me.lvSelectedMembers.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader6})
        Me.lvSelectedMembers.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvSelectedMembers.FullRowSelect = True
        Me.lvSelectedMembers.GridLines = True
        Me.lvSelectedMembers.HideSelection = False
        Me.lvSelectedMembers.Location = New System.Drawing.Point(570, 49)
        Me.lvSelectedMembers.Name = "lvSelectedMembers"
        Me.lvSelectedMembers.Size = New System.Drawing.Size(422, 317)
        Me.lvSelectedMembers.Sorting = System.Windows.Forms.SortOrder.Ascending
        Me.lvSelectedMembers.TabIndex = 4
        Me.lvSelectedMembers.UseCompatibleStateImageBehavior = False
        Me.lvSelectedMembers.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Member No"
        Me.ColumnHeader3.Width = 90
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Name"
        Me.ColumnHeader4.Width = 155
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Email id"
        Me.ColumnHeader6.Width = 173
        '
        'btnRemoveSelected
        '
        Me.btnRemoveSelected.Font = New System.Drawing.Font("Verdana", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRemoveSelected.Location = New System.Drawing.Point(451, 191)
        Me.btnRemoveSelected.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnRemoveSelected.Name = "btnRemoveSelected"
        Me.btnRemoveSelected.Size = New System.Drawing.Size(108, 33)
        Me.btnRemoveSelected.TabIndex = 6
        Me.btnRemoveSelected.Text = "Remove"
        Me.btnRemoveSelected.UseVisualStyleBackColor = True
        '
        'btnRemoveAll
        '
        Me.btnRemoveAll.Font = New System.Drawing.Font("Verdana", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRemoveAll.Location = New System.Drawing.Point(451, 252)
        Me.btnRemoveAll.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnRemoveAll.Name = "btnRemoveAll"
        Me.btnRemoveAll.Size = New System.Drawing.Size(108, 32)
        Me.btnRemoveAll.TabIndex = 7
        Me.btnRemoveAll.Text = "Remove all"
        Me.btnRemoveAll.UseVisualStyleBackColor = True
        '
        'btnAddAll
        '
        Me.btnAddAll.Font = New System.Drawing.Font("Verdana", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddAll.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnAddAll.Location = New System.Drawing.Point(451, 84)
        Me.btnAddAll.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnAddAll.Name = "btnAddAll"
        Me.btnAddAll.Size = New System.Drawing.Size(108, 35)
        Me.btnAddAll.TabIndex = 2
        Me.btnAddAll.Text = "Add all "
        Me.ToolTip1.SetToolTip(Me.btnAddAll, "Click to add all members")
        Me.btnAddAll.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(328, 580)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(104, 23)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "Delete All"
        Me.ToolTip1.SetToolTip(Me.Button1, "Click to delete All attachments")
        Me.Button1.UseVisualStyleBackColor = True
        '
        'rbActiveMembers
        '
        Me.rbActiveMembers.AutoSize = True
        Me.rbActiveMembers.Location = New System.Drawing.Point(150, 12)
        Me.rbActiveMembers.Name = "rbActiveMembers"
        Me.rbActiveMembers.Size = New System.Drawing.Size(124, 18)
        Me.rbActiveMembers.TabIndex = 1
        Me.rbActiveMembers.Text = "Active members"
        Me.rbActiveMembers.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.txtBody)
        Me.GroupBox2.Controls.Add(Me.txtSubject)
        Me.GroupBox2.Location = New System.Drawing.Point(448, 414)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(567, 155)
        Me.GroupBox2.TabIndex = 5
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Email Details"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(22, 67)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(40, 14)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Body"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(7, 28)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(57, 14)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Subject"
        '
        'txtBody
        '
        Me.txtBody.Location = New System.Drawing.Point(70, 64)
        Me.txtBody.Multiline = True
        Me.txtBody.Name = "txtBody"
        Me.txtBody.Size = New System.Drawing.Size(481, 85)
        Me.txtBody.TabIndex = 3
        '
        'txtSubject
        '
        Me.txtSubject.Location = New System.Drawing.Point(70, 24)
        Me.txtSubject.Multiline = True
        Me.txtSubject.Name = "txtSubject"
        Me.txtSubject.Size = New System.Drawing.Size(481, 34)
        Me.txtSubject.TabIndex = 1
        '
        'lblMessage
        '
        Me.lblMessage.AutoSize = True
        Me.lblMessage.Location = New System.Drawing.Point(515, 592)
        Me.lblMessage.Name = "lblMessage"
        Me.lblMessage.Size = New System.Drawing.Size(39, 14)
        Me.lblMessage.TabIndex = 8
        Me.lblMessage.Text = "        "
        '
        'DataGridViewImageColumn2
        '
        Me.DataGridViewImageColumn2.HeaderText = "Attach"
        Me.DataGridViewImageColumn2.Name = "DataGridViewImageColumn2"
        Me.DataGridViewImageColumn2.Width = 70
        '
        'DataGridViewImageColumn3
        '
        Me.DataGridViewImageColumn3.HeaderText = "Delete"
        Me.DataGridViewImageColumn3.Name = "DataGridViewImageColumn3"
        '
        'DataGridViewImageColumn4
        '
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.DataGridViewImageColumn4.DefaultCellStyle = DataGridViewCellStyle8
        Me.DataGridViewImageColumn4.HeaderText = "Delete"
        Me.DataGridViewImageColumn4.Image = Global.BAS.Resources.WRONG
        Me.DataGridViewImageColumn4.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom
        Me.DataGridViewImageColumn4.Name = "DataGridViewImageColumn4"
        Me.DataGridViewImageColumn4.ToolTipText = "Click to delete the attachment"
        Me.DataGridViewImageColumn4.Width = 105
        '
        'DataGridViewImageColumn1
        '
        Me.DataGridViewImageColumn1.HeaderText = "Delete"
        Me.DataGridViewImageColumn1.Name = "DataGridViewImageColumn1"
        Me.DataGridViewImageColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewImageColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.DataGridViewImageColumn1.Width = 65
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'ColmAttach
        '
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle9.NullValue = "Attach"
        Me.ColmAttach.DefaultCellStyle = DataGridViewCellStyle9
        Me.ColmAttach.HeaderText = "Attach"
        Me.ColmAttach.Name = "ColmAttach"
        Me.ColmAttach.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.ColmAttach.ToolTipText = "Click to attach a file "
        Me.ColmAttach.Width = 80
        '
        'BackgroundWorker1
        '
        Me.BackgroundWorker1.WorkerReportsProgress = True
        Me.BackgroundWorker1.WorkerSupportsCancellation = True
        '
        'ColmFileName
        '
        Me.ColmFileName.HeaderText = "File Name"
        Me.ColmFileName.Name = "ColmFileName"
        Me.ColmFileName.ToolTipText = "Click to attach a file"
        Me.ColmFileName.Width = 185
        '
        'ColmDelete
        '
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle10.NullValue = "Delete"
        Me.ColmDelete.DefaultCellStyle = DataGridViewCellStyle10
        Me.ColmDelete.HeaderText = "Delete"
        Me.ColmDelete.Name = "ColmDelete"
        Me.ColmDelete.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.ColmDelete.Text = "Delete"
        Me.ColmDelete.ToolTipText = "Click to delete the attachment"
        Me.ColmDelete.Width = 105
        '
        'dgvAttachment
        '
        Me.dgvAttachment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvAttachment.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colmAttachFile, Me.colmFile, Me.colmDeleteFile})
        Me.dgvAttachment.Location = New System.Drawing.Point(23, 21)
        Me.dgvAttachment.Name = "dgvAttachment"
        Me.dgvAttachment.Size = New System.Drawing.Size(403, 128)
        Me.dgvAttachment.TabIndex = 0
        '
        'colmAttachFile
        '
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle6.NullValue = "Attach"
        Me.colmAttachFile.DefaultCellStyle = DataGridViewCellStyle6
        Me.colmAttachFile.HeaderText = "Attach"
        Me.colmAttachFile.Name = "colmAttachFile"
        Me.colmAttachFile.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.colmAttachFile.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.colmAttachFile.Text = "Attach"
        Me.colmAttachFile.ToolTipText = "Click to attach a file "
        Me.colmAttachFile.Width = 60
        '
        'colmFile
        '
        Me.colmFile.HeaderText = "File Name"
        Me.colmFile.Name = "colmFile"
        Me.colmFile.ToolTipText = "Click to attach a file"
        Me.colmFile.Width = 240
        '
        'colmDeleteFile
        '
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle7.NullValue = "Delete"
        Me.colmDeleteFile.DefaultCellStyle = DataGridViewCellStyle7
        Me.colmDeleteFile.HeaderText = "Delete"
        Me.colmDeleteFile.Name = "colmDeleteFile"
        Me.colmDeleteFile.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.colmDeleteFile.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.colmDeleteFile.Text = "Delete"
        Me.colmDeleteFile.ToolTipText = "Click to delete a file "
        Me.colmDeleteFile.Width = 60
        '
        'frmMemberEmail
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.GhostWhite
        Me.CancelButton = Me.btnClose
        Me.ClientSize = New System.Drawing.Size(1028, 615)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.lblMessage)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GbAttachments)
        Me.Controls.Add(Me.BtnSend)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.rbInActiveMembers)
        Me.Controls.Add(Me.rbActiveMembers)
        Me.Controls.Add(Me.rbAllMembers)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Name = "frmMemberEmail"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Send Email To Members"
        Me.GbAttachments.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.dgvAttachment, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents rbAllMembers As System.Windows.Forms.RadioButton
    Friend WithEvents rbInActiveMembers As System.Windows.Forms.RadioButton
    Friend WithEvents BtnSend As System.Windows.Forms.Button
    Friend WithEvents GbAttachments As System.Windows.Forms.GroupBox
    Friend WithEvents btnAddSelected As System.Windows.Forms.Button
    Friend WithEvents lvAllMembers As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lvSelectedMembers As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader6 As System.Windows.Forms.ColumnHeader
    Friend WithEvents btnRemoveSelected As System.Windows.Forms.Button
    Friend WithEvents btnRemoveAll As System.Windows.Forms.Button
    Friend WithEvents btnAddAll As System.Windows.Forms.Button
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents rbActiveMembers As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtBody As System.Windows.Forms.TextBox
    Friend WithEvents txtSubject As System.Windows.Forms.TextBox
    Friend WithEvents lblMessage As System.Windows.Forms.Label
    Friend WithEvents DataGridViewImageColumn2 As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents DataGridViewImageColumn3 As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents DataGridViewImageColumn4 As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents DataGridViewImageColumn1 As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents ColmAttach As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents ColmFileName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColmDelete As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents dgvAttachment As System.Windows.Forms.DataGridView
    Friend WithEvents colmAttachFile As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents colmFile As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colmDeleteFile As System.Windows.Forms.DataGridViewButtonColumn
End Class
