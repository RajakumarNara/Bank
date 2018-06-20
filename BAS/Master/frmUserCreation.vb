Public Class frmUserCreation
    Inherits System.Windows.Forms.Form

#Region "GlobalVariables"
    Dim objUser As New clsUsers
    Dim roleID As Integer
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
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents txtUserID As BankControls.TextControl
    Friend WithEvents btnClose As BankControls.NewButton
    Friend WithEvents btnOk As BankControls.NewButton
    Friend WithEvents lblAccountNo As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtNewPassword1 As BankControls.TextControl
    Friend WithEvents txtNewPassword2 As BankControls.TextControl
    Friend WithEvents txtRole As BankControls.TextControl
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmUserCreation))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.txtUserID = New BankControls.TextControl
        Me.btnClose = New BankControls.NewButton
        Me.btnOk = New BankControls.NewButton
        Me.lblAccountNo = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtRole = New BankControls.TextControl
        Me.txtNewPassword1 = New BankControls.TextControl
        Me.txtNewPassword2 = New BankControls.TextControl
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.Label21 = New System.Windows.Forms.Label
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtUserID)
        Me.GroupBox1.Controls.Add(Me.btnClose)
        Me.GroupBox1.Controls.Add(Me.btnOk)
        Me.GroupBox1.Controls.Add(Me.lblAccountNo)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtRole)
        Me.GroupBox1.Controls.Add(Me.txtNewPassword1)
        Me.GroupBox1.Controls.Add(Me.txtNewPassword2)
        Me.GroupBox1.Controls.Add(Me.PictureBox1)
        Me.GroupBox1.Controls.Add(Me.Label21)
        Me.GroupBox1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(8, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(440, 288)
        Me.GroupBox1.TabIndex = 93
        Me.GroupBox1.TabStop = False
        '
        'txtUserID
        '
        Me.txtUserID.AlphaNumeric = True
        Me.txtUserID.BackColor = System.Drawing.Color.AntiqueWhite
        Me.txtUserID.BlankSpace = True
        Me.txtUserID.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUserID.GotFocusColour = System.Drawing.Color.AntiqueWhite
        Me.txtUserID.Location = New System.Drawing.Point(208, 80)
        Me.txtUserID.LostFocusColour = System.Drawing.Color.AntiqueWhite
        Me.txtUserID.Mandatory = False
        Me.txtUserID.MaxLength = 20
        Me.txtUserID.Name = "txtUserID"
        Me.txtUserID.Size = New System.Drawing.Size(184, 23)
        Me.txtUserID.SpecialChar = True
        Me.txtUserID.TabIndex = 1
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
        Me.btnClose.Location = New System.Drawing.Point(320, 232)
        Me.btnClose.LostFocusColour = System.Drawing.SystemColors.Control
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(104, 40)
        Me.btnClose.TabIndex = 6
        Me.btnClose.Text = "&Close"
        '
        'btnOk
        '
        Me.btnOk.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnOk.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnOk.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOk.ForeColor = System.Drawing.Color.Black
        Me.btnOk.GotFocusColour = System.Drawing.Color.FromArgb(CType(CType(118, Byte), Integer), CType(CType(114, Byte), Integer), CType(CType(158, Byte), Integer))
        Me.btnOk.Image = CType(resources.GetObject("btnOk.Image"), System.Drawing.Image)
        Me.btnOk.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnOk.Location = New System.Drawing.Point(216, 232)
        Me.btnOk.LostFocusColour = System.Drawing.SystemColors.Control
        Me.btnOk.Name = "btnOk"
        Me.btnOk.Size = New System.Drawing.Size(104, 40)
        Me.btnOk.TabIndex = 5
        Me.btnOk.Text = "&Save"
        '
        'lblAccountNo
        '
        Me.lblAccountNo.AutoSize = True
        Me.lblAccountNo.BackColor = System.Drawing.SystemColors.Control
        Me.lblAccountNo.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAccountNo.ForeColor = System.Drawing.Color.Black
        Me.lblAccountNo.Location = New System.Drawing.Point(48, 80)
        Me.lblAccountNo.Name = "lblAccountNo"
        Me.lblAccountNo.Size = New System.Drawing.Size(89, 16)
        Me.lblAccountNo.TabIndex = 100
        Me.lblAccountNo.Text = "User Name :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.Control
        Me.Label1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(48, 176)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(82, 16)
        Me.Label1.TabIndex = 101
        Me.Label1.Text = "RoleName :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.SystemColors.Control
        Me.Label2.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(48, 112)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(86, 16)
        Me.Label2.TabIndex = 102
        Me.Label2.Text = " Password :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.SystemColors.Control
        Me.Label3.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(48, 144)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(144, 16)
        Me.Label3.TabIndex = 99
        Me.Label3.Text = "Re-type  Password :"
        '
        'txtRole
        '
        Me.txtRole.AlphaNumeric = True
        Me.txtRole.BackColor = System.Drawing.Color.White
        Me.txtRole.BlankSpace = True
        Me.txtRole.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRole.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtRole.Location = New System.Drawing.Point(208, 176)
        Me.txtRole.LostFocusColour = System.Drawing.Color.White
        Me.txtRole.Mandatory = False
        Me.txtRole.MaxLength = 20
        Me.txtRole.Name = "txtRole"
        Me.txtRole.Size = New System.Drawing.Size(184, 23)
        Me.txtRole.SpecialChar = False
        Me.txtRole.TabIndex = 4
        '
        'txtNewPassword1
        '
        Me.txtNewPassword1.AlphaNumeric = True
        Me.txtNewPassword1.BackColor = System.Drawing.Color.White
        Me.txtNewPassword1.BlankSpace = True
        Me.txtNewPassword1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNewPassword1.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtNewPassword1.Location = New System.Drawing.Point(208, 112)
        Me.txtNewPassword1.LostFocusColour = System.Drawing.Color.White
        Me.txtNewPassword1.Mandatory = False
        Me.txtNewPassword1.MaxLength = 20
        Me.txtNewPassword1.Name = "txtNewPassword1"
        Me.txtNewPassword1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtNewPassword1.Size = New System.Drawing.Size(184, 23)
        Me.txtNewPassword1.SpecialChar = True
        Me.txtNewPassword1.TabIndex = 2
        '
        'txtNewPassword2
        '
        Me.txtNewPassword2.AlphaNumeric = True
        Me.txtNewPassword2.BackColor = System.Drawing.Color.White
        Me.txtNewPassword2.BlankSpace = True
        Me.txtNewPassword2.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNewPassword2.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtNewPassword2.Location = New System.Drawing.Point(208, 144)
        Me.txtNewPassword2.LostFocusColour = System.Drawing.Color.White
        Me.txtNewPassword2.Mandatory = False
        Me.txtNewPassword2.MaxLength = 20
        Me.txtNewPassword2.Name = "txtNewPassword2"
        Me.txtNewPassword2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtNewPassword2.Size = New System.Drawing.Size(184, 23)
        Me.txtNewPassword2.SpecialChar = True
        Me.txtNewPassword2.TabIndex = 3
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(24, 16)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(48, 40)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 92
        Me.PictureBox1.TabStop = False
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.BackColor = System.Drawing.SystemColors.Control
        Me.Label21.Font = New System.Drawing.Font("Georgia", 14.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label21.Location = New System.Drawing.Point(80, 16)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(127, 23)
        Me.Label21.TabIndex = 91
        Me.Label21.Text = "User Creation"
        Me.Label21.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'frmUserCreation
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.CancelButton = Me.btnClose
        Me.ClientSize = New System.Drawing.Size(458, 295)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmUserCreation"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "User Creation"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region "Function"
    Function fnSet() As Boolean
        objUser.UserID = txtUserID.Text
        Return True
    End Function

    Function fnCheck() As Boolean
        If txtUserID.Text = "" Then
            MsgBox("Enter user ID ", MsgBoxStyle.Information, Me.Text)
            txtUserID.Focus()
            Return False
        ElseIf txtNewPassword1.Text = "" Then
            MsgBox("Enter password ", MsgBoxStyle.Information, Me.Text)
            txtNewPassword1.Focus()
            Return False
        ElseIf Trim(txtNewPassword1.Text) <> Trim(txtNewPassword2.Text) Then
            MsgBox("Passwords are not matched, please enter correct password", MsgBoxStyle.Information, Me.Text)
            txtNewPassword2.Focus()
            Return False
        ElseIf txtRole.Text = "" Then
            MsgBox("Enter role name ", MsgBoxStyle.Information, Me.Text)
            txtRole.Focus()
            Return False
        ElseIf objUser.fuCheckRole() Then
            MsgBox("Role name already exist", MsgBoxStyle.Information, Me.Text)
            txtRole.Focus()
            Return False
        Else
            Return True
        End If
    End Function

    Function fnSetData() As Boolean
        objUser.UserID = txtUserID.Text
        objUser.Password = txtNewPassword1.Text
        objUser.TypeOfUser = txtRole.Text
        Return True
    End Function

    Sub sbclear()
        txtUserID.Text = ""
        txtNewPassword1.Text = ""
        txtNewPassword2.Text = ""
        txtRole.Text = ""
    End Sub

#End Region

    Private Sub btnOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOk.Click
        If fnCheck() Then
            If fnSetData() Then
                If objUser.fnCheckUserID() Then
                    MsgBox("UserId is already exist,try another one", MsgBoxStyle.Information, Me.Text)
                    sbclear()
                    txtUserID.Focus()
                Else
                    If objUser.fnAddUser(roleID) Then
                        MsgBox("New user created successfully", MsgBoxStyle.Information, Me.Text)
                        sbclear()
                    Else
                        MsgBox("New user creation failed, because of internal error", MsgBoxStyle.Exclamation, Me.Text)
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub txtUserID_Leave(ByVal sender As Object, ByVal e As System.EventArgs)
        If txtUserID.Text = "" Then
            MsgBox("Blank userID's are not allowed", MsgBoxStyle.Information, Me.Text)
        ElseIf fnSet() Then
            If objUser.fnCheckUserID() Then
                MsgBox("UserId is already exist,try another one", MsgBoxStyle.Information, Me.Text)
                txtUserID.Text = ""
                txtUserID.Focus()
            End If
        End If
    End Sub

    Private Sub frmUserCreation_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        roleID = objUser.fnGetNewRoleNo
    End Sub
End Class
