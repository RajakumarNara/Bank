<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmFdMaturedList
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmFdMaturedList))
        Me.lvFDs = New System.Windows.Forms.ListView
        Me.ColumnHeader1 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader2 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader3 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader4 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader7 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader8 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader6 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader9 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader12 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader13 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader14 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader10 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader11 = New System.Windows.Forms.ColumnHeader
        Me.btnAddFD = New BankControls.NewButton
        Me.btnClose = New BankControls.NewButton
        Me.NewButton1 = New BankControls.NewButton
        Me.SuspendLayout()
        '
        'lvFDs
        '
        Me.lvFDs.AllowColumnReorder = True
        Me.lvFDs.BackColor = System.Drawing.Color.FromArgb(CType(CType(218, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.lvFDs.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lvFDs.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader7, Me.ColumnHeader8, Me.ColumnHeader6, Me.ColumnHeader9, Me.ColumnHeader12, Me.ColumnHeader13, Me.ColumnHeader14, Me.ColumnHeader10, Me.ColumnHeader11})
        Me.lvFDs.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvFDs.FullRowSelect = True
        Me.lvFDs.GridLines = True
        Me.lvFDs.HideSelection = False
        Me.lvFDs.Location = New System.Drawing.Point(12, 17)
        Me.lvFDs.MultiSelect = False
        Me.lvFDs.Name = "lvFDs"
        Me.lvFDs.Size = New System.Drawing.Size(1040, 408)
        Me.lvFDs.Sorting = System.Windows.Forms.SortOrder.Ascending
        Me.lvFDs.TabIndex = 5
        Me.lvFDs.UseCompatibleStateImageBehavior = False
        Me.lvFDs.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Account No"
        Me.ColumnHeader1.Width = 81
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Name"
        Me.ColumnHeader2.Width = 206
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Date"
        Me.ColumnHeader3.Width = 80
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Amount"
        Me.ColumnHeader4.Width = 70
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "ROI"
        '
        'ColumnHeader8
        '
        Me.ColumnHeader8.Text = "Years"
        Me.ColumnHeader8.Width = 50
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Months"
        Me.ColumnHeader6.Width = 50
        '
        'ColumnHeader9
        '
        Me.ColumnHeader9.Text = "Days"
        Me.ColumnHeader9.Width = 50
        '
        'ColumnHeader12
        '
        Me.ColumnHeader12.Text = "Mat Date"
        Me.ColumnHeader12.Width = 90
        '
        'ColumnHeader13
        '
        Me.ColumnHeader13.Text = "Int Amount"
        Me.ColumnHeader13.Width = 70
        '
        'ColumnHeader14
        '
        Me.ColumnHeader14.Text = "Mat Amount"
        Me.ColumnHeader14.Width = 70
        '
        'ColumnHeader10
        '
        Me.ColumnHeader10.Text = "Status"
        '
        'ColumnHeader11
        '
        Me.ColumnHeader11.Text = "Remarks"
        Me.ColumnHeader11.Width = 100
        '
        'btnAddFD
        '
        Me.btnAddFD.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAddFD.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnAddFD.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddFD.ForeColor = System.Drawing.Color.Black
        Me.btnAddFD.GotFocusColour = System.Drawing.Color.FromArgb(CType(CType(123, Byte), Integer), CType(CType(202, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnAddFD.Image = CType(resources.GetObject("btnAddFD.Image"), System.Drawing.Image)
        Me.btnAddFD.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAddFD.Location = New System.Drawing.Point(12, 450)
        Me.btnAddFD.LostFocusColour = System.Drawing.Color.FromArgb(CType(CType(176, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.btnAddFD.Name = "btnAddFD"
        Me.btnAddFD.Size = New System.Drawing.Size(121, 40)
        Me.btnAddFD.TabIndex = 8
        Me.btnAddFD.Text = "Fd Renewal"
        Me.btnAddFD.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnClose
        '
        Me.btnClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnClose.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.GotFocusColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnClose.Image = CType(resources.GetObject("btnClose.Image"), System.Drawing.Image)
        Me.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnClose.Location = New System.Drawing.Point(948, 450)
        Me.btnClose.LostFocusColour = System.Drawing.Color.FromArgb(CType(CType(176, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(104, 40)
        Me.btnClose.TabIndex = 7
        Me.btnClose.Text = "&Close"
        '
        'NewButton1
        '
        Me.NewButton1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.NewButton1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.NewButton1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NewButton1.ForeColor = System.Drawing.Color.Black
        Me.NewButton1.GotFocusColour = System.Drawing.Color.FromArgb(CType(CType(123, Byte), Integer), CType(CType(202, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.NewButton1.Image = CType(resources.GetObject("NewButton1.Image"), System.Drawing.Image)
        Me.NewButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.NewButton1.Location = New System.Drawing.Point(165, 450)
        Me.NewButton1.LostFocusColour = System.Drawing.Color.FromArgb(CType(CType(176, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.NewButton1.Name = "NewButton1"
        Me.NewButton1.Size = New System.Drawing.Size(109, 40)
        Me.NewButton1.TabIndex = 9
        Me.NewButton1.Text = "Fd Closure"
        Me.NewButton1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'FrmFdMaturedList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1061, 518)
        Me.Controls.Add(Me.NewButton1)
        Me.Controls.Add(Me.btnAddFD)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.lvFDs)
        Me.Name = "FrmFdMaturedList"
        Me.Text = "Matured FD List"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lvFDs As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader7 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader8 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader6 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader9 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader12 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader13 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader14 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader10 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader11 As System.Windows.Forms.ColumnHeader
    Friend WithEvents btnAddFD As BankControls.NewButton
    Friend WithEvents btnClose As BankControls.NewButton
    Friend WithEvents NewButton1 As BankControls.NewButton
End Class
