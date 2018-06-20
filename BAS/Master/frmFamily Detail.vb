Imports System.IO
Public Class frmFamily_Detail
    Inherits System.Windows.Forms.Form

#Region "Form Global Variables"

    Dim objfamily As New clsFamilyDetails
    Dim objMember As New clsMember
    Dim objRelation As New clsRelations
    Dim objDv As DataView
    Dim intNo As Integer = 0
    Dim objDT As DataTable
    Public chrType As Char

#End Region

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    'Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    Friend WithEvents txtName As BankControls.TextControl
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnOK As BankControls.NewButton
    Friend WithEvents btnClose As BankControls.NewButton
    Friend WithEvents lblAccountNo As System.Windows.Forms.Label
    Friend WithEvents txtAccountNo As BankControls.TextControl
    Friend WithEvents btnAdd As BankControls.NewButton
    Friend WithEvents btnDelete As BankControls.NewButton
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents lblRecords As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents btnPhotoLoad As BankControls.NewButton
    Friend WithEvents picPhoto As System.Windows.Forms.PictureBox
    Friend WithEvents lblPhoto As System.Windows.Forms.Label
    Friend WithEvents btnPhotoCancel As BankControls.NewButton
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents rdbMale As System.Windows.Forms.RadioButton
    Friend WithEvents rdbFemale As System.Windows.Forms.RadioButton
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents txtAge As BankControls.NumericControl
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents dtpDOB As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents txtFMName As BankControls.TextControl
    Friend WithEvents lblRelation As System.Windows.Forms.Label
    Friend WithEvents cmbRelation As System.Windows.Forms.ComboBox
    Friend WithEvents rdbMajor As System.Windows.Forms.RadioButton
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents rdbMinor As System.Windows.Forms.RadioButton
    Friend WithEvents lblNomineeNo As System.Windows.Forms.Label
    Friend WithEvents txtNomineeNo As BankControls.TextControl
    Friend WithEvents lvFamily As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmFamily_Detail))
        Me.txtName = New BankControls.TextControl
        Me.Label3 = New System.Windows.Forms.Label
        Me.btnOK = New BankControls.NewButton
        Me.btnClose = New BankControls.NewButton
        Me.lblAccountNo = New System.Windows.Forms.Label
        Me.txtAccountNo = New BankControls.TextControl
        Me.btnAdd = New BankControls.NewButton
        Me.btnDelete = New BankControls.NewButton
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog
        Me.lblRecords = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.lvFamily = New System.Windows.Forms.ListView
        Me.ColumnHeader1 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader2 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader3 = New System.Windows.Forms.ColumnHeader
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.btnPhotoLoad = New BankControls.NewButton
        Me.picPhoto = New System.Windows.Forms.PictureBox
        Me.lblPhoto = New System.Windows.Forms.Label
        Me.btnPhotoCancel = New BankControls.NewButton
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.rdbMale = New System.Windows.Forms.RadioButton
        Me.rdbFemale = New System.Windows.Forms.RadioButton
        Me.Label20 = New System.Windows.Forms.Label
        Me.txtAge = New BankControls.NumericControl
        Me.Label19 = New System.Windows.Forms.Label
        Me.dtpDOB = New System.Windows.Forms.DateTimePicker
        Me.Label18 = New System.Windows.Forms.Label
        Me.Label17 = New System.Windows.Forms.Label
        Me.txtFMName = New BankControls.TextControl
        Me.lblRelation = New System.Windows.Forms.Label
        Me.cmbRelation = New System.Windows.Forms.ComboBox
        Me.rdbMajor = New System.Windows.Forms.RadioButton
        Me.Label1 = New System.Windows.Forms.Label
        Me.rdbMinor = New System.Windows.Forms.RadioButton
        Me.lblNomineeNo = New System.Windows.Forms.Label
        Me.txtNomineeNo = New BankControls.TextControl
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtName
        '
        Me.txtName.AlphaNumeric = False
        Me.txtName.BackColor = System.Drawing.Color.FromArgb(CType(238, Byte), CType(253, Byte), CType(248, Byte))
        Me.txtName.BlankSpace = True
        Me.txtName.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtName.GotFocusColour = System.Drawing.Color.FromArgb(CType(238, Byte), CType(253, Byte), CType(248, Byte))
        Me.txtName.Location = New System.Drawing.Point(344, 18)
        Me.txtName.LostFocusColour = System.Drawing.Color.FromArgb(CType(238, Byte), CType(253, Byte), CType(248, Byte))
        Me.txtName.Mandatory = False
        Me.txtName.Name = "txtName"
        Me.txtName.ReadOnly = True
        Me.txtName.Size = New System.Drawing.Size(248, 23)
        Me.txtName.SpecialChar = False
        Me.txtName.TabIndex = 82
        Me.txtName.TabStop = False
        Me.txtName.Text = ""
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(288, 20)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(59, 19)
        Me.Label3.TabIndex = 80
        Me.Label3.Text = "Name : "
        '
        'btnOK
        '
        Me.btnOK.BackColor = System.Drawing.Color.FromArgb(CType(238, Byte), CType(253, Byte), CType(248, Byte))
        Me.btnOK.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnOK.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnOK.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOK.ForeColor = System.Drawing.Color.Black
        Me.btnOK.GotFocusColour = System.Drawing.Color.FromArgb(CType(122, Byte), CType(120, Byte), CType(152, Byte))
        Me.btnOK.Location = New System.Drawing.Point(448, 442)
        Me.btnOK.LostFocusColour = System.Drawing.Color.FromArgb(CType(238, Byte), CType(253, Byte), CType(248, Byte))
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(88, 32)
        Me.btnOK.TabIndex = 10
        Me.btnOK.Text = "&Save"
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.Color.FromArgb(CType(238, Byte), CType(253, Byte), CType(248, Byte))
        Me.btnClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnClose.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.ForeColor = System.Drawing.Color.Black
        Me.btnClose.GotFocusColour = System.Drawing.Color.FromArgb(CType(255, Byte), CType(128, Byte), CType(128, Byte))
        Me.btnClose.Location = New System.Drawing.Point(536, 442)
        Me.btnClose.LostFocusColour = System.Drawing.Color.FromArgb(CType(238, Byte), CType(253, Byte), CType(248, Byte))
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(88, 32)
        Me.btnClose.TabIndex = 11
        Me.btnClose.Text = "&Close"
        '
        'lblAccountNo
        '
        Me.lblAccountNo.AutoSize = True
        Me.lblAccountNo.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAccountNo.Location = New System.Drawing.Point(40, 20)
        Me.lblAccountNo.Name = "lblAccountNo"
        Me.lblAccountNo.Size = New System.Drawing.Size(111, 19)
        Me.lblAccountNo.TabIndex = 79
        Me.lblAccountNo.Text = " Account No.  : "
        '
        'txtAccountNo
        '
        Me.txtAccountNo.AlphaNumeric = False
        Me.txtAccountNo.BackColor = System.Drawing.Color.FromArgb(CType(238, Byte), CType(253, Byte), CType(248, Byte))
        Me.txtAccountNo.BlankSpace = False
        Me.txtAccountNo.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAccountNo.GotFocusColour = System.Drawing.Color.FromArgb(CType(238, Byte), CType(253, Byte), CType(248, Byte))
        Me.txtAccountNo.Location = New System.Drawing.Point(160, 18)
        Me.txtAccountNo.LostFocusColour = System.Drawing.Color.FromArgb(CType(238, Byte), CType(253, Byte), CType(248, Byte))
        Me.txtAccountNo.Mandatory = False
        Me.txtAccountNo.Name = "txtAccountNo"
        Me.txtAccountNo.ReadOnly = True
        Me.txtAccountNo.Size = New System.Drawing.Size(104, 23)
        Me.txtAccountNo.SpecialChar = False
        Me.txtAccountNo.TabIndex = 81
        Me.txtAccountNo.TabStop = False
        Me.txtAccountNo.Text = ""
        '
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.Color.FromArgb(CType(238, Byte), CType(253, Byte), CType(248, Byte))
        Me.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnAdd.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.ForeColor = System.Drawing.Color.Black
        Me.btnAdd.GotFocusColour = System.Drawing.Color.FromArgb(CType(122, Byte), CType(120, Byte), CType(152, Byte))
        Me.btnAdd.Location = New System.Drawing.Point(16, 440)
        Me.btnAdd.LostFocusColour = System.Drawing.Color.FromArgb(CType(238, Byte), CType(253, Byte), CType(248, Byte))
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(88, 32)
        Me.btnAdd.TabIndex = 13
        Me.btnAdd.Text = "&Add"
        '
        'btnDelete
        '
        Me.btnDelete.BackColor = System.Drawing.Color.FromArgb(CType(238, Byte), CType(253, Byte), CType(248, Byte))
        Me.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnDelete.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.ForeColor = System.Drawing.Color.Black
        Me.btnDelete.GotFocusColour = System.Drawing.Color.FromArgb(CType(122, Byte), CType(120, Byte), CType(152, Byte))
        Me.btnDelete.Location = New System.Drawing.Point(104, 440)
        Me.btnDelete.LostFocusColour = System.Drawing.Color.FromArgb(CType(238, Byte), CType(253, Byte), CType(248, Byte))
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(88, 32)
        Me.btnDelete.TabIndex = 14
        Me.btnDelete.Text = "&Delete"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.Filter = "BMP files|*.bmp|JPEG files|*.jpg|GIF files|*.gif"
        '
        'lblRecords
        '
        Me.lblRecords.AutoSize = True
        Me.lblRecords.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRecords.Location = New System.Drawing.Point(208, 448)
        Me.lblRecords.Name = "lblRecords"
        Me.lblRecords.Size = New System.Drawing.Size(0, 19)
        Me.lblRecords.TabIndex = 78
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.FromArgb(CType(238, Byte), CType(253, Byte), CType(248, Byte))
        Me.GroupBox1.Controls.Add(Me.lvFamily)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 56)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(280, 376)
        Me.GroupBox1.TabIndex = 83
        Me.GroupBox1.TabStop = False
        '
        'lvFamily
        '
        Me.lvFamily.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lvFamily.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3})
        Me.lvFamily.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvFamily.FullRowSelect = True
        Me.lvFamily.GridLines = True
        Me.lvFamily.HideSelection = False
        Me.lvFamily.Location = New System.Drawing.Point(8, 64)
        Me.lvFamily.MultiSelect = False
        Me.lvFamily.Name = "lvFamily"
        Me.lvFamily.Size = New System.Drawing.Size(256, 248)
        Me.lvFamily.TabIndex = 12
        Me.lvFamily.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "SlNo."
        Me.ColumnHeader1.Width = 40
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Name"
        Me.ColumnHeader2.Width = 150
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Relation"
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.FromArgb(CType(238, Byte), CType(253, Byte), CType(248, Byte))
        Me.GroupBox3.Controls.Add(Me.btnPhotoLoad)
        Me.GroupBox3.Controls.Add(Me.picPhoto)
        Me.GroupBox3.Controls.Add(Me.lblPhoto)
        Me.GroupBox3.Controls.Add(Me.btnPhotoCancel)
        Me.GroupBox3.Controls.Add(Me.GroupBox4)
        Me.GroupBox3.Controls.Add(Me.Label20)
        Me.GroupBox3.Controls.Add(Me.txtAge)
        Me.GroupBox3.Controls.Add(Me.Label19)
        Me.GroupBox3.Controls.Add(Me.dtpDOB)
        Me.GroupBox3.Controls.Add(Me.Label18)
        Me.GroupBox3.Controls.Add(Me.Label17)
        Me.GroupBox3.Controls.Add(Me.txtFMName)
        Me.GroupBox3.Controls.Add(Me.lblRelation)
        Me.GroupBox3.Controls.Add(Me.cmbRelation)
        Me.GroupBox3.Controls.Add(Me.rdbMajor)
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.Controls.Add(Me.rdbMinor)
        Me.GroupBox3.Controls.Add(Me.lblNomineeNo)
        Me.GroupBox3.Controls.Add(Me.txtNomineeNo)
        Me.GroupBox3.Location = New System.Drawing.Point(288, 56)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(384, 376)
        Me.GroupBox3.TabIndex = 85
        Me.GroupBox3.TabStop = False
        '
        'btnPhotoLoad
        '
        Me.btnPhotoLoad.BackColor = System.Drawing.Color.FromArgb(CType(238, Byte), CType(253, Byte), CType(248, Byte))
        Me.btnPhotoLoad.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPhotoLoad.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnPhotoLoad.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPhotoLoad.ForeColor = System.Drawing.Color.Black
        Me.btnPhotoLoad.GotFocusColour = System.Drawing.Color.FromArgb(CType(120, Byte), CType(128, Byte), CType(171, Byte))
        Me.btnPhotoLoad.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnPhotoLoad.Location = New System.Drawing.Point(272, 272)
        Me.btnPhotoLoad.LostFocusColour = System.Drawing.Color.FromArgb(CType(238, Byte), CType(253, Byte), CType(248, Byte))
        Me.btnPhotoLoad.Name = "btnPhotoLoad"
        Me.btnPhotoLoad.Size = New System.Drawing.Size(64, 24)
        Me.btnPhotoLoad.TabIndex = 8
        Me.btnPhotoLoad.Text = "Load"
        '
        'picPhoto
        '
        Me.picPhoto.BackColor = System.Drawing.Color.FromArgb(CType(238, Byte), CType(253, Byte), CType(248, Byte))
        Me.picPhoto.BackgroundImage = CType(resources.GetObject("picPhoto.BackgroundImage"), System.Drawing.Image)
        Me.picPhoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picPhoto.Cursor = System.Windows.Forms.Cursors.Hand
        Me.picPhoto.Location = New System.Drawing.Point(152, 264)
        Me.picPhoto.Name = "picPhoto"
        Me.picPhoto.Size = New System.Drawing.Size(96, 100)
        Me.picPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picPhoto.TabIndex = 72
        Me.picPhoto.TabStop = False
        '
        'lblPhoto
        '
        Me.lblPhoto.AutoSize = True
        Me.lblPhoto.BackColor = System.Drawing.Color.FromArgb(CType(238, Byte), CType(253, Byte), CType(248, Byte))
        Me.lblPhoto.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPhoto.Location = New System.Drawing.Point(48, 272)
        Me.lblPhoto.Name = "lblPhoto"
        Me.lblPhoto.Size = New System.Drawing.Size(58, 19)
        Me.lblPhoto.TabIndex = 71
        Me.lblPhoto.Text = "Photo : "
        '
        'btnPhotoCancel
        '
        Me.btnPhotoCancel.BackColor = System.Drawing.Color.FromArgb(CType(238, Byte), CType(253, Byte), CType(248, Byte))
        Me.btnPhotoCancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPhotoCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnPhotoCancel.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPhotoCancel.ForeColor = System.Drawing.Color.Black
        Me.btnPhotoCancel.GotFocusColour = System.Drawing.Color.FromArgb(CType(255, Byte), CType(128, Byte), CType(128, Byte))
        Me.btnPhotoCancel.Location = New System.Drawing.Point(272, 320)
        Me.btnPhotoCancel.LostFocusColour = System.Drawing.Color.FromArgb(CType(238, Byte), CType(253, Byte), CType(248, Byte))
        Me.btnPhotoCancel.Name = "btnPhotoCancel"
        Me.btnPhotoCancel.Size = New System.Drawing.Size(64, 24)
        Me.btnPhotoCancel.TabIndex = 9
        Me.btnPhotoCancel.Text = "Cancel"
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.Color.FromArgb(CType(238, Byte), CType(253, Byte), CType(248, Byte))
        Me.GroupBox4.Controls.Add(Me.rdbMale)
        Me.GroupBox4.Controls.Add(Me.rdbFemale)
        Me.GroupBox4.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.Location = New System.Drawing.Point(152, 168)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(176, 36)
        Me.GroupBox4.TabIndex = 4
        Me.GroupBox4.TabStop = False
        '
        'rdbMale
        '
        Me.rdbMale.Checked = True
        Me.rdbMale.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdbMale.Location = New System.Drawing.Point(24, 8)
        Me.rdbMale.Name = "rdbMale"
        Me.rdbMale.Size = New System.Drawing.Size(72, 24)
        Me.rdbMale.TabIndex = 5
        Me.rdbMale.TabStop = True
        Me.rdbMale.Text = "Male"
        '
        'rdbFemale
        '
        Me.rdbFemale.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdbFemale.Location = New System.Drawing.Point(96, 8)
        Me.rdbFemale.Name = "rdbFemale"
        Me.rdbFemale.Size = New System.Drawing.Size(72, 24)
        Me.rdbFemale.TabIndex = 6
        Me.rdbFemale.Text = "Female"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.BackColor = System.Drawing.Color.FromArgb(CType(238, Byte), CType(253, Byte), CType(248, Byte))
        Me.Label20.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(48, 176)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(69, 19)
        Me.Label20.TabIndex = 48
        Me.Label20.Text = "Gender : "
        '
        'txtAge
        '
        Me.txtAge.AfterDecimal = 0
        Me.txtAge.BeforeDecimal = 3
        Me.txtAge.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAge.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtAge.Location = New System.Drawing.Point(152, 112)
        Me.txtAge.LostFocusColour = System.Drawing.SystemColors.Window
        Me.txtAge.MaxLength = 3
        Me.txtAge.MaxValue = 100
        Me.txtAge.MinValue = 0
        Me.txtAge.Name = "txtAge"
        Me.txtAge.Size = New System.Drawing.Size(56, 23)
        Me.txtAge.TabIndex = 3
        Me.txtAge.Text = ""
        Me.txtAge.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.BackColor = System.Drawing.Color.FromArgb(CType(238, Byte), CType(253, Byte), CType(248, Byte))
        Me.Label19.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(48, 112)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(46, 19)
        Me.Label19.TabIndex = 46
        Me.Label19.Text = "Age : "
        '
        'dtpDOB
        '
        Me.dtpDOB.CustomFormat = "dd - MMM - yyyy"
        Me.dtpDOB.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpDOB.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpDOB.Location = New System.Drawing.Point(152, 80)
        Me.dtpDOB.MaxDate = New Date(9998, 11, 16, 0, 0, 0, 0)
        Me.dtpDOB.Name = "dtpDOB"
        Me.dtpDOB.Size = New System.Drawing.Size(184, 23)
        Me.dtpDOB.TabIndex = 2
        Me.dtpDOB.Value = New Date(2006, 11, 16, 0, 0, 0, 0)
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.BackColor = System.Drawing.Color.FromArgb(CType(238, Byte), CType(253, Byte), CType(248, Byte))
        Me.Label18.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(48, 80)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(107, 19)
        Me.Label18.TabIndex = 44
        Me.Label18.Text = "Date of Birth : "
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.BackColor = System.Drawing.Color.FromArgb(CType(238, Byte), CType(253, Byte), CType(248, Byte))
        Me.Label17.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(48, 48)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(59, 19)
        Me.Label17.TabIndex = 42
        Me.Label17.Text = "Name : "
        '
        'txtFMName
        '
        Me.txtFMName.AlphaNumeric = False
        Me.txtFMName.BlankSpace = True
        Me.txtFMName.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFMName.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtFMName.Location = New System.Drawing.Point(152, 48)
        Me.txtFMName.LostFocusColour = System.Drawing.SystemColors.Window
        Me.txtFMName.Mandatory = False
        Me.txtFMName.MaxLength = 30
        Me.txtFMName.Name = "txtFMName"
        Me.txtFMName.Size = New System.Drawing.Size(184, 23)
        Me.txtFMName.SpecialChar = True
        Me.txtFMName.TabIndex = 1
        Me.txtFMName.Text = ""
        '
        'lblRelation
        '
        Me.lblRelation.AutoSize = True
        Me.lblRelation.BackColor = System.Drawing.Color.FromArgb(CType(238, Byte), CType(253, Byte), CType(248, Byte))
        Me.lblRelation.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRelation.Location = New System.Drawing.Point(48, 216)
        Me.lblRelation.Name = "lblRelation"
        Me.lblRelation.Size = New System.Drawing.Size(75, 19)
        Me.lblRelation.TabIndex = 55
        Me.lblRelation.Text = "Relation : "
        '
        'cmbRelation
        '
        Me.cmbRelation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbRelation.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbRelation.ItemHeight = 16
        Me.cmbRelation.Location = New System.Drawing.Point(152, 216)
        Me.cmbRelation.Name = "cmbRelation"
        Me.cmbRelation.Size = New System.Drawing.Size(184, 24)
        Me.cmbRelation.TabIndex = 7
        '
        'rdbMajor
        '
        Me.rdbMajor.BackColor = System.Drawing.Color.FromArgb(CType(238, Byte), CType(253, Byte), CType(248, Byte))
        Me.rdbMajor.Checked = True
        Me.rdbMajor.Enabled = False
        Me.rdbMajor.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdbMajor.Location = New System.Drawing.Point(176, 144)
        Me.rdbMajor.Name = "rdbMajor"
        Me.rdbMajor.Size = New System.Drawing.Size(72, 24)
        Me.rdbMajor.TabIndex = 4
        Me.rdbMajor.TabStop = True
        Me.rdbMajor.Text = "Major"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(238, Byte), CType(253, Byte), CType(248, Byte))
        Me.Label1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(48, 144)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(94, 19)
        Me.Label1.TabIndex = 48
        Me.Label1.Text = "Age Status : "
        '
        'rdbMinor
        '
        Me.rdbMinor.BackColor = System.Drawing.Color.FromArgb(CType(238, Byte), CType(253, Byte), CType(248, Byte))
        Me.rdbMinor.Enabled = False
        Me.rdbMinor.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdbMinor.Location = New System.Drawing.Point(248, 144)
        Me.rdbMinor.Name = "rdbMinor"
        Me.rdbMinor.Size = New System.Drawing.Size(88, 24)
        Me.rdbMinor.TabIndex = 4
        Me.rdbMinor.Text = "Minor"
        '
        'lblNomineeNo
        '
        Me.lblNomineeNo.AutoSize = True
        Me.lblNomineeNo.BackColor = System.Drawing.Color.FromArgb(CType(238, Byte), CType(253, Byte), CType(248, Byte))
        Me.lblNomineeNo.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNomineeNo.Location = New System.Drawing.Point(48, 16)
        Me.lblNomineeNo.Name = "lblNomineeNo"
        Me.lblNomineeNo.Size = New System.Drawing.Size(48, 19)
        Me.lblNomineeNo.TabIndex = 66
        Me.lblNomineeNo.Text = " No. : "
        '
        'txtNomineeNo
        '
        Me.txtNomineeNo.AlphaNumeric = False
        Me.txtNomineeNo.BackColor = System.Drawing.Color.FromArgb(CType(238, Byte), CType(253, Byte), CType(248, Byte))
        Me.txtNomineeNo.BlankSpace = False
        Me.txtNomineeNo.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNomineeNo.GotFocusColour = System.Drawing.Color.FromArgb(CType(238, Byte), CType(253, Byte), CType(248, Byte))
        Me.txtNomineeNo.Location = New System.Drawing.Point(152, 16)
        Me.txtNomineeNo.LostFocusColour = System.Drawing.Color.FromArgb(CType(238, Byte), CType(253, Byte), CType(248, Byte))
        Me.txtNomineeNo.Mandatory = False
        Me.txtNomineeNo.Name = "txtNomineeNo"
        Me.txtNomineeNo.ReadOnly = True
        Me.txtNomineeNo.Size = New System.Drawing.Size(104, 23)
        Me.txtNomineeNo.SpecialChar = False
        Me.txtNomineeNo.TabIndex = 68
        Me.txtNomineeNo.TabStop = False
        Me.txtNomineeNo.Text = ""
        '
        'frmFamily_Detail
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(7, 16)
        Me.BackColor = System.Drawing.Color.FromArgb(CType(238, Byte), CType(253, Byte), CType(248, Byte))
        Me.CancelButton = Me.btnClose
        Me.ClientSize = New System.Drawing.Size(680, 493)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnOK)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.lblAccountNo)
        Me.Controls.Add(Me.txtAccountNo)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.lblRecords)
        Me.Controls.Add(Me.txtName)
        Me.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmFamily_Detail"
        Me.Text = "Family Master"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region "Sub Routines to load Control values from Database"

    'to load database values to form controls
    Sub sbLoadControlValues()
        sbLoadRelation()
    End Sub

    'To load ReligionTbl values to the Religion ComboBox control
    Sub sbLoadRelation()
        If objRelation.fnGetRelations Then
            'objDv = New DataView(objRelation.RelationTable, "FamilyRelation='Y'", "RelationCode", DataViewRowState.OriginalRows)
            cmbRelation.DataSource = objRelation.RelationTable
            cmbRelation.DisplayMember = "RelationName"
            cmbRelation.ValueMember = "RelationCode"
        End If
        objRelation = Nothing
    End Sub

