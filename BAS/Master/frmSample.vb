Public Class frmSample
    Inherits System.Windows.Forms.Form

#Region " Windows Form Designer generated code "

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
    Friend WithEvents SideButton5 As BankControls.SideButton
    Friend WithEvents SideButton6 As BankControls.SideButton
    Friend WithEvents SideButton7 As BankControls.SideButton
    Friend WithEvents SideButton8 As BankControls.SideButton
    Friend WithEvents SideButton9 As BankControls.SideButton
    Friend WithEvents SideButton10 As BankControls.SideButton
    Friend WithEvents SideButton1 As BankControls.SideButton
    Friend WithEvents SideButton2 As BankControls.SideButton
    Friend WithEvents SideButton3 As BankControls.SideButton
    Friend WithEvents SideButton4 As BankControls.SideButton
    Friend WithEvents pnlTrans As System.Windows.Forms.Panel
    Friend WithEvents pnlCreateNew As System.Windows.Forms.Panel
    Friend WithEvents pnlCreateMain As System.Windows.Forms.Panel
    Friend WithEvents hdrCreate As BankControls.HeaderPanel
    Friend WithEvents pnlTransMain As System.Windows.Forms.Panel
    Friend WithEvents hdrTrans As BankControls.HeaderPanel
    Friend WithEvents picDown As System.Windows.Forms.PictureBox
    Friend WithEvents picCreate As System.Windows.Forms.PictureBox
    Friend WithEvents picTrans As System.Windows.Forms.PictureBox
    Friend WithEvents picUp As System.Windows.Forms.PictureBox
    Friend WithEvents pnlCloseMain As System.Windows.Forms.Panel
    Friend WithEvents hdrClose As BankControls.HeaderPanel
    Friend WithEvents picClose As System.Windows.Forms.PictureBox
    Friend WithEvents pnlClose As System.Windows.Forms.Panel
    Friend WithEvents SideButton11 As BankControls.SideButton
    Friend WithEvents SideButton12 As BankControls.SideButton
    Friend WithEvents SideButton13 As BankControls.SideButton
    Friend WithEvents SideButton14 As BankControls.SideButton
    Friend WithEvents lblTrans As System.Windows.Forms.Label
    Friend WithEvents lblCreate As System.Windows.Forms.Label
    Friend WithEvents lblClose As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmSample))
        Me.pnlTransMain = New System.Windows.Forms.Panel
        Me.hdrTrans = New BankControls.HeaderPanel
        Me.lblTrans = New System.Windows.Forms.Label
        Me.picTrans = New System.Windows.Forms.PictureBox
        Me.pnlTrans = New System.Windows.Forms.Panel
        Me.SideButton10 = New BankControls.SideButton
        Me.SideButton7 = New BankControls.SideButton
        Me.SideButton5 = New BankControls.SideButton
        Me.SideButton8 = New BankControls.SideButton
        Me.SideButton6 = New BankControls.SideButton
        Me.SideButton9 = New BankControls.SideButton
        Me.pnlCreateMain = New System.Windows.Forms.Panel
        Me.hdrCreate = New BankControls.HeaderPanel
        Me.picCreate = New System.Windows.Forms.PictureBox
        Me.lblCreate = New System.Windows.Forms.Label
        Me.pnlCreateNew = New System.Windows.Forms.Panel
        Me.SideButton4 = New BankControls.SideButton
        Me.SideButton3 = New BankControls.SideButton
        Me.SideButton1 = New BankControls.SideButton
        Me.SideButton2 = New BankControls.SideButton
        Me.picDown = New System.Windows.Forms.PictureBox
        Me.picUp = New System.Windows.Forms.PictureBox
        Me.pnlCloseMain = New System.Windows.Forms.Panel
        Me.hdrClose = New BankControls.HeaderPanel
        Me.picClose = New System.Windows.Forms.PictureBox
        Me.lblClose = New System.Windows.Forms.Label
        Me.pnlClose = New System.Windows.Forms.Panel
        Me.SideButton11 = New BankControls.SideButton
        Me.SideButton12 = New BankControls.SideButton
        Me.SideButton13 = New BankControls.SideButton
        Me.SideButton14 = New BankControls.SideButton
        Me.pnlTransMain.SuspendLayout()
        Me.hdrTrans.SuspendLayout()
        Me.pnlTrans.SuspendLayout()
        Me.pnlCreateMain.SuspendLayout()
        Me.hdrCreate.SuspendLayout()
        Me.pnlCreateNew.SuspendLayout()
        Me.pnlCloseMain.SuspendLayout()
        Me.hdrClose.SuspendLayout()
        Me.pnlClose.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlTransMain
        '
        Me.pnlTransMain.BackColor = System.Drawing.Color.FromArgb(CType(209, Byte), CType(207, Byte), CType(220, Byte))
        Me.pnlTransMain.Controls.Add(Me.hdrTrans)
        Me.pnlTransMain.Controls.Add(Me.pnlTrans)
        Me.pnlTransMain.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlTransMain.Location = New System.Drawing.Point(0, 168)
        Me.pnlTransMain.Name = "pnlTransMain"
        Me.pnlTransMain.Size = New System.Drawing.Size(176, 232)
        Me.pnlTransMain.TabIndex = 2
        '
        'hdrTrans
        '
        Me.hdrTrans.BackColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(64, Byte))
        Me.hdrTrans.BackColor2 = System.Drawing.Color.LightSteelBlue
        Me.hdrTrans.Controls.Add(Me.lblTrans)
        Me.hdrTrans.Controls.Add(Me.picTrans)
        Me.hdrTrans.Cursor = System.Windows.Forms.Cursors.Hand
        Me.hdrTrans.Curvature = 25
        Me.hdrTrans.CurveMode = CSharpCustomPanelControl.CornerCurveMode.TopRight
        Me.hdrTrans.Dock = System.Windows.Forms.DockStyle.Top
        Me.hdrTrans.GradientMode = CSharpCustomPanelControl.LinearGradientMode.Vertical
        Me.hdrTrans.Location = New System.Drawing.Point(0, 0)
        Me.hdrTrans.Name = "hdrTrans"
        Me.hdrTrans.Size = New System.Drawing.Size(176, 32)
        Me.hdrTrans.TabIndex = 2
        '
        'lblTrans
        '
        Me.lblTrans.Dock = System.Windows.Forms.DockStyle.Left
        Me.lblTrans.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTrans.ForeColor = System.Drawing.Color.White
        Me.lblTrans.Location = New System.Drawing.Point(0, 0)
        Me.lblTrans.Name = "lblTrans"
        Me.lblTrans.Size = New System.Drawing.Size(96, 32)
        Me.lblTrans.TabIndex = 2
        Me.lblTrans.Text = "Transact..."
        Me.lblTrans.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'picTrans
        '
        Me.picTrans.BackColor = System.Drawing.Color.Transparent
        Me.picTrans.Image = CType(resources.GetObject("picTrans.Image"), System.Drawing.Image)
        Me.picTrans.Location = New System.Drawing.Point(152, 8)
        Me.picTrans.Name = "picTrans"
        Me.picTrans.Size = New System.Drawing.Size(16, 16)
        Me.picTrans.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picTrans.TabIndex = 3
        Me.picTrans.TabStop = False
        '
        'pnlTrans
        '
        Me.pnlTrans.Controls.Add(Me.SideButton10)
        Me.pnlTrans.Controls.Add(Me.SideButton7)
        Me.pnlTrans.Controls.Add(Me.SideButton5)
        Me.pnlTrans.Controls.Add(Me.SideButton8)
        Me.pnlTrans.Controls.Add(Me.SideButton6)
        Me.pnlTrans.Controls.Add(Me.SideButton9)
        Me.pnlTrans.Location = New System.Drawing.Point(0, 32)
        Me.pnlTrans.Name = "pnlTrans"
        Me.pnlTrans.Size = New System.Drawing.Size(176, 192)
        Me.pnlTrans.TabIndex = 5
        '
        'SideButton10
        '
        Me.SideButton10.Image = CType(resources.GetObject("SideButton10.Image"), System.Drawing.Image)
        Me.SideButton10.Location = New System.Drawing.Point(0, 128)
        Me.SideButton10.Name = "SideButton10"
        Me.SideButton10.Size = New System.Drawing.Size(176, 32)
        Me.SideButton10.TabIndex = 3
        Me.SideButton10.TextValue = "Refund Shares"
        '
        'SideButton7
        '
        Me.SideButton7.Image = CType(resources.GetObject("SideButton7.Image"), System.Drawing.Image)
        Me.SideButton7.Location = New System.Drawing.Point(0, 96)
        Me.SideButton7.Name = "SideButton7"
        Me.SideButton7.Size = New System.Drawing.Size(176, 32)
        Me.SideButton7.TabIndex = 2
        Me.SideButton7.TextValue = "Remit Shares "
        '
        'SideButton5
        '
        Me.SideButton5.Image = CType(resources.GetObject("SideButton5.Image"), System.Drawing.Image)
        Me.SideButton5.Location = New System.Drawing.Point(0, 0)
        Me.SideButton5.Name = "SideButton5"
        Me.SideButton5.Size = New System.Drawing.Size(176, 32)
        Me.SideButton5.TabIndex = 0
        Me.SideButton5.TextValue = "Deposit Cash"
        '
        'SideButton8
        '
        Me.SideButton8.Image = CType(resources.GetObject("SideButton8.Image"), System.Drawing.Image)
        Me.SideButton8.Location = New System.Drawing.Point(0, 64)
        Me.SideButton8.Name = "SideButton8"
        Me.SideButton8.Size = New System.Drawing.Size(176, 32)
        Me.SideButton8.TabIndex = 1
        Me.SideButton8.TextValue = "FD Interest Payment"
        '
        'SideButton6
        '
        Me.SideButton6.Image = CType(resources.GetObject("SideButton6.Image"), System.Drawing.Image)
        Me.SideButton6.Location = New System.Drawing.Point(0, 32)
        Me.SideButton6.Name = "SideButton6"
        Me.SideButton6.Size = New System.Drawing.Size(176, 32)
        Me.SideButton6.TabIndex = 0
        Me.SideButton6.TextValue = "Withdraw Cash"
        '
        'SideButton9
        '
        Me.SideButton9.Image = CType(resources.GetObject("SideButton9.Image"), System.Drawing.Image)
        Me.SideButton9.Location = New System.Drawing.Point(0, 160)
        Me.SideButton9.Name = "SideButton9"
        Me.SideButton9.Size = New System.Drawing.Size(176, 32)
        Me.SideButton9.TabIndex = 4
        Me.SideButton9.TextValue = "Loan Repayment"
        '
        'pnlCreateMain
        '
        Me.pnlCreateMain.BackColor = System.Drawing.Color.FromArgb(CType(209, Byte), CType(207, Byte), CType(220, Byte))
        Me.pnlCreateMain.Controls.Add(Me.hdrCreate)
        Me.pnlCreateMain.Controls.Add(Me.pnlCreateNew)
        Me.pnlCreateMain.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlCreateMain.Location = New System.Drawing.Point(0, 0)
        Me.pnlCreateMain.Name = "pnlCreateMain"
        Me.pnlCreateMain.Size = New System.Drawing.Size(176, 168)
        Me.pnlCreateMain.TabIndex = 1
        '
        'hdrCreate
        '
        Me.hdrCreate.BackColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(64, Byte))
        Me.hdrCreate.BackColor2 = System.Drawing.Color.LightSteelBlue
        Me.hdrCreate.Controls.Add(Me.picCreate)
        Me.hdrCreate.Controls.Add(Me.lblCreate)
        Me.hdrCreate.Cursor = System.Windows.Forms.Cursors.Hand
        Me.hdrCreate.Curvature = 25
        Me.hdrCreate.CurveMode = CSharpCustomPanelControl.CornerCurveMode.TopRight
        Me.hdrCreate.Dock = System.Windows.Forms.DockStyle.Top
        Me.hdrCreate.GradientMode = CSharpCustomPanelControl.LinearGradientMode.Vertical
        Me.hdrCreate.Location = New System.Drawing.Point(0, 0)
        Me.hdrCreate.Name = "hdrCreate"
        Me.hdrCreate.Size = New System.Drawing.Size(176, 32)
        Me.hdrCreate.TabIndex = 0
        '
        'picCreate
        '
        Me.picCreate.BackColor = System.Drawing.Color.Transparent
        Me.picCreate.Image = CType(resources.GetObject("picCreate.Image"), System.Drawing.Image)
        Me.picCreate.Location = New System.Drawing.Point(152, 8)
        Me.picCreate.Name = "picCreate"
        Me.picCreate.Size = New System.Drawing.Size(16, 16)
        Me.picCreate.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picCreate.TabIndex = 3
        Me.picCreate.TabStop = False
        '
        'lblCreate
        '
        Me.lblCreate.Dock = System.Windows.Forms.DockStyle.Left
        Me.lblCreate.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCreate.ForeColor = System.Drawing.Color.White
        Me.lblCreate.Location = New System.Drawing.Point(0, 0)
        Me.lblCreate.Name = "lblCreate"
        Me.lblCreate.Size = New System.Drawing.Size(112, 32)
        Me.lblCreate.TabIndex = 2
        Me.lblCreate.Text = "Create New..."
        Me.lblCreate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pnlCreateNew
        '
        Me.pnlCreateNew.Controls.Add(Me.SideButton4)
        Me.pnlCreateNew.Controls.Add(Me.SideButton3)
        Me.pnlCreateNew.Controls.Add(Me.SideButton1)
        Me.pnlCreateNew.Controls.Add(Me.SideButton2)
        Me.pnlCreateNew.Location = New System.Drawing.Point(0, 32)
        Me.pnlCreateNew.Name = "pnlCreateNew"
        Me.pnlCreateNew.Size = New System.Drawing.Size(176, 128)
        Me.pnlCreateNew.TabIndex = 5
        '
        'SideButton4
        '
        Me.SideButton4.Image = CType(resources.GetObject("SideButton4.Image"), System.Drawing.Image)
        Me.SideButton4.Location = New System.Drawing.Point(0, 96)
        Me.SideButton4.Name = "SideButton4"
        Me.SideButton4.Size = New System.Drawing.Size(176, 32)
        Me.SideButton4.TabIndex = 0
        Me.SideButton4.TextValue = "Loan"
        '
        'SideButton3
        '
        Me.SideButton3.Image = CType(resources.GetObject("SideButton3.Image"), System.Drawing.Image)
        Me.SideButton3.Location = New System.Drawing.Point(0, 64)
        Me.SideButton3.Name = "SideButton3"
        Me.SideButton3.Size = New System.Drawing.Size(176, 32)
        Me.SideButton3.TabIndex = 0
        Me.SideButton3.TextValue = "FD Account"
        '
        'SideButton1
        '
        Me.SideButton1.Image = CType(resources.GetObject("SideButton1.Image"), System.Drawing.Image)
        Me.SideButton1.Location = New System.Drawing.Point(0, 0)
        Me.SideButton1.Name = "SideButton1"
        Me.SideButton1.Size = New System.Drawing.Size(176, 32)
        Me.SideButton1.TabIndex = 0
        Me.SideButton1.TextValue = "Member"
        '
        'SideButton2
        '
        Me.SideButton2.Image = CType(resources.GetObject("SideButton2.Image"), System.Drawing.Image)
        Me.SideButton2.Location = New System.Drawing.Point(0, 32)
        Me.SideButton2.Name = "SideButton2"
        Me.SideButton2.Size = New System.Drawing.Size(176, 32)
        Me.SideButton2.TabIndex = 0
        Me.SideButton2.TextValue = "SB Account"
        '
        'picDown
        '
        Me.picDown.Image = CType(resources.GetObject("picDown.Image"), System.Drawing.Image)
        Me.picDown.Location = New System.Drawing.Point(88, 576)
        Me.picDown.Name = "picDown"
        Me.picDown.Size = New System.Drawing.Size(16, 16)
        Me.picDown.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picDown.TabIndex = 3
        Me.picDown.TabStop = False
        Me.picDown.Visible = False
        '
        'picUp
        '
        Me.picUp.Image = CType(resources.GetObject("picUp.Image"), System.Drawing.Image)
        Me.picUp.Location = New System.Drawing.Point(48, 576)
        Me.picUp.Name = "picUp"
        Me.picUp.Size = New System.Drawing.Size(16, 16)
        Me.picUp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picUp.TabIndex = 3
        Me.picUp.TabStop = False
        Me.picUp.Visible = False
        '
        'pnlCloseMain
        '
        Me.pnlCloseMain.BackColor = System.Drawing.Color.FromArgb(CType(209, Byte), CType(207, Byte), CType(220, Byte))
        Me.pnlCloseMain.Controls.Add(Me.hdrClose)
        Me.pnlCloseMain.Controls.Add(Me.pnlClose)
        Me.pnlCloseMain.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlCloseMain.Location = New System.Drawing.Point(0, 400)
        Me.pnlCloseMain.Name = "pnlCloseMain"
        Me.pnlCloseMain.Size = New System.Drawing.Size(176, 168)
        Me.pnlCloseMain.TabIndex = 4
        '
        'hdrClose
        '
        Me.hdrClose.BackColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(64, Byte))
        Me.hdrClose.BackColor2 = System.Drawing.Color.LightSteelBlue
        Me.hdrClose.Controls.Add(Me.picClose)
        Me.hdrClose.Controls.Add(Me.lblClose)
        Me.hdrClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.hdrClose.Curvature = 25
        Me.hdrClose.CurveMode = CSharpCustomPanelControl.CornerCurveMode.TopRight
        Me.hdrClose.Dock = System.Windows.Forms.DockStyle.Top
        Me.hdrClose.GradientMode = CSharpCustomPanelControl.LinearGradientMode.Vertical
        Me.hdrClose.Location = New System.Drawing.Point(0, 0)
        Me.hdrClose.Name = "hdrClose"
        Me.hdrClose.Size = New System.Drawing.Size(176, 32)
        Me.hdrClose.TabIndex = 0
        '
        'picClose
        '
        Me.picClose.BackColor = System.Drawing.Color.Transparent
        Me.picClose.Image = CType(resources.GetObject("picClose.Image"), System.Drawing.Image)
        Me.picClose.Location = New System.Drawing.Point(152, 8)
        Me.picClose.Name = "picClose"
        Me.picClose.Size = New System.Drawing.Size(16, 16)
        Me.picClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picClose.TabIndex = 3
        Me.picClose.TabStop = False
        '
        'lblClose
        '
        Me.lblClose.Dock = System.Windows.Forms.DockStyle.Left
        Me.lblClose.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblClose.ForeColor = System.Drawing.Color.White
        Me.lblClose.Location = New System.Drawing.Point(0, 0)
        Me.lblClose.Name = "lblClose"
        Me.lblClose.Size = New System.Drawing.Size(64, 32)
        Me.lblClose.TabIndex = 2
        Me.lblClose.Text = " Close..."
        Me.lblClose.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'pnlClose
        '
        Me.pnlClose.Controls.Add(Me.SideButton11)
        Me.pnlClose.Controls.Add(Me.SideButton12)
        Me.pnlClose.Controls.Add(Me.SideButton13)
        Me.pnlClose.Controls.Add(Me.SideButton14)
        Me.pnlClose.Location = New System.Drawing.Point(0, 32)
        Me.pnlClose.Name = "pnlClose"
        Me.pnlClose.Size = New System.Drawing.Size(176, 128)
        Me.pnlClose.TabIndex = 5
        '
        'SideButton11
        '
        Me.SideButton11.Image = CType(resources.GetObject("SideButton11.Image"), System.Drawing.Image)
        Me.SideButton11.Location = New System.Drawing.Point(0, 96)
        Me.SideButton11.Name = "SideButton11"
        Me.SideButton11.Size = New System.Drawing.Size(176, 32)
        Me.SideButton11.TabIndex = 0
        Me.SideButton11.TextValue = "Loan"
        '
        'SideButton12
        '
        Me.SideButton12.Image = CType(resources.GetObject("SideButton12.Image"), System.Drawing.Image)
        Me.SideButton12.Location = New System.Drawing.Point(0, 64)
        Me.SideButton12.Name = "SideButton12"
        Me.SideButton12.Size = New System.Drawing.Size(176, 32)
        Me.SideButton12.TabIndex = 0
        Me.SideButton12.TextValue = "FD Account"
        '
        'SideButton13
        '
        Me.SideButton13.Image = CType(resources.GetObject("SideButton13.Image"), System.Drawing.Image)
        Me.SideButton13.Location = New System.Drawing.Point(0, 0)
        Me.SideButton13.Name = "SideButton13"
        Me.SideButton13.Size = New System.Drawing.Size(176, 32)
        Me.SideButton13.TabIndex = 0
        Me.SideButton13.TextValue = "Membership"
        '
        'SideButton14
        '
        Me.SideButton14.Image = CType(resources.GetObject("SideButton14.Image"), System.Drawing.Image)
        Me.SideButton14.Location = New System.Drawing.Point(0, 32)
        Me.SideButton14.Name = "SideButton14"
        Me.SideButton14.Size = New System.Drawing.Size(176, 32)
        Me.SideButton14.TabIndex = 0
        Me.SideButton14.TextValue = "SB Account"
        '
        'frmSample
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.AutoScroll = True
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(176, 600)
        Me.ControlBox = False
        Me.Controls.Add(Me.pnlCloseMain)
        Me.Controls.Add(Me.pnlTransMain)
        Me.Controls.Add(Me.pnlCreateMain)
        Me.Controls.Add(Me.picDown)
        Me.Controls.Add(Me.picUp)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmSample"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Main Menu"
        Me.pnlTransMain.ResumeLayout(False)
        Me.hdrTrans.ResumeLayout(False)
        Me.pnlTrans.ResumeLayout(False)
        Me.pnlCreateMain.ResumeLayout(False)
        Me.hdrCreate.ResumeLayout(False)
        Me.pnlCreateNew.ResumeLayout(False)
        Me.pnlCloseMain.ResumeLayout(False)
        Me.hdrClose.ResumeLayout(False)
        Me.pnlClose.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region "Code to Create Instance Object"

    Private Shared m_FormDefInstance As frmSample
    Private Shared m_InitializingDefInstance As Boolean

    Public Shared Property DefInstance() As frmSample
        Get
            If m_FormDefInstance Is Nothing OrElse m_FormDefInstance.IsDisposed Then
                m_InitializingDefInstance = True
                m_FormDefInstance = New frmSample
                m_InitializingDefInstance = False
            End If
            DefInstance = m_FormDefInstance
        End Get
        Set(ByVal Value As frmSample)
            m_FormDefInstance = Value
        End Set
    End Property

