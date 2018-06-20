#Region "Import Statements"
Imports System.IO
#End Region

Public Class frmSBAccList
    Inherits System.Windows.Forms.Form

#Region "Form Global Variables"

    Dim objSBAccount As New clsSavingsBank
    Dim objMember As New clsMember
    Dim lngPersonNo As Long = 0
    Dim dvSBAccounts As DataView
    Dim strFilter As String = "Name like '%'"
    Friend WithEvents dtp As New DateTimePicker
    Friend WithEvents NewButton4 As BankControls.NewButton
    Dim intCount As Integer

#End Region

#Region "Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()
        If m_FormDefInstance Is Nothing Then
            If m_InitializingDefInstance Then
                m_FormDefInstance = Me
            End If
        End If
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
    Friend WithEvents NewButton2 As BankControls.NewButton
    Friend WithEvents NewButton3 As BankControls.NewButton
    Friend WithEvents NewButton5 As BankControls.NewButton
    Friend WithEvents NewButton6 As BankControls.NewButton
    Friend WithEvents btnCancel As BankControls.NewButton
    Friend WithEvents btnNominees As BankControls.NewButton
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnAdd As BankControls.NewButton
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label32 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cmbType As System.Windows.Forms.ComboBox
    Friend WithEvents lblMessage As System.Windows.Forms.Label
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader8 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader6 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents lvSBAccounts As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader7 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader9 As System.Windows.Forms.ColumnHeader
    Friend WithEvents btnChequeWithdraw As BankControls.NewButton
    Friend WithEvents btnChequeDeposit As BankControls.NewButton
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents ColumnHeader10 As System.Windows.Forms.ColumnHeader
    Friend WithEvents txtSearch As BankControls.TextControl
    Friend WithEvents txtAvailBal As BankControls.NumericControl
    Friend WithEvents NewButton1 As BankControls.NewButton
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSBAccList))
        Me.NewButton2 = New BankControls.NewButton
        Me.btnNominees = New BankControls.NewButton
        Me.NewButton3 = New BankControls.NewButton
        Me.NewButton5 = New BankControls.NewButton
        Me.NewButton6 = New BankControls.NewButton
        Me.btnCancel = New BankControls.NewButton
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.NewButton4 = New BankControls.NewButton
        Me.NewButton1 = New BankControls.NewButton
        Me.btnChequeWithdraw = New BankControls.NewButton
        Me.btnChequeDeposit = New BankControls.NewButton
        Me.btnAdd = New BankControls.NewButton
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.txtSearch = New BankControls.TextControl
        Me.txtAvailBal = New BankControls.NumericControl
        Me.Label2 = New System.Windows.Forms.Label
        Me.cmbType = New System.Windows.Forms.ComboBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.lblMessage = New System.Windows.Forms.Label
        Me.lvSBAccounts = New System.Windows.Forms.ListView
        Me.ColumnHeader1 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader2 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader3 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader7 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader9 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader5 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader4 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader10 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader8 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader6 = New System.Windows.Forms.ColumnHeader
        Me.Label32 = New System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'NewButton2
        '
        Me.NewButton2.BackColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.NewButton2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.NewButton2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.NewButton2.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NewButton2.ForeColor = System.Drawing.Color.Black
        Me.NewButton2.GotFocusColour = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.NewButton2.Image = CType(resources.GetObject("NewButton2.Image"), System.Drawing.Image)
        Me.NewButton2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.NewButton2.Location = New System.Drawing.Point(16, 112)
        Me.NewButton2.LostFocusColour = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.NewButton2.Name = "NewButton2"
        Me.NewButton2.Size = New System.Drawing.Size(168, 40)
        Me.NewButton2.TabIndex = 5
        Me.NewButton2.Text = "Joint Holders"
        Me.NewButton2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.NewButton2.UseVisualStyleBackColor = False
        '
        'btnNominees
        '
        Me.btnNominees.BackColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.btnNominees.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnNominees.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnNominees.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNominees.ForeColor = System.Drawing.Color.Black
        Me.btnNominees.GotFocusColour = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnNominees.Image = CType(resources.GetObject("btnNominees.Image"), System.Drawing.Image)
        Me.btnNominees.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnNominees.Location = New System.Drawing.Point(16, 152)
        Me.btnNominees.LostFocusColour = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.btnNominees.Name = "btnNominees"
        Me.btnNominees.Size = New System.Drawing.Size(168, 40)
        Me.btnNominees.TabIndex = 6
        Me.btnNominees.Text = "Nominee Details"
        Me.btnNominees.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnNominees.UseVisualStyleBackColor = False
        '
        'NewButton3
        '
        Me.NewButton3.BackColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.NewButton3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.NewButton3.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.NewButton3.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NewButton3.ForeColor = System.Drawing.Color.Black
        Me.NewButton3.GotFocusColour = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.NewButton3.Image = CType(resources.GetObject("NewButton3.Image"), System.Drawing.Image)
        Me.NewButton3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.NewButton3.Location = New System.Drawing.Point(16, 192)
        Me.NewButton3.LostFocusColour = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.NewButton3.Name = "NewButton3"
        Me.NewButton3.Size = New System.Drawing.Size(168, 40)
        Me.NewButton3.TabIndex = 7
        Me.NewButton3.Text = "Issue Cheque Book"
        Me.NewButton3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.NewButton3.UseVisualStyleBackColor = False
        '
        'NewButton5
        '
        Me.NewButton5.BackColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.NewButton5.Cursor = System.Windows.Forms.Cursors.Hand
        Me.NewButton5.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.NewButton5.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NewButton5.ForeColor = System.Drawing.Color.Black
        Me.NewButton5.GotFocusColour = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.NewButton5.Location = New System.Drawing.Point(16, 412)
        Me.NewButton5.LostFocusColour = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.NewButton5.Name = "NewButton5"
        Me.NewButton5.Size = New System.Drawing.Size(168, 40)
        Me.NewButton5.TabIndex = 10
        Me.NewButton5.Text = "View Transaction Log(All)"
        Me.NewButton5.UseVisualStyleBackColor = False
        '
        'NewButton6
        '
        Me.NewButton6.BackColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.NewButton6.Cursor = System.Windows.Forms.Cursors.Hand
        Me.NewButton6.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.NewButton6.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NewButton6.ForeColor = System.Drawing.Color.Black
        Me.NewButton6.GotFocusColour = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.NewButton6.Location = New System.Drawing.Point(16, 460)
        Me.NewButton6.LostFocusColour = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.NewButton6.Name = "NewButton6"
        Me.NewButton6.Size = New System.Drawing.Size(168, 40)
        Me.NewButton6.TabIndex = 11
        Me.NewButton6.Text = "Cheque Deposit Details"
        Me.NewButton6.UseVisualStyleBackColor = False
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnCancel.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.ForeColor = System.Drawing.Color.Black
        Me.btnCancel.GotFocusColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnCancel.Image = CType(resources.GetObject("btnCancel.Image"), System.Drawing.Image)
        Me.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCancel.Location = New System.Drawing.Point(672, 568)
        Me.btnCancel.LostFocusColour = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(96, 40)
        Me.btnCancel.TabIndex = 4
        Me.btnCancel.Text = "&Cancel"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.NewButton4)
        Me.GroupBox1.Controls.Add(Me.NewButton1)
        Me.GroupBox1.Controls.Add(Me.NewButton2)
        Me.GroupBox1.Controls.Add(Me.btnNominees)
        Me.GroupBox1.Controls.Add(Me.NewButton3)
        Me.GroupBox1.Controls.Add(Me.NewButton5)
        Me.GroupBox1.Controls.Add(Me.NewButton6)
        Me.GroupBox1.Controls.Add(Me.btnChequeWithdraw)
        Me.GroupBox1.Controls.Add(Me.btnChequeDeposit)
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.GroupBox1.Location = New System.Drawing.Point(8, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(200, 616)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        '
        'NewButton4
        '
        Me.NewButton4.BackColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.NewButton4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.NewButton4.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.NewButton4.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NewButton4.ForeColor = System.Drawing.Color.Black
        Me.NewButton4.GotFocusColour = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.NewButton4.Location = New System.Drawing.Point(16, 508)
        Me.NewButton4.LostFocusColour = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.NewButton4.Name = "NewButton4"
        Me.NewButton4.Size = New System.Drawing.Size(168, 40)
        Me.NewButton4.TabIndex = 13
        Me.NewButton4.Text = "Pass Book Print"
        Me.NewButton4.UseVisualStyleBackColor = False
        '
        'NewButton1
        '
        Me.NewButton1.BackColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.NewButton1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.NewButton1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.NewButton1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NewButton1.ForeColor = System.Drawing.Color.Black
        Me.NewButton1.GotFocusColour = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.NewButton1.Image = CType(resources.GetObject("NewButton1.Image"), System.Drawing.Image)
        Me.NewButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.NewButton1.Location = New System.Drawing.Point(16, 272)
        Me.NewButton1.LostFocusColour = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.NewButton1.Name = "NewButton1"
        Me.NewButton1.Size = New System.Drawing.Size(168, 40)
        Me.NewButton1.TabIndex = 12
        Me.NewButton1.Text = "Cash Transaction"
        Me.NewButton1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.NewButton1.UseVisualStyleBackColor = False
        '
        'btnChequeWithdraw
        '
        Me.btnChequeWithdraw.BackColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.btnChequeWithdraw.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnChequeWithdraw.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnChequeWithdraw.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnChequeWithdraw.ForeColor = System.Drawing.Color.Black
        Me.btnChequeWithdraw.GotFocusColour = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnChequeWithdraw.Image = CType(resources.GetObject("btnChequeWithdraw.Image"), System.Drawing.Image)
        Me.btnChequeWithdraw.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnChequeWithdraw.Location = New System.Drawing.Point(16, 352)
        Me.btnChequeWithdraw.LostFocusColour = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.btnChequeWithdraw.Name = "btnChequeWithdraw"
        Me.btnChequeWithdraw.Size = New System.Drawing.Size(168, 40)
        Me.btnChequeWithdraw.TabIndex = 9
        Me.btnChequeWithdraw.Text = "Cheque WithDrawl"
        Me.btnChequeWithdraw.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnChequeWithdraw.UseVisualStyleBackColor = False
        '
        'btnChequeDeposit
        '
        Me.btnChequeDeposit.BackColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.btnChequeDeposit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnChequeDeposit.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnChequeDeposit.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnChequeDeposit.ForeColor = System.Drawing.Color.Black
        Me.btnChequeDeposit.GotFocusColour = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnChequeDeposit.Image = CType(resources.GetObject("btnChequeDeposit.Image"), System.Drawing.Image)
        Me.btnChequeDeposit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnChequeDeposit.Location = New System.Drawing.Point(16, 312)
        Me.btnChequeDeposit.LostFocusColour = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.btnChequeDeposit.Name = "btnChequeDeposit"
        Me.btnChequeDeposit.Size = New System.Drawing.Size(168, 40)
        Me.btnChequeDeposit.TabIndex = 8
        Me.btnChequeDeposit.Text = "Cheque Deposit"
        Me.btnChequeDeposit.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnChequeDeposit.UseVisualStyleBackColor = False
        '
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnAdd.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.ForeColor = System.Drawing.Color.Black
        Me.btnAdd.GotFocusColour = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnAdd.Image = CType(resources.GetObject("btnAdd.Image"), System.Drawing.Image)
        Me.btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAdd.Location = New System.Drawing.Point(16, 568)
        Me.btnAdd.LostFocusColour = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(144, 40)
        Me.btnAdd.TabIndex = 5
        Me.btnAdd.Text = "&New SB Account"
        Me.btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAdd.UseVisualStyleBackColor = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.GroupBox3)
        Me.GroupBox2.Controls.Add(Me.lblMessage)
        Me.GroupBox2.Controls.Add(Me.lvSBAccounts)
        Me.GroupBox2.Controls.Add(Me.Label32)
        Me.GroupBox2.Controls.Add(Me.btnAdd)
        Me.GroupBox2.Controls.Add(Me.btnCancel)
        Me.GroupBox2.Controls.Add(Me.PictureBox1)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Location = New System.Drawing.Point(216, 0)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(792, 616)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(528, 544)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(88, 24)
        Me.Label3.TabIndex = 73
        Me.Label3.Text = "Total Balance"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.txtSearch)
        Me.GroupBox3.Controls.Add(Me.txtAvailBal)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.cmbType)
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.Location = New System.Drawing.Point(16, 64)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(760, 48)
        Me.GroupBox3.TabIndex = 1
        Me.GroupBox3.TabStop = False
        '
        'txtSearch
        '
        Me.txtSearch.AlphaNumeric = True
        Me.txtSearch.BlankSpace = True
        Me.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSearch.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearch.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtSearch.Location = New System.Drawing.Point(504, 14)
        Me.txtSearch.LostFocusColour = System.Drawing.SystemColors.Window
        Me.txtSearch.Mandatory = False
        Me.txtSearch.MaxLength = 50
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(200, 23)
        Me.txtSearch.SpecialChar = True
        Me.txtSearch.TabIndex = 2
        '
        'txtAvailBal
        '
        Me.txtAvailBal.AfterDecimal = 2
        Me.txtAvailBal.BeforeDecimal = 10
        Me.txtAvailBal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtAvailBal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.txtAvailBal.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtAvailBal.Location = New System.Drawing.Point(504, 14)
        Me.txtAvailBal.LostFocusColour = System.Drawing.Color.Empty
        Me.txtAvailBal.MaxLength = 10
        Me.txtAvailBal.MaxValue = 0
        Me.txtAvailBal.MinValue = 0
        Me.txtAvailBal.Name = "txtAvailBal"
        Me.txtAvailBal.Size = New System.Drawing.Size(200, 22)
        Me.txtAvailBal.TabIndex = 2
        Me.txtAvailBal.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(48, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(86, 16)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Search By :"
        '
        'cmbType
        '
        Me.cmbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbType.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbType.Items.AddRange(New Object() {"Name", "AccountNo", "CustomerID", "Balance", "IntroducerNo", "TypeOfAccount", "Status", "Remarks"})
        Me.cmbType.Location = New System.Drawing.Point(136, 16)
        Me.cmbType.Name = "cmbType"
        Me.cmbType.Size = New System.Drawing.Size(200, 24)
        Me.cmbType.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(400, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(105, 16)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Search Text : "
        '
        'lblMessage
        '
        Me.lblMessage.AutoSize = True
        Me.lblMessage.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMessage.Location = New System.Drawing.Point(16, 128)
        Me.lblMessage.Name = "lblMessage"
        Me.lblMessage.Size = New System.Drawing.Size(287, 16)
        Me.lblMessage.TabIndex = 72
        Me.lblMessage.Text = "There are 0 records found for your search"
        '
        'lvSBAccounts
        '
        Me.lvSBAccounts.AllowColumnReorder = True
        Me.lvSBAccounts.BackColor = System.Drawing.Color.LightCyan
        Me.lvSBAccounts.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lvSBAccounts.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader7, Me.ColumnHeader9, Me.ColumnHeader5, Me.ColumnHeader4, Me.ColumnHeader10, Me.ColumnHeader8, Me.ColumnHeader6})
        Me.lvSBAccounts.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvSBAccounts.FullRowSelect = True
        Me.lvSBAccounts.GridLines = True
        Me.lvSBAccounts.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.lvSBAccounts.HideSelection = False
        Me.lvSBAccounts.Location = New System.Drawing.Point(16, 152)
        Me.lvSBAccounts.MultiSelect = False
        Me.lvSBAccounts.Name = "lvSBAccounts"
        Me.lvSBAccounts.Size = New System.Drawing.Size(760, 384)
        Me.lvSBAccounts.Sorting = System.Windows.Forms.SortOrder.Ascending
        Me.lvSBAccounts.TabIndex = 3
        Me.lvSBAccounts.UseCompatibleStateImageBehavior = False
        Me.lvSBAccounts.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "AccountNo ."
        Me.ColumnHeader1.Width = 80
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Name"
        Me.ColumnHeader2.Width = 206
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "CustomerID"
        Me.ColumnHeader3.Width = 96
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "Introducer No"
        Me.ColumnHeader7.Width = 96
        '
        'ColumnHeader9
        '
        Me.ColumnHeader9.Text = "Type Of Account"
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Date"
        Me.ColumnHeader5.Width = 89
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Available Balance"
        Me.ColumnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader4.Width = 72
        '
        'ColumnHeader10
        '
        Me.ColumnHeader10.Text = "Book Balance"
        Me.ColumnHeader10.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader10.Width = 72
        '
        'ColumnHeader8
        '
        Me.ColumnHeader8.Text = "Status"
        Me.ColumnHeader8.Width = 57
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Remarks"
        Me.ColumnHeader6.Width = 101
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.BackColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.Label32.Font = New System.Drawing.Font("Georgia", 14.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label32.ForeColor = System.Drawing.Color.Teal
        Me.Label32.Location = New System.Drawing.Point(72, 16)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(199, 23)
        Me.Label32.TabIndex = 68
        Me.Label32.Text = "Savings Account's List"
        Me.Label32.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(16, 16)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(40, 40)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 69
        Me.PictureBox1.TabStop = False
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(624, 544)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(144, 24)
        Me.Label4.TabIndex = 73
        '
        'frmSBAccList
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.CancelButton = Me.btnCancel
        Me.ClientSize = New System.Drawing.Size(1018, 631)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.KeyPreview = True
        Me.Name = "frmSBAccList"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SB Account's  List"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region "Code to Create Instance Object"

    Private Shared m_FormDefInstance As frmSBAccList
    Private Shared m_InitializingDefInstance As Boolean

    Public Shared Property DefInstance() As frmSBAccList
        Get
            If m_FormDefInstance Is Nothing OrElse m_FormDefInstance.IsDisposed Then
                m_InitializingDefInstance = True
                m_FormDefInstance = New frmSBAccList
                m_InitializingDefInstance = False
            End If
            DefInstance = m_FormDefInstance
        End Get
        Set(ByVal Value As frmSBAccList)
            m_FormDefInstance = Value
        End Set
    End Property

#End Region

#Region "EVENTS"
    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        SendKeys.Send("{F6}")
    End Sub

    Private Sub NewButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewButton3.Click
        If lvSBAccounts.SelectedItems.Count > 0 Then
            If lvSBAccounts.SelectedItems(0).SubItems(8).Text = "A" Then
                Dim objChequeBookIsue As New frmSBChequeBookIssue
                objChequeBookIsue.strSbno = Trim(lvSBAccounts.SelectedItems(0).SubItems(0).Text)
                objChequeBookIsue.cmbAccountNo.Enabled = False
                objChequeBookIsue.txtName.ReadOnly = True
                objChequeBookIsue.btnSearch.Enabled = False
                objChequeBookIsue.ShowDialog(Me)
                frmSBAccCreation_Load(sender, e)
            Else
                MsgBox("Account is closed", MsgBoxStyle.Information, "SB Module")
            End If
        Else
            MsgBox("Select account number from the list", MsgBoxStyle.Information, "SB Module")
        End If
    End Sub

    Private Sub frmSBAccCreation_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load, MyBase.Activated
        cmbType.SelectedIndex = -1
        txtSearch.Enabled = False
        If objSBAccount.fnGetSBAccountList Then
            dvSBAccounts = New DataView(objSBAccount.SBAccTable, strFilter, "Name", DataViewRowState.OriginalRows)
            fnLoadSBAccounts()
        End If
    End Sub

    Private Sub btnNominees_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNominees.Click
        If lvSBAccounts.SelectedItems.Count > 0 Then
            Dim objNominees As New frmNominees
            objNominees.txtAccountNo.Text = Trim(lvSBAccounts.SelectedItems(0).SubItems(0).Text)
            objNominees.chrType = "N"
            objNominees.Text = "Savings Bank Nominees for Account No  " & Trim(lvSBAccounts.SelectedItems(0).SubItems(0).Text)
            objNominees.txtName.Text = Trim(lvSBAccounts.SelectedItems(0).SubItems(1).Text)
            objNominees.ShowDialog(Me)
            objNominees.Dispose()
        Else
            MsgBox("Select account number from the list", MsgBoxStyle.Information, "SB Module")
        End If
    End Sub

    Private Sub NewButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewButton2.Click
        If lvSBAccounts.SelectedItems.Count > 0 Then
            If lvSBAccounts.SelectedItems(0).SubItems(4).Text = "J" Then
                Dim objJointHolders As New frmNominees
                objJointHolders.txtAccountNo.Text = Trim(lvSBAccounts.SelectedItems(0).SubItems(0).Text)
                objJointHolders.chrType = "J"
                objJointHolders.Text = "Savings Bank Joint-Holders for Account No  " & Trim(lvSBAccounts.SelectedItems(0).SubItems(0).Text)
                objJointHolders.txtName.Text = Trim(lvSBAccounts.SelectedItems(0).SubItems(1).Text)
                objJointHolders.ShowDialog(Me)
                objJointHolders.Dispose()
            Else
                MsgBox("Account type is not joint", MsgBoxStyle.Information, "SB Module")
                lvSBAccounts.Focus()
            End If
        Else
            MsgBox("Select account number from the list", MsgBoxStyle.Information, "SB Module")
        End If
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub NewButton5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewButton5.Click
        If lvSBAccounts.SelectedItems.Count > 0 Then
            Dim objfrmAccountStmt As New frmSBStmtOfAccount
            objfrmAccountStmt.txtAccno.Text = Trim(lvSBAccounts.SelectedItems(0).SubItems(0).Text)
            objfrmAccountStmt.txtName.Text = Trim(lvSBAccounts.SelectedItems(0).SubItems(1).Text)
            objfrmAccountStmt.ShowDialog(Me)
        Else
            MsgBox("Select account number from the list", MsgBoxStyle.Information, "SB Module")
        End If
    End Sub

    Private Sub txtSearch_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSearch.TextChanged, txtAvailBal.TextChanged
        Select Case cmbType.SelectedItem
            Case "Name"
                strFilter = "Name like '" & txtSearch.Text & "%'"
                fnLoadSBAccounts()
            Case "AccountNo"
                strFilter = "AccountNo like '" & txtSearch.Text & "%'"
                fnLoadSBAccounts()
            Case "CustomerID"
                strFilter = "CustomerID like '" & txtSearch.Text & "%'"
                fnLoadSBAccounts()
            Case "Status"
                strFilter = "Accstatus like '" & txtSearch.Text & "%'"
                fnLoadSBAccounts()
            Case "TypeOfAccount"
                strFilter = "Acctype like '" & txtSearch.Text & "%'"
                fnLoadSBAccounts()
            Case "IntroducerNo"
                strFilter = "IntroNo like '" & txtSearch.Text & "%'"
                fnLoadSBAccounts()
            Case "Balance"
                If txtAvailBal.Text = String.Empty Then
                    strFilter = "Name like '" & txtSearch.Text & "%'"
                    fnLoadSBAccounts()
                Else
                    strFilter = "AvailBalance =" & txtAvailBal.Text & ""
                    fnLoadSBAccounts()
                End If
            Case "Remarks"
                strFilter = "Remarks like '" & txtSearch.Text & "%'"
                fnLoadSBAccounts()
        End Select
    End Sub

    Private Sub cmbType_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbType.SelectedIndexChanged
        txtSearch.ResetText()
        txtAvailBal.Text = ""
        txtSearch.Enabled = True
        Select Case cmbType.SelectedItem
            Case "Name"
                txtSearch.Visible = True
                txtAvailBal.Visible = False
            Case "AccountNo"
                txtSearch.Visible = True
                txtAvailBal.Visible = False
            Case "CustomerID"
                txtSearch.Visible = True
                txtAvailBal.Visible = False
            Case "Status"
                txtSearch.Visible = True
                txtAvailBal.Visible = False
            Case "TypeOfAccount"
                txtSearch.Visible = True
                txtAvailBal.Visible = False
            Case "IntroducerNo"
                txtSearch.Visible = True
                txtAvailBal.Visible = False
            Case "Balance"
                txtSearch.Visible = False
                txtAvailBal.Visible = True
            Case "Remarks"
                txtSearch.Visible = True
                txtAvailBal.Visible = False
        End Select
    End Sub

    Private Sub btnChequeWithdraw_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnChequeWithdraw.Click

        Dim ObjfrmSBChequeWithdraw As New frmSBChequeWithdraw
        ObjfrmSBChequeWithdraw.txtAccNo.ReadOnly = True
        ObjfrmSBChequeWithdraw.btnSearch.Enabled = False
        ObjfrmSBChequeWithdraw.ShowDialog(Me)
        ObjfrmSBChequeWithdraw.Dispose()
        frmSBAccCreation_Load(sender, e)

    End Sub

    Private Sub btnChequeDeposit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnChequeDeposit.Click
        If lvSBAccounts.SelectedItems.Count > 0 Then
            If lvSBAccounts.SelectedItems(0).SubItems(8).Text = "A" Then
                Dim objfrmChequeDeposit As New frmSBChequeDeposit
                objfrmChequeDeposit.objAccountNo = lvSBAccounts.SelectedItems(0).SubItems(0).Text
                objfrmChequeDeposit.txtAccountNo.Enabled = False
                objfrmChequeDeposit.btnSearch.Enabled = False
                objfrmChequeDeposit.txtName.ReadOnly = True
                objfrmChequeDeposit.ShowDialog(Me)
                objfrmChequeDeposit = Nothing
                frmSBAccCreation_Load(sender, e)
            Else
                MsgBox("Account is closed", MsgBoxStyle.Information)
            End If
        Else
            MsgBox("Select account number from the list", MsgBoxStyle.Information, "SB Module")
        End If
    End Sub

    Private Sub NewButton6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewButton6.Click
        Dim objfrmChequeDepositDetails As New frmSBChequeStatusDetails
        objfrmChequeDepositDetails.MdiParent = Me.MdiParent
        objfrmChequeDepositDetails.Show()
        objfrmChequeDepositDetails = Nothing
    End Sub

    Private Sub lvSBAccounts_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles lvSBAccounts.DoubleClick
        If lvSBAccounts.SelectedItems.Count > 0 Then
            Dim objfrmSBAccCreation As frmSBAccCreation
            objfrmSBAccCreation = frmSBAccCreation.DefInstance
            objfrmSBAccCreation.BringToFront()
            objfrmSBAccCreation.MdiParent = Me.MdiParent
            objfrmSBAccCreation.txtAccNo.Text = lvSBAccounts.SelectedItems(0).SubItems(0).Text
            objfrmSBAccCreation.Show()
            objfrmSBAccCreation = Nothing
        Else
            MsgBox("Select account number from the list", MsgBoxStyle.Information, "SB Module")
            lvSBAccounts.Focus()
        End If
    End Sub

    Private Sub lvSBAccounts_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles lvSBAccounts.KeyUp
        If e.KeyCode = Keys.Enter Then
            lvSBAccounts_DoubleClick(Me, e.Empty)
        End If
    End Sub
#End Region

#Region "Genral Subroutines"

    Function fnLoadSBAccounts() As Boolean
        Dim intCounter As Integer = 0
        Dim lvItem As New ListViewItem
        Dim dblTotalBal As Double = 0
        If Not dvSBAccounts Is Nothing Then
            dvSBAccounts.RowFilter = strFilter
            lvSBAccounts.Items.Clear()
            lblMessage.Text = "There are " & dvSBAccounts.Count & " records found for your search"
            While intCounter < dvSBAccounts.Count
                lvItem = lvSBAccounts.Items.Add(dvSBAccounts.Item(intCounter).Item("AccountNo"))
                lvItem.UseItemStyleForSubItems = False
                lvItem.SubItems.Add(dvSBAccounts.Item(intCounter).Item("Name"))
                lvItem.SubItems.Add(dvSBAccounts.Item(intCounter).Item("CustomerID"))
                lvItem.SubItems.Add(dvSBAccounts.Item(intCounter).Item("IntroNo"))
                lvItem.SubItems.Add(dvSBAccounts.Item(intCounter).Item("AccType"))
                lvItem.SubItems.Add(Format(dvSBAccounts.Item(intCounter).Item("AccDate"), "dd-MM-yyyy"))
                lvItem.SubItems.Add(Format(dvSBAccounts.Item(intCounter).Item("AvailBalance"), "0,00.00"))
                dblTotalBal += dvSBAccounts.Item(intCounter).Item("AvailBalance")
                lvItem.SubItems.Add(Format(dvSBAccounts.Item(intCounter).Item("BookBalance"), "0,00.00"))
                lvItem.SubItems.Add(dvSBAccounts.Item(intCounter).Item("AccStatus"))
                lvItem.SubItems.Add(dvSBAccounts.Item(intCounter).Item("Remarks"))
                intCounter += 1
            End While
        End If
        Label4.Text = Format(dblTotalBal, "0,00.00")
    End Function
#End Region

    Private Sub frmSBAccList_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyData = Keys.F1 Then
            NewButton1_Click(sender, e)
        End If
    End Sub

    Private Sub NewButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewButton1.Click
        Dim objfrmSBWithdraw As New frmCashTransaction
        objfrmSBWithdraw.ShowDialog(Me)
        objfrmSBWithdraw = Nothing
        frmSBAccCreation_Load(sender, e)
    End Sub

    Private Sub NewButton4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewButton4.Click
        If lvSBAccounts.SelectedItems.Count > 0 Then
            Dim objfrmPassBookPrint As New frmPassBookPrint
            objfrmPassBookPrint.txtAccountNo.Text = Trim(lvSBAccounts.SelectedItems(0).SubItems(0).Text)
            objfrmPassBookPrint.txtName.Text = Trim(lvSBAccounts.SelectedItems(0).SubItems(1).Text)
            objfrmPassBookPrint.ShowDialog(Me)
        Else
            MsgBox("Select account number from the list", MsgBoxStyle.Information, "SB Module")
        End If
    End Sub

   
End Class