#End Region

#Region "Sub Routines and Functions"

    Function fnGetFamilys() As Boolean
        If txtAccountNo.Text <> "" Then
            If objfamily.fnGetFamilys(txtAccountNo.Text, chrType) Then
                intNo = 0
                objDT = objfamily.FamilyTable
                Return True
            End If
        End If
        Return False
    End Function

    Function fnLoadFamilyDetails() As Boolean

        Dim msStream As New MemoryStream

        If Not objDT Is Nothing Then
            If intNo >= objDT.Rows.Count Then
                Exit Function
            End If
        Else
            Exit Function
        End If
        sbClear()
        txtNomineeNo.Text = objDT.Rows(intNo).Item("No")
        txtFMName.Text = objDT.Rows(intNo).Item("Name")
        dtpDOB.Value = objDT.Rows(intNo).Item("DOB")
        txtAge.Text = objDT.Rows(intNo).Item("Age")

        If objDT.Rows(intNo).Item("AgeStatus") = "M" Then
            rdbMajor.Checked = True
        Else
            rdbMinor.Checked = True
        End If

        If objDT.Rows(intNo).Item("Gender") = "M" Then
            rdbMale.Checked = True
        Else
            rdbFemale.Checked = True
        End If
        cmbRelation.SelectedValue = objDT.Rows(intNo).Item("RelationCode")

        If Not IsDBNull(objDT.Rows(intNo).Item("Photo")) Then
            If objDT.Rows(intNo).Item("Photo").length > 0 Then
                msStream = New MemoryStream(objDT.Rows(intNo).Item("Photo"), True)
                msStream.Write(objDT.Rows(intNo).Item("Photo"), 0, objDT.Rows(intNo).Item("Photo").length)
                picPhoto.Image = Image.FromStream(msStream)
                msStream.Close()
            End If
        End If

    End Function

    Sub fnLoadFamily()
        Dim intCounter As Integer = 0
        Dim lvItem As ListViewItem
        Dim dvFamily As DataView
        lvFamily.Items.Clear()
        If objfamily.fnGetFamily(txtAccountNo.Text) Then
            dvFamily = New DataView(objfamily.FamilyTable)
            While intCounter < dvFamily.Count
                lvItem = lvFamily.Items.Add(dvFamily.Item(intCounter).Item("No"))
                lvItem.SubItems.Add(dvFamily.Item(intCounter).Item("Name"))
                lvItem.SubItems.Add(dvFamily.Item(intCounter).Item("RelationCode"))
                intCounter += 1
            End While
        End If
    End Sub

    Sub sbLoadMember()
        Dim objDT As DataTable
        If objMember.fnGetMemberDetails(txtAccountNo.Text) Then
            sbClear()
            objDT = objMember.MemberTable
            txtAccountNo.Text = objDT.Rows(0).Item("MemberNo")
            txtName.Text = objDT.Rows(0).Item("Name")
            fnLoadFamily()
        End If

    End Sub

    Sub sbClear()
        txtFMName.ResetText()
        txtAge.ResetText()
        rdbMale.Checked = True
        rdbMajor.Checked = True
        cmbRelation.SelectedIndex = -1
        picPhoto.Image = Nothing

    End Sub

    Function fnCheck() As Boolean
        If Trim(txtFMName.Text) = "" Then
            MsgBox("Nominee name can not be blank", MsgBoxStyle.Exclamation)
            txtFMName.Focus()
            Return False
        ElseIf Trim(txtAge.Text) = "" Then
            MsgBox("Enter age", MsgBoxStyle.Exclamation)
            txtFMName.Focus()
            Return False
        ElseIf cmbRelation.SelectedIndex < 0 Then
            MsgBox("Select nominee relation", MsgBoxStyle.Exclamation)
            cmbRelation.Focus()
            Return False
        Else
            Return True
        End If
    End Function

    Function fnSetData() As Boolean

        objfamily.No = txtNomineeNo.Text
        objfamily.AccountNo = txtAccountNo.Text
        objfamily.Name = txtFMName.Text
        objfamily.DOB = dtpDOB.Value
        objfamily.Age = txtAge.Text
        objfamily.AgeStatus = IIf(rdbMajor.Checked = True, "M", "N")
        objfamily.Gender = IIf(rdbMale.Checked = True, "M", "F")
        objfamily.RelationCode = cmbRelation.SelectedValue
        objfamily.Type = chrType
        objfamily.Photo = fnGetPhoto()
        Return True

    End Function


    Function fnsaveData(ByVal objTrans As IDbTransaction) As Boolean

        If objfamily.fnCheckFamily(txtNomineeNo.Text, txtAccountNo.Text, chrType) = True Then
            If objfamily.fnUpdateFamily(objTrans) Then
                MsgBox("Family details updated successfully", MsgBoxStyle.Information)
                Return True
            Else
                Return False
            End If
        Else
            If objfamily.fnAddFamily(objTrans) Then
                MsgBox("Family details added successfully", MsgBoxStyle.Information)
                Return True
            Else
                Return False
            End If
        End If
    End Function

    'To get Byte array for Photo object, function called while setting values to the Class Properties
    Function fnGetPhoto() As Byte()
        Try
            If Not picPhoto.Image Is Nothing Then
                Dim msStream As New MemoryStream
                Dim bytArr() As Byte
                picPhoto.Image.Save(msStream, picPhoto.Image.RawFormat)
                bytArr = msStream.GetBuffer
                msStream.Close()
                Return bytArr
            End If
            Return Nothing
        Catch ex As Exception
            Return Nothing
        End Try
    End Function

