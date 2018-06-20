Imports System.IO
Public Class frmNominees
    Inherits System.Windows.Forms.Form

#Region "Form Global Variables"
    Dim objNominee As New clsNominee
    Dim objMember As New clsMember
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
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents picPhoto As System.Windows.Forms.PictureBox
    Friend WithEvents lblPhoto As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnClose As BankControls.NewButton
    Friend WithEvents btnPrevious As BankControls.NewButton
    Friend WithEvents btnNext As BankControls.NewButton
    Friend WithEvents btnPhotoLoad As BankControls.NewButton
    Friend WithEvents btnPhotoCancel As BankControls.NewButton
    Friend WithEvents btnSignCancel As BankControls.NewButton
    Friend WithEvents btnSignLoad As BankControls.NewButton
    Friend WithEvents picSign As System.Windows.Forms.PictureBox
    Friend WithEvents txtName As BankControls.TextControl
    Friend WithEvents txtAccountNo As BankControls.TextControl
    Friend WithEvents btnAdd As BankControls.NewButton
    Friend WithEvents btnDelete As BankControls.NewButton
    Friend WithEvents btnOK As BankControls.NewButton
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents lblRecords As System.Windows.Forms.Label
    Friend WithEvents lblAccountNo As System.Windows.Forms.Label
    Friend WithEvents rdbMale As System.Windows.Forms.RadioButton
    Friend WithEvents rdbFemale As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtFatherName As BankControls.TextControl
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton2 As System.Windows.Forms.RadioButton
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents txtAge As BankControls.NumericControl
    Friend WithEvents dtpDOB As System.Windows.Forms.DateTimePicker
    Friend WithEvents cmbOccupation As System.Windows.Forms.ComboBox
    Friend WithEvents txtNomineeName As BankControls.TextControl
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents lblRelation As System.Windows.Forms.Label
    Friend WithEvents txtAddress As BankControls.TextControl
    Friend WithEvents cmbRelation As System.Windows.Forms.ComboBox
    Friend WithEvents rdbMajor As System.Windows.Forms.RadioButton
    Friend WithEvents rdbMinor As System.Windows.Forms.RadioButton
    Friend WithEvents txtNomineeNo As BankControls.TextControl
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lblNomineeNo As System.Windows.Forms.Label
    Friend WithEvents Label28 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmNominees))
        Me.btnAdd = New BankControls.NewButton
        Me.btnDelete = New BankControls.NewButton
        Me.btnOK = New BankControls.NewButton
        Me.btnClose = New BankControls.NewButton
        Me.btnPrevious = New BankControls.NewButton
        Me.btnNext = New BankControls.NewButton
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.btnPhotoLoad = New BankControls.NewButton
        Me.picPhoto = New System.Windows.Forms.PictureBox
        Me.lblPhoto = New System.Windows.Forms.Label
        Me.btnPhotoCancel = New BankControls.NewButton
        Me.Label2 = New System.Windows.Forms.Label
        Me.btnSignCancel = New BankControls.NewButton
        Me.btnSignLoad = New BankControls.NewButton
        Me.picSign = New System.Windows.Forms.PictureBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtName = New BankControls.TextControl
        Me.lblAccountNo = New System.Windows.Forms.Label
        Me.txtAccountNo = New BankControls.TextControl
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog
        Me.lblRecords = New System.Windows.Forms.Label
        Me.rdbMale = New System.Windows.Forms.RadioButton
        Me.rdbFemale = New System.Windows.Forms.RadioButton
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label28 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtFatherName = New BankControls.TextControl
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.RadioButton1 = New System.Windows.Forms.RadioButton
        Me.RadioButton2 = New System.Windows.Forms.RadioButton
        Me.Label20 = New System.Windows.Forms.Label
        Me.txtAge = New BankControls.NumericControl
        Me.dtpDOB = New System.Windows.Forms.DateTimePicker
        Me.cmbOccupation = New System.Windows.Forms.ComboBox
        Me.Label23 = New System.Windows.Forms.Label
        Me.lblRelation = New System.Windows.Forms.Label
        Me.txtAddress = New BankControls.TextControl
        Me.cmbRelation = New System.Windows.Forms.ComboBox
        Me.rdbMajor = New System.Windows.Forms.RadioButton
        Me.rdbMinor = New System.Windows.Forms.RadioButton
        Me.txtNomineeNo = New BankControls.TextControl
        Me.Label17 = New System.Windows.Forms.Label
        Me.txtNomineeName = New BankControls.TextControl
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.lblNomineeNo = New System.Windows.Forms.Label
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.GroupBox2.SuspendLayout()
        CType(Me.picPhoto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picSign, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(253, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnAdd.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.ForeColor = System.Drawing.Color.Black
        Me.btnAdd.GotFocusColour = System.Drawing.Color.FromArgb(CType(CType(122, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(152, Byte), Integer))
        Me.btnAdd.Location = New System.Drawing.Point(24, 456)
        Me.btnAdd.LostFocusColour = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(253, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(88, 32)
        Me.btnAdd.TabIndex = 17
        Me.btnAdd.Text = "&Add"
        Me.btnAdd.UseVisualStyleBackColor = False
        '
        'btnDelete
        '
        Me.btnDelete.BackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(253, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnDelete.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.ForeColor = System.Drawing.Color.Black
        Me.btnDelete.GotFocusColour = System.Drawing.Color.FromArgb(CType(CType(122, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(152, Byte), Integer))
        Me.btnDelete.Location = New System.Drawing.Point(112, 456)
        Me.btnDelete.LostFocusColour = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(253, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(88, 32)
        Me.btnDelete.TabIndex = 18
        Me.btnDelete.Text = "&Delete"
        Me.btnDelete.UseVisualStyleBackColor = False
        '
        'btnOK
        '
        Me.btnOK.BackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(253, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.btnOK.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnOK.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnOK.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOK.ForeColor = System.Drawing.Color.Black
        Me.btnOK.GotFocusColour = System.Drawing.Color.FromArgb(CType(CType(122, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(152, Byte), Integer))
        Me.btnOK.Location = New System.Drawing.Point(495, 456)
        Me.btnOK.LostFocusColour = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(253, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(88, 32)
        Me.btnOK.TabIndex = 15
        Me.btnOK.Text = "&Save"
        Me.btnOK.UseVisualStyleBackColor = False
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(253, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.btnClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnClose.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.ForeColor = System.Drawing.Color.Black
        Me.btnClose.GotFocusColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnClose.Location = New System.Drawing.Point(584, 456)
        Me.btnClose.LostFocusColour = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(253, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(88, 32)
        Me.btnClose.TabIndex = 16
        Me.btnClose.Text = "&Close"
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'btnPrevious
        '
        Me.btnPrevious.BackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(253, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.btnPrevious.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPrevious.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnPrevious.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrevious.ForeColor = System.Drawing.Color.Black
        Me.btnPrevious.GotFocusColour = System.Drawing.Color.FromArgb(CType(CType(122, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(152, Byte), Integer))
        Me.btnPrevious.Image = CType(resources.GetObject("btnPrevious.Image"), System.Drawing.Image)
        Me.btnPrevious.Location = New System.Drawing.Point(384, 456)
        Me.btnPrevious.LostFocusColour = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(253, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.btnPrevious.Name = "btnPrevious"
        Me.btnPrevious.Size = New System.Drawing.Size(48, 32)
        Me.btnPrevious.TabIndex = 59
        Me.btnPrevious.UseVisualStyleBackColor = False
        '
        'btnNext
        '
        Me.btnNext.BackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(253, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.btnNext.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnNext.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNext.ForeColor = System.Drawing.Color.Black
        Me.btnNext.GotFocusColour = System.Drawing.Color.FromArgb(CType(CType(122, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(152, Byte), Integer))
        Me.btnNext.Image = CType(resources.GetObject("btnNext.Image"), System.Drawing.Image)
        Me.btnNext.Location = New System.Drawing.Point(432, 456)
        Me.btnNext.LostFocusColour = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(253, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(48, 32)
        Me.btnNext.TabIndex = 59
        Me.btnNext.UseVisualStyleBackColor = False
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
        Me.GroupBox2.Location = New System.Drawing.Point(448, 80)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(248, 360)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        '
        'btnPhotoLoad
        '
        Me.btnPhotoLoad.BackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(253, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.btnPhotoLoad.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPhotoLoad.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnPhotoLoad.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPhotoLoad.ForeColor = System.Drawing.Color.Black
        Me.btnPhotoLoad.GotFocusColour = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(171, Byte), Integer))
        Me.btnPhotoLoad.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnPhotoLoad.Location = New System.Drawing.Point(80, 128)
        Me.btnPhotoLoad.LostFocusColour = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(253, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.btnPhotoLoad.Name = "btnPhotoLoad"
        Me.btnPhotoLoad.Size = New System.Drawing.Size(64, 24)
        Me.btnPhotoLoad.TabIndex = 11
        Me.btnPhotoLoad.Text = "Load"
        Me.btnPhotoLoad.UseVisualStyleBackColor = False
        '
        'picPhoto
        '
        Me.picPhoto.BackgroundImage = CType(resources.GetObject("picPhoto.BackgroundImage"), System.Drawing.Image)
        Me.picPhoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picPhoto.Cursor = System.Windows.Forms.Cursors.Hand
        Me.picPhoto.Location = New System.Drawing.Point(96, 24)
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
        Me.lblPhoto.Location = New System.Drawing.Point(16, 24)
        Me.lblPhoto.Name = "lblPhoto"
        Me.lblPhoto.Size = New System.Drawing.Size(62, 16)
        Me.lblPhoto.TabIndex = 53
        Me.lblPhoto.Text = "Photo : "
        '
        'btnPhotoCancel
        '
        Me.btnPhotoCancel.BackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(253, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.btnPhotoCancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPhotoCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnPhotoCancel.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPhotoCancel.ForeColor = System.Drawing.Color.Black
        Me.btnPhotoCancel.GotFocusColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnPhotoCancel.Location = New System.Drawing.Point(144, 128)
        Me.btnPhotoCancel.LostFocusColour = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(253, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.btnPhotoCancel.Name = "btnPhotoCancel"
        Me.btnPhotoCancel.Size = New System.Drawing.Size(64, 24)
        Me.btnPhotoCancel.TabIndex = 12
        Me.btnPhotoCancel.Text = "Cancel"
        Me.btnPhotoCancel.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(8, 200)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(87, 16)
        Me.Label2.TabIndex = 53
        Me.Label2.Text = "Signature : "
        '
        'btnSignCancel
        '
        Me.btnSignCancel.BackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(253, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.btnSignCancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSignCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSignCancel.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSignCancel.ForeColor = System.Drawing.Color.Black
        Me.btnSignCancel.GotFocusColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnSignCancel.Location = New System.Drawing.Point(144, 304)
        Me.btnSignCancel.LostFocusColour = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(253, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.btnSignCancel.Name = "btnSignCancel"
        Me.btnSignCancel.Size = New System.Drawing.Size(64, 24)
        Me.btnSignCancel.TabIndex = 14
        Me.btnSignCancel.Text = "Cancel"
        Me.btnSignCancel.UseVisualStyleBackColor = False
        '
        'btnSignLoad
        '
        Me.btnSignLoad.BackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(253, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.btnSignLoad.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSignLoad.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSignLoad.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSignLoad.ForeColor = System.Drawing.Color.Black
        Me.btnSignLoad.GotFocusColour = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(171, Byte), Integer))
        Me.btnSignLoad.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSignLoad.Location = New System.Drawing.Point(80, 304)
        Me.btnSignLoad.LostFocusColour = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(253, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.btnSignLoad.Name = "btnSignLoad"
        Me.btnSignLoad.Size = New System.Drawing.Size(64, 24)
        Me.btnSignLoad.TabIndex = 13
        Me.btnSignLoad.Text = "Load"
        Me.btnSignLoad.UseVisualStyleBackColor = False
        '
        'picSign
        '
        Me.picSign.BackgroundImage = CType(resources.GetObject("picSign.BackgroundImage"), System.Drawing.Image)
        Me.picSign.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picSign.Cursor = System.Windows.Forms.Cursors.Hand
        Me.picSign.Location = New System.Drawing.Point(96, 200)
        Me.picSign.Name = "picSign"
        Me.picSign.Size = New System.Drawing.Size(96, 100)
        Me.picSign.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picSign.TabIndex = 54
        Me.picSign.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(328, 24)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(60, 16)
        Me.Label3.TabIndex = 67
        Me.Label3.Text = "Name : "
        '
        'txtName
        '
        Me.txtName.AlphaNumeric = True
        Me.txtName.BackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(253, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.txtName.BlankSpace = True
        Me.txtName.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtName.GotFocusColour = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(253, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.txtName.Location = New System.Drawing.Point(392, 24)
        Me.txtName.LostFocusColour = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(253, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.txtName.Mandatory = False
        Me.txtName.Name = "txtName"
        Me.txtName.ReadOnly = True
        Me.txtName.Size = New System.Drawing.Size(248, 23)
        Me.txtName.SpecialChar = False
        Me.txtName.TabIndex = 69
        Me.txtName.TabStop = False
        '
        'lblAccountNo
        '
        Me.lblAccountNo.AutoSize = True
        Me.lblAccountNo.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAccountNo.Location = New System.Drawing.Point(32, 24)
        Me.lblAccountNo.Name = "lblAccountNo"
        Me.lblAccountNo.Size = New System.Drawing.Size(111, 16)
        Me.lblAccountNo.TabIndex = 66
        Me.lblAccountNo.Text = "Account  No. : "
        '
        'txtAccountNo
        '
        Me.txtAccountNo.AlphaNumeric = False
        Me.txtAccountNo.BackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(253, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.txtAccountNo.BlankSpace = False
        Me.txtAccountNo.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAccountNo.GotFocusColour = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(253, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.txtAccountNo.Location = New System.Drawing.Point(144, 24)
        Me.txtAccountNo.LostFocusColour = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(253, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.txtAccountNo.Mandatory = False
        Me.txtAccountNo.Name = "txtAccountNo"
        Me.txtAccountNo.ReadOnly = True
        Me.txtAccountNo.Size = New System.Drawing.Size(104, 23)
        Me.txtAccountNo.SpecialChar = False
        Me.txtAccountNo.TabIndex = 68
        Me.txtAccountNo.TabStop = False
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.Filter = "BMP files|*.bmp|JPEG files|*.jpg|GIF files|*.gif"
        '
        'lblRecords
        '
        Me.lblRecords.AutoSize = True
        Me.lblRecords.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRecords.Location = New System.Drawing.Point(216, 464)
        Me.lblRecords.Name = "lblRecords"
        Me.lblRecords.Size = New System.Drawing.Size(0, 16)
        Me.lblRecords.TabIndex = 66
        '
        'rdbMale
        '
        Me.rdbMale.Checked = True
        Me.rdbMale.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdbMale.Location = New System.Drawing.Point(8, 8)
        Me.rdbMale.Name = "rdbMale"
        Me.rdbMale.Size = New System.Drawing.Size(72, 24)
        Me.rdbMale.TabIndex = 5
        Me.rdbMale.TabStop = True
        Me.rdbMale.Text = "Male"
        '
        'rdbFemale
        '
        Me.rdbFemale.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdbFemale.Location = New System.Drawing.Point(88, 8)
        Me.rdbFemale.Name = "rdbFemale"
        Me.rdbFemale.Size = New System.Drawing.Size(72, 24)
        Me.rdbFemale.TabIndex = 5
        Me.rdbFemale.Text = "Female"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label28)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtFatherName)
        Me.GroupBox1.Controls.Add(Me.GroupBox3)
        Me.GroupBox1.Controls.Add(Me.Label20)
        Me.GroupBox1.Controls.Add(Me.txtAge)
        Me.GroupBox1.Controls.Add(Me.dtpDOB)
        Me.GroupBox1.Controls.Add(Me.cmbOccupation)
        Me.GroupBox1.Controls.Add(Me.Label23)
        Me.GroupBox1.Controls.Add(Me.lblRelation)
        Me.GroupBox1.Controls.Add(Me.txtAddress)
        Me.GroupBox1.Controls.Add(Me.cmbRelation)
        Me.GroupBox1.Controls.Add(Me.rdbMajor)
        Me.GroupBox1.Controls.Add(Me.rdbMinor)
        Me.GroupBox1.Controls.Add(Me.txtNomineeNo)
        Me.GroupBox1.Controls.Add(Me.Label17)
        Me.GroupBox1.Controls.Add(Me.txtNomineeName)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.lblNomineeNo)
        Me.GroupBox1.Location = New System.Drawing.Point(16, 80)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(416, 360)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label28.Location = New System.Drawing.Point(8, 56)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(115, 16)
        Me.Label28.TabIndex = 77
        Me.Label28.Text = "Husband Name  "
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(16, 40)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(67, 16)
        Me.Label4.TabIndex = 76
        Me.Label4.Text = "Father / "
        '
        'txtFatherName
        '
        Me.txtFatherName.AlphaNumeric = True
        Me.txtFatherName.BlankSpace = True
        Me.txtFatherName.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFatherName.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtFatherName.Location = New System.Drawing.Point(128, 48)
        Me.txtFatherName.LostFocusColour = System.Drawing.Color.Empty
        Me.txtFatherName.Mandatory = False
        Me.txtFatherName.MaxLength = 30
        Me.txtFatherName.Name = "txtFatherName"
        Me.txtFatherName.Size = New System.Drawing.Size(184, 23)
        Me.txtFatherName.SpecialChar = True
        Me.txtFatherName.TabIndex = 1
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.RadioButton1)
        Me.GroupBox3.Controls.Add(Me.RadioButton2)
        Me.GroupBox3.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(128, 168)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(184, 40)
        Me.GroupBox3.TabIndex = 5
        Me.GroupBox3.TabStop = False
        '
        'RadioButton1
        '
        Me.RadioButton1.Checked = True
        Me.RadioButton1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton1.Location = New System.Drawing.Point(8, 12)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(72, 24)
        Me.RadioButton1.TabIndex = 6
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "Male"
        '
        'RadioButton2
        '
        Me.RadioButton2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton2.Location = New System.Drawing.Point(88, 12)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(72, 24)
        Me.RadioButton2.TabIndex = 7
        Me.RadioButton2.Text = "Female"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(8, 176)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(70, 16)
        Me.Label20.TabIndex = 48
        Me.Label20.Text = "Gender : "
        '
        'txtAge
        '
        Me.txtAge.AfterDecimal = 0
        Me.txtAge.BeforeDecimal = 3
        Me.txtAge.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAge.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtAge.Location = New System.Drawing.Point(128, 112)
        Me.txtAge.LostFocusColour = System.Drawing.SystemColors.Window
        Me.txtAge.MaxLength = 3
        Me.txtAge.MaxValue = 100
        Me.txtAge.MinValue = 0
        Me.txtAge.Name = "txtAge"
        Me.txtAge.Size = New System.Drawing.Size(48, 23)
        Me.txtAge.TabIndex = 3
        Me.txtAge.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'dtpDOB
        '
        Me.dtpDOB.CustomFormat = "dd - MMM - yyyy"
        Me.dtpDOB.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpDOB.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpDOB.Location = New System.Drawing.Point(128, 80)
        Me.dtpDOB.Name = "dtpDOB"
        Me.dtpDOB.Size = New System.Drawing.Size(184, 23)
        Me.dtpDOB.TabIndex = 2
        Me.dtpDOB.Value = New Date(2006, 11, 16, 0, 0, 0, 0)
        '
        'cmbOccupation
        '
        Me.cmbOccupation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbOccupation.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbOccupation.Location = New System.Drawing.Point(128, 288)
        Me.cmbOccupation.Name = "cmbOccupation"
        Me.cmbOccupation.Size = New System.Drawing.Size(184, 24)
        Me.cmbOccupation.TabIndex = 9
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(8, 288)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(99, 16)
        Me.Label23.TabIndex = 56
        Me.Label23.Text = "Occupation : "
        '
        'lblRelation
        '
        Me.lblRelation.AutoSize = True
        Me.lblRelation.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRelation.Location = New System.Drawing.Point(8, 320)
        Me.lblRelation.Name = "lblRelation"
        Me.lblRelation.Size = New System.Drawing.Size(81, 16)
        Me.lblRelation.TabIndex = 55
        Me.lblRelation.Text = "Relation :  "
        '
        'txtAddress
        '
        Me.txtAddress.AlphaNumeric = True
        Me.txtAddress.BlankSpace = True
        Me.txtAddress.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAddress.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtAddress.Location = New System.Drawing.Point(128, 208)
        Me.txtAddress.LostFocusColour = System.Drawing.SystemColors.Window
        Me.txtAddress.Mandatory = False
        Me.txtAddress.MaxLength = 300
        Me.txtAddress.Multiline = True
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtAddress.Size = New System.Drawing.Size(184, 72)
        Me.txtAddress.SpecialChar = True
        Me.txtAddress.TabIndex = 8
        '
        'cmbRelation
        '
        Me.cmbRelation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbRelation.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbRelation.Location = New System.Drawing.Point(128, 320)
        Me.cmbRelation.Name = "cmbRelation"
        Me.cmbRelation.Size = New System.Drawing.Size(184, 24)
        Me.cmbRelation.TabIndex = 10
        '
        'rdbMajor
        '
        Me.rdbMajor.BackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(253, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.rdbMajor.Checked = True
        Me.rdbMajor.Enabled = False
        Me.rdbMajor.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdbMajor.Location = New System.Drawing.Point(136, 144)
        Me.rdbMajor.Name = "rdbMajor"
        Me.rdbMajor.Size = New System.Drawing.Size(72, 24)
        Me.rdbMajor.TabIndex = 4
        Me.rdbMajor.TabStop = True
        Me.rdbMajor.Text = "Major"
        Me.rdbMajor.UseVisualStyleBackColor = False
        '
        'rdbMinor
        '
        Me.rdbMinor.BackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(253, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.rdbMinor.Enabled = False
        Me.rdbMinor.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdbMinor.Location = New System.Drawing.Point(240, 144)
        Me.rdbMinor.Name = "rdbMinor"
        Me.rdbMinor.Size = New System.Drawing.Size(72, 24)
        Me.rdbMinor.TabIndex = 5
        Me.rdbMinor.Text = "Minor"
        Me.rdbMinor.UseVisualStyleBackColor = False
        '
        'txtNomineeNo
        '
        Me.txtNomineeNo.AlphaNumeric = False
        Me.txtNomineeNo.BackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(253, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.txtNomineeNo.BlankSpace = False
        Me.txtNomineeNo.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNomineeNo.GotFocusColour = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(253, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.txtNomineeNo.Location = New System.Drawing.Point(128, 16)
        Me.txtNomineeNo.LostFocusColour = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(253, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.txtNomineeNo.Mandatory = False
        Me.txtNomineeNo.Name = "txtNomineeNo"
        Me.txtNomineeNo.ReadOnly = True
        Me.txtNomineeNo.Size = New System.Drawing.Size(48, 23)
        Me.txtNomineeNo.SpecialChar = False
        Me.txtNomineeNo.TabIndex = 68
        Me.txtNomineeNo.TabStop = False
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.BackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(253, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.Label17.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(184, 16)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(44, 16)
        Me.Label17.TabIndex = 42
        Me.Label17.Text = "Name"
        '
        'txtNomineeName
        '
        Me.txtNomineeName.AlphaNumeric = False
        Me.txtNomineeName.BlankSpace = True
        Me.txtNomineeName.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNomineeName.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtNomineeName.Location = New System.Drawing.Point(232, 16)
        Me.txtNomineeName.LostFocusColour = System.Drawing.SystemColors.Window
        Me.txtNomineeName.Mandatory = False
        Me.txtNomineeName.MaxLength = 30
        Me.txtNomineeName.Name = "txtNomineeName"
        Me.txtNomineeName.Size = New System.Drawing.Size(176, 23)
        Me.txtNomineeName.SpecialChar = True
        Me.txtNomineeName.TabIndex = 0
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(8, 216)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(81, 16)
        Me.Label5.TabIndex = 52
        Me.Label5.Text = "Address :  "
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(8, 80)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(108, 16)
        Me.Label6.TabIndex = 44
        Me.Label6.Text = "Date of Birth : "
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(253, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.Label9.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(8, 144)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(98, 16)
        Me.Label9.TabIndex = 48
        Me.Label9.Text = "Age Status : "
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(8, 112)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(49, 16)
        Me.Label12.TabIndex = 46
        Me.Label12.Text = "Age : "
        '
        'lblNomineeNo
        '
        Me.lblNomineeNo.AutoSize = True
        Me.lblNomineeNo.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNomineeNo.Location = New System.Drawing.Point(8, 16)
        Me.lblNomineeNo.Name = "lblNomineeNo"
        Me.lblNomineeNo.Size = New System.Drawing.Size(51, 16)
        Me.lblNomineeNo.TabIndex = 66
        Me.lblNomineeNo.Text = " No. : "
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.Label3)
        Me.GroupBox4.Controls.Add(Me.txtName)
        Me.GroupBox4.Controls.Add(Me.lblAccountNo)
        Me.GroupBox4.Controls.Add(Me.txtAccountNo)
        Me.GroupBox4.Location = New System.Drawing.Point(16, 16)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(680, 64)
        Me.GroupBox4.TabIndex = 71
        Me.GroupBox4.TabStop = False
        '
        'frmNominees
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(253, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.CancelButton = Me.btnClose
        Me.ClientSize = New System.Drawing.Size(706, 503)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.btnOK)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnPrevious)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.lblRecords)
        Me.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmNominees"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Nominee Master"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.picPhoto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picSign, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region


#Region "Sub Routines to load Control values from Database"

    'to load database values to form controls
    Sub sbLoadControlValues()
        sbLoadOccupation()
        sbLoadRelation()
        ' sbLoadVillages()
    End Sub

    Sub sbLoadOccupation()
        Dim objOccupation As New clsOccupation
        If objOccupation.fnGetOccupations Then
            cmbOccupation.DataSource = objOccupation.OccupationTable
            cmbOccupation.DisplayMember = "OccupationName"
            cmbOccupation.ValueMember = "OccupationCode"
        End If
        objOccupation = Nothing
    End Sub

    'To load ReligionTbl values to the Religion ComboBox control
    Sub sbLoadRelation()
        Dim objRelation As New clsRelations
        If objRelation.fnGetRelations Then
            cmbRelation.DataSource = objRelation.RelationTable
            cmbRelation.DisplayMember = "RelationName"
            cmbRelation.ValueMember = "RelationCode"
        End If
        objRelation = Nothing
    End Sub

    'To load VillageTbl values to the Village ComboBox controls
    'Sub sbLoadVillages()

    '    Dim objVillage As New clsVillage
    '    If objVillage.fnGetVillages = True Then
    '        cmbVillage.DataSource = objVillage.VillageTable
    '        cmbVillage.DisplayMember = "VillageName"
    '        cmbVillage.ValueMember = "VillageCode"
    '    End If
    '    objVillage = Nothing

    'End Sub

#End Region

#Region "Sub Routines and Functions"

    Sub sbLoadMember()
        Dim objDT As DataTable
        If objMember.fnGetMemberDetails(txtAccountNo.Text) Then
            sbClear()
            objDT = objMember.MemberTable
            txtAccountNo.Text = objDT.Rows(0).Item("MemberNo")
            txtName.Text = objDT.Rows(0).Item("Name")
        End If

    End Sub

    Function fnGetNominees() As Boolean
        If txtAccountNo.Text <> "" Then
            If objNominee.fnGetNominees(txtAccountNo.Text, chrType) Then
                intNo = 0
                objDT = objNominee.NomineeTable
                Return True
            End If
        End If
        Return False
    End Function

    Function fnLoadNomineeDetails() As Boolean

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
        txtNomineeNo.Text = objDT.Rows(intNo).Item("No")
        txtNomineeName.Text = objDT.Rows(intNo).Item("Name")
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
        txtFatherName.Text = objDT.Rows(intNo).Item("FatherName")
        txtAddress.Text = objDT.Rows(intNo).Item("Address")
        cmbOccupation.SelectedValue = objDT.Rows(intNo).Item("OccupationCode")
        cmbRelation.SelectedValue = objDT.Rows(intNo).Item("RelationCode")

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
        txtNomineeName.ResetText()
        txtAge.ResetText()
        rdbMale.Checked = True
        rdbMajor.Checked = True
        txtFatherName.ResetText()
        ''txtAddress.ResetText()
        cmbOccupation.SelectedIndex = -1
        cmbRelation.SelectedIndex = -1
        picPhoto.Image = Nothing
        picSign.Image = Nothing
    End Sub

    Function fnCheck() As Boolean
        If Trim(txtNomineeName.Text) = "" And chrType = "N" Then
            MsgBox("Nominee name can not be blank",MsgBoxStyle.Exclamation)
            txtNomineeName.Focus()
            Return False
        ElseIf Trim(txtAge.Text) = "" Then
            MsgBox("Enter Age", MsgBoxStyle.Exclamation)
            txtAge.Focus()
            Return False
        ElseIf Trim(txtAddress.Text) = "" Then
            MsgBox("Enter Address", MsgBoxStyle.Exclamation)
            txtAddress.Focus()
            Return False
        ElseIf cmbOccupation.SelectedIndex < 0 Then
            MsgBox("Select Occupation", MsgBoxStyle.Exclamation)
            cmbOccupation.Focus()
            Return False
        ElseIf cmbRelation.SelectedIndex < 0 Then
            MsgBox("Select relation", MsgBoxStyle.Exclamation)
            cmbRelation.Focus()
            Return False
        Else
            Return True
        End If
    End Function

    Function fnSetData() As Boolean
        objNominee.No = txtNomineeNo.Text
        objNominee.AccountNo = txtAccountNo.Text
        objNominee.Name = txtNomineeName.Text
        objNominee.DOB = dtpDOB.Value
        objNominee.Age = txtAge.Text
        objNominee.AgeStatus = IIf(rdbMajor.Checked = True, "M", "N")
        objNominee.Gender = IIf(rdbMale.Checked = True, "M", "F")
        objNominee.Address = txtAddress.Text
        objNominee.OccupationCode = cmbOccupation.SelectedValue
        objNominee.RelationCode = cmbRelation.SelectedValue
        objNominee.Type = chrType
        objNominee.Photo = fnGetPhoto()
        objNominee.Sign = fnGetSign()
        objNominee.FatherName = txtFatherName.Text
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
    Public Property Address() As String
        Get
            Return txtAddress.Text
        End Get
        Set(ByVal Value As String)
            txtAddress.Text = Value
        End Set
    End Property

#Region "Events"

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub frmNominees_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        dtpDOB.MaxDate = Date.Now
        ' dtpDOB.Value = Date.Now

        If chrType = "J" Then
            lblRelation.Visible = False
            cmbRelation.Visible = False
            Label4.Visible = True
            Label28.Visible = True
            txtFatherName.Visible = True
            txtNomineeName.Visible = True
            Label17.Visible = True
            ' lblNomineeNo.Location = New System.Drawing.Point(40, 16)
            'txtNomineeNo.Location = New System.Drawing.Point(144, 16)
            'Label17.Location = New System.Drawing.Point(40, 40)
            ' txtNomineeName.Location = New System.Drawing.Point(144, 40)
            'Me.Text = "Joint Holders"
        End If
        If chrType = "N" Then
            Label4.Visible = False
            Label28.Visible = False
            txtFatherName.Visible = False
            Label17.Location = New System.Drawing.Point(12, 46)
            txtNomineeName.Location = New System.Drawing.Point(129, 46)
            'Label6.Location = New System.Drawing.Point(12, 46)
            'dtpDOB.Location = New System.Drawing.Point(129, 46)
            'Label12.Location = New System.Drawing.Point(12, 76)
            'txtAge.Location = New System.Drawing.Point(129, 76)
            'Label9.Location = New System.Drawing.Point(12, 46)
            'rdbMajor.Location = New System.Drawing.Point(129, 46)
            'rdbMinor.Location = New System.Drawing.Point(159, 46)
        End If
        sbLoadControlValues()
        If txtAccountNo.Text <> "" Then
            sbLoadMember()
            If fnGetNominees() Then
                fnLoadNomineeDetails()
            Else
                btnAdd_Click(sender, e)
            End If
        End If

    End Sub

    Private Sub btnPhotoCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPhotoCancel.Click
        picPhoto.Image = Nothing
    End Sub

    Private Sub btnSignCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSignCancel.Click
        picSign.Image = Nothing
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

    Private Sub btnSignLoad_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSignLoad.Click
        If OpenFileDialog1.ShowDialog() <> DialogResult.Cancel Then
            Try
                picSign.Image = Image.FromFile(OpenFileDialog1.FileName)
            Catch
                MsgBox("Select image files only", MsgBoxStyle.Exclamation)
            End Try
        End If
    End Sub

    Private Sub picPhoto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picPhoto.Click
        btnPhotoLoad_Click(sender, e)
    End Sub

    Private Sub picSign_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picSign.Click
        btnSignLoad_Click(sender, e)
    End Sub

    Private Sub btnNext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNext.Click
        If Not objDT Is Nothing Then
            If intNo <> objDT.Rows.Count - 1 Then
                intNo += 1
                fnLoadNomineeDetails()
            End If
        End If
    End Sub

    Private Sub btnPrevious_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrevious.Click
        If intNo <> 0 Then
            intNo -= 1
            fnLoadNomineeDetails()
        End If
    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        txtNomineeNo.Text = objNominee.fnGetNewNomineeNo(txtAccountNo.Text, chrType)
        intNo += 1
        sbClear()
        txtNomineeName.Focus()
    End Sub

    Private Sub btnOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOK.Click

        Dim objTrans As IDbTransaction

        Try
            objTrans = fnGetTransaction()
            If fnCheck() Then
                If fnSetData() Then

                    If objNominee.fnCheckNominee(txtNomineeNo.Text, txtAccountNo.Text, chrType) = True Then
                        If objNominee.fnUpdateNominee(objTrans) Then
                            objTrans.Commit()
                            MsgBox(" Details updated successfully", MsgBoxStyle.Information)
                        Else
                            MsgBox("Updation failed, because of internal error", MsgBoxStyle.Exclamation)
                        End If
                    Else
                        If objNominee.fnAddNominee(objTrans) Then
                            objTrans.Commit()
                            MsgBox(" Details added successfully", MsgBoxStyle.Information)
                        Else
                            MsgBox("Addition failed, because of internal error", MsgBoxStyle.Exclamation)
                        End If
                    End If
                    fnGetNominees()
                    btnAdd_Click(sender, e)
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

    Private Sub dtpDOB_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtpDOB.TextChanged
        txtAge.Text = DateDiff(DateInterval.Year, dtpDOB.Value, Date.Now)
    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        If MsgBox("Are you sure you want to delete this record?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirm delete") = MsgBoxResult.Yes Then
            If objNominee.fnDeleteNominee(txtAccountNo.Text, txtNomineeNo.Text, chrType) Then
                MsgBox("Deleted successfully", MsgBoxStyle.Information)
                btnAdd_Click(sender, e)
                If fnGetNominees() Then
                    fnLoadNomineeDetails()
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

#End Region

End Class
