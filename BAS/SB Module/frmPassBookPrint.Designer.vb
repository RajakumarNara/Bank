<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPassBookPrint
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPassBookPrint))
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.btnPassSheetPrint = New BankControls.NewButton
        Me.DTPFrom = New System.Windows.Forms.DateTimePicker
        Me.DTPTo = New System.Windows.Forms.DateTimePicker
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtFatherName = New System.Windows.Forms.TextBox
        Me.label6 = New System.Windows.Forms.Label
        Me.txtAccountNo = New System.Windows.Forms.TextBox
        Me.groupBox4 = New System.Windows.Forms.GroupBox
        Me.btnNewPassBook = New BankControls.NewButton
        Me.dtpNPBFrom = New System.Windows.Forms.DateTimePicker
        Me.dtpNPBTo = New System.Windows.Forms.DateTimePicker
        Me.label8 = New System.Windows.Forms.Label
        Me.label7 = New System.Windows.Forms.Label
        Me.groupBox5 = New System.Windows.Forms.GroupBox
        Me.btnOldPassBookPrint = New BankControls.NewButton
        Me.txtName = New System.Windows.Forms.TextBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.btnSBAccSearch = New System.Windows.Forms.Button
        Me.btnHomePage = New System.Windows.Forms.Button
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.GroupBox3.SuspendLayout()
        Me.groupBox4.SuspendLayout()
        Me.groupBox5.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.btnPassSheetPrint)
        Me.GroupBox3.Controls.Add(Me.DTPFrom)
        Me.GroupBox3.Controls.Add(Me.DTPTo)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(19, 377)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(365, 108)
        Me.GroupBox3.TabIndex = 8
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Pass Sheet"
        '
        'btnPassSheetPrint
        '
        Me.btnPassSheetPrint.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPassSheetPrint.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnPassSheetPrint.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPassSheetPrint.GotFocusColour = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnPassSheetPrint.Image = CType(resources.GetObject("btnPassSheetPrint.Image"), System.Drawing.Image)
        Me.btnPassSheetPrint.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnPassSheetPrint.Location = New System.Drawing.Point(125, 62)
        Me.btnPassSheetPrint.LostFocusColour = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.btnPassSheetPrint.Name = "btnPassSheetPrint"
        Me.btnPassSheetPrint.Size = New System.Drawing.Size(120, 40)
        Me.btnPassSheetPrint.TabIndex = 9
        Me.btnPassSheetPrint.Text = "&Print"
        '
        'DTPFrom
        '
        Me.DTPFrom.CustomFormat = "dd-MMM-yyyy"
        Me.DTPFrom.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DTPFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DTPFrom.Location = New System.Drawing.Point(61, 27)
        Me.DTPFrom.Name = "DTPFrom"
        Me.DTPFrom.Size = New System.Drawing.Size(121, 23)
        Me.DTPFrom.TabIndex = 1
        '
        'DTPTo
        '
        Me.DTPTo.CustomFormat = "dd-MMM-yyyy"
        Me.DTPTo.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DTPTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DTPTo.Location = New System.Drawing.Point(236, 27)
        Me.DTPTo.Name = "DTPTo"
        Me.DTPTo.Size = New System.Drawing.Size(121, 23)
        Me.DTPTo.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(200, 30)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(36, 16)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "To :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 30)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 16)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "From :"
        '
        'txtFatherName
        '
        Me.txtFatherName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtFatherName.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFatherName.Location = New System.Drawing.Point(188, 114)
        Me.txtFatherName.Name = "txtFatherName"
        Me.txtFatherName.ReadOnly = True
        Me.txtFatherName.Size = New System.Drawing.Size(333, 23)
        Me.txtFatherName.TabIndex = 8
        '
        'label6
        '
        Me.label6.AutoSize = True
        Me.label6.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label6.Location = New System.Drawing.Point(17, 117)
        Me.label6.Name = "label6"
        Me.label6.Size = New System.Drawing.Size(165, 16)
        Me.label6.TabIndex = 7
        Me.label6.Text = "Father/Husband Name :"
        '
        'txtAccountNo
        '
        Me.txtAccountNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtAccountNo.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAccountNo.Location = New System.Drawing.Point(188, 39)
        Me.txtAccountNo.Name = "txtAccountNo"
        Me.txtAccountNo.Size = New System.Drawing.Size(124, 23)
        Me.txtAccountNo.TabIndex = 4
        '
        'groupBox4
        '
        Me.groupBox4.Controls.Add(Me.btnNewPassBook)
        Me.groupBox4.Controls.Add(Me.dtpNPBFrom)
        Me.groupBox4.Controls.Add(Me.dtpNPBTo)
        Me.groupBox4.Controls.Add(Me.label8)
        Me.groupBox4.Controls.Add(Me.label7)
        Me.groupBox4.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.groupBox4.Location = New System.Drawing.Point(5, 61)
        Me.groupBox4.Name = "groupBox4"
        Me.groupBox4.Size = New System.Drawing.Size(361, 100)
        Me.groupBox4.TabIndex = 1
        Me.groupBox4.TabStop = False
        Me.groupBox4.Text = "Transactions"
        '
        'btnNewPassBook
        '
        Me.btnNewPassBook.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnNewPassBook.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnNewPassBook.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNewPassBook.GotFocusColour = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnNewPassBook.Image = CType(resources.GetObject("btnNewPassBook.Image"), System.Drawing.Image)
        Me.btnNewPassBook.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnNewPassBook.Location = New System.Drawing.Point(120, 54)
        Me.btnNewPassBook.LostFocusColour = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.btnNewPassBook.Name = "btnNewPassBook"
        Me.btnNewPassBook.Size = New System.Drawing.Size(120, 40)
        Me.btnNewPassBook.TabIndex = 9
        Me.btnNewPassBook.Text = "&Print"
        '
        'dtpNPBFrom
        '
        Me.dtpNPBFrom.CustomFormat = "dd-MMM-yyyy"
        Me.dtpNPBFrom.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpNPBFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpNPBFrom.Location = New System.Drawing.Point(60, 22)
        Me.dtpNPBFrom.Name = "dtpNPBFrom"
        Me.dtpNPBFrom.Size = New System.Drawing.Size(117, 23)
        Me.dtpNPBFrom.TabIndex = 1
        '
        'dtpNPBTo
        '
        Me.dtpNPBTo.CustomFormat = "dd-MMM-yyyy"
        Me.dtpNPBTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpNPBTo.Location = New System.Drawing.Point(231, 23)
        Me.dtpNPBTo.Name = "dtpNPBTo"
        Me.dtpNPBTo.Size = New System.Drawing.Size(121, 23)
        Me.dtpNPBTo.TabIndex = 3
        '
        'label8
        '
        Me.label8.AutoSize = True
        Me.label8.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label8.Location = New System.Drawing.Point(5, 25)
        Me.label8.Name = "label8"
        Me.label8.Size = New System.Drawing.Size(51, 16)
        Me.label8.TabIndex = 0
        Me.label8.Text = "From :"
        '
        'label7
        '
        Me.label7.AutoSize = True
        Me.label7.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label7.Location = New System.Drawing.Point(192, 26)
        Me.label7.Name = "label7"
        Me.label7.Size = New System.Drawing.Size(36, 16)
        Me.label7.TabIndex = 2
        Me.label7.Text = "To :"
        '
        'groupBox5
        '
        Me.groupBox5.Controls.Add(Me.btnOldPassBookPrint)
        Me.groupBox5.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.groupBox5.Location = New System.Drawing.Point(395, 181)
        Me.groupBox5.Name = "groupBox5"
        Me.groupBox5.Size = New System.Drawing.Size(162, 82)
        Me.groupBox5.TabIndex = 7
        Me.groupBox5.TabStop = False
        Me.groupBox5.Text = "Old Pass Book"
        '
        'btnOldPassBookPrint
        '
        Me.btnOldPassBookPrint.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnOldPassBookPrint.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnOldPassBookPrint.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOldPassBookPrint.GotFocusColour = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnOldPassBookPrint.Image = CType(resources.GetObject("btnOldPassBookPrint.Image"), System.Drawing.Image)
        Me.btnOldPassBookPrint.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnOldPassBookPrint.Location = New System.Drawing.Point(22, 30)
        Me.btnOldPassBookPrint.LostFocusColour = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.btnOldPassBookPrint.Name = "btnOldPassBookPrint"
        Me.btnOldPassBookPrint.Size = New System.Drawing.Size(120, 40)
        Me.btnOldPassBookPrint.TabIndex = 9
        Me.btnOldPassBookPrint.Text = "&Print"
        '
        'txtName
        '
        Me.txtName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtName.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtName.Location = New System.Drawing.Point(188, 77)
        Me.txtName.Name = "txtName"
        Me.txtName.ReadOnly = True
        Me.txtName.Size = New System.Drawing.Size(333, 23)
        Me.txtName.TabIndex = 6
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtFatherName)
        Me.GroupBox1.Controls.Add(Me.label6)
        Me.GroupBox1.Controls.Add(Me.txtAccountNo)
        Me.GroupBox1.Controls.Add(Me.txtName)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.btnSBAccSearch)
        Me.GroupBox1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(19, 18)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(529, 150)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Customer Information"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(86, 41)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(96, 16)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Account No :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(127, 79)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 16)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Name :"
        '
        'btnSBAccSearch
        '
        Me.btnSBAccSearch.BackColor = System.Drawing.SystemColors.Window
        Me.btnSBAccSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSBAccSearch.Image = CType(resources.GetObject("btnSBAccSearch.Image"), System.Drawing.Image)
        Me.btnSBAccSearch.Location = New System.Drawing.Point(319, 37)
        Me.btnSBAccSearch.Name = "btnSBAccSearch"
        Me.btnSBAccSearch.Size = New System.Drawing.Size(38, 32)
        Me.btnSBAccSearch.TabIndex = 3
        Me.btnSBAccSearch.UseVisualStyleBackColor = False
        '
        'btnHomePage
        '
        Me.btnHomePage.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHomePage.Location = New System.Drawing.Point(116, 23)
        Me.btnHomePage.Name = "btnHomePage"
        Me.btnHomePage.Size = New System.Drawing.Size(125, 32)
        Me.btnHomePage.TabIndex = 0
        Me.btnHomePage.Text = "Home Page"
        Me.btnHomePage.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.groupBox4)
        Me.GroupBox2.Controls.Add(Me.btnHomePage)
        Me.GroupBox2.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(19, 181)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(372, 181)
        Me.GroupBox2.TabIndex = 6
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "New Pass Book"
        '
        'frmPassBookPrint
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(569, 497)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.groupBox5)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Name = "frmPassBookPrint"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Pass Book Print"
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.groupBox4.ResumeLayout(False)
        Me.groupBox4.PerformLayout()
        Me.groupBox5.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents DTPFrom As System.Windows.Forms.DateTimePicker
    Friend WithEvents DTPTo As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtFatherName As System.Windows.Forms.TextBox
    Friend WithEvents label6 As System.Windows.Forms.Label
    Friend WithEvents txtAccountNo As System.Windows.Forms.TextBox
    Private WithEvents groupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents dtpNPBFrom As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpNPBTo As System.Windows.Forms.DateTimePicker
    Friend WithEvents label8 As System.Windows.Forms.Label
    Friend WithEvents label7 As System.Windows.Forms.Label
    Private WithEvents groupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnSBAccSearch As System.Windows.Forms.Button
    Friend WithEvents btnHomePage As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents btnPassSheetPrint As BankControls.NewButton
    Friend WithEvents btnNewPassBook As BankControls.NewButton
    Friend WithEvents btnOldPassBookPrint As BankControls.NewButton
End Class