#End Region


    Private Sub frmSample_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Resize

        Me.Left = 0
        Me.Top = 0
        Me.WindowState = FormWindowState.Normal

    End Sub

    Private Sub SideButton1_Click1(ByVal sender As Object, ByVal e As System.EventArgs) Handles SideButton1.Click1

        Dim objMemberCreation As frmMemberCreation
        objMemberCreation = frmMemberCreation.DefInstance
        objMemberCreation.MdiParent = Me.MdiParent
        objMemberCreation.BringToFront()
        objMemberCreation.Show()
        objMemberCreation = Nothing

    End Sub

    Private Sub SideButton2_Click1(ByVal sender As Object, ByVal e As System.EventArgs) Handles SideButton2.Click1

        Dim objSBAccCreation As frmSBAccCreation
        objSBAccCreation = frmSBAccCreation.DefInstance
        objSBAccCreation.MdiParent = Me.MdiParent
        objSBAccCreation.BringToFront()
        objSBAccCreation.Show()
        objSBAccCreation = Nothing

    End Sub

    Private Sub SideButton3_Click1(ByVal sender As Object, ByVal e As System.EventArgs) Handles SideButton3.Click1

        Dim objfrmFDCreation As frmFDCreation
        objfrmFDCreation = frmFDCreation.DefInstance
        objfrmFDCreation.MdiParent = Me.MdiParent
        objfrmFDCreation.BringToFront()
        objfrmFDCreation.Show()
        objfrmFDCreation = Nothing

    End Sub

    Private Sub SideButton7_Click1(ByVal sender As Object, ByVal e As System.EventArgs) Handles SideButton7.Click1

        Dim objfrmRemitShares As New frmRemitShares
        objfrmRemitShares.ShowDialog(Me)
        objfrmRemitShares = Nothing

    End Sub

    Private Sub SideButton10_Click1(ByVal sender As Object, ByVal e As System.EventArgs) Handles SideButton10.Click1

        Dim objfrmRefundShares As New frmRefundShares
        objfrmRefundShares.ShowDialog(Me)
        objfrmRefundShares = Nothing

    End Sub

    Private Sub picTrans_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picTrans.Click, hdrTrans.Click, lblTrans.Click

        If picTrans.Image Is picDown.Image Then
            picTrans.Image = picUp.Image
            pnlTransMain.Height = hdrTrans.Height + pnlTrans.Height + 10
        Else
            picTrans.Image = picDown.Image
            pnlTransMain.Height = hdrTrans.Height
        End If

    End Sub

    Private Sub picCreate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picCreate.Click, hdrCreate.Click, lblCreate.Click

        If picCreate.Image Is picDown.Image Then
            picCreate.Image = picUp.Image
            pnlCreateMain.Height = hdrCreate.Height + pnlCreateNew.Height + 10
        Else
            picCreate.Image = picDown.Image
            pnlCreateMain.Height = hdrCreate.Height
        End If

    End Sub

    Private Sub picClose_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles picClose.Click, hdrClose.Click, lblClose.Click

        If picClose.Image Is picDown.Image Then
            picClose.Image = picUp.Image
            pnlCloseMain.Height = hdrClose.Height + pnlClose.Height + 10
        Else
            picClose.Image = picDown.Image
            pnlCloseMain.Height = hdrClose.Height
        End If

    End Sub

    Private Sub SideButton13_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles SideButton13.Click, SideButton13.Click1

        Dim ObjfrmMemberClose As New frmMemberClose
        ObjfrmMemberClose.ShowDialog(Me)
        ObjfrmMemberClose = Nothing

    End Sub

    Private Sub SideButton14_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles SideButton14.Click, SideButton14.Click1

        Dim ObjfrmSBClose As New frmSBClouser
        ObjfrmSBClose.ShowDialog(Me)
        ObjfrmSBClose = Nothing

    End Sub

    Private Sub SideButton12_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles SideButton12.Click, SideButton12.Click1

        '''Dim ObjfrmFDClose As New frmFDClosure
        '''ObjfrmFDClose.ShowDialog(Me)
        '''ObjfrmFDClose = Nothing

        Dim ObjfrmFDClose As frmFDClosure
        ObjfrmFDClose = frmFDClosure.DefInstance
        ObjfrmFDClose.MdiParent = Me.MdiParent
        ObjfrmFDClose.BringToFront()
        ObjfrmFDClose.Show()
        ObjfrmFDClose = Nothing

    End Sub

End Class

