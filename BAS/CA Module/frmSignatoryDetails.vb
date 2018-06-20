Imports System.IO
Public Class frmSignatoryDetails
    Inherits System.Windows.Forms.Form

#Region "Form Global Variables"
    Dim objSig As New clsSignatories
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
    'Friend WithEvents lblAccountNo As System.Windows.Forms.Label
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    ' Friend WithEvents Label3 As System.Windows.Forms.Label
    'Friend WithEvents txtName As BankControls.TextControl
    Friend WithEvents btnOK As BankControls.NewButton
    Friend WithEvents lblRecords As System.Windows.Forms.Label
    'Friend WithEvents txtAccountNo As BankControls.TextControl
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents btnPhotoLoad As BankControls.NewButton
    Friend WithEvents picPhoto As System.Windows.Forms.PictureBox
    Friend WithEvents lblPhoto As System.Windows.Forms.Label
    Friend WithEvents btnPhotoCancel As BankControls.NewButton
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnSignCancel As BankControls.NewButton
    Friend WithEvents btnSignLoad As BankControls.NewButton
    Friend WithEvents picSign As System.Windows.Forms.PictureBox
    Friend WithEvents btnClose As BankControls.NewButton
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents rdbMale As System.Windows.Forms.RadioButton
    Friend WithEvents rdbFemale As System.Windows.Forms.RadioButton
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents txtAge As BankControls.NumericControl
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents dtpDOB As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents cmbVillage As System.Windows.Forms.ComboBox
    Friend WithEvents lblRelation As System.Windows.Forms.Label
    Friend WithEvents txtAddress As BankControls.TextControl
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents rdbMajor As System.Windows.Forms.RadioButton
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents rdbMinor As System.Windows.Forms.RadioButton
    Friend WithEvents lblNomineeNo As System.Windows.Forms.Label
    Friend WithEvents btnDelete As BankControls.NewButton
    Friend WithEvents btnAdd As BankControls.NewButton
    Friend WithEvents btnPrevious As BankControls.NewButton
    Friend WithEvents btnNext As BankControls.NewButton
    Friend WithEvents cmbPosition As System.Windows.Forms.ComboBox
    Friend WithEvents txtPhoneNo As BankControls.NumericControl
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtName As BankControls.TextControl
    Friend WithEvents lblAccountNo As System.Windows.Forms.Label
    Friend WithEvents txtAccountNo As BankControls.TextControl
    Friend WithEvents txtSignName As BankControls.TextControl
    Friend WithEvents txtno As BankControls.TextControl
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtmoblieNo As BankControls.NumericControl
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cmbSignatory As System.Windows.Forms.ComboBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmSignatoryDetails))
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog
        Me.btnOK = New BankControls.NewButton
        Me.lblRecords = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.btnPhotoLoad = New BankControls.NewButton
        Me.picPhoto = New System.Windows.Forms.PictureBox
        Me.lblPhoto = New System.Windows.Forms.Label
        Me.btnPhotoCancel = New BankControls.NewButton
        Me.Label2 = New System.Windows.Forms.Label
        Me.btnSignCancel = New BankControls.NewButton
        Me.btnSignLoad = New BankControls.NewButton
        Me.picSign = New System.Windows.Forms.PictureBox
        Me.btnClose = New BankControls.NewButton
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.cmbSignatory = New System.Windows.Forms.ComboBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.rdbMale = New System.Windows.Forms.RadioButton
        Me.rdbFemale = New System.Windows.Forms.RadioButton
        Me.Label20 = New System.Windows.Forms.Label
        Me.txtAge = New BankControls.NumericControl
        Me.Label19 = New System.Windows.Forms.Label
        Me.dtpDOB = New System.Windows.Forms.DateTimePicker
        Me.Label18 = New System.Windows.Forms.Label
        Me.Label17 = New System.Windows.Forms.Label
        Me.cmbPosition = New System.Windows.Forms.ComboBox
        Me.txtSignName = New BankControls.TextControl
        Me.Label23 = New System.Windows.Forms.Label
        Me.lblRelation = New System.Windows.Forms.Label
        Me.txtAddress = New BankControls.TextControl
        Me.Label22 = New System.Windows.Forms.Label
        Me.lblNomineeNo = New System.Windows.Forms.Label
        Me.txtno = New BankControls.TextControl
        Me.btnDelete = New BankControls.NewButton
        Me.btnAdd = New BankControls.NewButton
        Me.btnPrevious = New BankControls.NewButton
        Me.btnNext = New BankControls.NewButton
        Me.txtPhoneNo = New BankControls.NumericControl
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtName = New BankControls.TextControl
        Me.lblAccountNo = New System.Windows.Forms.Label
        Me.txtAccountNo = New BankControls.TextControl
        Me.txtmoblieNo = New BankControls.NumericControl
        Me.Label4 = New System.Windows.Forms.Label
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.Filter = "BMP files|*.bmp|JPEG files|*.jpg|GIF files|*.gif"
        '
        'btnOK
        '
        Me.btnOK.BackColor = System.Drawing.Color.FromArgb(CType(238, Byte), CType(253, Byte), CType(248, Byte))
        Me.btnOK.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnOK.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnOK.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOK.ForeColor = System.Drawing.Color.Black
        Me.btnOK.GotFocusColour = System.Drawing.Color.FromArgb(CType(122, Byte), CType(120, Byte), CType(152, Byte))
        Me.btnOK.Location = New System.Drawing.Point(488, 442)
        Me.btnOK.LostFocusColour = System.Drawing.Color.FromArgb(CType(238, Byte), CType(253, Byte), CType(248, Byte))
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(88, 32)
        Me.btnOK.TabIndex = 14
        Me.btnOK.Text = "&Save"
        '
        'lblRecords
        '
        Me.lblRecords.AutoSize = True
        Me.lblRecords.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRecords.Location = New System.Drawing.Point(208, 450)
        Me.lblRecords.Name = "lblRecords"
        Me.lblRecords.Size = New System.Drawing.Size(0, 19)
        Me.lblRecords.TabIndex = 79
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnPhotoLoad)
        Me.GroupBox2.Controls.Add(Me.picPhoto)
        Me.GroupBox2.Controls.Add(Me.lblPhoto)
        Me.GroupBox2.Controls.Add(Me.btnPhotoCancel)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.btnSignCancel)
        Me.GroupBox2.Controls.Add(Me.btnSignLoad)
        Me.GroupBox2.Controls.Add(Me.picSign)
        Me.GroupBox2.Location = New System.Drawing.Point(416, 58)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(248, 368)
        Me.GroupBox2.TabIndex = 10
        Me.GroupBox2.TabStop = False
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
        Me.btnPhotoLoad.Location = New System.Drawing.Point(88, 144)
        Me.btnPhotoLoad.LostFocusColour = System.Drawing.Color.FromArgb(CType(238, Byte), CType(253, Byte), CType(248, Byte))
        Me.btnPhotoLoad.Name = "btnPhotoLoad"
        Me.btnPhotoLoad.Size = New System.Drawing.Size(64, 24)
        Me.btnPhotoLoad.TabIndex = 10
        Me.btnPhotoLoad.Text = "Load"
        '
        'picPhoto
        '
        Me.picPhoto.BackgroundImage = CType(resources.GetObject("picPhoto.BackgroundImage"), System.Drawing.Image)
        Me.picPhoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picPhoto.Cursor = System.Windows.Forms.Cursors.Hand
        Me.picPhoto.Location = New System.Drawing.Point(104, 40)
        Me.picPhoto.Name = "picPhoto"
        Me.picPhoto.Size = New System.Drawing.Size(96, 100)
        Me.picPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picPhoto.TabIndex = 54
        Me.picPhoto.TabStop = False
        '
        'lblPhoto
        '
        Me.lblPhoto.AutoSize = True
        Me.lblPhoto.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPhoto.Location = New System.Drawing.Point(16, 40)
        Me.lblPhoto.Name = "lblPhoto"
        Me.lblPhoto.Size = New System.Drawing.Size(49, 19)
        Me.lblPhoto.TabIndex = 53
        Me.lblPhoto.Text = "Photo:"
        '
        'btnPhotoCancel
        '
        Me.btnPhotoCancel.BackColor = System.Drawing.Color.FromArgb(CType(238, Byte), CType(253, Byte), CType(248, Byte))
        Me.btnPhotoCancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPhotoCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnPhotoCancel.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPhotoCancel.ForeColor = System.Drawing.Color.Black
        Me.btnPhotoCancel.GotFocusColour = System.Drawing.Color.FromArgb(CType(255, Byte), CType(128, Byte), CType(128, Byte))
        Me.btnPhotoCancel.Location = New System.Drawing.Point(152, 144)
        Me.btnPhotoCancel.LostFocusColour = System.Drawing.Color.FromArgb(CType(238, Byte), CType(253, Byte), CType(248, Byte))
        Me.btnPhotoCancel.Name = "btnPhotoCancel"
        Me.btnPhotoCancel.Size = New System.Drawing.Size(64, 24)
        Me.btnPhotoCancel.TabIndex = 11
        Me.btnPhotoCancel.Text = "Cancel"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(16, 216)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(76, 19)
        Me.Label2.TabIndex = 53
        Me.Label2.Text = "Signature:"
        '
        'btnSignCancel
        '
        Me.btnSignCancel.BackColor = System.Drawing.Color.FromArgb(CType(238, Byte), CType(253, Byte), CType(248, Byte))
        Me.btnSignCancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSignCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSignCancel.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSignCancel.ForeColor = System.Drawing.Color.Black
        Me.btnSignCancel.GotFocusColour = System.Drawing.Color.FromArgb(CType(255, Byte), CType(128, Byte), CType(128, Byte))
        Me.btnSignCancel.Location = New System.Drawing.Point(152, 320)
        Me.btnSignCancel.LostFocusColour = System.Drawing.Color.FromArgb(CType(238, Byte), CType(253, Byte), CType(248, Byte))
        Me.btnSignCancel.Name = "btnSignCancel"
        Me.btnSignCancel.Size = New System.Drawing.Size(64, 24)
        Me.btnSignCancel.TabIndex = 13
        Me.btnSignCancel.Text = "Cancel"
        '
        'btnSignLoad
        '
        Me.btnSignLoad.BackColor = System.Drawing.Color.FromArgb(CType(238, Byte), CType(253, Byte), CType(248, Byte))
        Me.btnSignLoad.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSignLoad.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSignLoad.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSignLoad.ForeColor = System.Drawing.Color.Black
        Me.btnSignLoad.GotFocusColour = System.Drawing.Color.FromArgb(CType(120, Byte), CType(128, Byte), CType(171, Byte))
        Me.btnSignLoad.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSignLoad.Location = New System.Drawing.Point(88, 320)
        Me.btnSignLoad.LostFocusColour = System.Drawing.Color.FromArgb(CType(238, Byte), CType(253, Byte), CType(248, Byte))
        Me.btnSignLoad.Name = "btnSignLoad"
        Me.btnSignLoad.Size = New System.Drawing.Size(64, 24)
        Me.btnSignLoad.TabIndex = 12
        Me.btnSignLoad.Text = "Load"
        '
        'picSign
        '
        Me.picSign.BackgroundImage = CType(resources.GetObject("picSign.BackgroundImage"), System.Drawing.Image)
        Me.picSign.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picSign.Cursor = System.Windows.Forms.Cursors.Hand
        Me.picSign.Location = New System.Drawing.Point(104, 216)
        Me.picSign.Name = "picSign"
        Me.picSign.Size = New System.Drawing.Size(96, 100)
        Me.picSign.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picSign.TabIndex = 54
        Me.picSign.TabStop = False
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
        Me.btnClose.Location = New System.Drawing.Point(576, 442)
        Me.btnClose.LostFocusColour = System.Drawing.Color.FromArgb(CType(238, Byte), CType(253, Byte), CType(248, Byte))
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(88, 32)
        Me.btnClose.TabIndex = 18
        Me.btnClose.Text = "&Close"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cmbSignatory)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.GroupBox3)
        Me.GroupBox1.Controls.Add(Me.Label20)
        Me.GroupBox1.Controls.Add(Me.txtAge)
        Me.GroupBox1.Controls.Add(Me.Label19)
        Me.GroupBox1.Controls.Add(Me.dtpDOB)
        Me.GroupBox1.Controls.Add(Me.Label18)
        Me.GroupBox1.Controls.Add(Me.Label17)
        Me.GroupBox1.Controls.Add(Me.cmbPosition)
        Me.GroupBox1.Controls.Add(Me.txtSignName)
        Me.GroupBox1.Controls.Add(Me.Label23)
        Me.GroupBox1.Controls.Add(Me.lblRelation)
        Me.GroupBox1.Controls.Add(Me.txtAddress)
        Me.GroupBox1.Controls.Add(Me.Label22)
        Me.GroupBox1.Controls.Add(Me.lblNomineeNo)
        Me.GroupBox1.Controls.Add(Me.txtno)
        Me.GroupBox1.Location = New System.Drawing.Point(16, 56)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(384, 368)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        '
        'cmbSignatory
        '
        Me.cmbSignatory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbSignatory.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbSignatory.Items.AddRange(New Object() {"Mandatory", "First Signatory", "Second Signatory"})
        Me.cmbSignatory.Location = New System.Drawing.Point(168, 232)
        Me.cmbSignatory.Name = "cmbSignatory"
        Me.cmbSignatory.Size = New System.Drawing.Size(184, 24)
        Me.cmbSignatory.TabIndex = 6
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(40, 240)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(131, 19)
        Me.Label5.TabIndex = 70
        Me.Label5.Text = "Signatory status : "
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.rdbMale)
        Me.GroupBox3.Controls.Add(Me.rdbFemale)
        Me.GroupBox3.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(168, 112)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(184, 32)
        Me.GroupBox3.TabIndex = 4
        Me.GroupBox3.TabStop = False
        '
        'rdbMale
        '
        Me.rdbMale.Checked = True
        Me.rdbMale.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdbMale.Location = New System.Drawing.Point(16, 8)
        Me.rdbMale.Name = "rdbMale"
        Me.rdbMale.Size = New System.Drawing.Size(72, 24)
        Me.rdbMale.TabIndex = 4
        Me.rdbMale.TabStop = True
        Me.rdbMale.Text = "Male"
        '
        'rdbFemale
        '
        Me.rdbFemale.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdbFemale.Location = New System.Drawing.Point(104, 8)
        Me.rdbFemale.Name = "rdbFemale"
        Me.rdbFemale.Size = New System.Drawing.Size(72, 24)
        Me.rdbFemale.TabIndex = 5
        Me.rdbFemale.Text = "Female"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(40, 128)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(60, 19)
        Me.Label20.TabIndex = 48
        Me.Label20.Text = "Gender:"
        '
        'txtAge
        '
        Me.txtAge.AfterDecimal = 0
        Me.txtAge.BeforeDecimal = 3
        Me.txtAge.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAge.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtAge.Location = New System.Drawing.Point(168, 96)
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
        Me.Label19.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(40, 99)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(36, 19)
        Me.Label19.TabIndex = 46
        Me.Label19.Text = "Age:"
        '
        'dtpDOB
        '
        Me.dtpDOB.CustomFormat = "dd - MMM - yyyy"
        Me.dtpDOB.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpDOB.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpDOB.Location = New System.Drawing.Point(168, 72)
        Me.dtpDOB.MaxDate = New Date(9998, 11, 16, 0, 0, 0, 0)
        Me.dtpDOB.Name = "dtpDOB"
        Me.dtpDOB.Size = New System.Drawing.Size(184, 23)
        Me.dtpDOB.TabIndex = 2
        Me.dtpDOB.Value = New Date(2006, 11, 16, 0, 0, 0, 0)
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(40, 75)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(97, 19)
        Me.Label18.TabIndex = 44
        Me.Label18.Text = "Date of Birth:"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(40, 51)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(50, 19)
        Me.Label17.TabIndex = 42
        Me.Label17.Text = "Name:"
        '
        'cmbPosition
        '
        Me.cmbPosition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbPosition.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbPosition.Items.AddRange(New Object() {"CEO", "Manager", "General Manager", "Assistance Manager"})
        Me.cmbPosition.Location = New System.Drawing.Point(168, 264)
        Me.cmbPosition.Name = "cmbPosition"
        Me.cmbPosition.Size = New System.Drawing.Size(184, 24)
        Me.cmbPosition.TabIndex = 7
        '
        'txtSignName
        '
        Me.txtSignName.AlphaNumeric = True
        Me.txtSignName.BlankSpace = True
        Me.txtSignName.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSignName.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtSignName.Location = New System.Drawing.Point(168, 48)
        Me.txtSignName.LostFocusColour = System.Drawing.SystemColors.Window
        Me.txtSignName.Mandatory = False
        Me.txtSignName.MaxLength = 30
        Me.txtSignName.Name = "txtSignName"
        Me.txtSignName.Size = New System.Drawing.Size(184, 23)
        Me.txtSignName.SpecialChar = True
        Me.txtSignName.TabIndex = 1
        Me.txtSignName.Text = ""
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(40, 272)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(63, 19)
        Me.Label23.TabIndex = 56
        Me.Label23.Text = "Position:"
        '
        'lblRelation
        '
        Me.lblRelation.AutoSize = True
        Me.lblRelation.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRelation.Location = New System.Drawing.Point(40, 296)
        Me.lblRelation.Name = "lblRelation"
        Me.lblRelation.Size = New System.Drawing.Size(80, 19)
        Me.lblRelation.TabIndex = 55
        Me.lblRelation.Text = "PhoneNo. :"
        '
        'txtAddress
        '
        Me.txtAddress.AlphaNumeric = True
        Me.txtAddress.BlankSpace = True
        Me.txtAddress.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAddress.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtAddress.Location = New System.Drawing.Point(168, 152)
        Me.txtAddress.LostFocusColour = System.Drawing.SystemColors.Window
        Me.txtAddress.Mandatory = False
        Me.txtAddress.MaxLength = 150
        Me.txtAddress.Multiline = True
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtAddress.Size = New System.Drawing.Size(184, 72)
        Me.txtAddress.SpecialChar = True
        Me.txtAddress.TabIndex = 5
        Me.txtAddress.Text = ""
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(40, 160)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(64, 19)
        Me.Label22.TabIndex = 52
        Me.Label22.Text = "Address:"
        '
        'lblNomineeNo
        '
        Me.lblNomineeNo.AutoSize = True
        Me.lblNomineeNo.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNomineeNo.Location = New System.Drawing.Point(40, 27)
        Me.lblNomineeNo.Name = "lblNomineeNo"
        Me.lblNomineeNo.Size = New System.Drawing.Size(43, 19)
        Me.lblNomineeNo.TabIndex = 66
        Me.lblNomineeNo.Text = " No. :"
        '
        'txtno
        '
        Me.txtno.AlphaNumeric = False
        Me.txtno.BackColor = System.Drawing.Color.FromArgb(CType(238, Byte), CType(253, Byte), CType(248, Byte))
        Me.txtno.BlankSpace = False
        Me.txtno.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtno.GotFocusColour = System.Drawing.Color.FromArgb(CType(238, Byte), CType(253, Byte), CType(248, Byte))
        Me.txtno.Location = New System.Drawing.Point(168, 24)
        Me.txtno.LostFocusColour = System.Drawing.Color.FromArgb(CType(238, Byte), CType(253, Byte), CType(248, Byte))
        Me.txtno.Mandatory = False
        Me.txtno.Name = "txtno"
        Me.txtno.ReadOnly = True
        Me.txtno.Size = New System.Drawing.Size(104, 23)
        Me.txtno.SpecialChar = False
        Me.txtno.TabIndex = 68
        Me.txtno.TabStop = False
        Me.txtno.Text = ""
        '
        'btnDelete
        '
        Me.btnDelete.BackColor = System.Drawing.Color.FromArgb(CType(238, Byte), CType(253, Byte), CType(248, Byte))
        Me.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnDelete.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.ForeColor = System.Drawing.Color.Black
        Me.btnDelete.GotFocusColour = System.Drawing.Color.FromArgb(CType(122, Byte), CType(120, Byte), CType(152, Byte))
        Me.btnDelete.Location = New System.Drawing.Point(104, 442)
        Me.btnDelete.LostFocusColour = System.Drawing.Color.FromArgb(CType(238, Byte), CType(253, Byte), CType(248, Byte))
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(88, 32)
        Me.btnDelete.TabIndex = 17
        Me.btnDelete.Text = "&Delete"
        '
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.Color.FromArgb(CType(238, Byte), CType(253, Byte), CType(248, Byte))
        Me.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnAdd.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.ForeColor = System.Drawing.Color.Black
        Me.btnAdd.GotFocusColour = System.Drawing.Color.FromArgb(CType(122, Byte), CType(120, Byte), CType(152, Byte))
        Me.btnAdd.Location = New System.Drawing.Point(16, 442)
        Me.btnAdd.LostFocusColour = System.Drawing.Color.FromArgb(CType(238, Byte), CType(253, Byte), CType(248, Byte))
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(88, 32)
        Me.btnAdd.TabIndex = 16
        Me.btnAdd.Text = "&Add"
        '
        'btnPrevious
        '
        Me.btnPrevious.BackColor = System.Drawing.Color.FromArgb(CType(238, Byte), CType(253, Byte), CType(248, Byte))
        Me.btnPrevious.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPrevious.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnPrevious.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrevious.ForeColor = System.Drawing.Color.Black
        Me.btnPrevious.GotFocusColour = System.Drawing.Color.FromArgb(CType(122, Byte), CType(120, Byte), CType(152, Byte))
        Me.btnPrevious.Image = CType(resources.GetObject("btnPrevious.Image"), System.Drawing.Image)
        Me.btnPrevious.Location = New System.Drawing.Point(376, 442)
        Me.btnPrevious.LostFocusColour = System.Drawing.Color.FromArgb(CType(238, Byte), CType(253, Byte), CType(248, Byte))
        Me.btnPrevious.Name = "btnPrevious"
        Me.btnPrevious.Size = New System.Drawing.Size(48, 32)
        Me.btnPrevious.TabIndex = 19
        '
        'btnNext
        '
        Me.btnNext.BackColor = System.Drawing.Color.FromArgb(CType(238, Byte), CType(253, Byte), CType(248, Byte))
        Me.btnNext.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnNext.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNext.ForeColor = System.Drawing.Color.Black
        Me.btnNext.GotFocusColour = System.Drawing.Color.FromArgb(CType(122, Byte), CType(120, Byte), CType(152, Byte))
        Me.btnNext.Image = CType(resources.GetObject("btnNext.Image"), System.Drawing.Image)
        Me.btnNext.Location = New System.Drawing.Point(424, 442)
        Me.btnNext.LostFocusColour = System.Drawing.Color.FromArgb(CType(238, Byte), CType(253, Byte), CType(248, Byte))
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(48, 32)
        Me.btnNext.TabIndex = 20
        '
        'txtPhoneNo
        '
        Me.txtPhoneNo.AfterDecimal = 0
        Me.txtPhoneNo.BeforeDecimal = 12
        Me.txtPhoneNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPhoneNo.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtPhoneNo.Location = New System.Drawing.Point(184, 352)
        Me.txtPhoneNo.LostFocusColour = System.Drawing.Color.Empty
        Me.txtPhoneNo.MaxValue = 0
        Me.txtPhoneNo.MinValue = 0
        Me.txtPhoneNo.Name = "txtPhoneNo"
        Me.txtPhoneNo.Size = New System.Drawing.Size(184, 22)
        Me.txtPhoneNo.TabIndex = 8
        Me.txtPhoneNo.Text = ""
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(276, 16)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(50, 19)
        Me.Label3.TabIndex = 82
        Me.Label3.Text = "Name:"
        '
        'txtName
        '
        Me.txtName.AlphaNumeric = False
        Me.txtName.BackColor = System.Drawing.Color.FromArgb(CType(238, Byte), CType(253, Byte), CType(248, Byte))
        Me.txtName.BlankSpace = False
        Me.txtName.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtName.GotFocusColour = System.Drawing.Color.FromArgb(CType(238, Byte), CType(253, Byte), CType(248, Byte))
        Me.txtName.Location = New System.Drawing.Point(328, 16)
        Me.txtName.LostFocusColour = System.Drawing.Color.FromArgb(CType(238, Byte), CType(253, Byte), CType(248, Byte))
        Me.txtName.Mandatory = False
        Me.txtName.Name = "txtName"
        Me.txtName.ReadOnly = True
        Me.txtName.Size = New System.Drawing.Size(248, 23)
        Me.txtName.SpecialChar = False
        Me.txtName.TabIndex = 84
        Me.txtName.TabStop = False
        Me.txtName.Text = ""
        '
        'lblAccountNo
        '
        Me.lblAccountNo.AutoSize = True
        Me.lblAccountNo.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAccountNo.Location = New System.Drawing.Point(96, 16)
        Me.lblAccountNo.Name = "lblAccountNo"
        Me.lblAccountNo.Size = New System.Drawing.Size(43, 19)
        Me.lblAccountNo.TabIndex = 81
        Me.lblAccountNo.Text = " No. :"
        '
        'txtAccountNo
        '
        Me.txtAccountNo.AlphaNumeric = False
        Me.txtAccountNo.BackColor = System.Drawing.Color.FromArgb(CType(238, Byte), CType(253, Byte), CType(248, Byte))
        Me.txtAccountNo.BlankSpace = False
        Me.txtAccountNo.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAccountNo.GotFocusColour = System.Drawing.Color.FromArgb(CType(238, Byte), CType(253, Byte), CType(248, Byte))
        Me.txtAccountNo.Location = New System.Drawing.Point(152, 16)
        Me.txtAccountNo.LostFocusColour = System.Drawing.Color.FromArgb(CType(238, Byte), CType(253, Byte), CType(248, Byte))
        Me.txtAccountNo.Mandatory = False
        Me.txtAccountNo.Name = "txtAccountNo"
        Me.txtAccountNo.ReadOnly = True
        Me.txtAccountNo.Size = New System.Drawing.Size(104, 23)
        Me.txtAccountNo.SpecialChar = False
        Me.txtAccountNo.TabIndex = 83
        Me.txtAccountNo.TabStop = False
        Me.txtAccountNo.Text = ""
        '
        'txtmoblieNo
        '
        Me.txtmoblieNo.AfterDecimal = 0
        Me.txtmoblieNo.BeforeDecimal = 10
        Me.txtmoblieNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtmoblieNo.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtmoblieNo.Location = New System.Drawing.Point(184, 384)
        Me.txtmoblieNo.LostFocusColour = System.Drawing.Color.Empty
        Me.txtmoblieNo.MaxValue = 0
        Me.txtmoblieNo.MinValue = 0
        Me.txtmoblieNo.Name = "txtmoblieNo"
        Me.txtmoblieNo.Size = New System.Drawing.Size(184, 22)
        Me.txtmoblieNo.TabIndex = 9
        Me.txtmoblieNo.Text = ""
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(56, 384)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(69, 17)
        Me.Label4.TabIndex = 85
        Me.Label4.Text = "MobileNo. :"
        '
        'frmSignatoryDetails
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.FromArgb(CType(238, Byte), CType(253, Byte), CType(248, Byte))
        Me.CancelButton = Me.btnClose
        Me.ClientSize = New System.Drawing.Size(680, 493)
        Me.Controls.Add(Me.txtmoblieNo)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.lblAccountNo)
        Me.Controls.Add(Me.txtAccountNo)
        Me.Controls.Add(Me.txtPhoneNo)
        Me.Controls.Add(Me.btnOK)
        Me.Controls.Add(Me.lblRecords)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.btnPrevious)
        Me.Controls.Add(Me.btnNext)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmSignatoryDetails"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Signatory Detail"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region "Sub Routines and Functions"

    Function fnGetSignatories() As Boolean
        If txtAccountNo.Text <> "" Then
            If objSig.fnGetSignatories(txtAccountNo.Text) Then
                intNo = 0
                objDT = objSig.SignatoryTable
                Return True
            End If
        End If
        Return False
    End Function

    Function fnLoadSignotoriesDetails() As Boolean

        Dim msStream As New MemoryStream

        If Not objDT Is Nothing Then
            If intNo >= objDT.Rows.Count Then
                Exit Function
            End If
        Else
            Exit Function
        End If
        sbClear()
        lblRecords.Text = "Record " & intNo + 1 & " of " & objDT.Rows.Count
        txtno.Text = objDT.Rows(intNo).Item("No")
        txtSignName.Text = objDT.Rows(intNo).Item("SignName")
        dtpDOB.Value = objDT.Rows(intNo).Item("DOB")
        txtAge.Text = objDT.Rows(intNo).Item("Age")

        If objDT.Rows(intNo).Item("Gender") = "M" Then
            rdbMale.Checked = True
        Else
            rdbFemale.Checked = True
        End If

        txtAddress.Text = objDT.Rows(intNo).Item("SigAdder")
        cmbPosition.SelectedItem = objDT.Rows(intNo).Item("Position")
        cmbSignatory.SelectedItem = objDT.Rows(intNo).Item("SignatoryStatus")
        txtPhoneNo.Text = objDT.Rows(intNo).Item("PhoneNo")
        txtmoblieNo.Text = objDT.Rows(intNo).Item("MobileNo")

        If Not IsDBNull(objDT.Rows(intNo).Item("Photo")) Then
            If objDT.Rows(intNo).Item("Photo").length > 0 Then
                msStream = New MemoryStream(objDT.Rows(intNo).Item("Photo"), True)
                msStream.Write(objDT.Rows(intNo).Item("Photo"), 0, objDT.Rows(intNo).Item("Photo").length)
                picPhoto.Image = Image.FromStream(msStream)
                msStream.Close()
            End If
        End If

        If Not IsDBNull(objDT.Rows(intNo).Item("Signature")) Then
            If objDT.Rows(intNo).Item("Signature").length > 0 Then
                msStream = New MemoryStream(objDT.Rows(intNo).Item("Signature"), True)
                msStream.Write(objDT.Rows(intNo).Item("Signature"), 0, objDT.Rows(intNo).Item("Signature").length)
                picSign.Image = Image.FromStream(msStream)
                msStream.Close()
            End If
        End If

    End Function

    Sub sbClear()
        'txtno.ResetText()
        txtSignName.ResetText()
        txtAge.ResetText()
        rdbMale.Checked = True
        txtAddress.ResetText()
        cmbPosition.SelectedIndex = 0
        cmbSignatory.SelectedIndex = 0
        txtPhoneNo.ResetText()
        picPhoto.Image = Nothing
        picSign.Image = Nothing
        txtmoblieNo.ResetText()
    End Sub

    Function fnCheck() As Boolean
        If Trim(txtSignName.Text) = "" Then
            MsgBox("Signatory name can not be blank", MsgBoxStyle.Exclamation)
            txtSignName.Focus()
            Return False
        ElseIf Trim(txtAge.Text) = "" Then
            MsgBox("Enter age", MsgBoxStyle.Exclamation)
            txtAge.Focus()
            Return False
        ElseIf Trim(txtAddress.Text) = "" Then
            MsgBox("Enter signatory address", MsgBoxStyle.Exclamation)
            txtAddress.Focus()
            Return False
        ElseIf cmbPosition.SelectedIndex < 0 Then
            MsgBox("Select nominee occupation", MsgBoxStyle.Exclamation)
            cmbPosition.Focus()
            Return False
        Else
            Return True
        End If
    End Function

    'Function fnCADetail() As Boolean
    '    Dim mandatory, first, second As String
    '    Dim intNo As Integer = 0
    '    Dim objtrans As IDbTransaction
    '    Try
    '        While intNo < objDT.Rows.Count
    '            If objDT.Rows(intNo).Item("SignatoryStatus") = "First Signatory" Then
    '                first = objDT.Rows(intNo).Item("SignName")
    '            ElseIf objDT.Rows(intNo).Item("SignatoryStatus") = "Second Signatory" Then
    '                second = objDT.Rows(intNo).Item("SignName")
    '            Else
    '                mandatory = objDT.Rows(intNo).Item("SignName")
    '            End If
    '            intNo += 1
    '        End While
    '        If objSig.fnupdatesign(mandatory, first, second, objtrans) Then
    '            Return True
    '        Else
    '            Return False
    '        End If
    '    Catch
    '        MsgBox("error")
    '    Finally
    '        objtrans.Dispose()
    '    End Try



    'End Function

    'Function fnCAinDetail() As Boolean
    '    Dim mandatory, first, second As String
    '    Dim intNo As Integer = 0
    '    Dim objTrans As IDbTransaction
    '    Try
    '        While intNo < objDT.Rows.Count
    '            If objDT.Rows(intNo).Item("SignatoryStatus") = "FirstSignatory" Then
    '                first = objDT.Rows(intNo).Item("SignName")
    '            ElseIf objDT.Rows(intNo).Item("SignatoryStatus") = "SecondSignatory" Then
    '                second = objDT.Rows(intNo).Item("SignName")
    '            Else
    '                mandatory = objDT.Rows(intNo).Item("SignName")
    '            End If
    '            intNo += 1
    '        End While
    '        If objSig.fninsertSign(mandatory, first, second, objTrans) Then
    '            Return True
    '        Else
    '            Return False
    '        End If
    '    Catch
    '        MsgBox("error")
    '    Finally
    '        objTrans.Dispose()
    '    End Try



    'End Function


    Function fnSetData() As Boolean
        objSig.number = txtno.Text
        objSig.Curno = txtAccountNo.Text
        objSig.SignatoryName = txtSignName.Text
        objSig.SignatoryDOB = dtpDOB.Value
        objSig.Age = txtAge.Text
        objSig.Gender = IIf(rdbMale.Checked = True, "M", "F")
        objSig.address = txtAddress.Text
        objSig.Signstatus = cmbSignatory.SelectedItem
        objSig.Position = cmbPosition.SelectedItem
        objSig.PhoneNo = txtPhoneNo.Text
        objSig.MoblieNo = txtmoblieNo.Text
        objSig.Photo = fnGetPhoto()
        objSig.Sign = fnGetSign()
        Return True

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

    'To get Byte array for Signature object, function called while setting values to the Class Properties
    Function fnGetSign() As Byte()
        Try
            If Not picSign.Image Is Nothing Then
                Dim msStream As New MemoryStream
                Dim bytArr() As Byte
                picSign.Image.Save(msStream, picSign.Image.RawFormat)
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

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnPhotoCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPhotoCancel.Click
        picPhoto.Image = Nothing
    End Sub

    Private Sub btnSignCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSignCancel.Click
        picSign.Image = Nothing
    End Sub

    Private Sub btnPhotoLoad_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPhotoLoad.Click
        If OpenFileDialog1.ShowDialog <> DialogResult.Cancel Then
            Try
                picPhoto.Image = Image.FromFile(OpenFileDialog1.FileName)
            Catch
                MsgBox("select image files only", MsgBoxStyle.Exclamation)
            End Try
        End If
    End Sub

    Private Sub btnSignLoad_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSignLoad.Click
        If OpenFileDialog1.ShowDialog <> DialogResult.Cancel Then
            Try
                picSign.Image = Image.FromFile(OpenFileDialog1.FileName)
            Catch
                MsgBox("Select image file only", MsgBoxStyle.Exclamation)
            End Try
        End If
    End Sub

    Private Sub picPhoto_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles picPhoto.Click
        btnPhotoLoad_Click(sender, e)
    End Sub

    Private Sub picSign_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles picSign.Click
        btnSignLoad_Click(sender, e)
    End Sub

    Private Sub btnNext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNext.Click
        If Not objDT Is Nothing Then
            If intNo <> objDT.Rows.Count - 1 Then
                intNo += 1
                fnLoadSignotoriesDetails()
            End If
        End If
    End Sub

    Private Sub btnPrevious_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrevious.Click
        If intNo <> 0 Then
            intNo -= 1
            fnLoadSignotoriesDetails()
        End If
    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        txtno.Text = objSig.fnGetNewNo(txtAccountNo.Text)
        intNo += 1
        sbClear()
        txtSignName.Focus()
    End Sub

    Private Sub btnOK_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnOK.Click

        Dim objTrans As IDbTransaction
        objTrans = fnGetTransaction()

        Try
            If fnCheck() Then
                If fnSetData() Then

                    If objSig.fnCheckSignatories(txtno.Text, txtAccountNo.Text) = True Then
                        If objSig.fnUpdateSignatory(objTrans) Then
                            objTrans.Commit()
                            MsgBox("Signatory details updated successfully", MsgBoxStyle.Information)
                        Else
                            MsgBox("Updation failed, because of internal error", MsgBoxStyle.Exclamation)
                        End If
                    Else
                        If objSig.fnAddSignatory(objTrans) Then
                            objTrans.Commit()
                            MsgBox("Signatory details added successfully", MsgBoxStyle.Information)
                        Else
                            MsgBox("Addition failed, because of internal error", MsgBoxStyle.Exclamation)
                        End If
                    End If
                    btnAdd_Click(sender, e)
                End If
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            objTrans.Dispose()
        End Try
       
    End Sub

    Private Sub dtpDOB_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtpDOB.ValueChanged
        txtAge.Text = DateDiff(DateInterval.Year, dtpDOB.Value, Date.Now)
    End Sub

    Private Sub btnDelete_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        If MsgBox("Are you sure you want to delete this record?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirm Delete") = MsgBoxResult.Yes Then
            If objSig.fnDeleteSignatory(txtAccountNo.Text, txtno.Text) Then
                MsgBox("Deleted successfully", MsgBoxStyle.Information)
                btnAdd_Click(sender, e)
                If fnGetSignatories() Then
                    fnLoadSignotoriesDetails()
                End If
            End If
        End If
    End Sub

    Private Sub frmSignatoryDetails_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If fnGetSignatories() Then
            fnLoadSignotoriesDetails()
        Else
            btnAdd_Click(sender, e)
        End If
    End Sub

End Class
