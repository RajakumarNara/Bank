Public Class frmLogin
    Inherits System.Windows.Forms.Form

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
    Friend WithEvents CustomPanel1 As CSharpCustomPanelControl.CustomPanel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents CustomPanel2 As CSharpCustomPanelControl.CustomPanel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnLogin As BankControls.NewButton
    Friend WithEvents btnCancel As BankControls.NewButton
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents txtUserName As BankControls.TextControl
    Friend WithEvents txtPassword As BankControls.TextControl
    Friend WithEvents BalloonToolTip1 As CustomTooltip.BalloonToolTip
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents CustomPanel3 As CSharpCustomPanelControl.CustomPanel
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents PictureBox5 As System.Windows.Forms.PictureBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLogin))
        Me.CustomPanel1 = New CSharpCustomPanelControl.CustomPanel
        Me.Label1 = New System.Windows.Forms.Label
        Me.CustomPanel2 = New CSharpCustomPanelControl.CustomPanel
        Me.txtUserName = New BankControls.TextControl
        Me.Label3 = New System.Windows.Forms.Label
        Me.btnCancel = New BankControls.NewButton
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.txtPassword = New BankControls.TextControl
        Me.Label2 = New System.Windows.Forms.Label
        Me.btnLogin = New BankControls.NewButton
        Me.Label4 = New System.Windows.Forms.Label
        Me.PictureBox2 = New System.Windows.Forms.PictureBox
        Me.PictureBox3 = New System.Windows.Forms.PictureBox
        Me.CustomPanel3 = New CSharpCustomPanelControl.CustomPanel
        Me.Label11 = New System.Windows.Forms.Label
        Me.PictureBox5 = New System.Windows.Forms.PictureBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.BalloonToolTip1 = New CustomTooltip.BalloonToolTip
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.CustomPanel1.SuspendLayout()
        Me.CustomPanel2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.CustomPanel3.SuspendLayout()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CustomPanel1
        '
        Me.CustomPanel1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.CustomPanel1.BackColor2 = System.Drawing.Color.SlateGray
        Me.BalloonToolTip1.SetBalloonText(Me.CustomPanel1, Nothing)
        Me.CustomPanel1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.CustomPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CustomPanel1.Controls.Add(Me.Label1)
        Me.CustomPanel1.Controls.Add(Me.CustomPanel2)
        Me.CustomPanel1.Controls.Add(Me.PictureBox2)
        Me.CustomPanel1.Controls.Add(Me.PictureBox3)
        Me.CustomPanel1.Controls.Add(Me.CustomPanel3)
        Me.CustomPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CustomPanel1.GradientMode = CSharpCustomPanelControl.LinearGradientMode.Vertical
        Me.CustomPanel1.Location = New System.Drawing.Point(0, 0)
        Me.CustomPanel1.Name = "CustomPanel1"
        Me.CustomPanel1.Padding = New System.Windows.Forms.Padding(20)
        Me.CustomPanel1.Size = New System.Drawing.Size(1024, 752)
        Me.CustomPanel1.TabIndex = 7
        '
        'Label1
        '
        Me.BalloonToolTip1.SetBalloonText(Me.Label1, "Bank Automation System by Coherent Technologies")
        Me.Label1.Font = New System.Drawing.Font("Bookman Old Style", 24.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.SlateGray
        Me.Label1.Location = New System.Drawing.Point(288, 176)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(432, 40)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Bank Automation System"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'CustomPanel2
        '
        Me.CustomPanel2.BackColor = System.Drawing.Color.SlateGray
        Me.CustomPanel2.BackColor2 = System.Drawing.Color.WhiteSmoke
        Me.BalloonToolTip1.SetBalloonText(Me.CustomPanel2, Nothing)
        Me.CustomPanel2.Controls.Add(Me.txtUserName)
        Me.CustomPanel2.Controls.Add(Me.Label3)
        Me.CustomPanel2.Controls.Add(Me.btnCancel)
        Me.CustomPanel2.Controls.Add(Me.PictureBox1)
        Me.CustomPanel2.Controls.Add(Me.txtPassword)
        Me.CustomPanel2.Controls.Add(Me.Label2)
        Me.CustomPanel2.Controls.Add(Me.btnLogin)
        Me.CustomPanel2.Controls.Add(Me.Label4)
        Me.CustomPanel2.Curvature = 20
        Me.CustomPanel2.GradientMode = CSharpCustomPanelControl.LinearGradientMode.Vertical
        Me.CustomPanel2.Location = New System.Drawing.Point(536, 480)
        Me.CustomPanel2.Name = "CustomPanel2"
        Me.CustomPanel2.Size = New System.Drawing.Size(424, 208)
        Me.CustomPanel2.TabIndex = 1
        '
        'txtUserName
        '
        Me.txtUserName.AlphaNumeric = True
        Me.txtUserName.BackColor = System.Drawing.Color.WhiteSmoke
        Me.BalloonToolTip1.SetBalloonText(Me.txtUserName, "Name of User to Login?")
        Me.txtUserName.BlankSpace = True
        Me.txtUserName.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUserName.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtUserName.Location = New System.Drawing.Point(216, 56)
        Me.txtUserName.LostFocusColour = System.Drawing.Color.WhiteSmoke
        Me.txtUserName.Mandatory = False
        Me.txtUserName.Name = "txtUserName"
        Me.txtUserName.Size = New System.Drawing.Size(144, 23)
        Me.txtUserName.SpecialChar = False
        Me.txtUserName.TabIndex = 0
        '
        'Label3
        '
        Me.BalloonToolTip1.SetBalloonText(Me.Label3, Nothing)
        Me.Label3.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.DimGray
        Me.Label3.Image = CType(resources.GetObject("Label3.Image"), System.Drawing.Image)
        Me.Label3.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label3.Location = New System.Drawing.Point(120, 99)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(96, 16)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Password :"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnCancel
        '
        Me.BalloonToolTip1.SetBalloonText(Me.btnCancel, "Cancel Login")
        Me.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnCancel.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.ForeColor = System.Drawing.Color.Black
        Me.btnCancel.GotFocusColour = System.Drawing.Color.SlateGray
        Me.btnCancel.Image = CType(resources.GetObject("btnCancel.Image"), System.Drawing.Image)
        Me.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCancel.Location = New System.Drawing.Point(248, 144)
        Me.btnCancel.LostFocusColour = System.Drawing.Color.Empty
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(96, 32)
        Me.btnCancel.TabIndex = 3
        Me.btnCancel.Text = "&Cancel"
        '
        'PictureBox1
        '
        Me.BalloonToolTip1.SetBalloonText(Me.PictureBox1, Nothing)
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(16, 56)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(88, 72)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'txtPassword
        '
        Me.txtPassword.AlphaNumeric = True
        Me.txtPassword.BackColor = System.Drawing.Color.WhiteSmoke
        Me.BalloonToolTip1.SetBalloonText(Me.txtPassword, "Password Used for Login?")
        Me.txtPassword.BlankSpace = True
        Me.txtPassword.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPassword.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtPassword.Location = New System.Drawing.Point(216, 96)
        Me.txtPassword.LostFocusColour = System.Drawing.Color.WhiteSmoke
        Me.txtPassword.Mandatory = False
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(35)
        Me.txtPassword.Size = New System.Drawing.Size(144, 23)
        Me.txtPassword.SpecialChar = True
        Me.txtPassword.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.BalloonToolTip1.SetBalloonText(Me.Label2, Nothing)
        Me.Label2.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label2.Location = New System.Drawing.Point(120, 59)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(96, 16)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "User Name :"
        '
        'btnLogin
        '
        Me.BalloonToolTip1.SetBalloonText(Me.btnLogin, "Login To System")
        Me.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnLogin.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogin.ForeColor = System.Drawing.Color.Black
        Me.btnLogin.GotFocusColour = System.Drawing.Color.SlateGray
        Me.btnLogin.Image = CType(resources.GetObject("btnLogin.Image"), System.Drawing.Image)
        Me.btnLogin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnLogin.Location = New System.Drawing.Point(144, 144)
        Me.btnLogin.LostFocusColour = System.Drawing.Color.Empty
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(96, 32)
        Me.btnLogin.TabIndex = 2
        Me.btnLogin.Text = "&Login"
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.BalloonToolTip1.SetBalloonText(Me.Label4, Nothing)
        Me.Label4.Font = New System.Drawing.Font("Courier New", 14.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label4.Location = New System.Drawing.Point(80, 8)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(264, 32)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Login Panel"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBox2
        '
        Me.BalloonToolTip1.SetBalloonText(Me.PictureBox2, "Bank Automation System by Coherent Technologies")
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(456, 80)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(96, 88)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 2
        Me.PictureBox2.TabStop = False
        '
        'PictureBox3
        '
        Me.BalloonToolTip1.SetBalloonText(Me.PictureBox3, Nothing)
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(472, 568)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(56, 48)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 2
        Me.PictureBox3.TabStop = False
        Me.PictureBox3.Visible = False
        '
        'CustomPanel3
        '
        Me.CustomPanel3.BackColor = System.Drawing.Color.SlateGray
        Me.CustomPanel3.BackColor2 = System.Drawing.Color.WhiteSmoke
        Me.BalloonToolTip1.SetBalloonText(Me.CustomPanel3, Nothing)
        Me.CustomPanel3.Controls.Add(Me.Label11)
        Me.CustomPanel3.Controls.Add(Me.PictureBox5)
        Me.CustomPanel3.Controls.Add(Me.Label5)
        Me.CustomPanel3.Controls.Add(Me.Label6)
        Me.CustomPanel3.Controls.Add(Me.Label7)
        Me.CustomPanel3.Controls.Add(Me.Label8)
        Me.CustomPanel3.Controls.Add(Me.Label9)
        Me.CustomPanel3.Controls.Add(Me.Label10)
        Me.CustomPanel3.Curvature = 20
        Me.CustomPanel3.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CustomPanel3.Location = New System.Drawing.Point(64, 480)
        Me.CustomPanel3.Name = "CustomPanel3"
        Me.CustomPanel3.Size = New System.Drawing.Size(408, 208)
        Me.CustomPanel3.TabIndex = 1
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.BalloonToolTip1.SetBalloonText(Me.Label11, Nothing)
        Me.Label11.ForeColor = System.Drawing.SystemColors.Window
        Me.Label11.Location = New System.Drawing.Point(101, 117)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(193, 16)
        Me.Label11.TabIndex = 3
        Me.Label11.Text = " near malleshawaram rly stn"
        '
        'PictureBox5
        '
        Me.PictureBox5.BackColor = System.Drawing.Color.Transparent
        Me.BalloonToolTip1.SetBalloonText(Me.PictureBox5, Nothing)
        Me.PictureBox5.Image = CType(resources.GetObject("PictureBox5.Image"), System.Drawing.Image)
        Me.PictureBox5.Location = New System.Drawing.Point(80, 48)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(240, 40)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox5.TabIndex = 3
        Me.PictureBox5.TabStop = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.BalloonToolTip1.SetBalloonText(Me.Label5, Nothing)
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label5.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label5.Location = New System.Drawing.Point(24, 24)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(98, 16)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Developed By:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.BalloonToolTip1.SetBalloonText(Me.Label6, Nothing)
        Me.Label6.Font = New System.Drawing.Font("Georgia", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label6.Location = New System.Drawing.Point(80, 56)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(222, 25)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Coherent Technologies"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.BalloonToolTip1.SetBalloonText(Me.Label7, Nothing)
        Me.Label7.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label7.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label7.Location = New System.Drawing.Point(76, 96)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(297, 16)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "#q-9/b, 4th cross, 4th main, maruthi extn, "
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.BalloonToolTip1.SetBalloonText(Me.Label8, Nothing)
        Me.Label8.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label8.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label8.Location = New System.Drawing.Point(95, 143)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(200, 16)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Devaiah park, Bangalore - 21"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.BalloonToolTip1.SetBalloonText(Me.Label9, Nothing)
        Me.Label9.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label9.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label9.Location = New System.Drawing.Point(8, 176)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(142, 16)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "www.coherent.co.in"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.BalloonToolTip1.SetBalloonText(Me.Label10, Nothing)
        Me.Label10.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label10.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label10.Location = New System.Drawing.Point(233, 176)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(167, 16)
        Me.Label10.TabIndex = 0
        Me.Label10.Text = "support@coherent.co.in"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BalloonToolTip1
        '
        Me.BalloonToolTip1.BackColor = System.Drawing.SystemColors.Info
        Me.BalloonToolTip1.ForeColor = System.Drawing.SystemColors.InfoText
        Me.BalloonToolTip1.Title = ""
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'frmLogin
        '
        Me.AcceptButton = Me.btnLogin
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.White
        Me.CancelButton = Me.btnCancel
        Me.ClientSize = New System.Drawing.Size(1024, 752)
        Me.Controls.Add(Me.CustomPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Name = "frmLogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "BAS"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.CustomPanel1.ResumeLayout(False)
        Me.CustomPanel2.ResumeLayout(False)
        Me.CustomPanel2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.CustomPanel3.ResumeLayout(False)
        Me.CustomPanel3.PerformLayout()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
    Dim objUser As New clsUsers

    Private Const SND_ASYNC As Int32 = &H1
    Dim intCounter As Integer = 0

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Application.Exit()
    End Sub

    Private Sub btnLogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLogin.Click
        If fnCheck() = False Then
            Exit Sub
        End If

        Try
            intCounter += 1
            If objUser.fnCheckPassword(txtUserName.Text, txtPassword.Text) Then
                PictureBox1.Image = PictureBox3.Image
                'fnCheckRoles()
                Timer1.Start()
            Else
                MsgBox("Invalid login details", MsgBoxStyle.Exclamation, "Login Error")
                txtUserName.Focus()
            End If
            If intCounter >= 3 Then
                MsgBox("You do not have correct login details, application will close now.", MsgBoxStyle.Information, Me.Text)
                Application.Exit()
            End If

        Catch ex As Exception
            Me.ShowDialog()
            MsgBox(ex.Message)
        End Try
    End Sub

    Function fnCheck() As Boolean
        If txtUserName.Text = "" Then
            MsgBox("Enter user ID", MsgBoxStyle.Information, "Data Error")
            txtUserName.Focus()
            Return False
        ElseIf txtPassword.Text = "" Then
            MsgBox("Enter password ", MsgBoxStyle.Information, "Data Error")
            txtPassword.Focus()
            Return False
        Else
            Return True
        End If
    End Function

    Private Sub Timer1_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Timer1.Tick

        sbInitialise()      'to initialise system settings and global objects
        Me.Hide()
        Timer1.Stop()
        Timer1.Enabled = False
        If pbUserId <> "" Then
            pbUserId = txtUserName.Text
            fnLogEntry(pbUserId, pbUserId & "Logged in to the system", Date.Now, "Login")
            Me.Close()
            Exit Sub
        End If
        pbUserId = txtUserName.Text
        fnLogEntry(pbUserId, pbUserId & "Loggedin to the system", Date.Now, "Login")

        objfrmMain.ShowDialog()
        Me.ShowInTaskbar = False

    End Sub

End Class