#End Region

#Region " Events"

    Private Sub frmFamily_Detail_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        dtpDOB.Value = Date.Now
        dtpDOB.MaxDate = Date.Now
        sbLoadControlValues()
        sbLoadMember()
        btnAdd_Click(sender, e)
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnPhotoCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPhotoCancel.Click
        picPhoto.Image = Nothing
    End Sub

    Private Sub btnPhotoLoad_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPhotoLoad.Click
        If OpenFileDialog1.ShowDialog() <> DialogResult.Cancel Then
            Try
                picPhoto.Image = Image.FromFile(OpenFileDialog1.FileName)
            Catch
                MsgBox("Select image files only", MsgBoxStyle.Exclamation)
            End Try
        End If
    End Sub

    Private Sub picPhoto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picPhoto.Click
        btnPhotoLoad_Click(sender, e)
    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        txtNomineeNo.Text = objfamily.fnGetNewFamilyNo(txtAccountNo.Text, chrType)
        intNo += 1
        sbClear()
        txtFMName.Focus()
    End Sub

    Private Sub btnOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOK.Click

        Dim objTrans As IDbTransaction
        Try
            objTrans = fnGetTransaction()
            If fnCheck() Then
                If fnSetData() Then
                    If fnsaveData(objTrans) Then
                        objTrans.Commit()
                        If fnGetFamilys() Then
                            fnLoadFamily()
                            btnAdd_Click(sender, e)
                        End If
                    Else
                        MsgBox("Transaction failed, because of internal error", MsgBoxStyle.Exclamation)
                    End If
                End If
            End If
        Catch ex As Exception
            objTrans.Rollback()
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
        Finally
            objTrans.Dispose()
        End Try
       
    End Sub

    Private Sub dtpDOB_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpDOB.ValueChanged
        txtAge.Text = DateDiff(DateInterval.Year, dtpDOB.Value, Date.Now)
    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        If MsgBox("Are you sure you want to delete this record?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirm Delete") = MsgBoxResult.Yes Then
            If objfamily.fnDeleteFamily(txtAccountNo.Text, txtNomineeNo.Text, chrType) Then
                MsgBox("Deleted successfully", MsgBoxStyle.Information)
                btnAdd_Click(sender, e)
                If fnGetFamilys() Then
                    fnLoadFamilyDetails()
                End If
            End If
        End If
    End Sub

    Private Sub txtAge_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtAge.TextChanged
        If Val(txtAge.Text) >= 18 Then
            rdbMajor.Checked = True
        Else
            rdbMinor.Checked = True
        End If
    End Sub

    Private Sub lvFamily_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lvFamily.SelectedIndexChanged
        If lvFamily.SelectedItems.Count > 0 Then
            If objfamily.fnCheckFamily(lvFamily.SelectedItems(0).SubItems(0).Text, txtAccountNo.Text) Then
                intNo = 0
                objDT = objfamily.FamilyTable
                fnLoadFamilyDetails()
            End If
        End If

    End Sub

#End Region

End Class
