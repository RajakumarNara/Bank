Imports System.Math

Public Class frmFDList
    Inherits System.Windows.Forms.Form


#Region "Form Global Variables"

    Dim objFDAccount As New clsFDAccount
    Dim dvFDAccounts As DataView
    Public strFDNo As String
    Dim strFilter As String = "Name like '%'"
    Dim objIntTable As DataTable
    Friend WithEvents Label32 As System.Windows.Forms.Label
    Friend WithEvents btnClose As BankControls.NewButton
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
    Friend WithEvents lblMessage As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cmbType As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtSearch As BankControls.TextControl
    Friend WithEvents Label39 As System.Windows.Forms.Label
    Friend WithEvents cmbDepositType As System.Windows.Forms.ComboBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents btnAddFD As BankControls.NewButton
    Dim intcounter1 As Integer

#End Region

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
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnReceiptDetails As BankControls.NewButton
    Friend WithEvents btnNominees As BankControls.NewButton
    Friend WithEvents btnFamilyDetails As BankControls.NewButton
    Friend WithEvents btnJointHolders As BankControls.NewButton
    Friend WithEvents btnFDDetails As BankControls.NewButton
    Friend WithEvents btnTransactions As BankControls.NewButton
    Friend WithEvents ContextMenu1 As System.Windows.Forms.ContextMenu
    Friend WithEvents mnuFDDetails As UltimateMenus.KunalMenuItem
    Friend WithEvents mnuFamilyDetails As UltimateMenus.KunalMenuItem
    Friend WithEvents mnuNomineeDetails As UltimateMenus.KunalMenuItem
    Friend WithEvents mnuJointHolders As UltimateMenus.KunalMenuItem
    Friend WithEvents mnuTransactions As UltimateMenus.KunalMenuItem
    Friend WithEvents MenuItem1 As System.Windows.Forms.MenuItem
    Friend WithEvents mnuNewFD As System.Windows.Forms.MenuItem
    Friend WithEvents NewButton1 As BankControls.NewButton
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmFDList))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.NewButton1 = New BankControls.NewButton
        Me.btnReceiptDetails = New BankControls.NewButton
        Me.btnNominees = New BankControls.NewButton
        Me.btnFamilyDetails = New BankControls.NewButton
        Me.btnJointHolders = New BankControls.NewButton
        Me.btnFDDetails = New BankControls.NewButton
        Me.btnTransactions = New BankControls.NewButton
        Me.ContextMenu1 = New System.Windows.Forms.ContextMenu
        Me.mnuNewFD = New System.Windows.Forms.MenuItem
        Me.MenuItem1 = New System.Windows.Forms.MenuItem
        Me.mnuFDDetails = New UltimateMenus.KunalMenuItem
        Me.mnuFamilyDetails = New UltimateMenus.KunalMenuItem
        Me.mnuNomineeDetails = New UltimateMenus.KunalMenuItem
        Me.mnuJointHolders = New UltimateMenus.KunalMenuItem
        Me.mnuTransactions = New UltimateMenus.KunalMenuItem
        Me.Label32 = New System.Windows.Forms.Label
        Me.btnClose = New BankControls.NewButton
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
        Me.lblMessage = New System.Windows.Forms.Label
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.cmbDepositType = New System.Windows.Forms.ComboBox
        Me.Label39 = New System.Windows.Forms.Label
        Me.txtSearch = New BankControls.TextControl
        Me.Label1 = New System.Windows.Forms.Label
        Me.cmbType = New System.Windows.Forms.ComboBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.btnAddFD = New BankControls.NewButton
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.NewButton1)
        Me.GroupBox1.Controls.Add(Me.btnReceiptDetails)
        Me.GroupBox1.Controls.Add(Me.btnNominees)
        Me.GroupBox1.Controls.Add(Me.btnFamilyDetails)
        Me.GroupBox1.Controls.Add(Me.btnJointHolders)
        Me.GroupBox1.Controls.Add(Me.btnFDDetails)
        Me.GroupBox1.Controls.Add(Me.btnTransactions)
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.GroupBox1.Location = New System.Drawing.Point(8, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(200, 616)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        '
        'NewButton1
        '
        Me.NewButton1.BackColor = System.Drawing.Color.FromArgb(CType(CType(176, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.NewButton1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.NewButton1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.NewButton1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NewButton1.ForeColor = System.Drawing.Color.Black
        Me.NewButton1.GotFocusColour = System.Drawing.Color.FromArgb(CType(CType(123, Byte), Integer), CType(CType(202, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.NewButton1.Image = CType(resources.GetObject("NewButton1.Image"), System.Drawing.Image)
        Me.NewButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.NewButton1.Location = New System.Drawing.Point(16, 400)
        Me.NewButton1.LostFocusColour = System.Drawing.Color.FromArgb(CType(CType(176, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.NewButton1.Name = "NewButton1"
        Me.NewButton1.Size = New System.Drawing.Size(168, 40)
        Me.NewButton1.TabIndex = 13
        Me.NewButton1.Text = "Payments"
        Me.NewButton1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.NewButton1.UseVisualStyleBackColor = False
        '
        'btnReceiptDetails
        '
        Me.btnReceiptDetails.BackColor = System.Drawing.Color.FromArgb(CType(CType(176, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.btnReceiptDetails.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnReceiptDetails.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnReceiptDetails.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReceiptDetails.ForeColor = System.Drawing.Color.Black
        Me.btnReceiptDetails.GotFocusColour = System.Drawing.Color.FromArgb(CType(CType(123, Byte), Integer), CType(CType(202, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnReceiptDetails.Image = CType(resources.GetObject("btnReceiptDetails.Image"), System.Drawing.Image)
        Me.btnReceiptDetails.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnReceiptDetails.Location = New System.Drawing.Point(16, 360)
        Me.btnReceiptDetails.LostFocusColour = System.Drawing.Color.FromArgb(CType(CType(176, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.btnReceiptDetails.Name = "btnReceiptDetails"
        Me.btnReceiptDetails.Size = New System.Drawing.Size(168, 40)
        Me.btnReceiptDetails.TabIndex = 12
        Me.btnReceiptDetails.Text = "Receipt Details"
        Me.btnReceiptDetails.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnReceiptDetails.UseVisualStyleBackColor = False
        Me.btnReceiptDetails.Visible = False
        '
        'btnNominees
        '
        Me.btnNominees.BackColor = System.Drawing.Color.FromArgb(CType(CType(176, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.btnNominees.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnNominees.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnNominees.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNominees.ForeColor = System.Drawing.Color.Black
        Me.btnNominees.GotFocusColour = System.Drawing.Color.FromArgb(CType(CType(123, Byte), Integer), CType(CType(202, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnNominees.Image = CType(resources.GetObject("btnNominees.Image"), System.Drawing.Image)
        Me.btnNominees.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnNominees.Location = New System.Drawing.Point(16, 280)
        Me.btnNominees.LostFocusColour = System.Drawing.Color.FromArgb(CType(CType(176, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.btnNominees.Name = "btnNominees"
        Me.btnNominees.Size = New System.Drawing.Size(168, 40)
        Me.btnNominees.TabIndex = 10
        Me.btnNominees.Text = "Nominee Details"
        Me.btnNominees.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnNominees.UseVisualStyleBackColor = False
        '
        'btnFamilyDetails
        '
        Me.btnFamilyDetails.BackColor = System.Drawing.Color.FromArgb(CType(CType(176, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.btnFamilyDetails.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnFamilyDetails.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnFamilyDetails.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFamilyDetails.ForeColor = System.Drawing.Color.Black
        Me.btnFamilyDetails.GotFocusColour = System.Drawing.Color.FromArgb(CType(CType(123, Byte), Integer), CType(CType(202, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnFamilyDetails.Image = CType(resources.GetObject("btnFamilyDetails.Image"), System.Drawing.Image)
        Me.btnFamilyDetails.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnFamilyDetails.Location = New System.Drawing.Point(16, 240)
        Me.btnFamilyDetails.LostFocusColour = System.Drawing.Color.FromArgb(CType(CType(176, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.btnFamilyDetails.Name = "btnFamilyDetails"
        Me.btnFamilyDetails.Size = New System.Drawing.Size(168, 40)
        Me.btnFamilyDetails.TabIndex = 9
        Me.btnFamilyDetails.Text = "Family Details"
        Me.btnFamilyDetails.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnFamilyDetails.UseVisualStyleBackColor = False
        '
        'btnJointHolders
        '
        Me.btnJointHolders.BackColor = System.Drawing.Color.FromArgb(CType(CType(176, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.btnJointHolders.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnJointHolders.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnJointHolders.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnJointHolders.ForeColor = System.Drawing.Color.Black
        Me.btnJointHolders.GotFocusColour = System.Drawing.Color.FromArgb(CType(CType(123, Byte), Integer), CType(CType(202, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnJointHolders.Image = CType(resources.GetObject("btnJointHolders.Image"), System.Drawing.Image)
        Me.btnJointHolders.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnJointHolders.Location = New System.Drawing.Point(16, 320)
        Me.btnJointHolders.LostFocusColour = System.Drawing.Color.FromArgb(CType(CType(176, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.btnJointHolders.Name = "btnJointHolders"
        Me.btnJointHolders.Size = New System.Drawing.Size(168, 40)
        Me.btnJointHolders.TabIndex = 11
        Me.btnJointHolders.Text = "Joint Holders"
        Me.btnJointHolders.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnJointHolders.UseVisualStyleBackColor = False
        '
        'btnFDDetails
        '
        Me.btnFDDetails.BackColor = System.Drawing.Color.FromArgb(CType(CType(176, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.btnFDDetails.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnFDDetails.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnFDDetails.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFDDetails.ForeColor = System.Drawing.Color.Black
        Me.btnFDDetails.GotFocusColour = System.Drawing.Color.FromArgb(CType(CType(123, Byte), Integer), CType(CType(202, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnFDDetails.Image = CType(resources.GetObject("btnFDDetails.Image"), System.Drawing.Image)
        Me.btnFDDetails.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnFDDetails.Location = New System.Drawing.Point(16, 200)
        Me.btnFDDetails.LostFocusColour = System.Drawing.Color.FromArgb(CType(CType(176, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.btnFDDetails.Name = "btnFDDetails"
        Me.btnFDDetails.Size = New System.Drawing.Size(168, 40)
        Me.btnFDDetails.TabIndex = 8
        Me.btnFDDetails.Text = "Deposit Details"
        Me.btnFDDetails.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnFDDetails.UseVisualStyleBackColor = False
        '
        'btnTransactions
        '
        Me.btnTransactions.BackColor = System.Drawing.Color.FromArgb(CType(CType(176, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.btnTransactions.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnTransactions.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnTransactions.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTransactions.ForeColor = System.Drawing.Color.Black
        Me.btnTransactions.GotFocusColour = System.Drawing.Color.FromArgb(CType(CType(123, Byte), Integer), CType(CType(202, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnTransactions.Image = CType(resources.GetObject("btnTransactions.Image"), System.Drawing.Image)
        Me.btnTransactions.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnTransactions.Location = New System.Drawing.Point(16, 440)
        Me.btnTransactions.LostFocusColour = System.Drawing.Color.FromArgb(CType(CType(176, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.btnTransactions.Name = "btnTransactions"
        Me.btnTransactions.Size = New System.Drawing.Size(168, 40)
        Me.btnTransactions.TabIndex = 14
        Me.btnTransactions.Text = "Transactions"
        Me.btnTransactions.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnTransactions.UseVisualStyleBackColor = False
        '
        'ContextMenu1
        '
        Me.ContextMenu1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuNewFD, Me.MenuItem1, Me.mnuFDDetails, Me.mnuFamilyDetails, Me.mnuNomineeDetails, Me.mnuJointHolders, Me.mnuTransactions})
        '
        'mnuNewFD
        '
        Me.mnuNewFD.Index = 0
        Me.mnuNewFD.Text = "New FD"
        '
        'MenuItem1
        '
        Me.MenuItem1.Index = 1
        Me.MenuItem1.Text = "-"
        '
        'mnuFDDetails
        '
        Me.mnuFDDetails.CheckedImageIndex = 0
        Me.mnuFDDetails.CheckedMenuItemBackColor = System.Drawing.SystemColors.Control
        Me.mnuFDDetails.CheckedMenuItemBorderColor = System.Drawing.SystemColors.Control
        Me.mnuFDDetails.CheckedMenuItemDisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(197, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(184, Byte), Integer))
        Me.mnuFDDetails.CheckedMenuItemIconShadowColor = System.Drawing.Color.Gray
        Me.mnuFDDetails.CheckedMenuItemStyle = UltimateMenus.KunalMenuItem.CheckedMenuStyles.CheckedItemDefault
        Me.mnuFDDetails.CheckedMenuItemTickMarkColor = System.Drawing.SystemColors.Control
        Me.mnuFDDetails.FillMenuBarItem = False
        Me.mnuFDDetails.HighLightForeColor = System.Drawing.SystemColors.HighlightText
        Me.mnuFDDetails.HighLightScheme = UltimateMenus.KunalMenuItem.HighLightColorDrawStyle.DefaultScheme
        Me.mnuFDDetails.HiliteGradientColor1 = System.Drawing.Color.WhiteSmoke
        Me.mnuFDDetails.HiliteGradientColor2 = System.Drawing.Color.CornflowerBlue
        Me.mnuFDDetails.HiLiteGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.mnuFDDetails.IconShadowColor = System.Drawing.Color.Gray
        Me.mnuFDDetails.ImageIndex = 0
        Me.mnuFDDetails.Index = 2
        Me.mnuFDDetails.MakeCheckedMenuItemIconTransparent = False
        Me.mnuFDDetails.MakeTransparentIcon = False
        Me.mnuFDDetails.MenuBarItemBorderColor = System.Drawing.Color.Black
        Me.mnuFDDetails.MenuBarItemFillColor = System.Drawing.SystemColors.Menu
        Me.mnuFDDetails.MenuBarItemFillingStyle = UltimateMenus.KunalMenuItem.MenuBarFillStyles.FillColor
        Me.mnuFDDetails.MenuBarItemGradientColor1 = System.Drawing.SystemColors.Menu
        Me.mnuFDDetails.MenuBarItemGradientColor2 = System.Drawing.SystemColors.Menu
        Me.mnuFDDetails.MenuBarItemGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.mnuFDDetails.OwnerDraw = True
        Me.mnuFDDetails.PreDefinedHiLiteColors = UltimateMenus.KunalMenuItem.PreDefinedHighLightColors.Khaki
        Me.mnuFDDetails.PreDefinedHiLiteGradientColors = UltimateMenus.KunalMenuItem.PreDefinedGrHighLightColors.BrownWhite
        Me.mnuFDDetails.PreDefinedSideBarGradientColour = UltimateMenus.KunalMenuItem.PreDefinedSideBarGradientColors.ShineyBlueYellow
        Me.mnuFDDetails.ShowBorderAroundMenuBar = False
        Me.mnuFDDetails.ShowHiliteOverSideBar = False
        Me.mnuFDDetails.ShowShadowUnderMenuBar = True
        Me.mnuFDDetails.SideBarGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.mnuFDDetails.SideBarStyle = UltimateMenus.KunalMenuItem.SideBarDrawStyle.DefaultGradient
        Me.mnuFDDetails.Text = "FD Details"
        '
        'mnuFamilyDetails
        '
        Me.mnuFamilyDetails.CheckedImageIndex = 0
        Me.mnuFamilyDetails.CheckedMenuItemBackColor = System.Drawing.SystemColors.Control
        Me.mnuFamilyDetails.CheckedMenuItemBorderColor = System.Drawing.SystemColors.Control
        Me.mnuFamilyDetails.CheckedMenuItemDisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(197, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(184, Byte), Integer))
        Me.mnuFamilyDetails.CheckedMenuItemIconShadowColor = System.Drawing.Color.Gray
        Me.mnuFamilyDetails.CheckedMenuItemStyle = UltimateMenus.KunalMenuItem.CheckedMenuStyles.CheckedItemDefault
        Me.mnuFamilyDetails.CheckedMenuItemTickMarkColor = System.Drawing.SystemColors.Control
        Me.mnuFamilyDetails.FillMenuBarItem = False
        Me.mnuFamilyDetails.HighLightForeColor = System.Drawing.SystemColors.HighlightText
        Me.mnuFamilyDetails.HighLightScheme = UltimateMenus.KunalMenuItem.HighLightColorDrawStyle.DefaultScheme
        Me.mnuFamilyDetails.HiliteGradientColor1 = System.Drawing.Color.WhiteSmoke
        Me.mnuFamilyDetails.HiliteGradientColor2 = System.Drawing.Color.CornflowerBlue
        Me.mnuFamilyDetails.HiLiteGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.mnuFamilyDetails.IconShadowColor = System.Drawing.Color.Gray
        Me.mnuFamilyDetails.ImageIndex = 0
        Me.mnuFamilyDetails.Index = 3
        Me.mnuFamilyDetails.MakeCheckedMenuItemIconTransparent = False
        Me.mnuFamilyDetails.MakeTransparentIcon = False
        Me.mnuFamilyDetails.MenuBarItemBorderColor = System.Drawing.Color.Black
        Me.mnuFamilyDetails.MenuBarItemFillColor = System.Drawing.SystemColors.Menu
        Me.mnuFamilyDetails.MenuBarItemFillingStyle = UltimateMenus.KunalMenuItem.MenuBarFillStyles.FillColor
        Me.mnuFamilyDetails.MenuBarItemGradientColor1 = System.Drawing.SystemColors.Menu
        Me.mnuFamilyDetails.MenuBarItemGradientColor2 = System.Drawing.SystemColors.Menu
        Me.mnuFamilyDetails.MenuBarItemGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.mnuFamilyDetails.OwnerDraw = True
        Me.mnuFamilyDetails.PreDefinedHiLiteColors = UltimateMenus.KunalMenuItem.PreDefinedHighLightColors.Khaki
        Me.mnuFamilyDetails.PreDefinedHiLiteGradientColors = UltimateMenus.KunalMenuItem.PreDefinedGrHighLightColors.BrownWhite
        Me.mnuFamilyDetails.PreDefinedSideBarGradientColour = UltimateMenus.KunalMenuItem.PreDefinedSideBarGradientColors.ShineyBlueYellow
        Me.mnuFamilyDetails.ShowBorderAroundMenuBar = False
        Me.mnuFamilyDetails.ShowHiliteOverSideBar = False
        Me.mnuFamilyDetails.ShowShadowUnderMenuBar = True
        Me.mnuFamilyDetails.SideBarGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.mnuFamilyDetails.SideBarStyle = UltimateMenus.KunalMenuItem.SideBarDrawStyle.DefaultGradient
        Me.mnuFamilyDetails.Text = "Family Details"
        '
        'mnuNomineeDetails
        '
        Me.mnuNomineeDetails.CheckedImageIndex = 0
        Me.mnuNomineeDetails.CheckedMenuItemBackColor = System.Drawing.SystemColors.Control
        Me.mnuNomineeDetails.CheckedMenuItemBorderColor = System.Drawing.SystemColors.Control
        Me.mnuNomineeDetails.CheckedMenuItemDisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(197, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(184, Byte), Integer))
        Me.mnuNomineeDetails.CheckedMenuItemIconShadowColor = System.Drawing.Color.Gray
        Me.mnuNomineeDetails.CheckedMenuItemStyle = UltimateMenus.KunalMenuItem.CheckedMenuStyles.CheckedItemDefault
        Me.mnuNomineeDetails.CheckedMenuItemTickMarkColor = System.Drawing.SystemColors.Control
        Me.mnuNomineeDetails.FillMenuBarItem = False
        Me.mnuNomineeDetails.HighLightForeColor = System.Drawing.SystemColors.HighlightText
        Me.mnuNomineeDetails.HighLightScheme = UltimateMenus.KunalMenuItem.HighLightColorDrawStyle.DefaultScheme
        Me.mnuNomineeDetails.HiliteGradientColor1 = System.Drawing.Color.WhiteSmoke
        Me.mnuNomineeDetails.HiliteGradientColor2 = System.Drawing.Color.CornflowerBlue
        Me.mnuNomineeDetails.HiLiteGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.mnuNomineeDetails.IconShadowColor = System.Drawing.Color.Gray
        Me.mnuNomineeDetails.ImageIndex = 0
        Me.mnuNomineeDetails.Index = 4
        Me.mnuNomineeDetails.MakeCheckedMenuItemIconTransparent = False
        Me.mnuNomineeDetails.MakeTransparentIcon = False
        Me.mnuNomineeDetails.MenuBarItemBorderColor = System.Drawing.Color.Black
        Me.mnuNomineeDetails.MenuBarItemFillColor = System.Drawing.SystemColors.Menu
        Me.mnuNomineeDetails.MenuBarItemFillingStyle = UltimateMenus.KunalMenuItem.MenuBarFillStyles.FillColor
        Me.mnuNomineeDetails.MenuBarItemGradientColor1 = System.Drawing.SystemColors.Menu
        Me.mnuNomineeDetails.MenuBarItemGradientColor2 = System.Drawing.SystemColors.Menu
        Me.mnuNomineeDetails.MenuBarItemGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.mnuNomineeDetails.OwnerDraw = True
        Me.mnuNomineeDetails.PreDefinedHiLiteColors = UltimateMenus.KunalMenuItem.PreDefinedHighLightColors.Khaki
        Me.mnuNomineeDetails.PreDefinedHiLiteGradientColors = UltimateMenus.KunalMenuItem.PreDefinedGrHighLightColors.BrownWhite
        Me.mnuNomineeDetails.PreDefinedSideBarGradientColour = UltimateMenus.KunalMenuItem.PreDefinedSideBarGradientColors.ShineyBlueYellow
        Me.mnuNomineeDetails.ShowBorderAroundMenuBar = False
        Me.mnuNomineeDetails.ShowHiliteOverSideBar = False
        Me.mnuNomineeDetails.ShowShadowUnderMenuBar = True
        Me.mnuNomineeDetails.SideBarGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.mnuNomineeDetails.SideBarStyle = UltimateMenus.KunalMenuItem.SideBarDrawStyle.DefaultGradient
        Me.mnuNomineeDetails.Text = "Nominee Details"
        '
        'mnuJointHolders
        '
        Me.mnuJointHolders.CheckedImageIndex = 0
        Me.mnuJointHolders.CheckedMenuItemBackColor = System.Drawing.SystemColors.Control
        Me.mnuJointHolders.CheckedMenuItemBorderColor = System.Drawing.SystemColors.Control
        Me.mnuJointHolders.CheckedMenuItemDisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(197, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(184, Byte), Integer))
        Me.mnuJointHolders.CheckedMenuItemIconShadowColor = System.Drawing.Color.Gray
        Me.mnuJointHolders.CheckedMenuItemStyle = UltimateMenus.KunalMenuItem.CheckedMenuStyles.CheckedItemDefault
        Me.mnuJointHolders.CheckedMenuItemTickMarkColor = System.Drawing.SystemColors.Control
        Me.mnuJointHolders.FillMenuBarItem = False
        Me.mnuJointHolders.HighLightForeColor = System.Drawing.SystemColors.HighlightText
        Me.mnuJointHolders.HighLightScheme = UltimateMenus.KunalMenuItem.HighLightColorDrawStyle.DefaultScheme
        Me.mnuJointHolders.HiliteGradientColor1 = System.Drawing.Color.WhiteSmoke
        Me.mnuJointHolders.HiliteGradientColor2 = System.Drawing.Color.CornflowerBlue
        Me.mnuJointHolders.HiLiteGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.mnuJointHolders.IconShadowColor = System.Drawing.Color.Gray
        Me.mnuJointHolders.ImageIndex = 0
        Me.mnuJointHolders.Index = 5
        Me.mnuJointHolders.MakeCheckedMenuItemIconTransparent = False
        Me.mnuJointHolders.MakeTransparentIcon = False
        Me.mnuJointHolders.MenuBarItemBorderColor = System.Drawing.Color.Black
        Me.mnuJointHolders.MenuBarItemFillColor = System.Drawing.SystemColors.Menu
        Me.mnuJointHolders.MenuBarItemFillingStyle = UltimateMenus.KunalMenuItem.MenuBarFillStyles.FillColor
        Me.mnuJointHolders.MenuBarItemGradientColor1 = System.Drawing.SystemColors.Menu
        Me.mnuJointHolders.MenuBarItemGradientColor2 = System.Drawing.SystemColors.Menu
        Me.mnuJointHolders.MenuBarItemGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.mnuJointHolders.OwnerDraw = True
        Me.mnuJointHolders.PreDefinedHiLiteColors = UltimateMenus.KunalMenuItem.PreDefinedHighLightColors.Khaki
        Me.mnuJointHolders.PreDefinedHiLiteGradientColors = UltimateMenus.KunalMenuItem.PreDefinedGrHighLightColors.BrownWhite
        Me.mnuJointHolders.PreDefinedSideBarGradientColour = UltimateMenus.KunalMenuItem.PreDefinedSideBarGradientColors.ShineyBlueYellow
        Me.mnuJointHolders.ShowBorderAroundMenuBar = False
        Me.mnuJointHolders.ShowHiliteOverSideBar = False
        Me.mnuJointHolders.ShowShadowUnderMenuBar = True
        Me.mnuJointHolders.SideBarGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.mnuJointHolders.SideBarStyle = UltimateMenus.KunalMenuItem.SideBarDrawStyle.DefaultGradient
        Me.mnuJointHolders.Text = "Joint Holders"
        '
        'mnuTransactions
        '
        Me.mnuTransactions.CheckedImageIndex = 0
        Me.mnuTransactions.CheckedMenuItemBackColor = System.Drawing.SystemColors.Control
        Me.mnuTransactions.CheckedMenuItemBorderColor = System.Drawing.SystemColors.Control
        Me.mnuTransactions.CheckedMenuItemDisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(197, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(184, Byte), Integer))
        Me.mnuTransactions.CheckedMenuItemIconShadowColor = System.Drawing.Color.Gray
        Me.mnuTransactions.CheckedMenuItemStyle = UltimateMenus.KunalMenuItem.CheckedMenuStyles.CheckedItemDefault
        Me.mnuTransactions.CheckedMenuItemTickMarkColor = System.Drawing.SystemColors.Control
        Me.mnuTransactions.FillMenuBarItem = False
        Me.mnuTransactions.HighLightForeColor = System.Drawing.SystemColors.HighlightText
        Me.mnuTransactions.HighLightScheme = UltimateMenus.KunalMenuItem.HighLightColorDrawStyle.DefaultScheme
        Me.mnuTransactions.HiliteGradientColor1 = System.Drawing.Color.WhiteSmoke
        Me.mnuTransactions.HiliteGradientColor2 = System.Drawing.Color.CornflowerBlue
        Me.mnuTransactions.HiLiteGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.mnuTransactions.IconShadowColor = System.Drawing.Color.Gray
        Me.mnuTransactions.ImageIndex = 0
        Me.mnuTransactions.Index = 6
        Me.mnuTransactions.MakeCheckedMenuItemIconTransparent = False
        Me.mnuTransactions.MakeTransparentIcon = False
        Me.mnuTransactions.MenuBarItemBorderColor = System.Drawing.Color.Black
        Me.mnuTransactions.MenuBarItemFillColor = System.Drawing.SystemColors.Menu
        Me.mnuTransactions.MenuBarItemFillingStyle = UltimateMenus.KunalMenuItem.MenuBarFillStyles.FillColor
        Me.mnuTransactions.MenuBarItemGradientColor1 = System.Drawing.SystemColors.Menu
        Me.mnuTransactions.MenuBarItemGradientColor2 = System.Drawing.SystemColors.Menu
        Me.mnuTransactions.MenuBarItemGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.mnuTransactions.OwnerDraw = True
        Me.mnuTransactions.PreDefinedHiLiteColors = UltimateMenus.KunalMenuItem.PreDefinedHighLightColors.Khaki
        Me.mnuTransactions.PreDefinedHiLiteGradientColors = UltimateMenus.KunalMenuItem.PreDefinedGrHighLightColors.BrownWhite
        Me.mnuTransactions.PreDefinedSideBarGradientColour = UltimateMenus.KunalMenuItem.PreDefinedSideBarGradientColors.ShineyBlueYellow
        Me.mnuTransactions.ShowBorderAroundMenuBar = False
        Me.mnuTransactions.ShowHiliteOverSideBar = False
        Me.mnuTransactions.ShowShadowUnderMenuBar = True
        Me.mnuTransactions.SideBarGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.mnuTransactions.SideBarStyle = UltimateMenus.KunalMenuItem.SideBarDrawStyle.DefaultGradient
        Me.mnuTransactions.Text = "Transactions"
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.BackColor = System.Drawing.Color.FromArgb(CType(CType(176, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.Label32.Font = New System.Drawing.Font("Georgia", 14.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label32.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label32.Location = New System.Drawing.Point(72, 16)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(125, 23)
        Me.Label32.TabIndex = 11
        Me.Label32.Text = " Deposits List"
        Me.Label32.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
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
        Me.btnClose.Location = New System.Drawing.Point(664, 560)
        Me.btnClose.LostFocusColour = System.Drawing.Color.FromArgb(CType(CType(176, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(104, 40)
        Me.btnClose.TabIndex = 5
        Me.btnClose.Text = "&Close"
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
        Me.lvFDs.Location = New System.Drawing.Point(24, 136)
        Me.lvFDs.MultiSelect = False
        Me.lvFDs.Name = "lvFDs"
        Me.lvFDs.Size = New System.Drawing.Size(760, 408)
        Me.lvFDs.Sorting = System.Windows.Forms.SortOrder.Ascending
        Me.lvFDs.TabIndex = 4
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
        'lblMessage
        '
        Me.lblMessage.AutoSize = True
        Me.lblMessage.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMessage.Location = New System.Drawing.Point(24, 112)
        Me.lblMessage.Name = "lblMessage"
        Me.lblMessage.Size = New System.Drawing.Size(253, 16)
        Me.lblMessage.TabIndex = 15
        Me.lblMessage.Text = "There are 0 records found for your search"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.cmbType)
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.Controls.Add(Me.txtSearch)
        Me.GroupBox3.Controls.Add(Me.Label39)
        Me.GroupBox3.Controls.Add(Me.cmbDepositType)
        Me.GroupBox3.Location = New System.Drawing.Point(16, 56)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(768, 48)
        Me.GroupBox3.TabIndex = 1
        Me.GroupBox3.TabStop = False
        '
        'cmbDepositType
        '
        Me.cmbDepositType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbDepositType.DropDownWidth = 120
        Me.cmbDepositType.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbDepositType.Items.AddRange(New Object() {"FD", "ENNVY", "SCC"})
        Me.cmbDepositType.Location = New System.Drawing.Point(120, 14)
        Me.cmbDepositType.Name = "cmbDepositType"
        Me.cmbDepositType.Size = New System.Drawing.Size(88, 24)
        Me.cmbDepositType.TabIndex = 0
        '
        'Label39
        '
        Me.Label39.AutoSize = True
        Me.Label39.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label39.ForeColor = System.Drawing.Color.Black
        Me.Label39.Location = New System.Drawing.Point(16, 17)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(106, 16)
        Me.Label39.TabIndex = 139
        Me.Label39.Text = "Deposit Type: "
        '
        'txtSearch
        '
        Me.txtSearch.AlphaNumeric = True
        Me.txtSearch.BlankSpace = True
        Me.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSearch.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearch.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtSearch.Location = New System.Drawing.Point(544, 16)
        Me.txtSearch.LostFocusColour = System.Drawing.SystemColors.Window
        Me.txtSearch.Mandatory = False
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(200, 23)
        Me.txtSearch.SpecialChar = True
        Me.txtSearch.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(440, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 16)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Search Text: "
        '
        'cmbType
        '
        Me.cmbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbType.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbType.Items.AddRange(New Object() {"Name", "FD No", "Amount", "ROI", "Years", "Months", "Days", "Status", "Remarks"})
        Me.cmbType.Location = New System.Drawing.Point(296, 14)
        Me.cmbType.Name = "cmbType"
        Me.cmbType.Size = New System.Drawing.Size(136, 24)
        Me.cmbType.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(208, 17)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(86, 16)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Search By: "
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(176, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(16, 16)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(48, 40)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 12
        Me.PictureBox1.TabStop = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.PictureBox1)
        Me.GroupBox2.Controls.Add(Me.GroupBox3)
        Me.GroupBox2.Controls.Add(Me.lblMessage)
        Me.GroupBox2.Controls.Add(Me.lvFDs)
        Me.GroupBox2.Controls.Add(Me.btnAddFD)
        Me.GroupBox2.Controls.Add(Me.btnClose)
        Me.GroupBox2.Controls.Add(Me.Label32)
        Me.GroupBox2.Location = New System.Drawing.Point(216, 0)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(792, 616)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
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
        Me.btnAddFD.Location = New System.Drawing.Point(24, 560)
        Me.btnAddFD.LostFocusColour = System.Drawing.Color.FromArgb(CType(CType(176, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.btnAddFD.Name = "btnAddFD"
        Me.btnAddFD.Size = New System.Drawing.Size(88, 40)
        Me.btnAddFD.TabIndex = 6
        Me.btnAddFD.Text = "&New FD"
        Me.btnAddFD.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'frmFDList
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(176, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.CancelButton = Me.btnClose
        Me.ClientSize = New System.Drawing.Size(1018, 631)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "frmFDList"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Deposit List"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region "Code to Create Instance Object"

    Private Shared m_FormDefInstance As frmFDList
    Private Shared m_InitializingDefInstance As Boolean

    Public Shared Property DefInstance() As frmFDList
        Get
            If m_FormDefInstance Is Nothing OrElse m_FormDefInstance.IsDisposed Then
                m_InitializingDefInstance = True
                m_FormDefInstance = New frmFDList
                m_InitializingDefInstance = False
            End If
            DefInstance = m_FormDefInstance
        End Get
        Set(ByVal Value As frmFDList)
            m_FormDefInstance = Value
        End Set
    End Property

#End Region


    Function fnLoadFDAccounts()
        Dim intCounter As Integer = 0
        Dim lvItem As New ListViewItem
        If Not dvFDAccounts Is Nothing Then
            dvFDAccounts.RowFilter = strFilter
            lvFDs.Items.Clear()
            lblMessage.Text = "There are " & dvFDAccounts.Count & " records found for your search"
            While intCounter < dvFDAccounts.Count
                lvItem = lvFDs.Items.Add(dvFDAccounts.Item(intCounter).Item("FDNo"))
                lvItem.UseItemStyleForSubItems = False
                lvItem.SubItems.Add(dvFDAccounts.Item(intCounter).Item("Name"))
                ' lvItem.SubItems.Add(dvFDAccounts.Item(intCounter).Item("MemberNo"))
                lvItem.SubItems.Add(Format(dvFDAccounts.Item(intCounter).Item("FDDate"), "dd-MM-yyyy"))
                lvItem.SubItems.Add(dvFDAccounts.Item(intCounter).Item("FDAmount"))
                If Convert.ToString(dvFDAccounts.Item(intCounter).Item("FDROI")) = "" Then
                    lvItem.SubItems.Add("")
                Else
                    lvItem.SubItems.Add(dvFDAccounts.Item(intCounter).Item("FDROI"))
                End If
                lvItem.SubItems.Add(dvFDAccounts.Item(intCounter).Item("Years"))
                lvItem.SubItems.Add(dvFDAccounts.Item(intCounter).Item("Months"))
                lvItem.SubItems.Add(dvFDAccounts.Item(intCounter).Item("Days"))
                lvItem.SubItems.Add(Format(dvFDAccounts.Item(intCounter).Item("MatDate"), "dd-MM-yyyy"))
                lvItem.SubItems.Add(dvFDAccounts.Item(intCounter).Item("IntAmount"))
                lvItem.SubItems.Add(dvFDAccounts.Item(intCounter).Item("MatAmount"))

                lvItem.SubItems.Add(dvFDAccounts.Item(intCounter).Item("Status"))
                lvItem.SubItems.Add(dvFDAccounts.Item(intCounter).Item("Remarks"))
                'Matured fd accounts displayed as red color
                If (Convert.ToDateTime(dvFDAccounts.Item(intCounter).Item("MatDate"))) <= Date.Today And dvFDAccounts.Item(intCounter).Item("Status") = "A" Then
                    lvItem.ForeColor = Color.Red
                End If
                intCounter += 1
            End While
        End If
    End Function


    Private Sub frmFDList_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cmbType.SelectedIndex = -1
        cmbDepositType.SelectedIndex = -1
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub


    Private Sub txtSearch_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSearch.TextChanged
        If cmbType.SelectedItem = "Name" Then
            strFilter = "Name like '" & txtSearch.Text & "%'"
            fnLoadFDAccounts()
        ElseIf cmbType.SelectedItem = "FD No" Then
            strFilter = "FDNo like '" & txtSearch.Text & "%'"
            fnLoadFDAccounts()
        ElseIf cmbType.SelectedItem = "Amount" Then
            strFilter = "FDAmount = '" & Val(txtSearch.Text) & "'"
            fnLoadFDAccounts()
        ElseIf cmbType.SelectedItem = "ROI" Then
            strFilter = "FDROI = '" & Val(txtSearch.Text) & "'"
            fnLoadFDAccounts()
        ElseIf cmbType.SelectedItem = "Years" Then
            strFilter = "Years = '" & Val(txtSearch.Text) & "'"
            fnLoadFDAccounts()
        ElseIf cmbType.SelectedItem = "Months" Then
            strFilter = "Months = '" & Val(txtSearch.Text) & "'"
            fnLoadFDAccounts()
        ElseIf cmbType.SelectedItem = "Days" Then
            strFilter = "Days = '" & Val(txtSearch.Text) & "'"
            fnLoadFDAccounts()
        ElseIf cmbType.SelectedItem = "Status" Then
            strFilter = "Status like '" & txtSearch.Text & "%'"
            fnLoadFDAccounts()
        ElseIf cmbType.SelectedItem = "Remarks" Then
            strFilter = "Remarks like '" & txtSearch.Text & "%'"
            fnLoadFDAccounts()
        End If
    End Sub


    Private Sub txtSearch_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtSearch.KeyDown
        If e.KeyData = Keys.Down Then
            lvFDs.Focus()
        End If
    End Sub


    Private Sub btnFamilyDetails_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFamilyDetails.Click, mnuFamilyDetails.Click
        If lvFDs.SelectedItems.Count > 0 Then
            Dim objFamilyDetails As New frmFamily_Detail
            objFamilyDetails.txtAccountNo.Text = lvFDs.SelectedItems(0).SubItems(0).Text
            objFamilyDetails.txtName.Text = lvFDs.SelectedItems(0).SubItems(1).Text
            objFamilyDetails.chrType = "F"
            objFamilyDetails.ShowDialog(Me)
            objFamilyDetails.Dispose()
        Else
            MsgBox("Select account number from the list ", MsgBoxStyle.Information, "Deposit Module")
            lvFDs.Focus()
        End If
    End Sub


    Private Sub btnNominees_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNominees.Click, mnuNomineeDetails.Click
        If lvFDs.SelectedItems.Count > 0 Then
            Dim objNominees As New frmNominees
            objNominees.txtAccountNo.Text = lvFDs.SelectedItems(0).SubItems(0).Text
            objNominees.txtName.Text = lvFDs.SelectedItems(0).SubItems(1).Text
            objNominees.chrType = "N"
            objNominees.ShowDialog(Me)
            objNominees.Dispose()
        Else
            MsgBox("Select account number from the list ", MsgBoxStyle.Information, "Deposit Module")
            lvFDs.Focus()
        End If
    End Sub

    Private Sub btnJointHolders_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnJointHolders.Click, mnuJointHolders.Click
        Dim dtRow As DataRow
        If lvFDs.SelectedItems.Count > 0 Then
            dtRow = dvFDAccounts.Table.Select("FDNo='" & lvFDs.SelectedItems(0).SubItems(0).Text & "'").GetValue(0)
            If dtRow.Item("AccType") = "J" Then
                Dim objJointHolders As New frmNominees
                objJointHolders.txtAccountNo.Text = lvFDs.SelectedItems(0).SubItems(0).Text
                objJointHolders.txtName.Text = lvFDs.SelectedItems(0).SubItems(1).Text
                objJointHolders.chrType = "J"
                objJointHolders.ShowDialog(Me)
                objJointHolders = Nothing
            Else
                MsgBox("Account is not a joint account", MsgBoxStyle.Information, "Deposit Module")
                lvFDs.Focus()
            End If
        Else
            MsgBox("Select account number from the list ", MsgBoxStyle.Information, "Deposit Module")
            lvFDs.Focus()
        End If

    End Sub

    Private Sub btnAddFD_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddFD.Click
        Dim objfrmFDCreation As frmFDCreation
        objfrmFDCreation = frmFDCreation.DefInstance
        objfrmFDCreation.BringToFront()
        objfrmFDCreation.MdiParent = Me.MdiParent
        objfrmFDCreation.Show()
        objfrmFDCreation = Nothing
    End Sub

    Private Sub btnTransactions_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTransactions.Click, mnuTransactions.Click
        If lvFDs.SelectedItems.Count > 0 Then
            Dim objfrmAccTrans As New frmAccountTransactions
            objfrmAccTrans.txtAccountNo.Text = lvFDs.SelectedItems(0).SubItems(0).Text
            objfrmAccTrans.txtName.Text = lvFDs.SelectedItems(0).SubItems(1).Text
            objfrmAccTrans.ShowDialog(Me)
            objfrmAccTrans = Nothing
        Else
            MsgBox("Select account number from the list ", MsgBoxStyle.Information, "Deposit Module")
            lvFDs.Focus()
        End If
    End Sub

    Private Sub btnFDDetails_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFDDetails.Click, mnuFDDetails.Click, lvFDs.DoubleClick
        If lvFDs.SelectedItems.Count > 0 Then
            Dim strROI As String = lvFDs.SelectedItems(0).SubItems(4).Text.ToString
            If strROI <> "" Then
                Dim objfrmFDCreation As frmFDCreation
                objfrmFDCreation = frmFDCreation.DefInstance
                objfrmFDCreation.strFDNo = lvFDs.SelectedItems(0).SubItems(0).Text
                objfrmFDCreation.MdiParent = Me.MdiParent
                Select Case cmbDepositType.SelectedItem
                    Case "FD"
                        objfrmFDCreation.cmbDepositType.SelectedItem = "FD"
                    Case "ENNVY"
                        objfrmFDCreation.cmbDepositType.SelectedItem = "ENNVY"
                    Case "SCC"
                        objfrmFDCreation.cmbDepositType.SelectedItem = "SCC"
                End Select
                objfrmFDCreation.BringToFront()
                objfrmFDCreation.Show()
                objfrmFDCreation = Nothing
            ElseIf strROI = "" Then
                Dim objfrmDoubleThriable As frmDoubleThriable
                objfrmDoubleThriable = objfrmDoubleThriable.DefInstance
                objfrmDoubleThriable.strFDNo = lvFDs.SelectedItems(0).SubItems(0).Text
                objfrmDoubleThriable.MdiParent = Me.MdiParent
                Select Case cmbDepositType.SelectedItem
                    Case "FD"
                        objfrmDoubleThriable.cmbDepositType.SelectedItem = "FD"
                    Case "SCC"
                        objfrmDoubleThriable.cmbDepositType.SelectedItem = "SCC"
                End Select
                objfrmDoubleThriable.BringToFront()
                objfrmDoubleThriable.Show()
                objfrmDoubleThriable = Nothing
            End If
        Else
            MsgBox("Select account number from the list ", MsgBoxStyle.Information, "Deposit Module")
            lvFDs.Focus()
        End If
    End Sub

    Private Sub lvFDs_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles lvFDs.KeyDown
        If e.KeyData = Keys.Enter Then
            btnFDDetails_Click(sender, e)
        End If
    End Sub

    Private Sub NewButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewButton1.Click
        'If lvFDs.SelectedItems.Count > 0 Then
        '    Dim ObjfrmFDPayments As New frmFDPayments
        '    ObjfrmFDPayments.txtFDAccountNo.Text = lvFDs.SelectedItems(0).SubItems(0).Text
        '    ObjfrmFDPayments.ShowDialog(Me)
        'Else
        '    MsgBox("Select Account Number From the List ", MsgBoxStyle.Information, "Deposit Module")
        '    lvFDs.Focus()
        'End If
        If objFDAccount.fnCheckFDAccount(lvFDs.SelectedItems(0).SubItems(0).Text) Then
            If objFDAccount.FDDetailstbl.Rows(0).Item("Status") = "A" Then
                Dim ObjfrmFDPayments As New frmFDPayments
                ObjfrmFDPayments.txtFDAccountNo.Text = lvFDs.SelectedItems(0).SubItems(0).Text
                Select Case cmbDepositType.SelectedItem
                    Case "FD"
                        ObjfrmFDPayments.cmbDepositType.SelectedItem = "FD"
                    Case "ENNVY"
                        ObjfrmFDPayments.cmbDepositType.SelectedItem = "ENNVY"
                    Case "SCC"
                        ObjfrmFDPayments.cmbDepositType.SelectedItem = "SCC"
                End Select
                'ObjfrmFDPayments.cmbSchemeType.SelectedValue = cmbSchemeType.SelectedValue
                ObjfrmFDPayments.ShowDialog(Me)
            Else
                MsgBox("Account is already closed", MsgBoxStyle.Information)
            End If
        Else
            MsgBox("Account number dosent exist", MsgBoxStyle.Information)
        End If
    End Sub

    Private Sub cmbDepositType_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbDepositType.SelectedIndexChanged

        Select Case cmbDepositType.SelectedItem

            Case "FD"
                lvFDs.Items.Clear()
                If objFDAccount.fnGetFDList("FD") Then
                    dvFDAccounts = New DataView(objFDAccount.FDTable, strFilter, "FDNo", DataViewRowState.OriginalRows)
                    fnLoadFDAccounts()
                End If
            Case "ENNVY"
                lvFDs.Items.Clear()
                If objFDAccount.fnGetFDList("ENNVY") Then
                    dvFDAccounts = New DataView(objFDAccount.FDTable, strFilter, "FDNo", DataViewRowState.OriginalRows)
                    fnLoadFDAccounts()
                End If
            Case "SCC"
                lvFDs.Items.Clear()
                If objFDAccount.fnGetFDList("SCC") Then
                    dvFDAccounts = New DataView(objFDAccount.FDTable, strFilter, "FDNo", DataViewRowState.OriginalRows)
                    fnLoadFDAccounts()
                End If
        End Select

    End Sub

    Function fnLoadFDAccounts(ByVal dvFDAccounts)
        Dim intCounter As Integer = 0
        Dim lvItem As New ListViewItem
        If Not dvFDAccounts Is Nothing Then
            dvFDAccounts.RowFilter = strFilter
            lvFDs.Items.Clear()
            lblMessage.Text = "There are " & dvFDAccounts.Count & " records found for your search"
            While intCounter < dvFDAccounts.Count
                lvItem = lvFDs.Items.Add(dvFDAccounts.Item(intCounter).Item("FDNo"))
                lvItem.UseItemStyleForSubItems = False
                lvItem.SubItems.Add(dvFDAccounts.Item(intCounter).Item("Name"))
                ' lvItem.SubItems.Add(dvFDAccounts.Item(intCounter).Item("MemberNo"))
                lvItem.SubItems.Add(Format(dvFDAccounts.Item(intCounter).Item("FDDate"), "dd-MM-yyyy"))
                lvItem.SubItems.Add(dvFDAccounts.Item(intCounter).Item("FDAmount"))
                If Convert.ToString(dvFDAccounts.Item(intCounter).Item("FDROI")) = "" Then
                    lvItem.SubItems.Add("")
                Else
                    lvItem.SubItems.Add(dvFDAccounts.Item(intCounter).Item("FDROI"))
                End If
                lvItem.SubItems.Add(dvFDAccounts.Item(intCounter).Item("Years"))
                lvItem.SubItems.Add(dvFDAccounts.Item(intCounter).Item("Months"))
                lvItem.SubItems.Add(dvFDAccounts.Item(intCounter).Item("Days"))
                lvItem.SubItems.Add(Format(dvFDAccounts.Item(intCounter).Item("MatDate"), "dd-MM-yyyy"))
                lvItem.SubItems.Add(dvFDAccounts.Item(intCounter).Item("IntAmount"))
                lvItem.SubItems.Add(dvFDAccounts.Item(intCounter).Item("MatAmount"))

                lvItem.SubItems.Add(dvFDAccounts.Item(intCounter).Item("Status"))
                lvItem.SubItems.Add(dvFDAccounts.Item(intCounter).Item("Remarks"))
                'Matured fd accounts displayed as red color
                If (Convert.ToDateTime(dvFDAccounts.Item(intCounter).Item("MatDate"))) <= Date.Today And dvFDAccounts.Item(intCounter).Item("Status") = "A" Then
                    lvItem.ForeColor = Color.Red
                End If
                intCounter += 1
            End While
        End If
    End Function

End Class
