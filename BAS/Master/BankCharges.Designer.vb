<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBankCharges
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmBankCharges))
        Me.cmbParticulars = New System.Windows.Forms.ComboBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label32 = New System.Windows.Forms.Label
        Me.btnOk = New BankControls.NewButton
        Me.btnCancel = New BankControls.NewButton
        Me.btnAdd = New BankControls.NewButton
        Me.txtAmount = New BankControls.NumericControl
        Me.txtCharges = New BankControls.NumericControl
        Me.txtSchemeCode = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.lvBankCharges = New System.Windows.Forms.ListView
        Me.OccupationCode = New System.Windows.Forms.ColumnHeader
        Me.OccupationName = New System.Windows.Forms.ColumnHeader
        Me.ShortName = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader1 = New System.Windows.Forms.ColumnHeader
        Me.Label5 = New System.Windows.Forms.Label
        Me.cmbComparision = New System.Windows.Forms.ComboBox
        Me.ColumnHeader2 = New System.Windows.Forms.ColumnHeader
        Me.SuspendLayout()
        '
        'cmbParticulars
        '
        Me.cmbParticulars.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbParticulars.FormattingEnabled = True
        Me.cmbParticulars.Items.AddRange(New Object() {"Building fund", "Document", "Loan processing ", "Secured deposit"})
        Me.cmbParticulars.Location = New System.Drawing.Point(16, 78)
        Me.cmbParticulars.Name = "cmbParticulars"
        Me.cmbParticulars.Size = New System.Drawing.Size(142, 24)
        Me.cmbParticulars.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(13, 53)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(83, 16)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Particulars:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Image = CType(resources.GetObject("Label2.Image"), System.Drawing.Image)
        Me.Label2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label2.Location = New System.Drawing.Point(378, 54)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(73, 16)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Amount   "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Image = CType(resources.GetObject("Label3.Image"), System.Drawing.Image)
        Me.Label3.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label3.Location = New System.Drawing.Point(476, 54)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(76, 16)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Charges   "
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.BackColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(176, Byte), Integer))
        Me.Label32.Font = New System.Drawing.Font("Georgia", 14.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label32.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label32.Location = New System.Drawing.Point(12, 9)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(262, 23)
        Me.Label32.TabIndex = 142
        Me.Label32.Text = " Bank Charges Master Setting"
        Me.Label32.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnOk
        '
        Me.btnOk.BackColor = System.Drawing.Color.LightYellow
        Me.btnOk.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnOk.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnOk.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOk.ForeColor = System.Drawing.Color.Black
        Me.btnOk.GotFocusColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(189, Byte), Integer))
        Me.btnOk.Location = New System.Drawing.Point(411, 122)
        Me.btnOk.LostFocusColour = System.Drawing.Color.LightYellow
        Me.btnOk.Name = "btnOk"
        Me.btnOk.Size = New System.Drawing.Size(64, 27)
        Me.btnOk.TabIndex = 143
        Me.btnOk.Text = "&Save"
        Me.btnOk.UseVisualStyleBackColor = False
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.LightYellow
        Me.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnCancel.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.ForeColor = System.Drawing.Color.Black
        Me.btnCancel.GotFocusColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(189, Byte), Integer))
        Me.btnCancel.Location = New System.Drawing.Point(481, 122)
        Me.btnCancel.LostFocusColour = System.Drawing.Color.LightYellow
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(64, 27)
        Me.btnCancel.TabIndex = 144
        Me.btnCancel.Text = "&Cancel"
        Me.btnCancel.UseVisualStyleBackColor = False
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
        Me.btnAdd.Location = New System.Drawing.Point(324, 122)
        Me.btnAdd.LostFocusColour = System.Drawing.Color.LightYellow
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(81, 27)
        Me.btnAdd.TabIndex = 145
        Me.btnAdd.Text = "&Reset"
        Me.btnAdd.UseVisualStyleBackColor = False
        '
        'txtAmount
        '
        Me.txtAmount.AfterDecimal = 0
        Me.txtAmount.BeforeDecimal = 8
        Me.txtAmount.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAmount.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtAmount.Location = New System.Drawing.Point(374, 78)
        Me.txtAmount.LostFocusColour = System.Drawing.SystemColors.Window
        Me.txtAmount.MaxLength = 10
        Me.txtAmount.MaxValue = 0
        Me.txtAmount.MinValue = 0
        Me.txtAmount.Name = "txtAmount"
        Me.txtAmount.Size = New System.Drawing.Size(101, 23)
        Me.txtAmount.TabIndex = 146
        '
        'txtCharges
        '
        Me.txtCharges.AfterDecimal = 0
        Me.txtCharges.BeforeDecimal = 7
        Me.txtCharges.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCharges.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtCharges.Location = New System.Drawing.Point(476, 77)
        Me.txtCharges.LostFocusColour = System.Drawing.SystemColors.Window
        Me.txtCharges.MaxLength = 10
        Me.txtCharges.MaxValue = 0
        Me.txtCharges.MinValue = 0
        Me.txtCharges.Name = "txtCharges"
        Me.txtCharges.Size = New System.Drawing.Size(68, 23)
        Me.txtCharges.TabIndex = 147
        '
        'txtSchemeCode
        '
        Me.txtSchemeCode.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSchemeCode.Location = New System.Drawing.Point(286, 28)
        Me.txtSchemeCode.Name = "txtSchemeCode"
        Me.txtSchemeCode.Size = New System.Drawing.Size(100, 23)
        Me.txtSchemeCode.TabIndex = 148
        Me.txtSchemeCode.Visible = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(282, 9)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(104, 16)
        Me.Label4.TabIndex = 149
        Me.Label4.Text = "Scheme Code:"
        Me.Label4.Visible = False
        '
        'lvBankCharges
        '
        Me.lvBankCharges.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.OccupationCode, Me.OccupationName, Me.ShortName, Me.ColumnHeader1, Me.ColumnHeader2})
        Me.lvBankCharges.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvBankCharges.FullRowSelect = True
        Me.lvBankCharges.GridLines = True
        Me.lvBankCharges.Location = New System.Drawing.Point(6, 162)
        Me.lvBankCharges.Name = "lvBankCharges"
        Me.lvBankCharges.Size = New System.Drawing.Size(544, 349)
        Me.lvBankCharges.TabIndex = 150
        Me.lvBankCharges.UseCompatibleStateImageBehavior = False
        Me.lvBankCharges.View = System.Windows.Forms.View.Details
        '
        'OccupationCode
        '
        Me.OccupationCode.Tag = "Particular"
        Me.OccupationCode.Text = "Code"
        Me.OccupationCode.Width = 1
        '
        'OccupationName
        '
        Me.OccupationName.Tag = "Amount"
        Me.OccupationName.Text = "Particular"
        Me.OccupationName.Width = 160
        '
        'ShortName
        '
        Me.ShortName.Tag = "Charges"
        Me.ShortName.Text = "Comparision"
        Me.ShortName.Width = 200
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Amount"
        Me.ColumnHeader1.Width = 100
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(162, 53)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(92, 16)
        Me.Label5.TabIndex = 152
        Me.Label5.Text = "Comparision:"
        '
        'cmbComparision
        '
        Me.cmbComparision.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbComparision.FormattingEnabled = True
        Me.cmbComparision.Items.AddRange(New Object() {"Equal to", "Less than", "Less than or equal to ", "Greater than", "Greater than or equal to"})
        Me.cmbComparision.Location = New System.Drawing.Point(159, 78)
        Me.cmbComparision.Name = "cmbComparision"
        Me.cmbComparision.Size = New System.Drawing.Size(215, 24)
        Me.cmbComparision.TabIndex = 151
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Charges"
        Me.ColumnHeader2.Width = 80
        '
        'frmBankCharges
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(556, 518)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.cmbComparision)
        Me.Controls.Add(Me.lvBankCharges)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtSchemeCode)
        Me.Controls.Add(Me.txtCharges)
        Me.Controls.Add(Me.txtAmount)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.btnOk)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.Label32)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmbParticulars)
        Me.Name = "frmBankCharges"
        Me.Text = "BankChargesForLoan"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmbParticulars As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label32 As System.Windows.Forms.Label
    Friend WithEvents btnOk As BankControls.NewButton
    Friend WithEvents btnCancel As BankControls.NewButton
    Friend WithEvents btnAdd As BankControls.NewButton
    Friend WithEvents txtAmount As BankControls.NumericControl
    Friend WithEvents txtCharges As BankControls.NumericControl
    Friend WithEvents txtSchemeCode As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lvBankCharges As System.Windows.Forms.ListView
    Friend WithEvents OccupationCode As System.Windows.Forms.ColumnHeader
    Friend WithEvents OccupationName As System.Windows.Forms.ColumnHeader
    Friend WithEvents ShortName As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cmbComparision As System.Windows.Forms.ComboBox
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
End Class
