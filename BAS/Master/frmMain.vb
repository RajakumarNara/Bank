Public Class frmMain
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
    Friend WithEvents StatusBar1 As System.Windows.Forms.StatusBar
    Friend WithEvents MainMenu1 As System.Windows.Forms.MainMenu
    Friend WithEvents MenuItem2 As UltimateMenus.KunalMenuItem
    Friend WithEvents MenuItem4 As UltimateMenus.KunalMenuItem
    Friend WithEvents MenuItem5 As UltimateMenus.KunalMenuItem
    'Friend WithEvents NewButton4 As BankControls.NewButton
    Friend WithEvents BalloonToolTip1 As CustomTooltip.BalloonToolTip
    Friend WithEvents MenuItem6 As UltimateMenus.KunalMenuItem
    Friend WithEvents MenuItem7 As UltimateMenus.KunalMenuItem
    Friend WithEvents MenuItem8 As UltimateMenus.KunalMenuItem
    Friend WithEvents MenuItem9 As UltimateMenus.KunalMenuItem
    Friend WithEvents MenuItem10 As UltimateMenus.KunalMenuItem
    Friend WithEvents MenuItem14 As UltimateMenus.KunalMenuItem
    Friend WithEvents MenuItem15 As UltimateMenus.KunalMenuItem
    Friend WithEvents MenuItem29 As UltimateMenus.KunalMenuItem
    Friend WithEvents MenuItem30 As UltimateMenus.KunalMenuItem
    Friend WithEvents MenuItem31 As UltimateMenus.KunalMenuItem
    Friend WithEvents MenuItem32 As UltimateMenus.KunalMenuItem
    Friend WithEvents MenuItem33 As UltimateMenus.KunalMenuItem
    Friend WithEvents MenuItem34 As UltimateMenus.KunalMenuItem
    Friend WithEvents MenuItem35 As UltimateMenus.KunalMenuItem
    Friend WithEvents MenuItem36 As UltimateMenus.KunalMenuItem
    Friend WithEvents MenuItem37 As UltimateMenus.KunalMenuItem
    Friend WithEvents MenuItem38 As UltimateMenus.KunalMenuItem
    Friend WithEvents MenuItem41 As UltimateMenus.KunalMenuItem
    Friend WithEvents MenuItem43 As UltimateMenus.KunalMenuItem
    Friend WithEvents MenuItem44 As UltimateMenus.KunalMenuItem
    Friend WithEvents MenuItem45 As UltimateMenus.KunalMenuItem
    Friend WithEvents MenuItem46 As UltimateMenus.KunalMenuItem
    Friend WithEvents MenuItem47 As UltimateMenus.KunalMenuItem
    Friend WithEvents MenuItem50 As UltimateMenus.KunalMenuItem
    Friend WithEvents MenuItem51 As UltimateMenus.KunalMenuItem
    Friend WithEvents MenuItem53 As UltimateMenus.KunalMenuItem
    Friend WithEvents MenuItem57 As UltimateMenus.KunalMenuItem
    Friend WithEvents MenuItem59 As UltimateMenus.KunalMenuItem
    Friend WithEvents MenuItem60 As UltimateMenus.KunalMenuItem
    Friend WithEvents MenuItem61 As UltimateMenus.KunalMenuItem
    Friend WithEvents MenuItem62 As UltimateMenus.KunalMenuItem
    Friend WithEvents MenuItem63 As UltimateMenus.KunalMenuItem
    'Friend WithEvents btnShares As BankControls.NewButton
    'Friend WithEvents btnAccounts As BankControls.NewButton
    'Friend WithEvents btnMembers As BankControls.NewButton
    'Friend WithEvents btnSavings As BankControls.NewButton
    'Friend WithEvents btnDeposits As BankControls.NewButton
    'Friend WithEvents btnLoans As BankControls.NewButton
    Friend WithEvents MenuItem66 As UltimateMenus.KunalMenuItem
    Friend WithEvents MenuItem67 As UltimateMenus.KunalMenuItem
    Friend WithEvents MenuItem68 As UltimateMenus.KunalMenuItem
    Friend WithEvents MenuItem69 As UltimateMenus.KunalMenuItem
    Friend WithEvents MenuItem70 As UltimateMenus.KunalMenuItem
    Friend WithEvents MenuItem71 As UltimateMenus.KunalMenuItem
    Friend WithEvents MenuItem72 As UltimateMenus.KunalMenuItem
    Friend WithEvents MenuItem73 As UltimateMenus.KunalMenuItem
    Friend WithEvents MenuItem74 As UltimateMenus.KunalMenuItem
    Friend WithEvents MenuItem75 As UltimateMenus.KunalMenuItem
    Friend WithEvents MenuItem76 As UltimateMenus.KunalMenuItem
    Friend WithEvents MenuItem78 As UltimateMenus.KunalMenuItem
    'Friend WithEvents btnCalculator As BankControls.NewButton
    Friend WithEvents MenuItem58 As UltimateMenus.KunalMenuItem
    Friend WithEvents MenuItem79 As UltimateMenus.KunalMenuItem
    Friend WithEvents MenuItem80 As UltimateMenus.KunalMenuItem
    Friend WithEvents MenuItem81 As UltimateMenus.KunalMenuItem
    Friend WithEvents MenuItem82 As UltimateMenus.KunalMenuItem
    Friend WithEvents MenuItem56 As UltimateMenus.KunalMenuItem
    Friend WithEvents MenuItem84 As UltimateMenus.KunalMenuItem
    Friend WithEvents MenuItem85 As UltimateMenus.KunalMenuItem
    Friend WithEvents MenuItem86 As UltimateMenus.KunalMenuItem
    Friend WithEvents MenuItem87 As UltimateMenus.KunalMenuItem
    Friend WithEvents MenuItem88 As UltimateMenus.KunalMenuItem
    Friend WithEvents MenuItem89 As UltimateMenus.KunalMenuItem
    Friend WithEvents MenuItem90 As UltimateMenus.KunalMenuItem
    Friend WithEvents Status As System.Windows.Forms.StatusBarPanel
    Friend WithEvents DateTime As System.Windows.Forms.StatusBarPanel
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents MenuItem91 As UltimateMenus.KunalMenuItem
    Friend WithEvents MenuItem92 As UltimateMenus.KunalMenuItem
    'Friend WithEvents btnLogOff As BankControls.NewButton
    'Friend WithEvents btnExit As BankControls.NewButton
    Friend WithEvents MenuItem93 As UltimateMenus.KunalMenuItem
    Friend WithEvents MenuItem94 As UltimateMenus.KunalMenuItem
    Friend WithEvents MenuItem95 As UltimateMenus.KunalMenuItem
    Friend WithEvents smnuDefaulters As UltimateMenus.KunalMenuItem
    Friend WithEvents MenuItem99 As UltimateMenus.KunalMenuItem
    Friend WithEvents smnuRDClosure As UltimateMenus.KunalMenuItem
    Friend WithEvents mnuViewShares As UltimateMenus.KunalMenuItem
    Friend WithEvents smnuViewShares As UltimateMenus.KunalMenuItem
    Friend WithEvents smnuDividend As UltimateMenus.KunalMenuItem
    Friend WithEvents smnuTransferShares As UltimateMenus.KunalMenuItem
    'Friend WithEvents NewButton1 As BankControls.NewButton
    'Friend WithEvents NewButton2 As BankControls.NewButton
    'Friend WithEvents btnReports As BankControls.NewButton
    Friend WithEvents smnuDuplicateFD As UltimateMenus.KunalMenuItem
    Friend WithEvents smnuFDPremature As UltimateMenus.KunalMenuItem
    Friend WithEvents timerLoad As System.Windows.Forms.Timer
    Friend WithEvents MenuItem16 As UltimateMenus.KunalMenuItem
    Friend WithEvents pnlQuickLaunch As System.Windows.Forms.Panel
    Friend WithEvents btnShares As BankControls.NewButton
    Friend WithEvents btnMembers As BankControls.NewButton
    Friend WithEvents btnSavings As BankControls.NewButton
    Friend WithEvents btnDeposits As BankControls.NewButton
    Friend WithEvents btnLoans As BankControls.NewButton
    Friend WithEvents btnAccounts As BankControls.NewButton
    Friend WithEvents btnReports As BankControls.NewButton
    Friend WithEvents NewButton4 As BankControls.NewButton
    Friend WithEvents btnCalculator As BankControls.NewButton
    Friend WithEvents btnLogOff As BankControls.NewButton
    Friend WithEvents btnExit As BankControls.NewButton
    Friend WithEvents qqq As System.Windows.Forms.StatusBarPanel
    Friend WithEvents MenuItem1 As UltimateMenus.KunalMenuItem
    Friend WithEvents MenuItem11 As UltimateMenus.KunalMenuItem
    Friend WithEvents smnuCloseMembership As UltimateMenus.KunalMenuItem
    Friend WithEvents MenuItem27 As UltimateMenus.KunalMenuItem
    Friend WithEvents MenuItem39 As UltimateMenus.KunalMenuItem
    Friend WithEvents MenuItem40 As UltimateMenus.KunalMenuItem
    Friend WithEvents MenuItem42 As UltimateMenus.KunalMenuItem
    Friend WithEvents MenuItem48 As UltimateMenus.KunalMenuItem
    Friend WithEvents MenuItem52 As UltimateMenus.KunalMenuItem
    Friend WithEvents MenuItem103 As UltimateMenus.KunalMenuItem
    Friend WithEvents tmrSnooze As System.Windows.Forms.Timer
    Friend WithEvents MenuItem64 As UltimateMenus.KunalMenuItem
    Friend WithEvents MenuItem65 As UltimateMenus.KunalMenuItem
    Friend WithEvents MenuItem83 As UltimateMenus.KunalMenuItem
    Friend WithEvents MenuItem98 As UltimateMenus.KunalMenuItem
    Friend WithEvents MenuItem106 As UltimateMenus.KunalMenuItem
    Friend WithEvents MenuItem107 As UltimateMenus.KunalMenuItem
    Friend WithEvents MenuItem108 As UltimateMenus.KunalMenuItem
    Friend WithEvents MenuItem109 As UltimateMenus.KunalMenuItem
    Friend WithEvents MenuItem110 As UltimateMenus.KunalMenuItem
    Friend WithEvents MenuItem100 As UltimateMenus.KunalMenuItem
    Friend WithEvents MenuItem54 As UltimateMenus.KunalMenuItem
    Friend WithEvents MenuItem3 As UltimateMenus.KunalMenuItem
    Friend WithEvents MenuItem12 As UltimateMenus.KunalMenuItem
    Friend WithEvents MenuItem13 As UltimateMenus.KunalMenuItem
    Friend WithEvents MenuItem17 As UltimateMenus.KunalMenuItem
    Friend WithEvents MenuItem18 As UltimateMenus.KunalMenuItem
    Friend WithEvents MenuItem19 As UltimateMenus.KunalMenuItem
    Friend WithEvents MenuItem20 As UltimateMenus.KunalMenuItem
    Friend WithEvents MenuItem21 As UltimateMenus.KunalMenuItem
    Friend WithEvents MenuItem22 As UltimateMenus.KunalMenuItem
    Friend WithEvents MenuItem23 As UltimateMenus.KunalMenuItem
    Friend WithEvents MenuItem24 As UltimateMenus.KunalMenuItem
    Friend WithEvents MenuItem25 As UltimateMenus.KunalMenuItem
    Friend WithEvents MenuItem26 As UltimateMenus.KunalMenuItem
    Friend WithEvents MenuItem28 As UltimateMenus.KunalMenuItem
    Friend WithEvents MenuItem55 As UltimateMenus.KunalMenuItem
    Friend WithEvents MenuItem101 As UltimateMenus.KunalMenuItem
    Friend WithEvents MenuItem102 As UltimateMenus.KunalMenuItem
    Friend WithEvents MenuItem104 As UltimateMenus.KunalMenuItem
    Friend WithEvents MenuItem105 As UltimateMenus.KunalMenuItem
    Friend WithEvents MainMenu2 As System.Windows.Forms.MainMenu
    Friend WithEvents MenuItem96 As UltimateMenus.KunalMenuItem
    Friend WithEvents MenuItem112 As UltimateMenus.KunalMenuItem
    Friend WithEvents MenuItem111 As UltimateMenus.KunalMenuItem
    Friend WithEvents MenuItem113 As UltimateMenus.KunalMenuItem
    Friend WithEvents MenuItem114 As UltimateMenus.KunalMenuItem
    Friend WithEvents MenuItem115 As UltimateMenus.KunalMenuItem
    Friend WithEvents MenuItem116 As UltimateMenus.KunalMenuItem
    Friend WithEvents MenuItem117 As UltimateMenus.KunalMenuItem
    Friend WithEvents MenuItem118 As UltimateMenus.KunalMenuItem
    Friend WithEvents MenuItem119 As UltimateMenus.KunalMenuItem
    Friend WithEvents MenuItem120 As UltimateMenus.KunalMenuItem
    Friend WithEvents MenuItem121 As UltimateMenus.KunalMenuItem
    Friend WithEvents MenuItem122 As UltimateMenus.KunalMenuItem
    Friend WithEvents MenuItem123 As UltimateMenus.KunalMenuItem
    Friend WithEvents MenuItem124 As UltimateMenus.KunalMenuItem
    Friend WithEvents MenuItem125 As UltimateMenus.KunalMenuItem
    Friend WithEvents MenuItem126 As UltimateMenus.KunalMenuItem
    Friend WithEvents MenuItem127 As UltimateMenus.KunalMenuItem
    Friend WithEvents MenuItem128 As UltimateMenus.KunalMenuItem
    Friend WithEvents MenuItem129 As UltimateMenus.KunalMenuItem
    Friend WithEvents MenuItem130 As UltimateMenus.KunalMenuItem
    Friend WithEvents MenuItem131 As UltimateMenus.KunalMenuItem
    Friend WithEvents MenuItem132 As UltimateMenus.KunalMenuItem
    Friend WithEvents MenuItem133 As UltimateMenus.KunalMenuItem
    Friend WithEvents MenuItem134 As UltimateMenus.KunalMenuItem
    Friend WithEvents MenuItem135 As UltimateMenus.KunalMenuItem
    Friend WithEvents ComapanyName As System.Windows.Forms.StatusBarPanel
    Friend WithEvents MenuItem77 As UltimateMenus.KunalMenuItem
    Friend WithEvents MenuItem97 As UltimateMenus.KunalMenuItem
    Friend WithEvents MenuItem136 As UltimateMenus.KunalMenuItem
    Friend WithEvents MenuItem138 As UltimateMenus.KunalMenuItem
    Friend WithEvents MenuItem139 As UltimateMenus.KunalMenuItem
    Friend WithEvents MenuItem140 As UltimateMenus.KunalMenuItem
    Friend WithEvents MenuItem141 As UltimateMenus.KunalMenuItem
    Friend WithEvents MenuItem142 As UltimateMenus.KunalMenuItem
    Friend WithEvents MenuItem143 As UltimateMenus.KunalMenuItem
    Friend WithEvents MenuItem144 As UltimateMenus.KunalMenuItem
    Friend WithEvents MenuItem145 As UltimateMenus.KunalMenuItem
    Friend WithEvents MenuItem146 As UltimateMenus.KunalMenuItem
    Friend WithEvents MenuItem147 As UltimateMenus.KunalMenuItem
    Friend WithEvents MenuItem148 As UltimateMenus.KunalMenuItem
    Friend WithEvents MenuItem149 As UltimateMenus.KunalMenuItem
    Friend WithEvents MenuItem150 As UltimateMenus.KunalMenuItem
    Friend WithEvents MenuItem151 As UltimateMenus.KunalMenuItem
    Friend WithEvents MenuItem152 As UltimateMenus.KunalMenuItem
    Friend WithEvents MenuItem153 As UltimateMenus.KunalMenuItem
    Friend WithEvents MenuItem154 As UltimateMenus.KunalMenuItem
    Friend WithEvents MenuItem155 As UltimateMenus.KunalMenuItem
    Friend WithEvents MenuItem156 As UltimateMenus.KunalMenuItem
    Friend WithEvents MenuItem157 As UltimateMenus.KunalMenuItem
    Friend WithEvents MenuItem158 As UltimateMenus.KunalMenuItem
    Friend WithEvents MenuItem159 As UltimateMenus.KunalMenuItem
    Friend WithEvents MenuItem160 As UltimateMenus.KunalMenuItem
    Friend WithEvents MenuItem161 As UltimateMenus.KunalMenuItem
    Friend WithEvents MenuItem162 As UltimateMenus.KunalMenuItem
    Friend WithEvents MenuItem171 As UltimateMenus.KunalMenuItem
    Friend WithEvents MenuItem172 As UltimateMenus.KunalMenuItem
    Friend WithEvents MenuItem173 As UltimateMenus.KunalMenuItem
    Friend WithEvents MenuItem174 As UltimateMenus.KunalMenuItem
    Friend WithEvents MenuItem175 As UltimateMenus.KunalMenuItem
    Friend WithEvents MenuItem176 As UltimateMenus.KunalMenuItem
    Friend WithEvents MenuItem177 As UltimateMenus.KunalMenuItem
    Friend WithEvents MenuItem163 As UltimateMenus.KunalMenuItem
    Friend WithEvents mnuSMTL As UltimateMenus.KunalMenuItem
    Friend WithEvents MenuItem164 As UltimateMenus.KunalMenuItem
    Friend WithEvents MenuItem165 As UltimateMenus.KunalMenuItem
    Friend WithEvents MenuItem166 As UltimateMenus.KunalMenuItem
    Friend WithEvents MenuItem49 As UltimateMenus.KunalMenuItem
    Friend WithEvents MenuItem167 As UltimateMenus.KunalMenuItem
    Friend WithEvents MenuItem168 As UltimateMenus.KunalMenuItem
    Friend WithEvents MenuItem169 As UltimateMenus.KunalMenuItem
    Friend WithEvents MenuItem170 As UltimateMenus.KunalMenuItem
    Friend WithEvents Role As System.Windows.Forms.StatusBarPanel
    Friend WithEvents MenuItem178 As UltimateMenus.KunalMenuItem
    Friend WithEvents MenuItem179 As UltimateMenus.KunalMenuItem
    Friend WithEvents MenuItem180 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem181 As UltimateMenus.KunalMenuItem
    Friend WithEvents MenuItem182 As UltimateMenus.KunalMenuItem
    Friend WithEvents MenuItem183 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem137 As UltimateMenus.KunalMenuItem
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.StatusBar1 = New System.Windows.Forms.StatusBar()
        Me.Status = New System.Windows.Forms.StatusBarPanel()
        Me.Role = New System.Windows.Forms.StatusBarPanel()
        Me.ComapanyName = New System.Windows.Forms.StatusBarPanel()
        Me.DateTime = New System.Windows.Forms.StatusBarPanel()
        Me.MainMenu1 = New System.Windows.Forms.MainMenu(Me.components)
        Me.MenuItem5 = New UltimateMenus.KunalMenuItem()
        Me.MenuItem47 = New UltimateMenus.KunalMenuItem()
        Me.MenuItem73 = New UltimateMenus.KunalMenuItem()
        Me.MenuItem72 = New UltimateMenus.KunalMenuItem()
        Me.MenuItem71 = New UltimateMenus.KunalMenuItem()
        Me.MenuItem70 = New UltimateMenus.KunalMenuItem()
        Me.MenuItem69 = New UltimateMenus.KunalMenuItem()
        Me.MenuItem68 = New UltimateMenus.KunalMenuItem()
        Me.MenuItem67 = New UltimateMenus.KunalMenuItem()
        Me.MenuItem66 = New UltimateMenus.KunalMenuItem()
        Me.MenuItem91 = New UltimateMenus.KunalMenuItem()
        Me.MenuItem92 = New UltimateMenus.KunalMenuItem()
        Me.MenuItem81 = New UltimateMenus.KunalMenuItem()
        Me.MenuItem9 = New UltimateMenus.KunalMenuItem()
        Me.MenuItem10 = New UltimateMenus.KunalMenuItem()
        Me.MenuItem82 = New UltimateMenus.KunalMenuItem()
        Me.MenuItem63 = New UltimateMenus.KunalMenuItem()
        Me.MenuItem16 = New UltimateMenus.KunalMenuItem()
        Me.MenuItem64 = New UltimateMenus.KunalMenuItem()
        Me.MenuItem65 = New UltimateMenus.KunalMenuItem()
        Me.MenuItem62 = New UltimateMenus.KunalMenuItem()
        Me.MenuItem83 = New UltimateMenus.KunalMenuItem()
        Me.MenuItem112 = New UltimateMenus.KunalMenuItem()
        Me.MenuItem111 = New UltimateMenus.KunalMenuItem()
        Me.MenuItem96 = New UltimateMenus.KunalMenuItem()
        Me.MenuItem178 = New UltimateMenus.KunalMenuItem()
        Me.MenuItem113 = New UltimateMenus.KunalMenuItem()
        Me.MenuItem98 = New UltimateMenus.KunalMenuItem()
        Me.MenuItem106 = New UltimateMenus.KunalMenuItem()
        Me.MenuItem105 = New UltimateMenus.KunalMenuItem()
        Me.MenuItem107 = New UltimateMenus.KunalMenuItem()
        Me.MenuItem108 = New UltimateMenus.KunalMenuItem()
        Me.MenuItem109 = New UltimateMenus.KunalMenuItem()
        Me.MenuItem110 = New UltimateMenus.KunalMenuItem()
        Me.MenuItem100 = New UltimateMenus.KunalMenuItem()
        Me.MenuItem49 = New UltimateMenus.KunalMenuItem()
        Me.MenuItem84 = New UltimateMenus.KunalMenuItem()
        Me.MenuItem85 = New UltimateMenus.KunalMenuItem()
        Me.MenuItem86 = New UltimateMenus.KunalMenuItem()
        Me.MenuItem141 = New UltimateMenus.KunalMenuItem()
        Me.MenuItem142 = New UltimateMenus.KunalMenuItem()
        Me.MenuItem1 = New UltimateMenus.KunalMenuItem()
        Me.MenuItem11 = New UltimateMenus.KunalMenuItem()
        Me.smnuCloseMembership = New UltimateMenus.KunalMenuItem()
        Me.MenuItem27 = New UltimateMenus.KunalMenuItem()
        Me.MenuItem137 = New UltimateMenus.KunalMenuItem()
        Me.MenuItem170 = New UltimateMenus.KunalMenuItem()
        Me.MenuItem181 = New UltimateMenus.KunalMenuItem()
        Me.MenuItem182 = New UltimateMenus.KunalMenuItem()
        Me.MenuItem2 = New UltimateMenus.KunalMenuItem()
        Me.MenuItem14 = New UltimateMenus.KunalMenuItem()
        Me.MenuItem15 = New UltimateMenus.KunalMenuItem()
        Me.smnuTransferShares = New UltimateMenus.KunalMenuItem()
        Me.smnuDividend = New UltimateMenus.KunalMenuItem()
        Me.mnuViewShares = New UltimateMenus.KunalMenuItem()
        Me.smnuViewShares = New UltimateMenus.KunalMenuItem()
        Me.MenuItem54 = New UltimateMenus.KunalMenuItem()
        Me.MenuItem3 = New UltimateMenus.KunalMenuItem()
        Me.MenuItem13 = New UltimateMenus.KunalMenuItem()
        Me.MenuItem17 = New UltimateMenus.KunalMenuItem()
        Me.MenuItem18 = New UltimateMenus.KunalMenuItem()
        Me.MenuItem114 = New UltimateMenus.KunalMenuItem()
        Me.MenuItem19 = New UltimateMenus.KunalMenuItem()
        Me.MenuItem55 = New UltimateMenus.KunalMenuItem()
        Me.MenuItem20 = New UltimateMenus.KunalMenuItem()
        Me.MenuItem21 = New UltimateMenus.KunalMenuItem()
        Me.MenuItem22 = New UltimateMenus.KunalMenuItem()
        Me.MenuItem23 = New UltimateMenus.KunalMenuItem()
        Me.MenuItem24 = New UltimateMenus.KunalMenuItem()
        Me.MenuItem25 = New UltimateMenus.KunalMenuItem()
        Me.MenuItem26 = New UltimateMenus.KunalMenuItem()
        Me.MenuItem28 = New UltimateMenus.KunalMenuItem()
        Me.MenuItem101 = New UltimateMenus.KunalMenuItem()
        Me.MenuItem12 = New UltimateMenus.KunalMenuItem()
        Me.MenuItem102 = New UltimateMenus.KunalMenuItem()
        Me.MenuItem104 = New UltimateMenus.KunalMenuItem()
        Me.MenuItem116 = New UltimateMenus.KunalMenuItem()
        Me.MenuItem132 = New UltimateMenus.KunalMenuItem()
        Me.MenuItem133 = New UltimateMenus.KunalMenuItem()
        Me.MenuItem134 = New UltimateMenus.KunalMenuItem()
        Me.MenuItem135 = New UltimateMenus.KunalMenuItem()
        Me.MenuItem125 = New UltimateMenus.KunalMenuItem()
        Me.MenuItem127 = New UltimateMenus.KunalMenuItem()
        Me.MenuItem4 = New UltimateMenus.KunalMenuItem()
        Me.MenuItem29 = New UltimateMenus.KunalMenuItem()
        Me.MenuItem32 = New UltimateMenus.KunalMenuItem()
        Me.MenuItem33 = New UltimateMenus.KunalMenuItem()
        Me.MenuItem34 = New UltimateMenus.KunalMenuItem()
        Me.MenuItem35 = New UltimateMenus.KunalMenuItem()
        Me.MenuItem36 = New UltimateMenus.KunalMenuItem()
        Me.MenuItem74 = New UltimateMenus.KunalMenuItem()
        Me.MenuItem37 = New UltimateMenus.KunalMenuItem()
        Me.smnuDuplicateFD = New UltimateMenus.KunalMenuItem()
        Me.smnuFDPremature = New UltimateMenus.KunalMenuItem()
        Me.MenuItem143 = New UltimateMenus.KunalMenuItem()
        Me.MenuItem167 = New UltimateMenus.KunalMenuItem()
        Me.MenuItem168 = New UltimateMenus.KunalMenuItem()
        Me.MenuItem30 = New UltimateMenus.KunalMenuItem()
        Me.MenuItem38 = New UltimateMenus.KunalMenuItem()
        Me.MenuItem118 = New UltimateMenus.KunalMenuItem()
        Me.MenuItem119 = New UltimateMenus.KunalMenuItem()
        Me.MenuItem41 = New UltimateMenus.KunalMenuItem()
        Me.smnuRDClosure = New UltimateMenus.KunalMenuItem()
        Me.MenuItem43 = New UltimateMenus.KunalMenuItem()
        Me.MenuItem146 = New UltimateMenus.KunalMenuItem()
        Me.MenuItem31 = New UltimateMenus.KunalMenuItem()
        Me.MenuItem44 = New UltimateMenus.KunalMenuItem()
        Me.MenuItem77 = New UltimateMenus.KunalMenuItem()
        Me.MenuItem97 = New UltimateMenus.KunalMenuItem()
        Me.MenuItem136 = New UltimateMenus.KunalMenuItem()
        Me.MenuItem45 = New UltimateMenus.KunalMenuItem()
        Me.MenuItem46 = New UltimateMenus.KunalMenuItem()
        Me.MenuItem147 = New UltimateMenus.KunalMenuItem()
        Me.MenuItem148 = New UltimateMenus.KunalMenuItem()
        Me.MenuItem149 = New UltimateMenus.KunalMenuItem()
        Me.MenuItem180 = New System.Windows.Forms.MenuItem()
        Me.MenuItem6 = New UltimateMenus.KunalMenuItem()
        Me.MenuItem94 = New UltimateMenus.KunalMenuItem()
        Me.MenuItem95 = New UltimateMenus.KunalMenuItem()
        Me.MenuItem122 = New UltimateMenus.KunalMenuItem()
        Me.MenuItem120 = New UltimateMenus.KunalMenuItem()
        Me.MenuItem121 = New UltimateMenus.KunalMenuItem()
        Me.MenuItem123 = New UltimateMenus.KunalMenuItem()
        Me.MenuItem124 = New UltimateMenus.KunalMenuItem()
        Me.MenuItem144 = New UltimateMenus.KunalMenuItem()
        Me.MenuItem99 = New UltimateMenus.KunalMenuItem()
        Me.MenuItem138 = New UltimateMenus.KunalMenuItem()
        Me.MenuItem139 = New UltimateMenus.KunalMenuItem()
        Me.MenuItem145 = New UltimateMenus.KunalMenuItem()
        Me.smnuDefaulters = New UltimateMenus.KunalMenuItem()
        Me.mnuSMTL = New UltimateMenus.KunalMenuItem()
        Me.MenuItem164 = New UltimateMenus.KunalMenuItem()
        Me.MenuItem165 = New UltimateMenus.KunalMenuItem()
        Me.MenuItem166 = New UltimateMenus.KunalMenuItem()
        Me.MenuItem128 = New UltimateMenus.KunalMenuItem()
        Me.MenuItem129 = New UltimateMenus.KunalMenuItem()
        Me.MenuItem130 = New UltimateMenus.KunalMenuItem()
        Me.MenuItem131 = New UltimateMenus.KunalMenuItem()
        Me.MenuItem163 = New UltimateMenus.KunalMenuItem()
        Me.MenuItem7 = New UltimateMenus.KunalMenuItem()
        Me.MenuItem51 = New UltimateMenus.KunalMenuItem()
        Me.MenuItem53 = New UltimateMenus.KunalMenuItem()
        Me.MenuItem50 = New UltimateMenus.KunalMenuItem()
        Me.MenuItem75 = New UltimateMenus.KunalMenuItem()
        Me.MenuItem76 = New UltimateMenus.KunalMenuItem()
        Me.MenuItem78 = New UltimateMenus.KunalMenuItem()
        Me.MenuItem87 = New UltimateMenus.KunalMenuItem()
        Me.MenuItem88 = New UltimateMenus.KunalMenuItem()
        Me.MenuItem89 = New UltimateMenus.KunalMenuItem()
        Me.MenuItem115 = New UltimateMenus.KunalMenuItem()
        Me.MenuItem103 = New UltimateMenus.KunalMenuItem()
        Me.MenuItem140 = New UltimateMenus.KunalMenuItem()
        Me.MenuItem57 = New UltimateMenus.KunalMenuItem()
        Me.MenuItem59 = New UltimateMenus.KunalMenuItem()
        Me.MenuItem60 = New UltimateMenus.KunalMenuItem()
        Me.MenuItem61 = New UltimateMenus.KunalMenuItem()
        Me.MenuItem93 = New UltimateMenus.KunalMenuItem()
        Me.MenuItem52 = New UltimateMenus.KunalMenuItem()
        Me.MenuItem8 = New UltimateMenus.KunalMenuItem()
        Me.MenuItem79 = New UltimateMenus.KunalMenuItem()
        Me.MenuItem80 = New UltimateMenus.KunalMenuItem()
        Me.MenuItem56 = New UltimateMenus.KunalMenuItem()
        Me.MenuItem90 = New UltimateMenus.KunalMenuItem()
        Me.MenuItem58 = New UltimateMenus.KunalMenuItem()
        Me.MenuItem126 = New UltimateMenus.KunalMenuItem()
        Me.MenuItem179 = New UltimateMenus.KunalMenuItem()
        Me.MenuItem39 = New UltimateMenus.KunalMenuItem()
        Me.MenuItem40 = New UltimateMenus.KunalMenuItem()
        Me.MenuItem151 = New UltimateMenus.KunalMenuItem()
        Me.MenuItem152 = New UltimateMenus.KunalMenuItem()
        Me.MenuItem42 = New UltimateMenus.KunalMenuItem()
        Me.MenuItem48 = New UltimateMenus.KunalMenuItem()
        Me.MenuItem158 = New UltimateMenus.KunalMenuItem()
        Me.MenuItem159 = New UltimateMenus.KunalMenuItem()
        Me.MenuItem153 = New UltimateMenus.KunalMenuItem()
        Me.MenuItem160 = New UltimateMenus.KunalMenuItem()
        Me.MenuItem161 = New UltimateMenus.KunalMenuItem()
        Me.MenuItem162 = New UltimateMenus.KunalMenuItem()
        Me.MenuItem154 = New UltimateMenus.KunalMenuItem()
        Me.MenuItem155 = New UltimateMenus.KunalMenuItem()
        Me.MenuItem156 = New UltimateMenus.KunalMenuItem()
        Me.MenuItem157 = New UltimateMenus.KunalMenuItem()
        Me.MenuItem171 = New UltimateMenus.KunalMenuItem()
        Me.MenuItem172 = New UltimateMenus.KunalMenuItem()
        Me.MenuItem173 = New UltimateMenus.KunalMenuItem()
        Me.MenuItem174 = New UltimateMenus.KunalMenuItem()
        Me.MenuItem175 = New UltimateMenus.KunalMenuItem()
        Me.MenuItem176 = New UltimateMenus.KunalMenuItem()
        Me.MenuItem177 = New UltimateMenus.KunalMenuItem()
        Me.MenuItem183 = New System.Windows.Forms.MenuItem()
        Me.MenuItem150 = New UltimateMenus.KunalMenuItem()
        Me.MenuItem169 = New UltimateMenus.KunalMenuItem()
        Me.BalloonToolTip1 = New CustomTooltip.BalloonToolTip()
        Me.pnlQuickLaunch = New System.Windows.Forms.Panel()
        Me.btnLogOff = New BankControls.NewButton()
        Me.btnCalculator = New BankControls.NewButton()
        Me.NewButton4 = New BankControls.NewButton()
        Me.btnReports = New BankControls.NewButton()
        Me.btnAccounts = New BankControls.NewButton()
        Me.btnLoans = New BankControls.NewButton()
        Me.btnDeposits = New BankControls.NewButton()
        Me.btnSavings = New BankControls.NewButton()
        Me.btnShares = New BankControls.NewButton()
        Me.btnMembers = New BankControls.NewButton()
        Me.btnExit = New BankControls.NewButton()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.timerLoad = New System.Windows.Forms.Timer(Me.components)
        Me.tmrSnooze = New System.Windows.Forms.Timer(Me.components)
        Me.MainMenu2 = New System.Windows.Forms.MainMenu(Me.components)
        Me.MenuItem117 = New UltimateMenus.KunalMenuItem()
        CType(Me.Status, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Role, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ComapanyName, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateTime, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlQuickLaunch.SuspendLayout()
        Me.SuspendLayout()
        '
        'StatusBar1
        '
        Me.BalloonToolTip1.SetBalloonText(Me.StatusBar1, Nothing)
        Me.StatusBar1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StatusBar1.Location = New System.Drawing.Point(0, 645)
        Me.StatusBar1.Name = "StatusBar1"
        Me.StatusBar1.Panels.AddRange(New System.Windows.Forms.StatusBarPanel() {Me.Status, Me.Role, Me.ComapanyName, Me.DateTime})
        Me.StatusBar1.ShowPanels = True
        Me.StatusBar1.Size = New System.Drawing.Size(1026, 24)
        Me.StatusBar1.TabIndex = 2
        Me.StatusBar1.Text = "StatusBar1"
        '
        'Status
        '
        Me.Status.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.Status.BorderStyle = System.Windows.Forms.StatusBarPanelBorderStyle.Raised
        Me.Status.Icon = CType(resources.GetObject("Status.Icon"), System.Drawing.Icon)
        Me.Status.Name = "Status"
        Me.Status.Width = 520
        '
        'Role
        '
        Me.Role.Icon = CType(resources.GetObject("Role.Icon"), System.Drawing.Icon)
        Me.Role.MinWidth = 200
        Me.Role.Name = "Role"
        Me.Role.Width = 200
        '
        'ComapanyName
        '
        Me.ComapanyName.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.ComapanyName.BorderStyle = System.Windows.Forms.StatusBarPanelBorderStyle.Raised
        Me.ComapanyName.MinWidth = 50
        Me.ComapanyName.Name = "ComapanyName"
        '
        'DateTime
        '
        Me.DateTime.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.DateTime.Name = "DateTime"
        Me.DateTime.ToolTipText = "System Date and Time"
        Me.DateTime.Width = 180
        '
        'MainMenu1
        '
        Me.MainMenu1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem5, Me.MenuItem82, Me.MenuItem1, Me.MenuItem2, Me.MenuItem54, Me.MenuItem4, Me.MenuItem6, Me.MenuItem128, Me.MenuItem7, Me.MenuItem8, Me.MenuItem39, Me.MenuItem150})
        '
        'MenuItem5
        '
        Me.MenuItem5.CheckedImageIndex = 0
        Me.MenuItem5.CheckedMenuItemBackColor = System.Drawing.SystemColors.Control
        Me.MenuItem5.CheckedMenuItemBorderColor = System.Drawing.SystemColors.Control
        Me.MenuItem5.CheckedMenuItemDisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(197, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(184, Byte), Integer))
        Me.MenuItem5.CheckedMenuItemIconShadowColor = System.Drawing.Color.Gray
        Me.MenuItem5.CheckedMenuItemStyle = UltimateMenus.KunalMenuItem.CheckedMenuStyles.CheckedItemDefault
        Me.MenuItem5.CheckedMenuItemTickMarkColor = System.Drawing.SystemColors.Control
        Me.MenuItem5.FillMenuBarItem = False
        Me.MenuItem5.HighLightForeColor = System.Drawing.SystemColors.HighlightText
        Me.MenuItem5.HighLightScheme = UltimateMenus.KunalMenuItem.HighLightColorDrawStyle.DefaultScheme
        Me.MenuItem5.HiliteGradientColor1 = System.Drawing.Color.WhiteSmoke
        Me.MenuItem5.HiliteGradientColor2 = System.Drawing.Color.CornflowerBlue
        Me.MenuItem5.HiLiteGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.MenuItem5.IconShadowColor = System.Drawing.Color.Gray
        Me.MenuItem5.ImageIndex = 0
        Me.MenuItem5.Index = 0
        Me.MenuItem5.MakeCheckedMenuItemIconTransparent = False
        Me.MenuItem5.MakeTransparentIcon = False
        Me.MenuItem5.MenuBarItemBorderColor = System.Drawing.Color.Black
        Me.MenuItem5.MenuBarItemFillColor = System.Drawing.SystemColors.Menu
        Me.MenuItem5.MenuBarItemFillingStyle = UltimateMenus.KunalMenuItem.MenuBarFillStyles.FillColor
        Me.MenuItem5.MenuBarItemGradientColor1 = System.Drawing.SystemColors.Menu
        Me.MenuItem5.MenuBarItemGradientColor2 = System.Drawing.SystemColors.Menu
        Me.MenuItem5.MenuBarItemGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.MenuItem5.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem47, Me.MenuItem91, Me.MenuItem92, Me.MenuItem81, Me.MenuItem9, Me.MenuItem10})
        Me.MenuItem5.OwnerDraw = True
        Me.MenuItem5.PreDefinedHiLiteColors = UltimateMenus.KunalMenuItem.PreDefinedHighLightColors.Khaki
        Me.MenuItem5.PreDefinedHiLiteGradientColors = UltimateMenus.KunalMenuItem.PreDefinedGrHighLightColors.BrownWhite
        Me.MenuItem5.PreDefinedSideBarGradientColour = UltimateMenus.KunalMenuItem.PreDefinedSideBarGradientColors.ShineyBlueYellow
        Me.MenuItem5.ShowBorderAroundMenuBar = False
        Me.MenuItem5.ShowHiliteOverSideBar = False
        Me.MenuItem5.ShowShadowUnderMenuBar = True
        Me.MenuItem5.SideBarGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.MenuItem5.SideBarStyle = UltimateMenus.KunalMenuItem.SideBarDrawStyle.DefaultGradient
        Me.MenuItem5.Text = "&User"
        '
        'MenuItem47
        '
        Me.MenuItem47.CheckedImageIndex = 0
        Me.MenuItem47.CheckedMenuItemBackColor = System.Drawing.SystemColors.Control
        Me.MenuItem47.CheckedMenuItemBorderColor = System.Drawing.SystemColors.Control
        Me.MenuItem47.CheckedMenuItemDisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(197, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(184, Byte), Integer))
        Me.MenuItem47.CheckedMenuItemIconShadowColor = System.Drawing.Color.Gray
        Me.MenuItem47.CheckedMenuItemStyle = UltimateMenus.KunalMenuItem.CheckedMenuStyles.CheckedItemDefault
        Me.MenuItem47.CheckedMenuItemTickMarkColor = System.Drawing.SystemColors.Control
        Me.MenuItem47.FillMenuBarItem = False
        Me.MenuItem47.HighLightForeColor = System.Drawing.SystemColors.HighlightText
        Me.MenuItem47.HighLightScheme = UltimateMenus.KunalMenuItem.HighLightColorDrawStyle.DefaultScheme
        Me.MenuItem47.HiliteGradientColor1 = System.Drawing.Color.WhiteSmoke
        Me.MenuItem47.HiliteGradientColor2 = System.Drawing.Color.CornflowerBlue
        Me.MenuItem47.HiLiteGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.MenuItem47.IconShadowColor = System.Drawing.Color.Gray
        Me.MenuItem47.ImageIndex = 0
        Me.MenuItem47.Index = 0
        Me.MenuItem47.MakeCheckedMenuItemIconTransparent = False
        Me.MenuItem47.MakeTransparentIcon = False
        Me.MenuItem47.MenuBarItemBorderColor = System.Drawing.Color.Black
        Me.MenuItem47.MenuBarItemFillColor = System.Drawing.SystemColors.Menu
        Me.MenuItem47.MenuBarItemFillingStyle = UltimateMenus.KunalMenuItem.MenuBarFillStyles.FillColor
        Me.MenuItem47.MenuBarItemGradientColor1 = System.Drawing.SystemColors.Menu
        Me.MenuItem47.MenuBarItemGradientColor2 = System.Drawing.SystemColors.Menu
        Me.MenuItem47.MenuBarItemGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.MenuItem47.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem73, Me.MenuItem72, Me.MenuItem71, Me.MenuItem70, Me.MenuItem69, Me.MenuItem68, Me.MenuItem67, Me.MenuItem66})
        Me.MenuItem47.OwnerDraw = True
        Me.MenuItem47.PreDefinedHiLiteColors = UltimateMenus.KunalMenuItem.PreDefinedHighLightColors.Khaki
        Me.MenuItem47.PreDefinedHiLiteGradientColors = UltimateMenus.KunalMenuItem.PreDefinedGrHighLightColors.BrownWhite
        Me.MenuItem47.PreDefinedSideBarGradientColour = UltimateMenus.KunalMenuItem.PreDefinedSideBarGradientColors.ShineyBlueYellow
        Me.MenuItem47.ShowBorderAroundMenuBar = False
        Me.MenuItem47.ShowHiliteOverSideBar = False
        Me.MenuItem47.ShowShadowUnderMenuBar = True
        Me.MenuItem47.SideBarGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.MenuItem47.SideBarStyle = UltimateMenus.KunalMenuItem.SideBarDrawStyle.DefaultGradient
        Me.MenuItem47.Text = "&Masters"
        Me.MenuItem47.Visible = False
        '
        'MenuItem73
        '
        Me.MenuItem73.CheckedImageIndex = 0
        Me.MenuItem73.CheckedMenuItemBackColor = System.Drawing.SystemColors.Control
        Me.MenuItem73.CheckedMenuItemBorderColor = System.Drawing.SystemColors.Control
        Me.MenuItem73.CheckedMenuItemDisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(197, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(184, Byte), Integer))
        Me.MenuItem73.CheckedMenuItemIconShadowColor = System.Drawing.Color.Gray
        Me.MenuItem73.CheckedMenuItemStyle = UltimateMenus.KunalMenuItem.CheckedMenuStyles.CheckedItemDefault
        Me.MenuItem73.CheckedMenuItemTickMarkColor = System.Drawing.SystemColors.Control
        Me.MenuItem73.FillMenuBarItem = False
        Me.MenuItem73.HighLightForeColor = System.Drawing.SystemColors.HighlightText
        Me.MenuItem73.HighLightScheme = UltimateMenus.KunalMenuItem.HighLightColorDrawStyle.DefaultScheme
        Me.MenuItem73.HiliteGradientColor1 = System.Drawing.Color.WhiteSmoke
        Me.MenuItem73.HiliteGradientColor2 = System.Drawing.Color.CornflowerBlue
        Me.MenuItem73.HiLiteGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.MenuItem73.IconShadowColor = System.Drawing.Color.Gray
        Me.MenuItem73.ImageIndex = 0
        Me.MenuItem73.Index = 0
        Me.MenuItem73.MakeCheckedMenuItemIconTransparent = False
        Me.MenuItem73.MakeTransparentIcon = False
        Me.MenuItem73.MenuBarItemBorderColor = System.Drawing.Color.Black
        Me.MenuItem73.MenuBarItemFillColor = System.Drawing.SystemColors.Menu
        Me.MenuItem73.MenuBarItemFillingStyle = UltimateMenus.KunalMenuItem.MenuBarFillStyles.FillColor
        Me.MenuItem73.MenuBarItemGradientColor1 = System.Drawing.SystemColors.Menu
        Me.MenuItem73.MenuBarItemGradientColor2 = System.Drawing.SystemColors.Menu
        Me.MenuItem73.MenuBarItemGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.MenuItem73.OwnerDraw = True
        Me.MenuItem73.PreDefinedHiLiteColors = UltimateMenus.KunalMenuItem.PreDefinedHighLightColors.Khaki
        Me.MenuItem73.PreDefinedHiLiteGradientColors = UltimateMenus.KunalMenuItem.PreDefinedGrHighLightColors.BrownWhite
        Me.MenuItem73.PreDefinedSideBarGradientColour = UltimateMenus.KunalMenuItem.PreDefinedSideBarGradientColors.ShineyBlueYellow
        Me.MenuItem73.ShowBorderAroundMenuBar = False
        Me.MenuItem73.ShowHiliteOverSideBar = False
        Me.MenuItem73.ShowShadowUnderMenuBar = True
        Me.MenuItem73.SideBarGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.MenuItem73.SideBarStyle = UltimateMenus.KunalMenuItem.SideBarDrawStyle.DefaultGradient
        Me.MenuItem73.Text = "State"
        '
        'MenuItem72
        '
        Me.MenuItem72.CheckedImageIndex = 0
        Me.MenuItem72.CheckedMenuItemBackColor = System.Drawing.SystemColors.Control
        Me.MenuItem72.CheckedMenuItemBorderColor = System.Drawing.SystemColors.Control
        Me.MenuItem72.CheckedMenuItemDisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(197, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(184, Byte), Integer))
        Me.MenuItem72.CheckedMenuItemIconShadowColor = System.Drawing.Color.Gray
        Me.MenuItem72.CheckedMenuItemStyle = UltimateMenus.KunalMenuItem.CheckedMenuStyles.CheckedItemDefault
        Me.MenuItem72.CheckedMenuItemTickMarkColor = System.Drawing.SystemColors.Control
        Me.MenuItem72.FillMenuBarItem = False
        Me.MenuItem72.HighLightForeColor = System.Drawing.SystemColors.HighlightText
        Me.MenuItem72.HighLightScheme = UltimateMenus.KunalMenuItem.HighLightColorDrawStyle.DefaultScheme
        Me.MenuItem72.HiliteGradientColor1 = System.Drawing.Color.WhiteSmoke
        Me.MenuItem72.HiliteGradientColor2 = System.Drawing.Color.CornflowerBlue
        Me.MenuItem72.HiLiteGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.MenuItem72.IconShadowColor = System.Drawing.Color.Gray
        Me.MenuItem72.ImageIndex = 0
        Me.MenuItem72.Index = 1
        Me.MenuItem72.MakeCheckedMenuItemIconTransparent = False
        Me.MenuItem72.MakeTransparentIcon = False
        Me.MenuItem72.MenuBarItemBorderColor = System.Drawing.Color.Black
        Me.MenuItem72.MenuBarItemFillColor = System.Drawing.SystemColors.Menu
        Me.MenuItem72.MenuBarItemFillingStyle = UltimateMenus.KunalMenuItem.MenuBarFillStyles.FillColor
        Me.MenuItem72.MenuBarItemGradientColor1 = System.Drawing.SystemColors.Menu
        Me.MenuItem72.MenuBarItemGradientColor2 = System.Drawing.SystemColors.Menu
        Me.MenuItem72.MenuBarItemGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.MenuItem72.OwnerDraw = True
        Me.MenuItem72.PreDefinedHiLiteColors = UltimateMenus.KunalMenuItem.PreDefinedHighLightColors.Khaki
        Me.MenuItem72.PreDefinedHiLiteGradientColors = UltimateMenus.KunalMenuItem.PreDefinedGrHighLightColors.BrownWhite
        Me.MenuItem72.PreDefinedSideBarGradientColour = UltimateMenus.KunalMenuItem.PreDefinedSideBarGradientColors.ShineyBlueYellow
        Me.MenuItem72.ShowBorderAroundMenuBar = False
        Me.MenuItem72.ShowHiliteOverSideBar = False
        Me.MenuItem72.ShowShadowUnderMenuBar = True
        Me.MenuItem72.SideBarGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.MenuItem72.SideBarStyle = UltimateMenus.KunalMenuItem.SideBarDrawStyle.DefaultGradient
        Me.MenuItem72.Text = "District"
        Me.MenuItem72.Visible = False
        '
        'MenuItem71
        '
        Me.MenuItem71.CheckedImageIndex = 0
        Me.MenuItem71.CheckedMenuItemBackColor = System.Drawing.SystemColors.Control
        Me.MenuItem71.CheckedMenuItemBorderColor = System.Drawing.SystemColors.Control
        Me.MenuItem71.CheckedMenuItemDisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(197, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(184, Byte), Integer))
        Me.MenuItem71.CheckedMenuItemIconShadowColor = System.Drawing.Color.Gray
        Me.MenuItem71.CheckedMenuItemStyle = UltimateMenus.KunalMenuItem.CheckedMenuStyles.CheckedItemDefault
        Me.MenuItem71.CheckedMenuItemTickMarkColor = System.Drawing.SystemColors.Control
        Me.MenuItem71.FillMenuBarItem = False
        Me.MenuItem71.HighLightForeColor = System.Drawing.SystemColors.HighlightText
        Me.MenuItem71.HighLightScheme = UltimateMenus.KunalMenuItem.HighLightColorDrawStyle.DefaultScheme
        Me.MenuItem71.HiliteGradientColor1 = System.Drawing.Color.WhiteSmoke
        Me.MenuItem71.HiliteGradientColor2 = System.Drawing.Color.CornflowerBlue
        Me.MenuItem71.HiLiteGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.MenuItem71.IconShadowColor = System.Drawing.Color.Gray
        Me.MenuItem71.ImageIndex = 0
        Me.MenuItem71.Index = 2
        Me.MenuItem71.MakeCheckedMenuItemIconTransparent = False
        Me.MenuItem71.MakeTransparentIcon = False
        Me.MenuItem71.MenuBarItemBorderColor = System.Drawing.Color.Black
        Me.MenuItem71.MenuBarItemFillColor = System.Drawing.SystemColors.Menu
        Me.MenuItem71.MenuBarItemFillingStyle = UltimateMenus.KunalMenuItem.MenuBarFillStyles.FillColor
        Me.MenuItem71.MenuBarItemGradientColor1 = System.Drawing.SystemColors.Menu
        Me.MenuItem71.MenuBarItemGradientColor2 = System.Drawing.SystemColors.Menu
        Me.MenuItem71.MenuBarItemGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.MenuItem71.OwnerDraw = True
        Me.MenuItem71.PreDefinedHiLiteColors = UltimateMenus.KunalMenuItem.PreDefinedHighLightColors.Khaki
        Me.MenuItem71.PreDefinedHiLiteGradientColors = UltimateMenus.KunalMenuItem.PreDefinedGrHighLightColors.BrownWhite
        Me.MenuItem71.PreDefinedSideBarGradientColour = UltimateMenus.KunalMenuItem.PreDefinedSideBarGradientColors.ShineyBlueYellow
        Me.MenuItem71.ShowBorderAroundMenuBar = False
        Me.MenuItem71.ShowHiliteOverSideBar = False
        Me.MenuItem71.ShowShadowUnderMenuBar = True
        Me.MenuItem71.SideBarGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.MenuItem71.SideBarStyle = UltimateMenus.KunalMenuItem.SideBarDrawStyle.DefaultGradient
        Me.MenuItem71.Text = "Taluk"
        Me.MenuItem71.Visible = False
        '
        'MenuItem70
        '
        Me.MenuItem70.CheckedImageIndex = 0
        Me.MenuItem70.CheckedMenuItemBackColor = System.Drawing.SystemColors.Control
        Me.MenuItem70.CheckedMenuItemBorderColor = System.Drawing.SystemColors.Control
        Me.MenuItem70.CheckedMenuItemDisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(197, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(184, Byte), Integer))
        Me.MenuItem70.CheckedMenuItemIconShadowColor = System.Drawing.Color.Gray
        Me.MenuItem70.CheckedMenuItemStyle = UltimateMenus.KunalMenuItem.CheckedMenuStyles.CheckedItemDefault
        Me.MenuItem70.CheckedMenuItemTickMarkColor = System.Drawing.SystemColors.Control
        Me.MenuItem70.FillMenuBarItem = False
        Me.MenuItem70.HighLightForeColor = System.Drawing.SystemColors.HighlightText
        Me.MenuItem70.HighLightScheme = UltimateMenus.KunalMenuItem.HighLightColorDrawStyle.DefaultScheme
        Me.MenuItem70.HiliteGradientColor1 = System.Drawing.Color.WhiteSmoke
        Me.MenuItem70.HiliteGradientColor2 = System.Drawing.Color.CornflowerBlue
        Me.MenuItem70.HiLiteGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.MenuItem70.IconShadowColor = System.Drawing.Color.Gray
        Me.MenuItem70.ImageIndex = 0
        Me.MenuItem70.Index = 3
        Me.MenuItem70.MakeCheckedMenuItemIconTransparent = False
        Me.MenuItem70.MakeTransparentIcon = False
        Me.MenuItem70.MenuBarItemBorderColor = System.Drawing.Color.Black
        Me.MenuItem70.MenuBarItemFillColor = System.Drawing.SystemColors.Menu
        Me.MenuItem70.MenuBarItemFillingStyle = UltimateMenus.KunalMenuItem.MenuBarFillStyles.FillColor
        Me.MenuItem70.MenuBarItemGradientColor1 = System.Drawing.SystemColors.Menu
        Me.MenuItem70.MenuBarItemGradientColor2 = System.Drawing.SystemColors.Menu
        Me.MenuItem70.MenuBarItemGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.MenuItem70.OwnerDraw = True
        Me.MenuItem70.PreDefinedHiLiteColors = UltimateMenus.KunalMenuItem.PreDefinedHighLightColors.Khaki
        Me.MenuItem70.PreDefinedHiLiteGradientColors = UltimateMenus.KunalMenuItem.PreDefinedGrHighLightColors.BrownWhite
        Me.MenuItem70.PreDefinedSideBarGradientColour = UltimateMenus.KunalMenuItem.PreDefinedSideBarGradientColors.ShineyBlueYellow
        Me.MenuItem70.ShowBorderAroundMenuBar = False
        Me.MenuItem70.ShowHiliteOverSideBar = False
        Me.MenuItem70.ShowShadowUnderMenuBar = True
        Me.MenuItem70.SideBarGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.MenuItem70.SideBarStyle = UltimateMenus.KunalMenuItem.SideBarDrawStyle.DefaultGradient
        Me.MenuItem70.Text = "Hobli"
        Me.MenuItem70.Visible = False
        '
        'MenuItem69
        '
        Me.MenuItem69.CheckedImageIndex = 0
        Me.MenuItem69.CheckedMenuItemBackColor = System.Drawing.SystemColors.Control
        Me.MenuItem69.CheckedMenuItemBorderColor = System.Drawing.SystemColors.Control
        Me.MenuItem69.CheckedMenuItemDisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(197, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(184, Byte), Integer))
        Me.MenuItem69.CheckedMenuItemIconShadowColor = System.Drawing.Color.Gray
        Me.MenuItem69.CheckedMenuItemStyle = UltimateMenus.KunalMenuItem.CheckedMenuStyles.CheckedItemDefault
        Me.MenuItem69.CheckedMenuItemTickMarkColor = System.Drawing.SystemColors.Control
        Me.MenuItem69.FillMenuBarItem = False
        Me.MenuItem69.HighLightForeColor = System.Drawing.SystemColors.HighlightText
        Me.MenuItem69.HighLightScheme = UltimateMenus.KunalMenuItem.HighLightColorDrawStyle.DefaultScheme
        Me.MenuItem69.HiliteGradientColor1 = System.Drawing.Color.WhiteSmoke
        Me.MenuItem69.HiliteGradientColor2 = System.Drawing.Color.CornflowerBlue
        Me.MenuItem69.HiLiteGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.MenuItem69.IconShadowColor = System.Drawing.Color.Gray
        Me.MenuItem69.ImageIndex = 0
        Me.MenuItem69.Index = 4
        Me.MenuItem69.MakeCheckedMenuItemIconTransparent = False
        Me.MenuItem69.MakeTransparentIcon = False
        Me.MenuItem69.MenuBarItemBorderColor = System.Drawing.Color.Black
        Me.MenuItem69.MenuBarItemFillColor = System.Drawing.SystemColors.Menu
        Me.MenuItem69.MenuBarItemFillingStyle = UltimateMenus.KunalMenuItem.MenuBarFillStyles.FillColor
        Me.MenuItem69.MenuBarItemGradientColor1 = System.Drawing.SystemColors.Menu
        Me.MenuItem69.MenuBarItemGradientColor2 = System.Drawing.SystemColors.Menu
        Me.MenuItem69.MenuBarItemGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.MenuItem69.OwnerDraw = True
        Me.MenuItem69.PreDefinedHiLiteColors = UltimateMenus.KunalMenuItem.PreDefinedHighLightColors.Khaki
        Me.MenuItem69.PreDefinedHiLiteGradientColors = UltimateMenus.KunalMenuItem.PreDefinedGrHighLightColors.BrownWhite
        Me.MenuItem69.PreDefinedSideBarGradientColour = UltimateMenus.KunalMenuItem.PreDefinedSideBarGradientColors.ShineyBlueYellow
        Me.MenuItem69.ShowBorderAroundMenuBar = False
        Me.MenuItem69.ShowHiliteOverSideBar = False
        Me.MenuItem69.ShowShadowUnderMenuBar = True
        Me.MenuItem69.SideBarGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.MenuItem69.SideBarStyle = UltimateMenus.KunalMenuItem.SideBarDrawStyle.DefaultGradient
        Me.MenuItem69.Text = "Village"
        Me.MenuItem69.Visible = False
        '
        'MenuItem68
        '
        Me.MenuItem68.CheckedImageIndex = 0
        Me.MenuItem68.CheckedMenuItemBackColor = System.Drawing.SystemColors.Control
        Me.MenuItem68.CheckedMenuItemBorderColor = System.Drawing.SystemColors.Control
        Me.MenuItem68.CheckedMenuItemDisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(197, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(184, Byte), Integer))
        Me.MenuItem68.CheckedMenuItemIconShadowColor = System.Drawing.Color.Gray
        Me.MenuItem68.CheckedMenuItemStyle = UltimateMenus.KunalMenuItem.CheckedMenuStyles.CheckedItemDefault
        Me.MenuItem68.CheckedMenuItemTickMarkColor = System.Drawing.SystemColors.Control
        Me.MenuItem68.FillMenuBarItem = False
        Me.MenuItem68.HighLightForeColor = System.Drawing.SystemColors.HighlightText
        Me.MenuItem68.HighLightScheme = UltimateMenus.KunalMenuItem.HighLightColorDrawStyle.DefaultScheme
        Me.MenuItem68.HiliteGradientColor1 = System.Drawing.Color.WhiteSmoke
        Me.MenuItem68.HiliteGradientColor2 = System.Drawing.Color.CornflowerBlue
        Me.MenuItem68.HiLiteGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.MenuItem68.IconShadowColor = System.Drawing.Color.Gray
        Me.MenuItem68.ImageIndex = 0
        Me.MenuItem68.Index = 5
        Me.MenuItem68.MakeCheckedMenuItemIconTransparent = False
        Me.MenuItem68.MakeTransparentIcon = False
        Me.MenuItem68.MenuBarItemBorderColor = System.Drawing.Color.Black
        Me.MenuItem68.MenuBarItemFillColor = System.Drawing.SystemColors.Menu
        Me.MenuItem68.MenuBarItemFillingStyle = UltimateMenus.KunalMenuItem.MenuBarFillStyles.FillColor
        Me.MenuItem68.MenuBarItemGradientColor1 = System.Drawing.SystemColors.Menu
        Me.MenuItem68.MenuBarItemGradientColor2 = System.Drawing.SystemColors.Menu
        Me.MenuItem68.MenuBarItemGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.MenuItem68.OwnerDraw = True
        Me.MenuItem68.PreDefinedHiLiteColors = UltimateMenus.KunalMenuItem.PreDefinedHighLightColors.Khaki
        Me.MenuItem68.PreDefinedHiLiteGradientColors = UltimateMenus.KunalMenuItem.PreDefinedGrHighLightColors.BrownWhite
        Me.MenuItem68.PreDefinedSideBarGradientColour = UltimateMenus.KunalMenuItem.PreDefinedSideBarGradientColors.ShineyBlueYellow
        Me.MenuItem68.ShowBorderAroundMenuBar = False
        Me.MenuItem68.ShowHiliteOverSideBar = False
        Me.MenuItem68.ShowShadowUnderMenuBar = True
        Me.MenuItem68.SideBarGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.MenuItem68.SideBarStyle = UltimateMenus.KunalMenuItem.SideBarDrawStyle.DefaultGradient
        Me.MenuItem68.Text = "Occupation"
        '
        'MenuItem67
        '
        Me.MenuItem67.CheckedImageIndex = 0
        Me.MenuItem67.CheckedMenuItemBackColor = System.Drawing.SystemColors.Control
        Me.MenuItem67.CheckedMenuItemBorderColor = System.Drawing.SystemColors.Control
        Me.MenuItem67.CheckedMenuItemDisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(197, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(184, Byte), Integer))
        Me.MenuItem67.CheckedMenuItemIconShadowColor = System.Drawing.Color.Gray
        Me.MenuItem67.CheckedMenuItemStyle = UltimateMenus.KunalMenuItem.CheckedMenuStyles.CheckedItemDefault
        Me.MenuItem67.CheckedMenuItemTickMarkColor = System.Drawing.SystemColors.Control
        Me.MenuItem67.FillMenuBarItem = False
        Me.MenuItem67.HighLightForeColor = System.Drawing.SystemColors.HighlightText
        Me.MenuItem67.HighLightScheme = UltimateMenus.KunalMenuItem.HighLightColorDrawStyle.DefaultScheme
        Me.MenuItem67.HiliteGradientColor1 = System.Drawing.Color.WhiteSmoke
        Me.MenuItem67.HiliteGradientColor2 = System.Drawing.Color.CornflowerBlue
        Me.MenuItem67.HiLiteGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.MenuItem67.IconShadowColor = System.Drawing.Color.Gray
        Me.MenuItem67.ImageIndex = 0
        Me.MenuItem67.Index = 6
        Me.MenuItem67.MakeCheckedMenuItemIconTransparent = False
        Me.MenuItem67.MakeTransparentIcon = False
        Me.MenuItem67.MenuBarItemBorderColor = System.Drawing.Color.Black
        Me.MenuItem67.MenuBarItemFillColor = System.Drawing.SystemColors.Menu
        Me.MenuItem67.MenuBarItemFillingStyle = UltimateMenus.KunalMenuItem.MenuBarFillStyles.FillColor
        Me.MenuItem67.MenuBarItemGradientColor1 = System.Drawing.SystemColors.Menu
        Me.MenuItem67.MenuBarItemGradientColor2 = System.Drawing.SystemColors.Menu
        Me.MenuItem67.MenuBarItemGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.MenuItem67.OwnerDraw = True
        Me.MenuItem67.PreDefinedHiLiteColors = UltimateMenus.KunalMenuItem.PreDefinedHighLightColors.Khaki
        Me.MenuItem67.PreDefinedHiLiteGradientColors = UltimateMenus.KunalMenuItem.PreDefinedGrHighLightColors.BrownWhite
        Me.MenuItem67.PreDefinedSideBarGradientColour = UltimateMenus.KunalMenuItem.PreDefinedSideBarGradientColors.ShineyBlueYellow
        Me.MenuItem67.ShowBorderAroundMenuBar = False
        Me.MenuItem67.ShowHiliteOverSideBar = False
        Me.MenuItem67.ShowShadowUnderMenuBar = True
        Me.MenuItem67.SideBarGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.MenuItem67.SideBarStyle = UltimateMenus.KunalMenuItem.SideBarDrawStyle.DefaultGradient
        Me.MenuItem67.Text = "Religion"
        '
        'MenuItem66
        '
        Me.MenuItem66.CheckedImageIndex = 0
        Me.MenuItem66.CheckedMenuItemBackColor = System.Drawing.SystemColors.Control
        Me.MenuItem66.CheckedMenuItemBorderColor = System.Drawing.SystemColors.Control
        Me.MenuItem66.CheckedMenuItemDisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(197, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(184, Byte), Integer))
        Me.MenuItem66.CheckedMenuItemIconShadowColor = System.Drawing.Color.Gray
        Me.MenuItem66.CheckedMenuItemStyle = UltimateMenus.KunalMenuItem.CheckedMenuStyles.CheckedItemDefault
        Me.MenuItem66.CheckedMenuItemTickMarkColor = System.Drawing.SystemColors.Control
        Me.MenuItem66.FillMenuBarItem = False
        Me.MenuItem66.HighLightForeColor = System.Drawing.SystemColors.HighlightText
        Me.MenuItem66.HighLightScheme = UltimateMenus.KunalMenuItem.HighLightColorDrawStyle.DefaultScheme
        Me.MenuItem66.HiliteGradientColor1 = System.Drawing.Color.WhiteSmoke
        Me.MenuItem66.HiliteGradientColor2 = System.Drawing.Color.CornflowerBlue
        Me.MenuItem66.HiLiteGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.MenuItem66.IconShadowColor = System.Drawing.Color.Gray
        Me.MenuItem66.ImageIndex = 0
        Me.MenuItem66.Index = 7
        Me.MenuItem66.MakeCheckedMenuItemIconTransparent = False
        Me.MenuItem66.MakeTransparentIcon = False
        Me.MenuItem66.MenuBarItemBorderColor = System.Drawing.Color.Black
        Me.MenuItem66.MenuBarItemFillColor = System.Drawing.SystemColors.Menu
        Me.MenuItem66.MenuBarItemFillingStyle = UltimateMenus.KunalMenuItem.MenuBarFillStyles.FillColor
        Me.MenuItem66.MenuBarItemGradientColor1 = System.Drawing.SystemColors.Menu
        Me.MenuItem66.MenuBarItemGradientColor2 = System.Drawing.SystemColors.Menu
        Me.MenuItem66.MenuBarItemGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.MenuItem66.OwnerDraw = True
        Me.MenuItem66.PreDefinedHiLiteColors = UltimateMenus.KunalMenuItem.PreDefinedHighLightColors.Khaki
        Me.MenuItem66.PreDefinedHiLiteGradientColors = UltimateMenus.KunalMenuItem.PreDefinedGrHighLightColors.BrownWhite
        Me.MenuItem66.PreDefinedSideBarGradientColour = UltimateMenus.KunalMenuItem.PreDefinedSideBarGradientColors.ShineyBlueYellow
        Me.MenuItem66.ShowBorderAroundMenuBar = False
        Me.MenuItem66.ShowHiliteOverSideBar = False
        Me.MenuItem66.ShowShadowUnderMenuBar = True
        Me.MenuItem66.SideBarGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.MenuItem66.SideBarStyle = UltimateMenus.KunalMenuItem.SideBarDrawStyle.DefaultGradient
        Me.MenuItem66.Text = "Caste"
        '
        'MenuItem91
        '
        Me.MenuItem91.Checked = True
        Me.MenuItem91.CheckedImageIndex = 0
        Me.MenuItem91.CheckedMenuItemBackColor = System.Drawing.SystemColors.Control
        Me.MenuItem91.CheckedMenuItemBorderColor = System.Drawing.SystemColors.Control
        Me.MenuItem91.CheckedMenuItemDisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(197, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(184, Byte), Integer))
        Me.MenuItem91.CheckedMenuItemIconShadowColor = System.Drawing.Color.Gray
        Me.MenuItem91.CheckedMenuItemStyle = UltimateMenus.KunalMenuItem.CheckedMenuStyles.CheckedItemDefault
        Me.MenuItem91.CheckedMenuItemTickMarkColor = System.Drawing.SystemColors.Control
        Me.MenuItem91.FillMenuBarItem = False
        Me.MenuItem91.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuItem91.HighLightForeColor = System.Drawing.SystemColors.HighlightText
        Me.MenuItem91.HighLightScheme = UltimateMenus.KunalMenuItem.HighLightColorDrawStyle.DefaultScheme
        Me.MenuItem91.HiliteGradientColor1 = System.Drawing.Color.WhiteSmoke
        Me.MenuItem91.HiliteGradientColor2 = System.Drawing.Color.CornflowerBlue
        Me.MenuItem91.HiLiteGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.MenuItem91.IconShadowColor = System.Drawing.Color.Gray
        Me.MenuItem91.ImageIndex = 0
        Me.MenuItem91.Index = 1
        Me.MenuItem91.MakeCheckedMenuItemIconTransparent = False
        Me.MenuItem91.MakeTransparentIcon = False
        Me.MenuItem91.MenuBarItemBorderColor = System.Drawing.Color.Black
        Me.MenuItem91.MenuBarItemFillColor = System.Drawing.SystemColors.Menu
        Me.MenuItem91.MenuBarItemFillingStyle = UltimateMenus.KunalMenuItem.MenuBarFillStyles.FillColor
        Me.MenuItem91.MenuBarItemGradientColor1 = System.Drawing.SystemColors.Menu
        Me.MenuItem91.MenuBarItemGradientColor2 = System.Drawing.SystemColors.Menu
        Me.MenuItem91.MenuBarItemGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.MenuItem91.OwnerDraw = True
        Me.MenuItem91.PreDefinedHiLiteColors = UltimateMenus.KunalMenuItem.PreDefinedHighLightColors.Khaki
        Me.MenuItem91.PreDefinedHiLiteGradientColors = UltimateMenus.KunalMenuItem.PreDefinedGrHighLightColors.BrownWhite
        Me.MenuItem91.PreDefinedSideBarGradientColour = UltimateMenus.KunalMenuItem.PreDefinedSideBarGradientColors.ShineyBlueYellow
        Me.MenuItem91.Shortcut = System.Windows.Forms.Shortcut.F11
        Me.MenuItem91.ShowBorderAroundMenuBar = False
        Me.MenuItem91.ShowHiliteOverSideBar = False
        Me.MenuItem91.ShowShadowUnderMenuBar = True
        Me.MenuItem91.SideBarGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.MenuItem91.SideBarStyle = UltimateMenus.KunalMenuItem.SideBarDrawStyle.DefaultGradient
        Me.MenuItem91.Text = "&Quick Launch"
        '
        'MenuItem92
        '
        Me.MenuItem92.Checked = True
        Me.MenuItem92.CheckedImageIndex = 0
        Me.MenuItem92.CheckedMenuItemBackColor = System.Drawing.SystemColors.Control
        Me.MenuItem92.CheckedMenuItemBorderColor = System.Drawing.SystemColors.Control
        Me.MenuItem92.CheckedMenuItemDisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(197, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(184, Byte), Integer))
        Me.MenuItem92.CheckedMenuItemIconShadowColor = System.Drawing.Color.Gray
        Me.MenuItem92.CheckedMenuItemStyle = UltimateMenus.KunalMenuItem.CheckedMenuStyles.CheckedItemDefault
        Me.MenuItem92.CheckedMenuItemTickMarkColor = System.Drawing.SystemColors.Control
        Me.MenuItem92.FillMenuBarItem = False
        Me.MenuItem92.HighLightForeColor = System.Drawing.SystemColors.HighlightText
        Me.MenuItem92.HighLightScheme = UltimateMenus.KunalMenuItem.HighLightColorDrawStyle.DefaultScheme
        Me.MenuItem92.HiliteGradientColor1 = System.Drawing.Color.WhiteSmoke
        Me.MenuItem92.HiliteGradientColor2 = System.Drawing.Color.CornflowerBlue
        Me.MenuItem92.HiLiteGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.MenuItem92.IconShadowColor = System.Drawing.Color.Gray
        Me.MenuItem92.ImageIndex = 0
        Me.MenuItem92.Index = 2
        Me.MenuItem92.MakeCheckedMenuItemIconTransparent = False
        Me.MenuItem92.MakeTransparentIcon = False
        Me.MenuItem92.MenuBarItemBorderColor = System.Drawing.Color.Black
        Me.MenuItem92.MenuBarItemFillColor = System.Drawing.SystemColors.Menu
        Me.MenuItem92.MenuBarItemFillingStyle = UltimateMenus.KunalMenuItem.MenuBarFillStyles.FillColor
        Me.MenuItem92.MenuBarItemGradientColor1 = System.Drawing.SystemColors.Menu
        Me.MenuItem92.MenuBarItemGradientColor2 = System.Drawing.SystemColors.Menu
        Me.MenuItem92.MenuBarItemGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.MenuItem92.OwnerDraw = True
        Me.MenuItem92.PreDefinedHiLiteColors = UltimateMenus.KunalMenuItem.PreDefinedHighLightColors.Khaki
        Me.MenuItem92.PreDefinedHiLiteGradientColors = UltimateMenus.KunalMenuItem.PreDefinedGrHighLightColors.BrownWhite
        Me.MenuItem92.PreDefinedSideBarGradientColour = UltimateMenus.KunalMenuItem.PreDefinedSideBarGradientColors.ShineyBlueYellow
        Me.MenuItem92.Shortcut = System.Windows.Forms.Shortcut.F12
        Me.MenuItem92.ShowBorderAroundMenuBar = False
        Me.MenuItem92.ShowHiliteOverSideBar = False
        Me.MenuItem92.ShowShadowUnderMenuBar = True
        Me.MenuItem92.SideBarGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.MenuItem92.SideBarStyle = UltimateMenus.KunalMenuItem.SideBarDrawStyle.DefaultGradient
        Me.MenuItem92.Text = "&Tasks"
        Me.MenuItem92.Visible = False
        '
        'MenuItem81
        '
        Me.MenuItem81.CheckedImageIndex = 0
        Me.MenuItem81.CheckedMenuItemBackColor = System.Drawing.SystemColors.Control
        Me.MenuItem81.CheckedMenuItemBorderColor = System.Drawing.SystemColors.Control
        Me.MenuItem81.CheckedMenuItemDisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(197, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(184, Byte), Integer))
        Me.MenuItem81.CheckedMenuItemIconShadowColor = System.Drawing.Color.Gray
        Me.MenuItem81.CheckedMenuItemStyle = UltimateMenus.KunalMenuItem.CheckedMenuStyles.CheckedItemDefault
        Me.MenuItem81.CheckedMenuItemTickMarkColor = System.Drawing.SystemColors.Control
        Me.MenuItem81.FillMenuBarItem = False
        Me.MenuItem81.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuItem81.HighLightForeColor = System.Drawing.SystemColors.HighlightText
        Me.MenuItem81.HighLightScheme = UltimateMenus.KunalMenuItem.HighLightColorDrawStyle.DefaultScheme
        Me.MenuItem81.HiliteGradientColor1 = System.Drawing.Color.WhiteSmoke
        Me.MenuItem81.HiliteGradientColor2 = System.Drawing.Color.CornflowerBlue
        Me.MenuItem81.HiLiteGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.MenuItem81.IconShadowColor = System.Drawing.Color.Gray
        Me.MenuItem81.ImageIndex = 0
        Me.MenuItem81.Index = 3
        Me.MenuItem81.MakeCheckedMenuItemIconTransparent = False
        Me.MenuItem81.MakeTransparentIcon = False
        Me.MenuItem81.MenuBarItemBorderColor = System.Drawing.Color.Black
        Me.MenuItem81.MenuBarItemFillColor = System.Drawing.SystemColors.Menu
        Me.MenuItem81.MenuBarItemFillingStyle = UltimateMenus.KunalMenuItem.MenuBarFillStyles.FillColor
        Me.MenuItem81.MenuBarItemGradientColor1 = System.Drawing.SystemColors.Menu
        Me.MenuItem81.MenuBarItemGradientColor2 = System.Drawing.SystemColors.Menu
        Me.MenuItem81.MenuBarItemGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.MenuItem81.OwnerDraw = True
        Me.MenuItem81.PreDefinedHiLiteColors = UltimateMenus.KunalMenuItem.PreDefinedHighLightColors.Khaki
        Me.MenuItem81.PreDefinedHiLiteGradientColors = UltimateMenus.KunalMenuItem.PreDefinedGrHighLightColors.BrownWhite
        Me.MenuItem81.PreDefinedSideBarGradientColour = UltimateMenus.KunalMenuItem.PreDefinedSideBarGradientColors.ShineyBlueYellow
        Me.MenuItem81.ShowBorderAroundMenuBar = False
        Me.MenuItem81.ShowHiliteOverSideBar = False
        Me.MenuItem81.ShowShadowUnderMenuBar = True
        Me.MenuItem81.SideBarGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.MenuItem81.SideBarStyle = UltimateMenus.KunalMenuItem.SideBarDrawStyle.DefaultGradient
        Me.MenuItem81.Text = "&Change Password"
        '
        'MenuItem9
        '
        Me.MenuItem9.CheckedImageIndex = 0
        Me.MenuItem9.CheckedMenuItemBackColor = System.Drawing.SystemColors.Control
        Me.MenuItem9.CheckedMenuItemBorderColor = System.Drawing.SystemColors.Control
        Me.MenuItem9.CheckedMenuItemDisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(197, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(184, Byte), Integer))
        Me.MenuItem9.CheckedMenuItemIconShadowColor = System.Drawing.Color.Gray
        Me.MenuItem9.CheckedMenuItemStyle = UltimateMenus.KunalMenuItem.CheckedMenuStyles.CheckedItemDefault
        Me.MenuItem9.CheckedMenuItemTickMarkColor = System.Drawing.SystemColors.Control
        Me.MenuItem9.FillMenuBarItem = False
        Me.MenuItem9.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuItem9.HighLightForeColor = System.Drawing.SystemColors.HighlightText
        Me.MenuItem9.HighLightScheme = UltimateMenus.KunalMenuItem.HighLightColorDrawStyle.DefaultScheme
        Me.MenuItem9.HiliteGradientColor1 = System.Drawing.Color.WhiteSmoke
        Me.MenuItem9.HiliteGradientColor2 = System.Drawing.Color.CornflowerBlue
        Me.MenuItem9.HiLiteGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.MenuItem9.IconShadowColor = System.Drawing.Color.Gray
        Me.MenuItem9.ImageIndex = 0
        Me.MenuItem9.Index = 4
        Me.MenuItem9.MakeCheckedMenuItemIconTransparent = False
        Me.MenuItem9.MakeTransparentIcon = False
        Me.MenuItem9.MenuBarItemBorderColor = System.Drawing.Color.Black
        Me.MenuItem9.MenuBarItemFillColor = System.Drawing.SystemColors.Menu
        Me.MenuItem9.MenuBarItemFillingStyle = UltimateMenus.KunalMenuItem.MenuBarFillStyles.FillColor
        Me.MenuItem9.MenuBarItemGradientColor1 = System.Drawing.SystemColors.Menu
        Me.MenuItem9.MenuBarItemGradientColor2 = System.Drawing.SystemColors.Menu
        Me.MenuItem9.MenuBarItemGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.MenuItem9.OwnerDraw = True
        Me.MenuItem9.PreDefinedHiLiteColors = UltimateMenus.KunalMenuItem.PreDefinedHighLightColors.Khaki
        Me.MenuItem9.PreDefinedHiLiteGradientColors = UltimateMenus.KunalMenuItem.PreDefinedGrHighLightColors.BrownWhite
        Me.MenuItem9.PreDefinedSideBarGradientColour = UltimateMenus.KunalMenuItem.PreDefinedSideBarGradientColors.ShineyBlueYellow
        Me.MenuItem9.ShowBorderAroundMenuBar = False
        Me.MenuItem9.ShowHiliteOverSideBar = False
        Me.MenuItem9.ShowShadowUnderMenuBar = True
        Me.MenuItem9.SideBarGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.MenuItem9.SideBarStyle = UltimateMenus.KunalMenuItem.SideBarDrawStyle.DefaultGradient
        Me.MenuItem9.Text = "Log &Off"
        '
        'MenuItem10
        '
        Me.MenuItem10.CheckedImageIndex = 0
        Me.MenuItem10.CheckedMenuItemBackColor = System.Drawing.SystemColors.Control
        Me.MenuItem10.CheckedMenuItemBorderColor = System.Drawing.SystemColors.Control
        Me.MenuItem10.CheckedMenuItemDisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(197, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(184, Byte), Integer))
        Me.MenuItem10.CheckedMenuItemIconShadowColor = System.Drawing.Color.Gray
        Me.MenuItem10.CheckedMenuItemStyle = UltimateMenus.KunalMenuItem.CheckedMenuStyles.CheckedItemDefault
        Me.MenuItem10.CheckedMenuItemTickMarkColor = System.Drawing.SystemColors.Control
        Me.MenuItem10.FillMenuBarItem = False
        Me.MenuItem10.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuItem10.HighLightForeColor = System.Drawing.SystemColors.HighlightText
        Me.MenuItem10.HighLightScheme = UltimateMenus.KunalMenuItem.HighLightColorDrawStyle.DefaultScheme
        Me.MenuItem10.HiliteGradientColor1 = System.Drawing.Color.WhiteSmoke
        Me.MenuItem10.HiliteGradientColor2 = System.Drawing.Color.CornflowerBlue
        Me.MenuItem10.HiLiteGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.MenuItem10.IconShadowColor = System.Drawing.Color.Gray
        Me.MenuItem10.ImageIndex = 0
        Me.MenuItem10.Index = 5
        Me.MenuItem10.MakeCheckedMenuItemIconTransparent = False
        Me.MenuItem10.MakeTransparentIcon = False
        Me.MenuItem10.MenuBarItemBorderColor = System.Drawing.Color.Black
        Me.MenuItem10.MenuBarItemFillColor = System.Drawing.SystemColors.Menu
        Me.MenuItem10.MenuBarItemFillingStyle = UltimateMenus.KunalMenuItem.MenuBarFillStyles.FillColor
        Me.MenuItem10.MenuBarItemGradientColor1 = System.Drawing.SystemColors.Menu
        Me.MenuItem10.MenuBarItemGradientColor2 = System.Drawing.SystemColors.Menu
        Me.MenuItem10.MenuBarItemGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.MenuItem10.OwnerDraw = True
        Me.MenuItem10.PreDefinedHiLiteColors = UltimateMenus.KunalMenuItem.PreDefinedHighLightColors.Khaki
        Me.MenuItem10.PreDefinedHiLiteGradientColors = UltimateMenus.KunalMenuItem.PreDefinedGrHighLightColors.BrownWhite
        Me.MenuItem10.PreDefinedSideBarGradientColour = UltimateMenus.KunalMenuItem.PreDefinedSideBarGradientColors.ShineyBlueYellow
        Me.MenuItem10.Shortcut = System.Windows.Forms.Shortcut.CtrlX
        Me.MenuItem10.ShowBorderAroundMenuBar = False
        Me.MenuItem10.ShowHiliteOverSideBar = False
        Me.MenuItem10.ShowShadowUnderMenuBar = True
        Me.MenuItem10.SideBarGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.MenuItem10.SideBarStyle = UltimateMenus.KunalMenuItem.SideBarDrawStyle.DefaultGradient
        Me.MenuItem10.Text = "E&xit"
        '
        'MenuItem82
        '
        Me.MenuItem82.CheckedImageIndex = 0
        Me.MenuItem82.CheckedMenuItemBackColor = System.Drawing.SystemColors.Control
        Me.MenuItem82.CheckedMenuItemBorderColor = System.Drawing.SystemColors.Control
        Me.MenuItem82.CheckedMenuItemDisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(197, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(184, Byte), Integer))
        Me.MenuItem82.CheckedMenuItemIconShadowColor = System.Drawing.Color.Gray
        Me.MenuItem82.CheckedMenuItemStyle = UltimateMenus.KunalMenuItem.CheckedMenuStyles.CheckedItemDefault
        Me.MenuItem82.CheckedMenuItemTickMarkColor = System.Drawing.SystemColors.Control
        Me.MenuItem82.FillMenuBarItem = False
        Me.MenuItem82.HighLightForeColor = System.Drawing.SystemColors.HighlightText
        Me.MenuItem82.HighLightScheme = UltimateMenus.KunalMenuItem.HighLightColorDrawStyle.DefaultScheme
        Me.MenuItem82.HiliteGradientColor1 = System.Drawing.Color.WhiteSmoke
        Me.MenuItem82.HiliteGradientColor2 = System.Drawing.Color.CornflowerBlue
        Me.MenuItem82.HiLiteGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.MenuItem82.IconShadowColor = System.Drawing.Color.Gray
        Me.MenuItem82.ImageIndex = 0
        Me.MenuItem82.Index = 1
        Me.MenuItem82.MakeCheckedMenuItemIconTransparent = False
        Me.MenuItem82.MakeTransparentIcon = False
        Me.MenuItem82.MenuBarItemBorderColor = System.Drawing.Color.Black
        Me.MenuItem82.MenuBarItemFillColor = System.Drawing.SystemColors.Menu
        Me.MenuItem82.MenuBarItemFillingStyle = UltimateMenus.KunalMenuItem.MenuBarFillStyles.FillColor
        Me.MenuItem82.MenuBarItemGradientColor1 = System.Drawing.SystemColors.Menu
        Me.MenuItem82.MenuBarItemGradientColor2 = System.Drawing.SystemColors.Menu
        Me.MenuItem82.MenuBarItemGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.MenuItem82.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem63, Me.MenuItem62, Me.MenuItem83, Me.MenuItem84, Me.MenuItem85, Me.MenuItem86, Me.MenuItem141, Me.MenuItem142})
        Me.MenuItem82.OwnerDraw = True
        Me.MenuItem82.PreDefinedHiLiteColors = UltimateMenus.KunalMenuItem.PreDefinedHighLightColors.Khaki
        Me.MenuItem82.PreDefinedHiLiteGradientColors = UltimateMenus.KunalMenuItem.PreDefinedGrHighLightColors.BrownWhite
        Me.MenuItem82.PreDefinedSideBarGradientColour = UltimateMenus.KunalMenuItem.PreDefinedSideBarGradientColors.ShineyBlueYellow
        Me.MenuItem82.ShowBorderAroundMenuBar = False
        Me.MenuItem82.ShowHiliteOverSideBar = False
        Me.MenuItem82.ShowShadowUnderMenuBar = True
        Me.MenuItem82.SideBarGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.MenuItem82.SideBarStyle = UltimateMenus.KunalMenuItem.SideBarDrawStyle.DefaultGradient
        Me.MenuItem82.Text = "Administratio&n"
        '
        'MenuItem63
        '
        Me.MenuItem63.CheckedImageIndex = 0
        Me.MenuItem63.CheckedMenuItemBackColor = System.Drawing.SystemColors.Control
        Me.MenuItem63.CheckedMenuItemBorderColor = System.Drawing.SystemColors.Control
        Me.MenuItem63.CheckedMenuItemDisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(197, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(184, Byte), Integer))
        Me.MenuItem63.CheckedMenuItemIconShadowColor = System.Drawing.Color.Gray
        Me.MenuItem63.CheckedMenuItemStyle = UltimateMenus.KunalMenuItem.CheckedMenuStyles.CheckedItemDefault
        Me.MenuItem63.CheckedMenuItemTickMarkColor = System.Drawing.SystemColors.Control
        Me.MenuItem63.FillMenuBarItem = False
        Me.MenuItem63.HighLightForeColor = System.Drawing.SystemColors.HighlightText
        Me.MenuItem63.HighLightScheme = UltimateMenus.KunalMenuItem.HighLightColorDrawStyle.DefaultScheme
        Me.MenuItem63.HiliteGradientColor1 = System.Drawing.Color.WhiteSmoke
        Me.MenuItem63.HiliteGradientColor2 = System.Drawing.Color.CornflowerBlue
        Me.MenuItem63.HiLiteGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.MenuItem63.IconShadowColor = System.Drawing.Color.Gray
        Me.MenuItem63.ImageIndex = 0
        Me.MenuItem63.Index = 0
        Me.MenuItem63.MakeCheckedMenuItemIconTransparent = False
        Me.MenuItem63.MakeTransparentIcon = False
        Me.MenuItem63.MenuBarItemBorderColor = System.Drawing.Color.Black
        Me.MenuItem63.MenuBarItemFillColor = System.Drawing.SystemColors.Menu
        Me.MenuItem63.MenuBarItemFillingStyle = UltimateMenus.KunalMenuItem.MenuBarFillStyles.FillColor
        Me.MenuItem63.MenuBarItemGradientColor1 = System.Drawing.SystemColors.Menu
        Me.MenuItem63.MenuBarItemGradientColor2 = System.Drawing.SystemColors.Menu
        Me.MenuItem63.MenuBarItemGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.MenuItem63.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem16, Me.MenuItem64, Me.MenuItem65})
        Me.MenuItem63.OwnerDraw = True
        Me.MenuItem63.PreDefinedHiLiteColors = UltimateMenus.KunalMenuItem.PreDefinedHighLightColors.Khaki
        Me.MenuItem63.PreDefinedHiLiteGradientColors = UltimateMenus.KunalMenuItem.PreDefinedGrHighLightColors.BrownWhite
        Me.MenuItem63.PreDefinedSideBarGradientColour = UltimateMenus.KunalMenuItem.PreDefinedSideBarGradientColors.ShineyBlueYellow
        Me.MenuItem63.ShowBorderAroundMenuBar = False
        Me.MenuItem63.ShowHiliteOverSideBar = False
        Me.MenuItem63.ShowShadowUnderMenuBar = True
        Me.MenuItem63.SideBarGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.MenuItem63.SideBarStyle = UltimateMenus.KunalMenuItem.SideBarDrawStyle.DefaultGradient
        Me.MenuItem63.Text = "&Users"
        '
        'MenuItem16
        '
        Me.MenuItem16.CheckedImageIndex = 0
        Me.MenuItem16.CheckedMenuItemBackColor = System.Drawing.SystemColors.Control
        Me.MenuItem16.CheckedMenuItemBorderColor = System.Drawing.SystemColors.Control
        Me.MenuItem16.CheckedMenuItemDisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(197, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(184, Byte), Integer))
        Me.MenuItem16.CheckedMenuItemIconShadowColor = System.Drawing.Color.Gray
        Me.MenuItem16.CheckedMenuItemStyle = UltimateMenus.KunalMenuItem.CheckedMenuStyles.CheckedItemDefault
        Me.MenuItem16.CheckedMenuItemTickMarkColor = System.Drawing.SystemColors.Control
        Me.MenuItem16.FillMenuBarItem = False
        Me.MenuItem16.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuItem16.HighLightForeColor = System.Drawing.SystemColors.HighlightText
        Me.MenuItem16.HighLightScheme = UltimateMenus.KunalMenuItem.HighLightColorDrawStyle.DefaultScheme
        Me.MenuItem16.HiliteGradientColor1 = System.Drawing.Color.WhiteSmoke
        Me.MenuItem16.HiliteGradientColor2 = System.Drawing.Color.CornflowerBlue
        Me.MenuItem16.HiLiteGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.MenuItem16.IconShadowColor = System.Drawing.Color.Gray
        Me.MenuItem16.ImageIndex = 0
        Me.MenuItem16.Index = 0
        Me.MenuItem16.MakeCheckedMenuItemIconTransparent = False
        Me.MenuItem16.MakeTransparentIcon = False
        Me.MenuItem16.MenuBarItemBorderColor = System.Drawing.Color.Black
        Me.MenuItem16.MenuBarItemFillColor = System.Drawing.SystemColors.Menu
        Me.MenuItem16.MenuBarItemFillingStyle = UltimateMenus.KunalMenuItem.MenuBarFillStyles.FillColor
        Me.MenuItem16.MenuBarItemGradientColor1 = System.Drawing.SystemColors.Menu
        Me.MenuItem16.MenuBarItemGradientColor2 = System.Drawing.SystemColors.Menu
        Me.MenuItem16.MenuBarItemGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.MenuItem16.OwnerDraw = True
        Me.MenuItem16.PreDefinedHiLiteColors = UltimateMenus.KunalMenuItem.PreDefinedHighLightColors.Khaki
        Me.MenuItem16.PreDefinedHiLiteGradientColors = UltimateMenus.KunalMenuItem.PreDefinedGrHighLightColors.BrownWhite
        Me.MenuItem16.PreDefinedSideBarGradientColour = UltimateMenus.KunalMenuItem.PreDefinedSideBarGradientColors.ShineyBlueYellow
        Me.MenuItem16.ShowBorderAroundMenuBar = False
        Me.MenuItem16.ShowHiliteOverSideBar = False
        Me.MenuItem16.ShowShadowUnderMenuBar = True
        Me.MenuItem16.SideBarGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.MenuItem16.SideBarStyle = UltimateMenus.KunalMenuItem.SideBarDrawStyle.DefaultGradient
        Me.MenuItem16.Text = "Create User"
        '
        'MenuItem64
        '
        Me.MenuItem64.CheckedImageIndex = 0
        Me.MenuItem64.CheckedMenuItemBackColor = System.Drawing.SystemColors.Control
        Me.MenuItem64.CheckedMenuItemBorderColor = System.Drawing.SystemColors.Control
        Me.MenuItem64.CheckedMenuItemDisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(197, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(184, Byte), Integer))
        Me.MenuItem64.CheckedMenuItemIconShadowColor = System.Drawing.Color.Gray
        Me.MenuItem64.CheckedMenuItemStyle = UltimateMenus.KunalMenuItem.CheckedMenuStyles.CheckedItemDefault
        Me.MenuItem64.CheckedMenuItemTickMarkColor = System.Drawing.SystemColors.Control
        Me.MenuItem64.FillMenuBarItem = False
        Me.MenuItem64.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuItem64.HighLightForeColor = System.Drawing.SystemColors.HighlightText
        Me.MenuItem64.HighLightScheme = UltimateMenus.KunalMenuItem.HighLightColorDrawStyle.DefaultScheme
        Me.MenuItem64.HiliteGradientColor1 = System.Drawing.Color.WhiteSmoke
        Me.MenuItem64.HiliteGradientColor2 = System.Drawing.Color.CornflowerBlue
        Me.MenuItem64.HiLiteGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.MenuItem64.IconShadowColor = System.Drawing.Color.Gray
        Me.MenuItem64.ImageIndex = 0
        Me.MenuItem64.Index = 1
        Me.MenuItem64.MakeCheckedMenuItemIconTransparent = False
        Me.MenuItem64.MakeTransparentIcon = False
        Me.MenuItem64.MenuBarItemBorderColor = System.Drawing.Color.Black
        Me.MenuItem64.MenuBarItemFillColor = System.Drawing.SystemColors.Menu
        Me.MenuItem64.MenuBarItemFillingStyle = UltimateMenus.KunalMenuItem.MenuBarFillStyles.FillColor
        Me.MenuItem64.MenuBarItemGradientColor1 = System.Drawing.SystemColors.Menu
        Me.MenuItem64.MenuBarItemGradientColor2 = System.Drawing.SystemColors.Menu
        Me.MenuItem64.MenuBarItemGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.MenuItem64.OwnerDraw = True
        Me.MenuItem64.PreDefinedHiLiteColors = UltimateMenus.KunalMenuItem.PreDefinedHighLightColors.Khaki
        Me.MenuItem64.PreDefinedHiLiteGradientColors = UltimateMenus.KunalMenuItem.PreDefinedGrHighLightColors.BrownWhite
        Me.MenuItem64.PreDefinedSideBarGradientColour = UltimateMenus.KunalMenuItem.PreDefinedSideBarGradientColors.ShineyBlueYellow
        Me.MenuItem64.ShowBorderAroundMenuBar = False
        Me.MenuItem64.ShowHiliteOverSideBar = False
        Me.MenuItem64.ShowShadowUnderMenuBar = True
        Me.MenuItem64.SideBarGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.MenuItem64.SideBarStyle = UltimateMenus.KunalMenuItem.SideBarDrawStyle.DefaultGradient
        Me.MenuItem64.Text = "View User"
        '
        'MenuItem65
        '
        Me.MenuItem65.CheckedImageIndex = 0
        Me.MenuItem65.CheckedMenuItemBackColor = System.Drawing.SystemColors.Control
        Me.MenuItem65.CheckedMenuItemBorderColor = System.Drawing.SystemColors.Control
        Me.MenuItem65.CheckedMenuItemDisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(197, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(184, Byte), Integer))
        Me.MenuItem65.CheckedMenuItemIconShadowColor = System.Drawing.Color.Gray
        Me.MenuItem65.CheckedMenuItemStyle = UltimateMenus.KunalMenuItem.CheckedMenuStyles.CheckedItemDefault
        Me.MenuItem65.CheckedMenuItemTickMarkColor = System.Drawing.SystemColors.Control
        Me.MenuItem65.FillMenuBarItem = False
        Me.MenuItem65.HighLightForeColor = System.Drawing.SystemColors.HighlightText
        Me.MenuItem65.HighLightScheme = UltimateMenus.KunalMenuItem.HighLightColorDrawStyle.DefaultScheme
        Me.MenuItem65.HiliteGradientColor1 = System.Drawing.Color.WhiteSmoke
        Me.MenuItem65.HiliteGradientColor2 = System.Drawing.Color.CornflowerBlue
        Me.MenuItem65.HiLiteGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.MenuItem65.IconShadowColor = System.Drawing.Color.Gray
        Me.MenuItem65.ImageIndex = 0
        Me.MenuItem65.Index = 2
        Me.MenuItem65.MakeCheckedMenuItemIconTransparent = False
        Me.MenuItem65.MakeTransparentIcon = False
        Me.MenuItem65.MenuBarItemBorderColor = System.Drawing.Color.Black
        Me.MenuItem65.MenuBarItemFillColor = System.Drawing.SystemColors.Menu
        Me.MenuItem65.MenuBarItemFillingStyle = UltimateMenus.KunalMenuItem.MenuBarFillStyles.FillColor
        Me.MenuItem65.MenuBarItemGradientColor1 = System.Drawing.SystemColors.Menu
        Me.MenuItem65.MenuBarItemGradientColor2 = System.Drawing.SystemColors.Menu
        Me.MenuItem65.MenuBarItemGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.MenuItem65.OwnerDraw = True
        Me.MenuItem65.PreDefinedHiLiteColors = UltimateMenus.KunalMenuItem.PreDefinedHighLightColors.Khaki
        Me.MenuItem65.PreDefinedHiLiteGradientColors = UltimateMenus.KunalMenuItem.PreDefinedGrHighLightColors.BrownWhite
        Me.MenuItem65.PreDefinedSideBarGradientColour = UltimateMenus.KunalMenuItem.PreDefinedSideBarGradientColors.ShineyBlueYellow
        Me.MenuItem65.ShowBorderAroundMenuBar = False
        Me.MenuItem65.ShowHiliteOverSideBar = False
        Me.MenuItem65.ShowShadowUnderMenuBar = True
        Me.MenuItem65.SideBarGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.MenuItem65.SideBarStyle = UltimateMenus.KunalMenuItem.SideBarDrawStyle.DefaultGradient
        Me.MenuItem65.Text = "Access Permisson"
        Me.MenuItem65.Visible = False
        '
        'MenuItem62
        '
        Me.MenuItem62.CheckedImageIndex = 0
        Me.MenuItem62.CheckedMenuItemBackColor = System.Drawing.SystemColors.Control
        Me.MenuItem62.CheckedMenuItemBorderColor = System.Drawing.SystemColors.Control
        Me.MenuItem62.CheckedMenuItemDisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(197, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(184, Byte), Integer))
        Me.MenuItem62.CheckedMenuItemIconShadowColor = System.Drawing.Color.Gray
        Me.MenuItem62.CheckedMenuItemStyle = UltimateMenus.KunalMenuItem.CheckedMenuStyles.CheckedItemDefault
        Me.MenuItem62.CheckedMenuItemTickMarkColor = System.Drawing.SystemColors.Control
        Me.MenuItem62.FillMenuBarItem = False
        Me.MenuItem62.HighLightForeColor = System.Drawing.SystemColors.HighlightText
        Me.MenuItem62.HighLightScheme = UltimateMenus.KunalMenuItem.HighLightColorDrawStyle.DefaultScheme
        Me.MenuItem62.HiliteGradientColor1 = System.Drawing.Color.WhiteSmoke
        Me.MenuItem62.HiliteGradientColor2 = System.Drawing.Color.CornflowerBlue
        Me.MenuItem62.HiLiteGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.MenuItem62.IconShadowColor = System.Drawing.Color.Gray
        Me.MenuItem62.ImageIndex = 0
        Me.MenuItem62.Index = 1
        Me.MenuItem62.MakeCheckedMenuItemIconTransparent = False
        Me.MenuItem62.MakeTransparentIcon = False
        Me.MenuItem62.MenuBarItemBorderColor = System.Drawing.Color.Black
        Me.MenuItem62.MenuBarItemFillColor = System.Drawing.SystemColors.Menu
        Me.MenuItem62.MenuBarItemFillingStyle = UltimateMenus.KunalMenuItem.MenuBarFillStyles.FillColor
        Me.MenuItem62.MenuBarItemGradientColor1 = System.Drawing.SystemColors.Menu
        Me.MenuItem62.MenuBarItemGradientColor2 = System.Drawing.SystemColors.Menu
        Me.MenuItem62.MenuBarItemGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.MenuItem62.OwnerDraw = True
        Me.MenuItem62.PreDefinedHiLiteColors = UltimateMenus.KunalMenuItem.PreDefinedHighLightColors.Khaki
        Me.MenuItem62.PreDefinedHiLiteGradientColors = UltimateMenus.KunalMenuItem.PreDefinedGrHighLightColors.BrownWhite
        Me.MenuItem62.PreDefinedSideBarGradientColour = UltimateMenus.KunalMenuItem.PreDefinedSideBarGradientColors.ShineyBlueYellow
        Me.MenuItem62.ShowBorderAroundMenuBar = False
        Me.MenuItem62.ShowHiliteOverSideBar = False
        Me.MenuItem62.ShowShadowUnderMenuBar = True
        Me.MenuItem62.SideBarGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.MenuItem62.SideBarStyle = UltimateMenus.KunalMenuItem.SideBarDrawStyle.DefaultGradient
        Me.MenuItem62.Text = "&Logs"
        '
        'MenuItem83
        '
        Me.MenuItem83.CheckedImageIndex = 0
        Me.MenuItem83.CheckedMenuItemBackColor = System.Drawing.SystemColors.Control
        Me.MenuItem83.CheckedMenuItemBorderColor = System.Drawing.SystemColors.Control
        Me.MenuItem83.CheckedMenuItemDisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(197, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(184, Byte), Integer))
        Me.MenuItem83.CheckedMenuItemIconShadowColor = System.Drawing.Color.Gray
        Me.MenuItem83.CheckedMenuItemStyle = UltimateMenus.KunalMenuItem.CheckedMenuStyles.CheckedItemDefault
        Me.MenuItem83.CheckedMenuItemTickMarkColor = System.Drawing.SystemColors.Control
        Me.MenuItem83.FillMenuBarItem = False
        Me.MenuItem83.HighLightForeColor = System.Drawing.SystemColors.HighlightText
        Me.MenuItem83.HighLightScheme = UltimateMenus.KunalMenuItem.HighLightColorDrawStyle.DefaultScheme
        Me.MenuItem83.HiliteGradientColor1 = System.Drawing.Color.WhiteSmoke
        Me.MenuItem83.HiliteGradientColor2 = System.Drawing.Color.CornflowerBlue
        Me.MenuItem83.HiLiteGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.MenuItem83.IconShadowColor = System.Drawing.Color.Gray
        Me.MenuItem83.ImageIndex = 0
        Me.MenuItem83.Index = 2
        Me.MenuItem83.MakeCheckedMenuItemIconTransparent = False
        Me.MenuItem83.MakeTransparentIcon = False
        Me.MenuItem83.MenuBarItemBorderColor = System.Drawing.Color.Black
        Me.MenuItem83.MenuBarItemFillColor = System.Drawing.SystemColors.Menu
        Me.MenuItem83.MenuBarItemFillingStyle = UltimateMenus.KunalMenuItem.MenuBarFillStyles.FillColor
        Me.MenuItem83.MenuBarItemGradientColor1 = System.Drawing.SystemColors.Menu
        Me.MenuItem83.MenuBarItemGradientColor2 = System.Drawing.SystemColors.Menu
        Me.MenuItem83.MenuBarItemGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.MenuItem83.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem112, Me.MenuItem111, Me.MenuItem96, Me.MenuItem178, Me.MenuItem113, Me.MenuItem98, Me.MenuItem106, Me.MenuItem105, Me.MenuItem107, Me.MenuItem108, Me.MenuItem109, Me.MenuItem110, Me.MenuItem100, Me.MenuItem49})
        Me.MenuItem83.OwnerDraw = True
        Me.MenuItem83.PreDefinedHiLiteColors = UltimateMenus.KunalMenuItem.PreDefinedHighLightColors.Khaki
        Me.MenuItem83.PreDefinedHiLiteGradientColors = UltimateMenus.KunalMenuItem.PreDefinedGrHighLightColors.BrownWhite
        Me.MenuItem83.PreDefinedSideBarGradientColour = UltimateMenus.KunalMenuItem.PreDefinedSideBarGradientColors.ShineyBlueYellow
        Me.MenuItem83.ShowBorderAroundMenuBar = False
        Me.MenuItem83.ShowHiliteOverSideBar = False
        Me.MenuItem83.ShowShadowUnderMenuBar = True
        Me.MenuItem83.SideBarGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.MenuItem83.SideBarStyle = UltimateMenus.KunalMenuItem.SideBarDrawStyle.DefaultGradient
        Me.MenuItem83.Text = "&Master Settings"
        '
        'MenuItem112
        '
        Me.MenuItem112.CheckedImageIndex = 0
        Me.MenuItem112.CheckedMenuItemBackColor = System.Drawing.SystemColors.Control
        Me.MenuItem112.CheckedMenuItemBorderColor = System.Drawing.SystemColors.Control
        Me.MenuItem112.CheckedMenuItemDisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(197, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(184, Byte), Integer))
        Me.MenuItem112.CheckedMenuItemIconShadowColor = System.Drawing.Color.Gray
        Me.MenuItem112.CheckedMenuItemStyle = UltimateMenus.KunalMenuItem.CheckedMenuStyles.CheckedItemDefault
        Me.MenuItem112.CheckedMenuItemTickMarkColor = System.Drawing.SystemColors.Control
        Me.MenuItem112.FillMenuBarItem = False
        Me.MenuItem112.HighLightForeColor = System.Drawing.SystemColors.HighlightText
        Me.MenuItem112.HighLightScheme = UltimateMenus.KunalMenuItem.HighLightColorDrawStyle.DefaultScheme
        Me.MenuItem112.HiliteGradientColor1 = System.Drawing.Color.WhiteSmoke
        Me.MenuItem112.HiliteGradientColor2 = System.Drawing.Color.CornflowerBlue
        Me.MenuItem112.HiLiteGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.MenuItem112.IconShadowColor = System.Drawing.Color.Gray
        Me.MenuItem112.ImageIndex = 0
        Me.MenuItem112.Index = 0
        Me.MenuItem112.MakeCheckedMenuItemIconTransparent = False
        Me.MenuItem112.MakeTransparentIcon = False
        Me.MenuItem112.MenuBarItemBorderColor = System.Drawing.Color.Black
        Me.MenuItem112.MenuBarItemFillColor = System.Drawing.SystemColors.Menu
        Me.MenuItem112.MenuBarItemFillingStyle = UltimateMenus.KunalMenuItem.MenuBarFillStyles.FillColor
        Me.MenuItem112.MenuBarItemGradientColor1 = System.Drawing.SystemColors.Menu
        Me.MenuItem112.MenuBarItemGradientColor2 = System.Drawing.SystemColors.Menu
        Me.MenuItem112.MenuBarItemGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.MenuItem112.OwnerDraw = True
        Me.MenuItem112.PreDefinedHiLiteColors = UltimateMenus.KunalMenuItem.PreDefinedHighLightColors.Khaki
        Me.MenuItem112.PreDefinedHiLiteGradientColors = UltimateMenus.KunalMenuItem.PreDefinedGrHighLightColors.BrownWhite
        Me.MenuItem112.PreDefinedSideBarGradientColour = UltimateMenus.KunalMenuItem.PreDefinedSideBarGradientColors.ShineyBlueYellow
        Me.MenuItem112.ShowBorderAroundMenuBar = False
        Me.MenuItem112.ShowHiliteOverSideBar = False
        Me.MenuItem112.ShowShadowUnderMenuBar = True
        Me.MenuItem112.SideBarGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.MenuItem112.SideBarStyle = UltimateMenus.KunalMenuItem.SideBarDrawStyle.DefaultGradient
        Me.MenuItem112.Text = "City/ Area"
        Me.MenuItem112.Visible = False
        '
        'MenuItem111
        '
        Me.MenuItem111.CheckedImageIndex = 0
        Me.MenuItem111.CheckedMenuItemBackColor = System.Drawing.SystemColors.Control
        Me.MenuItem111.CheckedMenuItemBorderColor = System.Drawing.SystemColors.Control
        Me.MenuItem111.CheckedMenuItemDisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(197, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(184, Byte), Integer))
        Me.MenuItem111.CheckedMenuItemIconShadowColor = System.Drawing.Color.Gray
        Me.MenuItem111.CheckedMenuItemStyle = UltimateMenus.KunalMenuItem.CheckedMenuStyles.CheckedItemDefault
        Me.MenuItem111.CheckedMenuItemTickMarkColor = System.Drawing.SystemColors.Control
        Me.MenuItem111.FillMenuBarItem = False
        Me.MenuItem111.HighLightForeColor = System.Drawing.SystemColors.HighlightText
        Me.MenuItem111.HighLightScheme = UltimateMenus.KunalMenuItem.HighLightColorDrawStyle.DefaultScheme
        Me.MenuItem111.HiliteGradientColor1 = System.Drawing.Color.WhiteSmoke
        Me.MenuItem111.HiliteGradientColor2 = System.Drawing.Color.CornflowerBlue
        Me.MenuItem111.HiLiteGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.MenuItem111.IconShadowColor = System.Drawing.Color.Gray
        Me.MenuItem111.ImageIndex = 0
        Me.MenuItem111.Index = 1
        Me.MenuItem111.MakeCheckedMenuItemIconTransparent = False
        Me.MenuItem111.MakeTransparentIcon = False
        Me.MenuItem111.MenuBarItemBorderColor = System.Drawing.Color.Black
        Me.MenuItem111.MenuBarItemFillColor = System.Drawing.SystemColors.Menu
        Me.MenuItem111.MenuBarItemFillingStyle = UltimateMenus.KunalMenuItem.MenuBarFillStyles.FillColor
        Me.MenuItem111.MenuBarItemGradientColor1 = System.Drawing.SystemColors.Menu
        Me.MenuItem111.MenuBarItemGradientColor2 = System.Drawing.SystemColors.Menu
        Me.MenuItem111.MenuBarItemGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.MenuItem111.OwnerDraw = True
        Me.MenuItem111.PreDefinedHiLiteColors = UltimateMenus.KunalMenuItem.PreDefinedHighLightColors.Khaki
        Me.MenuItem111.PreDefinedHiLiteGradientColors = UltimateMenus.KunalMenuItem.PreDefinedGrHighLightColors.BrownWhite
        Me.MenuItem111.PreDefinedSideBarGradientColour = UltimateMenus.KunalMenuItem.PreDefinedSideBarGradientColors.ShineyBlueYellow
        Me.MenuItem111.ShowBorderAroundMenuBar = False
        Me.MenuItem111.ShowHiliteOverSideBar = False
        Me.MenuItem111.ShowShadowUnderMenuBar = True
        Me.MenuItem111.SideBarGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.MenuItem111.SideBarStyle = UltimateMenus.KunalMenuItem.SideBarDrawStyle.DefaultGradient
        Me.MenuItem111.Text = "Occupation"
        '
        'MenuItem96
        '
        Me.MenuItem96.CheckedImageIndex = 0
        Me.MenuItem96.CheckedMenuItemBackColor = System.Drawing.SystemColors.Control
        Me.MenuItem96.CheckedMenuItemBorderColor = System.Drawing.SystemColors.Control
        Me.MenuItem96.CheckedMenuItemDisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(197, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(184, Byte), Integer))
        Me.MenuItem96.CheckedMenuItemIconShadowColor = System.Drawing.Color.Gray
        Me.MenuItem96.CheckedMenuItemStyle = UltimateMenus.KunalMenuItem.CheckedMenuStyles.CheckedItemDefault
        Me.MenuItem96.CheckedMenuItemTickMarkColor = System.Drawing.SystemColors.Control
        Me.MenuItem96.FillMenuBarItem = False
        Me.MenuItem96.HighLightForeColor = System.Drawing.SystemColors.HighlightText
        Me.MenuItem96.HighLightScheme = UltimateMenus.KunalMenuItem.HighLightColorDrawStyle.DefaultScheme
        Me.MenuItem96.HiliteGradientColor1 = System.Drawing.Color.WhiteSmoke
        Me.MenuItem96.HiliteGradientColor2 = System.Drawing.Color.CornflowerBlue
        Me.MenuItem96.HiLiteGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.MenuItem96.IconShadowColor = System.Drawing.Color.Gray
        Me.MenuItem96.ImageIndex = 0
        Me.MenuItem96.Index = 2
        Me.MenuItem96.MakeCheckedMenuItemIconTransparent = False
        Me.MenuItem96.MakeTransparentIcon = False
        Me.MenuItem96.MenuBarItemBorderColor = System.Drawing.Color.Black
        Me.MenuItem96.MenuBarItemFillColor = System.Drawing.SystemColors.Menu
        Me.MenuItem96.MenuBarItemFillingStyle = UltimateMenus.KunalMenuItem.MenuBarFillStyles.FillColor
        Me.MenuItem96.MenuBarItemGradientColor1 = System.Drawing.SystemColors.Menu
        Me.MenuItem96.MenuBarItemGradientColor2 = System.Drawing.SystemColors.Menu
        Me.MenuItem96.MenuBarItemGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.MenuItem96.OwnerDraw = True
        Me.MenuItem96.PreDefinedHiLiteColors = UltimateMenus.KunalMenuItem.PreDefinedHighLightColors.Khaki
        Me.MenuItem96.PreDefinedHiLiteGradientColors = UltimateMenus.KunalMenuItem.PreDefinedGrHighLightColors.BrownWhite
        Me.MenuItem96.PreDefinedSideBarGradientColour = UltimateMenus.KunalMenuItem.PreDefinedSideBarGradientColors.ShineyBlueYellow
        Me.MenuItem96.ShowBorderAroundMenuBar = False
        Me.MenuItem96.ShowHiliteOverSideBar = False
        Me.MenuItem96.ShowShadowUnderMenuBar = True
        Me.MenuItem96.SideBarGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.MenuItem96.SideBarStyle = UltimateMenus.KunalMenuItem.SideBarDrawStyle.DefaultGradient
        Me.MenuItem96.Text = "Religion"
        '
        'MenuItem178
        '
        Me.MenuItem178.CheckedImageIndex = 0
        Me.MenuItem178.CheckedMenuItemBackColor = System.Drawing.SystemColors.Control
        Me.MenuItem178.CheckedMenuItemBorderColor = System.Drawing.SystemColors.Control
        Me.MenuItem178.CheckedMenuItemDisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(197, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(184, Byte), Integer))
        Me.MenuItem178.CheckedMenuItemIconShadowColor = System.Drawing.Color.Gray
        Me.MenuItem178.CheckedMenuItemStyle = UltimateMenus.KunalMenuItem.CheckedMenuStyles.CheckedItemDefault
        Me.MenuItem178.CheckedMenuItemTickMarkColor = System.Drawing.SystemColors.Control
        Me.MenuItem178.FillMenuBarItem = False
        Me.MenuItem178.HighLightForeColor = System.Drawing.SystemColors.HighlightText
        Me.MenuItem178.HighLightScheme = UltimateMenus.KunalMenuItem.HighLightColorDrawStyle.DefaultScheme
        Me.MenuItem178.HiliteGradientColor1 = System.Drawing.Color.WhiteSmoke
        Me.MenuItem178.HiliteGradientColor2 = System.Drawing.Color.CornflowerBlue
        Me.MenuItem178.HiLiteGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.MenuItem178.IconShadowColor = System.Drawing.Color.Gray
        Me.MenuItem178.ImageIndex = 0
        Me.MenuItem178.Index = 3
        Me.MenuItem178.MakeCheckedMenuItemIconTransparent = False
        Me.MenuItem178.MakeTransparentIcon = False
        Me.MenuItem178.MenuBarItemBorderColor = System.Drawing.Color.Black
        Me.MenuItem178.MenuBarItemFillColor = System.Drawing.SystemColors.Menu
        Me.MenuItem178.MenuBarItemFillingStyle = UltimateMenus.KunalMenuItem.MenuBarFillStyles.FillColor
        Me.MenuItem178.MenuBarItemGradientColor1 = System.Drawing.SystemColors.Menu
        Me.MenuItem178.MenuBarItemGradientColor2 = System.Drawing.SystemColors.Menu
        Me.MenuItem178.MenuBarItemGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.MenuItem178.OwnerDraw = True
        Me.MenuItem178.PreDefinedHiLiteColors = UltimateMenus.KunalMenuItem.PreDefinedHighLightColors.Khaki
        Me.MenuItem178.PreDefinedHiLiteGradientColors = UltimateMenus.KunalMenuItem.PreDefinedGrHighLightColors.BrownWhite
        Me.MenuItem178.PreDefinedSideBarGradientColour = UltimateMenus.KunalMenuItem.PreDefinedSideBarGradientColors.ShineyBlueYellow
        Me.MenuItem178.ShowBorderAroundMenuBar = False
        Me.MenuItem178.ShowHiliteOverSideBar = False
        Me.MenuItem178.ShowShadowUnderMenuBar = True
        Me.MenuItem178.SideBarGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.MenuItem178.SideBarStyle = UltimateMenus.KunalMenuItem.SideBarDrawStyle.DefaultGradient
        Me.MenuItem178.Text = "Relation"
        '
        'MenuItem113
        '
        Me.MenuItem113.CheckedImageIndex = 0
        Me.MenuItem113.CheckedMenuItemBackColor = System.Drawing.SystemColors.Control
        Me.MenuItem113.CheckedMenuItemBorderColor = System.Drawing.SystemColors.Control
        Me.MenuItem113.CheckedMenuItemDisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(197, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(184, Byte), Integer))
        Me.MenuItem113.CheckedMenuItemIconShadowColor = System.Drawing.Color.Gray
        Me.MenuItem113.CheckedMenuItemStyle = UltimateMenus.KunalMenuItem.CheckedMenuStyles.CheckedItemDefault
        Me.MenuItem113.CheckedMenuItemTickMarkColor = System.Drawing.SystemColors.Control
        Me.MenuItem113.FillMenuBarItem = False
        Me.MenuItem113.HighLightForeColor = System.Drawing.SystemColors.HighlightText
        Me.MenuItem113.HighLightScheme = UltimateMenus.KunalMenuItem.HighLightColorDrawStyle.DefaultScheme
        Me.MenuItem113.HiliteGradientColor1 = System.Drawing.Color.WhiteSmoke
        Me.MenuItem113.HiliteGradientColor2 = System.Drawing.Color.CornflowerBlue
        Me.MenuItem113.HiLiteGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.MenuItem113.IconShadowColor = System.Drawing.Color.Gray
        Me.MenuItem113.ImageIndex = 0
        Me.MenuItem113.Index = 4
        Me.MenuItem113.MakeCheckedMenuItemIconTransparent = False
        Me.MenuItem113.MakeTransparentIcon = False
        Me.MenuItem113.MenuBarItemBorderColor = System.Drawing.Color.Black
        Me.MenuItem113.MenuBarItemFillColor = System.Drawing.SystemColors.Menu
        Me.MenuItem113.MenuBarItemFillingStyle = UltimateMenus.KunalMenuItem.MenuBarFillStyles.FillColor
        Me.MenuItem113.MenuBarItemGradientColor1 = System.Drawing.SystemColors.Menu
        Me.MenuItem113.MenuBarItemGradientColor2 = System.Drawing.SystemColors.Menu
        Me.MenuItem113.MenuBarItemGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.MenuItem113.OwnerDraw = True
        Me.MenuItem113.PreDefinedHiLiteColors = UltimateMenus.KunalMenuItem.PreDefinedHighLightColors.Khaki
        Me.MenuItem113.PreDefinedHiLiteGradientColors = UltimateMenus.KunalMenuItem.PreDefinedGrHighLightColors.BrownWhite
        Me.MenuItem113.PreDefinedSideBarGradientColour = UltimateMenus.KunalMenuItem.PreDefinedSideBarGradientColors.ShineyBlueYellow
        Me.MenuItem113.ShowBorderAroundMenuBar = False
        Me.MenuItem113.ShowHiliteOverSideBar = False
        Me.MenuItem113.ShowShadowUnderMenuBar = True
        Me.MenuItem113.SideBarGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.MenuItem113.SideBarStyle = UltimateMenus.KunalMenuItem.SideBarDrawStyle.DefaultGradient
        Me.MenuItem113.Text = "Caste"
        '
        'MenuItem98
        '
        Me.MenuItem98.CheckedImageIndex = 0
        Me.MenuItem98.CheckedMenuItemBackColor = System.Drawing.SystemColors.Control
        Me.MenuItem98.CheckedMenuItemBorderColor = System.Drawing.SystemColors.Control
        Me.MenuItem98.CheckedMenuItemDisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(197, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(184, Byte), Integer))
        Me.MenuItem98.CheckedMenuItemIconShadowColor = System.Drawing.Color.Gray
        Me.MenuItem98.CheckedMenuItemStyle = UltimateMenus.KunalMenuItem.CheckedMenuStyles.CheckedItemDefault
        Me.MenuItem98.CheckedMenuItemTickMarkColor = System.Drawing.SystemColors.Control
        Me.MenuItem98.FillMenuBarItem = False
        Me.MenuItem98.HighLightForeColor = System.Drawing.SystemColors.HighlightText
        Me.MenuItem98.HighLightScheme = UltimateMenus.KunalMenuItem.HighLightColorDrawStyle.DefaultScheme
        Me.MenuItem98.HiliteGradientColor1 = System.Drawing.Color.WhiteSmoke
        Me.MenuItem98.HiliteGradientColor2 = System.Drawing.Color.CornflowerBlue
        Me.MenuItem98.HiLiteGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.MenuItem98.IconShadowColor = System.Drawing.Color.Gray
        Me.MenuItem98.ImageIndex = 0
        Me.MenuItem98.Index = 5
        Me.MenuItem98.MakeCheckedMenuItemIconTransparent = False
        Me.MenuItem98.MakeTransparentIcon = False
        Me.MenuItem98.MenuBarItemBorderColor = System.Drawing.Color.Black
        Me.MenuItem98.MenuBarItemFillColor = System.Drawing.SystemColors.Menu
        Me.MenuItem98.MenuBarItemFillingStyle = UltimateMenus.KunalMenuItem.MenuBarFillStyles.FillColor
        Me.MenuItem98.MenuBarItemGradientColor1 = System.Drawing.SystemColors.Menu
        Me.MenuItem98.MenuBarItemGradientColor2 = System.Drawing.SystemColors.Menu
        Me.MenuItem98.MenuBarItemGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.MenuItem98.OwnerDraw = True
        Me.MenuItem98.PreDefinedHiLiteColors = UltimateMenus.KunalMenuItem.PreDefinedHighLightColors.Khaki
        Me.MenuItem98.PreDefinedHiLiteGradientColors = UltimateMenus.KunalMenuItem.PreDefinedGrHighLightColors.BrownWhite
        Me.MenuItem98.PreDefinedSideBarGradientColour = UltimateMenus.KunalMenuItem.PreDefinedSideBarGradientColors.ShineyBlueYellow
        Me.MenuItem98.ShowBorderAroundMenuBar = False
        Me.MenuItem98.ShowHiliteOverSideBar = False
        Me.MenuItem98.ShowShadowUnderMenuBar = True
        Me.MenuItem98.SideBarGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.MenuItem98.SideBarStyle = UltimateMenus.KunalMenuItem.SideBarDrawStyle.DefaultGradient
        Me.MenuItem98.Text = "&Share Configuration"
        '
        'MenuItem106
        '
        Me.MenuItem106.CheckedImageIndex = 0
        Me.MenuItem106.CheckedMenuItemBackColor = System.Drawing.SystemColors.Control
        Me.MenuItem106.CheckedMenuItemBorderColor = System.Drawing.SystemColors.Control
        Me.MenuItem106.CheckedMenuItemDisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(197, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(184, Byte), Integer))
        Me.MenuItem106.CheckedMenuItemIconShadowColor = System.Drawing.Color.Gray
        Me.MenuItem106.CheckedMenuItemStyle = UltimateMenus.KunalMenuItem.CheckedMenuStyles.CheckedItemDefault
        Me.MenuItem106.CheckedMenuItemTickMarkColor = System.Drawing.SystemColors.Control
        Me.MenuItem106.FillMenuBarItem = False
        Me.MenuItem106.HighLightForeColor = System.Drawing.SystemColors.HighlightText
        Me.MenuItem106.HighLightScheme = UltimateMenus.KunalMenuItem.HighLightColorDrawStyle.DefaultScheme
        Me.MenuItem106.HiliteGradientColor1 = System.Drawing.Color.WhiteSmoke
        Me.MenuItem106.HiliteGradientColor2 = System.Drawing.Color.CornflowerBlue
        Me.MenuItem106.HiLiteGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.MenuItem106.IconShadowColor = System.Drawing.Color.Gray
        Me.MenuItem106.ImageIndex = 0
        Me.MenuItem106.Index = 6
        Me.MenuItem106.MakeCheckedMenuItemIconTransparent = False
        Me.MenuItem106.MakeTransparentIcon = False
        Me.MenuItem106.MenuBarItemBorderColor = System.Drawing.Color.Black
        Me.MenuItem106.MenuBarItemFillColor = System.Drawing.SystemColors.Menu
        Me.MenuItem106.MenuBarItemFillingStyle = UltimateMenus.KunalMenuItem.MenuBarFillStyles.FillColor
        Me.MenuItem106.MenuBarItemGradientColor1 = System.Drawing.SystemColors.Menu
        Me.MenuItem106.MenuBarItemGradientColor2 = System.Drawing.SystemColors.Menu
        Me.MenuItem106.MenuBarItemGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.MenuItem106.OwnerDraw = True
        Me.MenuItem106.PreDefinedHiLiteColors = UltimateMenus.KunalMenuItem.PreDefinedHighLightColors.Khaki
        Me.MenuItem106.PreDefinedHiLiteGradientColors = UltimateMenus.KunalMenuItem.PreDefinedGrHighLightColors.BrownWhite
        Me.MenuItem106.PreDefinedSideBarGradientColour = UltimateMenus.KunalMenuItem.PreDefinedSideBarGradientColors.ShineyBlueYellow
        Me.MenuItem106.ShowBorderAroundMenuBar = False
        Me.MenuItem106.ShowHiliteOverSideBar = False
        Me.MenuItem106.ShowShadowUnderMenuBar = True
        Me.MenuItem106.SideBarGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.MenuItem106.SideBarStyle = UltimateMenus.KunalMenuItem.SideBarDrawStyle.DefaultGradient
        Me.MenuItem106.Text = "SB Master Setting"
        '
        'MenuItem105
        '
        Me.MenuItem105.CheckedImageIndex = 0
        Me.MenuItem105.CheckedMenuItemBackColor = System.Drawing.SystemColors.Control
        Me.MenuItem105.CheckedMenuItemBorderColor = System.Drawing.SystemColors.Control
        Me.MenuItem105.CheckedMenuItemDisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(197, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(184, Byte), Integer))
        Me.MenuItem105.CheckedMenuItemIconShadowColor = System.Drawing.Color.Gray
        Me.MenuItem105.CheckedMenuItemStyle = UltimateMenus.KunalMenuItem.CheckedMenuStyles.CheckedItemDefault
        Me.MenuItem105.CheckedMenuItemTickMarkColor = System.Drawing.SystemColors.Control
        Me.MenuItem105.FillMenuBarItem = False
        Me.MenuItem105.HighLightForeColor = System.Drawing.SystemColors.HighlightText
        Me.MenuItem105.HighLightScheme = UltimateMenus.KunalMenuItem.HighLightColorDrawStyle.DefaultScheme
        Me.MenuItem105.HiliteGradientColor1 = System.Drawing.Color.WhiteSmoke
        Me.MenuItem105.HiliteGradientColor2 = System.Drawing.Color.CornflowerBlue
        Me.MenuItem105.HiLiteGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.MenuItem105.IconShadowColor = System.Drawing.Color.Gray
        Me.MenuItem105.ImageIndex = 0
        Me.MenuItem105.Index = 7
        Me.MenuItem105.MakeCheckedMenuItemIconTransparent = False
        Me.MenuItem105.MakeTransparentIcon = False
        Me.MenuItem105.MenuBarItemBorderColor = System.Drawing.Color.Black
        Me.MenuItem105.MenuBarItemFillColor = System.Drawing.SystemColors.Menu
        Me.MenuItem105.MenuBarItemFillingStyle = UltimateMenus.KunalMenuItem.MenuBarFillStyles.FillColor
        Me.MenuItem105.MenuBarItemGradientColor1 = System.Drawing.SystemColors.Menu
        Me.MenuItem105.MenuBarItemGradientColor2 = System.Drawing.SystemColors.Menu
        Me.MenuItem105.MenuBarItemGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.MenuItem105.OwnerDraw = True
        Me.MenuItem105.PreDefinedHiLiteColors = UltimateMenus.KunalMenuItem.PreDefinedHighLightColors.Khaki
        Me.MenuItem105.PreDefinedHiLiteGradientColors = UltimateMenus.KunalMenuItem.PreDefinedGrHighLightColors.BrownWhite
        Me.MenuItem105.PreDefinedSideBarGradientColour = UltimateMenus.KunalMenuItem.PreDefinedSideBarGradientColors.ShineyBlueYellow
        Me.MenuItem105.ShowBorderAroundMenuBar = False
        Me.MenuItem105.ShowHiliteOverSideBar = False
        Me.MenuItem105.ShowShadowUnderMenuBar = True
        Me.MenuItem105.SideBarGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.MenuItem105.SideBarStyle = UltimateMenus.KunalMenuItem.SideBarDrawStyle.DefaultGradient
        Me.MenuItem105.Text = "CA Master Setting"
        '
        'MenuItem107
        '
        Me.MenuItem107.CheckedImageIndex = 0
        Me.MenuItem107.CheckedMenuItemBackColor = System.Drawing.SystemColors.Control
        Me.MenuItem107.CheckedMenuItemBorderColor = System.Drawing.SystemColors.Control
        Me.MenuItem107.CheckedMenuItemDisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(197, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(184, Byte), Integer))
        Me.MenuItem107.CheckedMenuItemIconShadowColor = System.Drawing.Color.Gray
        Me.MenuItem107.CheckedMenuItemStyle = UltimateMenus.KunalMenuItem.CheckedMenuStyles.CheckedItemDefault
        Me.MenuItem107.CheckedMenuItemTickMarkColor = System.Drawing.SystemColors.Control
        Me.MenuItem107.FillMenuBarItem = False
        Me.MenuItem107.HighLightForeColor = System.Drawing.SystemColors.HighlightText
        Me.MenuItem107.HighLightScheme = UltimateMenus.KunalMenuItem.HighLightColorDrawStyle.DefaultScheme
        Me.MenuItem107.HiliteGradientColor1 = System.Drawing.Color.WhiteSmoke
        Me.MenuItem107.HiliteGradientColor2 = System.Drawing.Color.CornflowerBlue
        Me.MenuItem107.HiLiteGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.MenuItem107.IconShadowColor = System.Drawing.Color.Gray
        Me.MenuItem107.ImageIndex = 0
        Me.MenuItem107.Index = 8
        Me.MenuItem107.MakeCheckedMenuItemIconTransparent = False
        Me.MenuItem107.MakeTransparentIcon = False
        Me.MenuItem107.MenuBarItemBorderColor = System.Drawing.Color.Black
        Me.MenuItem107.MenuBarItemFillColor = System.Drawing.SystemColors.Menu
        Me.MenuItem107.MenuBarItemFillingStyle = UltimateMenus.KunalMenuItem.MenuBarFillStyles.FillColor
        Me.MenuItem107.MenuBarItemGradientColor1 = System.Drawing.SystemColors.Menu
        Me.MenuItem107.MenuBarItemGradientColor2 = System.Drawing.SystemColors.Menu
        Me.MenuItem107.MenuBarItemGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.MenuItem107.OwnerDraw = True
        Me.MenuItem107.PreDefinedHiLiteColors = UltimateMenus.KunalMenuItem.PreDefinedHighLightColors.Khaki
        Me.MenuItem107.PreDefinedHiLiteGradientColors = UltimateMenus.KunalMenuItem.PreDefinedGrHighLightColors.BrownWhite
        Me.MenuItem107.PreDefinedSideBarGradientColour = UltimateMenus.KunalMenuItem.PreDefinedSideBarGradientColors.ShineyBlueYellow
        Me.MenuItem107.ShowBorderAroundMenuBar = False
        Me.MenuItem107.ShowHiliteOverSideBar = False
        Me.MenuItem107.ShowShadowUnderMenuBar = True
        Me.MenuItem107.SideBarGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.MenuItem107.SideBarStyle = UltimateMenus.KunalMenuItem.SideBarDrawStyle.DefaultGradient
        Me.MenuItem107.Text = "FD Master Setting"
        '
        'MenuItem108
        '
        Me.MenuItem108.CheckedImageIndex = 0
        Me.MenuItem108.CheckedMenuItemBackColor = System.Drawing.SystemColors.Control
        Me.MenuItem108.CheckedMenuItemBorderColor = System.Drawing.SystemColors.Control
        Me.MenuItem108.CheckedMenuItemDisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(197, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(184, Byte), Integer))
        Me.MenuItem108.CheckedMenuItemIconShadowColor = System.Drawing.Color.Gray
        Me.MenuItem108.CheckedMenuItemStyle = UltimateMenus.KunalMenuItem.CheckedMenuStyles.CheckedItemDefault
        Me.MenuItem108.CheckedMenuItemTickMarkColor = System.Drawing.SystemColors.Control
        Me.MenuItem108.FillMenuBarItem = False
        Me.MenuItem108.HighLightForeColor = System.Drawing.SystemColors.HighlightText
        Me.MenuItem108.HighLightScheme = UltimateMenus.KunalMenuItem.HighLightColorDrawStyle.DefaultScheme
        Me.MenuItem108.HiliteGradientColor1 = System.Drawing.Color.WhiteSmoke
        Me.MenuItem108.HiliteGradientColor2 = System.Drawing.Color.CornflowerBlue
        Me.MenuItem108.HiLiteGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.MenuItem108.IconShadowColor = System.Drawing.Color.Gray
        Me.MenuItem108.ImageIndex = 0
        Me.MenuItem108.Index = 9
        Me.MenuItem108.MakeCheckedMenuItemIconTransparent = False
        Me.MenuItem108.MakeTransparentIcon = False
        Me.MenuItem108.MenuBarItemBorderColor = System.Drawing.Color.Black
        Me.MenuItem108.MenuBarItemFillColor = System.Drawing.SystemColors.Menu
        Me.MenuItem108.MenuBarItemFillingStyle = UltimateMenus.KunalMenuItem.MenuBarFillStyles.FillColor
        Me.MenuItem108.MenuBarItemGradientColor1 = System.Drawing.SystemColors.Menu
        Me.MenuItem108.MenuBarItemGradientColor2 = System.Drawing.SystemColors.Menu
        Me.MenuItem108.MenuBarItemGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.MenuItem108.OwnerDraw = True
        Me.MenuItem108.PreDefinedHiLiteColors = UltimateMenus.KunalMenuItem.PreDefinedHighLightColors.Khaki
        Me.MenuItem108.PreDefinedHiLiteGradientColors = UltimateMenus.KunalMenuItem.PreDefinedGrHighLightColors.BrownWhite
        Me.MenuItem108.PreDefinedSideBarGradientColour = UltimateMenus.KunalMenuItem.PreDefinedSideBarGradientColors.ShineyBlueYellow
        Me.MenuItem108.ShowBorderAroundMenuBar = False
        Me.MenuItem108.ShowHiliteOverSideBar = False
        Me.MenuItem108.ShowShadowUnderMenuBar = True
        Me.MenuItem108.SideBarGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.MenuItem108.SideBarStyle = UltimateMenus.KunalMenuItem.SideBarDrawStyle.DefaultGradient
        Me.MenuItem108.Text = "RD Configuration"
        Me.MenuItem108.Visible = False
        '
        'MenuItem109
        '
        Me.MenuItem109.CheckedImageIndex = 0
        Me.MenuItem109.CheckedMenuItemBackColor = System.Drawing.SystemColors.Control
        Me.MenuItem109.CheckedMenuItemBorderColor = System.Drawing.SystemColors.Control
        Me.MenuItem109.CheckedMenuItemDisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(197, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(184, Byte), Integer))
        Me.MenuItem109.CheckedMenuItemIconShadowColor = System.Drawing.Color.Gray
        Me.MenuItem109.CheckedMenuItemStyle = UltimateMenus.KunalMenuItem.CheckedMenuStyles.CheckedItemDefault
        Me.MenuItem109.CheckedMenuItemTickMarkColor = System.Drawing.SystemColors.Control
        Me.MenuItem109.FillMenuBarItem = False
        Me.MenuItem109.HighLightForeColor = System.Drawing.SystemColors.HighlightText
        Me.MenuItem109.HighLightScheme = UltimateMenus.KunalMenuItem.HighLightColorDrawStyle.DefaultScheme
        Me.MenuItem109.HiliteGradientColor1 = System.Drawing.Color.WhiteSmoke
        Me.MenuItem109.HiliteGradientColor2 = System.Drawing.Color.CornflowerBlue
        Me.MenuItem109.HiLiteGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.MenuItem109.IconShadowColor = System.Drawing.Color.Gray
        Me.MenuItem109.ImageIndex = 0
        Me.MenuItem109.Index = 10
        Me.MenuItem109.MakeCheckedMenuItemIconTransparent = False
        Me.MenuItem109.MakeTransparentIcon = False
        Me.MenuItem109.MenuBarItemBorderColor = System.Drawing.Color.Black
        Me.MenuItem109.MenuBarItemFillColor = System.Drawing.SystemColors.Menu
        Me.MenuItem109.MenuBarItemFillingStyle = UltimateMenus.KunalMenuItem.MenuBarFillStyles.FillColor
        Me.MenuItem109.MenuBarItemGradientColor1 = System.Drawing.SystemColors.Menu
        Me.MenuItem109.MenuBarItemGradientColor2 = System.Drawing.SystemColors.Menu
        Me.MenuItem109.MenuBarItemGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.MenuItem109.OwnerDraw = True
        Me.MenuItem109.PreDefinedHiLiteColors = UltimateMenus.KunalMenuItem.PreDefinedHighLightColors.Khaki
        Me.MenuItem109.PreDefinedHiLiteGradientColors = UltimateMenus.KunalMenuItem.PreDefinedGrHighLightColors.BrownWhite
        Me.MenuItem109.PreDefinedSideBarGradientColour = UltimateMenus.KunalMenuItem.PreDefinedSideBarGradientColors.ShineyBlueYellow
        Me.MenuItem109.ShowBorderAroundMenuBar = False
        Me.MenuItem109.ShowHiliteOverSideBar = False
        Me.MenuItem109.ShowShadowUnderMenuBar = True
        Me.MenuItem109.SideBarGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.MenuItem109.SideBarStyle = UltimateMenus.KunalMenuItem.SideBarDrawStyle.DefaultGradient
        Me.MenuItem109.Text = "RD Master Setting"
        '
        'MenuItem110
        '
        Me.MenuItem110.CheckedImageIndex = 0
        Me.MenuItem110.CheckedMenuItemBackColor = System.Drawing.SystemColors.Control
        Me.MenuItem110.CheckedMenuItemBorderColor = System.Drawing.SystemColors.Control
        Me.MenuItem110.CheckedMenuItemDisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(197, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(184, Byte), Integer))
        Me.MenuItem110.CheckedMenuItemIconShadowColor = System.Drawing.Color.Gray
        Me.MenuItem110.CheckedMenuItemStyle = UltimateMenus.KunalMenuItem.CheckedMenuStyles.CheckedItemDefault
        Me.MenuItem110.CheckedMenuItemTickMarkColor = System.Drawing.SystemColors.Control
        Me.MenuItem110.FillMenuBarItem = False
        Me.MenuItem110.HighLightForeColor = System.Drawing.SystemColors.HighlightText
        Me.MenuItem110.HighLightScheme = UltimateMenus.KunalMenuItem.HighLightColorDrawStyle.DefaultScheme
        Me.MenuItem110.HiliteGradientColor1 = System.Drawing.Color.WhiteSmoke
        Me.MenuItem110.HiliteGradientColor2 = System.Drawing.Color.CornflowerBlue
        Me.MenuItem110.HiLiteGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.MenuItem110.IconShadowColor = System.Drawing.Color.Gray
        Me.MenuItem110.ImageIndex = 0
        Me.MenuItem110.Index = 11
        Me.MenuItem110.MakeCheckedMenuItemIconTransparent = False
        Me.MenuItem110.MakeTransparentIcon = False
        Me.MenuItem110.MenuBarItemBorderColor = System.Drawing.Color.Black
        Me.MenuItem110.MenuBarItemFillColor = System.Drawing.SystemColors.Menu
        Me.MenuItem110.MenuBarItemFillingStyle = UltimateMenus.KunalMenuItem.MenuBarFillStyles.FillColor
        Me.MenuItem110.MenuBarItemGradientColor1 = System.Drawing.SystemColors.Menu
        Me.MenuItem110.MenuBarItemGradientColor2 = System.Drawing.SystemColors.Menu
        Me.MenuItem110.MenuBarItemGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.MenuItem110.OwnerDraw = True
        Me.MenuItem110.PreDefinedHiLiteColors = UltimateMenus.KunalMenuItem.PreDefinedHighLightColors.Khaki
        Me.MenuItem110.PreDefinedHiLiteGradientColors = UltimateMenus.KunalMenuItem.PreDefinedGrHighLightColors.BrownWhite
        Me.MenuItem110.PreDefinedSideBarGradientColour = UltimateMenus.KunalMenuItem.PreDefinedSideBarGradientColors.ShineyBlueYellow
        Me.MenuItem110.ShowBorderAroundMenuBar = False
        Me.MenuItem110.ShowHiliteOverSideBar = False
        Me.MenuItem110.ShowShadowUnderMenuBar = True
        Me.MenuItem110.SideBarGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.MenuItem110.SideBarStyle = UltimateMenus.KunalMenuItem.SideBarDrawStyle.DefaultGradient
        Me.MenuItem110.Text = "Pigmy Configuration"
        '
        'MenuItem100
        '
        Me.MenuItem100.CheckedImageIndex = 0
        Me.MenuItem100.CheckedMenuItemBackColor = System.Drawing.SystemColors.Control
        Me.MenuItem100.CheckedMenuItemBorderColor = System.Drawing.SystemColors.Control
        Me.MenuItem100.CheckedMenuItemDisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(197, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(184, Byte), Integer))
        Me.MenuItem100.CheckedMenuItemIconShadowColor = System.Drawing.Color.Gray
        Me.MenuItem100.CheckedMenuItemStyle = UltimateMenus.KunalMenuItem.CheckedMenuStyles.CheckedItemDefault
        Me.MenuItem100.CheckedMenuItemTickMarkColor = System.Drawing.SystemColors.Control
        Me.MenuItem100.FillMenuBarItem = False
        Me.MenuItem100.HighLightForeColor = System.Drawing.SystemColors.HighlightText
        Me.MenuItem100.HighLightScheme = UltimateMenus.KunalMenuItem.HighLightColorDrawStyle.DefaultScheme
        Me.MenuItem100.HiliteGradientColor1 = System.Drawing.Color.WhiteSmoke
        Me.MenuItem100.HiliteGradientColor2 = System.Drawing.Color.CornflowerBlue
        Me.MenuItem100.HiLiteGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.MenuItem100.IconShadowColor = System.Drawing.Color.Gray
        Me.MenuItem100.ImageIndex = 0
        Me.MenuItem100.Index = 12
        Me.MenuItem100.MakeCheckedMenuItemIconTransparent = False
        Me.MenuItem100.MakeTransparentIcon = False
        Me.MenuItem100.MenuBarItemBorderColor = System.Drawing.Color.Black
        Me.MenuItem100.MenuBarItemFillColor = System.Drawing.SystemColors.Menu
        Me.MenuItem100.MenuBarItemFillingStyle = UltimateMenus.KunalMenuItem.MenuBarFillStyles.FillColor
        Me.MenuItem100.MenuBarItemGradientColor1 = System.Drawing.SystemColors.Menu
        Me.MenuItem100.MenuBarItemGradientColor2 = System.Drawing.SystemColors.Menu
        Me.MenuItem100.MenuBarItemGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.MenuItem100.OwnerDraw = True
        Me.MenuItem100.PreDefinedHiLiteColors = UltimateMenus.KunalMenuItem.PreDefinedHighLightColors.Khaki
        Me.MenuItem100.PreDefinedHiLiteGradientColors = UltimateMenus.KunalMenuItem.PreDefinedGrHighLightColors.BrownWhite
        Me.MenuItem100.PreDefinedSideBarGradientColour = UltimateMenus.KunalMenuItem.PreDefinedSideBarGradientColors.ShineyBlueYellow
        Me.MenuItem100.ShowBorderAroundMenuBar = False
        Me.MenuItem100.ShowHiliteOverSideBar = False
        Me.MenuItem100.ShowShadowUnderMenuBar = True
        Me.MenuItem100.SideBarGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.MenuItem100.SideBarStyle = UltimateMenus.KunalMenuItem.SideBarDrawStyle.DefaultGradient
        Me.MenuItem100.Text = "Loan Intrest Setting"
        '
        'MenuItem49
        '
        Me.MenuItem49.CheckedImageIndex = 0
        Me.MenuItem49.CheckedMenuItemBackColor = System.Drawing.SystemColors.Control
        Me.MenuItem49.CheckedMenuItemBorderColor = System.Drawing.SystemColors.Control
        Me.MenuItem49.CheckedMenuItemDisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(197, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(184, Byte), Integer))
        Me.MenuItem49.CheckedMenuItemIconShadowColor = System.Drawing.Color.Gray
        Me.MenuItem49.CheckedMenuItemStyle = UltimateMenus.KunalMenuItem.CheckedMenuStyles.CheckedItemDefault
        Me.MenuItem49.CheckedMenuItemTickMarkColor = System.Drawing.SystemColors.Control
        Me.MenuItem49.FillMenuBarItem = False
        Me.MenuItem49.HighLightForeColor = System.Drawing.SystemColors.HighlightText
        Me.MenuItem49.HighLightScheme = UltimateMenus.KunalMenuItem.HighLightColorDrawStyle.DefaultScheme
        Me.MenuItem49.HiliteGradientColor1 = System.Drawing.Color.WhiteSmoke
        Me.MenuItem49.HiliteGradientColor2 = System.Drawing.Color.CornflowerBlue
        Me.MenuItem49.HiLiteGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.MenuItem49.IconShadowColor = System.Drawing.Color.Gray
        Me.MenuItem49.ImageIndex = 0
        Me.MenuItem49.Index = 13
        Me.MenuItem49.MakeCheckedMenuItemIconTransparent = False
        Me.MenuItem49.MakeTransparentIcon = False
        Me.MenuItem49.MenuBarItemBorderColor = System.Drawing.Color.Black
        Me.MenuItem49.MenuBarItemFillColor = System.Drawing.SystemColors.Menu
        Me.MenuItem49.MenuBarItemFillingStyle = UltimateMenus.KunalMenuItem.MenuBarFillStyles.FillColor
        Me.MenuItem49.MenuBarItemGradientColor1 = System.Drawing.SystemColors.Menu
        Me.MenuItem49.MenuBarItemGradientColor2 = System.Drawing.SystemColors.Menu
        Me.MenuItem49.MenuBarItemGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.MenuItem49.OwnerDraw = True
        Me.MenuItem49.PreDefinedHiLiteColors = UltimateMenus.KunalMenuItem.PreDefinedHighLightColors.Khaki
        Me.MenuItem49.PreDefinedHiLiteGradientColors = UltimateMenus.KunalMenuItem.PreDefinedGrHighLightColors.BrownWhite
        Me.MenuItem49.PreDefinedSideBarGradientColour = UltimateMenus.KunalMenuItem.PreDefinedSideBarGradientColors.ShineyBlueYellow
        Me.MenuItem49.ShowBorderAroundMenuBar = False
        Me.MenuItem49.ShowHiliteOverSideBar = False
        Me.MenuItem49.ShowShadowUnderMenuBar = True
        Me.MenuItem49.SideBarGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.MenuItem49.SideBarStyle = UltimateMenus.KunalMenuItem.SideBarDrawStyle.DefaultGradient
        Me.MenuItem49.Text = "Bank Charges for Loan"
        '
        'MenuItem84
        '
        Me.MenuItem84.CheckedImageIndex = 0
        Me.MenuItem84.CheckedMenuItemBackColor = System.Drawing.SystemColors.Control
        Me.MenuItem84.CheckedMenuItemBorderColor = System.Drawing.SystemColors.Control
        Me.MenuItem84.CheckedMenuItemDisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(197, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(184, Byte), Integer))
        Me.MenuItem84.CheckedMenuItemIconShadowColor = System.Drawing.Color.Gray
        Me.MenuItem84.CheckedMenuItemStyle = UltimateMenus.KunalMenuItem.CheckedMenuStyles.CheckedItemDefault
        Me.MenuItem84.CheckedMenuItemTickMarkColor = System.Drawing.SystemColors.Control
        Me.MenuItem84.FillMenuBarItem = False
        Me.MenuItem84.HighLightForeColor = System.Drawing.SystemColors.HighlightText
        Me.MenuItem84.HighLightScheme = UltimateMenus.KunalMenuItem.HighLightColorDrawStyle.DefaultScheme
        Me.MenuItem84.HiliteGradientColor1 = System.Drawing.Color.WhiteSmoke
        Me.MenuItem84.HiliteGradientColor2 = System.Drawing.Color.CornflowerBlue
        Me.MenuItem84.HiLiteGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.MenuItem84.IconShadowColor = System.Drawing.Color.Gray
        Me.MenuItem84.ImageIndex = 0
        Me.MenuItem84.Index = 3
        Me.MenuItem84.MakeCheckedMenuItemIconTransparent = False
        Me.MenuItem84.MakeTransparentIcon = False
        Me.MenuItem84.MenuBarItemBorderColor = System.Drawing.Color.Black
        Me.MenuItem84.MenuBarItemFillColor = System.Drawing.SystemColors.Menu
        Me.MenuItem84.MenuBarItemFillingStyle = UltimateMenus.KunalMenuItem.MenuBarFillStyles.FillColor
        Me.MenuItem84.MenuBarItemGradientColor1 = System.Drawing.SystemColors.Menu
        Me.MenuItem84.MenuBarItemGradientColor2 = System.Drawing.SystemColors.Menu
        Me.MenuItem84.MenuBarItemGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.MenuItem84.OwnerDraw = True
        Me.MenuItem84.PreDefinedHiLiteColors = UltimateMenus.KunalMenuItem.PreDefinedHighLightColors.Khaki
        Me.MenuItem84.PreDefinedHiLiteGradientColors = UltimateMenus.KunalMenuItem.PreDefinedGrHighLightColors.BrownWhite
        Me.MenuItem84.PreDefinedSideBarGradientColour = UltimateMenus.KunalMenuItem.PreDefinedSideBarGradientColors.ShineyBlueYellow
        Me.MenuItem84.ShowBorderAroundMenuBar = False
        Me.MenuItem84.ShowHiliteOverSideBar = False
        Me.MenuItem84.ShowShadowUnderMenuBar = True
        Me.MenuItem84.SideBarGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.MenuItem84.SideBarStyle = UltimateMenus.KunalMenuItem.SideBarDrawStyle.DefaultGradient
        Me.MenuItem84.Text = "&Day End"
        Me.MenuItem84.Visible = False
        '
        'MenuItem85
        '
        Me.MenuItem85.CheckedImageIndex = 0
        Me.MenuItem85.CheckedMenuItemBackColor = System.Drawing.SystemColors.Control
        Me.MenuItem85.CheckedMenuItemBorderColor = System.Drawing.SystemColors.Control
        Me.MenuItem85.CheckedMenuItemDisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(197, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(184, Byte), Integer))
        Me.MenuItem85.CheckedMenuItemIconShadowColor = System.Drawing.Color.Gray
        Me.MenuItem85.CheckedMenuItemStyle = UltimateMenus.KunalMenuItem.CheckedMenuStyles.CheckedItemDefault
        Me.MenuItem85.CheckedMenuItemTickMarkColor = System.Drawing.SystemColors.Control
        Me.MenuItem85.FillMenuBarItem = False
        Me.MenuItem85.HighLightForeColor = System.Drawing.SystemColors.HighlightText
        Me.MenuItem85.HighLightScheme = UltimateMenus.KunalMenuItem.HighLightColorDrawStyle.DefaultScheme
        Me.MenuItem85.HiliteGradientColor1 = System.Drawing.Color.WhiteSmoke
        Me.MenuItem85.HiliteGradientColor2 = System.Drawing.Color.CornflowerBlue
        Me.MenuItem85.HiLiteGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.MenuItem85.IconShadowColor = System.Drawing.Color.Gray
        Me.MenuItem85.ImageIndex = 0
        Me.MenuItem85.Index = 4
        Me.MenuItem85.MakeCheckedMenuItemIconTransparent = False
        Me.MenuItem85.MakeTransparentIcon = False
        Me.MenuItem85.MenuBarItemBorderColor = System.Drawing.Color.Black
        Me.MenuItem85.MenuBarItemFillColor = System.Drawing.SystemColors.Menu
        Me.MenuItem85.MenuBarItemFillingStyle = UltimateMenus.KunalMenuItem.MenuBarFillStyles.FillColor
        Me.MenuItem85.MenuBarItemGradientColor1 = System.Drawing.SystemColors.Menu
        Me.MenuItem85.MenuBarItemGradientColor2 = System.Drawing.SystemColors.Menu
        Me.MenuItem85.MenuBarItemGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.MenuItem85.OwnerDraw = True
        Me.MenuItem85.PreDefinedHiLiteColors = UltimateMenus.KunalMenuItem.PreDefinedHighLightColors.Khaki
        Me.MenuItem85.PreDefinedHiLiteGradientColors = UltimateMenus.KunalMenuItem.PreDefinedGrHighLightColors.BrownWhite
        Me.MenuItem85.PreDefinedSideBarGradientColour = UltimateMenus.KunalMenuItem.PreDefinedSideBarGradientColors.ShineyBlueYellow
        Me.MenuItem85.ShowBorderAroundMenuBar = False
        Me.MenuItem85.ShowHiliteOverSideBar = False
        Me.MenuItem85.ShowShadowUnderMenuBar = True
        Me.MenuItem85.SideBarGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.MenuItem85.SideBarStyle = UltimateMenus.KunalMenuItem.SideBarDrawStyle.DefaultGradient
        Me.MenuItem85.Text = "&Bank Details"
        '
        'MenuItem86
        '
        Me.MenuItem86.CheckedImageIndex = 0
        Me.MenuItem86.CheckedMenuItemBackColor = System.Drawing.SystemColors.Control
        Me.MenuItem86.CheckedMenuItemBorderColor = System.Drawing.SystemColors.Control
        Me.MenuItem86.CheckedMenuItemDisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(197, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(184, Byte), Integer))
        Me.MenuItem86.CheckedMenuItemIconShadowColor = System.Drawing.Color.Gray
        Me.MenuItem86.CheckedMenuItemStyle = UltimateMenus.KunalMenuItem.CheckedMenuStyles.CheckedItemDefault
        Me.MenuItem86.CheckedMenuItemTickMarkColor = System.Drawing.SystemColors.Control
        Me.MenuItem86.FillMenuBarItem = False
        Me.MenuItem86.HighLightForeColor = System.Drawing.SystemColors.HighlightText
        Me.MenuItem86.HighLightScheme = UltimateMenus.KunalMenuItem.HighLightColorDrawStyle.DefaultScheme
        Me.MenuItem86.HiliteGradientColor1 = System.Drawing.Color.WhiteSmoke
        Me.MenuItem86.HiliteGradientColor2 = System.Drawing.Color.CornflowerBlue
        Me.MenuItem86.HiLiteGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.MenuItem86.IconShadowColor = System.Drawing.Color.Gray
        Me.MenuItem86.ImageIndex = 0
        Me.MenuItem86.Index = 5
        Me.MenuItem86.MakeCheckedMenuItemIconTransparent = False
        Me.MenuItem86.MakeTransparentIcon = False
        Me.MenuItem86.MenuBarItemBorderColor = System.Drawing.Color.Black
        Me.MenuItem86.MenuBarItemFillColor = System.Drawing.SystemColors.Menu
        Me.MenuItem86.MenuBarItemFillingStyle = UltimateMenus.KunalMenuItem.MenuBarFillStyles.FillColor
        Me.MenuItem86.MenuBarItemGradientColor1 = System.Drawing.SystemColors.Menu
        Me.MenuItem86.MenuBarItemGradientColor2 = System.Drawing.SystemColors.Menu
        Me.MenuItem86.MenuBarItemGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.MenuItem86.OwnerDraw = True
        Me.MenuItem86.PreDefinedHiLiteColors = UltimateMenus.KunalMenuItem.PreDefinedHighLightColors.Khaki
        Me.MenuItem86.PreDefinedHiLiteGradientColors = UltimateMenus.KunalMenuItem.PreDefinedGrHighLightColors.BrownWhite
        Me.MenuItem86.PreDefinedSideBarGradientColour = UltimateMenus.KunalMenuItem.PreDefinedSideBarGradientColors.ShineyBlueYellow
        Me.MenuItem86.ShowBorderAroundMenuBar = False
        Me.MenuItem86.ShowHiliteOverSideBar = False
        Me.MenuItem86.ShowShadowUnderMenuBar = True
        Me.MenuItem86.SideBarGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.MenuItem86.SideBarStyle = UltimateMenus.KunalMenuItem.SideBarDrawStyle.DefaultGradient
        Me.MenuItem86.Text = "&Directors"
        Me.MenuItem86.Visible = False
        '
        'MenuItem141
        '
        Me.MenuItem141.CheckedImageIndex = 0
        Me.MenuItem141.CheckedMenuItemBackColor = System.Drawing.SystemColors.Control
        Me.MenuItem141.CheckedMenuItemBorderColor = System.Drawing.SystemColors.Control
        Me.MenuItem141.CheckedMenuItemDisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(197, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(184, Byte), Integer))
        Me.MenuItem141.CheckedMenuItemIconShadowColor = System.Drawing.Color.Gray
        Me.MenuItem141.CheckedMenuItemStyle = UltimateMenus.KunalMenuItem.CheckedMenuStyles.CheckedItemDefault
        Me.MenuItem141.CheckedMenuItemTickMarkColor = System.Drawing.SystemColors.Control
        Me.MenuItem141.FillMenuBarItem = False
        Me.MenuItem141.HighLightForeColor = System.Drawing.SystemColors.HighlightText
        Me.MenuItem141.HighLightScheme = UltimateMenus.KunalMenuItem.HighLightColorDrawStyle.DefaultScheme
        Me.MenuItem141.HiliteGradientColor1 = System.Drawing.Color.WhiteSmoke
        Me.MenuItem141.HiliteGradientColor2 = System.Drawing.Color.CornflowerBlue
        Me.MenuItem141.HiLiteGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.MenuItem141.IconShadowColor = System.Drawing.Color.Gray
        Me.MenuItem141.ImageIndex = 0
        Me.MenuItem141.Index = 6
        Me.MenuItem141.MakeCheckedMenuItemIconTransparent = False
        Me.MenuItem141.MakeTransparentIcon = False
        Me.MenuItem141.MenuBarItemBorderColor = System.Drawing.Color.Black
        Me.MenuItem141.MenuBarItemFillColor = System.Drawing.SystemColors.Menu
        Me.MenuItem141.MenuBarItemFillingStyle = UltimateMenus.KunalMenuItem.MenuBarFillStyles.FillColor
        Me.MenuItem141.MenuBarItemGradientColor1 = System.Drawing.SystemColors.Menu
        Me.MenuItem141.MenuBarItemGradientColor2 = System.Drawing.SystemColors.Menu
        Me.MenuItem141.MenuBarItemGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.MenuItem141.OwnerDraw = True
        Me.MenuItem141.PreDefinedHiLiteColors = UltimateMenus.KunalMenuItem.PreDefinedHighLightColors.Khaki
        Me.MenuItem141.PreDefinedHiLiteGradientColors = UltimateMenus.KunalMenuItem.PreDefinedGrHighLightColors.BrownWhite
        Me.MenuItem141.PreDefinedSideBarGradientColour = UltimateMenus.KunalMenuItem.PreDefinedSideBarGradientColors.ShineyBlueYellow
        Me.MenuItem141.Shortcut = System.Windows.Forms.Shortcut.F4
        Me.MenuItem141.ShowBorderAroundMenuBar = False
        Me.MenuItem141.ShowHiliteOverSideBar = False
        Me.MenuItem141.ShowShadowUnderMenuBar = True
        Me.MenuItem141.SideBarGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.MenuItem141.SideBarStyle = UltimateMenus.KunalMenuItem.SideBarDrawStyle.DefaultGradient
        Me.MenuItem141.Text = "Customer Master"
        '
        'MenuItem142
        '
        Me.MenuItem142.CheckedImageIndex = 0
        Me.MenuItem142.CheckedMenuItemBackColor = System.Drawing.SystemColors.Control
        Me.MenuItem142.CheckedMenuItemBorderColor = System.Drawing.SystemColors.Control
        Me.MenuItem142.CheckedMenuItemDisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(197, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(184, Byte), Integer))
        Me.MenuItem142.CheckedMenuItemIconShadowColor = System.Drawing.Color.Gray
        Me.MenuItem142.CheckedMenuItemStyle = UltimateMenus.KunalMenuItem.CheckedMenuStyles.CheckedItemDefault
        Me.MenuItem142.CheckedMenuItemTickMarkColor = System.Drawing.SystemColors.Control
        Me.MenuItem142.FillMenuBarItem = False
        Me.MenuItem142.HighLightForeColor = System.Drawing.SystemColors.HighlightText
        Me.MenuItem142.HighLightScheme = UltimateMenus.KunalMenuItem.HighLightColorDrawStyle.DefaultScheme
        Me.MenuItem142.HiliteGradientColor1 = System.Drawing.Color.WhiteSmoke
        Me.MenuItem142.HiliteGradientColor2 = System.Drawing.Color.CornflowerBlue
        Me.MenuItem142.HiLiteGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.MenuItem142.IconShadowColor = System.Drawing.Color.Gray
        Me.MenuItem142.ImageIndex = 0
        Me.MenuItem142.Index = 7
        Me.MenuItem142.MakeCheckedMenuItemIconTransparent = False
        Me.MenuItem142.MakeTransparentIcon = False
        Me.MenuItem142.MenuBarItemBorderColor = System.Drawing.Color.Black
        Me.MenuItem142.MenuBarItemFillColor = System.Drawing.SystemColors.Menu
        Me.MenuItem142.MenuBarItemFillingStyle = UltimateMenus.KunalMenuItem.MenuBarFillStyles.FillColor
        Me.MenuItem142.MenuBarItemGradientColor1 = System.Drawing.SystemColors.Menu
        Me.MenuItem142.MenuBarItemGradientColor2 = System.Drawing.SystemColors.Menu
        Me.MenuItem142.MenuBarItemGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.MenuItem142.OwnerDraw = True
        Me.MenuItem142.PreDefinedHiLiteColors = UltimateMenus.KunalMenuItem.PreDefinedHighLightColors.Khaki
        Me.MenuItem142.PreDefinedHiLiteGradientColors = UltimateMenus.KunalMenuItem.PreDefinedGrHighLightColors.BrownWhite
        Me.MenuItem142.PreDefinedSideBarGradientColour = UltimateMenus.KunalMenuItem.PreDefinedSideBarGradientColors.ShineyBlueYellow
        Me.MenuItem142.Shortcut = System.Windows.Forms.Shortcut.CtrlF4
        Me.MenuItem142.ShowBorderAroundMenuBar = False
        Me.MenuItem142.ShowHiliteOverSideBar = False
        Me.MenuItem142.ShowShadowUnderMenuBar = True
        Me.MenuItem142.SideBarGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.MenuItem142.SideBarStyle = UltimateMenus.KunalMenuItem.SideBarDrawStyle.DefaultGradient
        Me.MenuItem142.Text = "Customer List"
        '
        'MenuItem1
        '
        Me.MenuItem1.CheckedImageIndex = 0
        Me.MenuItem1.CheckedMenuItemBackColor = System.Drawing.SystemColors.Control
        Me.MenuItem1.CheckedMenuItemBorderColor = System.Drawing.SystemColors.Control
        Me.MenuItem1.CheckedMenuItemDisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(197, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(184, Byte), Integer))
        Me.MenuItem1.CheckedMenuItemIconShadowColor = System.Drawing.Color.Gray
        Me.MenuItem1.CheckedMenuItemStyle = UltimateMenus.KunalMenuItem.CheckedMenuStyles.CheckedItemDefault
        Me.MenuItem1.CheckedMenuItemTickMarkColor = System.Drawing.SystemColors.Control
        Me.MenuItem1.FillMenuBarItem = False
        Me.MenuItem1.HighLightForeColor = System.Drawing.SystemColors.HighlightText
        Me.MenuItem1.HighLightScheme = UltimateMenus.KunalMenuItem.HighLightColorDrawStyle.DefaultScheme
        Me.MenuItem1.HiliteGradientColor1 = System.Drawing.Color.WhiteSmoke
        Me.MenuItem1.HiliteGradientColor2 = System.Drawing.Color.CornflowerBlue
        Me.MenuItem1.HiLiteGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.MenuItem1.IconShadowColor = System.Drawing.Color.Gray
        Me.MenuItem1.ImageIndex = 0
        Me.MenuItem1.Index = 2
        Me.MenuItem1.MakeCheckedMenuItemIconTransparent = False
        Me.MenuItem1.MakeTransparentIcon = False
        Me.MenuItem1.MenuBarItemBorderColor = System.Drawing.Color.Black
        Me.MenuItem1.MenuBarItemFillColor = System.Drawing.SystemColors.Menu
        Me.MenuItem1.MenuBarItemFillingStyle = UltimateMenus.KunalMenuItem.MenuBarFillStyles.FillColor
        Me.MenuItem1.MenuBarItemGradientColor1 = System.Drawing.SystemColors.Menu
        Me.MenuItem1.MenuBarItemGradientColor2 = System.Drawing.SystemColors.Menu
        Me.MenuItem1.MenuBarItemGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.MenuItem1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem11, Me.smnuCloseMembership, Me.MenuItem27, Me.MenuItem137, Me.MenuItem170, Me.MenuItem181, Me.MenuItem182})
        Me.MenuItem1.OwnerDraw = True
        Me.MenuItem1.PreDefinedHiLiteColors = UltimateMenus.KunalMenuItem.PreDefinedHighLightColors.Khaki
        Me.MenuItem1.PreDefinedHiLiteGradientColors = UltimateMenus.KunalMenuItem.PreDefinedGrHighLightColors.BrownWhite
        Me.MenuItem1.PreDefinedSideBarGradientColour = UltimateMenus.KunalMenuItem.PreDefinedSideBarGradientColors.ShineyBlueYellow
        Me.MenuItem1.ShowBorderAroundMenuBar = False
        Me.MenuItem1.ShowHiliteOverSideBar = False
        Me.MenuItem1.ShowShadowUnderMenuBar = True
        Me.MenuItem1.SideBarGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.MenuItem1.SideBarStyle = UltimateMenus.KunalMenuItem.SideBarDrawStyle.DefaultGradient
        Me.MenuItem1.Text = "&Members"
        '
        'MenuItem11
        '
        Me.MenuItem11.CheckedImageIndex = 0
        Me.MenuItem11.CheckedMenuItemBackColor = System.Drawing.SystemColors.Control
        Me.MenuItem11.CheckedMenuItemBorderColor = System.Drawing.SystemColors.Control
        Me.MenuItem11.CheckedMenuItemDisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(197, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(184, Byte), Integer))
        Me.MenuItem11.CheckedMenuItemIconShadowColor = System.Drawing.Color.Gray
        Me.MenuItem11.CheckedMenuItemStyle = UltimateMenus.KunalMenuItem.CheckedMenuStyles.CheckedItemDefault
        Me.MenuItem11.CheckedMenuItemTickMarkColor = System.Drawing.SystemColors.Control
        Me.MenuItem11.FillMenuBarItem = False
        Me.MenuItem11.HighLightForeColor = System.Drawing.SystemColors.HighlightText
        Me.MenuItem11.HighLightScheme = UltimateMenus.KunalMenuItem.HighLightColorDrawStyle.DefaultScheme
        Me.MenuItem11.HiliteGradientColor1 = System.Drawing.Color.WhiteSmoke
        Me.MenuItem11.HiliteGradientColor2 = System.Drawing.Color.CornflowerBlue
        Me.MenuItem11.HiLiteGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.MenuItem11.IconShadowColor = System.Drawing.Color.Gray
        Me.MenuItem11.ImageIndex = 0
        Me.MenuItem11.Index = 0
        Me.MenuItem11.MakeCheckedMenuItemIconTransparent = False
        Me.MenuItem11.MakeTransparentIcon = False
        Me.MenuItem11.MenuBarItemBorderColor = System.Drawing.Color.Black
        Me.MenuItem11.MenuBarItemFillColor = System.Drawing.SystemColors.Menu
        Me.MenuItem11.MenuBarItemFillingStyle = UltimateMenus.KunalMenuItem.MenuBarFillStyles.FillColor
        Me.MenuItem11.MenuBarItemGradientColor1 = System.Drawing.SystemColors.Menu
        Me.MenuItem11.MenuBarItemGradientColor2 = System.Drawing.SystemColors.Menu
        Me.MenuItem11.MenuBarItemGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.MenuItem11.OwnerDraw = True
        Me.MenuItem11.PreDefinedHiLiteColors = UltimateMenus.KunalMenuItem.PreDefinedHighLightColors.Khaki
        Me.MenuItem11.PreDefinedHiLiteGradientColors = UltimateMenus.KunalMenuItem.PreDefinedGrHighLightColors.BrownWhite
        Me.MenuItem11.PreDefinedSideBarGradientColour = UltimateMenus.KunalMenuItem.PreDefinedSideBarGradientColors.ShineyBlueYellow
        Me.MenuItem11.Shortcut = System.Windows.Forms.Shortcut.F5
        Me.MenuItem11.ShowBorderAroundMenuBar = False
        Me.MenuItem11.ShowHiliteOverSideBar = False
        Me.MenuItem11.ShowShadowUnderMenuBar = True
        Me.MenuItem11.SideBarGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.MenuItem11.SideBarStyle = UltimateMenus.KunalMenuItem.SideBarDrawStyle.DefaultGradient
        Me.MenuItem11.Text = "New Member"
        '
        'smnuCloseMembership
        '
        Me.smnuCloseMembership.CheckedImageIndex = 0
        Me.smnuCloseMembership.CheckedMenuItemBackColor = System.Drawing.SystemColors.Control
        Me.smnuCloseMembership.CheckedMenuItemBorderColor = System.Drawing.SystemColors.Control
        Me.smnuCloseMembership.CheckedMenuItemDisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(197, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(184, Byte), Integer))
        Me.smnuCloseMembership.CheckedMenuItemIconShadowColor = System.Drawing.Color.Gray
        Me.smnuCloseMembership.CheckedMenuItemStyle = UltimateMenus.KunalMenuItem.CheckedMenuStyles.CheckedItemDefault
        Me.smnuCloseMembership.CheckedMenuItemTickMarkColor = System.Drawing.SystemColors.Control
        Me.smnuCloseMembership.FillMenuBarItem = False
        Me.smnuCloseMembership.HighLightForeColor = System.Drawing.SystemColors.HighlightText
        Me.smnuCloseMembership.HighLightScheme = UltimateMenus.KunalMenuItem.HighLightColorDrawStyle.DefaultScheme
        Me.smnuCloseMembership.HiliteGradientColor1 = System.Drawing.Color.WhiteSmoke
        Me.smnuCloseMembership.HiliteGradientColor2 = System.Drawing.Color.CornflowerBlue
        Me.smnuCloseMembership.HiLiteGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.smnuCloseMembership.IconShadowColor = System.Drawing.Color.Gray
        Me.smnuCloseMembership.ImageIndex = 0
        Me.smnuCloseMembership.Index = 1
        Me.smnuCloseMembership.MakeCheckedMenuItemIconTransparent = False
        Me.smnuCloseMembership.MakeTransparentIcon = False
        Me.smnuCloseMembership.MenuBarItemBorderColor = System.Drawing.Color.Black
        Me.smnuCloseMembership.MenuBarItemFillColor = System.Drawing.SystemColors.Menu
        Me.smnuCloseMembership.MenuBarItemFillingStyle = UltimateMenus.KunalMenuItem.MenuBarFillStyles.FillColor
        Me.smnuCloseMembership.MenuBarItemGradientColor1 = System.Drawing.SystemColors.Menu
        Me.smnuCloseMembership.MenuBarItemGradientColor2 = System.Drawing.SystemColors.Menu
        Me.smnuCloseMembership.MenuBarItemGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.smnuCloseMembership.OwnerDraw = True
        Me.smnuCloseMembership.PreDefinedHiLiteColors = UltimateMenus.KunalMenuItem.PreDefinedHighLightColors.Khaki
        Me.smnuCloseMembership.PreDefinedHiLiteGradientColors = UltimateMenus.KunalMenuItem.PreDefinedGrHighLightColors.BrownWhite
        Me.smnuCloseMembership.PreDefinedSideBarGradientColour = UltimateMenus.KunalMenuItem.PreDefinedSideBarGradientColors.ShineyBlueYellow
        Me.smnuCloseMembership.ShowBorderAroundMenuBar = False
        Me.smnuCloseMembership.ShowHiliteOverSideBar = False
        Me.smnuCloseMembership.ShowShadowUnderMenuBar = True
        Me.smnuCloseMembership.SideBarGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.smnuCloseMembership.SideBarStyle = UltimateMenus.KunalMenuItem.SideBarDrawStyle.DefaultGradient
        Me.smnuCloseMembership.Text = "Close Membership"
        '
        'MenuItem27
        '
        Me.MenuItem27.CheckedImageIndex = 0
        Me.MenuItem27.CheckedMenuItemBackColor = System.Drawing.SystemColors.Control
        Me.MenuItem27.CheckedMenuItemBorderColor = System.Drawing.SystemColors.Control
        Me.MenuItem27.CheckedMenuItemDisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(197, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(184, Byte), Integer))
        Me.MenuItem27.CheckedMenuItemIconShadowColor = System.Drawing.Color.Gray
        Me.MenuItem27.CheckedMenuItemStyle = UltimateMenus.KunalMenuItem.CheckedMenuStyles.CheckedItemDefault
        Me.MenuItem27.CheckedMenuItemTickMarkColor = System.Drawing.SystemColors.Control
        Me.MenuItem27.FillMenuBarItem = False
        Me.MenuItem27.HighLightForeColor = System.Drawing.SystemColors.HighlightText
        Me.MenuItem27.HighLightScheme = UltimateMenus.KunalMenuItem.HighLightColorDrawStyle.DefaultScheme
        Me.MenuItem27.HiliteGradientColor1 = System.Drawing.Color.WhiteSmoke
        Me.MenuItem27.HiliteGradientColor2 = System.Drawing.Color.CornflowerBlue
        Me.MenuItem27.HiLiteGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.MenuItem27.IconShadowColor = System.Drawing.Color.Gray
        Me.MenuItem27.ImageIndex = 0
        Me.MenuItem27.Index = 2
        Me.MenuItem27.MakeCheckedMenuItemIconTransparent = False
        Me.MenuItem27.MakeTransparentIcon = False
        Me.MenuItem27.MenuBarItemBorderColor = System.Drawing.Color.Black
        Me.MenuItem27.MenuBarItemFillColor = System.Drawing.SystemColors.Menu
        Me.MenuItem27.MenuBarItemFillingStyle = UltimateMenus.KunalMenuItem.MenuBarFillStyles.FillColor
        Me.MenuItem27.MenuBarItemGradientColor1 = System.Drawing.SystemColors.Menu
        Me.MenuItem27.MenuBarItemGradientColor2 = System.Drawing.SystemColors.Menu
        Me.MenuItem27.MenuBarItemGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.MenuItem27.OwnerDraw = True
        Me.MenuItem27.PreDefinedHiLiteColors = UltimateMenus.KunalMenuItem.PreDefinedHighLightColors.Khaki
        Me.MenuItem27.PreDefinedHiLiteGradientColors = UltimateMenus.KunalMenuItem.PreDefinedGrHighLightColors.BrownWhite
        Me.MenuItem27.PreDefinedSideBarGradientColour = UltimateMenus.KunalMenuItem.PreDefinedSideBarGradientColors.ShineyBlueYellow
        Me.MenuItem27.Shortcut = System.Windows.Forms.Shortcut.CtrlF5
        Me.MenuItem27.ShowBorderAroundMenuBar = False
        Me.MenuItem27.ShowHiliteOverSideBar = False
        Me.MenuItem27.ShowShadowUnderMenuBar = True
        Me.MenuItem27.SideBarGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.MenuItem27.SideBarStyle = UltimateMenus.KunalMenuItem.SideBarDrawStyle.DefaultGradient
        Me.MenuItem27.Text = "View Members"
        '
        'MenuItem137
        '
        Me.MenuItem137.CheckedImageIndex = 0
        Me.MenuItem137.CheckedMenuItemBackColor = System.Drawing.SystemColors.Control
        Me.MenuItem137.CheckedMenuItemBorderColor = System.Drawing.SystemColors.Control
        Me.MenuItem137.CheckedMenuItemDisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(197, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(184, Byte), Integer))
        Me.MenuItem137.CheckedMenuItemIconShadowColor = System.Drawing.Color.Gray
        Me.MenuItem137.CheckedMenuItemStyle = UltimateMenus.KunalMenuItem.CheckedMenuStyles.CheckedItemDefault
        Me.MenuItem137.CheckedMenuItemTickMarkColor = System.Drawing.SystemColors.Control
        Me.MenuItem137.FillMenuBarItem = False
        Me.MenuItem137.HighLightForeColor = System.Drawing.SystemColors.HighlightText
        Me.MenuItem137.HighLightScheme = UltimateMenus.KunalMenuItem.HighLightColorDrawStyle.DefaultScheme
        Me.MenuItem137.HiliteGradientColor1 = System.Drawing.Color.WhiteSmoke
        Me.MenuItem137.HiliteGradientColor2 = System.Drawing.Color.CornflowerBlue
        Me.MenuItem137.HiLiteGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.MenuItem137.IconShadowColor = System.Drawing.Color.Gray
        Me.MenuItem137.ImageIndex = 0
        Me.MenuItem137.Index = 3
        Me.MenuItem137.MakeCheckedMenuItemIconTransparent = False
        Me.MenuItem137.MakeTransparentIcon = False
        Me.MenuItem137.MenuBarItemBorderColor = System.Drawing.Color.Black
        Me.MenuItem137.MenuBarItemFillColor = System.Drawing.SystemColors.Menu
        Me.MenuItem137.MenuBarItemFillingStyle = UltimateMenus.KunalMenuItem.MenuBarFillStyles.FillColor
        Me.MenuItem137.MenuBarItemGradientColor1 = System.Drawing.SystemColors.Menu
        Me.MenuItem137.MenuBarItemGradientColor2 = System.Drawing.SystemColors.Menu
        Me.MenuItem137.MenuBarItemGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.MenuItem137.OwnerDraw = True
        Me.MenuItem137.PreDefinedHiLiteColors = UltimateMenus.KunalMenuItem.PreDefinedHighLightColors.Khaki
        Me.MenuItem137.PreDefinedHiLiteGradientColors = UltimateMenus.KunalMenuItem.PreDefinedGrHighLightColors.BrownWhite
        Me.MenuItem137.PreDefinedSideBarGradientColour = UltimateMenus.KunalMenuItem.PreDefinedSideBarGradientColors.ShineyBlueYellow
        Me.MenuItem137.ShowBorderAroundMenuBar = False
        Me.MenuItem137.ShowHiliteOverSideBar = False
        Me.MenuItem137.ShowShadowUnderMenuBar = True
        Me.MenuItem137.SideBarGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.MenuItem137.SideBarStyle = UltimateMenus.KunalMenuItem.SideBarDrawStyle.DefaultGradient
        Me.MenuItem137.Text = "Customer List"
        '
        'MenuItem170
        '
        Me.MenuItem170.CheckedImageIndex = 0
        Me.MenuItem170.CheckedMenuItemBackColor = System.Drawing.SystemColors.Control
        Me.MenuItem170.CheckedMenuItemBorderColor = System.Drawing.SystemColors.Control
        Me.MenuItem170.CheckedMenuItemDisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(197, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(184, Byte), Integer))
        Me.MenuItem170.CheckedMenuItemIconShadowColor = System.Drawing.Color.Gray
        Me.MenuItem170.CheckedMenuItemStyle = UltimateMenus.KunalMenuItem.CheckedMenuStyles.CheckedItemDefault
        Me.MenuItem170.CheckedMenuItemTickMarkColor = System.Drawing.SystemColors.Control
        Me.MenuItem170.FillMenuBarItem = False
        Me.MenuItem170.HighLightForeColor = System.Drawing.SystemColors.HighlightText
        Me.MenuItem170.HighLightScheme = UltimateMenus.KunalMenuItem.HighLightColorDrawStyle.DefaultScheme
        Me.MenuItem170.HiliteGradientColor1 = System.Drawing.Color.WhiteSmoke
        Me.MenuItem170.HiliteGradientColor2 = System.Drawing.Color.CornflowerBlue
        Me.MenuItem170.HiLiteGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.MenuItem170.IconShadowColor = System.Drawing.Color.Gray
        Me.MenuItem170.ImageIndex = 0
        Me.MenuItem170.Index = 4
        Me.MenuItem170.MakeCheckedMenuItemIconTransparent = False
        Me.MenuItem170.MakeTransparentIcon = False
        Me.MenuItem170.MenuBarItemBorderColor = System.Drawing.Color.Black
        Me.MenuItem170.MenuBarItemFillColor = System.Drawing.SystemColors.Menu
        Me.MenuItem170.MenuBarItemFillingStyle = UltimateMenus.KunalMenuItem.MenuBarFillStyles.FillColor
        Me.MenuItem170.MenuBarItemGradientColor1 = System.Drawing.SystemColors.Menu
        Me.MenuItem170.MenuBarItemGradientColor2 = System.Drawing.SystemColors.Menu
        Me.MenuItem170.MenuBarItemGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.MenuItem170.OwnerDraw = True
        Me.MenuItem170.PreDefinedHiLiteColors = UltimateMenus.KunalMenuItem.PreDefinedHighLightColors.Khaki
        Me.MenuItem170.PreDefinedHiLiteGradientColors = UltimateMenus.KunalMenuItem.PreDefinedGrHighLightColors.BrownWhite
        Me.MenuItem170.PreDefinedSideBarGradientColour = UltimateMenus.KunalMenuItem.PreDefinedSideBarGradientColors.ShineyBlueYellow
        Me.MenuItem170.ShowBorderAroundMenuBar = False
        Me.MenuItem170.ShowHiliteOverSideBar = False
        Me.MenuItem170.ShowShadowUnderMenuBar = True
        Me.MenuItem170.SideBarGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.MenuItem170.SideBarStyle = UltimateMenus.KunalMenuItem.SideBarDrawStyle.DefaultGradient
        Me.MenuItem170.Text = "Share Installment Deposit"
        '
        'MenuItem181
        '
        Me.MenuItem181.CheckedImageIndex = 0
        Me.MenuItem181.CheckedMenuItemBackColor = System.Drawing.SystemColors.Control
        Me.MenuItem181.CheckedMenuItemBorderColor = System.Drawing.SystemColors.Control
        Me.MenuItem181.CheckedMenuItemDisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(197, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(184, Byte), Integer))
        Me.MenuItem181.CheckedMenuItemIconShadowColor = System.Drawing.Color.Gray
        Me.MenuItem181.CheckedMenuItemStyle = UltimateMenus.KunalMenuItem.CheckedMenuStyles.CheckedItemDefault
        Me.MenuItem181.CheckedMenuItemTickMarkColor = System.Drawing.SystemColors.Control
        Me.MenuItem181.FillMenuBarItem = False
        Me.MenuItem181.HighLightForeColor = System.Drawing.SystemColors.HighlightText
        Me.MenuItem181.HighLightScheme = UltimateMenus.KunalMenuItem.HighLightColorDrawStyle.DefaultScheme
        Me.MenuItem181.HiliteGradientColor1 = System.Drawing.Color.WhiteSmoke
        Me.MenuItem181.HiliteGradientColor2 = System.Drawing.Color.CornflowerBlue
        Me.MenuItem181.HiLiteGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.MenuItem181.IconShadowColor = System.Drawing.Color.Gray
        Me.MenuItem181.ImageIndex = 0
        Me.MenuItem181.Index = 5
        Me.MenuItem181.MakeCheckedMenuItemIconTransparent = False
        Me.MenuItem181.MakeTransparentIcon = False
        Me.MenuItem181.MenuBarItemBorderColor = System.Drawing.Color.Black
        Me.MenuItem181.MenuBarItemFillColor = System.Drawing.SystemColors.Menu
        Me.MenuItem181.MenuBarItemFillingStyle = UltimateMenus.KunalMenuItem.MenuBarFillStyles.FillColor
        Me.MenuItem181.MenuBarItemGradientColor1 = System.Drawing.SystemColors.Menu
        Me.MenuItem181.MenuBarItemGradientColor2 = System.Drawing.SystemColors.Menu
        Me.MenuItem181.MenuBarItemGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.MenuItem181.OwnerDraw = True
        Me.MenuItem181.PreDefinedHiLiteColors = UltimateMenus.KunalMenuItem.PreDefinedHighLightColors.Khaki
        Me.MenuItem181.PreDefinedHiLiteGradientColors = UltimateMenus.KunalMenuItem.PreDefinedGrHighLightColors.BrownWhite
        Me.MenuItem181.PreDefinedSideBarGradientColour = UltimateMenus.KunalMenuItem.PreDefinedSideBarGradientColors.ShineyBlueYellow
        Me.MenuItem181.ShowBorderAroundMenuBar = False
        Me.MenuItem181.ShowHiliteOverSideBar = False
        Me.MenuItem181.ShowShadowUnderMenuBar = True
        Me.MenuItem181.SideBarGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.MenuItem181.SideBarStyle = UltimateMenus.KunalMenuItem.SideBarDrawStyle.DefaultGradient
        Me.MenuItem181.Text = "Member Label Printing"
        '
        'MenuItem182
        '
        Me.MenuItem182.CheckedImageIndex = 0
        Me.MenuItem182.CheckedMenuItemBackColor = System.Drawing.SystemColors.Control
        Me.MenuItem182.CheckedMenuItemBorderColor = System.Drawing.SystemColors.Control
        Me.MenuItem182.CheckedMenuItemDisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(197, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(184, Byte), Integer))
        Me.MenuItem182.CheckedMenuItemIconShadowColor = System.Drawing.Color.Gray
        Me.MenuItem182.CheckedMenuItemStyle = UltimateMenus.KunalMenuItem.CheckedMenuStyles.CheckedItemDefault
        Me.MenuItem182.CheckedMenuItemTickMarkColor = System.Drawing.SystemColors.Control
        Me.MenuItem182.FillMenuBarItem = False
        Me.MenuItem182.HighLightForeColor = System.Drawing.SystemColors.HighlightText
        Me.MenuItem182.HighLightScheme = UltimateMenus.KunalMenuItem.HighLightColorDrawStyle.DefaultScheme
        Me.MenuItem182.HiliteGradientColor1 = System.Drawing.Color.WhiteSmoke
        Me.MenuItem182.HiliteGradientColor2 = System.Drawing.Color.CornflowerBlue
        Me.MenuItem182.HiLiteGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.MenuItem182.IconShadowColor = System.Drawing.Color.Gray
        Me.MenuItem182.ImageIndex = 0
        Me.MenuItem182.Index = 6
        Me.MenuItem182.MakeCheckedMenuItemIconTransparent = False
        Me.MenuItem182.MakeTransparentIcon = False
        Me.MenuItem182.MenuBarItemBorderColor = System.Drawing.Color.Black
        Me.MenuItem182.MenuBarItemFillColor = System.Drawing.SystemColors.Menu
        Me.MenuItem182.MenuBarItemFillingStyle = UltimateMenus.KunalMenuItem.MenuBarFillStyles.FillColor
        Me.MenuItem182.MenuBarItemGradientColor1 = System.Drawing.SystemColors.Menu
        Me.MenuItem182.MenuBarItemGradientColor2 = System.Drawing.SystemColors.Menu
        Me.MenuItem182.MenuBarItemGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.MenuItem182.OwnerDraw = True
        Me.MenuItem182.PreDefinedHiLiteColors = UltimateMenus.KunalMenuItem.PreDefinedHighLightColors.Khaki
        Me.MenuItem182.PreDefinedHiLiteGradientColors = UltimateMenus.KunalMenuItem.PreDefinedGrHighLightColors.BrownWhite
        Me.MenuItem182.PreDefinedSideBarGradientColour = UltimateMenus.KunalMenuItem.PreDefinedSideBarGradientColors.ShineyBlueYellow
        Me.MenuItem182.ShowBorderAroundMenuBar = False
        Me.MenuItem182.ShowHiliteOverSideBar = False
        Me.MenuItem182.ShowShadowUnderMenuBar = True
        Me.MenuItem182.SideBarGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.MenuItem182.SideBarStyle = UltimateMenus.KunalMenuItem.SideBarDrawStyle.DefaultGradient
        Me.MenuItem182.Text = "Send Email To Members"
        '
        'MenuItem2
        '
        Me.MenuItem2.CheckedImageIndex = 0
        Me.MenuItem2.CheckedMenuItemBackColor = System.Drawing.SystemColors.Control
        Me.MenuItem2.CheckedMenuItemBorderColor = System.Drawing.SystemColors.Control
        Me.MenuItem2.CheckedMenuItemDisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(197, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(184, Byte), Integer))
        Me.MenuItem2.CheckedMenuItemIconShadowColor = System.Drawing.Color.Gray
        Me.MenuItem2.CheckedMenuItemStyle = UltimateMenus.KunalMenuItem.CheckedMenuStyles.CheckedItemDefault
        Me.MenuItem2.CheckedMenuItemTickMarkColor = System.Drawing.SystemColors.Control
        Me.MenuItem2.FillMenuBarItem = False
        Me.MenuItem2.HighLightForeColor = System.Drawing.SystemColors.HighlightText
        Me.MenuItem2.HighLightScheme = UltimateMenus.KunalMenuItem.HighLightColorDrawStyle.DefaultScheme
        Me.MenuItem2.HiliteGradientColor1 = System.Drawing.Color.WhiteSmoke
        Me.MenuItem2.HiliteGradientColor2 = System.Drawing.Color.CornflowerBlue
        Me.MenuItem2.HiLiteGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.MenuItem2.IconShadowColor = System.Drawing.Color.Gray
        Me.MenuItem2.ImageIndex = 0
        Me.MenuItem2.Index = 3
        Me.MenuItem2.MakeCheckedMenuItemIconTransparent = False
        Me.MenuItem2.MakeTransparentIcon = False
        Me.MenuItem2.MenuBarItemBorderColor = System.Drawing.Color.Black
        Me.MenuItem2.MenuBarItemFillColor = System.Drawing.SystemColors.Menu
        Me.MenuItem2.MenuBarItemFillingStyle = UltimateMenus.KunalMenuItem.MenuBarFillStyles.FillColor
        Me.MenuItem2.MenuBarItemGradientColor1 = System.Drawing.SystemColors.Menu
        Me.MenuItem2.MenuBarItemGradientColor2 = System.Drawing.SystemColors.Menu
        Me.MenuItem2.MenuBarItemGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.MenuItem2.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem14, Me.MenuItem15, Me.smnuTransferShares, Me.smnuDividend, Me.mnuViewShares, Me.smnuViewShares})
        Me.MenuItem2.OwnerDraw = True
        Me.MenuItem2.PreDefinedHiLiteColors = UltimateMenus.KunalMenuItem.PreDefinedHighLightColors.Khaki
        Me.MenuItem2.PreDefinedHiLiteGradientColors = UltimateMenus.KunalMenuItem.PreDefinedGrHighLightColors.BrownWhite
        Me.MenuItem2.PreDefinedSideBarGradientColour = UltimateMenus.KunalMenuItem.PreDefinedSideBarGradientColors.ShineyBlueYellow
        Me.MenuItem2.ShowBorderAroundMenuBar = False
        Me.MenuItem2.ShowHiliteOverSideBar = False
        Me.MenuItem2.ShowShadowUnderMenuBar = True
        Me.MenuItem2.SideBarGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.MenuItem2.SideBarStyle = UltimateMenus.KunalMenuItem.SideBarDrawStyle.DefaultGradient
        Me.MenuItem2.Text = "&Shares"
        '
        'MenuItem14
        '
        Me.MenuItem14.CheckedImageIndex = 0
        Me.MenuItem14.CheckedMenuItemBackColor = System.Drawing.SystemColors.Control
        Me.MenuItem14.CheckedMenuItemBorderColor = System.Drawing.SystemColors.Control
        Me.MenuItem14.CheckedMenuItemDisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(197, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(184, Byte), Integer))
        Me.MenuItem14.CheckedMenuItemIconShadowColor = System.Drawing.Color.Gray
        Me.MenuItem14.CheckedMenuItemStyle = UltimateMenus.KunalMenuItem.CheckedMenuStyles.CheckedItemDefault
        Me.MenuItem14.CheckedMenuItemTickMarkColor = System.Drawing.SystemColors.Control
        Me.MenuItem14.FillMenuBarItem = False
        Me.MenuItem14.HighLightForeColor = System.Drawing.SystemColors.HighlightText
        Me.MenuItem14.HighLightScheme = UltimateMenus.KunalMenuItem.HighLightColorDrawStyle.DefaultScheme
        Me.MenuItem14.HiliteGradientColor1 = System.Drawing.Color.WhiteSmoke
        Me.MenuItem14.HiliteGradientColor2 = System.Drawing.Color.CornflowerBlue
        Me.MenuItem14.HiLiteGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.MenuItem14.IconShadowColor = System.Drawing.Color.Gray
        Me.MenuItem14.ImageIndex = 0
        Me.MenuItem14.Index = 0
        Me.MenuItem14.MakeCheckedMenuItemIconTransparent = False
        Me.MenuItem14.MakeTransparentIcon = False
        Me.MenuItem14.MenuBarItemBorderColor = System.Drawing.Color.Black
        Me.MenuItem14.MenuBarItemFillColor = System.Drawing.SystemColors.Menu
        Me.MenuItem14.MenuBarItemFillingStyle = UltimateMenus.KunalMenuItem.MenuBarFillStyles.FillColor
        Me.MenuItem14.MenuBarItemGradientColor1 = System.Drawing.SystemColors.Menu
        Me.MenuItem14.MenuBarItemGradientColor2 = System.Drawing.SystemColors.Menu
        Me.MenuItem14.MenuBarItemGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.MenuItem14.OwnerDraw = True
        Me.MenuItem14.PreDefinedHiLiteColors = UltimateMenus.KunalMenuItem.PreDefinedHighLightColors.Khaki
        Me.MenuItem14.PreDefinedHiLiteGradientColors = UltimateMenus.KunalMenuItem.PreDefinedGrHighLightColors.BrownWhite
        Me.MenuItem14.PreDefinedSideBarGradientColour = UltimateMenus.KunalMenuItem.PreDefinedSideBarGradientColors.ShineyBlueYellow
        Me.MenuItem14.ShowBorderAroundMenuBar = False
        Me.MenuItem14.ShowHiliteOverSideBar = False
        Me.MenuItem14.ShowShadowUnderMenuBar = True
        Me.MenuItem14.SideBarGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.MenuItem14.SideBarStyle = UltimateMenus.KunalMenuItem.SideBarDrawStyle.DefaultGradient
        Me.MenuItem14.Text = "Remit Shares"
        '
        'MenuItem15
        '
        Me.MenuItem15.CheckedImageIndex = 0
        Me.MenuItem15.CheckedMenuItemBackColor = System.Drawing.SystemColors.Control
        Me.MenuItem15.CheckedMenuItemBorderColor = System.Drawing.SystemColors.Control
        Me.MenuItem15.CheckedMenuItemDisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(197, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(184, Byte), Integer))
        Me.MenuItem15.CheckedMenuItemIconShadowColor = System.Drawing.Color.Gray
        Me.MenuItem15.CheckedMenuItemStyle = UltimateMenus.KunalMenuItem.CheckedMenuStyles.CheckedItemDefault
        Me.MenuItem15.CheckedMenuItemTickMarkColor = System.Drawing.SystemColors.Control
        Me.MenuItem15.FillMenuBarItem = False
        Me.MenuItem15.HighLightForeColor = System.Drawing.SystemColors.HighlightText
        Me.MenuItem15.HighLightScheme = UltimateMenus.KunalMenuItem.HighLightColorDrawStyle.DefaultScheme
        Me.MenuItem15.HiliteGradientColor1 = System.Drawing.Color.WhiteSmoke
        Me.MenuItem15.HiliteGradientColor2 = System.Drawing.Color.CornflowerBlue
        Me.MenuItem15.HiLiteGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.MenuItem15.IconShadowColor = System.Drawing.Color.Gray
        Me.MenuItem15.ImageIndex = 0
        Me.MenuItem15.Index = 1
        Me.MenuItem15.MakeCheckedMenuItemIconTransparent = False
        Me.MenuItem15.MakeTransparentIcon = False
        Me.MenuItem15.MenuBarItemBorderColor = System.Drawing.Color.Black
        Me.MenuItem15.MenuBarItemFillColor = System.Drawing.SystemColors.Menu
        Me.MenuItem15.MenuBarItemFillingStyle = UltimateMenus.KunalMenuItem.MenuBarFillStyles.FillColor
        Me.MenuItem15.MenuBarItemGradientColor1 = System.Drawing.SystemColors.Menu
        Me.MenuItem15.MenuBarItemGradientColor2 = System.Drawing.SystemColors.Menu
        Me.MenuItem15.MenuBarItemGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.MenuItem15.OwnerDraw = True
        Me.MenuItem15.PreDefinedHiLiteColors = UltimateMenus.KunalMenuItem.PreDefinedHighLightColors.Khaki
        Me.MenuItem15.PreDefinedHiLiteGradientColors = UltimateMenus.KunalMenuItem.PreDefinedGrHighLightColors.BrownWhite
        Me.MenuItem15.PreDefinedSideBarGradientColour = UltimateMenus.KunalMenuItem.PreDefinedSideBarGradientColors.ShineyBlueYellow
        Me.MenuItem15.ShowBorderAroundMenuBar = False
        Me.MenuItem15.ShowHiliteOverSideBar = False
        Me.MenuItem15.ShowShadowUnderMenuBar = True
        Me.MenuItem15.SideBarGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.MenuItem15.SideBarStyle = UltimateMenus.KunalMenuItem.SideBarDrawStyle.DefaultGradient
        Me.MenuItem15.Text = "Refund Shares"
        '
        'smnuTransferShares
        '
        Me.smnuTransferShares.CheckedImageIndex = 0
        Me.smnuTransferShares.CheckedMenuItemBackColor = System.Drawing.SystemColors.Control
        Me.smnuTransferShares.CheckedMenuItemBorderColor = System.Drawing.SystemColors.Control
        Me.smnuTransferShares.CheckedMenuItemDisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(197, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(184, Byte), Integer))
        Me.smnuTransferShares.CheckedMenuItemIconShadowColor = System.Drawing.Color.Gray
        Me.smnuTransferShares.CheckedMenuItemStyle = UltimateMenus.KunalMenuItem.CheckedMenuStyles.CheckedItemDefault
        Me.smnuTransferShares.CheckedMenuItemTickMarkColor = System.Drawing.SystemColors.Control
        Me.smnuTransferShares.FillMenuBarItem = False
        Me.smnuTransferShares.HighLightForeColor = System.Drawing.SystemColors.HighlightText
        Me.smnuTransferShares.HighLightScheme = UltimateMenus.KunalMenuItem.HighLightColorDrawStyle.DefaultScheme
        Me.smnuTransferShares.HiliteGradientColor1 = System.Drawing.Color.WhiteSmoke
        Me.smnuTransferShares.HiliteGradientColor2 = System.Drawing.Color.CornflowerBlue
        Me.smnuTransferShares.HiLiteGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.smnuTransferShares.IconShadowColor = System.Drawing.Color.Gray
        Me.smnuTransferShares.ImageIndex = 0
        Me.smnuTransferShares.Index = 2
        Me.smnuTransferShares.MakeCheckedMenuItemIconTransparent = False
        Me.smnuTransferShares.MakeTransparentIcon = False
        Me.smnuTransferShares.MenuBarItemBorderColor = System.Drawing.Color.Black
        Me.smnuTransferShares.MenuBarItemFillColor = System.Drawing.SystemColors.Menu
        Me.smnuTransferShares.MenuBarItemFillingStyle = UltimateMenus.KunalMenuItem.MenuBarFillStyles.FillColor
        Me.smnuTransferShares.MenuBarItemGradientColor1 = System.Drawing.SystemColors.Menu
        Me.smnuTransferShares.MenuBarItemGradientColor2 = System.Drawing.SystemColors.Menu
        Me.smnuTransferShares.MenuBarItemGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.smnuTransferShares.OwnerDraw = True
        Me.smnuTransferShares.PreDefinedHiLiteColors = UltimateMenus.KunalMenuItem.PreDefinedHighLightColors.Khaki
        Me.smnuTransferShares.PreDefinedHiLiteGradientColors = UltimateMenus.KunalMenuItem.PreDefinedGrHighLightColors.BrownWhite
        Me.smnuTransferShares.PreDefinedSideBarGradientColour = UltimateMenus.KunalMenuItem.PreDefinedSideBarGradientColors.ShineyBlueYellow
        Me.smnuTransferShares.ShowBorderAroundMenuBar = False
        Me.smnuTransferShares.ShowHiliteOverSideBar = False
        Me.smnuTransferShares.ShowShadowUnderMenuBar = True
        Me.smnuTransferShares.SideBarGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.smnuTransferShares.SideBarStyle = UltimateMenus.KunalMenuItem.SideBarDrawStyle.DefaultGradient
        Me.smnuTransferShares.Text = "Transfer Shares"
        '
        'smnuDividend
        '
        Me.smnuDividend.CheckedImageIndex = 0
        Me.smnuDividend.CheckedMenuItemBackColor = System.Drawing.SystemColors.Control
        Me.smnuDividend.CheckedMenuItemBorderColor = System.Drawing.SystemColors.Control
        Me.smnuDividend.CheckedMenuItemDisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(197, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(184, Byte), Integer))
        Me.smnuDividend.CheckedMenuItemIconShadowColor = System.Drawing.Color.Gray
        Me.smnuDividend.CheckedMenuItemStyle = UltimateMenus.KunalMenuItem.CheckedMenuStyles.CheckedItemDefault
        Me.smnuDividend.CheckedMenuItemTickMarkColor = System.Drawing.SystemColors.Control
        Me.smnuDividend.FillMenuBarItem = False
        Me.smnuDividend.HighLightForeColor = System.Drawing.SystemColors.HighlightText
        Me.smnuDividend.HighLightScheme = UltimateMenus.KunalMenuItem.HighLightColorDrawStyle.DefaultScheme
        Me.smnuDividend.HiliteGradientColor1 = System.Drawing.Color.WhiteSmoke
        Me.smnuDividend.HiliteGradientColor2 = System.Drawing.Color.CornflowerBlue
        Me.smnuDividend.HiLiteGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.smnuDividend.IconShadowColor = System.Drawing.Color.Gray
        Me.smnuDividend.ImageIndex = 0
        Me.smnuDividend.Index = 3
        Me.smnuDividend.MakeCheckedMenuItemIconTransparent = False
        Me.smnuDividend.MakeTransparentIcon = False
        Me.smnuDividend.MenuBarItemBorderColor = System.Drawing.Color.Black
        Me.smnuDividend.MenuBarItemFillColor = System.Drawing.SystemColors.Menu
        Me.smnuDividend.MenuBarItemFillingStyle = UltimateMenus.KunalMenuItem.MenuBarFillStyles.FillColor
        Me.smnuDividend.MenuBarItemGradientColor1 = System.Drawing.SystemColors.Menu
        Me.smnuDividend.MenuBarItemGradientColor2 = System.Drawing.SystemColors.Menu
        Me.smnuDividend.MenuBarItemGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.smnuDividend.OwnerDraw = True
        Me.smnuDividend.PreDefinedHiLiteColors = UltimateMenus.KunalMenuItem.PreDefinedHighLightColors.Khaki
        Me.smnuDividend.PreDefinedHiLiteGradientColors = UltimateMenus.KunalMenuItem.PreDefinedGrHighLightColors.BrownWhite
        Me.smnuDividend.PreDefinedSideBarGradientColour = UltimateMenus.KunalMenuItem.PreDefinedSideBarGradientColors.ShineyBlueYellow
        Me.smnuDividend.ShowBorderAroundMenuBar = False
        Me.smnuDividend.ShowHiliteOverSideBar = False
        Me.smnuDividend.ShowShadowUnderMenuBar = True
        Me.smnuDividend.SideBarGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.smnuDividend.SideBarStyle = UltimateMenus.KunalMenuItem.SideBarDrawStyle.DefaultGradient
        Me.smnuDividend.Text = "Dividend "
        '
        'mnuViewShares
        '
        Me.mnuViewShares.CheckedImageIndex = 0
        Me.mnuViewShares.CheckedMenuItemBackColor = System.Drawing.SystemColors.Control
        Me.mnuViewShares.CheckedMenuItemBorderColor = System.Drawing.SystemColors.Control
        Me.mnuViewShares.CheckedMenuItemDisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(197, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(184, Byte), Integer))
        Me.mnuViewShares.CheckedMenuItemIconShadowColor = System.Drawing.Color.Gray
        Me.mnuViewShares.CheckedMenuItemStyle = UltimateMenus.KunalMenuItem.CheckedMenuStyles.CheckedItemDefault
        Me.mnuViewShares.CheckedMenuItemTickMarkColor = System.Drawing.SystemColors.Control
        Me.mnuViewShares.FillMenuBarItem = False
        Me.mnuViewShares.HighLightForeColor = System.Drawing.SystemColors.HighlightText
        Me.mnuViewShares.HighLightScheme = UltimateMenus.KunalMenuItem.HighLightColorDrawStyle.DefaultScheme
        Me.mnuViewShares.HiliteGradientColor1 = System.Drawing.Color.WhiteSmoke
        Me.mnuViewShares.HiliteGradientColor2 = System.Drawing.Color.CornflowerBlue
        Me.mnuViewShares.HiLiteGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.mnuViewShares.IconShadowColor = System.Drawing.Color.Gray
        Me.mnuViewShares.ImageIndex = 0
        Me.mnuViewShares.Index = 4
        Me.mnuViewShares.MakeCheckedMenuItemIconTransparent = False
        Me.mnuViewShares.MakeTransparentIcon = False
        Me.mnuViewShares.MenuBarItemBorderColor = System.Drawing.Color.Black
        Me.mnuViewShares.MenuBarItemFillColor = System.Drawing.SystemColors.Menu
        Me.mnuViewShares.MenuBarItemFillingStyle = UltimateMenus.KunalMenuItem.MenuBarFillStyles.FillColor
        Me.mnuViewShares.MenuBarItemGradientColor1 = System.Drawing.SystemColors.Menu
        Me.mnuViewShares.MenuBarItemGradientColor2 = System.Drawing.SystemColors.Menu
        Me.mnuViewShares.MenuBarItemGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.mnuViewShares.OwnerDraw = True
        Me.mnuViewShares.PreDefinedHiLiteColors = UltimateMenus.KunalMenuItem.PreDefinedHighLightColors.Khaki
        Me.mnuViewShares.PreDefinedHiLiteGradientColors = UltimateMenus.KunalMenuItem.PreDefinedGrHighLightColors.BrownWhite
        Me.mnuViewShares.PreDefinedSideBarGradientColour = UltimateMenus.KunalMenuItem.PreDefinedSideBarGradientColors.ShineyBlueYellow
        Me.mnuViewShares.ShowBorderAroundMenuBar = False
        Me.mnuViewShares.ShowHiliteOverSideBar = False
        Me.mnuViewShares.ShowShadowUnderMenuBar = True
        Me.mnuViewShares.SideBarGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.mnuViewShares.SideBarStyle = UltimateMenus.KunalMenuItem.SideBarDrawStyle.DefaultGradient
        Me.mnuViewShares.Text = "View Shares "
        '
        'smnuViewShares
        '
        Me.smnuViewShares.CheckedImageIndex = 0
        Me.smnuViewShares.CheckedMenuItemBackColor = System.Drawing.SystemColors.Control
        Me.smnuViewShares.CheckedMenuItemBorderColor = System.Drawing.SystemColors.Control
        Me.smnuViewShares.CheckedMenuItemDisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(197, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(184, Byte), Integer))
        Me.smnuViewShares.CheckedMenuItemIconShadowColor = System.Drawing.Color.Gray
        Me.smnuViewShares.CheckedMenuItemStyle = UltimateMenus.KunalMenuItem.CheckedMenuStyles.CheckedItemDefault
        Me.smnuViewShares.CheckedMenuItemTickMarkColor = System.Drawing.SystemColors.Control
        Me.smnuViewShares.FillMenuBarItem = False
        Me.smnuViewShares.HighLightForeColor = System.Drawing.SystemColors.HighlightText
        Me.smnuViewShares.HighLightScheme = UltimateMenus.KunalMenuItem.HighLightColorDrawStyle.DefaultScheme
        Me.smnuViewShares.HiliteGradientColor1 = System.Drawing.Color.WhiteSmoke
        Me.smnuViewShares.HiliteGradientColor2 = System.Drawing.Color.CornflowerBlue
        Me.smnuViewShares.HiLiteGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.smnuViewShares.IconShadowColor = System.Drawing.Color.Gray
        Me.smnuViewShares.ImageIndex = 0
        Me.smnuViewShares.Index = 5
        Me.smnuViewShares.MakeCheckedMenuItemIconTransparent = False
        Me.smnuViewShares.MakeTransparentIcon = False
        Me.smnuViewShares.MenuBarItemBorderColor = System.Drawing.Color.Black
        Me.smnuViewShares.MenuBarItemFillColor = System.Drawing.SystemColors.Menu
        Me.smnuViewShares.MenuBarItemFillingStyle = UltimateMenus.KunalMenuItem.MenuBarFillStyles.FillColor
        Me.smnuViewShares.MenuBarItemGradientColor1 = System.Drawing.SystemColors.Menu
        Me.smnuViewShares.MenuBarItemGradientColor2 = System.Drawing.SystemColors.Menu
        Me.smnuViewShares.MenuBarItemGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.smnuViewShares.OwnerDraw = True
        Me.smnuViewShares.PreDefinedHiLiteColors = UltimateMenus.KunalMenuItem.PreDefinedHighLightColors.Khaki
        Me.smnuViewShares.PreDefinedHiLiteGradientColors = UltimateMenus.KunalMenuItem.PreDefinedGrHighLightColors.BrownWhite
        Me.smnuViewShares.PreDefinedSideBarGradientColour = UltimateMenus.KunalMenuItem.PreDefinedSideBarGradientColors.ShineyBlueYellow
        Me.smnuViewShares.ShowBorderAroundMenuBar = False
        Me.smnuViewShares.ShowHiliteOverSideBar = False
        Me.smnuViewShares.ShowShadowUnderMenuBar = True
        Me.smnuViewShares.SideBarGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.smnuViewShares.SideBarStyle = UltimateMenus.KunalMenuItem.SideBarDrawStyle.DefaultGradient
        Me.smnuViewShares.Text = "View Shares Transactions"
        '
        'MenuItem54
        '
        Me.MenuItem54.CheckedImageIndex = 0
        Me.MenuItem54.CheckedMenuItemBackColor = System.Drawing.SystemColors.Control
        Me.MenuItem54.CheckedMenuItemBorderColor = System.Drawing.SystemColors.Control
        Me.MenuItem54.CheckedMenuItemDisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(197, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(184, Byte), Integer))
        Me.MenuItem54.CheckedMenuItemIconShadowColor = System.Drawing.Color.Gray
        Me.MenuItem54.CheckedMenuItemStyle = UltimateMenus.KunalMenuItem.CheckedMenuStyles.CheckedItemDefault
        Me.MenuItem54.CheckedMenuItemTickMarkColor = System.Drawing.SystemColors.Control
        Me.MenuItem54.FillMenuBarItem = False
        Me.MenuItem54.HighLightForeColor = System.Drawing.SystemColors.HighlightText
        Me.MenuItem54.HighLightScheme = UltimateMenus.KunalMenuItem.HighLightColorDrawStyle.DefaultScheme
        Me.MenuItem54.HiliteGradientColor1 = System.Drawing.Color.WhiteSmoke
        Me.MenuItem54.HiliteGradientColor2 = System.Drawing.Color.CornflowerBlue
        Me.MenuItem54.HiLiteGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.MenuItem54.IconShadowColor = System.Drawing.Color.Gray
        Me.MenuItem54.ImageIndex = 0
        Me.MenuItem54.Index = 4
        Me.MenuItem54.MakeCheckedMenuItemIconTransparent = False
        Me.MenuItem54.MakeTransparentIcon = False
        Me.MenuItem54.MenuBarItemBorderColor = System.Drawing.Color.Black
        Me.MenuItem54.MenuBarItemFillColor = System.Drawing.SystemColors.Menu
        Me.MenuItem54.MenuBarItemFillingStyle = UltimateMenus.KunalMenuItem.MenuBarFillStyles.FillColor
        Me.MenuItem54.MenuBarItemGradientColor1 = System.Drawing.SystemColors.Menu
        Me.MenuItem54.MenuBarItemGradientColor2 = System.Drawing.SystemColors.Menu
        Me.MenuItem54.MenuBarItemGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.MenuItem54.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem3, Me.MenuItem12})
        Me.MenuItem54.OwnerDraw = True
        Me.MenuItem54.PreDefinedHiLiteColors = UltimateMenus.KunalMenuItem.PreDefinedHighLightColors.Khaki
        Me.MenuItem54.PreDefinedHiLiteGradientColors = UltimateMenus.KunalMenuItem.PreDefinedGrHighLightColors.BrownWhite
        Me.MenuItem54.PreDefinedSideBarGradientColour = UltimateMenus.KunalMenuItem.PreDefinedSideBarGradientColors.ShineyBlueYellow
        Me.MenuItem54.ShowBorderAroundMenuBar = False
        Me.MenuItem54.ShowHiliteOverSideBar = False
        Me.MenuItem54.ShowShadowUnderMenuBar = True
        Me.MenuItem54.SideBarGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.MenuItem54.SideBarStyle = UltimateMenus.KunalMenuItem.SideBarDrawStyle.DefaultGradient
        Me.MenuItem54.Text = " A&ccounts"
        '
        'MenuItem3
        '
        Me.MenuItem3.CheckedImageIndex = 0
        Me.MenuItem3.CheckedMenuItemBackColor = System.Drawing.SystemColors.Control
        Me.MenuItem3.CheckedMenuItemBorderColor = System.Drawing.SystemColors.Control
        Me.MenuItem3.CheckedMenuItemDisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(197, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(184, Byte), Integer))
        Me.MenuItem3.CheckedMenuItemIconShadowColor = System.Drawing.Color.Gray
        Me.MenuItem3.CheckedMenuItemStyle = UltimateMenus.KunalMenuItem.CheckedMenuStyles.CheckedItemDefault
        Me.MenuItem3.CheckedMenuItemTickMarkColor = System.Drawing.SystemColors.Control
        Me.MenuItem3.FillMenuBarItem = False
        Me.MenuItem3.HighLightForeColor = System.Drawing.SystemColors.HighlightText
        Me.MenuItem3.HighLightScheme = UltimateMenus.KunalMenuItem.HighLightColorDrawStyle.DefaultScheme
        Me.MenuItem3.HiliteGradientColor1 = System.Drawing.Color.WhiteSmoke
        Me.MenuItem3.HiliteGradientColor2 = System.Drawing.Color.CornflowerBlue
        Me.MenuItem3.HiLiteGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.MenuItem3.IconShadowColor = System.Drawing.Color.Gray
        Me.MenuItem3.ImageIndex = 0
        Me.MenuItem3.Index = 0
        Me.MenuItem3.MakeCheckedMenuItemIconTransparent = False
        Me.MenuItem3.MakeTransparentIcon = False
        Me.MenuItem3.MenuBarItemBorderColor = System.Drawing.Color.Black
        Me.MenuItem3.MenuBarItemFillColor = System.Drawing.SystemColors.Menu
        Me.MenuItem3.MenuBarItemFillingStyle = UltimateMenus.KunalMenuItem.MenuBarFillStyles.FillColor
        Me.MenuItem3.MenuBarItemGradientColor1 = System.Drawing.SystemColors.Menu
        Me.MenuItem3.MenuBarItemGradientColor2 = System.Drawing.SystemColors.Menu
        Me.MenuItem3.MenuBarItemGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.MenuItem3.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem13, Me.MenuItem17, Me.MenuItem18, Me.MenuItem114, Me.MenuItem19, Me.MenuItem55, Me.MenuItem20, Me.MenuItem21, Me.MenuItem22, Me.MenuItem23, Me.MenuItem24, Me.MenuItem25, Me.MenuItem26, Me.MenuItem28, Me.MenuItem101})
        Me.MenuItem3.OwnerDraw = True
        Me.MenuItem3.PreDefinedHiLiteColors = UltimateMenus.KunalMenuItem.PreDefinedHighLightColors.Khaki
        Me.MenuItem3.PreDefinedHiLiteGradientColors = UltimateMenus.KunalMenuItem.PreDefinedGrHighLightColors.BrownWhite
        Me.MenuItem3.PreDefinedSideBarGradientColour = UltimateMenus.KunalMenuItem.PreDefinedSideBarGradientColors.ShineyBlueYellow
        Me.MenuItem3.ShowBorderAroundMenuBar = False
        Me.MenuItem3.ShowHiliteOverSideBar = False
        Me.MenuItem3.ShowShadowUnderMenuBar = True
        Me.MenuItem3.SideBarGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.MenuItem3.SideBarStyle = UltimateMenus.KunalMenuItem.SideBarDrawStyle.DefaultGradient
        Me.MenuItem3.Text = "Savings Bank "
        '
        'MenuItem13
        '
        Me.MenuItem13.CheckedImageIndex = 0
        Me.MenuItem13.CheckedMenuItemBackColor = System.Drawing.SystemColors.Control
        Me.MenuItem13.CheckedMenuItemBorderColor = System.Drawing.SystemColors.Control
        Me.MenuItem13.CheckedMenuItemDisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(197, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(184, Byte), Integer))
        Me.MenuItem13.CheckedMenuItemIconShadowColor = System.Drawing.Color.Gray
        Me.MenuItem13.CheckedMenuItemStyle = UltimateMenus.KunalMenuItem.CheckedMenuStyles.CheckedItemDefault
        Me.MenuItem13.CheckedMenuItemTickMarkColor = System.Drawing.SystemColors.Control
        Me.MenuItem13.FillMenuBarItem = False
        Me.MenuItem13.HighLightForeColor = System.Drawing.SystemColors.HighlightText
        Me.MenuItem13.HighLightScheme = UltimateMenus.KunalMenuItem.HighLightColorDrawStyle.DefaultScheme
        Me.MenuItem13.HiliteGradientColor1 = System.Drawing.Color.WhiteSmoke
        Me.MenuItem13.HiliteGradientColor2 = System.Drawing.Color.CornflowerBlue
        Me.MenuItem13.HiLiteGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.MenuItem13.IconShadowColor = System.Drawing.Color.Gray
        Me.MenuItem13.ImageIndex = 0
        Me.MenuItem13.Index = 0
        Me.MenuItem13.MakeCheckedMenuItemIconTransparent = False
        Me.MenuItem13.MakeTransparentIcon = False
        Me.MenuItem13.MenuBarItemBorderColor = System.Drawing.Color.Black
        Me.MenuItem13.MenuBarItemFillColor = System.Drawing.SystemColors.Menu
        Me.MenuItem13.MenuBarItemFillingStyle = UltimateMenus.KunalMenuItem.MenuBarFillStyles.FillColor
        Me.MenuItem13.MenuBarItemGradientColor1 = System.Drawing.SystemColors.Menu
        Me.MenuItem13.MenuBarItemGradientColor2 = System.Drawing.SystemColors.Menu
        Me.MenuItem13.MenuBarItemGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.MenuItem13.OwnerDraw = True
        Me.MenuItem13.PreDefinedHiLiteColors = UltimateMenus.KunalMenuItem.PreDefinedHighLightColors.Khaki
        Me.MenuItem13.PreDefinedHiLiteGradientColors = UltimateMenus.KunalMenuItem.PreDefinedGrHighLightColors.BrownWhite
        Me.MenuItem13.PreDefinedSideBarGradientColour = UltimateMenus.KunalMenuItem.PreDefinedSideBarGradientColors.ShineyBlueYellow
        Me.MenuItem13.Shortcut = System.Windows.Forms.Shortcut.F6
        Me.MenuItem13.ShowBorderAroundMenuBar = False
        Me.MenuItem13.ShowHiliteOverSideBar = False
        Me.MenuItem13.ShowShadowUnderMenuBar = True
        Me.MenuItem13.SideBarGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.MenuItem13.SideBarStyle = UltimateMenus.KunalMenuItem.SideBarDrawStyle.DefaultGradient
        Me.MenuItem13.Text = "New Account"
        '
        'MenuItem17
        '
        Me.MenuItem17.CheckedImageIndex = 0
        Me.MenuItem17.CheckedMenuItemBackColor = System.Drawing.SystemColors.Control
        Me.MenuItem17.CheckedMenuItemBorderColor = System.Drawing.SystemColors.Control
        Me.MenuItem17.CheckedMenuItemDisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(197, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(184, Byte), Integer))
        Me.MenuItem17.CheckedMenuItemIconShadowColor = System.Drawing.Color.Gray
        Me.MenuItem17.CheckedMenuItemStyle = UltimateMenus.KunalMenuItem.CheckedMenuStyles.CheckedItemDefault
        Me.MenuItem17.CheckedMenuItemTickMarkColor = System.Drawing.SystemColors.Control
        Me.MenuItem17.FillMenuBarItem = False
        Me.MenuItem17.HighLightForeColor = System.Drawing.SystemColors.HighlightText
        Me.MenuItem17.HighLightScheme = UltimateMenus.KunalMenuItem.HighLightColorDrawStyle.DefaultScheme
        Me.MenuItem17.HiliteGradientColor1 = System.Drawing.Color.WhiteSmoke
        Me.MenuItem17.HiliteGradientColor2 = System.Drawing.Color.CornflowerBlue
        Me.MenuItem17.HiLiteGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.MenuItem17.IconShadowColor = System.Drawing.Color.Gray
        Me.MenuItem17.ImageIndex = 0
        Me.MenuItem17.Index = 1
        Me.MenuItem17.MakeCheckedMenuItemIconTransparent = False
        Me.MenuItem17.MakeTransparentIcon = False
        Me.MenuItem17.MenuBarItemBorderColor = System.Drawing.Color.Black
        Me.MenuItem17.MenuBarItemFillColor = System.Drawing.SystemColors.Menu
        Me.MenuItem17.MenuBarItemFillingStyle = UltimateMenus.KunalMenuItem.MenuBarFillStyles.FillColor
        Me.MenuItem17.MenuBarItemGradientColor1 = System.Drawing.SystemColors.Menu
        Me.MenuItem17.MenuBarItemGradientColor2 = System.Drawing.SystemColors.Menu
        Me.MenuItem17.MenuBarItemGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.MenuItem17.OwnerDraw = True
        Me.MenuItem17.PreDefinedHiLiteColors = UltimateMenus.KunalMenuItem.PreDefinedHighLightColors.Khaki
        Me.MenuItem17.PreDefinedHiLiteGradientColors = UltimateMenus.KunalMenuItem.PreDefinedGrHighLightColors.BrownWhite
        Me.MenuItem17.PreDefinedSideBarGradientColour = UltimateMenus.KunalMenuItem.PreDefinedSideBarGradientColors.ShineyBlueYellow
        Me.MenuItem17.ShowBorderAroundMenuBar = False
        Me.MenuItem17.ShowHiliteOverSideBar = False
        Me.MenuItem17.ShowShadowUnderMenuBar = True
        Me.MenuItem17.SideBarGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.MenuItem17.SideBarStyle = UltimateMenus.KunalMenuItem.SideBarDrawStyle.DefaultGradient
        Me.MenuItem17.Text = "Deposit Cash"
        Me.MenuItem17.Visible = False
        '
        'MenuItem18
        '
        Me.MenuItem18.CheckedImageIndex = 0
        Me.MenuItem18.CheckedMenuItemBackColor = System.Drawing.SystemColors.Control
        Me.MenuItem18.CheckedMenuItemBorderColor = System.Drawing.SystemColors.Control
        Me.MenuItem18.CheckedMenuItemDisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(197, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(184, Byte), Integer))
        Me.MenuItem18.CheckedMenuItemIconShadowColor = System.Drawing.Color.Gray
        Me.MenuItem18.CheckedMenuItemStyle = UltimateMenus.KunalMenuItem.CheckedMenuStyles.CheckedItemDefault
        Me.MenuItem18.CheckedMenuItemTickMarkColor = System.Drawing.SystemColors.Control
        Me.MenuItem18.FillMenuBarItem = False
        Me.MenuItem18.HighLightForeColor = System.Drawing.SystemColors.HighlightText
        Me.MenuItem18.HighLightScheme = UltimateMenus.KunalMenuItem.HighLightColorDrawStyle.DefaultScheme
        Me.MenuItem18.HiliteGradientColor1 = System.Drawing.Color.WhiteSmoke
        Me.MenuItem18.HiliteGradientColor2 = System.Drawing.Color.CornflowerBlue
        Me.MenuItem18.HiLiteGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.MenuItem18.IconShadowColor = System.Drawing.Color.Gray
        Me.MenuItem18.ImageIndex = 0
        Me.MenuItem18.Index = 2
        Me.MenuItem18.MakeCheckedMenuItemIconTransparent = False
        Me.MenuItem18.MakeTransparentIcon = False
        Me.MenuItem18.MenuBarItemBorderColor = System.Drawing.Color.Black
        Me.MenuItem18.MenuBarItemFillColor = System.Drawing.SystemColors.Menu
        Me.MenuItem18.MenuBarItemFillingStyle = UltimateMenus.KunalMenuItem.MenuBarFillStyles.FillColor
        Me.MenuItem18.MenuBarItemGradientColor1 = System.Drawing.SystemColors.Menu
        Me.MenuItem18.MenuBarItemGradientColor2 = System.Drawing.SystemColors.Menu
        Me.MenuItem18.MenuBarItemGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.MenuItem18.OwnerDraw = True
        Me.MenuItem18.PreDefinedHiLiteColors = UltimateMenus.KunalMenuItem.PreDefinedHighLightColors.Khaki
        Me.MenuItem18.PreDefinedHiLiteGradientColors = UltimateMenus.KunalMenuItem.PreDefinedGrHighLightColors.BrownWhite
        Me.MenuItem18.PreDefinedSideBarGradientColour = UltimateMenus.KunalMenuItem.PreDefinedSideBarGradientColors.ShineyBlueYellow
        Me.MenuItem18.ShowBorderAroundMenuBar = False
        Me.MenuItem18.ShowHiliteOverSideBar = False
        Me.MenuItem18.ShowShadowUnderMenuBar = True
        Me.MenuItem18.SideBarGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.MenuItem18.SideBarStyle = UltimateMenus.KunalMenuItem.SideBarDrawStyle.DefaultGradient
        Me.MenuItem18.Text = "Withdraw Cash"
        Me.MenuItem18.Visible = False
        '
        'MenuItem114
        '
        Me.MenuItem114.CheckedImageIndex = 0
        Me.MenuItem114.CheckedMenuItemBackColor = System.Drawing.SystemColors.Control
        Me.MenuItem114.CheckedMenuItemBorderColor = System.Drawing.SystemColors.Control
        Me.MenuItem114.CheckedMenuItemDisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(197, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(184, Byte), Integer))
        Me.MenuItem114.CheckedMenuItemIconShadowColor = System.Drawing.Color.Gray
        Me.MenuItem114.CheckedMenuItemStyle = UltimateMenus.KunalMenuItem.CheckedMenuStyles.CheckedItemDefault
        Me.MenuItem114.CheckedMenuItemTickMarkColor = System.Drawing.SystemColors.Control
        Me.MenuItem114.FillMenuBarItem = False
        Me.MenuItem114.HighLightForeColor = System.Drawing.SystemColors.HighlightText
        Me.MenuItem114.HighLightScheme = UltimateMenus.KunalMenuItem.HighLightColorDrawStyle.DefaultScheme
        Me.MenuItem114.HiliteGradientColor1 = System.Drawing.Color.WhiteSmoke
        Me.MenuItem114.HiliteGradientColor2 = System.Drawing.Color.CornflowerBlue
        Me.MenuItem114.HiLiteGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.MenuItem114.IconShadowColor = System.Drawing.Color.Gray
        Me.MenuItem114.ImageIndex = 0
        Me.MenuItem114.Index = 3
        Me.MenuItem114.MakeCheckedMenuItemIconTransparent = False
        Me.MenuItem114.MakeTransparentIcon = False
        Me.MenuItem114.MenuBarItemBorderColor = System.Drawing.Color.Black
        Me.MenuItem114.MenuBarItemFillColor = System.Drawing.SystemColors.Menu
        Me.MenuItem114.MenuBarItemFillingStyle = UltimateMenus.KunalMenuItem.MenuBarFillStyles.FillColor
        Me.MenuItem114.MenuBarItemGradientColor1 = System.Drawing.SystemColors.Menu
        Me.MenuItem114.MenuBarItemGradientColor2 = System.Drawing.SystemColors.Menu
        Me.MenuItem114.MenuBarItemGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.MenuItem114.OwnerDraw = True
        Me.MenuItem114.PreDefinedHiLiteColors = UltimateMenus.KunalMenuItem.PreDefinedHighLightColors.Khaki
        Me.MenuItem114.PreDefinedHiLiteGradientColors = UltimateMenus.KunalMenuItem.PreDefinedGrHighLightColors.BrownWhite
        Me.MenuItem114.PreDefinedSideBarGradientColour = UltimateMenus.KunalMenuItem.PreDefinedSideBarGradientColors.ShineyBlueYellow
        Me.MenuItem114.Shortcut = System.Windows.Forms.Shortcut.F1
        Me.MenuItem114.ShowBorderAroundMenuBar = False
        Me.MenuItem114.ShowHiliteOverSideBar = False
        Me.MenuItem114.ShowShadowUnderMenuBar = True
        Me.MenuItem114.SideBarGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.MenuItem114.SideBarStyle = UltimateMenus.KunalMenuItem.SideBarDrawStyle.DefaultGradient
        Me.MenuItem114.Text = "Transaction"
        '
        'MenuItem19
        '
        Me.MenuItem19.CheckedImageIndex = 0
        Me.MenuItem19.CheckedMenuItemBackColor = System.Drawing.SystemColors.Control
        Me.MenuItem19.CheckedMenuItemBorderColor = System.Drawing.SystemColors.Control
        Me.MenuItem19.CheckedMenuItemDisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(197, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(184, Byte), Integer))
        Me.MenuItem19.CheckedMenuItemIconShadowColor = System.Drawing.Color.Gray
        Me.MenuItem19.CheckedMenuItemStyle = UltimateMenus.KunalMenuItem.CheckedMenuStyles.CheckedItemDefault
        Me.MenuItem19.CheckedMenuItemTickMarkColor = System.Drawing.SystemColors.Control
        Me.MenuItem19.FillMenuBarItem = False
        Me.MenuItem19.HighLightForeColor = System.Drawing.SystemColors.HighlightText
        Me.MenuItem19.HighLightScheme = UltimateMenus.KunalMenuItem.HighLightColorDrawStyle.DefaultScheme
        Me.MenuItem19.HiliteGradientColor1 = System.Drawing.Color.WhiteSmoke
        Me.MenuItem19.HiliteGradientColor2 = System.Drawing.Color.CornflowerBlue
        Me.MenuItem19.HiLiteGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.MenuItem19.IconShadowColor = System.Drawing.Color.Gray
        Me.MenuItem19.ImageIndex = 0
        Me.MenuItem19.Index = 4
        Me.MenuItem19.MakeCheckedMenuItemIconTransparent = False
        Me.MenuItem19.MakeTransparentIcon = False
        Me.MenuItem19.MenuBarItemBorderColor = System.Drawing.Color.Black
        Me.MenuItem19.MenuBarItemFillColor = System.Drawing.SystemColors.Menu
        Me.MenuItem19.MenuBarItemFillingStyle = UltimateMenus.KunalMenuItem.MenuBarFillStyles.FillColor
        Me.MenuItem19.MenuBarItemGradientColor1 = System.Drawing.SystemColors.Menu
        Me.MenuItem19.MenuBarItemGradientColor2 = System.Drawing.SystemColors.Menu
        Me.MenuItem19.MenuBarItemGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.MenuItem19.OwnerDraw = True
        Me.MenuItem19.PreDefinedHiLiteColors = UltimateMenus.KunalMenuItem.PreDefinedHighLightColors.Khaki
        Me.MenuItem19.PreDefinedHiLiteGradientColors = UltimateMenus.KunalMenuItem.PreDefinedGrHighLightColors.BrownWhite
        Me.MenuItem19.PreDefinedSideBarGradientColour = UltimateMenus.KunalMenuItem.PreDefinedSideBarGradientColors.ShineyBlueYellow
        Me.MenuItem19.ShowBorderAroundMenuBar = False
        Me.MenuItem19.ShowHiliteOverSideBar = False
        Me.MenuItem19.ShowShadowUnderMenuBar = True
        Me.MenuItem19.SideBarGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.MenuItem19.SideBarStyle = UltimateMenus.KunalMenuItem.SideBarDrawStyle.DefaultGradient
        Me.MenuItem19.Text = "Deposit Cheque"
        '
        'MenuItem55
        '
        Me.MenuItem55.CheckedImageIndex = 0
        Me.MenuItem55.CheckedMenuItemBackColor = System.Drawing.SystemColors.Control
        Me.MenuItem55.CheckedMenuItemBorderColor = System.Drawing.SystemColors.Control
        Me.MenuItem55.CheckedMenuItemDisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(197, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(184, Byte), Integer))
        Me.MenuItem55.CheckedMenuItemIconShadowColor = System.Drawing.Color.Gray
        Me.MenuItem55.CheckedMenuItemStyle = UltimateMenus.KunalMenuItem.CheckedMenuStyles.CheckedItemDefault
        Me.MenuItem55.CheckedMenuItemTickMarkColor = System.Drawing.SystemColors.Control
        Me.MenuItem55.FillMenuBarItem = False
        Me.MenuItem55.HighLightForeColor = System.Drawing.SystemColors.HighlightText
        Me.MenuItem55.HighLightScheme = UltimateMenus.KunalMenuItem.HighLightColorDrawStyle.DefaultScheme
        Me.MenuItem55.HiliteGradientColor1 = System.Drawing.Color.WhiteSmoke
        Me.MenuItem55.HiliteGradientColor2 = System.Drawing.Color.CornflowerBlue
        Me.MenuItem55.HiLiteGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.MenuItem55.IconShadowColor = System.Drawing.Color.Gray
        Me.MenuItem55.ImageIndex = 0
        Me.MenuItem55.Index = 5
        Me.MenuItem55.MakeCheckedMenuItemIconTransparent = False
        Me.MenuItem55.MakeTransparentIcon = False
        Me.MenuItem55.MenuBarItemBorderColor = System.Drawing.Color.Black
        Me.MenuItem55.MenuBarItemFillColor = System.Drawing.SystemColors.Menu
        Me.MenuItem55.MenuBarItemFillingStyle = UltimateMenus.KunalMenuItem.MenuBarFillStyles.FillColor
        Me.MenuItem55.MenuBarItemGradientColor1 = System.Drawing.SystemColors.Menu
        Me.MenuItem55.MenuBarItemGradientColor2 = System.Drawing.SystemColors.Menu
        Me.MenuItem55.MenuBarItemGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.MenuItem55.OwnerDraw = True
        Me.MenuItem55.PreDefinedHiLiteColors = UltimateMenus.KunalMenuItem.PreDefinedHighLightColors.Khaki
        Me.MenuItem55.PreDefinedHiLiteGradientColors = UltimateMenus.KunalMenuItem.PreDefinedGrHighLightColors.BrownWhite
        Me.MenuItem55.PreDefinedSideBarGradientColour = UltimateMenus.KunalMenuItem.PreDefinedSideBarGradientColors.ShineyBlueYellow
        Me.MenuItem55.ShowBorderAroundMenuBar = False
        Me.MenuItem55.ShowHiliteOverSideBar = False
        Me.MenuItem55.ShowShadowUnderMenuBar = True
        Me.MenuItem55.SideBarGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.MenuItem55.SideBarStyle = UltimateMenus.KunalMenuItem.SideBarDrawStyle.DefaultGradient
        Me.MenuItem55.Text = "Cheque Withdraw"
        '
        'MenuItem20
        '
        Me.MenuItem20.CheckedImageIndex = 0
        Me.MenuItem20.CheckedMenuItemBackColor = System.Drawing.SystemColors.Control
        Me.MenuItem20.CheckedMenuItemBorderColor = System.Drawing.SystemColors.Control
        Me.MenuItem20.CheckedMenuItemDisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(197, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(184, Byte), Integer))
        Me.MenuItem20.CheckedMenuItemIconShadowColor = System.Drawing.Color.Gray
        Me.MenuItem20.CheckedMenuItemStyle = UltimateMenus.KunalMenuItem.CheckedMenuStyles.CheckedItemDefault
        Me.MenuItem20.CheckedMenuItemTickMarkColor = System.Drawing.SystemColors.Control
        Me.MenuItem20.FillMenuBarItem = False
        Me.MenuItem20.HighLightForeColor = System.Drawing.SystemColors.HighlightText
        Me.MenuItem20.HighLightScheme = UltimateMenus.KunalMenuItem.HighLightColorDrawStyle.DefaultScheme
        Me.MenuItem20.HiliteGradientColor1 = System.Drawing.Color.WhiteSmoke
        Me.MenuItem20.HiliteGradientColor2 = System.Drawing.Color.CornflowerBlue
        Me.MenuItem20.HiLiteGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.MenuItem20.IconShadowColor = System.Drawing.Color.Gray
        Me.MenuItem20.ImageIndex = 0
        Me.MenuItem20.Index = 6
        Me.MenuItem20.MakeCheckedMenuItemIconTransparent = False
        Me.MenuItem20.MakeTransparentIcon = False
        Me.MenuItem20.MenuBarItemBorderColor = System.Drawing.Color.Black
        Me.MenuItem20.MenuBarItemFillColor = System.Drawing.SystemColors.Menu
        Me.MenuItem20.MenuBarItemFillingStyle = UltimateMenus.KunalMenuItem.MenuBarFillStyles.FillColor
        Me.MenuItem20.MenuBarItemGradientColor1 = System.Drawing.SystemColors.Menu
        Me.MenuItem20.MenuBarItemGradientColor2 = System.Drawing.SystemColors.Menu
        Me.MenuItem20.MenuBarItemGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.MenuItem20.OwnerDraw = True
        Me.MenuItem20.PreDefinedHiLiteColors = UltimateMenus.KunalMenuItem.PreDefinedHighLightColors.Khaki
        Me.MenuItem20.PreDefinedHiLiteGradientColors = UltimateMenus.KunalMenuItem.PreDefinedGrHighLightColors.BrownWhite
        Me.MenuItem20.PreDefinedSideBarGradientColour = UltimateMenus.KunalMenuItem.PreDefinedSideBarGradientColors.ShineyBlueYellow
        Me.MenuItem20.ShowBorderAroundMenuBar = False
        Me.MenuItem20.ShowHiliteOverSideBar = False
        Me.MenuItem20.ShowShadowUnderMenuBar = True
        Me.MenuItem20.SideBarGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.MenuItem20.SideBarStyle = UltimateMenus.KunalMenuItem.SideBarDrawStyle.DefaultGradient
        Me.MenuItem20.Text = "Cheque's Detail"
        '
        'MenuItem21
        '
        Me.MenuItem21.CheckedImageIndex = 0
        Me.MenuItem21.CheckedMenuItemBackColor = System.Drawing.SystemColors.Control
        Me.MenuItem21.CheckedMenuItemBorderColor = System.Drawing.SystemColors.Control
        Me.MenuItem21.CheckedMenuItemDisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(197, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(184, Byte), Integer))
        Me.MenuItem21.CheckedMenuItemIconShadowColor = System.Drawing.Color.Gray
        Me.MenuItem21.CheckedMenuItemStyle = UltimateMenus.KunalMenuItem.CheckedMenuStyles.CheckedItemDefault
        Me.MenuItem21.CheckedMenuItemTickMarkColor = System.Drawing.SystemColors.Control
        Me.MenuItem21.FillMenuBarItem = False
        Me.MenuItem21.HighLightForeColor = System.Drawing.SystemColors.HighlightText
        Me.MenuItem21.HighLightScheme = UltimateMenus.KunalMenuItem.HighLightColorDrawStyle.DefaultScheme
        Me.MenuItem21.HiliteGradientColor1 = System.Drawing.Color.WhiteSmoke
        Me.MenuItem21.HiliteGradientColor2 = System.Drawing.Color.CornflowerBlue
        Me.MenuItem21.HiLiteGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.MenuItem21.IconShadowColor = System.Drawing.Color.Gray
        Me.MenuItem21.ImageIndex = 0
        Me.MenuItem21.Index = 7
        Me.MenuItem21.MakeCheckedMenuItemIconTransparent = False
        Me.MenuItem21.MakeTransparentIcon = False
        Me.MenuItem21.MenuBarItemBorderColor = System.Drawing.Color.Black
        Me.MenuItem21.MenuBarItemFillColor = System.Drawing.SystemColors.Menu
        Me.MenuItem21.MenuBarItemFillingStyle = UltimateMenus.KunalMenuItem.MenuBarFillStyles.FillColor
        Me.MenuItem21.MenuBarItemGradientColor1 = System.Drawing.SystemColors.Menu
        Me.MenuItem21.MenuBarItemGradientColor2 = System.Drawing.SystemColors.Menu
        Me.MenuItem21.MenuBarItemGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.MenuItem21.OwnerDraw = True
        Me.MenuItem21.PreDefinedHiLiteColors = UltimateMenus.KunalMenuItem.PreDefinedHighLightColors.Khaki
        Me.MenuItem21.PreDefinedHiLiteGradientColors = UltimateMenus.KunalMenuItem.PreDefinedGrHighLightColors.BrownWhite
        Me.MenuItem21.PreDefinedSideBarGradientColour = UltimateMenus.KunalMenuItem.PreDefinedSideBarGradientColors.ShineyBlueYellow
        Me.MenuItem21.ShowBorderAroundMenuBar = False
        Me.MenuItem21.ShowHiliteOverSideBar = False
        Me.MenuItem21.ShowShadowUnderMenuBar = True
        Me.MenuItem21.SideBarGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.MenuItem21.SideBarStyle = UltimateMenus.KunalMenuItem.SideBarDrawStyle.DefaultGradient
        Me.MenuItem21.Text = "Issue Cheque Book"
        '
        'MenuItem22
        '
        Me.MenuItem22.CheckedImageIndex = 0
        Me.MenuItem22.CheckedMenuItemBackColor = System.Drawing.SystemColors.Control
        Me.MenuItem22.CheckedMenuItemBorderColor = System.Drawing.SystemColors.Control
        Me.MenuItem22.CheckedMenuItemDisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(197, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(184, Byte), Integer))
        Me.MenuItem22.CheckedMenuItemIconShadowColor = System.Drawing.Color.Gray
        Me.MenuItem22.CheckedMenuItemStyle = UltimateMenus.KunalMenuItem.CheckedMenuStyles.CheckedItemDefault
        Me.MenuItem22.CheckedMenuItemTickMarkColor = System.Drawing.SystemColors.Control
        Me.MenuItem22.FillMenuBarItem = False
        Me.MenuItem22.HighLightForeColor = System.Drawing.SystemColors.HighlightText
        Me.MenuItem22.HighLightScheme = UltimateMenus.KunalMenuItem.HighLightColorDrawStyle.DefaultScheme
        Me.MenuItem22.HiliteGradientColor1 = System.Drawing.Color.WhiteSmoke
        Me.MenuItem22.HiliteGradientColor2 = System.Drawing.Color.CornflowerBlue
        Me.MenuItem22.HiLiteGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.MenuItem22.IconShadowColor = System.Drawing.Color.Gray
        Me.MenuItem22.ImageIndex = 0
        Me.MenuItem22.Index = 8
        Me.MenuItem22.MakeCheckedMenuItemIconTransparent = False
        Me.MenuItem22.MakeTransparentIcon = False
        Me.MenuItem22.MenuBarItemBorderColor = System.Drawing.Color.Black
        Me.MenuItem22.MenuBarItemFillColor = System.Drawing.SystemColors.Menu
        Me.MenuItem22.MenuBarItemFillingStyle = UltimateMenus.KunalMenuItem.MenuBarFillStyles.FillColor
        Me.MenuItem22.MenuBarItemGradientColor1 = System.Drawing.SystemColors.Menu
        Me.MenuItem22.MenuBarItemGradientColor2 = System.Drawing.SystemColors.Menu
        Me.MenuItem22.MenuBarItemGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.MenuItem22.OwnerDraw = True
        Me.MenuItem22.PreDefinedHiLiteColors = UltimateMenus.KunalMenuItem.PreDefinedHighLightColors.Khaki
        Me.MenuItem22.PreDefinedHiLiteGradientColors = UltimateMenus.KunalMenuItem.PreDefinedGrHighLightColors.BrownWhite
        Me.MenuItem22.PreDefinedSideBarGradientColour = UltimateMenus.KunalMenuItem.PreDefinedSideBarGradientColors.ShineyBlueYellow
        Me.MenuItem22.ShowBorderAroundMenuBar = False
        Me.MenuItem22.ShowHiliteOverSideBar = False
        Me.MenuItem22.ShowShadowUnderMenuBar = True
        Me.MenuItem22.SideBarGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.MenuItem22.SideBarStyle = UltimateMenus.KunalMenuItem.SideBarDrawStyle.DefaultGradient
        Me.MenuItem22.Text = "Issue Passbook"
        Me.MenuItem22.Visible = False
        '
        'MenuItem23
        '
        Me.MenuItem23.CheckedImageIndex = 0
        Me.MenuItem23.CheckedMenuItemBackColor = System.Drawing.SystemColors.Control
        Me.MenuItem23.CheckedMenuItemBorderColor = System.Drawing.SystemColors.Control
        Me.MenuItem23.CheckedMenuItemDisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(197, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(184, Byte), Integer))
        Me.MenuItem23.CheckedMenuItemIconShadowColor = System.Drawing.Color.Gray
        Me.MenuItem23.CheckedMenuItemStyle = UltimateMenus.KunalMenuItem.CheckedMenuStyles.CheckedItemDefault
        Me.MenuItem23.CheckedMenuItemTickMarkColor = System.Drawing.SystemColors.Control
        Me.MenuItem23.FillMenuBarItem = False
        Me.MenuItem23.HighLightForeColor = System.Drawing.SystemColors.HighlightText
        Me.MenuItem23.HighLightScheme = UltimateMenus.KunalMenuItem.HighLightColorDrawStyle.DefaultScheme
        Me.MenuItem23.HiliteGradientColor1 = System.Drawing.Color.WhiteSmoke
        Me.MenuItem23.HiliteGradientColor2 = System.Drawing.Color.CornflowerBlue
        Me.MenuItem23.HiLiteGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.MenuItem23.IconShadowColor = System.Drawing.Color.Gray
        Me.MenuItem23.ImageIndex = 0
        Me.MenuItem23.Index = 9
        Me.MenuItem23.MakeCheckedMenuItemIconTransparent = False
        Me.MenuItem23.MakeTransparentIcon = False
        Me.MenuItem23.MenuBarItemBorderColor = System.Drawing.Color.Black
        Me.MenuItem23.MenuBarItemFillColor = System.Drawing.SystemColors.Menu
        Me.MenuItem23.MenuBarItemFillingStyle = UltimateMenus.KunalMenuItem.MenuBarFillStyles.FillColor
        Me.MenuItem23.MenuBarItemGradientColor1 = System.Drawing.SystemColors.Menu
        Me.MenuItem23.MenuBarItemGradientColor2 = System.Drawing.SystemColors.Menu
        Me.MenuItem23.MenuBarItemGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.MenuItem23.OwnerDraw = True
        Me.MenuItem23.PreDefinedHiLiteColors = UltimateMenus.KunalMenuItem.PreDefinedHighLightColors.Khaki
        Me.MenuItem23.PreDefinedHiLiteGradientColors = UltimateMenus.KunalMenuItem.PreDefinedGrHighLightColors.BrownWhite
        Me.MenuItem23.PreDefinedSideBarGradientColour = UltimateMenus.KunalMenuItem.PreDefinedSideBarGradientColors.ShineyBlueYellow
        Me.MenuItem23.ShowBorderAroundMenuBar = False
        Me.MenuItem23.ShowHiliteOverSideBar = False
        Me.MenuItem23.ShowShadowUnderMenuBar = True
        Me.MenuItem23.SideBarGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.MenuItem23.SideBarStyle = UltimateMenus.KunalMenuItem.SideBarDrawStyle.DefaultGradient
        Me.MenuItem23.Text = "Close Account"
        '
        'MenuItem24
        '
        Me.MenuItem24.CheckedImageIndex = 0
        Me.MenuItem24.CheckedMenuItemBackColor = System.Drawing.SystemColors.Control
        Me.MenuItem24.CheckedMenuItemBorderColor = System.Drawing.SystemColors.Control
        Me.MenuItem24.CheckedMenuItemDisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(197, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(184, Byte), Integer))
        Me.MenuItem24.CheckedMenuItemIconShadowColor = System.Drawing.Color.Gray
        Me.MenuItem24.CheckedMenuItemStyle = UltimateMenus.KunalMenuItem.CheckedMenuStyles.CheckedItemDefault
        Me.MenuItem24.CheckedMenuItemTickMarkColor = System.Drawing.SystemColors.Control
        Me.MenuItem24.FillMenuBarItem = False
        Me.MenuItem24.HighLightForeColor = System.Drawing.SystemColors.HighlightText
        Me.MenuItem24.HighLightScheme = UltimateMenus.KunalMenuItem.HighLightColorDrawStyle.DefaultScheme
        Me.MenuItem24.HiliteGradientColor1 = System.Drawing.Color.WhiteSmoke
        Me.MenuItem24.HiliteGradientColor2 = System.Drawing.Color.CornflowerBlue
        Me.MenuItem24.HiLiteGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.MenuItem24.IconShadowColor = System.Drawing.Color.Gray
        Me.MenuItem24.ImageIndex = 0
        Me.MenuItem24.Index = 10
        Me.MenuItem24.MakeCheckedMenuItemIconTransparent = False
        Me.MenuItem24.MakeTransparentIcon = False
        Me.MenuItem24.MenuBarItemBorderColor = System.Drawing.Color.Black
        Me.MenuItem24.MenuBarItemFillColor = System.Drawing.SystemColors.Menu
        Me.MenuItem24.MenuBarItemFillingStyle = UltimateMenus.KunalMenuItem.MenuBarFillStyles.FillColor
        Me.MenuItem24.MenuBarItemGradientColor1 = System.Drawing.SystemColors.Menu
        Me.MenuItem24.MenuBarItemGradientColor2 = System.Drawing.SystemColors.Menu
        Me.MenuItem24.MenuBarItemGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.MenuItem24.OwnerDraw = True
        Me.MenuItem24.PreDefinedHiLiteColors = UltimateMenus.KunalMenuItem.PreDefinedHighLightColors.Khaki
        Me.MenuItem24.PreDefinedHiLiteGradientColors = UltimateMenus.KunalMenuItem.PreDefinedGrHighLightColors.BrownWhite
        Me.MenuItem24.PreDefinedSideBarGradientColour = UltimateMenus.KunalMenuItem.PreDefinedSideBarGradientColors.ShineyBlueYellow
        Me.MenuItem24.Shortcut = System.Windows.Forms.Shortcut.CtrlF6
        Me.MenuItem24.ShowBorderAroundMenuBar = False
        Me.MenuItem24.ShowHiliteOverSideBar = False
        Me.MenuItem24.ShowShadowUnderMenuBar = True
        Me.MenuItem24.SideBarGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.MenuItem24.SideBarStyle = UltimateMenus.KunalMenuItem.SideBarDrawStyle.DefaultGradient
        Me.MenuItem24.Text = "View Accounts"
        '
        'MenuItem25
        '
        Me.MenuItem25.CheckedImageIndex = 0
        Me.MenuItem25.CheckedMenuItemBackColor = System.Drawing.SystemColors.Control
        Me.MenuItem25.CheckedMenuItemBorderColor = System.Drawing.SystemColors.Control
        Me.MenuItem25.CheckedMenuItemDisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(197, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(184, Byte), Integer))
        Me.MenuItem25.CheckedMenuItemIconShadowColor = System.Drawing.Color.Gray
        Me.MenuItem25.CheckedMenuItemStyle = UltimateMenus.KunalMenuItem.CheckedMenuStyles.CheckedItemDefault
        Me.MenuItem25.CheckedMenuItemTickMarkColor = System.Drawing.SystemColors.Control
        Me.MenuItem25.FillMenuBarItem = False
        Me.MenuItem25.HighLightForeColor = System.Drawing.SystemColors.HighlightText
        Me.MenuItem25.HighLightScheme = UltimateMenus.KunalMenuItem.HighLightColorDrawStyle.DefaultScheme
        Me.MenuItem25.HiliteGradientColor1 = System.Drawing.Color.WhiteSmoke
        Me.MenuItem25.HiliteGradientColor2 = System.Drawing.Color.CornflowerBlue
        Me.MenuItem25.HiLiteGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.MenuItem25.IconShadowColor = System.Drawing.Color.Gray
        Me.MenuItem25.ImageIndex = 0
        Me.MenuItem25.Index = 11
        Me.MenuItem25.MakeCheckedMenuItemIconTransparent = False
        Me.MenuItem25.MakeTransparentIcon = False
        Me.MenuItem25.MenuBarItemBorderColor = System.Drawing.Color.Black
        Me.MenuItem25.MenuBarItemFillColor = System.Drawing.SystemColors.Menu
        Me.MenuItem25.MenuBarItemFillingStyle = UltimateMenus.KunalMenuItem.MenuBarFillStyles.FillColor
        Me.MenuItem25.MenuBarItemGradientColor1 = System.Drawing.SystemColors.Menu
        Me.MenuItem25.MenuBarItemGradientColor2 = System.Drawing.SystemColors.Menu
        Me.MenuItem25.MenuBarItemGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.MenuItem25.OwnerDraw = True
        Me.MenuItem25.PreDefinedHiLiteColors = UltimateMenus.KunalMenuItem.PreDefinedHighLightColors.Khaki
        Me.MenuItem25.PreDefinedHiLiteGradientColors = UltimateMenus.KunalMenuItem.PreDefinedGrHighLightColors.BrownWhite
        Me.MenuItem25.PreDefinedSideBarGradientColour = UltimateMenus.KunalMenuItem.PreDefinedSideBarGradientColors.ShineyBlueYellow
        Me.MenuItem25.ShowBorderAroundMenuBar = False
        Me.MenuItem25.ShowHiliteOverSideBar = False
        Me.MenuItem25.ShowShadowUnderMenuBar = True
        Me.MenuItem25.SideBarGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.MenuItem25.SideBarStyle = UltimateMenus.KunalMenuItem.SideBarDrawStyle.DefaultGradient
        Me.MenuItem25.Text = "Interest Calculation"
        '
        'MenuItem26
        '
        Me.MenuItem26.CheckedImageIndex = 0
        Me.MenuItem26.CheckedMenuItemBackColor = System.Drawing.SystemColors.Control
        Me.MenuItem26.CheckedMenuItemBorderColor = System.Drawing.SystemColors.Control
        Me.MenuItem26.CheckedMenuItemDisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(197, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(184, Byte), Integer))
        Me.MenuItem26.CheckedMenuItemIconShadowColor = System.Drawing.Color.Gray
        Me.MenuItem26.CheckedMenuItemStyle = UltimateMenus.KunalMenuItem.CheckedMenuStyles.CheckedItemDefault
        Me.MenuItem26.CheckedMenuItemTickMarkColor = System.Drawing.SystemColors.Control
        Me.MenuItem26.FillMenuBarItem = False
        Me.MenuItem26.HighLightForeColor = System.Drawing.SystemColors.HighlightText
        Me.MenuItem26.HighLightScheme = UltimateMenus.KunalMenuItem.HighLightColorDrawStyle.DefaultScheme
        Me.MenuItem26.HiliteGradientColor1 = System.Drawing.Color.WhiteSmoke
        Me.MenuItem26.HiliteGradientColor2 = System.Drawing.Color.CornflowerBlue
        Me.MenuItem26.HiLiteGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.MenuItem26.IconShadowColor = System.Drawing.Color.Gray
        Me.MenuItem26.ImageIndex = 0
        Me.MenuItem26.Index = 12
        Me.MenuItem26.MakeCheckedMenuItemIconTransparent = False
        Me.MenuItem26.MakeTransparentIcon = False
        Me.MenuItem26.MenuBarItemBorderColor = System.Drawing.Color.Black
        Me.MenuItem26.MenuBarItemFillColor = System.Drawing.SystemColors.Menu
        Me.MenuItem26.MenuBarItemFillingStyle = UltimateMenus.KunalMenuItem.MenuBarFillStyles.FillColor
        Me.MenuItem26.MenuBarItemGradientColor1 = System.Drawing.SystemColors.Menu
        Me.MenuItem26.MenuBarItemGradientColor2 = System.Drawing.SystemColors.Menu
        Me.MenuItem26.MenuBarItemGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.MenuItem26.OwnerDraw = True
        Me.MenuItem26.PreDefinedHiLiteColors = UltimateMenus.KunalMenuItem.PreDefinedHighLightColors.Khaki
        Me.MenuItem26.PreDefinedHiLiteGradientColors = UltimateMenus.KunalMenuItem.PreDefinedGrHighLightColors.BrownWhite
        Me.MenuItem26.PreDefinedSideBarGradientColour = UltimateMenus.KunalMenuItem.PreDefinedSideBarGradientColors.ShineyBlueYellow
        Me.MenuItem26.ShowBorderAroundMenuBar = False
        Me.MenuItem26.ShowHiliteOverSideBar = False
        Me.MenuItem26.ShowShadowUnderMenuBar = True
        Me.MenuItem26.SideBarGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.MenuItem26.SideBarStyle = UltimateMenus.KunalMenuItem.SideBarDrawStyle.DefaultGradient
        Me.MenuItem26.Text = "Transaction View"
        '
        'MenuItem28
        '
        Me.MenuItem28.CheckedImageIndex = 0
        Me.MenuItem28.CheckedMenuItemBackColor = System.Drawing.SystemColors.Control
        Me.MenuItem28.CheckedMenuItemBorderColor = System.Drawing.SystemColors.Control
        Me.MenuItem28.CheckedMenuItemDisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(197, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(184, Byte), Integer))
        Me.MenuItem28.CheckedMenuItemIconShadowColor = System.Drawing.Color.Gray
        Me.MenuItem28.CheckedMenuItemStyle = UltimateMenus.KunalMenuItem.CheckedMenuStyles.CheckedItemDefault
        Me.MenuItem28.CheckedMenuItemTickMarkColor = System.Drawing.SystemColors.Control
        Me.MenuItem28.FillMenuBarItem = False
        Me.MenuItem28.HighLightForeColor = System.Drawing.SystemColors.HighlightText
        Me.MenuItem28.HighLightScheme = UltimateMenus.KunalMenuItem.HighLightColorDrawStyle.DefaultScheme
        Me.MenuItem28.HiliteGradientColor1 = System.Drawing.Color.WhiteSmoke
        Me.MenuItem28.HiliteGradientColor2 = System.Drawing.Color.CornflowerBlue
        Me.MenuItem28.HiLiteGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.MenuItem28.IconShadowColor = System.Drawing.Color.Gray
        Me.MenuItem28.ImageIndex = 0
        Me.MenuItem28.Index = 13
        Me.MenuItem28.MakeCheckedMenuItemIconTransparent = False
        Me.MenuItem28.MakeTransparentIcon = False
        Me.MenuItem28.MenuBarItemBorderColor = System.Drawing.Color.Black
        Me.MenuItem28.MenuBarItemFillColor = System.Drawing.SystemColors.Menu
        Me.MenuItem28.MenuBarItemFillingStyle = UltimateMenus.KunalMenuItem.MenuBarFillStyles.FillColor
        Me.MenuItem28.MenuBarItemGradientColor1 = System.Drawing.SystemColors.Menu
        Me.MenuItem28.MenuBarItemGradientColor2 = System.Drawing.SystemColors.Menu
        Me.MenuItem28.MenuBarItemGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.MenuItem28.OwnerDraw = True
        Me.MenuItem28.PreDefinedHiLiteColors = UltimateMenus.KunalMenuItem.PreDefinedHighLightColors.Khaki
        Me.MenuItem28.PreDefinedHiLiteGradientColors = UltimateMenus.KunalMenuItem.PreDefinedGrHighLightColors.BrownWhite
        Me.MenuItem28.PreDefinedSideBarGradientColour = UltimateMenus.KunalMenuItem.PreDefinedSideBarGradientColors.ShineyBlueYellow
        Me.MenuItem28.ShowBorderAroundMenuBar = False
        Me.MenuItem28.ShowHiliteOverSideBar = False
        Me.MenuItem28.ShowShadowUnderMenuBar = True
        Me.MenuItem28.SideBarGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.MenuItem28.SideBarStyle = UltimateMenus.KunalMenuItem.SideBarDrawStyle.DefaultGradient
        Me.MenuItem28.Text = "Cheque StopPay"
        '
        'MenuItem101
        '
        Me.MenuItem101.CheckedImageIndex = 0
        Me.MenuItem101.CheckedMenuItemBackColor = System.Drawing.SystemColors.Control
        Me.MenuItem101.CheckedMenuItemBorderColor = System.Drawing.SystemColors.Control
        Me.MenuItem101.CheckedMenuItemDisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(197, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(184, Byte), Integer))
        Me.MenuItem101.CheckedMenuItemIconShadowColor = System.Drawing.Color.Gray
        Me.MenuItem101.CheckedMenuItemStyle = UltimateMenus.KunalMenuItem.CheckedMenuStyles.CheckedItemDefault
        Me.MenuItem101.CheckedMenuItemTickMarkColor = System.Drawing.SystemColors.Control
        Me.MenuItem101.FillMenuBarItem = False
        Me.MenuItem101.HighLightForeColor = System.Drawing.SystemColors.HighlightText
        Me.MenuItem101.HighLightScheme = UltimateMenus.KunalMenuItem.HighLightColorDrawStyle.DefaultScheme
        Me.MenuItem101.HiliteGradientColor1 = System.Drawing.Color.WhiteSmoke
        Me.MenuItem101.HiliteGradientColor2 = System.Drawing.Color.CornflowerBlue
        Me.MenuItem101.HiLiteGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.MenuItem101.IconShadowColor = System.Drawing.Color.Gray
        Me.MenuItem101.ImageIndex = 0
        Me.MenuItem101.Index = 14
        Me.MenuItem101.MakeCheckedMenuItemIconTransparent = False
        Me.MenuItem101.MakeTransparentIcon = False
        Me.MenuItem101.MenuBarItemBorderColor = System.Drawing.Color.Black
        Me.MenuItem101.MenuBarItemFillColor = System.Drawing.SystemColors.Menu
        Me.MenuItem101.MenuBarItemFillingStyle = UltimateMenus.KunalMenuItem.MenuBarFillStyles.FillColor
        Me.MenuItem101.MenuBarItemGradientColor1 = System.Drawing.SystemColors.Menu
        Me.MenuItem101.MenuBarItemGradientColor2 = System.Drawing.SystemColors.Menu
        Me.MenuItem101.MenuBarItemGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.MenuItem101.OwnerDraw = True
        Me.MenuItem101.PreDefinedHiLiteColors = UltimateMenus.KunalMenuItem.PreDefinedHighLightColors.Khaki
        Me.MenuItem101.PreDefinedHiLiteGradientColors = UltimateMenus.KunalMenuItem.PreDefinedGrHighLightColors.BrownWhite
        Me.MenuItem101.PreDefinedSideBarGradientColour = UltimateMenus.KunalMenuItem.PreDefinedSideBarGradientColors.ShineyBlueYellow
        Me.MenuItem101.ShowBorderAroundMenuBar = False
        Me.MenuItem101.ShowHiliteOverSideBar = False
        Me.MenuItem101.ShowShadowUnderMenuBar = True
        Me.MenuItem101.SideBarGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.MenuItem101.SideBarStyle = UltimateMenus.KunalMenuItem.SideBarDrawStyle.DefaultGradient
        Me.MenuItem101.Text = "Reports"
        Me.MenuItem101.Visible = False
        '
        'MenuItem12
        '
        Me.MenuItem12.CheckedImageIndex = 0
        Me.MenuItem12.CheckedMenuItemBackColor = System.Drawing.SystemColors.Control
        Me.MenuItem12.CheckedMenuItemBorderColor = System.Drawing.SystemColors.Control
        Me.MenuItem12.CheckedMenuItemDisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(197, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(184, Byte), Integer))
        Me.MenuItem12.CheckedMenuItemIconShadowColor = System.Drawing.Color.Gray
        Me.MenuItem12.CheckedMenuItemStyle = UltimateMenus.KunalMenuItem.CheckedMenuStyles.CheckedItemDefault
        Me.MenuItem12.CheckedMenuItemTickMarkColor = System.Drawing.SystemColors.Control
        Me.MenuItem12.FillMenuBarItem = False
        Me.MenuItem12.HighLightForeColor = System.Drawing.SystemColors.HighlightText
        Me.MenuItem12.HighLightScheme = UltimateMenus.KunalMenuItem.HighLightColorDrawStyle.DefaultScheme
        Me.MenuItem12.HiliteGradientColor1 = System.Drawing.Color.WhiteSmoke
        Me.MenuItem12.HiliteGradientColor2 = System.Drawing.Color.CornflowerBlue
        Me.MenuItem12.HiLiteGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.MenuItem12.IconShadowColor = System.Drawing.Color.Gray
        Me.MenuItem12.ImageIndex = 0
        Me.MenuItem12.Index = 1
        Me.MenuItem12.MakeCheckedMenuItemIconTransparent = False
        Me.MenuItem12.MakeTransparentIcon = False
        Me.MenuItem12.MenuBarItemBorderColor = System.Drawing.Color.Black
        Me.MenuItem12.MenuBarItemFillColor = System.Drawing.SystemColors.Menu
        Me.MenuItem12.MenuBarItemFillingStyle = UltimateMenus.KunalMenuItem.MenuBarFillStyles.FillColor
        Me.MenuItem12.MenuBarItemGradientColor1 = System.Drawing.SystemColors.Menu
        Me.MenuItem12.MenuBarItemGradientColor2 = System.Drawing.SystemColors.Menu
        Me.MenuItem12.MenuBarItemGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.MenuItem12.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem102, Me.MenuItem104, Me.MenuItem116, Me.MenuItem132, Me.MenuItem133, Me.MenuItem134, Me.MenuItem135, Me.MenuItem125, Me.MenuItem127})
        Me.MenuItem12.OwnerDraw = True
        Me.MenuItem12.PreDefinedHiLiteColors = UltimateMenus.KunalMenuItem.PreDefinedHighLightColors.Khaki
        Me.MenuItem12.PreDefinedHiLiteGradientColors = UltimateMenus.KunalMenuItem.PreDefinedGrHighLightColors.BrownWhite
        Me.MenuItem12.PreDefinedSideBarGradientColour = UltimateMenus.KunalMenuItem.PreDefinedSideBarGradientColors.ShineyBlueYellow
        Me.MenuItem12.ShowBorderAroundMenuBar = False
        Me.MenuItem12.ShowHiliteOverSideBar = False
        Me.MenuItem12.ShowShadowUnderMenuBar = True
        Me.MenuItem12.SideBarGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.MenuItem12.SideBarStyle = UltimateMenus.KunalMenuItem.SideBarDrawStyle.DefaultGradient
        Me.MenuItem12.Text = "Current Account"
        '
        'MenuItem102
        '
        Me.MenuItem102.CheckedImageIndex = 0
        Me.MenuItem102.CheckedMenuItemBackColor = System.Drawing.SystemColors.Control
        Me.MenuItem102.CheckedMenuItemBorderColor = System.Drawing.SystemColors.Control
        Me.MenuItem102.CheckedMenuItemDisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(197, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(184, Byte), Integer))
        Me.MenuItem102.CheckedMenuItemIconShadowColor = System.Drawing.Color.Gray
        Me.MenuItem102.CheckedMenuItemStyle = UltimateMenus.KunalMenuItem.CheckedMenuStyles.CheckedItemDefault
        Me.MenuItem102.CheckedMenuItemTickMarkColor = System.Drawing.SystemColors.Control
        Me.MenuItem102.FillMenuBarItem = False
        Me.MenuItem102.HighLightForeColor = System.Drawing.SystemColors.HighlightText
        Me.MenuItem102.HighLightScheme = UltimateMenus.KunalMenuItem.HighLightColorDrawStyle.DefaultScheme
        Me.MenuItem102.HiliteGradientColor1 = System.Drawing.Color.WhiteSmoke
        Me.MenuItem102.HiliteGradientColor2 = System.Drawing.Color.CornflowerBlue
        Me.MenuItem102.HiLiteGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.MenuItem102.IconShadowColor = System.Drawing.Color.Gray
        Me.MenuItem102.ImageIndex = 0
        Me.MenuItem102.Index = 0
        Me.MenuItem102.MakeCheckedMenuItemIconTransparent = False
        Me.MenuItem102.MakeTransparentIcon = False
        Me.MenuItem102.MenuBarItemBorderColor = System.Drawing.Color.Black
        Me.MenuItem102.MenuBarItemFillColor = System.Drawing.SystemColors.Menu
        Me.MenuItem102.MenuBarItemFillingStyle = UltimateMenus.KunalMenuItem.MenuBarFillStyles.FillColor
        Me.MenuItem102.MenuBarItemGradientColor1 = System.Drawing.SystemColors.Menu
        Me.MenuItem102.MenuBarItemGradientColor2 = System.Drawing.SystemColors.Menu
        Me.MenuItem102.MenuBarItemGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.MenuItem102.OwnerDraw = True
        Me.MenuItem102.PreDefinedHiLiteColors = UltimateMenus.KunalMenuItem.PreDefinedHighLightColors.Khaki
        Me.MenuItem102.PreDefinedHiLiteGradientColors = UltimateMenus.KunalMenuItem.PreDefinedGrHighLightColors.BrownWhite
        Me.MenuItem102.PreDefinedSideBarGradientColour = UltimateMenus.KunalMenuItem.PreDefinedSideBarGradientColors.ShineyBlueYellow
        Me.MenuItem102.Shortcut = System.Windows.Forms.Shortcut.F7
        Me.MenuItem102.ShowBorderAroundMenuBar = False
        Me.MenuItem102.ShowHiliteOverSideBar = False
        Me.MenuItem102.ShowShadowUnderMenuBar = True
        Me.MenuItem102.SideBarGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.MenuItem102.SideBarStyle = UltimateMenus.KunalMenuItem.SideBarDrawStyle.DefaultGradient
        Me.MenuItem102.Text = "New Account"
        '
        'MenuItem104
        '
        Me.MenuItem104.CheckedImageIndex = 0
        Me.MenuItem104.CheckedMenuItemBackColor = System.Drawing.SystemColors.Control
        Me.MenuItem104.CheckedMenuItemBorderColor = System.Drawing.SystemColors.Control
        Me.MenuItem104.CheckedMenuItemDisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(197, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(184, Byte), Integer))
        Me.MenuItem104.CheckedMenuItemIconShadowColor = System.Drawing.Color.Gray
        Me.MenuItem104.CheckedMenuItemStyle = UltimateMenus.KunalMenuItem.CheckedMenuStyles.CheckedItemDefault
        Me.MenuItem104.CheckedMenuItemTickMarkColor = System.Drawing.SystemColors.Control
        Me.MenuItem104.FillMenuBarItem = False
        Me.MenuItem104.HighLightForeColor = System.Drawing.SystemColors.HighlightText
        Me.MenuItem104.HighLightScheme = UltimateMenus.KunalMenuItem.HighLightColorDrawStyle.DefaultScheme
        Me.MenuItem104.HiliteGradientColor1 = System.Drawing.Color.WhiteSmoke
        Me.MenuItem104.HiliteGradientColor2 = System.Drawing.Color.CornflowerBlue
        Me.MenuItem104.HiLiteGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.MenuItem104.IconShadowColor = System.Drawing.Color.Gray
        Me.MenuItem104.ImageIndex = 0
        Me.MenuItem104.Index = 1
        Me.MenuItem104.MakeCheckedMenuItemIconTransparent = False
        Me.MenuItem104.MakeTransparentIcon = False
        Me.MenuItem104.MenuBarItemBorderColor = System.Drawing.Color.Black
        Me.MenuItem104.MenuBarItemFillColor = System.Drawing.SystemColors.Menu
        Me.MenuItem104.MenuBarItemFillingStyle = UltimateMenus.KunalMenuItem.MenuBarFillStyles.FillColor
        Me.MenuItem104.MenuBarItemGradientColor1 = System.Drawing.SystemColors.Menu
        Me.MenuItem104.MenuBarItemGradientColor2 = System.Drawing.SystemColors.Menu
        Me.MenuItem104.MenuBarItemGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.MenuItem104.OwnerDraw = True
        Me.MenuItem104.PreDefinedHiLiteColors = UltimateMenus.KunalMenuItem.PreDefinedHighLightColors.Khaki
        Me.MenuItem104.PreDefinedHiLiteGradientColors = UltimateMenus.KunalMenuItem.PreDefinedGrHighLightColors.BrownWhite
        Me.MenuItem104.PreDefinedSideBarGradientColour = UltimateMenus.KunalMenuItem.PreDefinedSideBarGradientColors.ShineyBlueYellow
        Me.MenuItem104.Shortcut = System.Windows.Forms.Shortcut.CtrlF7
        Me.MenuItem104.ShowBorderAroundMenuBar = False
        Me.MenuItem104.ShowHiliteOverSideBar = False
        Me.MenuItem104.ShowShadowUnderMenuBar = True
        Me.MenuItem104.SideBarGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.MenuItem104.SideBarStyle = UltimateMenus.KunalMenuItem.SideBarDrawStyle.DefaultGradient
        Me.MenuItem104.Text = "View CA "
        '
        'MenuItem116
        '
        Me.MenuItem116.CheckedImageIndex = 0
        Me.MenuItem116.CheckedMenuItemBackColor = System.Drawing.SystemColors.Control
        Me.MenuItem116.CheckedMenuItemBorderColor = System.Drawing.SystemColors.Control
        Me.MenuItem116.CheckedMenuItemDisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(197, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(184, Byte), Integer))
        Me.MenuItem116.CheckedMenuItemIconShadowColor = System.Drawing.Color.Gray
        Me.MenuItem116.CheckedMenuItemStyle = UltimateMenus.KunalMenuItem.CheckedMenuStyles.CheckedItemDefault
        Me.MenuItem116.CheckedMenuItemTickMarkColor = System.Drawing.SystemColors.Control
        Me.MenuItem116.FillMenuBarItem = False
        Me.MenuItem116.HighLightForeColor = System.Drawing.SystemColors.HighlightText
        Me.MenuItem116.HighLightScheme = UltimateMenus.KunalMenuItem.HighLightColorDrawStyle.DefaultScheme
        Me.MenuItem116.HiliteGradientColor1 = System.Drawing.Color.WhiteSmoke
        Me.MenuItem116.HiliteGradientColor2 = System.Drawing.Color.CornflowerBlue
        Me.MenuItem116.HiLiteGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.MenuItem116.IconShadowColor = System.Drawing.Color.Gray
        Me.MenuItem116.ImageIndex = 0
        Me.MenuItem116.Index = 2
        Me.MenuItem116.MakeCheckedMenuItemIconTransparent = False
        Me.MenuItem116.MakeTransparentIcon = False
        Me.MenuItem116.MenuBarItemBorderColor = System.Drawing.Color.Black
        Me.MenuItem116.MenuBarItemFillColor = System.Drawing.SystemColors.Menu
        Me.MenuItem116.MenuBarItemFillingStyle = UltimateMenus.KunalMenuItem.MenuBarFillStyles.FillColor
        Me.MenuItem116.MenuBarItemGradientColor1 = System.Drawing.SystemColors.Menu
        Me.MenuItem116.MenuBarItemGradientColor2 = System.Drawing.SystemColors.Menu
        Me.MenuItem116.MenuBarItemGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.MenuItem116.OwnerDraw = True
        Me.MenuItem116.PreDefinedHiLiteColors = UltimateMenus.KunalMenuItem.PreDefinedHighLightColors.Khaki
        Me.MenuItem116.PreDefinedHiLiteGradientColors = UltimateMenus.KunalMenuItem.PreDefinedGrHighLightColors.BrownWhite
        Me.MenuItem116.PreDefinedSideBarGradientColour = UltimateMenus.KunalMenuItem.PreDefinedSideBarGradientColors.ShineyBlueYellow
        Me.MenuItem116.Shortcut = System.Windows.Forms.Shortcut.F2
        Me.MenuItem116.ShowBorderAroundMenuBar = False
        Me.MenuItem116.ShowHiliteOverSideBar = False
        Me.MenuItem116.ShowShadowUnderMenuBar = True
        Me.MenuItem116.SideBarGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.MenuItem116.SideBarStyle = UltimateMenus.KunalMenuItem.SideBarDrawStyle.DefaultGradient
        Me.MenuItem116.Text = "CashTransaction"
        '
        'MenuItem132
        '
        Me.MenuItem132.CheckedImageIndex = 0
        Me.MenuItem132.CheckedMenuItemBackColor = System.Drawing.SystemColors.Control
        Me.MenuItem132.CheckedMenuItemBorderColor = System.Drawing.SystemColors.Control
        Me.MenuItem132.CheckedMenuItemDisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(197, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(184, Byte), Integer))
        Me.MenuItem132.CheckedMenuItemIconShadowColor = System.Drawing.Color.Gray
        Me.MenuItem132.CheckedMenuItemStyle = UltimateMenus.KunalMenuItem.CheckedMenuStyles.CheckedItemDefault
        Me.MenuItem132.CheckedMenuItemTickMarkColor = System.Drawing.SystemColors.Control
        Me.MenuItem132.FillMenuBarItem = False
        Me.MenuItem132.HighLightForeColor = System.Drawing.SystemColors.HighlightText
        Me.MenuItem132.HighLightScheme = UltimateMenus.KunalMenuItem.HighLightColorDrawStyle.DefaultScheme
        Me.MenuItem132.HiliteGradientColor1 = System.Drawing.Color.WhiteSmoke
        Me.MenuItem132.HiliteGradientColor2 = System.Drawing.Color.CornflowerBlue
        Me.MenuItem132.HiLiteGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.MenuItem132.IconShadowColor = System.Drawing.Color.Gray
        Me.MenuItem132.ImageIndex = 0
        Me.MenuItem132.Index = 3
        Me.MenuItem132.MakeCheckedMenuItemIconTransparent = False
        Me.MenuItem132.MakeTransparentIcon = False
        Me.MenuItem132.MenuBarItemBorderColor = System.Drawing.Color.Black
        Me.MenuItem132.MenuBarItemFillColor = System.Drawing.SystemColors.Menu
        Me.MenuItem132.MenuBarItemFillingStyle = UltimateMenus.KunalMenuItem.MenuBarFillStyles.FillColor
        Me.MenuItem132.MenuBarItemGradientColor1 = System.Drawing.SystemColors.Menu
        Me.MenuItem132.MenuBarItemGradientColor2 = System.Drawing.SystemColors.Menu
        Me.MenuItem132.MenuBarItemGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.MenuItem132.OwnerDraw = True
        Me.MenuItem132.PreDefinedHiLiteColors = UltimateMenus.KunalMenuItem.PreDefinedHighLightColors.Khaki
        Me.MenuItem132.PreDefinedHiLiteGradientColors = UltimateMenus.KunalMenuItem.PreDefinedGrHighLightColors.BrownWhite
        Me.MenuItem132.PreDefinedSideBarGradientColour = UltimateMenus.KunalMenuItem.PreDefinedSideBarGradientColors.ShineyBlueYellow
        Me.MenuItem132.ShowBorderAroundMenuBar = False
        Me.MenuItem132.ShowHiliteOverSideBar = False
        Me.MenuItem132.ShowShadowUnderMenuBar = True
        Me.MenuItem132.SideBarGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.MenuItem132.SideBarStyle = UltimateMenus.KunalMenuItem.SideBarDrawStyle.DefaultGradient
        Me.MenuItem132.Text = "Deposit Cheque"
        '
        'MenuItem133
        '
        Me.MenuItem133.CheckedImageIndex = 0
        Me.MenuItem133.CheckedMenuItemBackColor = System.Drawing.SystemColors.Control
        Me.MenuItem133.CheckedMenuItemBorderColor = System.Drawing.SystemColors.Control
        Me.MenuItem133.CheckedMenuItemDisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(197, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(184, Byte), Integer))
        Me.MenuItem133.CheckedMenuItemIconShadowColor = System.Drawing.Color.Gray
        Me.MenuItem133.CheckedMenuItemStyle = UltimateMenus.KunalMenuItem.CheckedMenuStyles.CheckedItemDefault
        Me.MenuItem133.CheckedMenuItemTickMarkColor = System.Drawing.SystemColors.Control
        Me.MenuItem133.FillMenuBarItem = False
        Me.MenuItem133.HighLightForeColor = System.Drawing.SystemColors.HighlightText
        Me.MenuItem133.HighLightScheme = UltimateMenus.KunalMenuItem.HighLightColorDrawStyle.DefaultScheme
        Me.MenuItem133.HiliteGradientColor1 = System.Drawing.Color.WhiteSmoke
        Me.MenuItem133.HiliteGradientColor2 = System.Drawing.Color.CornflowerBlue
        Me.MenuItem133.HiLiteGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.MenuItem133.IconShadowColor = System.Drawing.Color.Gray
        Me.MenuItem133.ImageIndex = 0
        Me.MenuItem133.Index = 4
        Me.MenuItem133.MakeCheckedMenuItemIconTransparent = False
        Me.MenuItem133.MakeTransparentIcon = False
        Me.MenuItem133.MenuBarItemBorderColor = System.Drawing.Color.Black
        Me.MenuItem133.MenuBarItemFillColor = System.Drawing.SystemColors.Menu
        Me.MenuItem133.MenuBarItemFillingStyle = UltimateMenus.KunalMenuItem.MenuBarFillStyles.FillColor
        Me.MenuItem133.MenuBarItemGradientColor1 = System.Drawing.SystemColors.Menu
        Me.MenuItem133.MenuBarItemGradientColor2 = System.Drawing.SystemColors.Menu
        Me.MenuItem133.MenuBarItemGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.MenuItem133.OwnerDraw = True
        Me.MenuItem133.PreDefinedHiLiteColors = UltimateMenus.KunalMenuItem.PreDefinedHighLightColors.Khaki
        Me.MenuItem133.PreDefinedHiLiteGradientColors = UltimateMenus.KunalMenuItem.PreDefinedGrHighLightColors.BrownWhite
        Me.MenuItem133.PreDefinedSideBarGradientColour = UltimateMenus.KunalMenuItem.PreDefinedSideBarGradientColors.ShineyBlueYellow
        Me.MenuItem133.ShowBorderAroundMenuBar = False
        Me.MenuItem133.ShowHiliteOverSideBar = False
        Me.MenuItem133.ShowShadowUnderMenuBar = True
        Me.MenuItem133.SideBarGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.MenuItem133.SideBarStyle = UltimateMenus.KunalMenuItem.SideBarDrawStyle.DefaultGradient
        Me.MenuItem133.Text = "Cheque Withdraw"
        '
        'MenuItem134
        '
        Me.MenuItem134.CheckedImageIndex = 0
        Me.MenuItem134.CheckedMenuItemBackColor = System.Drawing.SystemColors.Control
        Me.MenuItem134.CheckedMenuItemBorderColor = System.Drawing.SystemColors.Control
        Me.MenuItem134.CheckedMenuItemDisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(197, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(184, Byte), Integer))
        Me.MenuItem134.CheckedMenuItemIconShadowColor = System.Drawing.Color.Gray
        Me.MenuItem134.CheckedMenuItemStyle = UltimateMenus.KunalMenuItem.CheckedMenuStyles.CheckedItemDefault
        Me.MenuItem134.CheckedMenuItemTickMarkColor = System.Drawing.SystemColors.Control
        Me.MenuItem134.FillMenuBarItem = False
        Me.MenuItem134.HighLightForeColor = System.Drawing.SystemColors.HighlightText
        Me.MenuItem134.HighLightScheme = UltimateMenus.KunalMenuItem.HighLightColorDrawStyle.DefaultScheme
        Me.MenuItem134.HiliteGradientColor1 = System.Drawing.Color.WhiteSmoke
        Me.MenuItem134.HiliteGradientColor2 = System.Drawing.Color.CornflowerBlue
        Me.MenuItem134.HiLiteGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.MenuItem134.IconShadowColor = System.Drawing.Color.Gray
        Me.MenuItem134.ImageIndex = 0
        Me.MenuItem134.Index = 5
        Me.MenuItem134.MakeCheckedMenuItemIconTransparent = False
        Me.MenuItem134.MakeTransparentIcon = False
        Me.MenuItem134.MenuBarItemBorderColor = System.Drawing.Color.Black
        Me.MenuItem134.MenuBarItemFillColor = System.Drawing.SystemColors.Menu
        Me.MenuItem134.MenuBarItemFillingStyle = UltimateMenus.KunalMenuItem.MenuBarFillStyles.FillColor
        Me.MenuItem134.MenuBarItemGradientColor1 = System.Drawing.SystemColors.Menu
        Me.MenuItem134.MenuBarItemGradientColor2 = System.Drawing.SystemColors.Menu
        Me.MenuItem134.MenuBarItemGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.MenuItem134.OwnerDraw = True
        Me.MenuItem134.PreDefinedHiLiteColors = UltimateMenus.KunalMenuItem.PreDefinedHighLightColors.Khaki
        Me.MenuItem134.PreDefinedHiLiteGradientColors = UltimateMenus.KunalMenuItem.PreDefinedGrHighLightColors.BrownWhite
        Me.MenuItem134.PreDefinedSideBarGradientColour = UltimateMenus.KunalMenuItem.PreDefinedSideBarGradientColors.ShineyBlueYellow
        Me.MenuItem134.ShowBorderAroundMenuBar = False
        Me.MenuItem134.ShowHiliteOverSideBar = False
        Me.MenuItem134.ShowShadowUnderMenuBar = True
        Me.MenuItem134.SideBarGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.MenuItem134.SideBarStyle = UltimateMenus.KunalMenuItem.SideBarDrawStyle.DefaultGradient
        Me.MenuItem134.Text = "Cheque's Detail"
        '
        'MenuItem135
        '
        Me.MenuItem135.CheckedImageIndex = 0
        Me.MenuItem135.CheckedMenuItemBackColor = System.Drawing.SystemColors.Control
        Me.MenuItem135.CheckedMenuItemBorderColor = System.Drawing.SystemColors.Control
        Me.MenuItem135.CheckedMenuItemDisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(197, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(184, Byte), Integer))
        Me.MenuItem135.CheckedMenuItemIconShadowColor = System.Drawing.Color.Gray
        Me.MenuItem135.CheckedMenuItemStyle = UltimateMenus.KunalMenuItem.CheckedMenuStyles.CheckedItemDefault
        Me.MenuItem135.CheckedMenuItemTickMarkColor = System.Drawing.SystemColors.Control
        Me.MenuItem135.FillMenuBarItem = False
        Me.MenuItem135.HighLightForeColor = System.Drawing.SystemColors.HighlightText
        Me.MenuItem135.HighLightScheme = UltimateMenus.KunalMenuItem.HighLightColorDrawStyle.DefaultScheme
        Me.MenuItem135.HiliteGradientColor1 = System.Drawing.Color.WhiteSmoke
        Me.MenuItem135.HiliteGradientColor2 = System.Drawing.Color.CornflowerBlue
        Me.MenuItem135.HiLiteGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.MenuItem135.IconShadowColor = System.Drawing.Color.Gray
        Me.MenuItem135.ImageIndex = 0
        Me.MenuItem135.Index = 6
        Me.MenuItem135.MakeCheckedMenuItemIconTransparent = False
        Me.MenuItem135.MakeTransparentIcon = False
        Me.MenuItem135.MenuBarItemBorderColor = System.Drawing.Color.Black
        Me.MenuItem135.MenuBarItemFillColor = System.Drawing.SystemColors.Menu
        Me.MenuItem135.MenuBarItemFillingStyle = UltimateMenus.KunalMenuItem.MenuBarFillStyles.FillColor
        Me.MenuItem135.MenuBarItemGradientColor1 = System.Drawing.SystemColors.Menu
        Me.MenuItem135.MenuBarItemGradientColor2 = System.Drawing.SystemColors.Menu
        Me.MenuItem135.MenuBarItemGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.MenuItem135.OwnerDraw = True
        Me.MenuItem135.PreDefinedHiLiteColors = UltimateMenus.KunalMenuItem.PreDefinedHighLightColors.Khaki
        Me.MenuItem135.PreDefinedHiLiteGradientColors = UltimateMenus.KunalMenuItem.PreDefinedGrHighLightColors.BrownWhite
        Me.MenuItem135.PreDefinedSideBarGradientColour = UltimateMenus.KunalMenuItem.PreDefinedSideBarGradientColors.ShineyBlueYellow
        Me.MenuItem135.ShowBorderAroundMenuBar = False
        Me.MenuItem135.ShowHiliteOverSideBar = False
        Me.MenuItem135.ShowShadowUnderMenuBar = True
        Me.MenuItem135.SideBarGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.MenuItem135.SideBarStyle = UltimateMenus.KunalMenuItem.SideBarDrawStyle.DefaultGradient
        Me.MenuItem135.Text = "Issue Cheque Book"
        '
        'MenuItem125
        '
        Me.MenuItem125.CheckedImageIndex = 0
        Me.MenuItem125.CheckedMenuItemBackColor = System.Drawing.SystemColors.Control
        Me.MenuItem125.CheckedMenuItemBorderColor = System.Drawing.SystemColors.Control
        Me.MenuItem125.CheckedMenuItemDisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(197, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(184, Byte), Integer))
        Me.MenuItem125.CheckedMenuItemIconShadowColor = System.Drawing.Color.Gray
        Me.MenuItem125.CheckedMenuItemStyle = UltimateMenus.KunalMenuItem.CheckedMenuStyles.CheckedItemDefault
        Me.MenuItem125.CheckedMenuItemTickMarkColor = System.Drawing.SystemColors.Control
        Me.MenuItem125.FillMenuBarItem = False
        Me.MenuItem125.HighLightForeColor = System.Drawing.SystemColors.HighlightText
        Me.MenuItem125.HighLightScheme = UltimateMenus.KunalMenuItem.HighLightColorDrawStyle.DefaultScheme
        Me.MenuItem125.HiliteGradientColor1 = System.Drawing.Color.WhiteSmoke
        Me.MenuItem125.HiliteGradientColor2 = System.Drawing.Color.CornflowerBlue
        Me.MenuItem125.HiLiteGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.MenuItem125.IconShadowColor = System.Drawing.Color.Gray
        Me.MenuItem125.ImageIndex = 0
        Me.MenuItem125.Index = 7
        Me.MenuItem125.MakeCheckedMenuItemIconTransparent = False
        Me.MenuItem125.MakeTransparentIcon = False
        Me.MenuItem125.MenuBarItemBorderColor = System.Drawing.Color.Black
        Me.MenuItem125.MenuBarItemFillColor = System.Drawing.SystemColors.Menu
        Me.MenuItem125.MenuBarItemFillingStyle = UltimateMenus.KunalMenuItem.MenuBarFillStyles.FillColor
        Me.MenuItem125.MenuBarItemGradientColor1 = System.Drawing.SystemColors.Menu
        Me.MenuItem125.MenuBarItemGradientColor2 = System.Drawing.SystemColors.Menu
        Me.MenuItem125.MenuBarItemGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.MenuItem125.OwnerDraw = True
        Me.MenuItem125.PreDefinedHiLiteColors = UltimateMenus.KunalMenuItem.PreDefinedHighLightColors.Khaki
        Me.MenuItem125.PreDefinedHiLiteGradientColors = UltimateMenus.KunalMenuItem.PreDefinedGrHighLightColors.BrownWhite
        Me.MenuItem125.PreDefinedSideBarGradientColour = UltimateMenus.KunalMenuItem.PreDefinedSideBarGradientColors.ShineyBlueYellow
        Me.MenuItem125.ShowBorderAroundMenuBar = False
        Me.MenuItem125.ShowHiliteOverSideBar = False
        Me.MenuItem125.ShowShadowUnderMenuBar = True
        Me.MenuItem125.SideBarGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.MenuItem125.SideBarStyle = UltimateMenus.KunalMenuItem.SideBarDrawStyle.DefaultGradient
        Me.MenuItem125.Text = "Interest posting"
        '
        'MenuItem127
        '
        Me.MenuItem127.CheckedImageIndex = 0
        Me.MenuItem127.CheckedMenuItemBackColor = System.Drawing.SystemColors.Control
        Me.MenuItem127.CheckedMenuItemBorderColor = System.Drawing.SystemColors.Control
        Me.MenuItem127.CheckedMenuItemDisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(197, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(184, Byte), Integer))
        Me.MenuItem127.CheckedMenuItemIconShadowColor = System.Drawing.Color.Gray
        Me.MenuItem127.CheckedMenuItemStyle = UltimateMenus.KunalMenuItem.CheckedMenuStyles.CheckedItemDefault
        Me.MenuItem127.CheckedMenuItemTickMarkColor = System.Drawing.SystemColors.Control
        Me.MenuItem127.FillMenuBarItem = False
        Me.MenuItem127.HighLightForeColor = System.Drawing.SystemColors.HighlightText
        Me.MenuItem127.HighLightScheme = UltimateMenus.KunalMenuItem.HighLightColorDrawStyle.DefaultScheme
        Me.MenuItem127.HiliteGradientColor1 = System.Drawing.Color.WhiteSmoke
        Me.MenuItem127.HiliteGradientColor2 = System.Drawing.Color.CornflowerBlue
        Me.MenuItem127.HiLiteGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.MenuItem127.IconShadowColor = System.Drawing.Color.Gray
        Me.MenuItem127.ImageIndex = 0
        Me.MenuItem127.Index = 8
        Me.MenuItem127.MakeCheckedMenuItemIconTransparent = False
        Me.MenuItem127.MakeTransparentIcon = False
        Me.MenuItem127.MenuBarItemBorderColor = System.Drawing.Color.Black
        Me.MenuItem127.MenuBarItemFillColor = System.Drawing.SystemColors.Menu
        Me.MenuItem127.MenuBarItemFillingStyle = UltimateMenus.KunalMenuItem.MenuBarFillStyles.FillColor
        Me.MenuItem127.MenuBarItemGradientColor1 = System.Drawing.SystemColors.Menu
        Me.MenuItem127.MenuBarItemGradientColor2 = System.Drawing.SystemColors.Menu
        Me.MenuItem127.MenuBarItemGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.MenuItem127.OwnerDraw = True
        Me.MenuItem127.PreDefinedHiLiteColors = UltimateMenus.KunalMenuItem.PreDefinedHighLightColors.Khaki
        Me.MenuItem127.PreDefinedHiLiteGradientColors = UltimateMenus.KunalMenuItem.PreDefinedGrHighLightColors.BrownWhite
        Me.MenuItem127.PreDefinedSideBarGradientColour = UltimateMenus.KunalMenuItem.PreDefinedSideBarGradientColors.ShineyBlueYellow
        Me.MenuItem127.ShowBorderAroundMenuBar = False
        Me.MenuItem127.ShowHiliteOverSideBar = False
        Me.MenuItem127.ShowShadowUnderMenuBar = True
        Me.MenuItem127.SideBarGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.MenuItem127.SideBarStyle = UltimateMenus.KunalMenuItem.SideBarDrawStyle.DefaultGradient
        Me.MenuItem127.Text = "Transaction View"
        '
        'MenuItem4
        '
        Me.MenuItem4.CheckedImageIndex = 0
        Me.MenuItem4.CheckedMenuItemBackColor = System.Drawing.SystemColors.Control
        Me.MenuItem4.CheckedMenuItemBorderColor = System.Drawing.SystemColors.Control
        Me.MenuItem4.CheckedMenuItemDisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(197, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(184, Byte), Integer))
        Me.MenuItem4.CheckedMenuItemIconShadowColor = System.Drawing.Color.Gray
        Me.MenuItem4.CheckedMenuItemStyle = UltimateMenus.KunalMenuItem.CheckedMenuStyles.CheckedItemDefault
        Me.MenuItem4.CheckedMenuItemTickMarkColor = System.Drawing.SystemColors.Control
        Me.MenuItem4.FillMenuBarItem = False
        Me.MenuItem4.HighLightForeColor = System.Drawing.SystemColors.HighlightText
        Me.MenuItem4.HighLightScheme = UltimateMenus.KunalMenuItem.HighLightColorDrawStyle.DefaultScheme
        Me.MenuItem4.HiliteGradientColor1 = System.Drawing.Color.WhiteSmoke
        Me.MenuItem4.HiliteGradientColor2 = System.Drawing.Color.CornflowerBlue
        Me.MenuItem4.HiLiteGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.MenuItem4.IconShadowColor = System.Drawing.Color.Gray
        Me.MenuItem4.ImageIndex = 0
        Me.MenuItem4.Index = 5
        Me.MenuItem4.MakeCheckedMenuItemIconTransparent = False
        Me.MenuItem4.MakeTransparentIcon = False
        Me.MenuItem4.MenuBarItemBorderColor = System.Drawing.Color.Black
        Me.MenuItem4.MenuBarItemFillColor = System.Drawing.SystemColors.Menu
        Me.MenuItem4.MenuBarItemFillingStyle = UltimateMenus.KunalMenuItem.MenuBarFillStyles.FillColor
        Me.MenuItem4.MenuBarItemGradientColor1 = System.Drawing.SystemColors.Menu
        Me.MenuItem4.MenuBarItemGradientColor2 = System.Drawing.SystemColors.Menu
        Me.MenuItem4.MenuBarItemGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.MenuItem4.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem29, Me.MenuItem30, Me.MenuItem31})
        Me.MenuItem4.OwnerDraw = True
        Me.MenuItem4.PreDefinedHiLiteColors = UltimateMenus.KunalMenuItem.PreDefinedHighLightColors.Khaki
        Me.MenuItem4.PreDefinedHiLiteGradientColors = UltimateMenus.KunalMenuItem.PreDefinedGrHighLightColors.BrownWhite
        Me.MenuItem4.PreDefinedSideBarGradientColour = UltimateMenus.KunalMenuItem.PreDefinedSideBarGradientColors.ShineyBlueYellow
        Me.MenuItem4.ShowBorderAroundMenuBar = False
        Me.MenuItem4.ShowHiliteOverSideBar = False
        Me.MenuItem4.ShowShadowUnderMenuBar = True
        Me.MenuItem4.SideBarGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.MenuItem4.SideBarStyle = UltimateMenus.KunalMenuItem.SideBarDrawStyle.DefaultGradient
        Me.MenuItem4.Text = "&Deposits"
        '
        'MenuItem29
        '
        Me.MenuItem29.CheckedImageIndex = 0
        Me.MenuItem29.CheckedMenuItemBackColor = System.Drawing.SystemColors.Control
        Me.MenuItem29.CheckedMenuItemBorderColor = System.Drawing.SystemColors.Control
        Me.MenuItem29.CheckedMenuItemDisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(197, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(184, Byte), Integer))
        Me.MenuItem29.CheckedMenuItemIconShadowColor = System.Drawing.Color.Gray
        Me.MenuItem29.CheckedMenuItemStyle = UltimateMenus.KunalMenuItem.CheckedMenuStyles.CheckedItemDefault
        Me.MenuItem29.CheckedMenuItemTickMarkColor = System.Drawing.SystemColors.Control
        Me.MenuItem29.FillMenuBarItem = False
        Me.MenuItem29.HighLightForeColor = System.Drawing.SystemColors.HighlightText
        Me.MenuItem29.HighLightScheme = UltimateMenus.KunalMenuItem.HighLightColorDrawStyle.DefaultScheme
        Me.MenuItem29.HiliteGradientColor1 = System.Drawing.Color.WhiteSmoke
        Me.MenuItem29.HiliteGradientColor2 = System.Drawing.Color.CornflowerBlue
        Me.MenuItem29.HiLiteGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.MenuItem29.IconShadowColor = System.Drawing.Color.Gray
        Me.MenuItem29.ImageIndex = 0
        Me.MenuItem29.Index = 0
        Me.MenuItem29.MakeCheckedMenuItemIconTransparent = False
        Me.MenuItem29.MakeTransparentIcon = False
        Me.MenuItem29.MenuBarItemBorderColor = System.Drawing.Color.Black
        Me.MenuItem29.MenuBarItemFillColor = System.Drawing.SystemColors.Menu
        Me.MenuItem29.MenuBarItemFillingStyle = UltimateMenus.KunalMenuItem.MenuBarFillStyles.FillColor
        Me.MenuItem29.MenuBarItemGradientColor1 = System.Drawing.SystemColors.Menu
        Me.MenuItem29.MenuBarItemGradientColor2 = System.Drawing.SystemColors.Menu
        Me.MenuItem29.MenuBarItemGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.MenuItem29.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem32, Me.MenuItem33, Me.MenuItem34, Me.MenuItem35, Me.MenuItem36, Me.MenuItem74, Me.MenuItem37, Me.smnuDuplicateFD, Me.smnuFDPremature, Me.MenuItem143, Me.MenuItem167, Me.MenuItem168})
        Me.MenuItem29.OwnerDraw = True
        Me.MenuItem29.PreDefinedHiLiteColors = UltimateMenus.KunalMenuItem.PreDefinedHighLightColors.Khaki
        Me.MenuItem29.PreDefinedHiLiteGradientColors = UltimateMenus.KunalMenuItem.PreDefinedGrHighLightColors.BrownWhite
        Me.MenuItem29.PreDefinedSideBarGradientColour = UltimateMenus.KunalMenuItem.PreDefinedSideBarGradientColors.ShineyBlueYellow
        Me.MenuItem29.ShowBorderAroundMenuBar = False
        Me.MenuItem29.ShowHiliteOverSideBar = False
        Me.MenuItem29.ShowShadowUnderMenuBar = True
        Me.MenuItem29.SideBarGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.MenuItem29.SideBarStyle = UltimateMenus.KunalMenuItem.SideBarDrawStyle.DefaultGradient
        Me.MenuItem29.Text = "FD / ENNVY / SC"
        '
        'MenuItem32
        '
        Me.MenuItem32.CheckedImageIndex = 0
        Me.MenuItem32.CheckedMenuItemBackColor = System.Drawing.SystemColors.Control
        Me.MenuItem32.CheckedMenuItemBorderColor = System.Drawing.SystemColors.Control
        Me.MenuItem32.CheckedMenuItemDisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(197, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(184, Byte), Integer))
        Me.MenuItem32.CheckedMenuItemIconShadowColor = System.Drawing.Color.Gray
        Me.MenuItem32.CheckedMenuItemStyle = UltimateMenus.KunalMenuItem.CheckedMenuStyles.CheckedItemDefault
        Me.MenuItem32.CheckedMenuItemTickMarkColor = System.Drawing.SystemColors.Control
        Me.MenuItem32.FillMenuBarItem = False
        Me.MenuItem32.HighLightForeColor = System.Drawing.SystemColors.HighlightText
        Me.MenuItem32.HighLightScheme = UltimateMenus.KunalMenuItem.HighLightColorDrawStyle.DefaultScheme
        Me.MenuItem32.HiliteGradientColor1 = System.Drawing.Color.WhiteSmoke
        Me.MenuItem32.HiliteGradientColor2 = System.Drawing.Color.CornflowerBlue
        Me.MenuItem32.HiLiteGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.MenuItem32.IconShadowColor = System.Drawing.Color.Gray
        Me.MenuItem32.ImageIndex = 0
        Me.MenuItem32.Index = 0
        Me.MenuItem32.MakeCheckedMenuItemIconTransparent = False
        Me.MenuItem32.MakeTransparentIcon = False
        Me.MenuItem32.MenuBarItemBorderColor = System.Drawing.Color.Black
        Me.MenuItem32.MenuBarItemFillColor = System.Drawing.SystemColors.Menu
        Me.MenuItem32.MenuBarItemFillingStyle = UltimateMenus.KunalMenuItem.MenuBarFillStyles.FillColor
        Me.MenuItem32.MenuBarItemGradientColor1 = System.Drawing.SystemColors.Menu
        Me.MenuItem32.MenuBarItemGradientColor2 = System.Drawing.SystemColors.Menu
        Me.MenuItem32.MenuBarItemGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.MenuItem32.OwnerDraw = True
        Me.MenuItem32.PreDefinedHiLiteColors = UltimateMenus.KunalMenuItem.PreDefinedHighLightColors.Khaki
        Me.MenuItem32.PreDefinedHiLiteGradientColors = UltimateMenus.KunalMenuItem.PreDefinedGrHighLightColors.BrownWhite
        Me.MenuItem32.PreDefinedSideBarGradientColour = UltimateMenus.KunalMenuItem.PreDefinedSideBarGradientColors.ShineyBlueYellow
        Me.MenuItem32.Shortcut = System.Windows.Forms.Shortcut.F8
        Me.MenuItem32.ShowBorderAroundMenuBar = False
        Me.MenuItem32.ShowHiliteOverSideBar = False
        Me.MenuItem32.ShowShadowUnderMenuBar = True
        Me.MenuItem32.SideBarGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.MenuItem32.SideBarStyle = UltimateMenus.KunalMenuItem.SideBarDrawStyle.DefaultGradient
        Me.MenuItem32.Text = "New  Account"
        '
        'MenuItem33
        '
        Me.MenuItem33.CheckedImageIndex = 0
        Me.MenuItem33.CheckedMenuItemBackColor = System.Drawing.SystemColors.Control
        Me.MenuItem33.CheckedMenuItemBorderColor = System.Drawing.SystemColors.Control
        Me.MenuItem33.CheckedMenuItemDisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(197, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(184, Byte), Integer))
        Me.MenuItem33.CheckedMenuItemIconShadowColor = System.Drawing.Color.Gray
        Me.MenuItem33.CheckedMenuItemStyle = UltimateMenus.KunalMenuItem.CheckedMenuStyles.CheckedItemDefault
        Me.MenuItem33.CheckedMenuItemTickMarkColor = System.Drawing.SystemColors.Control
        Me.MenuItem33.FillMenuBarItem = False
        Me.MenuItem33.HighLightForeColor = System.Drawing.SystemColors.HighlightText
        Me.MenuItem33.HighLightScheme = UltimateMenus.KunalMenuItem.HighLightColorDrawStyle.DefaultScheme
        Me.MenuItem33.HiliteGradientColor1 = System.Drawing.Color.WhiteSmoke
        Me.MenuItem33.HiliteGradientColor2 = System.Drawing.Color.CornflowerBlue
        Me.MenuItem33.HiLiteGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.MenuItem33.IconShadowColor = System.Drawing.Color.Gray
        Me.MenuItem33.ImageIndex = 0
        Me.MenuItem33.Index = 1
        Me.MenuItem33.MakeCheckedMenuItemIconTransparent = False
        Me.MenuItem33.MakeTransparentIcon = False
        Me.MenuItem33.MenuBarItemBorderColor = System.Drawing.Color.Black
        Me.MenuItem33.MenuBarItemFillColor = System.Drawing.SystemColors.Menu
        Me.MenuItem33.MenuBarItemFillingStyle = UltimateMenus.KunalMenuItem.MenuBarFillStyles.FillColor
        Me.MenuItem33.MenuBarItemGradientColor1 = System.Drawing.SystemColors.Menu
        Me.MenuItem33.MenuBarItemGradientColor2 = System.Drawing.SystemColors.Menu
        Me.MenuItem33.MenuBarItemGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.MenuItem33.OwnerDraw = True
        Me.MenuItem33.PreDefinedHiLiteColors = UltimateMenus.KunalMenuItem.PreDefinedHighLightColors.Khaki
        Me.MenuItem33.PreDefinedHiLiteGradientColors = UltimateMenus.KunalMenuItem.PreDefinedGrHighLightColors.BrownWhite
        Me.MenuItem33.PreDefinedSideBarGradientColour = UltimateMenus.KunalMenuItem.PreDefinedSideBarGradientColors.ShineyBlueYellow
        Me.MenuItem33.ShowBorderAroundMenuBar = False
        Me.MenuItem33.ShowHiliteOverSideBar = False
        Me.MenuItem33.ShowShadowUnderMenuBar = True
        Me.MenuItem33.SideBarGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.MenuItem33.SideBarStyle = UltimateMenus.KunalMenuItem.SideBarDrawStyle.DefaultGradient
        Me.MenuItem33.Text = "Interest Payments"
        '
        'MenuItem34
        '
        Me.MenuItem34.CheckedImageIndex = 0
        Me.MenuItem34.CheckedMenuItemBackColor = System.Drawing.SystemColors.Control
        Me.MenuItem34.CheckedMenuItemBorderColor = System.Drawing.SystemColors.Control
        Me.MenuItem34.CheckedMenuItemDisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(197, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(184, Byte), Integer))
        Me.MenuItem34.CheckedMenuItemIconShadowColor = System.Drawing.Color.Gray
        Me.MenuItem34.CheckedMenuItemStyle = UltimateMenus.KunalMenuItem.CheckedMenuStyles.CheckedItemDefault
        Me.MenuItem34.CheckedMenuItemTickMarkColor = System.Drawing.SystemColors.Control
        Me.MenuItem34.FillMenuBarItem = False
        Me.MenuItem34.HighLightForeColor = System.Drawing.SystemColors.HighlightText
        Me.MenuItem34.HighLightScheme = UltimateMenus.KunalMenuItem.HighLightColorDrawStyle.DefaultScheme
        Me.MenuItem34.HiliteGradientColor1 = System.Drawing.Color.WhiteSmoke
        Me.MenuItem34.HiliteGradientColor2 = System.Drawing.Color.CornflowerBlue
        Me.MenuItem34.HiLiteGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.MenuItem34.IconShadowColor = System.Drawing.Color.Gray
        Me.MenuItem34.ImageIndex = 0
        Me.MenuItem34.Index = 2
        Me.MenuItem34.MakeCheckedMenuItemIconTransparent = False
        Me.MenuItem34.MakeTransparentIcon = False
        Me.MenuItem34.MenuBarItemBorderColor = System.Drawing.Color.Black
        Me.MenuItem34.MenuBarItemFillColor = System.Drawing.SystemColors.Menu
        Me.MenuItem34.MenuBarItemFillingStyle = UltimateMenus.KunalMenuItem.MenuBarFillStyles.FillColor
        Me.MenuItem34.MenuBarItemGradientColor1 = System.Drawing.SystemColors.Menu
        Me.MenuItem34.MenuBarItemGradientColor2 = System.Drawing.SystemColors.Menu
        Me.MenuItem34.MenuBarItemGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.MenuItem34.OwnerDraw = True
        Me.MenuItem34.PreDefinedHiLiteColors = UltimateMenus.KunalMenuItem.PreDefinedHighLightColors.Khaki
        Me.MenuItem34.PreDefinedHiLiteGradientColors = UltimateMenus.KunalMenuItem.PreDefinedGrHighLightColors.BrownWhite
        Me.MenuItem34.PreDefinedSideBarGradientColour = UltimateMenus.KunalMenuItem.PreDefinedSideBarGradientColors.ShineyBlueYellow
        Me.MenuItem34.ShowBorderAroundMenuBar = False
        Me.MenuItem34.ShowHiliteOverSideBar = False
        Me.MenuItem34.ShowShadowUnderMenuBar = True
        Me.MenuItem34.SideBarGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.MenuItem34.SideBarStyle = UltimateMenus.KunalMenuItem.SideBarDrawStyle.DefaultGradient
        Me.MenuItem34.Text = "Interest Postings"
        Me.MenuItem34.Visible = False
        '
        'MenuItem35
        '
        Me.MenuItem35.CheckedImageIndex = 0
        Me.MenuItem35.CheckedMenuItemBackColor = System.Drawing.SystemColors.Control
        Me.MenuItem35.CheckedMenuItemBorderColor = System.Drawing.SystemColors.Control
        Me.MenuItem35.CheckedMenuItemDisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(197, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(184, Byte), Integer))
        Me.MenuItem35.CheckedMenuItemIconShadowColor = System.Drawing.Color.Gray
        Me.MenuItem35.CheckedMenuItemStyle = UltimateMenus.KunalMenuItem.CheckedMenuStyles.CheckedItemDefault
        Me.MenuItem35.CheckedMenuItemTickMarkColor = System.Drawing.SystemColors.Control
        Me.MenuItem35.FillMenuBarItem = False
        Me.MenuItem35.HighLightForeColor = System.Drawing.SystemColors.HighlightText
        Me.MenuItem35.HighLightScheme = UltimateMenus.KunalMenuItem.HighLightColorDrawStyle.DefaultScheme
        Me.MenuItem35.HiliteGradientColor1 = System.Drawing.Color.WhiteSmoke
        Me.MenuItem35.HiliteGradientColor2 = System.Drawing.Color.CornflowerBlue
        Me.MenuItem35.HiLiteGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.MenuItem35.IconShadowColor = System.Drawing.Color.Gray
        Me.MenuItem35.ImageIndex = 0
        Me.MenuItem35.Index = 3
        Me.MenuItem35.MakeCheckedMenuItemIconTransparent = False
        Me.MenuItem35.MakeTransparentIcon = False
        Me.MenuItem35.MenuBarItemBorderColor = System.Drawing.Color.Black
        Me.MenuItem35.MenuBarItemFillColor = System.Drawing.SystemColors.Menu
        Me.MenuItem35.MenuBarItemFillingStyle = UltimateMenus.KunalMenuItem.MenuBarFillStyles.FillColor
        Me.MenuItem35.MenuBarItemGradientColor1 = System.Drawing.SystemColors.Menu
        Me.MenuItem35.MenuBarItemGradientColor2 = System.Drawing.SystemColors.Menu
        Me.MenuItem35.MenuBarItemGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.MenuItem35.OwnerDraw = True
        Me.MenuItem35.PreDefinedHiLiteColors = UltimateMenus.KunalMenuItem.PreDefinedHighLightColors.Khaki
        Me.MenuItem35.PreDefinedHiLiteGradientColors = UltimateMenus.KunalMenuItem.PreDefinedGrHighLightColors.BrownWhite
        Me.MenuItem35.PreDefinedSideBarGradientColour = UltimateMenus.KunalMenuItem.PreDefinedSideBarGradientColors.ShineyBlueYellow
        Me.MenuItem35.ShowBorderAroundMenuBar = False
        Me.MenuItem35.ShowHiliteOverSideBar = False
        Me.MenuItem35.ShowShadowUnderMenuBar = True
        Me.MenuItem35.SideBarGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.MenuItem35.SideBarStyle = UltimateMenus.KunalMenuItem.SideBarDrawStyle.DefaultGradient
        Me.MenuItem35.Text = "FD Renewal"
        '
        'MenuItem36
        '
        Me.MenuItem36.CheckedImageIndex = 0
        Me.MenuItem36.CheckedMenuItemBackColor = System.Drawing.SystemColors.Control
        Me.MenuItem36.CheckedMenuItemBorderColor = System.Drawing.SystemColors.Control
        Me.MenuItem36.CheckedMenuItemDisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(197, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(184, Byte), Integer))
        Me.MenuItem36.CheckedMenuItemIconShadowColor = System.Drawing.Color.Gray
        Me.MenuItem36.CheckedMenuItemStyle = UltimateMenus.KunalMenuItem.CheckedMenuStyles.CheckedItemDefault
        Me.MenuItem36.CheckedMenuItemTickMarkColor = System.Drawing.SystemColors.Control
        Me.MenuItem36.FillMenuBarItem = False
        Me.MenuItem36.HighLightForeColor = System.Drawing.SystemColors.HighlightText
        Me.MenuItem36.HighLightScheme = UltimateMenus.KunalMenuItem.HighLightColorDrawStyle.DefaultScheme
        Me.MenuItem36.HiliteGradientColor1 = System.Drawing.Color.WhiteSmoke
        Me.MenuItem36.HiliteGradientColor2 = System.Drawing.Color.CornflowerBlue
        Me.MenuItem36.HiLiteGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.MenuItem36.IconShadowColor = System.Drawing.Color.Gray
        Me.MenuItem36.ImageIndex = 0
        Me.MenuItem36.Index = 4
        Me.MenuItem36.MakeCheckedMenuItemIconTransparent = False
        Me.MenuItem36.MakeTransparentIcon = False
        Me.MenuItem36.MenuBarItemBorderColor = System.Drawing.Color.Black
        Me.MenuItem36.MenuBarItemFillColor = System.Drawing.SystemColors.Menu
        Me.MenuItem36.MenuBarItemFillingStyle = UltimateMenus.KunalMenuItem.MenuBarFillStyles.FillColor
        Me.MenuItem36.MenuBarItemGradientColor1 = System.Drawing.SystemColors.Menu
        Me.MenuItem36.MenuBarItemGradientColor2 = System.Drawing.SystemColors.Menu
        Me.MenuItem36.MenuBarItemGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.MenuItem36.OwnerDraw = True
        Me.MenuItem36.PreDefinedHiLiteColors = UltimateMenus.KunalMenuItem.PreDefinedHighLightColors.Khaki
        Me.MenuItem36.PreDefinedHiLiteGradientColors = UltimateMenus.KunalMenuItem.PreDefinedGrHighLightColors.BrownWhite
        Me.MenuItem36.PreDefinedSideBarGradientColour = UltimateMenus.KunalMenuItem.PreDefinedSideBarGradientColors.ShineyBlueYellow
        Me.MenuItem36.ShowBorderAroundMenuBar = False
        Me.MenuItem36.ShowHiliteOverSideBar = False
        Me.MenuItem36.ShowShadowUnderMenuBar = True
        Me.MenuItem36.SideBarGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.MenuItem36.SideBarStyle = UltimateMenus.KunalMenuItem.SideBarDrawStyle.DefaultGradient
        Me.MenuItem36.Text = "Account Closure"
        '
        'MenuItem74
        '
        Me.MenuItem74.CheckedImageIndex = 0
        Me.MenuItem74.CheckedMenuItemBackColor = System.Drawing.SystemColors.Control
        Me.MenuItem74.CheckedMenuItemBorderColor = System.Drawing.SystemColors.Control
        Me.MenuItem74.CheckedMenuItemDisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(197, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(184, Byte), Integer))
        Me.MenuItem74.CheckedMenuItemIconShadowColor = System.Drawing.Color.Gray
        Me.MenuItem74.CheckedMenuItemStyle = UltimateMenus.KunalMenuItem.CheckedMenuStyles.CheckedItemDefault
        Me.MenuItem74.CheckedMenuItemTickMarkColor = System.Drawing.SystemColors.Control
        Me.MenuItem74.FillMenuBarItem = False
        Me.MenuItem74.HighLightForeColor = System.Drawing.SystemColors.HighlightText
        Me.MenuItem74.HighLightScheme = UltimateMenus.KunalMenuItem.HighLightColorDrawStyle.DefaultScheme
        Me.MenuItem74.HiliteGradientColor1 = System.Drawing.Color.WhiteSmoke
        Me.MenuItem74.HiliteGradientColor2 = System.Drawing.Color.CornflowerBlue
        Me.MenuItem74.HiLiteGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.MenuItem74.IconShadowColor = System.Drawing.Color.Gray
        Me.MenuItem74.ImageIndex = 0
        Me.MenuItem74.Index = 5
        Me.MenuItem74.MakeCheckedMenuItemIconTransparent = False
        Me.MenuItem74.MakeTransparentIcon = False
        Me.MenuItem74.MenuBarItemBorderColor = System.Drawing.Color.Black
        Me.MenuItem74.MenuBarItemFillColor = System.Drawing.SystemColors.Menu
        Me.MenuItem74.MenuBarItemFillingStyle = UltimateMenus.KunalMenuItem.MenuBarFillStyles.FillColor
        Me.MenuItem74.MenuBarItemGradientColor1 = System.Drawing.SystemColors.Menu
        Me.MenuItem74.MenuBarItemGradientColor2 = System.Drawing.SystemColors.Menu
        Me.MenuItem74.MenuBarItemGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.MenuItem74.OwnerDraw = True
        Me.MenuItem74.PreDefinedHiLiteColors = UltimateMenus.KunalMenuItem.PreDefinedHighLightColors.Khaki
        Me.MenuItem74.PreDefinedHiLiteGradientColors = UltimateMenus.KunalMenuItem.PreDefinedGrHighLightColors.BrownWhite
        Me.MenuItem74.PreDefinedSideBarGradientColour = UltimateMenus.KunalMenuItem.PreDefinedSideBarGradientColors.ShineyBlueYellow
        Me.MenuItem74.ShowBorderAroundMenuBar = False
        Me.MenuItem74.ShowHiliteOverSideBar = False
        Me.MenuItem74.ShowShadowUnderMenuBar = True
        Me.MenuItem74.SideBarGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.MenuItem74.SideBarStyle = UltimateMenus.KunalMenuItem.SideBarDrawStyle.DefaultGradient
        Me.MenuItem74.Text = "Issue Bond"
        Me.MenuItem74.Visible = False
        '
        'MenuItem37
        '
        Me.MenuItem37.CheckedImageIndex = 0
        Me.MenuItem37.CheckedMenuItemBackColor = System.Drawing.SystemColors.Control
        Me.MenuItem37.CheckedMenuItemBorderColor = System.Drawing.SystemColors.Control
        Me.MenuItem37.CheckedMenuItemDisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(197, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(184, Byte), Integer))
        Me.MenuItem37.CheckedMenuItemIconShadowColor = System.Drawing.Color.Gray
        Me.MenuItem37.CheckedMenuItemStyle = UltimateMenus.KunalMenuItem.CheckedMenuStyles.CheckedItemDefault
        Me.MenuItem37.CheckedMenuItemTickMarkColor = System.Drawing.SystemColors.Control
        Me.MenuItem37.FillMenuBarItem = False
        Me.MenuItem37.HighLightForeColor = System.Drawing.SystemColors.HighlightText
        Me.MenuItem37.HighLightScheme = UltimateMenus.KunalMenuItem.HighLightColorDrawStyle.DefaultScheme
        Me.MenuItem37.HiliteGradientColor1 = System.Drawing.Color.WhiteSmoke
        Me.MenuItem37.HiliteGradientColor2 = System.Drawing.Color.CornflowerBlue
        Me.MenuItem37.HiLiteGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.MenuItem37.IconShadowColor = System.Drawing.Color.Gray
        Me.MenuItem37.ImageIndex = 0
        Me.MenuItem37.Index = 6
        Me.MenuItem37.MakeCheckedMenuItemIconTransparent = False
        Me.MenuItem37.MakeTransparentIcon = False
        Me.MenuItem37.MenuBarItemBorderColor = System.Drawing.Color.Black
        Me.MenuItem37.MenuBarItemFillColor = System.Drawing.SystemColors.Menu
        Me.MenuItem37.MenuBarItemFillingStyle = UltimateMenus.KunalMenuItem.MenuBarFillStyles.FillColor
        Me.MenuItem37.MenuBarItemGradientColor1 = System.Drawing.SystemColors.Menu
        Me.MenuItem37.MenuBarItemGradientColor2 = System.Drawing.SystemColors.Menu
        Me.MenuItem37.MenuBarItemGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.MenuItem37.OwnerDraw = True
        Me.MenuItem37.PreDefinedHiLiteColors = UltimateMenus.KunalMenuItem.PreDefinedHighLightColors.Khaki
        Me.MenuItem37.PreDefinedHiLiteGradientColors = UltimateMenus.KunalMenuItem.PreDefinedGrHighLightColors.BrownWhite
        Me.MenuItem37.PreDefinedSideBarGradientColour = UltimateMenus.KunalMenuItem.PreDefinedSideBarGradientColors.ShineyBlueYellow
        Me.MenuItem37.Shortcut = System.Windows.Forms.Shortcut.CtrlF8
        Me.MenuItem37.ShowBorderAroundMenuBar = False
        Me.MenuItem37.ShowHiliteOverSideBar = False
        Me.MenuItem37.ShowShadowUnderMenuBar = True
        Me.MenuItem37.SideBarGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.MenuItem37.SideBarStyle = UltimateMenus.KunalMenuItem.SideBarDrawStyle.DefaultGradient
        Me.MenuItem37.Text = "View Deposits"
        '
        'smnuDuplicateFD
        '
        Me.smnuDuplicateFD.CheckedImageIndex = 0
        Me.smnuDuplicateFD.CheckedMenuItemBackColor = System.Drawing.SystemColors.Control
        Me.smnuDuplicateFD.CheckedMenuItemBorderColor = System.Drawing.SystemColors.Control
        Me.smnuDuplicateFD.CheckedMenuItemDisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(197, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(184, Byte), Integer))
        Me.smnuDuplicateFD.CheckedMenuItemIconShadowColor = System.Drawing.Color.Gray
        Me.smnuDuplicateFD.CheckedMenuItemStyle = UltimateMenus.KunalMenuItem.CheckedMenuStyles.CheckedItemDefault
        Me.smnuDuplicateFD.CheckedMenuItemTickMarkColor = System.Drawing.SystemColors.Control
        Me.smnuDuplicateFD.FillMenuBarItem = False
        Me.smnuDuplicateFD.HighLightForeColor = System.Drawing.SystemColors.HighlightText
        Me.smnuDuplicateFD.HighLightScheme = UltimateMenus.KunalMenuItem.HighLightColorDrawStyle.DefaultScheme
        Me.smnuDuplicateFD.HiliteGradientColor1 = System.Drawing.Color.WhiteSmoke
        Me.smnuDuplicateFD.HiliteGradientColor2 = System.Drawing.Color.CornflowerBlue
        Me.smnuDuplicateFD.HiLiteGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.smnuDuplicateFD.IconShadowColor = System.Drawing.Color.Gray
        Me.smnuDuplicateFD.ImageIndex = 0
        Me.smnuDuplicateFD.Index = 7
        Me.smnuDuplicateFD.MakeCheckedMenuItemIconTransparent = False
        Me.smnuDuplicateFD.MakeTransparentIcon = False
        Me.smnuDuplicateFD.MenuBarItemBorderColor = System.Drawing.Color.Black
        Me.smnuDuplicateFD.MenuBarItemFillColor = System.Drawing.SystemColors.Menu
        Me.smnuDuplicateFD.MenuBarItemFillingStyle = UltimateMenus.KunalMenuItem.MenuBarFillStyles.FillColor
        Me.smnuDuplicateFD.MenuBarItemGradientColor1 = System.Drawing.SystemColors.Menu
        Me.smnuDuplicateFD.MenuBarItemGradientColor2 = System.Drawing.SystemColors.Menu
        Me.smnuDuplicateFD.MenuBarItemGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.smnuDuplicateFD.OwnerDraw = True
        Me.smnuDuplicateFD.PreDefinedHiLiteColors = UltimateMenus.KunalMenuItem.PreDefinedHighLightColors.Khaki
        Me.smnuDuplicateFD.PreDefinedHiLiteGradientColors = UltimateMenus.KunalMenuItem.PreDefinedGrHighLightColors.BrownWhite
        Me.smnuDuplicateFD.PreDefinedSideBarGradientColour = UltimateMenus.KunalMenuItem.PreDefinedSideBarGradientColors.ShineyBlueYellow
        Me.smnuDuplicateFD.ShowBorderAroundMenuBar = False
        Me.smnuDuplicateFD.ShowHiliteOverSideBar = False
        Me.smnuDuplicateFD.ShowShadowUnderMenuBar = True
        Me.smnuDuplicateFD.SideBarGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.smnuDuplicateFD.SideBarStyle = UltimateMenus.KunalMenuItem.SideBarDrawStyle.DefaultGradient
        Me.smnuDuplicateFD.Text = "Duplicate Deposits"
        Me.smnuDuplicateFD.Visible = False
        '
        'smnuFDPremature
        '
        Me.smnuFDPremature.CheckedImageIndex = 0
        Me.smnuFDPremature.CheckedMenuItemBackColor = System.Drawing.SystemColors.Control
        Me.smnuFDPremature.CheckedMenuItemBorderColor = System.Drawing.SystemColors.Control
        Me.smnuFDPremature.CheckedMenuItemDisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(197, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(184, Byte), Integer))
        Me.smnuFDPremature.CheckedMenuItemIconShadowColor = System.Drawing.Color.Gray
        Me.smnuFDPremature.CheckedMenuItemStyle = UltimateMenus.KunalMenuItem.CheckedMenuStyles.CheckedItemDefault
        Me.smnuFDPremature.CheckedMenuItemTickMarkColor = System.Drawing.SystemColors.Control
        Me.smnuFDPremature.FillMenuBarItem = False
        Me.smnuFDPremature.HighLightForeColor = System.Drawing.SystemColors.HighlightText
        Me.smnuFDPremature.HighLightScheme = UltimateMenus.KunalMenuItem.HighLightColorDrawStyle.DefaultScheme
        Me.smnuFDPremature.HiliteGradientColor1 = System.Drawing.Color.WhiteSmoke
        Me.smnuFDPremature.HiliteGradientColor2 = System.Drawing.Color.CornflowerBlue
        Me.smnuFDPremature.HiLiteGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.smnuFDPremature.IconShadowColor = System.Drawing.Color.Gray
        Me.smnuFDPremature.ImageIndex = 0
        Me.smnuFDPremature.Index = 8
        Me.smnuFDPremature.MakeCheckedMenuItemIconTransparent = False
        Me.smnuFDPremature.MakeTransparentIcon = False
        Me.smnuFDPremature.MenuBarItemBorderColor = System.Drawing.Color.Black
        Me.smnuFDPremature.MenuBarItemFillColor = System.Drawing.SystemColors.Menu
        Me.smnuFDPremature.MenuBarItemFillingStyle = UltimateMenus.KunalMenuItem.MenuBarFillStyles.FillColor
        Me.smnuFDPremature.MenuBarItemGradientColor1 = System.Drawing.SystemColors.Menu
        Me.smnuFDPremature.MenuBarItemGradientColor2 = System.Drawing.SystemColors.Menu
        Me.smnuFDPremature.MenuBarItemGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.smnuFDPremature.OwnerDraw = True
        Me.smnuFDPremature.PreDefinedHiLiteColors = UltimateMenus.KunalMenuItem.PreDefinedHighLightColors.Khaki
        Me.smnuFDPremature.PreDefinedHiLiteGradientColors = UltimateMenus.KunalMenuItem.PreDefinedGrHighLightColors.BrownWhite
        Me.smnuFDPremature.PreDefinedSideBarGradientColour = UltimateMenus.KunalMenuItem.PreDefinedSideBarGradientColors.ShineyBlueYellow
        Me.smnuFDPremature.ShowBorderAroundMenuBar = False
        Me.smnuFDPremature.ShowHiliteOverSideBar = False
        Me.smnuFDPremature.ShowShadowUnderMenuBar = True
        Me.smnuFDPremature.SideBarGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.smnuFDPremature.SideBarStyle = UltimateMenus.KunalMenuItem.SideBarDrawStyle.DefaultGradient
        Me.smnuFDPremature.Text = "Deposit Premature"
        '
        'MenuItem143
        '
        Me.MenuItem143.CheckedImageIndex = 0
        Me.MenuItem143.CheckedMenuItemBackColor = System.Drawing.SystemColors.Control
        Me.MenuItem143.CheckedMenuItemBorderColor = System.Drawing.SystemColors.Control
        Me.MenuItem143.CheckedMenuItemDisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(197, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(184, Byte), Integer))
        Me.MenuItem143.CheckedMenuItemIconShadowColor = System.Drawing.Color.Gray
        Me.MenuItem143.CheckedMenuItemStyle = UltimateMenus.KunalMenuItem.CheckedMenuStyles.CheckedItemDefault
        Me.MenuItem143.CheckedMenuItemTickMarkColor = System.Drawing.SystemColors.Control
        Me.MenuItem143.FillMenuBarItem = False
        Me.MenuItem143.HighLightForeColor = System.Drawing.SystemColors.HighlightText
        Me.MenuItem143.HighLightScheme = UltimateMenus.KunalMenuItem.HighLightColorDrawStyle.DefaultScheme
        Me.MenuItem143.HiliteGradientColor1 = System.Drawing.Color.WhiteSmoke
        Me.MenuItem143.HiliteGradientColor2 = System.Drawing.Color.CornflowerBlue
        Me.MenuItem143.HiLiteGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.MenuItem143.IconShadowColor = System.Drawing.Color.Gray
        Me.MenuItem143.ImageIndex = 0
        Me.MenuItem143.Index = 9
        Me.MenuItem143.MakeCheckedMenuItemIconTransparent = False
        Me.MenuItem143.MakeTransparentIcon = False
        Me.MenuItem143.MenuBarItemBorderColor = System.Drawing.Color.Black
        Me.MenuItem143.MenuBarItemFillColor = System.Drawing.SystemColors.Menu
        Me.MenuItem143.MenuBarItemFillingStyle = UltimateMenus.KunalMenuItem.MenuBarFillStyles.FillColor
        Me.MenuItem143.MenuBarItemGradientColor1 = System.Drawing.SystemColors.Menu
        Me.MenuItem143.MenuBarItemGradientColor2 = System.Drawing.SystemColors.Menu
        Me.MenuItem143.MenuBarItemGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.MenuItem143.OwnerDraw = True
        Me.MenuItem143.PreDefinedHiLiteColors = UltimateMenus.KunalMenuItem.PreDefinedHighLightColors.Khaki
        Me.MenuItem143.PreDefinedHiLiteGradientColors = UltimateMenus.KunalMenuItem.PreDefinedGrHighLightColors.BrownWhite
        Me.MenuItem143.PreDefinedSideBarGradientColour = UltimateMenus.KunalMenuItem.PreDefinedSideBarGradientColors.ShineyBlueYellow
        Me.MenuItem143.ShowBorderAroundMenuBar = False
        Me.MenuItem143.ShowHiliteOverSideBar = False
        Me.MenuItem143.ShowShadowUnderMenuBar = True
        Me.MenuItem143.SideBarGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.MenuItem143.SideBarStyle = UltimateMenus.KunalMenuItem.SideBarDrawStyle.DefaultGradient
        Me.MenuItem143.Text = "Interest Transaction"
        '
        'MenuItem167
        '
        Me.MenuItem167.CheckedImageIndex = 0
        Me.MenuItem167.CheckedMenuItemBackColor = System.Drawing.SystemColors.Control
        Me.MenuItem167.CheckedMenuItemBorderColor = System.Drawing.SystemColors.Control
        Me.MenuItem167.CheckedMenuItemDisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(197, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(184, Byte), Integer))
        Me.MenuItem167.CheckedMenuItemIconShadowColor = System.Drawing.Color.Gray
        Me.MenuItem167.CheckedMenuItemStyle = UltimateMenus.KunalMenuItem.CheckedMenuStyles.CheckedItemDefault
        Me.MenuItem167.CheckedMenuItemTickMarkColor = System.Drawing.SystemColors.Control
        Me.MenuItem167.FillMenuBarItem = False
        Me.MenuItem167.HighLightForeColor = System.Drawing.SystemColors.HighlightText
        Me.MenuItem167.HighLightScheme = UltimateMenus.KunalMenuItem.HighLightColorDrawStyle.DefaultScheme
        Me.MenuItem167.HiliteGradientColor1 = System.Drawing.Color.WhiteSmoke
        Me.MenuItem167.HiliteGradientColor2 = System.Drawing.Color.CornflowerBlue
        Me.MenuItem167.HiLiteGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.MenuItem167.IconShadowColor = System.Drawing.Color.Gray
        Me.MenuItem167.ImageIndex = 0
        Me.MenuItem167.Index = 10
        Me.MenuItem167.MakeCheckedMenuItemIconTransparent = False
        Me.MenuItem167.MakeTransparentIcon = False
        Me.MenuItem167.MenuBarItemBorderColor = System.Drawing.Color.Black
        Me.MenuItem167.MenuBarItemFillColor = System.Drawing.SystemColors.Menu
        Me.MenuItem167.MenuBarItemFillingStyle = UltimateMenus.KunalMenuItem.MenuBarFillStyles.FillColor
        Me.MenuItem167.MenuBarItemGradientColor1 = System.Drawing.SystemColors.Menu
        Me.MenuItem167.MenuBarItemGradientColor2 = System.Drawing.SystemColors.Menu
        Me.MenuItem167.MenuBarItemGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.MenuItem167.OwnerDraw = True
        Me.MenuItem167.PreDefinedHiLiteColors = UltimateMenus.KunalMenuItem.PreDefinedHighLightColors.Khaki
        Me.MenuItem167.PreDefinedHiLiteGradientColors = UltimateMenus.KunalMenuItem.PreDefinedGrHighLightColors.BrownWhite
        Me.MenuItem167.PreDefinedSideBarGradientColour = UltimateMenus.KunalMenuItem.PreDefinedSideBarGradientColors.ShineyBlueYellow
        Me.MenuItem167.ShowBorderAroundMenuBar = False
        Me.MenuItem167.ShowHiliteOverSideBar = False
        Me.MenuItem167.ShowShadowUnderMenuBar = True
        Me.MenuItem167.SideBarGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.MenuItem167.SideBarStyle = UltimateMenus.KunalMenuItem.SideBarDrawStyle.DefaultGradient
        Me.MenuItem167.Text = "View Renewal FDs"
        '
        'MenuItem168
        '
        Me.MenuItem168.CheckedImageIndex = 0
        Me.MenuItem168.CheckedMenuItemBackColor = System.Drawing.SystemColors.Control
        Me.MenuItem168.CheckedMenuItemBorderColor = System.Drawing.SystemColors.Control
        Me.MenuItem168.CheckedMenuItemDisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(197, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(184, Byte), Integer))
        Me.MenuItem168.CheckedMenuItemIconShadowColor = System.Drawing.Color.Gray
        Me.MenuItem168.CheckedMenuItemStyle = UltimateMenus.KunalMenuItem.CheckedMenuStyles.CheckedItemDefault
        Me.MenuItem168.CheckedMenuItemTickMarkColor = System.Drawing.SystemColors.Control
        Me.MenuItem168.FillMenuBarItem = False
        Me.MenuItem168.HighLightForeColor = System.Drawing.SystemColors.HighlightText
        Me.MenuItem168.HighLightScheme = UltimateMenus.KunalMenuItem.HighLightColorDrawStyle.DefaultScheme
        Me.MenuItem168.HiliteGradientColor1 = System.Drawing.Color.WhiteSmoke
        Me.MenuItem168.HiliteGradientColor2 = System.Drawing.Color.CornflowerBlue
        Me.MenuItem168.HiLiteGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.MenuItem168.IconShadowColor = System.Drawing.Color.Gray
        Me.MenuItem168.ImageIndex = 0
        Me.MenuItem168.Index = 11
        Me.MenuItem168.MakeCheckedMenuItemIconTransparent = False
        Me.MenuItem168.MakeTransparentIcon = False
        Me.MenuItem168.MenuBarItemBorderColor = System.Drawing.Color.Black
        Me.MenuItem168.MenuBarItemFillColor = System.Drawing.SystemColors.Menu
        Me.MenuItem168.MenuBarItemFillingStyle = UltimateMenus.KunalMenuItem.MenuBarFillStyles.FillColor
        Me.MenuItem168.MenuBarItemGradientColor1 = System.Drawing.SystemColors.Menu
        Me.MenuItem168.MenuBarItemGradientColor2 = System.Drawing.SystemColors.Menu
        Me.MenuItem168.MenuBarItemGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.MenuItem168.OwnerDraw = True
        Me.MenuItem168.PreDefinedHiLiteColors = UltimateMenus.KunalMenuItem.PreDefinedHighLightColors.Khaki
        Me.MenuItem168.PreDefinedHiLiteGradientColors = UltimateMenus.KunalMenuItem.PreDefinedGrHighLightColors.BrownWhite
        Me.MenuItem168.PreDefinedSideBarGradientColour = UltimateMenus.KunalMenuItem.PreDefinedSideBarGradientColors.ShineyBlueYellow
        Me.MenuItem168.ShowBorderAroundMenuBar = False
        Me.MenuItem168.ShowHiliteOverSideBar = False
        Me.MenuItem168.ShowShadowUnderMenuBar = True
        Me.MenuItem168.SideBarGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.MenuItem168.SideBarStyle = UltimateMenus.KunalMenuItem.SideBarDrawStyle.DefaultGradient
        Me.MenuItem168.Text = "&Double, Triple,  Lakshadipathi"
        '
        'MenuItem30
        '
        Me.MenuItem30.CheckedImageIndex = 0
        Me.MenuItem30.CheckedMenuItemBackColor = System.Drawing.SystemColors.Control
        Me.MenuItem30.CheckedMenuItemBorderColor = System.Drawing.SystemColors.Control
        Me.MenuItem30.CheckedMenuItemDisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(197, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(184, Byte), Integer))
        Me.MenuItem30.CheckedMenuItemIconShadowColor = System.Drawing.Color.Gray
        Me.MenuItem30.CheckedMenuItemStyle = UltimateMenus.KunalMenuItem.CheckedMenuStyles.CheckedItemDefault
        Me.MenuItem30.CheckedMenuItemTickMarkColor = System.Drawing.SystemColors.Control
        Me.MenuItem30.FillMenuBarItem = False
        Me.MenuItem30.HighLightForeColor = System.Drawing.SystemColors.HighlightText
        Me.MenuItem30.HighLightScheme = UltimateMenus.KunalMenuItem.HighLightColorDrawStyle.DefaultScheme
        Me.MenuItem30.HiliteGradientColor1 = System.Drawing.Color.WhiteSmoke
        Me.MenuItem30.HiliteGradientColor2 = System.Drawing.Color.CornflowerBlue
        Me.MenuItem30.HiLiteGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.MenuItem30.IconShadowColor = System.Drawing.Color.Gray
        Me.MenuItem30.ImageIndex = 0
        Me.MenuItem30.Index = 1
        Me.MenuItem30.MakeCheckedMenuItemIconTransparent = False
        Me.MenuItem30.MakeTransparentIcon = False
        Me.MenuItem30.MenuBarItemBorderColor = System.Drawing.Color.Black
        Me.MenuItem30.MenuBarItemFillColor = System.Drawing.SystemColors.Menu
        Me.MenuItem30.MenuBarItemFillingStyle = UltimateMenus.KunalMenuItem.MenuBarFillStyles.FillColor
        Me.MenuItem30.MenuBarItemGradientColor1 = System.Drawing.SystemColors.Menu
        Me.MenuItem30.MenuBarItemGradientColor2 = System.Drawing.SystemColors.Menu
        Me.MenuItem30.MenuBarItemGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.MenuItem30.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem38, Me.MenuItem118, Me.MenuItem119, Me.MenuItem41, Me.smnuRDClosure, Me.MenuItem43, Me.MenuItem146})
        Me.MenuItem30.OwnerDraw = True
        Me.MenuItem30.PreDefinedHiLiteColors = UltimateMenus.KunalMenuItem.PreDefinedHighLightColors.Khaki
        Me.MenuItem30.PreDefinedHiLiteGradientColors = UltimateMenus.KunalMenuItem.PreDefinedGrHighLightColors.BrownWhite
        Me.MenuItem30.PreDefinedSideBarGradientColour = UltimateMenus.KunalMenuItem.PreDefinedSideBarGradientColors.ShineyBlueYellow
        Me.MenuItem30.ShowBorderAroundMenuBar = False
        Me.MenuItem30.ShowHiliteOverSideBar = False
        Me.MenuItem30.ShowShadowUnderMenuBar = True
        Me.MenuItem30.SideBarGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.MenuItem30.SideBarStyle = UltimateMenus.KunalMenuItem.SideBarDrawStyle.DefaultGradient
        Me.MenuItem30.Text = "Recurring Deposits"
        '
        'MenuItem38
        '
        Me.MenuItem38.CheckedImageIndex = 0
        Me.MenuItem38.CheckedMenuItemBackColor = System.Drawing.SystemColors.Control
        Me.MenuItem38.CheckedMenuItemBorderColor = System.Drawing.SystemColors.Control
        Me.MenuItem38.CheckedMenuItemDisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(197, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(184, Byte), Integer))
        Me.MenuItem38.CheckedMenuItemIconShadowColor = System.Drawing.Color.Gray
        Me.MenuItem38.CheckedMenuItemStyle = UltimateMenus.KunalMenuItem.CheckedMenuStyles.CheckedItemDefault
        Me.MenuItem38.CheckedMenuItemTickMarkColor = System.Drawing.SystemColors.Control
        Me.MenuItem38.FillMenuBarItem = False
        Me.MenuItem38.HighLightForeColor = System.Drawing.SystemColors.HighlightText
        Me.MenuItem38.HighLightScheme = UltimateMenus.KunalMenuItem.HighLightColorDrawStyle.DefaultScheme
        Me.MenuItem38.HiliteGradientColor1 = System.Drawing.Color.WhiteSmoke
        Me.MenuItem38.HiliteGradientColor2 = System.Drawing.Color.CornflowerBlue
        Me.MenuItem38.HiLiteGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.MenuItem38.IconShadowColor = System.Drawing.Color.Gray
        Me.MenuItem38.ImageIndex = 0
        Me.MenuItem38.Index = 0
        Me.MenuItem38.MakeCheckedMenuItemIconTransparent = False
        Me.MenuItem38.MakeTransparentIcon = False
        Me.MenuItem38.MenuBarItemBorderColor = System.Drawing.Color.Black
        Me.MenuItem38.MenuBarItemFillColor = System.Drawing.SystemColors.Menu
        Me.MenuItem38.MenuBarItemFillingStyle = UltimateMenus.KunalMenuItem.MenuBarFillStyles.FillColor
        Me.MenuItem38.MenuBarItemGradientColor1 = System.Drawing.SystemColors.Menu
        Me.MenuItem38.MenuBarItemGradientColor2 = System.Drawing.SystemColors.Menu
        Me.MenuItem38.MenuBarItemGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.MenuItem38.OwnerDraw = True
        Me.MenuItem38.PreDefinedHiLiteColors = UltimateMenus.KunalMenuItem.PreDefinedHighLightColors.Khaki
        Me.MenuItem38.PreDefinedHiLiteGradientColors = UltimateMenus.KunalMenuItem.PreDefinedGrHighLightColors.BrownWhite
        Me.MenuItem38.PreDefinedSideBarGradientColour = UltimateMenus.KunalMenuItem.PreDefinedSideBarGradientColors.ShineyBlueYellow
        Me.MenuItem38.Shortcut = System.Windows.Forms.Shortcut.F9
        Me.MenuItem38.ShowBorderAroundMenuBar = False
        Me.MenuItem38.ShowHiliteOverSideBar = False
        Me.MenuItem38.ShowShadowUnderMenuBar = True
        Me.MenuItem38.SideBarGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.MenuItem38.SideBarStyle = UltimateMenus.KunalMenuItem.SideBarDrawStyle.DefaultGradient
        Me.MenuItem38.Text = "New RD"
        '
        'MenuItem118
        '
        Me.MenuItem118.CheckedImageIndex = 0
        Me.MenuItem118.CheckedMenuItemBackColor = System.Drawing.SystemColors.Control
        Me.MenuItem118.CheckedMenuItemBorderColor = System.Drawing.SystemColors.Control
        Me.MenuItem118.CheckedMenuItemDisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(197, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(184, Byte), Integer))
        Me.MenuItem118.CheckedMenuItemIconShadowColor = System.Drawing.Color.Gray
        Me.MenuItem118.CheckedMenuItemStyle = UltimateMenus.KunalMenuItem.CheckedMenuStyles.CheckedItemDefault
        Me.MenuItem118.CheckedMenuItemTickMarkColor = System.Drawing.SystemColors.Control
        Me.MenuItem118.FillMenuBarItem = False
        Me.MenuItem118.HighLightForeColor = System.Drawing.SystemColors.HighlightText
        Me.MenuItem118.HighLightScheme = UltimateMenus.KunalMenuItem.HighLightColorDrawStyle.DefaultScheme
        Me.MenuItem118.HiliteGradientColor1 = System.Drawing.Color.WhiteSmoke
        Me.MenuItem118.HiliteGradientColor2 = System.Drawing.Color.CornflowerBlue
        Me.MenuItem118.HiLiteGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.MenuItem118.IconShadowColor = System.Drawing.Color.Gray
        Me.MenuItem118.ImageIndex = 0
        Me.MenuItem118.Index = 1
        Me.MenuItem118.MakeCheckedMenuItemIconTransparent = False
        Me.MenuItem118.MakeTransparentIcon = False
        Me.MenuItem118.MenuBarItemBorderColor = System.Drawing.Color.Black
        Me.MenuItem118.MenuBarItemFillColor = System.Drawing.SystemColors.Menu
        Me.MenuItem118.MenuBarItemFillingStyle = UltimateMenus.KunalMenuItem.MenuBarFillStyles.FillColor
        Me.MenuItem118.MenuBarItemGradientColor1 = System.Drawing.SystemColors.Menu
        Me.MenuItem118.MenuBarItemGradientColor2 = System.Drawing.SystemColors.Menu
        Me.MenuItem118.MenuBarItemGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.MenuItem118.OwnerDraw = True
        Me.MenuItem118.PreDefinedHiLiteColors = UltimateMenus.KunalMenuItem.PreDefinedHighLightColors.Khaki
        Me.MenuItem118.PreDefinedHiLiteGradientColors = UltimateMenus.KunalMenuItem.PreDefinedGrHighLightColors.BrownWhite
        Me.MenuItem118.PreDefinedSideBarGradientColour = UltimateMenus.KunalMenuItem.PreDefinedSideBarGradientColors.ShineyBlueYellow
        Me.MenuItem118.ShowBorderAroundMenuBar = False
        Me.MenuItem118.ShowHiliteOverSideBar = False
        Me.MenuItem118.ShowShadowUnderMenuBar = True
        Me.MenuItem118.SideBarGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.MenuItem118.SideBarStyle = UltimateMenus.KunalMenuItem.SideBarDrawStyle.DefaultGradient
        Me.MenuItem118.Text = "RD Deposit"
        '
        'MenuItem119
        '
        Me.MenuItem119.CheckedImageIndex = 0
        Me.MenuItem119.CheckedMenuItemBackColor = System.Drawing.SystemColors.Control
        Me.MenuItem119.CheckedMenuItemBorderColor = System.Drawing.SystemColors.Control
        Me.MenuItem119.CheckedMenuItemDisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(197, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(184, Byte), Integer))
        Me.MenuItem119.CheckedMenuItemIconShadowColor = System.Drawing.Color.Gray
        Me.MenuItem119.CheckedMenuItemStyle = UltimateMenus.KunalMenuItem.CheckedMenuStyles.CheckedItemDefault
        Me.MenuItem119.CheckedMenuItemTickMarkColor = System.Drawing.SystemColors.Control
        Me.MenuItem119.FillMenuBarItem = False
        Me.MenuItem119.HighLightForeColor = System.Drawing.SystemColors.HighlightText
        Me.MenuItem119.HighLightScheme = UltimateMenus.KunalMenuItem.HighLightColorDrawStyle.DefaultScheme
        Me.MenuItem119.HiliteGradientColor1 = System.Drawing.Color.WhiteSmoke
        Me.MenuItem119.HiliteGradientColor2 = System.Drawing.Color.CornflowerBlue
        Me.MenuItem119.HiLiteGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.MenuItem119.IconShadowColor = System.Drawing.Color.Gray
        Me.MenuItem119.ImageIndex = 0
        Me.MenuItem119.Index = 2
        Me.MenuItem119.MakeCheckedMenuItemIconTransparent = False
        Me.MenuItem119.MakeTransparentIcon = False
        Me.MenuItem119.MenuBarItemBorderColor = System.Drawing.Color.Black
        Me.MenuItem119.MenuBarItemFillColor = System.Drawing.SystemColors.Menu
        Me.MenuItem119.MenuBarItemFillingStyle = UltimateMenus.KunalMenuItem.MenuBarFillStyles.FillColor
        Me.MenuItem119.MenuBarItemGradientColor1 = System.Drawing.SystemColors.Menu
        Me.MenuItem119.MenuBarItemGradientColor2 = System.Drawing.SystemColors.Menu
        Me.MenuItem119.MenuBarItemGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.MenuItem119.OwnerDraw = True
        Me.MenuItem119.PreDefinedHiLiteColors = UltimateMenus.KunalMenuItem.PreDefinedHighLightColors.Khaki
        Me.MenuItem119.PreDefinedHiLiteGradientColors = UltimateMenus.KunalMenuItem.PreDefinedGrHighLightColors.BrownWhite
        Me.MenuItem119.PreDefinedSideBarGradientColour = UltimateMenus.KunalMenuItem.PreDefinedSideBarGradientColors.ShineyBlueYellow
        Me.MenuItem119.ShowBorderAroundMenuBar = False
        Me.MenuItem119.ShowHiliteOverSideBar = False
        Me.MenuItem119.ShowShadowUnderMenuBar = True
        Me.MenuItem119.SideBarGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.MenuItem119.SideBarStyle = UltimateMenus.KunalMenuItem.SideBarDrawStyle.DefaultGradient
        Me.MenuItem119.Text = "RD Premature"
        '
        'MenuItem41
        '
        Me.MenuItem41.CheckedImageIndex = 0
        Me.MenuItem41.CheckedMenuItemBackColor = System.Drawing.SystemColors.Control
        Me.MenuItem41.CheckedMenuItemBorderColor = System.Drawing.SystemColors.Control
        Me.MenuItem41.CheckedMenuItemDisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(197, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(184, Byte), Integer))
        Me.MenuItem41.CheckedMenuItemIconShadowColor = System.Drawing.Color.Gray
        Me.MenuItem41.CheckedMenuItemStyle = UltimateMenus.KunalMenuItem.CheckedMenuStyles.CheckedItemDefault
        Me.MenuItem41.CheckedMenuItemTickMarkColor = System.Drawing.SystemColors.Control
        Me.MenuItem41.FillMenuBarItem = False
        Me.MenuItem41.HighLightForeColor = System.Drawing.SystemColors.HighlightText
        Me.MenuItem41.HighLightScheme = UltimateMenus.KunalMenuItem.HighLightColorDrawStyle.DefaultScheme
        Me.MenuItem41.HiliteGradientColor1 = System.Drawing.Color.WhiteSmoke
        Me.MenuItem41.HiliteGradientColor2 = System.Drawing.Color.CornflowerBlue
        Me.MenuItem41.HiLiteGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.MenuItem41.IconShadowColor = System.Drawing.Color.Gray
        Me.MenuItem41.ImageIndex = 0
        Me.MenuItem41.Index = 3
        Me.MenuItem41.MakeCheckedMenuItemIconTransparent = False
        Me.MenuItem41.MakeTransparentIcon = False
        Me.MenuItem41.MenuBarItemBorderColor = System.Drawing.Color.Black
        Me.MenuItem41.MenuBarItemFillColor = System.Drawing.SystemColors.Menu
        Me.MenuItem41.MenuBarItemFillingStyle = UltimateMenus.KunalMenuItem.MenuBarFillStyles.FillColor
        Me.MenuItem41.MenuBarItemGradientColor1 = System.Drawing.SystemColors.Menu
        Me.MenuItem41.MenuBarItemGradientColor2 = System.Drawing.SystemColors.Menu
        Me.MenuItem41.MenuBarItemGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.MenuItem41.OwnerDraw = True
        Me.MenuItem41.PreDefinedHiLiteColors = UltimateMenus.KunalMenuItem.PreDefinedHighLightColors.Khaki
        Me.MenuItem41.PreDefinedHiLiteGradientColors = UltimateMenus.KunalMenuItem.PreDefinedGrHighLightColors.BrownWhite
        Me.MenuItem41.PreDefinedSideBarGradientColour = UltimateMenus.KunalMenuItem.PreDefinedSideBarGradientColors.ShineyBlueYellow
        Me.MenuItem41.ShowBorderAroundMenuBar = False
        Me.MenuItem41.ShowHiliteOverSideBar = False
        Me.MenuItem41.ShowShadowUnderMenuBar = True
        Me.MenuItem41.SideBarGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.MenuItem41.SideBarStyle = UltimateMenus.KunalMenuItem.SideBarDrawStyle.DefaultGradient
        Me.MenuItem41.Text = "RD Renewal"
        Me.MenuItem41.Visible = False
        '
        'smnuRDClosure
        '
        Me.smnuRDClosure.CheckedImageIndex = 0
        Me.smnuRDClosure.CheckedMenuItemBackColor = System.Drawing.SystemColors.Control
        Me.smnuRDClosure.CheckedMenuItemBorderColor = System.Drawing.SystemColors.Control
        Me.smnuRDClosure.CheckedMenuItemDisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(197, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(184, Byte), Integer))
        Me.smnuRDClosure.CheckedMenuItemIconShadowColor = System.Drawing.Color.Gray
        Me.smnuRDClosure.CheckedMenuItemStyle = UltimateMenus.KunalMenuItem.CheckedMenuStyles.CheckedItemDefault
        Me.smnuRDClosure.CheckedMenuItemTickMarkColor = System.Drawing.SystemColors.Control
        Me.smnuRDClosure.FillMenuBarItem = False
        Me.smnuRDClosure.HighLightForeColor = System.Drawing.SystemColors.HighlightText
        Me.smnuRDClosure.HighLightScheme = UltimateMenus.KunalMenuItem.HighLightColorDrawStyle.DefaultScheme
        Me.smnuRDClosure.HiliteGradientColor1 = System.Drawing.Color.WhiteSmoke
        Me.smnuRDClosure.HiliteGradientColor2 = System.Drawing.Color.CornflowerBlue
        Me.smnuRDClosure.HiLiteGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.smnuRDClosure.IconShadowColor = System.Drawing.Color.Gray
        Me.smnuRDClosure.ImageIndex = 0
        Me.smnuRDClosure.Index = 4
        Me.smnuRDClosure.MakeCheckedMenuItemIconTransparent = False
        Me.smnuRDClosure.MakeTransparentIcon = False
        Me.smnuRDClosure.MenuBarItemBorderColor = System.Drawing.Color.Black
        Me.smnuRDClosure.MenuBarItemFillColor = System.Drawing.SystemColors.Menu
        Me.smnuRDClosure.MenuBarItemFillingStyle = UltimateMenus.KunalMenuItem.MenuBarFillStyles.FillColor
        Me.smnuRDClosure.MenuBarItemGradientColor1 = System.Drawing.SystemColors.Menu
        Me.smnuRDClosure.MenuBarItemGradientColor2 = System.Drawing.SystemColors.Menu
        Me.smnuRDClosure.MenuBarItemGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.smnuRDClosure.OwnerDraw = True
        Me.smnuRDClosure.PreDefinedHiLiteColors = UltimateMenus.KunalMenuItem.PreDefinedHighLightColors.Khaki
        Me.smnuRDClosure.PreDefinedHiLiteGradientColors = UltimateMenus.KunalMenuItem.PreDefinedGrHighLightColors.BrownWhite
        Me.smnuRDClosure.PreDefinedSideBarGradientColour = UltimateMenus.KunalMenuItem.PreDefinedSideBarGradientColors.ShineyBlueYellow
        Me.smnuRDClosure.ShowBorderAroundMenuBar = False
        Me.smnuRDClosure.ShowHiliteOverSideBar = False
        Me.smnuRDClosure.ShowShadowUnderMenuBar = True
        Me.smnuRDClosure.SideBarGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.smnuRDClosure.SideBarStyle = UltimateMenus.KunalMenuItem.SideBarDrawStyle.DefaultGradient
        Me.smnuRDClosure.Text = "RD Closure"
        '
        'MenuItem43
        '
        Me.MenuItem43.CheckedImageIndex = 0
        Me.MenuItem43.CheckedMenuItemBackColor = System.Drawing.SystemColors.Control
        Me.MenuItem43.CheckedMenuItemBorderColor = System.Drawing.SystemColors.Control
        Me.MenuItem43.CheckedMenuItemDisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(197, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(184, Byte), Integer))
        Me.MenuItem43.CheckedMenuItemIconShadowColor = System.Drawing.Color.Gray
        Me.MenuItem43.CheckedMenuItemStyle = UltimateMenus.KunalMenuItem.CheckedMenuStyles.CheckedItemDefault
        Me.MenuItem43.CheckedMenuItemTickMarkColor = System.Drawing.SystemColors.Control
        Me.MenuItem43.FillMenuBarItem = False
        Me.MenuItem43.HighLightForeColor = System.Drawing.SystemColors.HighlightText
        Me.MenuItem43.HighLightScheme = UltimateMenus.KunalMenuItem.HighLightColorDrawStyle.DefaultScheme
        Me.MenuItem43.HiliteGradientColor1 = System.Drawing.Color.WhiteSmoke
        Me.MenuItem43.HiliteGradientColor2 = System.Drawing.Color.CornflowerBlue
        Me.MenuItem43.HiLiteGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.MenuItem43.IconShadowColor = System.Drawing.Color.Gray
        Me.MenuItem43.ImageIndex = 0
        Me.MenuItem43.Index = 5
        Me.MenuItem43.MakeCheckedMenuItemIconTransparent = False
        Me.MenuItem43.MakeTransparentIcon = False
        Me.MenuItem43.MenuBarItemBorderColor = System.Drawing.Color.Black
        Me.MenuItem43.MenuBarItemFillColor = System.Drawing.SystemColors.Menu
        Me.MenuItem43.MenuBarItemFillingStyle = UltimateMenus.KunalMenuItem.MenuBarFillStyles.FillColor
        Me.MenuItem43.MenuBarItemGradientColor1 = System.Drawing.SystemColors.Menu
        Me.MenuItem43.MenuBarItemGradientColor2 = System.Drawing.SystemColors.Menu
        Me.MenuItem43.MenuBarItemGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.MenuItem43.OwnerDraw = True
        Me.MenuItem43.PreDefinedHiLiteColors = UltimateMenus.KunalMenuItem.PreDefinedHighLightColors.Khaki
        Me.MenuItem43.PreDefinedHiLiteGradientColors = UltimateMenus.KunalMenuItem.PreDefinedGrHighLightColors.BrownWhite
        Me.MenuItem43.PreDefinedSideBarGradientColour = UltimateMenus.KunalMenuItem.PreDefinedSideBarGradientColors.ShineyBlueYellow
        Me.MenuItem43.Shortcut = System.Windows.Forms.Shortcut.CtrlF9
        Me.MenuItem43.ShowBorderAroundMenuBar = False
        Me.MenuItem43.ShowHiliteOverSideBar = False
        Me.MenuItem43.ShowShadowUnderMenuBar = True
        Me.MenuItem43.SideBarGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.MenuItem43.SideBarStyle = UltimateMenus.KunalMenuItem.SideBarDrawStyle.DefaultGradient
        Me.MenuItem43.Text = "View RDs"
        '
        'MenuItem146
        '
        Me.MenuItem146.CheckedImageIndex = 0
        Me.MenuItem146.CheckedMenuItemBackColor = System.Drawing.SystemColors.Control
        Me.MenuItem146.CheckedMenuItemBorderColor = System.Drawing.SystemColors.Control
        Me.MenuItem146.CheckedMenuItemDisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(197, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(184, Byte), Integer))
        Me.MenuItem146.CheckedMenuItemIconShadowColor = System.Drawing.Color.Gray
        Me.MenuItem146.CheckedMenuItemStyle = UltimateMenus.KunalMenuItem.CheckedMenuStyles.CheckedItemDefault
        Me.MenuItem146.CheckedMenuItemTickMarkColor = System.Drawing.SystemColors.Control
        Me.MenuItem146.FillMenuBarItem = False
        Me.MenuItem146.HighLightForeColor = System.Drawing.SystemColors.HighlightText
        Me.MenuItem146.HighLightScheme = UltimateMenus.KunalMenuItem.HighLightColorDrawStyle.DefaultScheme
        Me.MenuItem146.HiliteGradientColor1 = System.Drawing.Color.WhiteSmoke
        Me.MenuItem146.HiliteGradientColor2 = System.Drawing.Color.CornflowerBlue
        Me.MenuItem146.HiLiteGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.MenuItem146.IconShadowColor = System.Drawing.Color.Gray
        Me.MenuItem146.ImageIndex = 0
        Me.MenuItem146.Index = 6
        Me.MenuItem146.MakeCheckedMenuItemIconTransparent = False
        Me.MenuItem146.MakeTransparentIcon = False
        Me.MenuItem146.MenuBarItemBorderColor = System.Drawing.Color.Black
        Me.MenuItem146.MenuBarItemFillColor = System.Drawing.SystemColors.Menu
        Me.MenuItem146.MenuBarItemFillingStyle = UltimateMenus.KunalMenuItem.MenuBarFillStyles.FillColor
        Me.MenuItem146.MenuBarItemGradientColor1 = System.Drawing.SystemColors.Menu
        Me.MenuItem146.MenuBarItemGradientColor2 = System.Drawing.SystemColors.Menu
        Me.MenuItem146.MenuBarItemGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.MenuItem146.OwnerDraw = True
        Me.MenuItem146.PreDefinedHiLiteColors = UltimateMenus.KunalMenuItem.PreDefinedHighLightColors.Khaki
        Me.MenuItem146.PreDefinedHiLiteGradientColors = UltimateMenus.KunalMenuItem.PreDefinedGrHighLightColors.BrownWhite
        Me.MenuItem146.PreDefinedSideBarGradientColour = UltimateMenus.KunalMenuItem.PreDefinedSideBarGradientColors.ShineyBlueYellow
        Me.MenuItem146.ShowBorderAroundMenuBar = False
        Me.MenuItem146.ShowHiliteOverSideBar = False
        Me.MenuItem146.ShowShadowUnderMenuBar = True
        Me.MenuItem146.SideBarGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.MenuItem146.SideBarStyle = UltimateMenus.KunalMenuItem.SideBarDrawStyle.DefaultGradient
        Me.MenuItem146.Text = "Provision Payments"
        '
        'MenuItem31
        '
        Me.MenuItem31.CheckedImageIndex = 0
        Me.MenuItem31.CheckedMenuItemBackColor = System.Drawing.SystemColors.Control
        Me.MenuItem31.CheckedMenuItemBorderColor = System.Drawing.SystemColors.Control
        Me.MenuItem31.CheckedMenuItemDisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(197, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(184, Byte), Integer))
        Me.MenuItem31.CheckedMenuItemIconShadowColor = System.Drawing.Color.Gray
        Me.MenuItem31.CheckedMenuItemStyle = UltimateMenus.KunalMenuItem.CheckedMenuStyles.CheckedItemDefault
        Me.MenuItem31.CheckedMenuItemTickMarkColor = System.Drawing.SystemColors.Control
        Me.MenuItem31.FillMenuBarItem = False
        Me.MenuItem31.HighLightForeColor = System.Drawing.SystemColors.HighlightText
        Me.MenuItem31.HighLightScheme = UltimateMenus.KunalMenuItem.HighLightColorDrawStyle.DefaultScheme
        Me.MenuItem31.HiliteGradientColor1 = System.Drawing.Color.WhiteSmoke
        Me.MenuItem31.HiliteGradientColor2 = System.Drawing.Color.CornflowerBlue
        Me.MenuItem31.HiLiteGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.MenuItem31.IconShadowColor = System.Drawing.Color.Gray
        Me.MenuItem31.ImageIndex = 0
        Me.MenuItem31.Index = 2
        Me.MenuItem31.MakeCheckedMenuItemIconTransparent = False
        Me.MenuItem31.MakeTransparentIcon = False
        Me.MenuItem31.MenuBarItemBorderColor = System.Drawing.Color.Black
        Me.MenuItem31.MenuBarItemFillColor = System.Drawing.SystemColors.Menu
        Me.MenuItem31.MenuBarItemFillingStyle = UltimateMenus.KunalMenuItem.MenuBarFillStyles.FillColor
        Me.MenuItem31.MenuBarItemGradientColor1 = System.Drawing.SystemColors.Menu
        Me.MenuItem31.MenuBarItemGradientColor2 = System.Drawing.SystemColors.Menu
        Me.MenuItem31.MenuBarItemGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.MenuItem31.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem44, Me.MenuItem77, Me.MenuItem97, Me.MenuItem136, Me.MenuItem45, Me.MenuItem46, Me.MenuItem147, Me.MenuItem148, Me.MenuItem149, Me.MenuItem180})
        Me.MenuItem31.OwnerDraw = True
        Me.MenuItem31.PreDefinedHiLiteColors = UltimateMenus.KunalMenuItem.PreDefinedHighLightColors.Khaki
        Me.MenuItem31.PreDefinedHiLiteGradientColors = UltimateMenus.KunalMenuItem.PreDefinedGrHighLightColors.BrownWhite
        Me.MenuItem31.PreDefinedSideBarGradientColour = UltimateMenus.KunalMenuItem.PreDefinedSideBarGradientColors.ShineyBlueYellow
        Me.MenuItem31.ShowBorderAroundMenuBar = False
        Me.MenuItem31.ShowHiliteOverSideBar = False
        Me.MenuItem31.ShowShadowUnderMenuBar = True
        Me.MenuItem31.SideBarGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.MenuItem31.SideBarStyle = UltimateMenus.KunalMenuItem.SideBarDrawStyle.DefaultGradient
        Me.MenuItem31.Text = "Pigmy(BNN) Deposits"
        '
        'MenuItem44
        '
        Me.MenuItem44.CheckedImageIndex = 0
        Me.MenuItem44.CheckedMenuItemBackColor = System.Drawing.SystemColors.Control
        Me.MenuItem44.CheckedMenuItemBorderColor = System.Drawing.SystemColors.Control
        Me.MenuItem44.CheckedMenuItemDisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(197, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(184, Byte), Integer))
        Me.MenuItem44.CheckedMenuItemIconShadowColor = System.Drawing.Color.Gray
        Me.MenuItem44.CheckedMenuItemStyle = UltimateMenus.KunalMenuItem.CheckedMenuStyles.CheckedItemDefault
        Me.MenuItem44.CheckedMenuItemTickMarkColor = System.Drawing.SystemColors.Control
        Me.MenuItem44.FillMenuBarItem = False
        Me.MenuItem44.HighLightForeColor = System.Drawing.SystemColors.HighlightText
        Me.MenuItem44.HighLightScheme = UltimateMenus.KunalMenuItem.HighLightColorDrawStyle.DefaultScheme
        Me.MenuItem44.HiliteGradientColor1 = System.Drawing.Color.WhiteSmoke
        Me.MenuItem44.HiliteGradientColor2 = System.Drawing.Color.CornflowerBlue
        Me.MenuItem44.HiLiteGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.MenuItem44.IconShadowColor = System.Drawing.Color.Gray
        Me.MenuItem44.ImageIndex = 0
        Me.MenuItem44.Index = 0
        Me.MenuItem44.MakeCheckedMenuItemIconTransparent = False
        Me.MenuItem44.MakeTransparentIcon = False
        Me.MenuItem44.MenuBarItemBorderColor = System.Drawing.Color.Black
        Me.MenuItem44.MenuBarItemFillColor = System.Drawing.SystemColors.Menu
        Me.MenuItem44.MenuBarItemFillingStyle = UltimateMenus.KunalMenuItem.MenuBarFillStyles.FillColor
        Me.MenuItem44.MenuBarItemGradientColor1 = System.Drawing.SystemColors.Menu
        Me.MenuItem44.MenuBarItemGradientColor2 = System.Drawing.SystemColors.Menu
        Me.MenuItem44.MenuBarItemGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.MenuItem44.OwnerDraw = True
        Me.MenuItem44.PreDefinedHiLiteColors = UltimateMenus.KunalMenuItem.PreDefinedHighLightColors.Khaki
        Me.MenuItem44.PreDefinedHiLiteGradientColors = UltimateMenus.KunalMenuItem.PreDefinedGrHighLightColors.BrownWhite
        Me.MenuItem44.PreDefinedSideBarGradientColour = UltimateMenus.KunalMenuItem.PreDefinedSideBarGradientColors.ShineyBlueYellow
        Me.MenuItem44.Shortcut = System.Windows.Forms.Shortcut.F10
        Me.MenuItem44.ShowBorderAroundMenuBar = False
        Me.MenuItem44.ShowHiliteOverSideBar = False
        Me.MenuItem44.ShowShadowUnderMenuBar = True
        Me.MenuItem44.SideBarGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.MenuItem44.SideBarStyle = UltimateMenus.KunalMenuItem.SideBarDrawStyle.DefaultGradient
        Me.MenuItem44.Text = "New Pigmy (BNN)"
        '
        'MenuItem77
        '
        Me.MenuItem77.CheckedImageIndex = 0
        Me.MenuItem77.CheckedMenuItemBackColor = System.Drawing.SystemColors.Control
        Me.MenuItem77.CheckedMenuItemBorderColor = System.Drawing.SystemColors.Control
        Me.MenuItem77.CheckedMenuItemDisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(197, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(184, Byte), Integer))
        Me.MenuItem77.CheckedMenuItemIconShadowColor = System.Drawing.Color.Gray
        Me.MenuItem77.CheckedMenuItemStyle = UltimateMenus.KunalMenuItem.CheckedMenuStyles.CheckedItemDefault
        Me.MenuItem77.CheckedMenuItemTickMarkColor = System.Drawing.SystemColors.Control
        Me.MenuItem77.FillMenuBarItem = False
        Me.MenuItem77.HighLightForeColor = System.Drawing.SystemColors.HighlightText
        Me.MenuItem77.HighLightScheme = UltimateMenus.KunalMenuItem.HighLightColorDrawStyle.DefaultScheme
        Me.MenuItem77.HiliteGradientColor1 = System.Drawing.Color.WhiteSmoke
        Me.MenuItem77.HiliteGradientColor2 = System.Drawing.Color.CornflowerBlue
        Me.MenuItem77.HiLiteGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.MenuItem77.IconShadowColor = System.Drawing.Color.Gray
        Me.MenuItem77.ImageIndex = 0
        Me.MenuItem77.Index = 1
        Me.MenuItem77.MakeCheckedMenuItemIconTransparent = False
        Me.MenuItem77.MakeTransparentIcon = False
        Me.MenuItem77.MenuBarItemBorderColor = System.Drawing.Color.Black
        Me.MenuItem77.MenuBarItemFillColor = System.Drawing.SystemColors.Menu
        Me.MenuItem77.MenuBarItemFillingStyle = UltimateMenus.KunalMenuItem.MenuBarFillStyles.FillColor
        Me.MenuItem77.MenuBarItemGradientColor1 = System.Drawing.SystemColors.Menu
        Me.MenuItem77.MenuBarItemGradientColor2 = System.Drawing.SystemColors.Menu
        Me.MenuItem77.MenuBarItemGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.MenuItem77.OwnerDraw = True
        Me.MenuItem77.PreDefinedHiLiteColors = UltimateMenus.KunalMenuItem.PreDefinedHighLightColors.Khaki
        Me.MenuItem77.PreDefinedHiLiteGradientColors = UltimateMenus.KunalMenuItem.PreDefinedGrHighLightColors.BrownWhite
        Me.MenuItem77.PreDefinedSideBarGradientColour = UltimateMenus.KunalMenuItem.PreDefinedSideBarGradientColors.ShineyBlueYellow
        Me.MenuItem77.ShowBorderAroundMenuBar = False
        Me.MenuItem77.ShowHiliteOverSideBar = False
        Me.MenuItem77.ShowShadowUnderMenuBar = True
        Me.MenuItem77.SideBarGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.MenuItem77.SideBarStyle = UltimateMenus.KunalMenuItem.SideBarDrawStyle.DefaultGradient
        Me.MenuItem77.Text = "Pigmy (BNN) Deposit"
        Me.MenuItem77.Visible = False
        '
        'MenuItem97
        '
        Me.MenuItem97.CheckedImageIndex = 0
        Me.MenuItem97.CheckedMenuItemBackColor = System.Drawing.SystemColors.Control
        Me.MenuItem97.CheckedMenuItemBorderColor = System.Drawing.SystemColors.Control
        Me.MenuItem97.CheckedMenuItemDisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(197, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(184, Byte), Integer))
        Me.MenuItem97.CheckedMenuItemIconShadowColor = System.Drawing.Color.Gray
        Me.MenuItem97.CheckedMenuItemStyle = UltimateMenus.KunalMenuItem.CheckedMenuStyles.CheckedItemDefault
        Me.MenuItem97.CheckedMenuItemTickMarkColor = System.Drawing.SystemColors.Control
        Me.MenuItem97.FillMenuBarItem = False
        Me.MenuItem97.HighLightForeColor = System.Drawing.SystemColors.HighlightText
        Me.MenuItem97.HighLightScheme = UltimateMenus.KunalMenuItem.HighLightColorDrawStyle.DefaultScheme
        Me.MenuItem97.HiliteGradientColor1 = System.Drawing.Color.WhiteSmoke
        Me.MenuItem97.HiliteGradientColor2 = System.Drawing.Color.CornflowerBlue
        Me.MenuItem97.HiLiteGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.MenuItem97.IconShadowColor = System.Drawing.Color.Gray
        Me.MenuItem97.ImageIndex = 0
        Me.MenuItem97.Index = 2
        Me.MenuItem97.MakeCheckedMenuItemIconTransparent = False
        Me.MenuItem97.MakeTransparentIcon = False
        Me.MenuItem97.MenuBarItemBorderColor = System.Drawing.Color.Black
        Me.MenuItem97.MenuBarItemFillColor = System.Drawing.SystemColors.Menu
        Me.MenuItem97.MenuBarItemFillingStyle = UltimateMenus.KunalMenuItem.MenuBarFillStyles.FillColor
        Me.MenuItem97.MenuBarItemGradientColor1 = System.Drawing.SystemColors.Menu
        Me.MenuItem97.MenuBarItemGradientColor2 = System.Drawing.SystemColors.Menu
        Me.MenuItem97.MenuBarItemGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.MenuItem97.OwnerDraw = True
        Me.MenuItem97.PreDefinedHiLiteColors = UltimateMenus.KunalMenuItem.PreDefinedHighLightColors.Khaki
        Me.MenuItem97.PreDefinedHiLiteGradientColors = UltimateMenus.KunalMenuItem.PreDefinedGrHighLightColors.BrownWhite
        Me.MenuItem97.PreDefinedSideBarGradientColour = UltimateMenus.KunalMenuItem.PreDefinedSideBarGradientColors.ShineyBlueYellow
        Me.MenuItem97.ShowBorderAroundMenuBar = False
        Me.MenuItem97.ShowHiliteOverSideBar = False
        Me.MenuItem97.ShowShadowUnderMenuBar = True
        Me.MenuItem97.SideBarGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.MenuItem97.SideBarStyle = UltimateMenus.KunalMenuItem.SideBarDrawStyle.DefaultGradient
        Me.MenuItem97.Text = "Pigmy (BNN) Premeature"
        '
        'MenuItem136
        '
        Me.MenuItem136.CheckedImageIndex = 0
        Me.MenuItem136.CheckedMenuItemBackColor = System.Drawing.SystemColors.Control
        Me.MenuItem136.CheckedMenuItemBorderColor = System.Drawing.SystemColors.Control
        Me.MenuItem136.CheckedMenuItemDisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(197, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(184, Byte), Integer))
        Me.MenuItem136.CheckedMenuItemIconShadowColor = System.Drawing.Color.Gray
        Me.MenuItem136.CheckedMenuItemStyle = UltimateMenus.KunalMenuItem.CheckedMenuStyles.CheckedItemDefault
        Me.MenuItem136.CheckedMenuItemTickMarkColor = System.Drawing.SystemColors.Control
        Me.MenuItem136.FillMenuBarItem = False
        Me.MenuItem136.HighLightForeColor = System.Drawing.SystemColors.HighlightText
        Me.MenuItem136.HighLightScheme = UltimateMenus.KunalMenuItem.HighLightColorDrawStyle.DefaultScheme
        Me.MenuItem136.HiliteGradientColor1 = System.Drawing.Color.WhiteSmoke
        Me.MenuItem136.HiliteGradientColor2 = System.Drawing.Color.CornflowerBlue
        Me.MenuItem136.HiLiteGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.MenuItem136.IconShadowColor = System.Drawing.Color.Gray
        Me.MenuItem136.ImageIndex = 0
        Me.MenuItem136.Index = 3
        Me.MenuItem136.MakeCheckedMenuItemIconTransparent = False
        Me.MenuItem136.MakeTransparentIcon = False
        Me.MenuItem136.MenuBarItemBorderColor = System.Drawing.Color.Black
        Me.MenuItem136.MenuBarItemFillColor = System.Drawing.SystemColors.Menu
        Me.MenuItem136.MenuBarItemFillingStyle = UltimateMenus.KunalMenuItem.MenuBarFillStyles.FillColor
        Me.MenuItem136.MenuBarItemGradientColor1 = System.Drawing.SystemColors.Menu
        Me.MenuItem136.MenuBarItemGradientColor2 = System.Drawing.SystemColors.Menu
        Me.MenuItem136.MenuBarItemGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.MenuItem136.OwnerDraw = True
        Me.MenuItem136.PreDefinedHiLiteColors = UltimateMenus.KunalMenuItem.PreDefinedHighLightColors.Khaki
        Me.MenuItem136.PreDefinedHiLiteGradientColors = UltimateMenus.KunalMenuItem.PreDefinedGrHighLightColors.BrownWhite
        Me.MenuItem136.PreDefinedSideBarGradientColour = UltimateMenus.KunalMenuItem.PreDefinedSideBarGradientColors.ShineyBlueYellow
        Me.MenuItem136.ShowBorderAroundMenuBar = False
        Me.MenuItem136.ShowHiliteOverSideBar = False
        Me.MenuItem136.ShowShadowUnderMenuBar = True
        Me.MenuItem136.SideBarGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.MenuItem136.SideBarStyle = UltimateMenus.KunalMenuItem.SideBarDrawStyle.DefaultGradient
        Me.MenuItem136.Text = "Agent Creation"
        '
        'MenuItem45
        '
        Me.MenuItem45.CheckedImageIndex = 0
        Me.MenuItem45.CheckedMenuItemBackColor = System.Drawing.SystemColors.Control
        Me.MenuItem45.CheckedMenuItemBorderColor = System.Drawing.SystemColors.Control
        Me.MenuItem45.CheckedMenuItemDisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(197, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(184, Byte), Integer))
        Me.MenuItem45.CheckedMenuItemIconShadowColor = System.Drawing.Color.Gray
        Me.MenuItem45.CheckedMenuItemStyle = UltimateMenus.KunalMenuItem.CheckedMenuStyles.CheckedItemDefault
        Me.MenuItem45.CheckedMenuItemTickMarkColor = System.Drawing.SystemColors.Control
        Me.MenuItem45.FillMenuBarItem = False
        Me.MenuItem45.HighLightForeColor = System.Drawing.SystemColors.HighlightText
        Me.MenuItem45.HighLightScheme = UltimateMenus.KunalMenuItem.HighLightColorDrawStyle.DefaultScheme
        Me.MenuItem45.HiliteGradientColor1 = System.Drawing.Color.WhiteSmoke
        Me.MenuItem45.HiliteGradientColor2 = System.Drawing.Color.CornflowerBlue
        Me.MenuItem45.HiLiteGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.MenuItem45.IconShadowColor = System.Drawing.Color.Gray
        Me.MenuItem45.ImageIndex = 0
        Me.MenuItem45.Index = 4
        Me.MenuItem45.MakeCheckedMenuItemIconTransparent = False
        Me.MenuItem45.MakeTransparentIcon = False
        Me.MenuItem45.MenuBarItemBorderColor = System.Drawing.Color.Black
        Me.MenuItem45.MenuBarItemFillColor = System.Drawing.SystemColors.Menu
        Me.MenuItem45.MenuBarItemFillingStyle = UltimateMenus.KunalMenuItem.MenuBarFillStyles.FillColor
        Me.MenuItem45.MenuBarItemGradientColor1 = System.Drawing.SystemColors.Menu
        Me.MenuItem45.MenuBarItemGradientColor2 = System.Drawing.SystemColors.Menu
        Me.MenuItem45.MenuBarItemGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.MenuItem45.OwnerDraw = True
        Me.MenuItem45.PreDefinedHiLiteColors = UltimateMenus.KunalMenuItem.PreDefinedHighLightColors.Khaki
        Me.MenuItem45.PreDefinedHiLiteGradientColors = UltimateMenus.KunalMenuItem.PreDefinedGrHighLightColors.BrownWhite
        Me.MenuItem45.PreDefinedSideBarGradientColour = UltimateMenus.KunalMenuItem.PreDefinedSideBarGradientColors.ShineyBlueYellow
        Me.MenuItem45.ShowBorderAroundMenuBar = False
        Me.MenuItem45.ShowHiliteOverSideBar = False
        Me.MenuItem45.ShowShadowUnderMenuBar = True
        Me.MenuItem45.SideBarGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.MenuItem45.SideBarStyle = UltimateMenus.KunalMenuItem.SideBarDrawStyle.DefaultGradient
        Me.MenuItem45.Text = "Pigmy (BNN) Closure "
        '
        'MenuItem46
        '
        Me.MenuItem46.CheckedImageIndex = 0
        Me.MenuItem46.CheckedMenuItemBackColor = System.Drawing.SystemColors.Control
        Me.MenuItem46.CheckedMenuItemBorderColor = System.Drawing.SystemColors.Control
        Me.MenuItem46.CheckedMenuItemDisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(197, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(184, Byte), Integer))
        Me.MenuItem46.CheckedMenuItemIconShadowColor = System.Drawing.Color.Gray
        Me.MenuItem46.CheckedMenuItemStyle = UltimateMenus.KunalMenuItem.CheckedMenuStyles.CheckedItemDefault
        Me.MenuItem46.CheckedMenuItemTickMarkColor = System.Drawing.SystemColors.Control
        Me.MenuItem46.FillMenuBarItem = False
        Me.MenuItem46.HighLightForeColor = System.Drawing.SystemColors.HighlightText
        Me.MenuItem46.HighLightScheme = UltimateMenus.KunalMenuItem.HighLightColorDrawStyle.DefaultScheme
        Me.MenuItem46.HiliteGradientColor1 = System.Drawing.Color.WhiteSmoke
        Me.MenuItem46.HiliteGradientColor2 = System.Drawing.Color.CornflowerBlue
        Me.MenuItem46.HiLiteGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.MenuItem46.IconShadowColor = System.Drawing.Color.Gray
        Me.MenuItem46.ImageIndex = 0
        Me.MenuItem46.Index = 5
        Me.MenuItem46.MakeCheckedMenuItemIconTransparent = False
        Me.MenuItem46.MakeTransparentIcon = False
        Me.MenuItem46.MenuBarItemBorderColor = System.Drawing.Color.Black
        Me.MenuItem46.MenuBarItemFillColor = System.Drawing.SystemColors.Menu
        Me.MenuItem46.MenuBarItemFillingStyle = UltimateMenus.KunalMenuItem.MenuBarFillStyles.FillColor
        Me.MenuItem46.MenuBarItemGradientColor1 = System.Drawing.SystemColors.Menu
        Me.MenuItem46.MenuBarItemGradientColor2 = System.Drawing.SystemColors.Menu
        Me.MenuItem46.MenuBarItemGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.MenuItem46.OwnerDraw = True
        Me.MenuItem46.PreDefinedHiLiteColors = UltimateMenus.KunalMenuItem.PreDefinedHighLightColors.Khaki
        Me.MenuItem46.PreDefinedHiLiteGradientColors = UltimateMenus.KunalMenuItem.PreDefinedGrHighLightColors.BrownWhite
        Me.MenuItem46.PreDefinedSideBarGradientColour = UltimateMenus.KunalMenuItem.PreDefinedSideBarGradientColors.ShineyBlueYellow
        Me.MenuItem46.Shortcut = System.Windows.Forms.Shortcut.CtrlF10
        Me.MenuItem46.ShowBorderAroundMenuBar = False
        Me.MenuItem46.ShowHiliteOverSideBar = False
        Me.MenuItem46.ShowShadowUnderMenuBar = True
        Me.MenuItem46.SideBarGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.MenuItem46.SideBarStyle = UltimateMenus.KunalMenuItem.SideBarDrawStyle.DefaultGradient
        Me.MenuItem46.Text = "View Pigmy (BNN)"
        '
        'MenuItem147
        '
        Me.MenuItem147.CheckedImageIndex = 0
        Me.MenuItem147.CheckedMenuItemBackColor = System.Drawing.SystemColors.Control
        Me.MenuItem147.CheckedMenuItemBorderColor = System.Drawing.SystemColors.Control
        Me.MenuItem147.CheckedMenuItemDisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(197, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(184, Byte), Integer))
        Me.MenuItem147.CheckedMenuItemIconShadowColor = System.Drawing.Color.Gray
        Me.MenuItem147.CheckedMenuItemStyle = UltimateMenus.KunalMenuItem.CheckedMenuStyles.CheckedItemDefault
        Me.MenuItem147.CheckedMenuItemTickMarkColor = System.Drawing.SystemColors.Control
        Me.MenuItem147.FillMenuBarItem = False
        Me.MenuItem147.HighLightForeColor = System.Drawing.SystemColors.HighlightText
        Me.MenuItem147.HighLightScheme = UltimateMenus.KunalMenuItem.HighLightColorDrawStyle.DefaultScheme
        Me.MenuItem147.HiliteGradientColor1 = System.Drawing.Color.WhiteSmoke
        Me.MenuItem147.HiliteGradientColor2 = System.Drawing.Color.CornflowerBlue
        Me.MenuItem147.HiLiteGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.MenuItem147.IconShadowColor = System.Drawing.Color.Gray
        Me.MenuItem147.ImageIndex = 0
        Me.MenuItem147.Index = 6
        Me.MenuItem147.MakeCheckedMenuItemIconTransparent = False
        Me.MenuItem147.MakeTransparentIcon = False
        Me.MenuItem147.MenuBarItemBorderColor = System.Drawing.Color.Black
        Me.MenuItem147.MenuBarItemFillColor = System.Drawing.SystemColors.Menu
        Me.MenuItem147.MenuBarItemFillingStyle = UltimateMenus.KunalMenuItem.MenuBarFillStyles.FillColor
        Me.MenuItem147.MenuBarItemGradientColor1 = System.Drawing.SystemColors.Menu
        Me.MenuItem147.MenuBarItemGradientColor2 = System.Drawing.SystemColors.Menu
        Me.MenuItem147.MenuBarItemGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.MenuItem147.OwnerDraw = True
        Me.MenuItem147.PreDefinedHiLiteColors = UltimateMenus.KunalMenuItem.PreDefinedHighLightColors.Khaki
        Me.MenuItem147.PreDefinedHiLiteGradientColors = UltimateMenus.KunalMenuItem.PreDefinedGrHighLightColors.BrownWhite
        Me.MenuItem147.PreDefinedSideBarGradientColour = UltimateMenus.KunalMenuItem.PreDefinedSideBarGradientColors.ShineyBlueYellow
        Me.MenuItem147.ShowBorderAroundMenuBar = False
        Me.MenuItem147.ShowHiliteOverSideBar = False
        Me.MenuItem147.ShowShadowUnderMenuBar = True
        Me.MenuItem147.SideBarGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.MenuItem147.SideBarStyle = UltimateMenus.KunalMenuItem.SideBarDrawStyle.DefaultGradient
        Me.MenuItem147.Text = "Pigmy(BNND) Deposit Process"
        '
        'MenuItem148
        '
        Me.MenuItem148.CheckedImageIndex = 0
        Me.MenuItem148.CheckedMenuItemBackColor = System.Drawing.SystemColors.Control
        Me.MenuItem148.CheckedMenuItemBorderColor = System.Drawing.SystemColors.Control
        Me.MenuItem148.CheckedMenuItemDisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(197, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(184, Byte), Integer))
        Me.MenuItem148.CheckedMenuItemIconShadowColor = System.Drawing.Color.Gray
        Me.MenuItem148.CheckedMenuItemStyle = UltimateMenus.KunalMenuItem.CheckedMenuStyles.CheckedItemDefault
        Me.MenuItem148.CheckedMenuItemTickMarkColor = System.Drawing.SystemColors.Control
        Me.MenuItem148.FillMenuBarItem = False
        Me.MenuItem148.HighLightForeColor = System.Drawing.SystemColors.HighlightText
        Me.MenuItem148.HighLightScheme = UltimateMenus.KunalMenuItem.HighLightColorDrawStyle.DefaultScheme
        Me.MenuItem148.HiliteGradientColor1 = System.Drawing.Color.WhiteSmoke
        Me.MenuItem148.HiliteGradientColor2 = System.Drawing.Color.CornflowerBlue
        Me.MenuItem148.HiLiteGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.MenuItem148.IconShadowColor = System.Drawing.Color.Gray
        Me.MenuItem148.ImageIndex = 0
        Me.MenuItem148.Index = 7
        Me.MenuItem148.MakeCheckedMenuItemIconTransparent = False
        Me.MenuItem148.MakeTransparentIcon = False
        Me.MenuItem148.MenuBarItemBorderColor = System.Drawing.Color.Black
        Me.MenuItem148.MenuBarItemFillColor = System.Drawing.SystemColors.Menu
        Me.MenuItem148.MenuBarItemFillingStyle = UltimateMenus.KunalMenuItem.MenuBarFillStyles.FillColor
        Me.MenuItem148.MenuBarItemGradientColor1 = System.Drawing.SystemColors.Menu
        Me.MenuItem148.MenuBarItemGradientColor2 = System.Drawing.SystemColors.Menu
        Me.MenuItem148.MenuBarItemGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.MenuItem148.OwnerDraw = True
        Me.MenuItem148.PreDefinedHiLiteColors = UltimateMenus.KunalMenuItem.PreDefinedHighLightColors.Khaki
        Me.MenuItem148.PreDefinedHiLiteGradientColors = UltimateMenus.KunalMenuItem.PreDefinedGrHighLightColors.BrownWhite
        Me.MenuItem148.PreDefinedSideBarGradientColour = UltimateMenus.KunalMenuItem.PreDefinedSideBarGradientColors.ShineyBlueYellow
        Me.MenuItem148.ShowBorderAroundMenuBar = False
        Me.MenuItem148.ShowHiliteOverSideBar = False
        Me.MenuItem148.ShowShadowUnderMenuBar = True
        Me.MenuItem148.SideBarGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.MenuItem148.SideBarStyle = UltimateMenus.KunalMenuItem.SideBarDrawStyle.DefaultGradient
        Me.MenuItem148.Text = "Pigmy(BNNC) Collection Process"
        '
        'MenuItem149
        '
        Me.MenuItem149.CheckedImageIndex = 0
        Me.MenuItem149.CheckedMenuItemBackColor = System.Drawing.SystemColors.Control
        Me.MenuItem149.CheckedMenuItemBorderColor = System.Drawing.SystemColors.Control
        Me.MenuItem149.CheckedMenuItemDisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(197, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(184, Byte), Integer))
        Me.MenuItem149.CheckedMenuItemIconShadowColor = System.Drawing.Color.Gray
        Me.MenuItem149.CheckedMenuItemStyle = UltimateMenus.KunalMenuItem.CheckedMenuStyles.CheckedItemDefault
        Me.MenuItem149.CheckedMenuItemTickMarkColor = System.Drawing.SystemColors.Control
        Me.MenuItem149.FillMenuBarItem = False
        Me.MenuItem149.HighLightForeColor = System.Drawing.SystemColors.HighlightText
        Me.MenuItem149.HighLightScheme = UltimateMenus.KunalMenuItem.HighLightColorDrawStyle.DefaultScheme
        Me.MenuItem149.HiliteGradientColor1 = System.Drawing.Color.WhiteSmoke
        Me.MenuItem149.HiliteGradientColor2 = System.Drawing.Color.CornflowerBlue
        Me.MenuItem149.HiLiteGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.MenuItem149.IconShadowColor = System.Drawing.Color.Gray
        Me.MenuItem149.ImageIndex = 0
        Me.MenuItem149.Index = 8
        Me.MenuItem149.MakeCheckedMenuItemIconTransparent = False
        Me.MenuItem149.MakeTransparentIcon = False
        Me.MenuItem149.MenuBarItemBorderColor = System.Drawing.Color.Black
        Me.MenuItem149.MenuBarItemFillColor = System.Drawing.SystemColors.Menu
        Me.MenuItem149.MenuBarItemFillingStyle = UltimateMenus.KunalMenuItem.MenuBarFillStyles.FillColor
        Me.MenuItem149.MenuBarItemGradientColor1 = System.Drawing.SystemColors.Menu
        Me.MenuItem149.MenuBarItemGradientColor2 = System.Drawing.SystemColors.Menu
        Me.MenuItem149.MenuBarItemGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.MenuItem149.OwnerDraw = True
        Me.MenuItem149.PreDefinedHiLiteColors = UltimateMenus.KunalMenuItem.PreDefinedHighLightColors.Khaki
        Me.MenuItem149.PreDefinedHiLiteGradientColors = UltimateMenus.KunalMenuItem.PreDefinedGrHighLightColors.BrownWhite
        Me.MenuItem149.PreDefinedSideBarGradientColour = UltimateMenus.KunalMenuItem.PreDefinedSideBarGradientColors.ShineyBlueYellow
        Me.MenuItem149.ShowBorderAroundMenuBar = False
        Me.MenuItem149.ShowHiliteOverSideBar = False
        Me.MenuItem149.ShowShadowUnderMenuBar = True
        Me.MenuItem149.SideBarGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.MenuItem149.SideBarStyle = UltimateMenus.KunalMenuItem.SideBarDrawStyle.DefaultGradient
        Me.MenuItem149.Text = "Agen's Commission"
        '
        'MenuItem180
        '
        Me.MenuItem180.Index = 9
        Me.MenuItem180.Text = "Pigmy Machine Import/Export"
        '
        'MenuItem6
        '
        Me.MenuItem6.CheckedImageIndex = 0
        Me.MenuItem6.CheckedMenuItemBackColor = System.Drawing.SystemColors.Control
        Me.MenuItem6.CheckedMenuItemBorderColor = System.Drawing.SystemColors.Control
        Me.MenuItem6.CheckedMenuItemDisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(197, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(184, Byte), Integer))
        Me.MenuItem6.CheckedMenuItemIconShadowColor = System.Drawing.Color.Gray
        Me.MenuItem6.CheckedMenuItemStyle = UltimateMenus.KunalMenuItem.CheckedMenuStyles.CheckedItemDefault
        Me.MenuItem6.CheckedMenuItemTickMarkColor = System.Drawing.SystemColors.Control
        Me.MenuItem6.FillMenuBarItem = False
        Me.MenuItem6.HighLightForeColor = System.Drawing.SystemColors.HighlightText
        Me.MenuItem6.HighLightScheme = UltimateMenus.KunalMenuItem.HighLightColorDrawStyle.DefaultScheme
        Me.MenuItem6.HiliteGradientColor1 = System.Drawing.Color.WhiteSmoke
        Me.MenuItem6.HiliteGradientColor2 = System.Drawing.Color.CornflowerBlue
        Me.MenuItem6.HiLiteGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.MenuItem6.IconShadowColor = System.Drawing.Color.Gray
        Me.MenuItem6.ImageIndex = 0
        Me.MenuItem6.Index = 6
        Me.MenuItem6.MakeCheckedMenuItemIconTransparent = False
        Me.MenuItem6.MakeTransparentIcon = False
        Me.MenuItem6.MenuBarItemBorderColor = System.Drawing.Color.Black
        Me.MenuItem6.MenuBarItemFillColor = System.Drawing.SystemColors.Menu
        Me.MenuItem6.MenuBarItemFillingStyle = UltimateMenus.KunalMenuItem.MenuBarFillStyles.FillColor
        Me.MenuItem6.MenuBarItemGradientColor1 = System.Drawing.SystemColors.Menu
        Me.MenuItem6.MenuBarItemGradientColor2 = System.Drawing.SystemColors.Menu
        Me.MenuItem6.MenuBarItemGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.MenuItem6.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem94, Me.MenuItem95, Me.MenuItem122, Me.MenuItem120, Me.MenuItem121, Me.MenuItem123, Me.MenuItem124, Me.MenuItem144, Me.MenuItem99, Me.smnuDefaulters, Me.mnuSMTL})
        Me.MenuItem6.OwnerDraw = True
        Me.MenuItem6.PreDefinedHiLiteColors = UltimateMenus.KunalMenuItem.PreDefinedHighLightColors.Khaki
        Me.MenuItem6.PreDefinedHiLiteGradientColors = UltimateMenus.KunalMenuItem.PreDefinedGrHighLightColors.BrownWhite
        Me.MenuItem6.PreDefinedSideBarGradientColour = UltimateMenus.KunalMenuItem.PreDefinedSideBarGradientColors.ShineyBlueYellow
        Me.MenuItem6.ShowBorderAroundMenuBar = False
        Me.MenuItem6.ShowHiliteOverSideBar = False
        Me.MenuItem6.ShowShadowUnderMenuBar = True
        Me.MenuItem6.SideBarGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.MenuItem6.SideBarStyle = UltimateMenus.KunalMenuItem.SideBarDrawStyle.DefaultGradient
        Me.MenuItem6.Text = "&Loans"
        '
        'MenuItem94
        '
        Me.MenuItem94.CheckedImageIndex = 0
        Me.MenuItem94.CheckedMenuItemBackColor = System.Drawing.SystemColors.Control
        Me.MenuItem94.CheckedMenuItemBorderColor = System.Drawing.SystemColors.Control
        Me.MenuItem94.CheckedMenuItemDisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(197, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(184, Byte), Integer))
        Me.MenuItem94.CheckedMenuItemIconShadowColor = System.Drawing.Color.Gray
        Me.MenuItem94.CheckedMenuItemStyle = UltimateMenus.KunalMenuItem.CheckedMenuStyles.CheckedItemDefault
        Me.MenuItem94.CheckedMenuItemTickMarkColor = System.Drawing.SystemColors.Control
        Me.MenuItem94.FillMenuBarItem = False
        Me.MenuItem94.HighLightForeColor = System.Drawing.SystemColors.HighlightText
        Me.MenuItem94.HighLightScheme = UltimateMenus.KunalMenuItem.HighLightColorDrawStyle.DefaultScheme
        Me.MenuItem94.HiliteGradientColor1 = System.Drawing.Color.WhiteSmoke
        Me.MenuItem94.HiliteGradientColor2 = System.Drawing.Color.CornflowerBlue
        Me.MenuItem94.HiLiteGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.MenuItem94.IconShadowColor = System.Drawing.Color.Gray
        Me.MenuItem94.ImageIndex = 0
        Me.MenuItem94.Index = 0
        Me.MenuItem94.MakeCheckedMenuItemIconTransparent = False
        Me.MenuItem94.MakeTransparentIcon = False
        Me.MenuItem94.MenuBarItemBorderColor = System.Drawing.Color.Black
        Me.MenuItem94.MenuBarItemFillColor = System.Drawing.SystemColors.Menu
        Me.MenuItem94.MenuBarItemFillingStyle = UltimateMenus.KunalMenuItem.MenuBarFillStyles.FillColor
        Me.MenuItem94.MenuBarItemGradientColor1 = System.Drawing.SystemColors.Menu
        Me.MenuItem94.MenuBarItemGradientColor2 = System.Drawing.SystemColors.Menu
        Me.MenuItem94.MenuBarItemGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.MenuItem94.OwnerDraw = True
        Me.MenuItem94.PreDefinedHiLiteColors = UltimateMenus.KunalMenuItem.PreDefinedHighLightColors.Khaki
        Me.MenuItem94.PreDefinedHiLiteGradientColors = UltimateMenus.KunalMenuItem.PreDefinedGrHighLightColors.BrownWhite
        Me.MenuItem94.PreDefinedSideBarGradientColour = UltimateMenus.KunalMenuItem.PreDefinedSideBarGradientColors.ShineyBlueYellow
        Me.MenuItem94.ShowBorderAroundMenuBar = False
        Me.MenuItem94.ShowHiliteOverSideBar = False
        Me.MenuItem94.ShowShadowUnderMenuBar = True
        Me.MenuItem94.SideBarGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.MenuItem94.SideBarStyle = UltimateMenus.KunalMenuItem.SideBarDrawStyle.DefaultGradient
        Me.MenuItem94.Text = "&Jewel Loan"
        '
        'MenuItem95
        '
        Me.MenuItem95.CheckedImageIndex = 0
        Me.MenuItem95.CheckedMenuItemBackColor = System.Drawing.SystemColors.Control
        Me.MenuItem95.CheckedMenuItemBorderColor = System.Drawing.SystemColors.Control
        Me.MenuItem95.CheckedMenuItemDisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(197, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(184, Byte), Integer))
        Me.MenuItem95.CheckedMenuItemIconShadowColor = System.Drawing.Color.Gray
        Me.MenuItem95.CheckedMenuItemStyle = UltimateMenus.KunalMenuItem.CheckedMenuStyles.CheckedItemDefault
        Me.MenuItem95.CheckedMenuItemTickMarkColor = System.Drawing.SystemColors.Control
        Me.MenuItem95.FillMenuBarItem = False
        Me.MenuItem95.HighLightForeColor = System.Drawing.SystemColors.HighlightText
        Me.MenuItem95.HighLightScheme = UltimateMenus.KunalMenuItem.HighLightColorDrawStyle.DefaultScheme
        Me.MenuItem95.HiliteGradientColor1 = System.Drawing.Color.WhiteSmoke
        Me.MenuItem95.HiliteGradientColor2 = System.Drawing.Color.CornflowerBlue
        Me.MenuItem95.HiLiteGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.MenuItem95.IconShadowColor = System.Drawing.Color.Gray
        Me.MenuItem95.ImageIndex = 0
        Me.MenuItem95.Index = 1
        Me.MenuItem95.MakeCheckedMenuItemIconTransparent = False
        Me.MenuItem95.MakeTransparentIcon = False
        Me.MenuItem95.MenuBarItemBorderColor = System.Drawing.Color.Black
        Me.MenuItem95.MenuBarItemFillColor = System.Drawing.SystemColors.Menu
        Me.MenuItem95.MenuBarItemFillingStyle = UltimateMenus.KunalMenuItem.MenuBarFillStyles.FillColor
        Me.MenuItem95.MenuBarItemGradientColor1 = System.Drawing.SystemColors.Menu
        Me.MenuItem95.MenuBarItemGradientColor2 = System.Drawing.SystemColors.Menu
        Me.MenuItem95.MenuBarItemGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.MenuItem95.OwnerDraw = True
        Me.MenuItem95.PreDefinedHiLiteColors = UltimateMenus.KunalMenuItem.PreDefinedHighLightColors.Khaki
        Me.MenuItem95.PreDefinedHiLiteGradientColors = UltimateMenus.KunalMenuItem.PreDefinedGrHighLightColors.BrownWhite
        Me.MenuItem95.PreDefinedSideBarGradientColour = UltimateMenus.KunalMenuItem.PreDefinedSideBarGradientColors.ShineyBlueYellow
        Me.MenuItem95.ShowBorderAroundMenuBar = False
        Me.MenuItem95.ShowHiliteOverSideBar = False
        Me.MenuItem95.ShowShadowUnderMenuBar = True
        Me.MenuItem95.SideBarGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.MenuItem95.SideBarStyle = UltimateMenus.KunalMenuItem.SideBarDrawStyle.DefaultGradient
        Me.MenuItem95.Text = "&Vehicle Loan"
        '
        'MenuItem122
        '
        Me.MenuItem122.CheckedImageIndex = 0
        Me.MenuItem122.CheckedMenuItemBackColor = System.Drawing.SystemColors.Control
        Me.MenuItem122.CheckedMenuItemBorderColor = System.Drawing.SystemColors.Control
        Me.MenuItem122.CheckedMenuItemDisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(197, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(184, Byte), Integer))
        Me.MenuItem122.CheckedMenuItemIconShadowColor = System.Drawing.Color.Gray
        Me.MenuItem122.CheckedMenuItemStyle = UltimateMenus.KunalMenuItem.CheckedMenuStyles.CheckedItemDefault
        Me.MenuItem122.CheckedMenuItemTickMarkColor = System.Drawing.SystemColors.Control
        Me.MenuItem122.FillMenuBarItem = False
        Me.MenuItem122.HighLightForeColor = System.Drawing.SystemColors.HighlightText
        Me.MenuItem122.HighLightScheme = UltimateMenus.KunalMenuItem.HighLightColorDrawStyle.DefaultScheme
        Me.MenuItem122.HiliteGradientColor1 = System.Drawing.Color.WhiteSmoke
        Me.MenuItem122.HiliteGradientColor2 = System.Drawing.Color.CornflowerBlue
        Me.MenuItem122.HiLiteGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.MenuItem122.IconShadowColor = System.Drawing.Color.Gray
        Me.MenuItem122.ImageIndex = 0
        Me.MenuItem122.Index = 2
        Me.MenuItem122.MakeCheckedMenuItemIconTransparent = False
        Me.MenuItem122.MakeTransparentIcon = False
        Me.MenuItem122.MenuBarItemBorderColor = System.Drawing.Color.Black
        Me.MenuItem122.MenuBarItemFillColor = System.Drawing.SystemColors.Menu
        Me.MenuItem122.MenuBarItemFillingStyle = UltimateMenus.KunalMenuItem.MenuBarFillStyles.FillColor
        Me.MenuItem122.MenuBarItemGradientColor1 = System.Drawing.SystemColors.Menu
        Me.MenuItem122.MenuBarItemGradientColor2 = System.Drawing.SystemColors.Menu
        Me.MenuItem122.MenuBarItemGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.MenuItem122.OwnerDraw = True
        Me.MenuItem122.PreDefinedHiLiteColors = UltimateMenus.KunalMenuItem.PreDefinedHighLightColors.Khaki
        Me.MenuItem122.PreDefinedHiLiteGradientColors = UltimateMenus.KunalMenuItem.PreDefinedGrHighLightColors.BrownWhite
        Me.MenuItem122.PreDefinedSideBarGradientColour = UltimateMenus.KunalMenuItem.PreDefinedSideBarGradientColors.ShineyBlueYellow
        Me.MenuItem122.ShowBorderAroundMenuBar = False
        Me.MenuItem122.ShowHiliteOverSideBar = False
        Me.MenuItem122.ShowShadowUnderMenuBar = True
        Me.MenuItem122.SideBarGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.MenuItem122.SideBarStyle = UltimateMenus.KunalMenuItem.SideBarDrawStyle.DefaultGradient
        Me.MenuItem122.Text = "&Hand Loan"
        '
        'MenuItem120
        '
        Me.MenuItem120.CheckedImageIndex = 0
        Me.MenuItem120.CheckedMenuItemBackColor = System.Drawing.SystemColors.Control
        Me.MenuItem120.CheckedMenuItemBorderColor = System.Drawing.SystemColors.Control
        Me.MenuItem120.CheckedMenuItemDisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(197, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(184, Byte), Integer))
        Me.MenuItem120.CheckedMenuItemIconShadowColor = System.Drawing.Color.Gray
        Me.MenuItem120.CheckedMenuItemStyle = UltimateMenus.KunalMenuItem.CheckedMenuStyles.CheckedItemDefault
        Me.MenuItem120.CheckedMenuItemTickMarkColor = System.Drawing.SystemColors.Control
        Me.MenuItem120.FillMenuBarItem = False
        Me.MenuItem120.HighLightForeColor = System.Drawing.SystemColors.HighlightText
        Me.MenuItem120.HighLightScheme = UltimateMenus.KunalMenuItem.HighLightColorDrawStyle.DefaultScheme
        Me.MenuItem120.HiliteGradientColor1 = System.Drawing.Color.WhiteSmoke
        Me.MenuItem120.HiliteGradientColor2 = System.Drawing.Color.CornflowerBlue
        Me.MenuItem120.HiLiteGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.MenuItem120.IconShadowColor = System.Drawing.Color.Gray
        Me.MenuItem120.ImageIndex = 0
        Me.MenuItem120.Index = 3
        Me.MenuItem120.MakeCheckedMenuItemIconTransparent = False
        Me.MenuItem120.MakeTransparentIcon = False
        Me.MenuItem120.MenuBarItemBorderColor = System.Drawing.Color.Black
        Me.MenuItem120.MenuBarItemFillColor = System.Drawing.SystemColors.Menu
        Me.MenuItem120.MenuBarItemFillingStyle = UltimateMenus.KunalMenuItem.MenuBarFillStyles.FillColor
        Me.MenuItem120.MenuBarItemGradientColor1 = System.Drawing.SystemColors.Menu
        Me.MenuItem120.MenuBarItemGradientColor2 = System.Drawing.SystemColors.Menu
        Me.MenuItem120.MenuBarItemGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.MenuItem120.OwnerDraw = True
        Me.MenuItem120.PreDefinedHiLiteColors = UltimateMenus.KunalMenuItem.PreDefinedHighLightColors.Khaki
        Me.MenuItem120.PreDefinedHiLiteGradientColors = UltimateMenus.KunalMenuItem.PreDefinedGrHighLightColors.BrownWhite
        Me.MenuItem120.PreDefinedSideBarGradientColour = UltimateMenus.KunalMenuItem.PreDefinedSideBarGradientColors.ShineyBlueYellow
        Me.MenuItem120.ShowBorderAroundMenuBar = False
        Me.MenuItem120.ShowHiliteOverSideBar = False
        Me.MenuItem120.ShowShadowUnderMenuBar = True
        Me.MenuItem120.SideBarGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.MenuItem120.SideBarStyle = UltimateMenus.KunalMenuItem.SideBarDrawStyle.DefaultGradient
        Me.MenuItem120.Text = "&Colleteral Hand Loan"
        '
        'MenuItem121
        '
        Me.MenuItem121.CheckedImageIndex = 0
        Me.MenuItem121.CheckedMenuItemBackColor = System.Drawing.SystemColors.Control
        Me.MenuItem121.CheckedMenuItemBorderColor = System.Drawing.SystemColors.Control
        Me.MenuItem121.CheckedMenuItemDisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(197, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(184, Byte), Integer))
        Me.MenuItem121.CheckedMenuItemIconShadowColor = System.Drawing.Color.Gray
        Me.MenuItem121.CheckedMenuItemStyle = UltimateMenus.KunalMenuItem.CheckedMenuStyles.CheckedItemDefault
        Me.MenuItem121.CheckedMenuItemTickMarkColor = System.Drawing.SystemColors.Control
        Me.MenuItem121.FillMenuBarItem = False
        Me.MenuItem121.HighLightForeColor = System.Drawing.SystemColors.HighlightText
        Me.MenuItem121.HighLightScheme = UltimateMenus.KunalMenuItem.HighLightColorDrawStyle.DefaultScheme
        Me.MenuItem121.HiliteGradientColor1 = System.Drawing.Color.WhiteSmoke
        Me.MenuItem121.HiliteGradientColor2 = System.Drawing.Color.CornflowerBlue
        Me.MenuItem121.HiLiteGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.MenuItem121.IconShadowColor = System.Drawing.Color.Gray
        Me.MenuItem121.ImageIndex = 0
        Me.MenuItem121.Index = 4
        Me.MenuItem121.MakeCheckedMenuItemIconTransparent = False
        Me.MenuItem121.MakeTransparentIcon = False
        Me.MenuItem121.MenuBarItemBorderColor = System.Drawing.Color.Black
        Me.MenuItem121.MenuBarItemFillColor = System.Drawing.SystemColors.Menu
        Me.MenuItem121.MenuBarItemFillingStyle = UltimateMenus.KunalMenuItem.MenuBarFillStyles.FillColor
        Me.MenuItem121.MenuBarItemGradientColor1 = System.Drawing.SystemColors.Menu
        Me.MenuItem121.MenuBarItemGradientColor2 = System.Drawing.SystemColors.Menu
        Me.MenuItem121.MenuBarItemGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.MenuItem121.OwnerDraw = True
        Me.MenuItem121.PreDefinedHiLiteColors = UltimateMenus.KunalMenuItem.PreDefinedHighLightColors.Khaki
        Me.MenuItem121.PreDefinedHiLiteGradientColors = UltimateMenus.KunalMenuItem.PreDefinedGrHighLightColors.BrownWhite
        Me.MenuItem121.PreDefinedSideBarGradientColour = UltimateMenus.KunalMenuItem.PreDefinedSideBarGradientColors.ShineyBlueYellow
        Me.MenuItem121.ShowBorderAroundMenuBar = False
        Me.MenuItem121.ShowHiliteOverSideBar = False
        Me.MenuItem121.ShowShadowUnderMenuBar = True
        Me.MenuItem121.SideBarGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.MenuItem121.SideBarStyle = UltimateMenus.KunalMenuItem.SideBarDrawStyle.DefaultGradient
        Me.MenuItem121.Text = "&Secured Loan"
        '
        'MenuItem123
        '
        Me.MenuItem123.CheckedImageIndex = 0
        Me.MenuItem123.CheckedMenuItemBackColor = System.Drawing.SystemColors.Control
        Me.MenuItem123.CheckedMenuItemBorderColor = System.Drawing.SystemColors.Control
        Me.MenuItem123.CheckedMenuItemDisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(197, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(184, Byte), Integer))
        Me.MenuItem123.CheckedMenuItemIconShadowColor = System.Drawing.Color.Gray
        Me.MenuItem123.CheckedMenuItemStyle = UltimateMenus.KunalMenuItem.CheckedMenuStyles.CheckedItemDefault
        Me.MenuItem123.CheckedMenuItemTickMarkColor = System.Drawing.SystemColors.Control
        Me.MenuItem123.FillMenuBarItem = False
        Me.MenuItem123.HighLightForeColor = System.Drawing.SystemColors.HighlightText
        Me.MenuItem123.HighLightScheme = UltimateMenus.KunalMenuItem.HighLightColorDrawStyle.DefaultScheme
        Me.MenuItem123.HiliteGradientColor1 = System.Drawing.Color.WhiteSmoke
        Me.MenuItem123.HiliteGradientColor2 = System.Drawing.Color.CornflowerBlue
        Me.MenuItem123.HiLiteGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.MenuItem123.IconShadowColor = System.Drawing.Color.Gray
        Me.MenuItem123.ImageIndex = 0
        Me.MenuItem123.Index = 5
        Me.MenuItem123.MakeCheckedMenuItemIconTransparent = False
        Me.MenuItem123.MakeTransparentIcon = False
        Me.MenuItem123.MenuBarItemBorderColor = System.Drawing.Color.Black
        Me.MenuItem123.MenuBarItemFillColor = System.Drawing.SystemColors.Menu
        Me.MenuItem123.MenuBarItemFillingStyle = UltimateMenus.KunalMenuItem.MenuBarFillStyles.FillColor
        Me.MenuItem123.MenuBarItemGradientColor1 = System.Drawing.SystemColors.Menu
        Me.MenuItem123.MenuBarItemGradientColor2 = System.Drawing.SystemColors.Menu
        Me.MenuItem123.MenuBarItemGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.MenuItem123.OwnerDraw = True
        Me.MenuItem123.PreDefinedHiLiteColors = UltimateMenus.KunalMenuItem.PreDefinedHighLightColors.Khaki
        Me.MenuItem123.PreDefinedHiLiteGradientColors = UltimateMenus.KunalMenuItem.PreDefinedGrHighLightColors.BrownWhite
        Me.MenuItem123.PreDefinedSideBarGradientColour = UltimateMenus.KunalMenuItem.PreDefinedSideBarGradientColors.ShineyBlueYellow
        Me.MenuItem123.ShowBorderAroundMenuBar = False
        Me.MenuItem123.ShowHiliteOverSideBar = False
        Me.MenuItem123.ShowShadowUnderMenuBar = True
        Me.MenuItem123.SideBarGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.MenuItem123.SideBarStyle = UltimateMenus.KunalMenuItem.SideBarDrawStyle.DefaultGradient
        Me.MenuItem123.Text = "Loans on &Term Deposit"
        '
        'MenuItem124
        '
        Me.MenuItem124.CheckedImageIndex = 0
        Me.MenuItem124.CheckedMenuItemBackColor = System.Drawing.SystemColors.Control
        Me.MenuItem124.CheckedMenuItemBorderColor = System.Drawing.SystemColors.Control
        Me.MenuItem124.CheckedMenuItemDisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(197, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(184, Byte), Integer))
        Me.MenuItem124.CheckedMenuItemIconShadowColor = System.Drawing.Color.Gray
        Me.MenuItem124.CheckedMenuItemStyle = UltimateMenus.KunalMenuItem.CheckedMenuStyles.CheckedItemDefault
        Me.MenuItem124.CheckedMenuItemTickMarkColor = System.Drawing.SystemColors.Control
        Me.MenuItem124.FillMenuBarItem = False
        Me.MenuItem124.HighLightForeColor = System.Drawing.SystemColors.HighlightText
        Me.MenuItem124.HighLightScheme = UltimateMenus.KunalMenuItem.HighLightColorDrawStyle.DefaultScheme
        Me.MenuItem124.HiliteGradientColor1 = System.Drawing.Color.WhiteSmoke
        Me.MenuItem124.HiliteGradientColor2 = System.Drawing.Color.CornflowerBlue
        Me.MenuItem124.HiLiteGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.MenuItem124.IconShadowColor = System.Drawing.Color.Gray
        Me.MenuItem124.ImageIndex = 0
        Me.MenuItem124.Index = 6
        Me.MenuItem124.MakeCheckedMenuItemIconTransparent = False
        Me.MenuItem124.MakeTransparentIcon = False
        Me.MenuItem124.MenuBarItemBorderColor = System.Drawing.Color.Black
        Me.MenuItem124.MenuBarItemFillColor = System.Drawing.SystemColors.Menu
        Me.MenuItem124.MenuBarItemFillingStyle = UltimateMenus.KunalMenuItem.MenuBarFillStyles.FillColor
        Me.MenuItem124.MenuBarItemGradientColor1 = System.Drawing.SystemColors.Menu
        Me.MenuItem124.MenuBarItemGradientColor2 = System.Drawing.SystemColors.Menu
        Me.MenuItem124.MenuBarItemGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.MenuItem124.OwnerDraw = True
        Me.MenuItem124.PreDefinedHiLiteColors = UltimateMenus.KunalMenuItem.PreDefinedHighLightColors.Khaki
        Me.MenuItem124.PreDefinedHiLiteGradientColors = UltimateMenus.KunalMenuItem.PreDefinedGrHighLightColors.BrownWhite
        Me.MenuItem124.PreDefinedSideBarGradientColour = UltimateMenus.KunalMenuItem.PreDefinedSideBarGradientColors.ShineyBlueYellow
        Me.MenuItem124.ShowBorderAroundMenuBar = False
        Me.MenuItem124.ShowHiliteOverSideBar = False
        Me.MenuItem124.ShowShadowUnderMenuBar = True
        Me.MenuItem124.SideBarGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.MenuItem124.SideBarStyle = UltimateMenus.KunalMenuItem.SideBarDrawStyle.DefaultGradient
        Me.MenuItem124.Text = "&Daily Recovery Loan"
        '
        'MenuItem144
        '
        Me.MenuItem144.CheckedImageIndex = 0
        Me.MenuItem144.CheckedMenuItemBackColor = System.Drawing.SystemColors.Control
        Me.MenuItem144.CheckedMenuItemBorderColor = System.Drawing.SystemColors.Control
        Me.MenuItem144.CheckedMenuItemDisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(197, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(184, Byte), Integer))
        Me.MenuItem144.CheckedMenuItemIconShadowColor = System.Drawing.Color.Gray
        Me.MenuItem144.CheckedMenuItemStyle = UltimateMenus.KunalMenuItem.CheckedMenuStyles.CheckedItemDefault
        Me.MenuItem144.CheckedMenuItemTickMarkColor = System.Drawing.SystemColors.Control
        Me.MenuItem144.FillMenuBarItem = False
        Me.MenuItem144.HighLightForeColor = System.Drawing.SystemColors.HighlightText
        Me.MenuItem144.HighLightScheme = UltimateMenus.KunalMenuItem.HighLightColorDrawStyle.DefaultScheme
        Me.MenuItem144.HiliteGradientColor1 = System.Drawing.Color.WhiteSmoke
        Me.MenuItem144.HiliteGradientColor2 = System.Drawing.Color.CornflowerBlue
        Me.MenuItem144.HiLiteGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.MenuItem144.IconShadowColor = System.Drawing.Color.Gray
        Me.MenuItem144.ImageIndex = 0
        Me.MenuItem144.Index = 7
        Me.MenuItem144.MakeCheckedMenuItemIconTransparent = False
        Me.MenuItem144.MakeTransparentIcon = False
        Me.MenuItem144.MenuBarItemBorderColor = System.Drawing.Color.Black
        Me.MenuItem144.MenuBarItemFillColor = System.Drawing.SystemColors.Menu
        Me.MenuItem144.MenuBarItemFillingStyle = UltimateMenus.KunalMenuItem.MenuBarFillStyles.FillColor
        Me.MenuItem144.MenuBarItemGradientColor1 = System.Drawing.SystemColors.Menu
        Me.MenuItem144.MenuBarItemGradientColor2 = System.Drawing.SystemColors.Menu
        Me.MenuItem144.MenuBarItemGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.MenuItem144.OwnerDraw = True
        Me.MenuItem144.PreDefinedHiLiteColors = UltimateMenus.KunalMenuItem.PreDefinedHighLightColors.Khaki
        Me.MenuItem144.PreDefinedHiLiteGradientColors = UltimateMenus.KunalMenuItem.PreDefinedGrHighLightColors.BrownWhite
        Me.MenuItem144.PreDefinedSideBarGradientColour = UltimateMenus.KunalMenuItem.PreDefinedSideBarGradientColors.ShineyBlueYellow
        Me.MenuItem144.ShowBorderAroundMenuBar = False
        Me.MenuItem144.ShowHiliteOverSideBar = False
        Me.MenuItem144.ShowShadowUnderMenuBar = True
        Me.MenuItem144.SideBarGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.MenuItem144.SideBarStyle = UltimateMenus.KunalMenuItem.SideBarDrawStyle.DefaultGradient
        Me.MenuItem144.Text = "Loan Monthly Interest"
        '
        'MenuItem99
        '
        Me.MenuItem99.CheckedImageIndex = 0
        Me.MenuItem99.CheckedMenuItemBackColor = System.Drawing.SystemColors.Control
        Me.MenuItem99.CheckedMenuItemBorderColor = System.Drawing.SystemColors.Control
        Me.MenuItem99.CheckedMenuItemDisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(197, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(184, Byte), Integer))
        Me.MenuItem99.CheckedMenuItemIconShadowColor = System.Drawing.Color.Gray
        Me.MenuItem99.CheckedMenuItemStyle = UltimateMenus.KunalMenuItem.CheckedMenuStyles.CheckedItemDefault
        Me.MenuItem99.CheckedMenuItemTickMarkColor = System.Drawing.SystemColors.Control
        Me.MenuItem99.FillMenuBarItem = False
        Me.MenuItem99.HighLightForeColor = System.Drawing.SystemColors.HighlightText
        Me.MenuItem99.HighLightScheme = UltimateMenus.KunalMenuItem.HighLightColorDrawStyle.DefaultScheme
        Me.MenuItem99.HiliteGradientColor1 = System.Drawing.Color.WhiteSmoke
        Me.MenuItem99.HiliteGradientColor2 = System.Drawing.Color.CornflowerBlue
        Me.MenuItem99.HiLiteGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.MenuItem99.IconShadowColor = System.Drawing.Color.Gray
        Me.MenuItem99.ImageIndex = 0
        Me.MenuItem99.Index = 8
        Me.MenuItem99.MakeCheckedMenuItemIconTransparent = False
        Me.MenuItem99.MakeTransparentIcon = False
        Me.MenuItem99.MenuBarItemBorderColor = System.Drawing.Color.Black
        Me.MenuItem99.MenuBarItemFillColor = System.Drawing.SystemColors.Menu
        Me.MenuItem99.MenuBarItemFillingStyle = UltimateMenus.KunalMenuItem.MenuBarFillStyles.FillColor
        Me.MenuItem99.MenuBarItemGradientColor1 = System.Drawing.SystemColors.Menu
        Me.MenuItem99.MenuBarItemGradientColor2 = System.Drawing.SystemColors.Menu
        Me.MenuItem99.MenuBarItemGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.MenuItem99.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem138, Me.MenuItem139, Me.MenuItem145})
        Me.MenuItem99.OwnerDraw = True
        Me.MenuItem99.PreDefinedHiLiteColors = UltimateMenus.KunalMenuItem.PreDefinedHighLightColors.Khaki
        Me.MenuItem99.PreDefinedHiLiteGradientColors = UltimateMenus.KunalMenuItem.PreDefinedGrHighLightColors.BrownWhite
        Me.MenuItem99.PreDefinedSideBarGradientColour = UltimateMenus.KunalMenuItem.PreDefinedSideBarGradientColors.ShineyBlueYellow
        Me.MenuItem99.ShowBorderAroundMenuBar = False
        Me.MenuItem99.ShowHiliteOverSideBar = False
        Me.MenuItem99.ShowShadowUnderMenuBar = True
        Me.MenuItem99.SideBarGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.MenuItem99.SideBarStyle = UltimateMenus.KunalMenuItem.SideBarDrawStyle.DefaultGradient
        Me.MenuItem99.Text = "&Over Draft"
        '
        'MenuItem138
        '
        Me.MenuItem138.CheckedImageIndex = 0
        Me.MenuItem138.CheckedMenuItemBackColor = System.Drawing.SystemColors.Control
        Me.MenuItem138.CheckedMenuItemBorderColor = System.Drawing.SystemColors.Control
        Me.MenuItem138.CheckedMenuItemDisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(197, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(184, Byte), Integer))
        Me.MenuItem138.CheckedMenuItemIconShadowColor = System.Drawing.Color.Gray
        Me.MenuItem138.CheckedMenuItemStyle = UltimateMenus.KunalMenuItem.CheckedMenuStyles.CheckedItemDefault
        Me.MenuItem138.CheckedMenuItemTickMarkColor = System.Drawing.SystemColors.Control
        Me.MenuItem138.FillMenuBarItem = False
        Me.MenuItem138.HighLightForeColor = System.Drawing.SystemColors.HighlightText
        Me.MenuItem138.HighLightScheme = UltimateMenus.KunalMenuItem.HighLightColorDrawStyle.DefaultScheme
        Me.MenuItem138.HiliteGradientColor1 = System.Drawing.Color.WhiteSmoke
        Me.MenuItem138.HiliteGradientColor2 = System.Drawing.Color.CornflowerBlue
        Me.MenuItem138.HiLiteGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.MenuItem138.IconShadowColor = System.Drawing.Color.Gray
        Me.MenuItem138.ImageIndex = 0
        Me.MenuItem138.Index = 0
        Me.MenuItem138.MakeCheckedMenuItemIconTransparent = False
        Me.MenuItem138.MakeTransparentIcon = False
        Me.MenuItem138.MenuBarItemBorderColor = System.Drawing.Color.Black
        Me.MenuItem138.MenuBarItemFillColor = System.Drawing.SystemColors.Menu
        Me.MenuItem138.MenuBarItemFillingStyle = UltimateMenus.KunalMenuItem.MenuBarFillStyles.FillColor
        Me.MenuItem138.MenuBarItemGradientColor1 = System.Drawing.SystemColors.Menu
        Me.MenuItem138.MenuBarItemGradientColor2 = System.Drawing.SystemColors.Menu
        Me.MenuItem138.MenuBarItemGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.MenuItem138.OwnerDraw = True
        Me.MenuItem138.PreDefinedHiLiteColors = UltimateMenus.KunalMenuItem.PreDefinedHighLightColors.Khaki
        Me.MenuItem138.PreDefinedHiLiteGradientColors = UltimateMenus.KunalMenuItem.PreDefinedGrHighLightColors.BrownWhite
        Me.MenuItem138.PreDefinedSideBarGradientColour = UltimateMenus.KunalMenuItem.PreDefinedSideBarGradientColors.ShineyBlueYellow
        Me.MenuItem138.ShowBorderAroundMenuBar = False
        Me.MenuItem138.ShowHiliteOverSideBar = False
        Me.MenuItem138.ShowShadowUnderMenuBar = True
        Me.MenuItem138.SideBarGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.MenuItem138.SideBarStyle = UltimateMenus.KunalMenuItem.SideBarDrawStyle.DefaultGradient
        Me.MenuItem138.Text = "New OD"
        '
        'MenuItem139
        '
        Me.MenuItem139.CheckedImageIndex = 0
        Me.MenuItem139.CheckedMenuItemBackColor = System.Drawing.SystemColors.Control
        Me.MenuItem139.CheckedMenuItemBorderColor = System.Drawing.SystemColors.Control
        Me.MenuItem139.CheckedMenuItemDisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(197, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(184, Byte), Integer))
        Me.MenuItem139.CheckedMenuItemIconShadowColor = System.Drawing.Color.Gray
        Me.MenuItem139.CheckedMenuItemStyle = UltimateMenus.KunalMenuItem.CheckedMenuStyles.CheckedItemDefault
        Me.MenuItem139.CheckedMenuItemTickMarkColor = System.Drawing.SystemColors.Control
        Me.MenuItem139.FillMenuBarItem = False
        Me.MenuItem139.HighLightForeColor = System.Drawing.SystemColors.HighlightText
        Me.MenuItem139.HighLightScheme = UltimateMenus.KunalMenuItem.HighLightColorDrawStyle.DefaultScheme
        Me.MenuItem139.HiliteGradientColor1 = System.Drawing.Color.WhiteSmoke
        Me.MenuItem139.HiliteGradientColor2 = System.Drawing.Color.CornflowerBlue
        Me.MenuItem139.HiLiteGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.MenuItem139.IconShadowColor = System.Drawing.Color.Gray
        Me.MenuItem139.ImageIndex = 0
        Me.MenuItem139.Index = 1
        Me.MenuItem139.MakeCheckedMenuItemIconTransparent = False
        Me.MenuItem139.MakeTransparentIcon = False
        Me.MenuItem139.MenuBarItemBorderColor = System.Drawing.Color.Black
        Me.MenuItem139.MenuBarItemFillColor = System.Drawing.SystemColors.Menu
        Me.MenuItem139.MenuBarItemFillingStyle = UltimateMenus.KunalMenuItem.MenuBarFillStyles.FillColor
        Me.MenuItem139.MenuBarItemGradientColor1 = System.Drawing.SystemColors.Menu
        Me.MenuItem139.MenuBarItemGradientColor2 = System.Drawing.SystemColors.Menu
        Me.MenuItem139.MenuBarItemGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.MenuItem139.OwnerDraw = True
        Me.MenuItem139.PreDefinedHiLiteColors = UltimateMenus.KunalMenuItem.PreDefinedHighLightColors.Khaki
        Me.MenuItem139.PreDefinedHiLiteGradientColors = UltimateMenus.KunalMenuItem.PreDefinedGrHighLightColors.BrownWhite
        Me.MenuItem139.PreDefinedSideBarGradientColour = UltimateMenus.KunalMenuItem.PreDefinedSideBarGradientColors.ShineyBlueYellow
        Me.MenuItem139.ShowBorderAroundMenuBar = False
        Me.MenuItem139.ShowHiliteOverSideBar = False
        Me.MenuItem139.ShowShadowUnderMenuBar = True
        Me.MenuItem139.SideBarGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.MenuItem139.SideBarStyle = UltimateMenus.KunalMenuItem.SideBarDrawStyle.DefaultGradient
        Me.MenuItem139.Text = "OD List"
        '
        'MenuItem145
        '
        Me.MenuItem145.CheckedImageIndex = 0
        Me.MenuItem145.CheckedMenuItemBackColor = System.Drawing.SystemColors.Control
        Me.MenuItem145.CheckedMenuItemBorderColor = System.Drawing.SystemColors.Control
        Me.MenuItem145.CheckedMenuItemDisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(197, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(184, Byte), Integer))
        Me.MenuItem145.CheckedMenuItemIconShadowColor = System.Drawing.Color.Gray
        Me.MenuItem145.CheckedMenuItemStyle = UltimateMenus.KunalMenuItem.CheckedMenuStyles.CheckedItemDefault
        Me.MenuItem145.CheckedMenuItemTickMarkColor = System.Drawing.SystemColors.Control
        Me.MenuItem145.FillMenuBarItem = False
        Me.MenuItem145.HighLightForeColor = System.Drawing.SystemColors.HighlightText
        Me.MenuItem145.HighLightScheme = UltimateMenus.KunalMenuItem.HighLightColorDrawStyle.DefaultScheme
        Me.MenuItem145.HiliteGradientColor1 = System.Drawing.Color.WhiteSmoke
        Me.MenuItem145.HiliteGradientColor2 = System.Drawing.Color.CornflowerBlue
        Me.MenuItem145.HiLiteGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.MenuItem145.IconShadowColor = System.Drawing.Color.Gray
        Me.MenuItem145.ImageIndex = 0
        Me.MenuItem145.Index = 2
        Me.MenuItem145.MakeCheckedMenuItemIconTransparent = False
        Me.MenuItem145.MakeTransparentIcon = False
        Me.MenuItem145.MenuBarItemBorderColor = System.Drawing.Color.Black
        Me.MenuItem145.MenuBarItemFillColor = System.Drawing.SystemColors.Menu
        Me.MenuItem145.MenuBarItemFillingStyle = UltimateMenus.KunalMenuItem.MenuBarFillStyles.FillColor
        Me.MenuItem145.MenuBarItemGradientColor1 = System.Drawing.SystemColors.Menu
        Me.MenuItem145.MenuBarItemGradientColor2 = System.Drawing.SystemColors.Menu
        Me.MenuItem145.MenuBarItemGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.MenuItem145.OwnerDraw = True
        Me.MenuItem145.PreDefinedHiLiteColors = UltimateMenus.KunalMenuItem.PreDefinedHighLightColors.Khaki
        Me.MenuItem145.PreDefinedHiLiteGradientColors = UltimateMenus.KunalMenuItem.PreDefinedGrHighLightColors.BrownWhite
        Me.MenuItem145.PreDefinedSideBarGradientColour = UltimateMenus.KunalMenuItem.PreDefinedSideBarGradientColors.ShineyBlueYellow
        Me.MenuItem145.ShowBorderAroundMenuBar = False
        Me.MenuItem145.ShowHiliteOverSideBar = False
        Me.MenuItem145.ShowShadowUnderMenuBar = True
        Me.MenuItem145.SideBarGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.MenuItem145.SideBarStyle = UltimateMenus.KunalMenuItem.SideBarDrawStyle.DefaultGradient
        Me.MenuItem145.Text = "OD Interest"
        '
        'smnuDefaulters
        '
        Me.smnuDefaulters.CheckedImageIndex = 0
        Me.smnuDefaulters.CheckedMenuItemBackColor = System.Drawing.SystemColors.Control
        Me.smnuDefaulters.CheckedMenuItemBorderColor = System.Drawing.SystemColors.Control
        Me.smnuDefaulters.CheckedMenuItemDisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(197, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(184, Byte), Integer))
        Me.smnuDefaulters.CheckedMenuItemIconShadowColor = System.Drawing.Color.Gray
        Me.smnuDefaulters.CheckedMenuItemStyle = UltimateMenus.KunalMenuItem.CheckedMenuStyles.CheckedItemDefault
        Me.smnuDefaulters.CheckedMenuItemTickMarkColor = System.Drawing.SystemColors.Control
        Me.smnuDefaulters.FillMenuBarItem = False
        Me.smnuDefaulters.HighLightForeColor = System.Drawing.SystemColors.HighlightText
        Me.smnuDefaulters.HighLightScheme = UltimateMenus.KunalMenuItem.HighLightColorDrawStyle.DefaultScheme
        Me.smnuDefaulters.HiliteGradientColor1 = System.Drawing.Color.WhiteSmoke
        Me.smnuDefaulters.HiliteGradientColor2 = System.Drawing.Color.CornflowerBlue
        Me.smnuDefaulters.HiLiteGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.smnuDefaulters.IconShadowColor = System.Drawing.Color.Gray
        Me.smnuDefaulters.ImageIndex = 0
        Me.smnuDefaulters.Index = 9
        Me.smnuDefaulters.MakeCheckedMenuItemIconTransparent = False
        Me.smnuDefaulters.MakeTransparentIcon = False
        Me.smnuDefaulters.MenuBarItemBorderColor = System.Drawing.Color.Black
        Me.smnuDefaulters.MenuBarItemFillColor = System.Drawing.SystemColors.Menu
        Me.smnuDefaulters.MenuBarItemFillingStyle = UltimateMenus.KunalMenuItem.MenuBarFillStyles.FillColor
        Me.smnuDefaulters.MenuBarItemGradientColor1 = System.Drawing.SystemColors.Menu
        Me.smnuDefaulters.MenuBarItemGradientColor2 = System.Drawing.SystemColors.Menu
        Me.smnuDefaulters.MenuBarItemGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.smnuDefaulters.OwnerDraw = True
        Me.smnuDefaulters.PreDefinedHiLiteColors = UltimateMenus.KunalMenuItem.PreDefinedHighLightColors.Khaki
        Me.smnuDefaulters.PreDefinedHiLiteGradientColors = UltimateMenus.KunalMenuItem.PreDefinedGrHighLightColors.BrownWhite
        Me.smnuDefaulters.PreDefinedSideBarGradientColour = UltimateMenus.KunalMenuItem.PreDefinedSideBarGradientColors.ShineyBlueYellow
        Me.smnuDefaulters.ShowBorderAroundMenuBar = False
        Me.smnuDefaulters.ShowHiliteOverSideBar = False
        Me.smnuDefaulters.ShowShadowUnderMenuBar = True
        Me.smnuDefaulters.SideBarGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.smnuDefaulters.SideBarStyle = UltimateMenus.KunalMenuItem.SideBarDrawStyle.DefaultGradient
        Me.smnuDefaulters.Text = "Defaulters &List"
        Me.smnuDefaulters.Visible = False
        '
        'mnuSMTL
        '
        Me.mnuSMTL.CheckedImageIndex = 0
        Me.mnuSMTL.CheckedMenuItemBackColor = System.Drawing.SystemColors.Control
        Me.mnuSMTL.CheckedMenuItemBorderColor = System.Drawing.SystemColors.Control
        Me.mnuSMTL.CheckedMenuItemDisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(197, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(184, Byte), Integer))
        Me.mnuSMTL.CheckedMenuItemIconShadowColor = System.Drawing.Color.Gray
        Me.mnuSMTL.CheckedMenuItemStyle = UltimateMenus.KunalMenuItem.CheckedMenuStyles.CheckedItemDefault
        Me.mnuSMTL.CheckedMenuItemTickMarkColor = System.Drawing.SystemColors.Control
        Me.mnuSMTL.FillMenuBarItem = False
        Me.mnuSMTL.HighLightForeColor = System.Drawing.SystemColors.HighlightText
        Me.mnuSMTL.HighLightScheme = UltimateMenus.KunalMenuItem.HighLightColorDrawStyle.DefaultScheme
        Me.mnuSMTL.HiliteGradientColor1 = System.Drawing.Color.WhiteSmoke
        Me.mnuSMTL.HiliteGradientColor2 = System.Drawing.Color.CornflowerBlue
        Me.mnuSMTL.HiLiteGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.mnuSMTL.IconShadowColor = System.Drawing.Color.Gray
        Me.mnuSMTL.ImageIndex = 0
        Me.mnuSMTL.Index = 10
        Me.mnuSMTL.MakeCheckedMenuItemIconTransparent = False
        Me.mnuSMTL.MakeTransparentIcon = False
        Me.mnuSMTL.MenuBarItemBorderColor = System.Drawing.Color.Black
        Me.mnuSMTL.MenuBarItemFillColor = System.Drawing.SystemColors.Menu
        Me.mnuSMTL.MenuBarItemFillingStyle = UltimateMenus.KunalMenuItem.MenuBarFillStyles.FillColor
        Me.mnuSMTL.MenuBarItemGradientColor1 = System.Drawing.SystemColors.Menu
        Me.mnuSMTL.MenuBarItemGradientColor2 = System.Drawing.SystemColors.Menu
        Me.mnuSMTL.MenuBarItemGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.mnuSMTL.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem164, Me.MenuItem165, Me.MenuItem166})
        Me.mnuSMTL.OwnerDraw = True
        Me.mnuSMTL.PreDefinedHiLiteColors = UltimateMenus.KunalMenuItem.PreDefinedHighLightColors.Khaki
        Me.mnuSMTL.PreDefinedHiLiteGradientColors = UltimateMenus.KunalMenuItem.PreDefinedGrHighLightColors.BrownWhite
        Me.mnuSMTL.PreDefinedSideBarGradientColour = UltimateMenus.KunalMenuItem.PreDefinedSideBarGradientColors.ShineyBlueYellow
        Me.mnuSMTL.ShowBorderAroundMenuBar = False
        Me.mnuSMTL.ShowHiliteOverSideBar = False
        Me.mnuSMTL.ShowShadowUnderMenuBar = True
        Me.mnuSMTL.SideBarGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.mnuSMTL.SideBarStyle = UltimateMenus.KunalMenuItem.SideBarDrawStyle.DefaultGradient
        Me.mnuSMTL.Text = "S&MTL"
        '
        'MenuItem164
        '
        Me.MenuItem164.CheckedImageIndex = 0
        Me.MenuItem164.CheckedMenuItemBackColor = System.Drawing.SystemColors.Control
        Me.MenuItem164.CheckedMenuItemBorderColor = System.Drawing.SystemColors.Control
        Me.MenuItem164.CheckedMenuItemDisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(197, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(184, Byte), Integer))
        Me.MenuItem164.CheckedMenuItemIconShadowColor = System.Drawing.Color.Gray
        Me.MenuItem164.CheckedMenuItemStyle = UltimateMenus.KunalMenuItem.CheckedMenuStyles.CheckedItemDefault
        Me.MenuItem164.CheckedMenuItemTickMarkColor = System.Drawing.SystemColors.Control
        Me.MenuItem164.FillMenuBarItem = False
        Me.MenuItem164.HighLightForeColor = System.Drawing.SystemColors.HighlightText
        Me.MenuItem164.HighLightScheme = UltimateMenus.KunalMenuItem.HighLightColorDrawStyle.DefaultScheme
        Me.MenuItem164.HiliteGradientColor1 = System.Drawing.Color.WhiteSmoke
        Me.MenuItem164.HiliteGradientColor2 = System.Drawing.Color.CornflowerBlue
        Me.MenuItem164.HiLiteGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.MenuItem164.IconShadowColor = System.Drawing.Color.Gray
        Me.MenuItem164.ImageIndex = 0
        Me.MenuItem164.Index = 0
        Me.MenuItem164.MakeCheckedMenuItemIconTransparent = False
        Me.MenuItem164.MakeTransparentIcon = False
        Me.MenuItem164.MenuBarItemBorderColor = System.Drawing.Color.Black
        Me.MenuItem164.MenuBarItemFillColor = System.Drawing.SystemColors.Menu
        Me.MenuItem164.MenuBarItemFillingStyle = UltimateMenus.KunalMenuItem.MenuBarFillStyles.FillColor
        Me.MenuItem164.MenuBarItemGradientColor1 = System.Drawing.SystemColors.Menu
        Me.MenuItem164.MenuBarItemGradientColor2 = System.Drawing.SystemColors.Menu
        Me.MenuItem164.MenuBarItemGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.MenuItem164.OwnerDraw = True
        Me.MenuItem164.PreDefinedHiLiteColors = UltimateMenus.KunalMenuItem.PreDefinedHighLightColors.Khaki
        Me.MenuItem164.PreDefinedHiLiteGradientColors = UltimateMenus.KunalMenuItem.PreDefinedGrHighLightColors.BrownWhite
        Me.MenuItem164.PreDefinedSideBarGradientColour = UltimateMenus.KunalMenuItem.PreDefinedSideBarGradientColors.ShineyBlueYellow
        Me.MenuItem164.ShowBorderAroundMenuBar = False
        Me.MenuItem164.ShowHiliteOverSideBar = False
        Me.MenuItem164.ShowShadowUnderMenuBar = True
        Me.MenuItem164.SideBarGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.MenuItem164.SideBarStyle = UltimateMenus.KunalMenuItem.SideBarDrawStyle.DefaultGradient
        Me.MenuItem164.Text = "New SMTL"
        '
        'MenuItem165
        '
        Me.MenuItem165.CheckedImageIndex = 0
        Me.MenuItem165.CheckedMenuItemBackColor = System.Drawing.SystemColors.Control
        Me.MenuItem165.CheckedMenuItemBorderColor = System.Drawing.SystemColors.Control
        Me.MenuItem165.CheckedMenuItemDisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(197, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(184, Byte), Integer))
        Me.MenuItem165.CheckedMenuItemIconShadowColor = System.Drawing.Color.Gray
        Me.MenuItem165.CheckedMenuItemStyle = UltimateMenus.KunalMenuItem.CheckedMenuStyles.CheckedItemDefault
        Me.MenuItem165.CheckedMenuItemTickMarkColor = System.Drawing.SystemColors.Control
        Me.MenuItem165.FillMenuBarItem = False
        Me.MenuItem165.HighLightForeColor = System.Drawing.SystemColors.HighlightText
        Me.MenuItem165.HighLightScheme = UltimateMenus.KunalMenuItem.HighLightColorDrawStyle.DefaultScheme
        Me.MenuItem165.HiliteGradientColor1 = System.Drawing.Color.WhiteSmoke
        Me.MenuItem165.HiliteGradientColor2 = System.Drawing.Color.CornflowerBlue
        Me.MenuItem165.HiLiteGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.MenuItem165.IconShadowColor = System.Drawing.Color.Gray
        Me.MenuItem165.ImageIndex = 0
        Me.MenuItem165.Index = 1
        Me.MenuItem165.MakeCheckedMenuItemIconTransparent = False
        Me.MenuItem165.MakeTransparentIcon = False
        Me.MenuItem165.MenuBarItemBorderColor = System.Drawing.Color.Black
        Me.MenuItem165.MenuBarItemFillColor = System.Drawing.SystemColors.Menu
        Me.MenuItem165.MenuBarItemFillingStyle = UltimateMenus.KunalMenuItem.MenuBarFillStyles.FillColor
        Me.MenuItem165.MenuBarItemGradientColor1 = System.Drawing.SystemColors.Menu
        Me.MenuItem165.MenuBarItemGradientColor2 = System.Drawing.SystemColors.Menu
        Me.MenuItem165.MenuBarItemGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.MenuItem165.OwnerDraw = True
        Me.MenuItem165.PreDefinedHiLiteColors = UltimateMenus.KunalMenuItem.PreDefinedHighLightColors.Khaki
        Me.MenuItem165.PreDefinedHiLiteGradientColors = UltimateMenus.KunalMenuItem.PreDefinedGrHighLightColors.BrownWhite
        Me.MenuItem165.PreDefinedSideBarGradientColour = UltimateMenus.KunalMenuItem.PreDefinedSideBarGradientColors.ShineyBlueYellow
        Me.MenuItem165.ShowBorderAroundMenuBar = False
        Me.MenuItem165.ShowHiliteOverSideBar = False
        Me.MenuItem165.ShowShadowUnderMenuBar = True
        Me.MenuItem165.SideBarGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.MenuItem165.SideBarStyle = UltimateMenus.KunalMenuItem.SideBarDrawStyle.DefaultGradient
        Me.MenuItem165.Text = "SMTL List"
        '
        'MenuItem166
        '
        Me.MenuItem166.CheckedImageIndex = 0
        Me.MenuItem166.CheckedMenuItemBackColor = System.Drawing.SystemColors.Control
        Me.MenuItem166.CheckedMenuItemBorderColor = System.Drawing.SystemColors.Control
        Me.MenuItem166.CheckedMenuItemDisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(197, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(184, Byte), Integer))
        Me.MenuItem166.CheckedMenuItemIconShadowColor = System.Drawing.Color.Gray
        Me.MenuItem166.CheckedMenuItemStyle = UltimateMenus.KunalMenuItem.CheckedMenuStyles.CheckedItemDefault
        Me.MenuItem166.CheckedMenuItemTickMarkColor = System.Drawing.SystemColors.Control
        Me.MenuItem166.FillMenuBarItem = False
        Me.MenuItem166.HighLightForeColor = System.Drawing.SystemColors.HighlightText
        Me.MenuItem166.HighLightScheme = UltimateMenus.KunalMenuItem.HighLightColorDrawStyle.DefaultScheme
        Me.MenuItem166.HiliteGradientColor1 = System.Drawing.Color.WhiteSmoke
        Me.MenuItem166.HiliteGradientColor2 = System.Drawing.Color.CornflowerBlue
        Me.MenuItem166.HiLiteGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.MenuItem166.IconShadowColor = System.Drawing.Color.Gray
        Me.MenuItem166.ImageIndex = 0
        Me.MenuItem166.Index = 2
        Me.MenuItem166.MakeCheckedMenuItemIconTransparent = False
        Me.MenuItem166.MakeTransparentIcon = False
        Me.MenuItem166.MenuBarItemBorderColor = System.Drawing.Color.Black
        Me.MenuItem166.MenuBarItemFillColor = System.Drawing.SystemColors.Menu
        Me.MenuItem166.MenuBarItemFillingStyle = UltimateMenus.KunalMenuItem.MenuBarFillStyles.FillColor
        Me.MenuItem166.MenuBarItemGradientColor1 = System.Drawing.SystemColors.Menu
        Me.MenuItem166.MenuBarItemGradientColor2 = System.Drawing.SystemColors.Menu
        Me.MenuItem166.MenuBarItemGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.MenuItem166.OwnerDraw = True
        Me.MenuItem166.PreDefinedHiLiteColors = UltimateMenus.KunalMenuItem.PreDefinedHighLightColors.Khaki
        Me.MenuItem166.PreDefinedHiLiteGradientColors = UltimateMenus.KunalMenuItem.PreDefinedGrHighLightColors.BrownWhite
        Me.MenuItem166.PreDefinedSideBarGradientColour = UltimateMenus.KunalMenuItem.PreDefinedSideBarGradientColors.ShineyBlueYellow
        Me.MenuItem166.ShowBorderAroundMenuBar = False
        Me.MenuItem166.ShowHiliteOverSideBar = False
        Me.MenuItem166.ShowShadowUnderMenuBar = True
        Me.MenuItem166.SideBarGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.MenuItem166.SideBarStyle = UltimateMenus.KunalMenuItem.SideBarDrawStyle.DefaultGradient
        Me.MenuItem166.Text = "SMTL Interest"
        '
        'MenuItem128
        '
        Me.MenuItem128.CheckedImageIndex = 0
        Me.MenuItem128.CheckedMenuItemBackColor = System.Drawing.SystemColors.Control
        Me.MenuItem128.CheckedMenuItemBorderColor = System.Drawing.SystemColors.Control
        Me.MenuItem128.CheckedMenuItemDisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(197, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(184, Byte), Integer))
        Me.MenuItem128.CheckedMenuItemIconShadowColor = System.Drawing.Color.Gray
        Me.MenuItem128.CheckedMenuItemStyle = UltimateMenus.KunalMenuItem.CheckedMenuStyles.CheckedItemDefault
        Me.MenuItem128.CheckedMenuItemTickMarkColor = System.Drawing.SystemColors.Control
        Me.MenuItem128.FillMenuBarItem = False
        Me.MenuItem128.HighLightForeColor = System.Drawing.SystemColors.HighlightText
        Me.MenuItem128.HighLightScheme = UltimateMenus.KunalMenuItem.HighLightColorDrawStyle.DefaultScheme
        Me.MenuItem128.HiliteGradientColor1 = System.Drawing.Color.WhiteSmoke
        Me.MenuItem128.HiliteGradientColor2 = System.Drawing.Color.CornflowerBlue
        Me.MenuItem128.HiLiteGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.MenuItem128.IconShadowColor = System.Drawing.Color.Gray
        Me.MenuItem128.ImageIndex = 0
        Me.MenuItem128.Index = 7
        Me.MenuItem128.MakeCheckedMenuItemIconTransparent = False
        Me.MenuItem128.MakeTransparentIcon = False
        Me.MenuItem128.MenuBarItemBorderColor = System.Drawing.Color.Black
        Me.MenuItem128.MenuBarItemFillColor = System.Drawing.SystemColors.Menu
        Me.MenuItem128.MenuBarItemFillingStyle = UltimateMenus.KunalMenuItem.MenuBarFillStyles.FillColor
        Me.MenuItem128.MenuBarItemGradientColor1 = System.Drawing.SystemColors.Menu
        Me.MenuItem128.MenuBarItemGradientColor2 = System.Drawing.SystemColors.Menu
        Me.MenuItem128.MenuBarItemGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.MenuItem128.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem129, Me.MenuItem130, Me.MenuItem131, Me.MenuItem163})
        Me.MenuItem128.OwnerDraw = True
        Me.MenuItem128.PreDefinedHiLiteColors = UltimateMenus.KunalMenuItem.PreDefinedHighLightColors.Khaki
        Me.MenuItem128.PreDefinedHiLiteGradientColors = UltimateMenus.KunalMenuItem.PreDefinedGrHighLightColors.BrownWhite
        Me.MenuItem128.PreDefinedSideBarGradientColour = UltimateMenus.KunalMenuItem.PreDefinedSideBarGradientColors.ShineyBlueYellow
        Me.MenuItem128.ShowBorderAroundMenuBar = False
        Me.MenuItem128.ShowHiliteOverSideBar = False
        Me.MenuItem128.ShowShadowUnderMenuBar = True
        Me.MenuItem128.SideBarGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.MenuItem128.SideBarStyle = UltimateMenus.KunalMenuItem.SideBarDrawStyle.DefaultGradient
        Me.MenuItem128.Text = "Clearing Bill Purchase"
        '
        'MenuItem129
        '
        Me.MenuItem129.CheckedImageIndex = 0
        Me.MenuItem129.CheckedMenuItemBackColor = System.Drawing.SystemColors.Control
        Me.MenuItem129.CheckedMenuItemBorderColor = System.Drawing.SystemColors.Control
        Me.MenuItem129.CheckedMenuItemDisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(197, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(184, Byte), Integer))
        Me.MenuItem129.CheckedMenuItemIconShadowColor = System.Drawing.Color.Gray
        Me.MenuItem129.CheckedMenuItemStyle = UltimateMenus.KunalMenuItem.CheckedMenuStyles.CheckedItemDefault
        Me.MenuItem129.CheckedMenuItemTickMarkColor = System.Drawing.SystemColors.Control
        Me.MenuItem129.FillMenuBarItem = False
        Me.MenuItem129.HighLightForeColor = System.Drawing.SystemColors.HighlightText
        Me.MenuItem129.HighLightScheme = UltimateMenus.KunalMenuItem.HighLightColorDrawStyle.DefaultScheme
        Me.MenuItem129.HiliteGradientColor1 = System.Drawing.Color.WhiteSmoke
        Me.MenuItem129.HiliteGradientColor2 = System.Drawing.Color.CornflowerBlue
        Me.MenuItem129.HiLiteGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.MenuItem129.IconShadowColor = System.Drawing.Color.Gray
        Me.MenuItem129.ImageIndex = 0
        Me.MenuItem129.Index = 0
        Me.MenuItem129.MakeCheckedMenuItemIconTransparent = False
        Me.MenuItem129.MakeTransparentIcon = False
        Me.MenuItem129.MenuBarItemBorderColor = System.Drawing.Color.Black
        Me.MenuItem129.MenuBarItemFillColor = System.Drawing.SystemColors.Menu
        Me.MenuItem129.MenuBarItemFillingStyle = UltimateMenus.KunalMenuItem.MenuBarFillStyles.FillColor
        Me.MenuItem129.MenuBarItemGradientColor1 = System.Drawing.SystemColors.Menu
        Me.MenuItem129.MenuBarItemGradientColor2 = System.Drawing.SystemColors.Menu
        Me.MenuItem129.MenuBarItemGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.MenuItem129.OwnerDraw = True
        Me.MenuItem129.PreDefinedHiLiteColors = UltimateMenus.KunalMenuItem.PreDefinedHighLightColors.Khaki
        Me.MenuItem129.PreDefinedHiLiteGradientColors = UltimateMenus.KunalMenuItem.PreDefinedGrHighLightColors.BrownWhite
        Me.MenuItem129.PreDefinedSideBarGradientColour = UltimateMenus.KunalMenuItem.PreDefinedSideBarGradientColors.ShineyBlueYellow
        Me.MenuItem129.ShowBorderAroundMenuBar = False
        Me.MenuItem129.ShowHiliteOverSideBar = False
        Me.MenuItem129.ShowShadowUnderMenuBar = True
        Me.MenuItem129.SideBarGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.MenuItem129.SideBarStyle = UltimateMenus.KunalMenuItem.SideBarDrawStyle.DefaultGradient
        Me.MenuItem129.Text = "New CBP"
        '
        'MenuItem130
        '
        Me.MenuItem130.CheckedImageIndex = 0
        Me.MenuItem130.CheckedMenuItemBackColor = System.Drawing.SystemColors.Control
        Me.MenuItem130.CheckedMenuItemBorderColor = System.Drawing.SystemColors.Control
        Me.MenuItem130.CheckedMenuItemDisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(197, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(184, Byte), Integer))
        Me.MenuItem130.CheckedMenuItemIconShadowColor = System.Drawing.Color.Gray
        Me.MenuItem130.CheckedMenuItemStyle = UltimateMenus.KunalMenuItem.CheckedMenuStyles.CheckedItemDefault
        Me.MenuItem130.CheckedMenuItemTickMarkColor = System.Drawing.SystemColors.Control
        Me.MenuItem130.FillMenuBarItem = False
        Me.MenuItem130.HighLightForeColor = System.Drawing.SystemColors.HighlightText
        Me.MenuItem130.HighLightScheme = UltimateMenus.KunalMenuItem.HighLightColorDrawStyle.DefaultScheme
        Me.MenuItem130.HiliteGradientColor1 = System.Drawing.Color.WhiteSmoke
        Me.MenuItem130.HiliteGradientColor2 = System.Drawing.Color.CornflowerBlue
        Me.MenuItem130.HiLiteGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.MenuItem130.IconShadowColor = System.Drawing.Color.Gray
        Me.MenuItem130.ImageIndex = 0
        Me.MenuItem130.Index = 1
        Me.MenuItem130.MakeCheckedMenuItemIconTransparent = False
        Me.MenuItem130.MakeTransparentIcon = False
        Me.MenuItem130.MenuBarItemBorderColor = System.Drawing.Color.Black
        Me.MenuItem130.MenuBarItemFillColor = System.Drawing.SystemColors.Menu
        Me.MenuItem130.MenuBarItemFillingStyle = UltimateMenus.KunalMenuItem.MenuBarFillStyles.FillColor
        Me.MenuItem130.MenuBarItemGradientColor1 = System.Drawing.SystemColors.Menu
        Me.MenuItem130.MenuBarItemGradientColor2 = System.Drawing.SystemColors.Menu
        Me.MenuItem130.MenuBarItemGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.MenuItem130.OwnerDraw = True
        Me.MenuItem130.PreDefinedHiLiteColors = UltimateMenus.KunalMenuItem.PreDefinedHighLightColors.Khaki
        Me.MenuItem130.PreDefinedHiLiteGradientColors = UltimateMenus.KunalMenuItem.PreDefinedGrHighLightColors.BrownWhite
        Me.MenuItem130.PreDefinedSideBarGradientColour = UltimateMenus.KunalMenuItem.PreDefinedSideBarGradientColors.ShineyBlueYellow
        Me.MenuItem130.ShowBorderAroundMenuBar = False
        Me.MenuItem130.ShowHiliteOverSideBar = False
        Me.MenuItem130.ShowShadowUnderMenuBar = True
        Me.MenuItem130.SideBarGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.MenuItem130.SideBarStyle = UltimateMenus.KunalMenuItem.SideBarDrawStyle.DefaultGradient
        Me.MenuItem130.Text = "View CBP List"
        '
        'MenuItem131
        '
        Me.MenuItem131.CheckedImageIndex = 0
        Me.MenuItem131.CheckedMenuItemBackColor = System.Drawing.SystemColors.Control
        Me.MenuItem131.CheckedMenuItemBorderColor = System.Drawing.SystemColors.Control
        Me.MenuItem131.CheckedMenuItemDisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(197, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(184, Byte), Integer))
        Me.MenuItem131.CheckedMenuItemIconShadowColor = System.Drawing.Color.Gray
        Me.MenuItem131.CheckedMenuItemStyle = UltimateMenus.KunalMenuItem.CheckedMenuStyles.CheckedItemDefault
        Me.MenuItem131.CheckedMenuItemTickMarkColor = System.Drawing.SystemColors.Control
        Me.MenuItem131.FillMenuBarItem = False
        Me.MenuItem131.HighLightForeColor = System.Drawing.SystemColors.HighlightText
        Me.MenuItem131.HighLightScheme = UltimateMenus.KunalMenuItem.HighLightColorDrawStyle.DefaultScheme
        Me.MenuItem131.HiliteGradientColor1 = System.Drawing.Color.WhiteSmoke
        Me.MenuItem131.HiliteGradientColor2 = System.Drawing.Color.CornflowerBlue
        Me.MenuItem131.HiLiteGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.MenuItem131.IconShadowColor = System.Drawing.Color.Gray
        Me.MenuItem131.ImageIndex = 0
        Me.MenuItem131.Index = 2
        Me.MenuItem131.MakeCheckedMenuItemIconTransparent = False
        Me.MenuItem131.MakeTransparentIcon = False
        Me.MenuItem131.MenuBarItemBorderColor = System.Drawing.Color.Black
        Me.MenuItem131.MenuBarItemFillColor = System.Drawing.SystemColors.Menu
        Me.MenuItem131.MenuBarItemFillingStyle = UltimateMenus.KunalMenuItem.MenuBarFillStyles.FillColor
        Me.MenuItem131.MenuBarItemGradientColor1 = System.Drawing.SystemColors.Menu
        Me.MenuItem131.MenuBarItemGradientColor2 = System.Drawing.SystemColors.Menu
        Me.MenuItem131.MenuBarItemGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.MenuItem131.OwnerDraw = True
        Me.MenuItem131.PreDefinedHiLiteColors = UltimateMenus.KunalMenuItem.PreDefinedHighLightColors.Khaki
        Me.MenuItem131.PreDefinedHiLiteGradientColors = UltimateMenus.KunalMenuItem.PreDefinedGrHighLightColors.BrownWhite
        Me.MenuItem131.PreDefinedSideBarGradientColour = UltimateMenus.KunalMenuItem.PreDefinedSideBarGradientColors.ShineyBlueYellow
        Me.MenuItem131.ShowBorderAroundMenuBar = False
        Me.MenuItem131.ShowHiliteOverSideBar = False
        Me.MenuItem131.ShowShadowUnderMenuBar = True
        Me.MenuItem131.SideBarGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.MenuItem131.SideBarStyle = UltimateMenus.KunalMenuItem.SideBarDrawStyle.DefaultGradient
        Me.MenuItem131.Text = "CBP Transaction"
        '
        'MenuItem163
        '
        Me.MenuItem163.CheckedImageIndex = 0
        Me.MenuItem163.CheckedMenuItemBackColor = System.Drawing.SystemColors.Control
        Me.MenuItem163.CheckedMenuItemBorderColor = System.Drawing.SystemColors.Control
        Me.MenuItem163.CheckedMenuItemDisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(197, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(184, Byte), Integer))
        Me.MenuItem163.CheckedMenuItemIconShadowColor = System.Drawing.Color.Gray
        Me.MenuItem163.CheckedMenuItemStyle = UltimateMenus.KunalMenuItem.CheckedMenuStyles.CheckedItemDefault
        Me.MenuItem163.CheckedMenuItemTickMarkColor = System.Drawing.SystemColors.Control
        Me.MenuItem163.FillMenuBarItem = False
        Me.MenuItem163.HighLightForeColor = System.Drawing.SystemColors.HighlightText
        Me.MenuItem163.HighLightScheme = UltimateMenus.KunalMenuItem.HighLightColorDrawStyle.DefaultScheme
        Me.MenuItem163.HiliteGradientColor1 = System.Drawing.Color.WhiteSmoke
        Me.MenuItem163.HiliteGradientColor2 = System.Drawing.Color.CornflowerBlue
        Me.MenuItem163.HiLiteGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.MenuItem163.IconShadowColor = System.Drawing.Color.Gray
        Me.MenuItem163.ImageIndex = 0
        Me.MenuItem163.Index = 3
        Me.MenuItem163.MakeCheckedMenuItemIconTransparent = False
        Me.MenuItem163.MakeTransparentIcon = False
        Me.MenuItem163.MenuBarItemBorderColor = System.Drawing.Color.Black
        Me.MenuItem163.MenuBarItemFillColor = System.Drawing.SystemColors.Menu
        Me.MenuItem163.MenuBarItemFillingStyle = UltimateMenus.KunalMenuItem.MenuBarFillStyles.FillColor
        Me.MenuItem163.MenuBarItemGradientColor1 = System.Drawing.SystemColors.Menu
        Me.MenuItem163.MenuBarItemGradientColor2 = System.Drawing.SystemColors.Menu
        Me.MenuItem163.MenuBarItemGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.MenuItem163.OwnerDraw = True
        Me.MenuItem163.PreDefinedHiLiteColors = UltimateMenus.KunalMenuItem.PreDefinedHighLightColors.Khaki
        Me.MenuItem163.PreDefinedHiLiteGradientColors = UltimateMenus.KunalMenuItem.PreDefinedGrHighLightColors.BrownWhite
        Me.MenuItem163.PreDefinedSideBarGradientColour = UltimateMenus.KunalMenuItem.PreDefinedSideBarGradientColors.ShineyBlueYellow
        Me.MenuItem163.ShowBorderAroundMenuBar = False
        Me.MenuItem163.ShowHiliteOverSideBar = False
        Me.MenuItem163.ShowShadowUnderMenuBar = True
        Me.MenuItem163.SideBarGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.MenuItem163.SideBarStyle = UltimateMenus.KunalMenuItem.SideBarDrawStyle.DefaultGradient
        Me.MenuItem163.Text = "Pending Bills"
        '
        'MenuItem7
        '
        Me.MenuItem7.CheckedImageIndex = 0
        Me.MenuItem7.CheckedMenuItemBackColor = System.Drawing.SystemColors.Control
        Me.MenuItem7.CheckedMenuItemBorderColor = System.Drawing.SystemColors.Control
        Me.MenuItem7.CheckedMenuItemDisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(197, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(184, Byte), Integer))
        Me.MenuItem7.CheckedMenuItemIconShadowColor = System.Drawing.Color.Gray
        Me.MenuItem7.CheckedMenuItemStyle = UltimateMenus.KunalMenuItem.CheckedMenuStyles.CheckedItemDefault
        Me.MenuItem7.CheckedMenuItemTickMarkColor = System.Drawing.SystemColors.Control
        Me.MenuItem7.FillMenuBarItem = False
        Me.MenuItem7.HighLightForeColor = System.Drawing.SystemColors.HighlightText
        Me.MenuItem7.HighLightScheme = UltimateMenus.KunalMenuItem.HighLightColorDrawStyle.DefaultScheme
        Me.MenuItem7.HiliteGradientColor1 = System.Drawing.Color.WhiteSmoke
        Me.MenuItem7.HiliteGradientColor2 = System.Drawing.Color.CornflowerBlue
        Me.MenuItem7.HiLiteGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.MenuItem7.IconShadowColor = System.Drawing.Color.Gray
        Me.MenuItem7.ImageIndex = 0
        Me.MenuItem7.Index = 8
        Me.MenuItem7.MakeCheckedMenuItemIconTransparent = False
        Me.MenuItem7.MakeTransparentIcon = False
        Me.MenuItem7.MenuBarItemBorderColor = System.Drawing.Color.Black
        Me.MenuItem7.MenuBarItemFillColor = System.Drawing.SystemColors.Menu
        Me.MenuItem7.MenuBarItemFillingStyle = UltimateMenus.KunalMenuItem.MenuBarFillStyles.FillColor
        Me.MenuItem7.MenuBarItemGradientColor1 = System.Drawing.SystemColors.Menu
        Me.MenuItem7.MenuBarItemGradientColor2 = System.Drawing.SystemColors.Menu
        Me.MenuItem7.MenuBarItemGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.MenuItem7.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem51, Me.MenuItem53, Me.MenuItem50, Me.MenuItem75, Me.MenuItem87, Me.MenuItem140, Me.MenuItem57, Me.MenuItem59, Me.MenuItem60, Me.MenuItem61, Me.MenuItem93, Me.MenuItem52})
        Me.MenuItem7.OwnerDraw = True
        Me.MenuItem7.PreDefinedHiLiteColors = UltimateMenus.KunalMenuItem.PreDefinedHighLightColors.Khaki
        Me.MenuItem7.PreDefinedHiLiteGradientColors = UltimateMenus.KunalMenuItem.PreDefinedGrHighLightColors.BrownWhite
        Me.MenuItem7.PreDefinedSideBarGradientColour = UltimateMenus.KunalMenuItem.PreDefinedSideBarGradientColors.ShineyBlueYellow
        Me.MenuItem7.ShowBorderAroundMenuBar = False
        Me.MenuItem7.ShowHiliteOverSideBar = False
        Me.MenuItem7.ShowShadowUnderMenuBar = True
        Me.MenuItem7.SideBarGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.MenuItem7.SideBarStyle = UltimateMenus.KunalMenuItem.SideBarDrawStyle.DefaultGradient
        Me.MenuItem7.Text = "&Accounting"
        '
        'MenuItem51
        '
        Me.MenuItem51.CheckedImageIndex = 0
        Me.MenuItem51.CheckedMenuItemBackColor = System.Drawing.SystemColors.Control
        Me.MenuItem51.CheckedMenuItemBorderColor = System.Drawing.SystemColors.Control
        Me.MenuItem51.CheckedMenuItemDisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(197, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(184, Byte), Integer))
        Me.MenuItem51.CheckedMenuItemIconShadowColor = System.Drawing.Color.Gray
        Me.MenuItem51.CheckedMenuItemStyle = UltimateMenus.KunalMenuItem.CheckedMenuStyles.CheckedItemDefault
        Me.MenuItem51.CheckedMenuItemTickMarkColor = System.Drawing.SystemColors.Control
        Me.MenuItem51.FillMenuBarItem = False
        Me.MenuItem51.HighLightForeColor = System.Drawing.SystemColors.HighlightText
        Me.MenuItem51.HighLightScheme = UltimateMenus.KunalMenuItem.HighLightColorDrawStyle.DefaultScheme
        Me.MenuItem51.HiliteGradientColor1 = System.Drawing.Color.WhiteSmoke
        Me.MenuItem51.HiliteGradientColor2 = System.Drawing.Color.CornflowerBlue
        Me.MenuItem51.HiLiteGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.MenuItem51.IconShadowColor = System.Drawing.Color.Gray
        Me.MenuItem51.ImageIndex = 0
        Me.MenuItem51.Index = 0
        Me.MenuItem51.MakeCheckedMenuItemIconTransparent = False
        Me.MenuItem51.MakeTransparentIcon = False
        Me.MenuItem51.MenuBarItemBorderColor = System.Drawing.Color.Black
        Me.MenuItem51.MenuBarItemFillColor = System.Drawing.SystemColors.Menu
        Me.MenuItem51.MenuBarItemFillingStyle = UltimateMenus.KunalMenuItem.MenuBarFillStyles.FillColor
        Me.MenuItem51.MenuBarItemGradientColor1 = System.Drawing.SystemColors.Menu
        Me.MenuItem51.MenuBarItemGradientColor2 = System.Drawing.SystemColors.Menu
        Me.MenuItem51.MenuBarItemGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.MenuItem51.OwnerDraw = True
        Me.MenuItem51.PreDefinedHiLiteColors = UltimateMenus.KunalMenuItem.PreDefinedHighLightColors.Khaki
        Me.MenuItem51.PreDefinedHiLiteGradientColors = UltimateMenus.KunalMenuItem.PreDefinedGrHighLightColors.BrownWhite
        Me.MenuItem51.PreDefinedSideBarGradientColour = UltimateMenus.KunalMenuItem.PreDefinedSideBarGradientColors.ShineyBlueYellow
        Me.MenuItem51.ShowBorderAroundMenuBar = False
        Me.MenuItem51.ShowHiliteOverSideBar = False
        Me.MenuItem51.ShowShadowUnderMenuBar = True
        Me.MenuItem51.SideBarGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.MenuItem51.SideBarStyle = UltimateMenus.KunalMenuItem.SideBarDrawStyle.DefaultGradient
        Me.MenuItem51.Text = "&Groups"
        '
        'MenuItem53
        '
        Me.MenuItem53.CheckedImageIndex = 0
        Me.MenuItem53.CheckedMenuItemBackColor = System.Drawing.SystemColors.Control
        Me.MenuItem53.CheckedMenuItemBorderColor = System.Drawing.SystemColors.Control
        Me.MenuItem53.CheckedMenuItemDisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(197, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(184, Byte), Integer))
        Me.MenuItem53.CheckedMenuItemIconShadowColor = System.Drawing.Color.Gray
        Me.MenuItem53.CheckedMenuItemStyle = UltimateMenus.KunalMenuItem.CheckedMenuStyles.CheckedItemDefault
        Me.MenuItem53.CheckedMenuItemTickMarkColor = System.Drawing.SystemColors.Control
        Me.MenuItem53.FillMenuBarItem = False
        Me.MenuItem53.HighLightForeColor = System.Drawing.SystemColors.HighlightText
        Me.MenuItem53.HighLightScheme = UltimateMenus.KunalMenuItem.HighLightColorDrawStyle.DefaultScheme
        Me.MenuItem53.HiliteGradientColor1 = System.Drawing.Color.WhiteSmoke
        Me.MenuItem53.HiliteGradientColor2 = System.Drawing.Color.CornflowerBlue
        Me.MenuItem53.HiLiteGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.MenuItem53.IconShadowColor = System.Drawing.Color.Gray
        Me.MenuItem53.ImageIndex = 0
        Me.MenuItem53.Index = 1
        Me.MenuItem53.MakeCheckedMenuItemIconTransparent = False
        Me.MenuItem53.MakeTransparentIcon = False
        Me.MenuItem53.MenuBarItemBorderColor = System.Drawing.Color.Black
        Me.MenuItem53.MenuBarItemFillColor = System.Drawing.SystemColors.Menu
        Me.MenuItem53.MenuBarItemFillingStyle = UltimateMenus.KunalMenuItem.MenuBarFillStyles.FillColor
        Me.MenuItem53.MenuBarItemGradientColor1 = System.Drawing.SystemColors.Menu
        Me.MenuItem53.MenuBarItemGradientColor2 = System.Drawing.SystemColors.Menu
        Me.MenuItem53.MenuBarItemGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.MenuItem53.OwnerDraw = True
        Me.MenuItem53.PreDefinedHiLiteColors = UltimateMenus.KunalMenuItem.PreDefinedHighLightColors.Khaki
        Me.MenuItem53.PreDefinedHiLiteGradientColors = UltimateMenus.KunalMenuItem.PreDefinedGrHighLightColors.BrownWhite
        Me.MenuItem53.PreDefinedSideBarGradientColour = UltimateMenus.KunalMenuItem.PreDefinedSideBarGradientColors.ShineyBlueYellow
        Me.MenuItem53.ShowBorderAroundMenuBar = False
        Me.MenuItem53.ShowHiliteOverSideBar = False
        Me.MenuItem53.ShowShadowUnderMenuBar = True
        Me.MenuItem53.SideBarGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.MenuItem53.SideBarStyle = UltimateMenus.KunalMenuItem.SideBarDrawStyle.DefaultGradient
        Me.MenuItem53.Text = "&Ledgers"
        '
        'MenuItem50
        '
        Me.MenuItem50.CheckedImageIndex = 0
        Me.MenuItem50.CheckedMenuItemBackColor = System.Drawing.SystemColors.Control
        Me.MenuItem50.CheckedMenuItemBorderColor = System.Drawing.SystemColors.Control
        Me.MenuItem50.CheckedMenuItemDisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(197, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(184, Byte), Integer))
        Me.MenuItem50.CheckedMenuItemIconShadowColor = System.Drawing.Color.Gray
        Me.MenuItem50.CheckedMenuItemStyle = UltimateMenus.KunalMenuItem.CheckedMenuStyles.CheckedItemDefault
        Me.MenuItem50.CheckedMenuItemTickMarkColor = System.Drawing.SystemColors.Control
        Me.MenuItem50.FillMenuBarItem = False
        Me.MenuItem50.HighLightForeColor = System.Drawing.SystemColors.HighlightText
        Me.MenuItem50.HighLightScheme = UltimateMenus.KunalMenuItem.HighLightColorDrawStyle.DefaultScheme
        Me.MenuItem50.HiliteGradientColor1 = System.Drawing.Color.WhiteSmoke
        Me.MenuItem50.HiliteGradientColor2 = System.Drawing.Color.CornflowerBlue
        Me.MenuItem50.HiLiteGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.MenuItem50.IconShadowColor = System.Drawing.Color.Gray
        Me.MenuItem50.ImageIndex = 0
        Me.MenuItem50.Index = 2
        Me.MenuItem50.MakeCheckedMenuItemIconTransparent = False
        Me.MenuItem50.MakeTransparentIcon = False
        Me.MenuItem50.MenuBarItemBorderColor = System.Drawing.Color.Black
        Me.MenuItem50.MenuBarItemFillColor = System.Drawing.SystemColors.Menu
        Me.MenuItem50.MenuBarItemFillingStyle = UltimateMenus.KunalMenuItem.MenuBarFillStyles.FillColor
        Me.MenuItem50.MenuBarItemGradientColor1 = System.Drawing.SystemColors.Menu
        Me.MenuItem50.MenuBarItemGradientColor2 = System.Drawing.SystemColors.Menu
        Me.MenuItem50.MenuBarItemGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.MenuItem50.OwnerDraw = True
        Me.MenuItem50.PreDefinedHiLiteColors = UltimateMenus.KunalMenuItem.PreDefinedHighLightColors.Khaki
        Me.MenuItem50.PreDefinedHiLiteGradientColors = UltimateMenus.KunalMenuItem.PreDefinedGrHighLightColors.BrownWhite
        Me.MenuItem50.PreDefinedSideBarGradientColour = UltimateMenus.KunalMenuItem.PreDefinedSideBarGradientColors.ShineyBlueYellow
        Me.MenuItem50.ShowBorderAroundMenuBar = False
        Me.MenuItem50.ShowHiliteOverSideBar = False
        Me.MenuItem50.ShowShadowUnderMenuBar = True
        Me.MenuItem50.SideBarGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.MenuItem50.SideBarStyle = UltimateMenus.KunalMenuItem.SideBarDrawStyle.DefaultGradient
        Me.MenuItem50.Text = "Voucher T&ypes"
        Me.MenuItem50.Visible = False
        '
        'MenuItem75
        '
        Me.MenuItem75.CheckedImageIndex = 0
        Me.MenuItem75.CheckedMenuItemBackColor = System.Drawing.SystemColors.Control
        Me.MenuItem75.CheckedMenuItemBorderColor = System.Drawing.SystemColors.Control
        Me.MenuItem75.CheckedMenuItemDisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(197, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(184, Byte), Integer))
        Me.MenuItem75.CheckedMenuItemIconShadowColor = System.Drawing.Color.Gray
        Me.MenuItem75.CheckedMenuItemStyle = UltimateMenus.KunalMenuItem.CheckedMenuStyles.CheckedItemDefault
        Me.MenuItem75.CheckedMenuItemTickMarkColor = System.Drawing.SystemColors.Control
        Me.MenuItem75.FillMenuBarItem = False
        Me.MenuItem75.HighLightForeColor = System.Drawing.SystemColors.HighlightText
        Me.MenuItem75.HighLightScheme = UltimateMenus.KunalMenuItem.HighLightColorDrawStyle.DefaultScheme
        Me.MenuItem75.HiliteGradientColor1 = System.Drawing.Color.WhiteSmoke
        Me.MenuItem75.HiliteGradientColor2 = System.Drawing.Color.CornflowerBlue
        Me.MenuItem75.HiLiteGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.MenuItem75.IconShadowColor = System.Drawing.Color.Gray
        Me.MenuItem75.ImageIndex = 0
        Me.MenuItem75.Index = 3
        Me.MenuItem75.MakeCheckedMenuItemIconTransparent = False
        Me.MenuItem75.MakeTransparentIcon = False
        Me.MenuItem75.MenuBarItemBorderColor = System.Drawing.Color.Black
        Me.MenuItem75.MenuBarItemFillColor = System.Drawing.SystemColors.Menu
        Me.MenuItem75.MenuBarItemFillingStyle = UltimateMenus.KunalMenuItem.MenuBarFillStyles.FillColor
        Me.MenuItem75.MenuBarItemGradientColor1 = System.Drawing.SystemColors.Menu
        Me.MenuItem75.MenuBarItemGradientColor2 = System.Drawing.SystemColors.Menu
        Me.MenuItem75.MenuBarItemGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.MenuItem75.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem76, Me.MenuItem78})
        Me.MenuItem75.OwnerDraw = True
        Me.MenuItem75.PreDefinedHiLiteColors = UltimateMenus.KunalMenuItem.PreDefinedHighLightColors.Khaki
        Me.MenuItem75.PreDefinedHiLiteGradientColors = UltimateMenus.KunalMenuItem.PreDefinedGrHighLightColors.BrownWhite
        Me.MenuItem75.PreDefinedSideBarGradientColour = UltimateMenus.KunalMenuItem.PreDefinedSideBarGradientColors.ShineyBlueYellow
        Me.MenuItem75.ShowBorderAroundMenuBar = False
        Me.MenuItem75.ShowHiliteOverSideBar = False
        Me.MenuItem75.ShowShadowUnderMenuBar = True
        Me.MenuItem75.SideBarGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.MenuItem75.SideBarStyle = UltimateMenus.KunalMenuItem.SideBarDrawStyle.DefaultGradient
        Me.MenuItem75.Text = "&View"
        '
        'MenuItem76
        '
        Me.MenuItem76.CheckedImageIndex = 0
        Me.MenuItem76.CheckedMenuItemBackColor = System.Drawing.SystemColors.Control
        Me.MenuItem76.CheckedMenuItemBorderColor = System.Drawing.SystemColors.Control
        Me.MenuItem76.CheckedMenuItemDisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(197, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(184, Byte), Integer))
        Me.MenuItem76.CheckedMenuItemIconShadowColor = System.Drawing.Color.Gray
        Me.MenuItem76.CheckedMenuItemStyle = UltimateMenus.KunalMenuItem.CheckedMenuStyles.CheckedItemDefault
        Me.MenuItem76.CheckedMenuItemTickMarkColor = System.Drawing.SystemColors.Control
        Me.MenuItem76.FillMenuBarItem = False
        Me.MenuItem76.HighLightForeColor = System.Drawing.SystemColors.HighlightText
        Me.MenuItem76.HighLightScheme = UltimateMenus.KunalMenuItem.HighLightColorDrawStyle.DefaultScheme
        Me.MenuItem76.HiliteGradientColor1 = System.Drawing.Color.WhiteSmoke
        Me.MenuItem76.HiliteGradientColor2 = System.Drawing.Color.CornflowerBlue
        Me.MenuItem76.HiLiteGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.MenuItem76.IconShadowColor = System.Drawing.Color.Gray
        Me.MenuItem76.ImageIndex = 0
        Me.MenuItem76.Index = 0
        Me.MenuItem76.MakeCheckedMenuItemIconTransparent = False
        Me.MenuItem76.MakeTransparentIcon = False
        Me.MenuItem76.MenuBarItemBorderColor = System.Drawing.Color.Black
        Me.MenuItem76.MenuBarItemFillColor = System.Drawing.SystemColors.Menu
        Me.MenuItem76.MenuBarItemFillingStyle = UltimateMenus.KunalMenuItem.MenuBarFillStyles.FillColor
        Me.MenuItem76.MenuBarItemGradientColor1 = System.Drawing.SystemColors.Menu
        Me.MenuItem76.MenuBarItemGradientColor2 = System.Drawing.SystemColors.Menu
        Me.MenuItem76.MenuBarItemGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.MenuItem76.OwnerDraw = True
        Me.MenuItem76.PreDefinedHiLiteColors = UltimateMenus.KunalMenuItem.PreDefinedHighLightColors.Khaki
        Me.MenuItem76.PreDefinedHiLiteGradientColors = UltimateMenus.KunalMenuItem.PreDefinedGrHighLightColors.BrownWhite
        Me.MenuItem76.PreDefinedSideBarGradientColour = UltimateMenus.KunalMenuItem.PreDefinedSideBarGradientColors.ShineyBlueYellow
        Me.MenuItem76.ShowBorderAroundMenuBar = False
        Me.MenuItem76.ShowHiliteOverSideBar = False
        Me.MenuItem76.ShowShadowUnderMenuBar = True
        Me.MenuItem76.SideBarGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.MenuItem76.SideBarStyle = UltimateMenus.KunalMenuItem.SideBarDrawStyle.DefaultGradient
        Me.MenuItem76.Text = "Ledger Details"
        '
        'MenuItem78
        '
        Me.MenuItem78.CheckedImageIndex = 0
        Me.MenuItem78.CheckedMenuItemBackColor = System.Drawing.SystemColors.Control
        Me.MenuItem78.CheckedMenuItemBorderColor = System.Drawing.SystemColors.Control
        Me.MenuItem78.CheckedMenuItemDisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(197, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(184, Byte), Integer))
        Me.MenuItem78.CheckedMenuItemIconShadowColor = System.Drawing.Color.Gray
        Me.MenuItem78.CheckedMenuItemStyle = UltimateMenus.KunalMenuItem.CheckedMenuStyles.CheckedItemDefault
        Me.MenuItem78.CheckedMenuItemTickMarkColor = System.Drawing.SystemColors.Control
        Me.MenuItem78.FillMenuBarItem = False
        Me.MenuItem78.HighLightForeColor = System.Drawing.SystemColors.HighlightText
        Me.MenuItem78.HighLightScheme = UltimateMenus.KunalMenuItem.HighLightColorDrawStyle.DefaultScheme
        Me.MenuItem78.HiliteGradientColor1 = System.Drawing.Color.WhiteSmoke
        Me.MenuItem78.HiliteGradientColor2 = System.Drawing.Color.CornflowerBlue
        Me.MenuItem78.HiLiteGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.MenuItem78.IconShadowColor = System.Drawing.Color.Gray
        Me.MenuItem78.ImageIndex = 0
        Me.MenuItem78.Index = 1
        Me.MenuItem78.MakeCheckedMenuItemIconTransparent = False
        Me.MenuItem78.MakeTransparentIcon = False
        Me.MenuItem78.MenuBarItemBorderColor = System.Drawing.Color.Black
        Me.MenuItem78.MenuBarItemFillColor = System.Drawing.SystemColors.Menu
        Me.MenuItem78.MenuBarItemFillingStyle = UltimateMenus.KunalMenuItem.MenuBarFillStyles.FillColor
        Me.MenuItem78.MenuBarItemGradientColor1 = System.Drawing.SystemColors.Menu
        Me.MenuItem78.MenuBarItemGradientColor2 = System.Drawing.SystemColors.Menu
        Me.MenuItem78.MenuBarItemGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.MenuItem78.OwnerDraw = True
        Me.MenuItem78.PreDefinedHiLiteColors = UltimateMenus.KunalMenuItem.PreDefinedHighLightColors.Khaki
        Me.MenuItem78.PreDefinedHiLiteGradientColors = UltimateMenus.KunalMenuItem.PreDefinedGrHighLightColors.BrownWhite
        Me.MenuItem78.PreDefinedSideBarGradientColour = UltimateMenus.KunalMenuItem.PreDefinedSideBarGradientColors.ShineyBlueYellow
        Me.MenuItem78.ShowBorderAroundMenuBar = False
        Me.MenuItem78.ShowHiliteOverSideBar = False
        Me.MenuItem78.ShowShadowUnderMenuBar = True
        Me.MenuItem78.SideBarGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.MenuItem78.SideBarStyle = UltimateMenus.KunalMenuItem.SideBarDrawStyle.DefaultGradient
        Me.MenuItem78.Text = "Vouchers"
        Me.MenuItem78.Visible = False
        '
        'MenuItem87
        '
        Me.MenuItem87.CheckedImageIndex = 0
        Me.MenuItem87.CheckedMenuItemBackColor = System.Drawing.SystemColors.Control
        Me.MenuItem87.CheckedMenuItemBorderColor = System.Drawing.SystemColors.Control
        Me.MenuItem87.CheckedMenuItemDisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(197, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(184, Byte), Integer))
        Me.MenuItem87.CheckedMenuItemIconShadowColor = System.Drawing.Color.Gray
        Me.MenuItem87.CheckedMenuItemStyle = UltimateMenus.KunalMenuItem.CheckedMenuStyles.CheckedItemDefault
        Me.MenuItem87.CheckedMenuItemTickMarkColor = System.Drawing.SystemColors.Control
        Me.MenuItem87.FillMenuBarItem = False
        Me.MenuItem87.HighLightForeColor = System.Drawing.SystemColors.HighlightText
        Me.MenuItem87.HighLightScheme = UltimateMenus.KunalMenuItem.HighLightColorDrawStyle.DefaultScheme
        Me.MenuItem87.HiliteGradientColor1 = System.Drawing.Color.WhiteSmoke
        Me.MenuItem87.HiliteGradientColor2 = System.Drawing.Color.CornflowerBlue
        Me.MenuItem87.HiLiteGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.MenuItem87.IconShadowColor = System.Drawing.Color.Gray
        Me.MenuItem87.ImageIndex = 0
        Me.MenuItem87.Index = 4
        Me.MenuItem87.MakeCheckedMenuItemIconTransparent = False
        Me.MenuItem87.MakeTransparentIcon = False
        Me.MenuItem87.MenuBarItemBorderColor = System.Drawing.Color.Black
        Me.MenuItem87.MenuBarItemFillColor = System.Drawing.SystemColors.Menu
        Me.MenuItem87.MenuBarItemFillingStyle = UltimateMenus.KunalMenuItem.MenuBarFillStyles.FillColor
        Me.MenuItem87.MenuBarItemGradientColor1 = System.Drawing.SystemColors.Menu
        Me.MenuItem87.MenuBarItemGradientColor2 = System.Drawing.SystemColors.Menu
        Me.MenuItem87.MenuBarItemGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.MenuItem87.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem88, Me.MenuItem89, Me.MenuItem115, Me.MenuItem103})
        Me.MenuItem87.OwnerDraw = True
        Me.MenuItem87.PreDefinedHiLiteColors = UltimateMenus.KunalMenuItem.PreDefinedHighLightColors.Khaki
        Me.MenuItem87.PreDefinedHiLiteGradientColors = UltimateMenus.KunalMenuItem.PreDefinedGrHighLightColors.BrownWhite
        Me.MenuItem87.PreDefinedSideBarGradientColour = UltimateMenus.KunalMenuItem.PreDefinedSideBarGradientColors.ShineyBlueYellow
        Me.MenuItem87.ShowBorderAroundMenuBar = False
        Me.MenuItem87.ShowHiliteOverSideBar = False
        Me.MenuItem87.ShowShadowUnderMenuBar = True
        Me.MenuItem87.SideBarGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.MenuItem87.SideBarStyle = UltimateMenus.KunalMenuItem.SideBarDrawStyle.DefaultGradient
        Me.MenuItem87.Text = "Boo&ks"
        '
        'MenuItem88
        '
        Me.MenuItem88.CheckedImageIndex = 0
        Me.MenuItem88.CheckedMenuItemBackColor = System.Drawing.SystemColors.Control
        Me.MenuItem88.CheckedMenuItemBorderColor = System.Drawing.SystemColors.Control
        Me.MenuItem88.CheckedMenuItemDisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(197, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(184, Byte), Integer))
        Me.MenuItem88.CheckedMenuItemIconShadowColor = System.Drawing.Color.Gray
        Me.MenuItem88.CheckedMenuItemStyle = UltimateMenus.KunalMenuItem.CheckedMenuStyles.CheckedItemDefault
        Me.MenuItem88.CheckedMenuItemTickMarkColor = System.Drawing.SystemColors.Control
        Me.MenuItem88.FillMenuBarItem = False
        Me.MenuItem88.HighLightForeColor = System.Drawing.SystemColors.HighlightText
        Me.MenuItem88.HighLightScheme = UltimateMenus.KunalMenuItem.HighLightColorDrawStyle.DefaultScheme
        Me.MenuItem88.HiliteGradientColor1 = System.Drawing.Color.WhiteSmoke
        Me.MenuItem88.HiliteGradientColor2 = System.Drawing.Color.CornflowerBlue
        Me.MenuItem88.HiLiteGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.MenuItem88.IconShadowColor = System.Drawing.Color.Gray
        Me.MenuItem88.ImageIndex = 0
        Me.MenuItem88.Index = 0
        Me.MenuItem88.MakeCheckedMenuItemIconTransparent = False
        Me.MenuItem88.MakeTransparentIcon = False
        Me.MenuItem88.MenuBarItemBorderColor = System.Drawing.Color.Black
        Me.MenuItem88.MenuBarItemFillColor = System.Drawing.SystemColors.Menu
        Me.MenuItem88.MenuBarItemFillingStyle = UltimateMenus.KunalMenuItem.MenuBarFillStyles.FillColor
        Me.MenuItem88.MenuBarItemGradientColor1 = System.Drawing.SystemColors.Menu
        Me.MenuItem88.MenuBarItemGradientColor2 = System.Drawing.SystemColors.Menu
        Me.MenuItem88.MenuBarItemGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.MenuItem88.OwnerDraw = True
        Me.MenuItem88.PreDefinedHiLiteColors = UltimateMenus.KunalMenuItem.PreDefinedHighLightColors.Khaki
        Me.MenuItem88.PreDefinedHiLiteGradientColors = UltimateMenus.KunalMenuItem.PreDefinedGrHighLightColors.BrownWhite
        Me.MenuItem88.PreDefinedSideBarGradientColour = UltimateMenus.KunalMenuItem.PreDefinedSideBarGradientColors.ShineyBlueYellow
        Me.MenuItem88.ShowBorderAroundMenuBar = False
        Me.MenuItem88.ShowHiliteOverSideBar = False
        Me.MenuItem88.ShowShadowUnderMenuBar = True
        Me.MenuItem88.SideBarGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.MenuItem88.SideBarStyle = UltimateMenus.KunalMenuItem.SideBarDrawStyle.DefaultGradient
        Me.MenuItem88.Text = "&Day Book"
        '
        'MenuItem89
        '
        Me.MenuItem89.CheckedImageIndex = 0
        Me.MenuItem89.CheckedMenuItemBackColor = System.Drawing.SystemColors.Control
        Me.MenuItem89.CheckedMenuItemBorderColor = System.Drawing.SystemColors.Control
        Me.MenuItem89.CheckedMenuItemDisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(197, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(184, Byte), Integer))
        Me.MenuItem89.CheckedMenuItemIconShadowColor = System.Drawing.Color.Gray
        Me.MenuItem89.CheckedMenuItemStyle = UltimateMenus.KunalMenuItem.CheckedMenuStyles.CheckedItemDefault
        Me.MenuItem89.CheckedMenuItemTickMarkColor = System.Drawing.SystemColors.Control
        Me.MenuItem89.FillMenuBarItem = False
        Me.MenuItem89.HighLightForeColor = System.Drawing.SystemColors.HighlightText
        Me.MenuItem89.HighLightScheme = UltimateMenus.KunalMenuItem.HighLightColorDrawStyle.DefaultScheme
        Me.MenuItem89.HiliteGradientColor1 = System.Drawing.Color.WhiteSmoke
        Me.MenuItem89.HiliteGradientColor2 = System.Drawing.Color.CornflowerBlue
        Me.MenuItem89.HiLiteGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.MenuItem89.IconShadowColor = System.Drawing.Color.Gray
        Me.MenuItem89.ImageIndex = 0
        Me.MenuItem89.Index = 1
        Me.MenuItem89.MakeCheckedMenuItemIconTransparent = False
        Me.MenuItem89.MakeTransparentIcon = False
        Me.MenuItem89.MenuBarItemBorderColor = System.Drawing.Color.Black
        Me.MenuItem89.MenuBarItemFillColor = System.Drawing.SystemColors.Menu
        Me.MenuItem89.MenuBarItemFillingStyle = UltimateMenus.KunalMenuItem.MenuBarFillStyles.FillColor
        Me.MenuItem89.MenuBarItemGradientColor1 = System.Drawing.SystemColors.Menu
        Me.MenuItem89.MenuBarItemGradientColor2 = System.Drawing.SystemColors.Menu
        Me.MenuItem89.MenuBarItemGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.MenuItem89.OwnerDraw = True
        Me.MenuItem89.PreDefinedHiLiteColors = UltimateMenus.KunalMenuItem.PreDefinedHighLightColors.Khaki
        Me.MenuItem89.PreDefinedHiLiteGradientColors = UltimateMenus.KunalMenuItem.PreDefinedGrHighLightColors.BrownWhite
        Me.MenuItem89.PreDefinedSideBarGradientColour = UltimateMenus.KunalMenuItem.PreDefinedSideBarGradientColors.ShineyBlueYellow
        Me.MenuItem89.ShowBorderAroundMenuBar = False
        Me.MenuItem89.ShowHiliteOverSideBar = False
        Me.MenuItem89.ShowShadowUnderMenuBar = True
        Me.MenuItem89.SideBarGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.MenuItem89.SideBarStyle = UltimateMenus.KunalMenuItem.SideBarDrawStyle.DefaultGradient
        Me.MenuItem89.Text = "&Cash Scroll"
        '
        'MenuItem115
        '
        Me.MenuItem115.CheckedImageIndex = 0
        Me.MenuItem115.CheckedMenuItemBackColor = System.Drawing.SystemColors.Control
        Me.MenuItem115.CheckedMenuItemBorderColor = System.Drawing.SystemColors.Control
        Me.MenuItem115.CheckedMenuItemDisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(197, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(184, Byte), Integer))
        Me.MenuItem115.CheckedMenuItemIconShadowColor = System.Drawing.Color.Gray
        Me.MenuItem115.CheckedMenuItemStyle = UltimateMenus.KunalMenuItem.CheckedMenuStyles.CheckedItemDefault
        Me.MenuItem115.CheckedMenuItemTickMarkColor = System.Drawing.SystemColors.Control
        Me.MenuItem115.FillMenuBarItem = False
        Me.MenuItem115.HighLightForeColor = System.Drawing.SystemColors.HighlightText
        Me.MenuItem115.HighLightScheme = UltimateMenus.KunalMenuItem.HighLightColorDrawStyle.DefaultScheme
        Me.MenuItem115.HiliteGradientColor1 = System.Drawing.Color.WhiteSmoke
        Me.MenuItem115.HiliteGradientColor2 = System.Drawing.Color.CornflowerBlue
        Me.MenuItem115.HiLiteGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.MenuItem115.IconShadowColor = System.Drawing.Color.Gray
        Me.MenuItem115.ImageIndex = 0
        Me.MenuItem115.Index = 2
        Me.MenuItem115.MakeCheckedMenuItemIconTransparent = False
        Me.MenuItem115.MakeTransparentIcon = False
        Me.MenuItem115.MenuBarItemBorderColor = System.Drawing.Color.Black
        Me.MenuItem115.MenuBarItemFillColor = System.Drawing.SystemColors.Menu
        Me.MenuItem115.MenuBarItemFillingStyle = UltimateMenus.KunalMenuItem.MenuBarFillStyles.FillColor
        Me.MenuItem115.MenuBarItemGradientColor1 = System.Drawing.SystemColors.Menu
        Me.MenuItem115.MenuBarItemGradientColor2 = System.Drawing.SystemColors.Menu
        Me.MenuItem115.MenuBarItemGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.MenuItem115.OwnerDraw = True
        Me.MenuItem115.PreDefinedHiLiteColors = UltimateMenus.KunalMenuItem.PreDefinedHighLightColors.Khaki
        Me.MenuItem115.PreDefinedHiLiteGradientColors = UltimateMenus.KunalMenuItem.PreDefinedGrHighLightColors.BrownWhite
        Me.MenuItem115.PreDefinedSideBarGradientColour = UltimateMenus.KunalMenuItem.PreDefinedSideBarGradientColors.ShineyBlueYellow
        Me.MenuItem115.ShowBorderAroundMenuBar = False
        Me.MenuItem115.ShowHiliteOverSideBar = False
        Me.MenuItem115.ShowShadowUnderMenuBar = True
        Me.MenuItem115.SideBarGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.MenuItem115.SideBarStyle = UltimateMenus.KunalMenuItem.SideBarDrawStyle.DefaultGradient
        Me.MenuItem115.Text = "Transfer Scroll"
        '
        'MenuItem103
        '
        Me.MenuItem103.CheckedImageIndex = 0
        Me.MenuItem103.CheckedMenuItemBackColor = System.Drawing.SystemColors.Control
        Me.MenuItem103.CheckedMenuItemBorderColor = System.Drawing.SystemColors.Control
        Me.MenuItem103.CheckedMenuItemDisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(197, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(184, Byte), Integer))
        Me.MenuItem103.CheckedMenuItemIconShadowColor = System.Drawing.Color.Gray
        Me.MenuItem103.CheckedMenuItemStyle = UltimateMenus.KunalMenuItem.CheckedMenuStyles.CheckedItemDefault
        Me.MenuItem103.CheckedMenuItemTickMarkColor = System.Drawing.SystemColors.Control
        Me.MenuItem103.FillMenuBarItem = False
        Me.MenuItem103.HighLightForeColor = System.Drawing.SystemColors.HighlightText
        Me.MenuItem103.HighLightScheme = UltimateMenus.KunalMenuItem.HighLightColorDrawStyle.DefaultScheme
        Me.MenuItem103.HiliteGradientColor1 = System.Drawing.Color.WhiteSmoke
        Me.MenuItem103.HiliteGradientColor2 = System.Drawing.Color.CornflowerBlue
        Me.MenuItem103.HiLiteGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.MenuItem103.IconShadowColor = System.Drawing.Color.Gray
        Me.MenuItem103.ImageIndex = 0
        Me.MenuItem103.Index = 3
        Me.MenuItem103.MakeCheckedMenuItemIconTransparent = False
        Me.MenuItem103.MakeTransparentIcon = False
        Me.MenuItem103.MenuBarItemBorderColor = System.Drawing.Color.Black
        Me.MenuItem103.MenuBarItemFillColor = System.Drawing.SystemColors.Menu
        Me.MenuItem103.MenuBarItemFillingStyle = UltimateMenus.KunalMenuItem.MenuBarFillStyles.FillColor
        Me.MenuItem103.MenuBarItemGradientColor1 = System.Drawing.SystemColors.Menu
        Me.MenuItem103.MenuBarItemGradientColor2 = System.Drawing.SystemColors.Menu
        Me.MenuItem103.MenuBarItemGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.MenuItem103.OwnerDraw = True
        Me.MenuItem103.PreDefinedHiLiteColors = UltimateMenus.KunalMenuItem.PreDefinedHighLightColors.Khaki
        Me.MenuItem103.PreDefinedHiLiteGradientColors = UltimateMenus.KunalMenuItem.PreDefinedGrHighLightColors.BrownWhite
        Me.MenuItem103.PreDefinedSideBarGradientColour = UltimateMenus.KunalMenuItem.PreDefinedSideBarGradientColors.ShineyBlueYellow
        Me.MenuItem103.ShowBorderAroundMenuBar = False
        Me.MenuItem103.ShowHiliteOverSideBar = False
        Me.MenuItem103.ShowShadowUnderMenuBar = True
        Me.MenuItem103.SideBarGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.MenuItem103.SideBarStyle = UltimateMenus.KunalMenuItem.SideBarDrawStyle.DefaultGradient
        Me.MenuItem103.Text = "Scroll Book"
        '
        'MenuItem140
        '
        Me.MenuItem140.CheckedImageIndex = 0
        Me.MenuItem140.CheckedMenuItemBackColor = System.Drawing.SystemColors.Control
        Me.MenuItem140.CheckedMenuItemBorderColor = System.Drawing.SystemColors.Control
        Me.MenuItem140.CheckedMenuItemDisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(197, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(184, Byte), Integer))
        Me.MenuItem140.CheckedMenuItemIconShadowColor = System.Drawing.Color.Gray
        Me.MenuItem140.CheckedMenuItemStyle = UltimateMenus.KunalMenuItem.CheckedMenuStyles.CheckedItemDefault
        Me.MenuItem140.CheckedMenuItemTickMarkColor = System.Drawing.SystemColors.Control
        Me.MenuItem140.FillMenuBarItem = False
        Me.MenuItem140.HighLightForeColor = System.Drawing.SystemColors.HighlightText
        Me.MenuItem140.HighLightScheme = UltimateMenus.KunalMenuItem.HighLightColorDrawStyle.DefaultScheme
        Me.MenuItem140.HiliteGradientColor1 = System.Drawing.Color.WhiteSmoke
        Me.MenuItem140.HiliteGradientColor2 = System.Drawing.Color.CornflowerBlue
        Me.MenuItem140.HiLiteGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.MenuItem140.IconShadowColor = System.Drawing.Color.Gray
        Me.MenuItem140.ImageIndex = 0
        Me.MenuItem140.Index = 5
        Me.MenuItem140.MakeCheckedMenuItemIconTransparent = False
        Me.MenuItem140.MakeTransparentIcon = False
        Me.MenuItem140.MenuBarItemBorderColor = System.Drawing.Color.Black
        Me.MenuItem140.MenuBarItemFillColor = System.Drawing.SystemColors.Menu
        Me.MenuItem140.MenuBarItemFillingStyle = UltimateMenus.KunalMenuItem.MenuBarFillStyles.FillColor
        Me.MenuItem140.MenuBarItemGradientColor1 = System.Drawing.SystemColors.Menu
        Me.MenuItem140.MenuBarItemGradientColor2 = System.Drawing.SystemColors.Menu
        Me.MenuItem140.MenuBarItemGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.MenuItem140.OwnerDraw = True
        Me.MenuItem140.PreDefinedHiLiteColors = UltimateMenus.KunalMenuItem.PreDefinedHighLightColors.Khaki
        Me.MenuItem140.PreDefinedHiLiteGradientColors = UltimateMenus.KunalMenuItem.PreDefinedGrHighLightColors.BrownWhite
        Me.MenuItem140.PreDefinedSideBarGradientColour = UltimateMenus.KunalMenuItem.PreDefinedSideBarGradientColors.ShineyBlueYellow
        Me.MenuItem140.ShowBorderAroundMenuBar = False
        Me.MenuItem140.ShowHiliteOverSideBar = False
        Me.MenuItem140.ShowShadowUnderMenuBar = True
        Me.MenuItem140.SideBarGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.MenuItem140.SideBarStyle = UltimateMenus.KunalMenuItem.SideBarDrawStyle.DefaultGradient
        Me.MenuItem140.Text = "Branch Interest"
        '
        'MenuItem57
        '
        Me.MenuItem57.CheckedImageIndex = 0
        Me.MenuItem57.CheckedMenuItemBackColor = System.Drawing.SystemColors.Control
        Me.MenuItem57.CheckedMenuItemBorderColor = System.Drawing.SystemColors.Control
        Me.MenuItem57.CheckedMenuItemDisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(197, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(184, Byte), Integer))
        Me.MenuItem57.CheckedMenuItemIconShadowColor = System.Drawing.Color.Gray
        Me.MenuItem57.CheckedMenuItemStyle = UltimateMenus.KunalMenuItem.CheckedMenuStyles.CheckedItemDefault
        Me.MenuItem57.CheckedMenuItemTickMarkColor = System.Drawing.SystemColors.Control
        Me.MenuItem57.DefaultItem = True
        Me.MenuItem57.FillMenuBarItem = False
        Me.MenuItem57.HighLightForeColor = System.Drawing.SystemColors.HighlightText
        Me.MenuItem57.HighLightScheme = UltimateMenus.KunalMenuItem.HighLightColorDrawStyle.DefaultScheme
        Me.MenuItem57.HiliteGradientColor1 = System.Drawing.Color.WhiteSmoke
        Me.MenuItem57.HiliteGradientColor2 = System.Drawing.Color.CornflowerBlue
        Me.MenuItem57.HiLiteGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.MenuItem57.IconShadowColor = System.Drawing.Color.Gray
        Me.MenuItem57.ImageIndex = 0
        Me.MenuItem57.Index = 6
        Me.MenuItem57.MakeCheckedMenuItemIconTransparent = False
        Me.MenuItem57.MakeTransparentIcon = False
        Me.MenuItem57.MenuBarItemBorderColor = System.Drawing.Color.Black
        Me.MenuItem57.MenuBarItemFillColor = System.Drawing.SystemColors.Menu
        Me.MenuItem57.MenuBarItemFillingStyle = UltimateMenus.KunalMenuItem.MenuBarFillStyles.FillColor
        Me.MenuItem57.MenuBarItemGradientColor1 = System.Drawing.SystemColors.Menu
        Me.MenuItem57.MenuBarItemGradientColor2 = System.Drawing.SystemColors.Menu
        Me.MenuItem57.MenuBarItemGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.MenuItem57.OwnerDraw = True
        Me.MenuItem57.PreDefinedHiLiteColors = UltimateMenus.KunalMenuItem.PreDefinedHighLightColors.Khaki
        Me.MenuItem57.PreDefinedHiLiteGradientColors = UltimateMenus.KunalMenuItem.PreDefinedGrHighLightColors.BrownWhite
        Me.MenuItem57.PreDefinedSideBarGradientColour = UltimateMenus.KunalMenuItem.PreDefinedSideBarGradientColors.ShineyBlueYellow
        Me.MenuItem57.Shortcut = System.Windows.Forms.Shortcut.F3
        Me.MenuItem57.ShowBorderAroundMenuBar = False
        Me.MenuItem57.ShowHiliteOverSideBar = False
        Me.MenuItem57.ShowShadowUnderMenuBar = True
        Me.MenuItem57.SideBarGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.MenuItem57.SideBarStyle = UltimateMenus.KunalMenuItem.SideBarDrawStyle.DefaultGradient
        Me.MenuItem57.Text = "Voucher &Entry"
        '
        'MenuItem59
        '
        Me.MenuItem59.CheckedImageIndex = 0
        Me.MenuItem59.CheckedMenuItemBackColor = System.Drawing.SystemColors.Control
        Me.MenuItem59.CheckedMenuItemBorderColor = System.Drawing.SystemColors.Control
        Me.MenuItem59.CheckedMenuItemDisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(197, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(184, Byte), Integer))
        Me.MenuItem59.CheckedMenuItemIconShadowColor = System.Drawing.Color.Gray
        Me.MenuItem59.CheckedMenuItemStyle = UltimateMenus.KunalMenuItem.CheckedMenuStyles.CheckedItemDefault
        Me.MenuItem59.CheckedMenuItemTickMarkColor = System.Drawing.SystemColors.Control
        Me.MenuItem59.FillMenuBarItem = False
        Me.MenuItem59.HighLightForeColor = System.Drawing.SystemColors.HighlightText
        Me.MenuItem59.HighLightScheme = UltimateMenus.KunalMenuItem.HighLightColorDrawStyle.DefaultScheme
        Me.MenuItem59.HiliteGradientColor1 = System.Drawing.Color.WhiteSmoke
        Me.MenuItem59.HiliteGradientColor2 = System.Drawing.Color.CornflowerBlue
        Me.MenuItem59.HiLiteGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.MenuItem59.IconShadowColor = System.Drawing.Color.Gray
        Me.MenuItem59.ImageIndex = 0
        Me.MenuItem59.Index = 7
        Me.MenuItem59.MakeCheckedMenuItemIconTransparent = False
        Me.MenuItem59.MakeTransparentIcon = False
        Me.MenuItem59.MenuBarItemBorderColor = System.Drawing.Color.Black
        Me.MenuItem59.MenuBarItemFillColor = System.Drawing.SystemColors.Menu
        Me.MenuItem59.MenuBarItemFillingStyle = UltimateMenus.KunalMenuItem.MenuBarFillStyles.FillColor
        Me.MenuItem59.MenuBarItemGradientColor1 = System.Drawing.SystemColors.Menu
        Me.MenuItem59.MenuBarItemGradientColor2 = System.Drawing.SystemColors.Menu
        Me.MenuItem59.MenuBarItemGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.MenuItem59.OwnerDraw = True
        Me.MenuItem59.PreDefinedHiLiteColors = UltimateMenus.KunalMenuItem.PreDefinedHighLightColors.Khaki
        Me.MenuItem59.PreDefinedHiLiteGradientColors = UltimateMenus.KunalMenuItem.PreDefinedGrHighLightColors.BrownWhite
        Me.MenuItem59.PreDefinedSideBarGradientColour = UltimateMenus.KunalMenuItem.PreDefinedSideBarGradientColors.ShineyBlueYellow
        Me.MenuItem59.ShowBorderAroundMenuBar = False
        Me.MenuItem59.ShowHiliteOverSideBar = False
        Me.MenuItem59.ShowShadowUnderMenuBar = True
        Me.MenuItem59.SideBarGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.MenuItem59.SideBarStyle = UltimateMenus.KunalMenuItem.SideBarDrawStyle.DefaultGradient
        Me.MenuItem59.Text = "&Trial Balance"
        Me.MenuItem59.Visible = False
        '
        'MenuItem60
        '
        Me.MenuItem60.CheckedImageIndex = 0
        Me.MenuItem60.CheckedMenuItemBackColor = System.Drawing.SystemColors.Control
        Me.MenuItem60.CheckedMenuItemBorderColor = System.Drawing.SystemColors.Control
        Me.MenuItem60.CheckedMenuItemDisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(197, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(184, Byte), Integer))
        Me.MenuItem60.CheckedMenuItemIconShadowColor = System.Drawing.Color.Gray
        Me.MenuItem60.CheckedMenuItemStyle = UltimateMenus.KunalMenuItem.CheckedMenuStyles.CheckedItemDefault
        Me.MenuItem60.CheckedMenuItemTickMarkColor = System.Drawing.SystemColors.Control
        Me.MenuItem60.FillMenuBarItem = False
        Me.MenuItem60.HighLightForeColor = System.Drawing.SystemColors.HighlightText
        Me.MenuItem60.HighLightScheme = UltimateMenus.KunalMenuItem.HighLightColorDrawStyle.DefaultScheme
        Me.MenuItem60.HiliteGradientColor1 = System.Drawing.Color.WhiteSmoke
        Me.MenuItem60.HiliteGradientColor2 = System.Drawing.Color.CornflowerBlue
        Me.MenuItem60.HiLiteGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.MenuItem60.IconShadowColor = System.Drawing.Color.Gray
        Me.MenuItem60.ImageIndex = 0
        Me.MenuItem60.Index = 8
        Me.MenuItem60.MakeCheckedMenuItemIconTransparent = False
        Me.MenuItem60.MakeTransparentIcon = False
        Me.MenuItem60.MenuBarItemBorderColor = System.Drawing.Color.Black
        Me.MenuItem60.MenuBarItemFillColor = System.Drawing.SystemColors.Menu
        Me.MenuItem60.MenuBarItemFillingStyle = UltimateMenus.KunalMenuItem.MenuBarFillStyles.FillColor
        Me.MenuItem60.MenuBarItemGradientColor1 = System.Drawing.SystemColors.Menu
        Me.MenuItem60.MenuBarItemGradientColor2 = System.Drawing.SystemColors.Menu
        Me.MenuItem60.MenuBarItemGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.MenuItem60.OwnerDraw = True
        Me.MenuItem60.PreDefinedHiLiteColors = UltimateMenus.KunalMenuItem.PreDefinedHighLightColors.Khaki
        Me.MenuItem60.PreDefinedHiLiteGradientColors = UltimateMenus.KunalMenuItem.PreDefinedGrHighLightColors.BrownWhite
        Me.MenuItem60.PreDefinedSideBarGradientColour = UltimateMenus.KunalMenuItem.PreDefinedSideBarGradientColors.ShineyBlueYellow
        Me.MenuItem60.ShowBorderAroundMenuBar = False
        Me.MenuItem60.ShowHiliteOverSideBar = False
        Me.MenuItem60.ShowShadowUnderMenuBar = True
        Me.MenuItem60.SideBarGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.MenuItem60.SideBarStyle = UltimateMenus.KunalMenuItem.SideBarDrawStyle.DefaultGradient
        Me.MenuItem60.Text = "&Income and  Expendature"
        '
        'MenuItem61
        '
        Me.MenuItem61.CheckedImageIndex = 0
        Me.MenuItem61.CheckedMenuItemBackColor = System.Drawing.SystemColors.Control
        Me.MenuItem61.CheckedMenuItemBorderColor = System.Drawing.SystemColors.Control
        Me.MenuItem61.CheckedMenuItemDisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(197, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(184, Byte), Integer))
        Me.MenuItem61.CheckedMenuItemIconShadowColor = System.Drawing.Color.Gray
        Me.MenuItem61.CheckedMenuItemStyle = UltimateMenus.KunalMenuItem.CheckedMenuStyles.CheckedItemDefault
        Me.MenuItem61.CheckedMenuItemTickMarkColor = System.Drawing.SystemColors.Control
        Me.MenuItem61.FillMenuBarItem = False
        Me.MenuItem61.HighLightForeColor = System.Drawing.SystemColors.HighlightText
        Me.MenuItem61.HighLightScheme = UltimateMenus.KunalMenuItem.HighLightColorDrawStyle.DefaultScheme
        Me.MenuItem61.HiliteGradientColor1 = System.Drawing.Color.WhiteSmoke
        Me.MenuItem61.HiliteGradientColor2 = System.Drawing.Color.CornflowerBlue
        Me.MenuItem61.HiLiteGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.MenuItem61.IconShadowColor = System.Drawing.Color.Gray
        Me.MenuItem61.ImageIndex = 0
        Me.MenuItem61.Index = 9
        Me.MenuItem61.MakeCheckedMenuItemIconTransparent = False
        Me.MenuItem61.MakeTransparentIcon = False
        Me.MenuItem61.MenuBarItemBorderColor = System.Drawing.Color.Black
        Me.MenuItem61.MenuBarItemFillColor = System.Drawing.SystemColors.Menu
        Me.MenuItem61.MenuBarItemFillingStyle = UltimateMenus.KunalMenuItem.MenuBarFillStyles.FillColor
        Me.MenuItem61.MenuBarItemGradientColor1 = System.Drawing.SystemColors.Menu
        Me.MenuItem61.MenuBarItemGradientColor2 = System.Drawing.SystemColors.Menu
        Me.MenuItem61.MenuBarItemGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.MenuItem61.OwnerDraw = True
        Me.MenuItem61.PreDefinedHiLiteColors = UltimateMenus.KunalMenuItem.PreDefinedHighLightColors.Khaki
        Me.MenuItem61.PreDefinedHiLiteGradientColors = UltimateMenus.KunalMenuItem.PreDefinedGrHighLightColors.BrownWhite
        Me.MenuItem61.PreDefinedSideBarGradientColour = UltimateMenus.KunalMenuItem.PreDefinedSideBarGradientColors.ShineyBlueYellow
        Me.MenuItem61.ShowBorderAroundMenuBar = False
        Me.MenuItem61.ShowHiliteOverSideBar = False
        Me.MenuItem61.ShowShadowUnderMenuBar = True
        Me.MenuItem61.SideBarGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.MenuItem61.SideBarStyle = UltimateMenus.KunalMenuItem.SideBarDrawStyle.DefaultGradient
        Me.MenuItem61.Text = "&Receipt and Payments"
        '
        'MenuItem93
        '
        Me.MenuItem93.CheckedImageIndex = 0
        Me.MenuItem93.CheckedMenuItemBackColor = System.Drawing.SystemColors.Control
        Me.MenuItem93.CheckedMenuItemBorderColor = System.Drawing.SystemColors.Control
        Me.MenuItem93.CheckedMenuItemDisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(197, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(184, Byte), Integer))
        Me.MenuItem93.CheckedMenuItemIconShadowColor = System.Drawing.Color.Gray
        Me.MenuItem93.CheckedMenuItemStyle = UltimateMenus.KunalMenuItem.CheckedMenuStyles.CheckedItemDefault
        Me.MenuItem93.CheckedMenuItemTickMarkColor = System.Drawing.SystemColors.Control
        Me.MenuItem93.FillMenuBarItem = False
        Me.MenuItem93.HighLightForeColor = System.Drawing.SystemColors.HighlightText
        Me.MenuItem93.HighLightScheme = UltimateMenus.KunalMenuItem.HighLightColorDrawStyle.DefaultScheme
        Me.MenuItem93.HiliteGradientColor1 = System.Drawing.Color.WhiteSmoke
        Me.MenuItem93.HiliteGradientColor2 = System.Drawing.Color.CornflowerBlue
        Me.MenuItem93.HiLiteGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.MenuItem93.IconShadowColor = System.Drawing.Color.Gray
        Me.MenuItem93.ImageIndex = 0
        Me.MenuItem93.Index = 10
        Me.MenuItem93.MakeCheckedMenuItemIconTransparent = False
        Me.MenuItem93.MakeTransparentIcon = False
        Me.MenuItem93.MenuBarItemBorderColor = System.Drawing.Color.Black
        Me.MenuItem93.MenuBarItemFillColor = System.Drawing.SystemColors.Menu
        Me.MenuItem93.MenuBarItemFillingStyle = UltimateMenus.KunalMenuItem.MenuBarFillStyles.FillColor
        Me.MenuItem93.MenuBarItemGradientColor1 = System.Drawing.SystemColors.Menu
        Me.MenuItem93.MenuBarItemGradientColor2 = System.Drawing.SystemColors.Menu
        Me.MenuItem93.MenuBarItemGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.MenuItem93.OwnerDraw = True
        Me.MenuItem93.PreDefinedHiLiteColors = UltimateMenus.KunalMenuItem.PreDefinedHighLightColors.Khaki
        Me.MenuItem93.PreDefinedHiLiteGradientColors = UltimateMenus.KunalMenuItem.PreDefinedGrHighLightColors.BrownWhite
        Me.MenuItem93.PreDefinedSideBarGradientColour = UltimateMenus.KunalMenuItem.PreDefinedSideBarGradientColors.ShineyBlueYellow
        Me.MenuItem93.ShowBorderAroundMenuBar = False
        Me.MenuItem93.ShowHiliteOverSideBar = False
        Me.MenuItem93.ShowShadowUnderMenuBar = True
        Me.MenuItem93.SideBarGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.MenuItem93.SideBarStyle = UltimateMenus.KunalMenuItem.SideBarDrawStyle.DefaultGradient
        Me.MenuItem93.Text = "Purchase and &Sales"
        Me.MenuItem93.Visible = False
        '
        'MenuItem52
        '
        Me.MenuItem52.CheckedImageIndex = 0
        Me.MenuItem52.CheckedMenuItemBackColor = System.Drawing.SystemColors.Control
        Me.MenuItem52.CheckedMenuItemBorderColor = System.Drawing.SystemColors.Control
        Me.MenuItem52.CheckedMenuItemDisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(197, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(184, Byte), Integer))
        Me.MenuItem52.CheckedMenuItemIconShadowColor = System.Drawing.Color.Gray
        Me.MenuItem52.CheckedMenuItemStyle = UltimateMenus.KunalMenuItem.CheckedMenuStyles.CheckedItemDefault
        Me.MenuItem52.CheckedMenuItemTickMarkColor = System.Drawing.SystemColors.Control
        Me.MenuItem52.FillMenuBarItem = False
        Me.MenuItem52.HighLightForeColor = System.Drawing.SystemColors.HighlightText
        Me.MenuItem52.HighLightScheme = UltimateMenus.KunalMenuItem.HighLightColorDrawStyle.DefaultScheme
        Me.MenuItem52.HiliteGradientColor1 = System.Drawing.Color.WhiteSmoke
        Me.MenuItem52.HiliteGradientColor2 = System.Drawing.Color.CornflowerBlue
        Me.MenuItem52.HiLiteGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.MenuItem52.IconShadowColor = System.Drawing.Color.Gray
        Me.MenuItem52.ImageIndex = 0
        Me.MenuItem52.Index = 11
        Me.MenuItem52.MakeCheckedMenuItemIconTransparent = False
        Me.MenuItem52.MakeTransparentIcon = False
        Me.MenuItem52.MenuBarItemBorderColor = System.Drawing.Color.Black
        Me.MenuItem52.MenuBarItemFillColor = System.Drawing.SystemColors.Menu
        Me.MenuItem52.MenuBarItemFillingStyle = UltimateMenus.KunalMenuItem.MenuBarFillStyles.FillColor
        Me.MenuItem52.MenuBarItemGradientColor1 = System.Drawing.SystemColors.Menu
        Me.MenuItem52.MenuBarItemGradientColor2 = System.Drawing.SystemColors.Menu
        Me.MenuItem52.MenuBarItemGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.MenuItem52.OwnerDraw = True
        Me.MenuItem52.PreDefinedHiLiteColors = UltimateMenus.KunalMenuItem.PreDefinedHighLightColors.Khaki
        Me.MenuItem52.PreDefinedHiLiteGradientColors = UltimateMenus.KunalMenuItem.PreDefinedGrHighLightColors.BrownWhite
        Me.MenuItem52.PreDefinedSideBarGradientColour = UltimateMenus.KunalMenuItem.PreDefinedSideBarGradientColors.ShineyBlueYellow
        Me.MenuItem52.ShowBorderAroundMenuBar = False
        Me.MenuItem52.ShowHiliteOverSideBar = False
        Me.MenuItem52.ShowShadowUnderMenuBar = True
        Me.MenuItem52.SideBarGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.MenuItem52.SideBarStyle = UltimateMenus.KunalMenuItem.SideBarDrawStyle.DefaultGradient
        Me.MenuItem52.Text = "Balance Sheet"
        '
        'MenuItem8
        '
        Me.MenuItem8.CheckedImageIndex = 0
        Me.MenuItem8.CheckedMenuItemBackColor = System.Drawing.SystemColors.Control
        Me.MenuItem8.CheckedMenuItemBorderColor = System.Drawing.SystemColors.Control
        Me.MenuItem8.CheckedMenuItemDisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(197, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(184, Byte), Integer))
        Me.MenuItem8.CheckedMenuItemIconShadowColor = System.Drawing.Color.Gray
        Me.MenuItem8.CheckedMenuItemStyle = UltimateMenus.KunalMenuItem.CheckedMenuStyles.CheckedItemDefault
        Me.MenuItem8.CheckedMenuItemTickMarkColor = System.Drawing.SystemColors.Control
        Me.MenuItem8.FillMenuBarItem = False
        Me.MenuItem8.HighLightForeColor = System.Drawing.SystemColors.HighlightText
        Me.MenuItem8.HighLightScheme = UltimateMenus.KunalMenuItem.HighLightColorDrawStyle.DefaultScheme
        Me.MenuItem8.HiliteGradientColor1 = System.Drawing.Color.WhiteSmoke
        Me.MenuItem8.HiliteGradientColor2 = System.Drawing.Color.CornflowerBlue
        Me.MenuItem8.HiLiteGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.MenuItem8.IconShadowColor = System.Drawing.Color.Gray
        Me.MenuItem8.ImageIndex = 0
        Me.MenuItem8.Index = 9
        Me.MenuItem8.MakeCheckedMenuItemIconTransparent = False
        Me.MenuItem8.MakeTransparentIcon = False
        Me.MenuItem8.MenuBarItemBorderColor = System.Drawing.Color.Black
        Me.MenuItem8.MenuBarItemFillColor = System.Drawing.SystemColors.Menu
        Me.MenuItem8.MenuBarItemFillingStyle = UltimateMenus.KunalMenuItem.MenuBarFillStyles.FillColor
        Me.MenuItem8.MenuBarItemGradientColor1 = System.Drawing.SystemColors.Menu
        Me.MenuItem8.MenuBarItemGradientColor2 = System.Drawing.SystemColors.Menu
        Me.MenuItem8.MenuBarItemGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.MenuItem8.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem79, Me.MenuItem80, Me.MenuItem56, Me.MenuItem90, Me.MenuItem58, Me.MenuItem126, Me.MenuItem179})
        Me.MenuItem8.OwnerDraw = True
        Me.MenuItem8.PreDefinedHiLiteColors = UltimateMenus.KunalMenuItem.PreDefinedHighLightColors.Khaki
        Me.MenuItem8.PreDefinedHiLiteGradientColors = UltimateMenus.KunalMenuItem.PreDefinedGrHighLightColors.BrownWhite
        Me.MenuItem8.PreDefinedSideBarGradientColour = UltimateMenus.KunalMenuItem.PreDefinedSideBarGradientColors.ShineyBlueYellow
        Me.MenuItem8.ShowBorderAroundMenuBar = False
        Me.MenuItem8.ShowHiliteOverSideBar = False
        Me.MenuItem8.ShowShadowUnderMenuBar = True
        Me.MenuItem8.SideBarGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.MenuItem8.SideBarStyle = UltimateMenus.KunalMenuItem.SideBarDrawStyle.DefaultGradient
        Me.MenuItem8.Text = "T&ools"
        '
        'MenuItem79
        '
        Me.MenuItem79.CheckedImageIndex = 0
        Me.MenuItem79.CheckedMenuItemBackColor = System.Drawing.SystemColors.Control
        Me.MenuItem79.CheckedMenuItemBorderColor = System.Drawing.SystemColors.Control
        Me.MenuItem79.CheckedMenuItemDisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(197, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(184, Byte), Integer))
        Me.MenuItem79.CheckedMenuItemIconShadowColor = System.Drawing.Color.Gray
        Me.MenuItem79.CheckedMenuItemStyle = UltimateMenus.KunalMenuItem.CheckedMenuStyles.CheckedItemDefault
        Me.MenuItem79.CheckedMenuItemTickMarkColor = System.Drawing.SystemColors.Control
        Me.MenuItem79.FillMenuBarItem = False
        Me.MenuItem79.HighLightForeColor = System.Drawing.SystemColors.HighlightText
        Me.MenuItem79.HighLightScheme = UltimateMenus.KunalMenuItem.HighLightColorDrawStyle.DefaultScheme
        Me.MenuItem79.HiliteGradientColor1 = System.Drawing.Color.WhiteSmoke
        Me.MenuItem79.HiliteGradientColor2 = System.Drawing.Color.CornflowerBlue
        Me.MenuItem79.HiLiteGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.MenuItem79.IconShadowColor = System.Drawing.Color.Gray
        Me.MenuItem79.ImageIndex = 0
        Me.MenuItem79.Index = 0
        Me.MenuItem79.MakeCheckedMenuItemIconTransparent = False
        Me.MenuItem79.MakeTransparentIcon = False
        Me.MenuItem79.MenuBarItemBorderColor = System.Drawing.Color.Black
        Me.MenuItem79.MenuBarItemFillColor = System.Drawing.SystemColors.Menu
        Me.MenuItem79.MenuBarItemFillingStyle = UltimateMenus.KunalMenuItem.MenuBarFillStyles.FillColor
        Me.MenuItem79.MenuBarItemGradientColor1 = System.Drawing.SystemColors.Menu
        Me.MenuItem79.MenuBarItemGradientColor2 = System.Drawing.SystemColors.Menu
        Me.MenuItem79.MenuBarItemGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.MenuItem79.OwnerDraw = True
        Me.MenuItem79.PreDefinedHiLiteColors = UltimateMenus.KunalMenuItem.PreDefinedHighLightColors.Khaki
        Me.MenuItem79.PreDefinedHiLiteGradientColors = UltimateMenus.KunalMenuItem.PreDefinedGrHighLightColors.BrownWhite
        Me.MenuItem79.PreDefinedSideBarGradientColour = UltimateMenus.KunalMenuItem.PreDefinedSideBarGradientColors.ShineyBlueYellow
        Me.MenuItem79.ShowBorderAroundMenuBar = False
        Me.MenuItem79.ShowHiliteOverSideBar = False
        Me.MenuItem79.ShowShadowUnderMenuBar = True
        Me.MenuItem79.SideBarGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.MenuItem79.SideBarStyle = UltimateMenus.KunalMenuItem.SideBarDrawStyle.DefaultGradient
        Me.MenuItem79.Text = "&Back Up"
        Me.MenuItem79.Visible = False
        '
        'MenuItem80
        '
        Me.MenuItem80.CheckedImageIndex = 0
        Me.MenuItem80.CheckedMenuItemBackColor = System.Drawing.SystemColors.Control
        Me.MenuItem80.CheckedMenuItemBorderColor = System.Drawing.SystemColors.Control
        Me.MenuItem80.CheckedMenuItemDisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(197, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(184, Byte), Integer))
        Me.MenuItem80.CheckedMenuItemIconShadowColor = System.Drawing.Color.Gray
        Me.MenuItem80.CheckedMenuItemStyle = UltimateMenus.KunalMenuItem.CheckedMenuStyles.CheckedItemDefault
        Me.MenuItem80.CheckedMenuItemTickMarkColor = System.Drawing.SystemColors.Control
        Me.MenuItem80.FillMenuBarItem = False
        Me.MenuItem80.HighLightForeColor = System.Drawing.SystemColors.HighlightText
        Me.MenuItem80.HighLightScheme = UltimateMenus.KunalMenuItem.HighLightColorDrawStyle.DefaultScheme
        Me.MenuItem80.HiliteGradientColor1 = System.Drawing.Color.WhiteSmoke
        Me.MenuItem80.HiliteGradientColor2 = System.Drawing.Color.CornflowerBlue
        Me.MenuItem80.HiLiteGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.MenuItem80.IconShadowColor = System.Drawing.Color.Gray
        Me.MenuItem80.ImageIndex = 0
        Me.MenuItem80.Index = 1
        Me.MenuItem80.MakeCheckedMenuItemIconTransparent = False
        Me.MenuItem80.MakeTransparentIcon = False
        Me.MenuItem80.MenuBarItemBorderColor = System.Drawing.Color.Black
        Me.MenuItem80.MenuBarItemFillColor = System.Drawing.SystemColors.Menu
        Me.MenuItem80.MenuBarItemFillingStyle = UltimateMenus.KunalMenuItem.MenuBarFillStyles.FillColor
        Me.MenuItem80.MenuBarItemGradientColor1 = System.Drawing.SystemColors.Menu
        Me.MenuItem80.MenuBarItemGradientColor2 = System.Drawing.SystemColors.Menu
        Me.MenuItem80.MenuBarItemGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.MenuItem80.OwnerDraw = True
        Me.MenuItem80.PreDefinedHiLiteColors = UltimateMenus.KunalMenuItem.PreDefinedHighLightColors.Khaki
        Me.MenuItem80.PreDefinedHiLiteGradientColors = UltimateMenus.KunalMenuItem.PreDefinedGrHighLightColors.BrownWhite
        Me.MenuItem80.PreDefinedSideBarGradientColour = UltimateMenus.KunalMenuItem.PreDefinedSideBarGradientColors.ShineyBlueYellow
        Me.MenuItem80.ShowBorderAroundMenuBar = False
        Me.MenuItem80.ShowHiliteOverSideBar = False
        Me.MenuItem80.ShowShadowUnderMenuBar = True
        Me.MenuItem80.SideBarGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.MenuItem80.SideBarStyle = UltimateMenus.KunalMenuItem.SideBarDrawStyle.DefaultGradient
        Me.MenuItem80.Text = "&Restore"
        Me.MenuItem80.Visible = False
        '
        'MenuItem56
        '
        Me.MenuItem56.CheckedImageIndex = 0
        Me.MenuItem56.CheckedMenuItemBackColor = System.Drawing.SystemColors.Control
        Me.MenuItem56.CheckedMenuItemBorderColor = System.Drawing.SystemColors.Control
        Me.MenuItem56.CheckedMenuItemDisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(197, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(184, Byte), Integer))
        Me.MenuItem56.CheckedMenuItemIconShadowColor = System.Drawing.Color.Gray
        Me.MenuItem56.CheckedMenuItemStyle = UltimateMenus.KunalMenuItem.CheckedMenuStyles.CheckedItemDefault
        Me.MenuItem56.CheckedMenuItemTickMarkColor = System.Drawing.SystemColors.Control
        Me.MenuItem56.FillMenuBarItem = False
        Me.MenuItem56.HighLightForeColor = System.Drawing.SystemColors.HighlightText
        Me.MenuItem56.HighLightScheme = UltimateMenus.KunalMenuItem.HighLightColorDrawStyle.DefaultScheme
        Me.MenuItem56.HiliteGradientColor1 = System.Drawing.Color.WhiteSmoke
        Me.MenuItem56.HiliteGradientColor2 = System.Drawing.Color.CornflowerBlue
        Me.MenuItem56.HiLiteGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.MenuItem56.IconShadowColor = System.Drawing.Color.Gray
        Me.MenuItem56.ImageIndex = 0
        Me.MenuItem56.Index = 2
        Me.MenuItem56.MakeCheckedMenuItemIconTransparent = False
        Me.MenuItem56.MakeTransparentIcon = False
        Me.MenuItem56.MenuBarItemBorderColor = System.Drawing.Color.Black
        Me.MenuItem56.MenuBarItemFillColor = System.Drawing.SystemColors.Menu
        Me.MenuItem56.MenuBarItemFillingStyle = UltimateMenus.KunalMenuItem.MenuBarFillStyles.FillColor
        Me.MenuItem56.MenuBarItemGradientColor1 = System.Drawing.SystemColors.Menu
        Me.MenuItem56.MenuBarItemGradientColor2 = System.Drawing.SystemColors.Menu
        Me.MenuItem56.MenuBarItemGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.MenuItem56.OwnerDraw = True
        Me.MenuItem56.PreDefinedHiLiteColors = UltimateMenus.KunalMenuItem.PreDefinedHighLightColors.Khaki
        Me.MenuItem56.PreDefinedHiLiteGradientColors = UltimateMenus.KunalMenuItem.PreDefinedGrHighLightColors.BrownWhite
        Me.MenuItem56.PreDefinedSideBarGradientColour = UltimateMenus.KunalMenuItem.PreDefinedSideBarGradientColors.ShineyBlueYellow
        Me.MenuItem56.ShowBorderAroundMenuBar = False
        Me.MenuItem56.ShowHiliteOverSideBar = False
        Me.MenuItem56.ShowShadowUnderMenuBar = True
        Me.MenuItem56.SideBarGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.MenuItem56.SideBarStyle = UltimateMenus.KunalMenuItem.SideBarDrawStyle.DefaultGradient
        Me.MenuItem56.Text = "&Printer Settings"
        Me.MenuItem56.Visible = False
        '
        'MenuItem90
        '
        Me.MenuItem90.CheckedImageIndex = 0
        Me.MenuItem90.CheckedMenuItemBackColor = System.Drawing.SystemColors.Control
        Me.MenuItem90.CheckedMenuItemBorderColor = System.Drawing.SystemColors.Control
        Me.MenuItem90.CheckedMenuItemDisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(197, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(184, Byte), Integer))
        Me.MenuItem90.CheckedMenuItemIconShadowColor = System.Drawing.Color.Gray
        Me.MenuItem90.CheckedMenuItemStyle = UltimateMenus.KunalMenuItem.CheckedMenuStyles.CheckedItemDefault
        Me.MenuItem90.CheckedMenuItemTickMarkColor = System.Drawing.SystemColors.Control
        Me.MenuItem90.FillMenuBarItem = False
        Me.MenuItem90.HighLightForeColor = System.Drawing.SystemColors.HighlightText
        Me.MenuItem90.HighLightScheme = UltimateMenus.KunalMenuItem.HighLightColorDrawStyle.DefaultScheme
        Me.MenuItem90.HiliteGradientColor1 = System.Drawing.Color.WhiteSmoke
        Me.MenuItem90.HiliteGradientColor2 = System.Drawing.Color.CornflowerBlue
        Me.MenuItem90.HiLiteGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.MenuItem90.IconShadowColor = System.Drawing.Color.Gray
        Me.MenuItem90.ImageIndex = 0
        Me.MenuItem90.Index = 3
        Me.MenuItem90.MakeCheckedMenuItemIconTransparent = False
        Me.MenuItem90.MakeTransparentIcon = False
        Me.MenuItem90.MenuBarItemBorderColor = System.Drawing.Color.Black
        Me.MenuItem90.MenuBarItemFillColor = System.Drawing.SystemColors.Menu
        Me.MenuItem90.MenuBarItemFillingStyle = UltimateMenus.KunalMenuItem.MenuBarFillStyles.FillColor
        Me.MenuItem90.MenuBarItemGradientColor1 = System.Drawing.SystemColors.Menu
        Me.MenuItem90.MenuBarItemGradientColor2 = System.Drawing.SystemColors.Menu
        Me.MenuItem90.MenuBarItemGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.MenuItem90.OwnerDraw = True
        Me.MenuItem90.PreDefinedHiLiteColors = UltimateMenus.KunalMenuItem.PreDefinedHighLightColors.Khaki
        Me.MenuItem90.PreDefinedHiLiteGradientColors = UltimateMenus.KunalMenuItem.PreDefinedGrHighLightColors.BrownWhite
        Me.MenuItem90.PreDefinedSideBarGradientColour = UltimateMenus.KunalMenuItem.PreDefinedSideBarGradientColors.ShineyBlueYellow
        Me.MenuItem90.ShowBorderAroundMenuBar = False
        Me.MenuItem90.ShowHiliteOverSideBar = False
        Me.MenuItem90.ShowShadowUnderMenuBar = True
        Me.MenuItem90.SideBarGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.MenuItem90.SideBarStyle = UltimateMenus.KunalMenuItem.SideBarDrawStyle.DefaultGradient
        Me.MenuItem90.Text = "&Notepad"
        '
        'MenuItem58
        '
        Me.MenuItem58.CheckedImageIndex = 0
        Me.MenuItem58.CheckedMenuItemBackColor = System.Drawing.SystemColors.Control
        Me.MenuItem58.CheckedMenuItemBorderColor = System.Drawing.SystemColors.Control
        Me.MenuItem58.CheckedMenuItemDisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(197, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(184, Byte), Integer))
        Me.MenuItem58.CheckedMenuItemIconShadowColor = System.Drawing.Color.Gray
        Me.MenuItem58.CheckedMenuItemStyle = UltimateMenus.KunalMenuItem.CheckedMenuStyles.CheckedItemDefault
        Me.MenuItem58.CheckedMenuItemTickMarkColor = System.Drawing.SystemColors.Control
        Me.MenuItem58.FillMenuBarItem = False
        Me.MenuItem58.HighLightForeColor = System.Drawing.SystemColors.HighlightText
        Me.MenuItem58.HighLightScheme = UltimateMenus.KunalMenuItem.HighLightColorDrawStyle.DefaultScheme
        Me.MenuItem58.HiliteGradientColor1 = System.Drawing.Color.WhiteSmoke
        Me.MenuItem58.HiliteGradientColor2 = System.Drawing.Color.CornflowerBlue
        Me.MenuItem58.HiLiteGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.MenuItem58.IconShadowColor = System.Drawing.Color.Gray
        Me.MenuItem58.ImageIndex = 0
        Me.MenuItem58.Index = 4
        Me.MenuItem58.MakeCheckedMenuItemIconTransparent = False
        Me.MenuItem58.MakeTransparentIcon = False
        Me.MenuItem58.MenuBarItemBorderColor = System.Drawing.Color.Black
        Me.MenuItem58.MenuBarItemFillColor = System.Drawing.SystemColors.Menu
        Me.MenuItem58.MenuBarItemFillingStyle = UltimateMenus.KunalMenuItem.MenuBarFillStyles.FillColor
        Me.MenuItem58.MenuBarItemGradientColor1 = System.Drawing.SystemColors.Menu
        Me.MenuItem58.MenuBarItemGradientColor2 = System.Drawing.SystemColors.Menu
        Me.MenuItem58.MenuBarItemGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.MenuItem58.OwnerDraw = True
        Me.MenuItem58.PreDefinedHiLiteColors = UltimateMenus.KunalMenuItem.PreDefinedHighLightColors.Khaki
        Me.MenuItem58.PreDefinedHiLiteGradientColors = UltimateMenus.KunalMenuItem.PreDefinedGrHighLightColors.BrownWhite
        Me.MenuItem58.PreDefinedSideBarGradientColour = UltimateMenus.KunalMenuItem.PreDefinedSideBarGradientColors.ShineyBlueYellow
        Me.MenuItem58.ShowBorderAroundMenuBar = False
        Me.MenuItem58.ShowHiliteOverSideBar = False
        Me.MenuItem58.ShowShadowUnderMenuBar = True
        Me.MenuItem58.SideBarGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.MenuItem58.SideBarStyle = UltimateMenus.KunalMenuItem.SideBarDrawStyle.DefaultGradient
        Me.MenuItem58.Text = "&Calculator"
        '
        'MenuItem126
        '
        Me.MenuItem126.CheckedImageIndex = 0
        Me.MenuItem126.CheckedMenuItemBackColor = System.Drawing.SystemColors.Control
        Me.MenuItem126.CheckedMenuItemBorderColor = System.Drawing.SystemColors.Control
        Me.MenuItem126.CheckedMenuItemDisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(197, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(184, Byte), Integer))
        Me.MenuItem126.CheckedMenuItemIconShadowColor = System.Drawing.Color.Gray
        Me.MenuItem126.CheckedMenuItemStyle = UltimateMenus.KunalMenuItem.CheckedMenuStyles.CheckedItemDefault
        Me.MenuItem126.CheckedMenuItemTickMarkColor = System.Drawing.SystemColors.Control
        Me.MenuItem126.FillMenuBarItem = False
        Me.MenuItem126.HighLightForeColor = System.Drawing.SystemColors.HighlightText
        Me.MenuItem126.HighLightScheme = UltimateMenus.KunalMenuItem.HighLightColorDrawStyle.DefaultScheme
        Me.MenuItem126.HiliteGradientColor1 = System.Drawing.Color.WhiteSmoke
        Me.MenuItem126.HiliteGradientColor2 = System.Drawing.Color.CornflowerBlue
        Me.MenuItem126.HiLiteGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.MenuItem126.IconShadowColor = System.Drawing.Color.Gray
        Me.MenuItem126.ImageIndex = 0
        Me.MenuItem126.Index = 5
        Me.MenuItem126.MakeCheckedMenuItemIconTransparent = False
        Me.MenuItem126.MakeTransparentIcon = False
        Me.MenuItem126.MenuBarItemBorderColor = System.Drawing.Color.Black
        Me.MenuItem126.MenuBarItemFillColor = System.Drawing.SystemColors.Menu
        Me.MenuItem126.MenuBarItemFillingStyle = UltimateMenus.KunalMenuItem.MenuBarFillStyles.FillColor
        Me.MenuItem126.MenuBarItemGradientColor1 = System.Drawing.SystemColors.Menu
        Me.MenuItem126.MenuBarItemGradientColor2 = System.Drawing.SystemColors.Menu
        Me.MenuItem126.MenuBarItemGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.MenuItem126.OwnerDraw = True
        Me.MenuItem126.PreDefinedHiLiteColors = UltimateMenus.KunalMenuItem.PreDefinedHighLightColors.Khaki
        Me.MenuItem126.PreDefinedHiLiteGradientColors = UltimateMenus.KunalMenuItem.PreDefinedGrHighLightColors.BrownWhite
        Me.MenuItem126.PreDefinedSideBarGradientColour = UltimateMenus.KunalMenuItem.PreDefinedSideBarGradientColors.ShineyBlueYellow
        Me.MenuItem126.ShowBorderAroundMenuBar = False
        Me.MenuItem126.ShowHiliteOverSideBar = False
        Me.MenuItem126.ShowShadowUnderMenuBar = True
        Me.MenuItem126.SideBarGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.MenuItem126.SideBarStyle = UltimateMenus.KunalMenuItem.SideBarDrawStyle.DefaultGradient
        Me.MenuItem126.Text = "LoanRepayment"
        '
        'MenuItem179
        '
        Me.MenuItem179.CheckedImageIndex = 0
        Me.MenuItem179.CheckedMenuItemBackColor = System.Drawing.SystemColors.Control
        Me.MenuItem179.CheckedMenuItemBorderColor = System.Drawing.SystemColors.Control
        Me.MenuItem179.CheckedMenuItemDisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(197, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(184, Byte), Integer))
        Me.MenuItem179.CheckedMenuItemIconShadowColor = System.Drawing.Color.Gray
        Me.MenuItem179.CheckedMenuItemStyle = UltimateMenus.KunalMenuItem.CheckedMenuStyles.CheckedItemDefault
        Me.MenuItem179.CheckedMenuItemTickMarkColor = System.Drawing.SystemColors.Control
        Me.MenuItem179.FillMenuBarItem = False
        Me.MenuItem179.HighLightForeColor = System.Drawing.SystemColors.HighlightText
        Me.MenuItem179.HighLightScheme = UltimateMenus.KunalMenuItem.HighLightColorDrawStyle.DefaultScheme
        Me.MenuItem179.HiliteGradientColor1 = System.Drawing.Color.WhiteSmoke
        Me.MenuItem179.HiliteGradientColor2 = System.Drawing.Color.CornflowerBlue
        Me.MenuItem179.HiLiteGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.MenuItem179.IconShadowColor = System.Drawing.Color.Gray
        Me.MenuItem179.ImageIndex = 0
        Me.MenuItem179.Index = 6
        Me.MenuItem179.MakeCheckedMenuItemIconTransparent = False
        Me.MenuItem179.MakeTransparentIcon = False
        Me.MenuItem179.MenuBarItemBorderColor = System.Drawing.Color.Black
        Me.MenuItem179.MenuBarItemFillColor = System.Drawing.SystemColors.Menu
        Me.MenuItem179.MenuBarItemFillingStyle = UltimateMenus.KunalMenuItem.MenuBarFillStyles.FillColor
        Me.MenuItem179.MenuBarItemGradientColor1 = System.Drawing.SystemColors.Menu
        Me.MenuItem179.MenuBarItemGradientColor2 = System.Drawing.SystemColors.Menu
        Me.MenuItem179.MenuBarItemGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.MenuItem179.OwnerDraw = True
        Me.MenuItem179.PreDefinedHiLiteColors = UltimateMenus.KunalMenuItem.PreDefinedHighLightColors.Khaki
        Me.MenuItem179.PreDefinedHiLiteGradientColors = UltimateMenus.KunalMenuItem.PreDefinedGrHighLightColors.BrownWhite
        Me.MenuItem179.PreDefinedSideBarGradientColour = UltimateMenus.KunalMenuItem.PreDefinedSideBarGradientColors.ShineyBlueYellow
        Me.MenuItem179.ShowBorderAroundMenuBar = False
        Me.MenuItem179.ShowHiliteOverSideBar = False
        Me.MenuItem179.ShowShadowUnderMenuBar = True
        Me.MenuItem179.SideBarGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.MenuItem179.SideBarStyle = UltimateMenus.KunalMenuItem.SideBarDrawStyle.DefaultGradient
        Me.MenuItem179.Text = "Backup and Restore"
        '
        'MenuItem39
        '
        Me.MenuItem39.CheckedImageIndex = 0
        Me.MenuItem39.CheckedMenuItemBackColor = System.Drawing.SystemColors.Control
        Me.MenuItem39.CheckedMenuItemBorderColor = System.Drawing.SystemColors.Control
        Me.MenuItem39.CheckedMenuItemDisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(197, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(184, Byte), Integer))
        Me.MenuItem39.CheckedMenuItemIconShadowColor = System.Drawing.Color.Gray
        Me.MenuItem39.CheckedMenuItemStyle = UltimateMenus.KunalMenuItem.CheckedMenuStyles.CheckedItemDefault
        Me.MenuItem39.CheckedMenuItemTickMarkColor = System.Drawing.SystemColors.Control
        Me.MenuItem39.FillMenuBarItem = False
        Me.MenuItem39.HighLightForeColor = System.Drawing.SystemColors.HighlightText
        Me.MenuItem39.HighLightScheme = UltimateMenus.KunalMenuItem.HighLightColorDrawStyle.DefaultScheme
        Me.MenuItem39.HiliteGradientColor1 = System.Drawing.Color.WhiteSmoke
        Me.MenuItem39.HiliteGradientColor2 = System.Drawing.Color.CornflowerBlue
        Me.MenuItem39.HiLiteGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.MenuItem39.IconShadowColor = System.Drawing.Color.Gray
        Me.MenuItem39.ImageIndex = 0
        Me.MenuItem39.Index = 10
        Me.MenuItem39.MakeCheckedMenuItemIconTransparent = False
        Me.MenuItem39.MakeTransparentIcon = False
        Me.MenuItem39.MenuBarItemBorderColor = System.Drawing.Color.Black
        Me.MenuItem39.MenuBarItemFillColor = System.Drawing.SystemColors.Menu
        Me.MenuItem39.MenuBarItemFillingStyle = UltimateMenus.KunalMenuItem.MenuBarFillStyles.FillColor
        Me.MenuItem39.MenuBarItemGradientColor1 = System.Drawing.SystemColors.Menu
        Me.MenuItem39.MenuBarItemGradientColor2 = System.Drawing.SystemColors.Menu
        Me.MenuItem39.MenuBarItemGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.MenuItem39.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem40, Me.MenuItem42, Me.MenuItem48, Me.MenuItem153, Me.MenuItem154, Me.MenuItem155, Me.MenuItem156, Me.MenuItem157, Me.MenuItem171, Me.MenuItem172, Me.MenuItem173, Me.MenuItem174, Me.MenuItem175, Me.MenuItem176, Me.MenuItem177, Me.MenuItem183})
        Me.MenuItem39.OwnerDraw = True
        Me.MenuItem39.PreDefinedHiLiteColors = UltimateMenus.KunalMenuItem.PreDefinedHighLightColors.Khaki
        Me.MenuItem39.PreDefinedHiLiteGradientColors = UltimateMenus.KunalMenuItem.PreDefinedGrHighLightColors.BrownWhite
        Me.MenuItem39.PreDefinedSideBarGradientColour = UltimateMenus.KunalMenuItem.PreDefinedSideBarGradientColors.ShineyBlueYellow
        Me.MenuItem39.ShowBorderAroundMenuBar = False
        Me.MenuItem39.ShowHiliteOverSideBar = False
        Me.MenuItem39.ShowShadowUnderMenuBar = True
        Me.MenuItem39.SideBarGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.MenuItem39.SideBarStyle = UltimateMenus.KunalMenuItem.SideBarDrawStyle.DefaultGradient
        Me.MenuItem39.Text = "Reports"
        '
        'MenuItem40
        '
        Me.MenuItem40.CheckedImageIndex = 0
        Me.MenuItem40.CheckedMenuItemBackColor = System.Drawing.SystemColors.Control
        Me.MenuItem40.CheckedMenuItemBorderColor = System.Drawing.SystemColors.Control
        Me.MenuItem40.CheckedMenuItemDisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(197, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(184, Byte), Integer))
        Me.MenuItem40.CheckedMenuItemIconShadowColor = System.Drawing.Color.Gray
        Me.MenuItem40.CheckedMenuItemStyle = UltimateMenus.KunalMenuItem.CheckedMenuStyles.CheckedItemDefault
        Me.MenuItem40.CheckedMenuItemTickMarkColor = System.Drawing.SystemColors.Control
        Me.MenuItem40.FillMenuBarItem = False
        Me.MenuItem40.HighLightForeColor = System.Drawing.SystemColors.HighlightText
        Me.MenuItem40.HighLightScheme = UltimateMenus.KunalMenuItem.HighLightColorDrawStyle.DefaultScheme
        Me.MenuItem40.HiliteGradientColor1 = System.Drawing.Color.WhiteSmoke
        Me.MenuItem40.HiliteGradientColor2 = System.Drawing.Color.CornflowerBlue
        Me.MenuItem40.HiLiteGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.MenuItem40.IconShadowColor = System.Drawing.Color.Gray
        Me.MenuItem40.ImageIndex = 0
        Me.MenuItem40.Index = 0
        Me.MenuItem40.MakeCheckedMenuItemIconTransparent = False
        Me.MenuItem40.MakeTransparentIcon = False
        Me.MenuItem40.MenuBarItemBorderColor = System.Drawing.Color.Black
        Me.MenuItem40.MenuBarItemFillColor = System.Drawing.SystemColors.Menu
        Me.MenuItem40.MenuBarItemFillingStyle = UltimateMenus.KunalMenuItem.MenuBarFillStyles.FillColor
        Me.MenuItem40.MenuBarItemGradientColor1 = System.Drawing.SystemColors.Menu
        Me.MenuItem40.MenuBarItemGradientColor2 = System.Drawing.SystemColors.Menu
        Me.MenuItem40.MenuBarItemGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.MenuItem40.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem151, Me.MenuItem152})
        Me.MenuItem40.OwnerDraw = True
        Me.MenuItem40.PreDefinedHiLiteColors = UltimateMenus.KunalMenuItem.PreDefinedHighLightColors.Khaki
        Me.MenuItem40.PreDefinedHiLiteGradientColors = UltimateMenus.KunalMenuItem.PreDefinedGrHighLightColors.BrownWhite
        Me.MenuItem40.PreDefinedSideBarGradientColour = UltimateMenus.KunalMenuItem.PreDefinedSideBarGradientColors.ShineyBlueYellow
        Me.MenuItem40.ShowBorderAroundMenuBar = False
        Me.MenuItem40.ShowHiliteOverSideBar = False
        Me.MenuItem40.ShowShadowUnderMenuBar = True
        Me.MenuItem40.SideBarGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.MenuItem40.SideBarStyle = UltimateMenus.KunalMenuItem.SideBarDrawStyle.DefaultGradient
        Me.MenuItem40.Text = "Pass Book"
        '
        'MenuItem151
        '
        Me.MenuItem151.CheckedImageIndex = 0
        Me.MenuItem151.CheckedMenuItemBackColor = System.Drawing.SystemColors.Control
        Me.MenuItem151.CheckedMenuItemBorderColor = System.Drawing.SystemColors.Control
        Me.MenuItem151.CheckedMenuItemDisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(197, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(184, Byte), Integer))
        Me.MenuItem151.CheckedMenuItemIconShadowColor = System.Drawing.Color.Gray
        Me.MenuItem151.CheckedMenuItemStyle = UltimateMenus.KunalMenuItem.CheckedMenuStyles.CheckedItemDefault
        Me.MenuItem151.CheckedMenuItemTickMarkColor = System.Drawing.SystemColors.Control
        Me.MenuItem151.FillMenuBarItem = False
        Me.MenuItem151.HighLightForeColor = System.Drawing.SystemColors.HighlightText
        Me.MenuItem151.HighLightScheme = UltimateMenus.KunalMenuItem.HighLightColorDrawStyle.DefaultScheme
        Me.MenuItem151.HiliteGradientColor1 = System.Drawing.Color.WhiteSmoke
        Me.MenuItem151.HiliteGradientColor2 = System.Drawing.Color.CornflowerBlue
        Me.MenuItem151.HiLiteGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.MenuItem151.IconShadowColor = System.Drawing.Color.Gray
        Me.MenuItem151.ImageIndex = 0
        Me.MenuItem151.Index = 0
        Me.MenuItem151.MakeCheckedMenuItemIconTransparent = False
        Me.MenuItem151.MakeTransparentIcon = False
        Me.MenuItem151.MenuBarItemBorderColor = System.Drawing.Color.Black
        Me.MenuItem151.MenuBarItemFillColor = System.Drawing.SystemColors.Menu
        Me.MenuItem151.MenuBarItemFillingStyle = UltimateMenus.KunalMenuItem.MenuBarFillStyles.FillColor
        Me.MenuItem151.MenuBarItemGradientColor1 = System.Drawing.SystemColors.Menu
        Me.MenuItem151.MenuBarItemGradientColor2 = System.Drawing.SystemColors.Menu
        Me.MenuItem151.MenuBarItemGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.MenuItem151.OwnerDraw = True
        Me.MenuItem151.PreDefinedHiLiteColors = UltimateMenus.KunalMenuItem.PreDefinedHighLightColors.Khaki
        Me.MenuItem151.PreDefinedHiLiteGradientColors = UltimateMenus.KunalMenuItem.PreDefinedGrHighLightColors.BrownWhite
        Me.MenuItem151.PreDefinedSideBarGradientColour = UltimateMenus.KunalMenuItem.PreDefinedSideBarGradientColors.ShineyBlueYellow
        Me.MenuItem151.ShowBorderAroundMenuBar = False
        Me.MenuItem151.ShowHiliteOverSideBar = False
        Me.MenuItem151.ShowShadowUnderMenuBar = True
        Me.MenuItem151.SideBarGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.MenuItem151.SideBarStyle = UltimateMenus.KunalMenuItem.SideBarDrawStyle.DefaultGradient
        Me.MenuItem151.Text = "Saving Account"
        '
        'MenuItem152
        '
        Me.MenuItem152.CheckedImageIndex = 0
        Me.MenuItem152.CheckedMenuItemBackColor = System.Drawing.SystemColors.Control
        Me.MenuItem152.CheckedMenuItemBorderColor = System.Drawing.SystemColors.Control
        Me.MenuItem152.CheckedMenuItemDisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(197, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(184, Byte), Integer))
        Me.MenuItem152.CheckedMenuItemIconShadowColor = System.Drawing.Color.Gray
        Me.MenuItem152.CheckedMenuItemStyle = UltimateMenus.KunalMenuItem.CheckedMenuStyles.CheckedItemDefault
        Me.MenuItem152.CheckedMenuItemTickMarkColor = System.Drawing.SystemColors.Control
        Me.MenuItem152.FillMenuBarItem = False
        Me.MenuItem152.HighLightForeColor = System.Drawing.SystemColors.HighlightText
        Me.MenuItem152.HighLightScheme = UltimateMenus.KunalMenuItem.HighLightColorDrawStyle.DefaultScheme
        Me.MenuItem152.HiliteGradientColor1 = System.Drawing.Color.WhiteSmoke
        Me.MenuItem152.HiliteGradientColor2 = System.Drawing.Color.CornflowerBlue
        Me.MenuItem152.HiLiteGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.MenuItem152.IconShadowColor = System.Drawing.Color.Gray
        Me.MenuItem152.ImageIndex = 0
        Me.MenuItem152.Index = 1
        Me.MenuItem152.MakeCheckedMenuItemIconTransparent = False
        Me.MenuItem152.MakeTransparentIcon = False
        Me.MenuItem152.MenuBarItemBorderColor = System.Drawing.Color.Black
        Me.MenuItem152.MenuBarItemFillColor = System.Drawing.SystemColors.Menu
        Me.MenuItem152.MenuBarItemFillingStyle = UltimateMenus.KunalMenuItem.MenuBarFillStyles.FillColor
        Me.MenuItem152.MenuBarItemGradientColor1 = System.Drawing.SystemColors.Menu
        Me.MenuItem152.MenuBarItemGradientColor2 = System.Drawing.SystemColors.Menu
        Me.MenuItem152.MenuBarItemGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.MenuItem152.OwnerDraw = True
        Me.MenuItem152.PreDefinedHiLiteColors = UltimateMenus.KunalMenuItem.PreDefinedHighLightColors.Khaki
        Me.MenuItem152.PreDefinedHiLiteGradientColors = UltimateMenus.KunalMenuItem.PreDefinedGrHighLightColors.BrownWhite
        Me.MenuItem152.PreDefinedSideBarGradientColour = UltimateMenus.KunalMenuItem.PreDefinedSideBarGradientColors.ShineyBlueYellow
        Me.MenuItem152.ShowBorderAroundMenuBar = False
        Me.MenuItem152.ShowHiliteOverSideBar = False
        Me.MenuItem152.ShowShadowUnderMenuBar = True
        Me.MenuItem152.SideBarGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.MenuItem152.SideBarStyle = UltimateMenus.KunalMenuItem.SideBarDrawStyle.DefaultGradient
        Me.MenuItem152.Text = "Current Account"
        '
        'MenuItem42
        '
        Me.MenuItem42.CheckedImageIndex = 0
        Me.MenuItem42.CheckedMenuItemBackColor = System.Drawing.SystemColors.Control
        Me.MenuItem42.CheckedMenuItemBorderColor = System.Drawing.SystemColors.Control
        Me.MenuItem42.CheckedMenuItemDisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(197, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(184, Byte), Integer))
        Me.MenuItem42.CheckedMenuItemIconShadowColor = System.Drawing.Color.Gray
        Me.MenuItem42.CheckedMenuItemStyle = UltimateMenus.KunalMenuItem.CheckedMenuStyles.CheckedItemDefault
        Me.MenuItem42.CheckedMenuItemTickMarkColor = System.Drawing.SystemColors.Control
        Me.MenuItem42.FillMenuBarItem = False
        Me.MenuItem42.HighLightForeColor = System.Drawing.SystemColors.HighlightText
        Me.MenuItem42.HighLightScheme = UltimateMenus.KunalMenuItem.HighLightColorDrawStyle.DefaultScheme
        Me.MenuItem42.HiliteGradientColor1 = System.Drawing.Color.WhiteSmoke
        Me.MenuItem42.HiliteGradientColor2 = System.Drawing.Color.CornflowerBlue
        Me.MenuItem42.HiLiteGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.MenuItem42.IconShadowColor = System.Drawing.Color.Gray
        Me.MenuItem42.ImageIndex = 0
        Me.MenuItem42.Index = 1
        Me.MenuItem42.MakeCheckedMenuItemIconTransparent = False
        Me.MenuItem42.MakeTransparentIcon = False
        Me.MenuItem42.MenuBarItemBorderColor = System.Drawing.Color.Black
        Me.MenuItem42.MenuBarItemFillColor = System.Drawing.SystemColors.Menu
        Me.MenuItem42.MenuBarItemFillingStyle = UltimateMenus.KunalMenuItem.MenuBarFillStyles.FillColor
        Me.MenuItem42.MenuBarItemGradientColor1 = System.Drawing.SystemColors.Menu
        Me.MenuItem42.MenuBarItemGradientColor2 = System.Drawing.SystemColors.Menu
        Me.MenuItem42.MenuBarItemGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.MenuItem42.OwnerDraw = True
        Me.MenuItem42.PreDefinedHiLiteColors = UltimateMenus.KunalMenuItem.PreDefinedHighLightColors.Khaki
        Me.MenuItem42.PreDefinedHiLiteGradientColors = UltimateMenus.KunalMenuItem.PreDefinedGrHighLightColors.BrownWhite
        Me.MenuItem42.PreDefinedSideBarGradientColour = UltimateMenus.KunalMenuItem.PreDefinedSideBarGradientColors.ShineyBlueYellow
        Me.MenuItem42.ShowBorderAroundMenuBar = False
        Me.MenuItem42.ShowHiliteOverSideBar = False
        Me.MenuItem42.ShowShadowUnderMenuBar = True
        Me.MenuItem42.SideBarGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.MenuItem42.SideBarStyle = UltimateMenus.KunalMenuItem.SideBarDrawStyle.DefaultGradient
        Me.MenuItem42.Text = "OD Statement"
        '
        'MenuItem48
        '
        Me.MenuItem48.CheckedImageIndex = 0
        Me.MenuItem48.CheckedMenuItemBackColor = System.Drawing.SystemColors.Control
        Me.MenuItem48.CheckedMenuItemBorderColor = System.Drawing.SystemColors.Control
        Me.MenuItem48.CheckedMenuItemDisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(197, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(184, Byte), Integer))
        Me.MenuItem48.CheckedMenuItemIconShadowColor = System.Drawing.Color.Gray
        Me.MenuItem48.CheckedMenuItemStyle = UltimateMenus.KunalMenuItem.CheckedMenuStyles.CheckedItemDefault
        Me.MenuItem48.CheckedMenuItemTickMarkColor = System.Drawing.SystemColors.Control
        Me.MenuItem48.FillMenuBarItem = False
        Me.MenuItem48.HighLightForeColor = System.Drawing.SystemColors.HighlightText
        Me.MenuItem48.HighLightScheme = UltimateMenus.KunalMenuItem.HighLightColorDrawStyle.DefaultScheme
        Me.MenuItem48.HiliteGradientColor1 = System.Drawing.Color.WhiteSmoke
        Me.MenuItem48.HiliteGradientColor2 = System.Drawing.Color.CornflowerBlue
        Me.MenuItem48.HiLiteGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.MenuItem48.IconShadowColor = System.Drawing.Color.Gray
        Me.MenuItem48.ImageIndex = 0
        Me.MenuItem48.Index = 2
        Me.MenuItem48.MakeCheckedMenuItemIconTransparent = False
        Me.MenuItem48.MakeTransparentIcon = False
        Me.MenuItem48.MenuBarItemBorderColor = System.Drawing.Color.Black
        Me.MenuItem48.MenuBarItemFillColor = System.Drawing.SystemColors.Menu
        Me.MenuItem48.MenuBarItemFillingStyle = UltimateMenus.KunalMenuItem.MenuBarFillStyles.FillColor
        Me.MenuItem48.MenuBarItemGradientColor1 = System.Drawing.SystemColors.Menu
        Me.MenuItem48.MenuBarItemGradientColor2 = System.Drawing.SystemColors.Menu
        Me.MenuItem48.MenuBarItemGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.MenuItem48.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem158, Me.MenuItem159})
        Me.MenuItem48.OwnerDraw = True
        Me.MenuItem48.PreDefinedHiLiteColors = UltimateMenus.KunalMenuItem.PreDefinedHighLightColors.Khaki
        Me.MenuItem48.PreDefinedHiLiteGradientColors = UltimateMenus.KunalMenuItem.PreDefinedGrHighLightColors.BrownWhite
        Me.MenuItem48.PreDefinedSideBarGradientColour = UltimateMenus.KunalMenuItem.PreDefinedSideBarGradientColors.ShineyBlueYellow
        Me.MenuItem48.ShowBorderAroundMenuBar = False
        Me.MenuItem48.ShowHiliteOverSideBar = False
        Me.MenuItem48.ShowShadowUnderMenuBar = True
        Me.MenuItem48.SideBarGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.MenuItem48.SideBarStyle = UltimateMenus.KunalMenuItem.SideBarDrawStyle.DefaultGradient
        Me.MenuItem48.Text = "Fixed Deposit"
        '
        'MenuItem158
        '
        Me.MenuItem158.CheckedImageIndex = 0
        Me.MenuItem158.CheckedMenuItemBackColor = System.Drawing.SystemColors.Control
        Me.MenuItem158.CheckedMenuItemBorderColor = System.Drawing.SystemColors.Control
        Me.MenuItem158.CheckedMenuItemDisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(197, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(184, Byte), Integer))
        Me.MenuItem158.CheckedMenuItemIconShadowColor = System.Drawing.Color.Gray
        Me.MenuItem158.CheckedMenuItemStyle = UltimateMenus.KunalMenuItem.CheckedMenuStyles.CheckedItemDefault
        Me.MenuItem158.CheckedMenuItemTickMarkColor = System.Drawing.SystemColors.Control
        Me.MenuItem158.FillMenuBarItem = False
        Me.MenuItem158.HighLightForeColor = System.Drawing.SystemColors.HighlightText
        Me.MenuItem158.HighLightScheme = UltimateMenus.KunalMenuItem.HighLightColorDrawStyle.DefaultScheme
        Me.MenuItem158.HiliteGradientColor1 = System.Drawing.Color.WhiteSmoke
        Me.MenuItem158.HiliteGradientColor2 = System.Drawing.Color.CornflowerBlue
        Me.MenuItem158.HiLiteGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.MenuItem158.IconShadowColor = System.Drawing.Color.Gray
        Me.MenuItem158.ImageIndex = 0
        Me.MenuItem158.Index = 0
        Me.MenuItem158.MakeCheckedMenuItemIconTransparent = False
        Me.MenuItem158.MakeTransparentIcon = False
        Me.MenuItem158.MenuBarItemBorderColor = System.Drawing.Color.Black
        Me.MenuItem158.MenuBarItemFillColor = System.Drawing.SystemColors.Menu
        Me.MenuItem158.MenuBarItemFillingStyle = UltimateMenus.KunalMenuItem.MenuBarFillStyles.FillColor
        Me.MenuItem158.MenuBarItemGradientColor1 = System.Drawing.SystemColors.Menu
        Me.MenuItem158.MenuBarItemGradientColor2 = System.Drawing.SystemColors.Menu
        Me.MenuItem158.MenuBarItemGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.MenuItem158.OwnerDraw = True
        Me.MenuItem158.PreDefinedHiLiteColors = UltimateMenus.KunalMenuItem.PreDefinedHighLightColors.Khaki
        Me.MenuItem158.PreDefinedHiLiteGradientColors = UltimateMenus.KunalMenuItem.PreDefinedGrHighLightColors.BrownWhite
        Me.MenuItem158.PreDefinedSideBarGradientColour = UltimateMenus.KunalMenuItem.PreDefinedSideBarGradientColors.ShineyBlueYellow
        Me.MenuItem158.ShowBorderAroundMenuBar = False
        Me.MenuItem158.ShowHiliteOverSideBar = False
        Me.MenuItem158.ShowShadowUnderMenuBar = True
        Me.MenuItem158.SideBarGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.MenuItem158.SideBarStyle = UltimateMenus.KunalMenuItem.SideBarDrawStyle.DefaultGradient
        Me.MenuItem158.Text = "Bound"
        '
        'MenuItem159
        '
        Me.MenuItem159.CheckedImageIndex = 0
        Me.MenuItem159.CheckedMenuItemBackColor = System.Drawing.SystemColors.Control
        Me.MenuItem159.CheckedMenuItemBorderColor = System.Drawing.SystemColors.Control
        Me.MenuItem159.CheckedMenuItemDisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(197, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(184, Byte), Integer))
        Me.MenuItem159.CheckedMenuItemIconShadowColor = System.Drawing.Color.Gray
        Me.MenuItem159.CheckedMenuItemStyle = UltimateMenus.KunalMenuItem.CheckedMenuStyles.CheckedItemDefault
        Me.MenuItem159.CheckedMenuItemTickMarkColor = System.Drawing.SystemColors.Control
        Me.MenuItem159.FillMenuBarItem = False
        Me.MenuItem159.HighLightForeColor = System.Drawing.SystemColors.HighlightText
        Me.MenuItem159.HighLightScheme = UltimateMenus.KunalMenuItem.HighLightColorDrawStyle.DefaultScheme
        Me.MenuItem159.HiliteGradientColor1 = System.Drawing.Color.WhiteSmoke
        Me.MenuItem159.HiliteGradientColor2 = System.Drawing.Color.CornflowerBlue
        Me.MenuItem159.HiLiteGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.MenuItem159.IconShadowColor = System.Drawing.Color.Gray
        Me.MenuItem159.ImageIndex = 0
        Me.MenuItem159.Index = 1
        Me.MenuItem159.MakeCheckedMenuItemIconTransparent = False
        Me.MenuItem159.MakeTransparentIcon = False
        Me.MenuItem159.MenuBarItemBorderColor = System.Drawing.Color.Black
        Me.MenuItem159.MenuBarItemFillColor = System.Drawing.SystemColors.Menu
        Me.MenuItem159.MenuBarItemFillingStyle = UltimateMenus.KunalMenuItem.MenuBarFillStyles.FillColor
        Me.MenuItem159.MenuBarItemGradientColor1 = System.Drawing.SystemColors.Menu
        Me.MenuItem159.MenuBarItemGradientColor2 = System.Drawing.SystemColors.Menu
        Me.MenuItem159.MenuBarItemGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.MenuItem159.OwnerDraw = True
        Me.MenuItem159.PreDefinedHiLiteColors = UltimateMenus.KunalMenuItem.PreDefinedHighLightColors.Khaki
        Me.MenuItem159.PreDefinedHiLiteGradientColors = UltimateMenus.KunalMenuItem.PreDefinedGrHighLightColors.BrownWhite
        Me.MenuItem159.PreDefinedSideBarGradientColour = UltimateMenus.KunalMenuItem.PreDefinedSideBarGradientColors.ShineyBlueYellow
        Me.MenuItem159.ShowBorderAroundMenuBar = False
        Me.MenuItem159.ShowHiliteOverSideBar = False
        Me.MenuItem159.ShowShadowUnderMenuBar = True
        Me.MenuItem159.SideBarGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.MenuItem159.SideBarStyle = UltimateMenus.KunalMenuItem.SideBarDrawStyle.DefaultGradient
        Me.MenuItem159.Text = "Periodic Statement"
        '
        'MenuItem153
        '
        Me.MenuItem153.CheckedImageIndex = 0
        Me.MenuItem153.CheckedMenuItemBackColor = System.Drawing.SystemColors.Control
        Me.MenuItem153.CheckedMenuItemBorderColor = System.Drawing.SystemColors.Control
        Me.MenuItem153.CheckedMenuItemDisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(197, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(184, Byte), Integer))
        Me.MenuItem153.CheckedMenuItemIconShadowColor = System.Drawing.Color.Gray
        Me.MenuItem153.CheckedMenuItemStyle = UltimateMenus.KunalMenuItem.CheckedMenuStyles.CheckedItemDefault
        Me.MenuItem153.CheckedMenuItemTickMarkColor = System.Drawing.SystemColors.Control
        Me.MenuItem153.FillMenuBarItem = False
        Me.MenuItem153.HighLightForeColor = System.Drawing.SystemColors.HighlightText
        Me.MenuItem153.HighLightScheme = UltimateMenus.KunalMenuItem.HighLightColorDrawStyle.DefaultScheme
        Me.MenuItem153.HiliteGradientColor1 = System.Drawing.Color.WhiteSmoke
        Me.MenuItem153.HiliteGradientColor2 = System.Drawing.Color.CornflowerBlue
        Me.MenuItem153.HiLiteGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.MenuItem153.IconShadowColor = System.Drawing.Color.Gray
        Me.MenuItem153.ImageIndex = 0
        Me.MenuItem153.Index = 3
        Me.MenuItem153.MakeCheckedMenuItemIconTransparent = False
        Me.MenuItem153.MakeTransparentIcon = False
        Me.MenuItem153.MenuBarItemBorderColor = System.Drawing.Color.Black
        Me.MenuItem153.MenuBarItemFillColor = System.Drawing.SystemColors.Menu
        Me.MenuItem153.MenuBarItemFillingStyle = UltimateMenus.KunalMenuItem.MenuBarFillStyles.FillColor
        Me.MenuItem153.MenuBarItemGradientColor1 = System.Drawing.SystemColors.Menu
        Me.MenuItem153.MenuBarItemGradientColor2 = System.Drawing.SystemColors.Menu
        Me.MenuItem153.MenuBarItemGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.MenuItem153.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem160, Me.MenuItem161, Me.MenuItem162})
        Me.MenuItem153.OwnerDraw = True
        Me.MenuItem153.PreDefinedHiLiteColors = UltimateMenus.KunalMenuItem.PreDefinedHighLightColors.Khaki
        Me.MenuItem153.PreDefinedHiLiteGradientColors = UltimateMenus.KunalMenuItem.PreDefinedGrHighLightColors.BrownWhite
        Me.MenuItem153.PreDefinedSideBarGradientColour = UltimateMenus.KunalMenuItem.PreDefinedSideBarGradientColors.ShineyBlueYellow
        Me.MenuItem153.ShowBorderAroundMenuBar = False
        Me.MenuItem153.ShowHiliteOverSideBar = False
        Me.MenuItem153.ShowShadowUnderMenuBar = True
        Me.MenuItem153.SideBarGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.MenuItem153.SideBarStyle = UltimateMenus.KunalMenuItem.SideBarDrawStyle.DefaultGradient
        Me.MenuItem153.Text = "Voucher List"
        '
        'MenuItem160
        '
        Me.MenuItem160.CheckedImageIndex = 0
        Me.MenuItem160.CheckedMenuItemBackColor = System.Drawing.SystemColors.Control
        Me.MenuItem160.CheckedMenuItemBorderColor = System.Drawing.SystemColors.Control
        Me.MenuItem160.CheckedMenuItemDisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(197, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(184, Byte), Integer))
        Me.MenuItem160.CheckedMenuItemIconShadowColor = System.Drawing.Color.Gray
        Me.MenuItem160.CheckedMenuItemStyle = UltimateMenus.KunalMenuItem.CheckedMenuStyles.CheckedItemDefault
        Me.MenuItem160.CheckedMenuItemTickMarkColor = System.Drawing.SystemColors.Control
        Me.MenuItem160.FillMenuBarItem = False
        Me.MenuItem160.HighLightForeColor = System.Drawing.SystemColors.HighlightText
        Me.MenuItem160.HighLightScheme = UltimateMenus.KunalMenuItem.HighLightColorDrawStyle.DefaultScheme
        Me.MenuItem160.HiliteGradientColor1 = System.Drawing.Color.WhiteSmoke
        Me.MenuItem160.HiliteGradientColor2 = System.Drawing.Color.CornflowerBlue
        Me.MenuItem160.HiLiteGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.MenuItem160.IconShadowColor = System.Drawing.Color.Gray
        Me.MenuItem160.ImageIndex = 0
        Me.MenuItem160.Index = 0
        Me.MenuItem160.MakeCheckedMenuItemIconTransparent = False
        Me.MenuItem160.MakeTransparentIcon = False
        Me.MenuItem160.MenuBarItemBorderColor = System.Drawing.Color.Black
        Me.MenuItem160.MenuBarItemFillColor = System.Drawing.SystemColors.Menu
        Me.MenuItem160.MenuBarItemFillingStyle = UltimateMenus.KunalMenuItem.MenuBarFillStyles.FillColor
        Me.MenuItem160.MenuBarItemGradientColor1 = System.Drawing.SystemColors.Menu
        Me.MenuItem160.MenuBarItemGradientColor2 = System.Drawing.SystemColors.Menu
        Me.MenuItem160.MenuBarItemGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.MenuItem160.OwnerDraw = True
        Me.MenuItem160.PreDefinedHiLiteColors = UltimateMenus.KunalMenuItem.PreDefinedHighLightColors.Khaki
        Me.MenuItem160.PreDefinedHiLiteGradientColors = UltimateMenus.KunalMenuItem.PreDefinedGrHighLightColors.BrownWhite
        Me.MenuItem160.PreDefinedSideBarGradientColour = UltimateMenus.KunalMenuItem.PreDefinedSideBarGradientColors.ShineyBlueYellow
        Me.MenuItem160.ShowBorderAroundMenuBar = False
        Me.MenuItem160.ShowHiliteOverSideBar = False
        Me.MenuItem160.ShowShadowUnderMenuBar = True
        Me.MenuItem160.SideBarGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.MenuItem160.SideBarStyle = UltimateMenus.KunalMenuItem.SideBarDrawStyle.DefaultGradient
        Me.MenuItem160.Text = "Payment"
        '
        'MenuItem161
        '
        Me.MenuItem161.CheckedImageIndex = 0
        Me.MenuItem161.CheckedMenuItemBackColor = System.Drawing.SystemColors.Control
        Me.MenuItem161.CheckedMenuItemBorderColor = System.Drawing.SystemColors.Control
        Me.MenuItem161.CheckedMenuItemDisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(197, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(184, Byte), Integer))
        Me.MenuItem161.CheckedMenuItemIconShadowColor = System.Drawing.Color.Gray
        Me.MenuItem161.CheckedMenuItemStyle = UltimateMenus.KunalMenuItem.CheckedMenuStyles.CheckedItemDefault
        Me.MenuItem161.CheckedMenuItemTickMarkColor = System.Drawing.SystemColors.Control
        Me.MenuItem161.FillMenuBarItem = False
        Me.MenuItem161.HighLightForeColor = System.Drawing.SystemColors.HighlightText
        Me.MenuItem161.HighLightScheme = UltimateMenus.KunalMenuItem.HighLightColorDrawStyle.DefaultScheme
        Me.MenuItem161.HiliteGradientColor1 = System.Drawing.Color.WhiteSmoke
        Me.MenuItem161.HiliteGradientColor2 = System.Drawing.Color.CornflowerBlue
        Me.MenuItem161.HiLiteGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.MenuItem161.IconShadowColor = System.Drawing.Color.Gray
        Me.MenuItem161.ImageIndex = 0
        Me.MenuItem161.Index = 1
        Me.MenuItem161.MakeCheckedMenuItemIconTransparent = False
        Me.MenuItem161.MakeTransparentIcon = False
        Me.MenuItem161.MenuBarItemBorderColor = System.Drawing.Color.Black
        Me.MenuItem161.MenuBarItemFillColor = System.Drawing.SystemColors.Menu
        Me.MenuItem161.MenuBarItemFillingStyle = UltimateMenus.KunalMenuItem.MenuBarFillStyles.FillColor
        Me.MenuItem161.MenuBarItemGradientColor1 = System.Drawing.SystemColors.Menu
        Me.MenuItem161.MenuBarItemGradientColor2 = System.Drawing.SystemColors.Menu
        Me.MenuItem161.MenuBarItemGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.MenuItem161.OwnerDraw = True
        Me.MenuItem161.PreDefinedHiLiteColors = UltimateMenus.KunalMenuItem.PreDefinedHighLightColors.Khaki
        Me.MenuItem161.PreDefinedHiLiteGradientColors = UltimateMenus.KunalMenuItem.PreDefinedGrHighLightColors.BrownWhite
        Me.MenuItem161.PreDefinedSideBarGradientColour = UltimateMenus.KunalMenuItem.PreDefinedSideBarGradientColors.ShineyBlueYellow
        Me.MenuItem161.ShowBorderAroundMenuBar = False
        Me.MenuItem161.ShowHiliteOverSideBar = False
        Me.MenuItem161.ShowShadowUnderMenuBar = True
        Me.MenuItem161.SideBarGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.MenuItem161.SideBarStyle = UltimateMenus.KunalMenuItem.SideBarDrawStyle.DefaultGradient
        Me.MenuItem161.Text = "Deposit"
        '
        'MenuItem162
        '
        Me.MenuItem162.CheckedImageIndex = 0
        Me.MenuItem162.CheckedMenuItemBackColor = System.Drawing.SystemColors.Control
        Me.MenuItem162.CheckedMenuItemBorderColor = System.Drawing.SystemColors.Control
        Me.MenuItem162.CheckedMenuItemDisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(197, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(184, Byte), Integer))
        Me.MenuItem162.CheckedMenuItemIconShadowColor = System.Drawing.Color.Gray
        Me.MenuItem162.CheckedMenuItemStyle = UltimateMenus.KunalMenuItem.CheckedMenuStyles.CheckedItemDefault
        Me.MenuItem162.CheckedMenuItemTickMarkColor = System.Drawing.SystemColors.Control
        Me.MenuItem162.FillMenuBarItem = False
        Me.MenuItem162.HighLightForeColor = System.Drawing.SystemColors.HighlightText
        Me.MenuItem162.HighLightScheme = UltimateMenus.KunalMenuItem.HighLightColorDrawStyle.DefaultScheme
        Me.MenuItem162.HiliteGradientColor1 = System.Drawing.Color.WhiteSmoke
        Me.MenuItem162.HiliteGradientColor2 = System.Drawing.Color.CornflowerBlue
        Me.MenuItem162.HiLiteGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.MenuItem162.IconShadowColor = System.Drawing.Color.Gray
        Me.MenuItem162.ImageIndex = 0
        Me.MenuItem162.Index = 2
        Me.MenuItem162.MakeCheckedMenuItemIconTransparent = False
        Me.MenuItem162.MakeTransparentIcon = False
        Me.MenuItem162.MenuBarItemBorderColor = System.Drawing.Color.Black
        Me.MenuItem162.MenuBarItemFillColor = System.Drawing.SystemColors.Menu
        Me.MenuItem162.MenuBarItemFillingStyle = UltimateMenus.KunalMenuItem.MenuBarFillStyles.FillColor
        Me.MenuItem162.MenuBarItemGradientColor1 = System.Drawing.SystemColors.Menu
        Me.MenuItem162.MenuBarItemGradientColor2 = System.Drawing.SystemColors.Menu
        Me.MenuItem162.MenuBarItemGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.MenuItem162.OwnerDraw = True
        Me.MenuItem162.PreDefinedHiLiteColors = UltimateMenus.KunalMenuItem.PreDefinedHighLightColors.Khaki
        Me.MenuItem162.PreDefinedHiLiteGradientColors = UltimateMenus.KunalMenuItem.PreDefinedGrHighLightColors.BrownWhite
        Me.MenuItem162.PreDefinedSideBarGradientColour = UltimateMenus.KunalMenuItem.PreDefinedSideBarGradientColors.ShineyBlueYellow
        Me.MenuItem162.ShowBorderAroundMenuBar = False
        Me.MenuItem162.ShowHiliteOverSideBar = False
        Me.MenuItem162.ShowShadowUnderMenuBar = True
        Me.MenuItem162.SideBarGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.MenuItem162.SideBarStyle = UltimateMenus.KunalMenuItem.SideBarDrawStyle.DefaultGradient
        Me.MenuItem162.Text = "Transfer"
        '
        'MenuItem154
        '
        Me.MenuItem154.CheckedImageIndex = 0
        Me.MenuItem154.CheckedMenuItemBackColor = System.Drawing.SystemColors.Control
        Me.MenuItem154.CheckedMenuItemBorderColor = System.Drawing.SystemColors.Control
        Me.MenuItem154.CheckedMenuItemDisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(197, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(184, Byte), Integer))
        Me.MenuItem154.CheckedMenuItemIconShadowColor = System.Drawing.Color.Gray
        Me.MenuItem154.CheckedMenuItemStyle = UltimateMenus.KunalMenuItem.CheckedMenuStyles.CheckedItemDefault
        Me.MenuItem154.CheckedMenuItemTickMarkColor = System.Drawing.SystemColors.Control
        Me.MenuItem154.FillMenuBarItem = False
        Me.MenuItem154.HighLightForeColor = System.Drawing.SystemColors.HighlightText
        Me.MenuItem154.HighLightScheme = UltimateMenus.KunalMenuItem.HighLightColorDrawStyle.DefaultScheme
        Me.MenuItem154.HiliteGradientColor1 = System.Drawing.Color.WhiteSmoke
        Me.MenuItem154.HiliteGradientColor2 = System.Drawing.Color.CornflowerBlue
        Me.MenuItem154.HiLiteGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.MenuItem154.IconShadowColor = System.Drawing.Color.Gray
        Me.MenuItem154.ImageIndex = 0
        Me.MenuItem154.Index = 4
        Me.MenuItem154.MakeCheckedMenuItemIconTransparent = False
        Me.MenuItem154.MakeTransparentIcon = False
        Me.MenuItem154.MenuBarItemBorderColor = System.Drawing.Color.Black
        Me.MenuItem154.MenuBarItemFillColor = System.Drawing.SystemColors.Menu
        Me.MenuItem154.MenuBarItemFillingStyle = UltimateMenus.KunalMenuItem.MenuBarFillStyles.FillColor
        Me.MenuItem154.MenuBarItemGradientColor1 = System.Drawing.SystemColors.Menu
        Me.MenuItem154.MenuBarItemGradientColor2 = System.Drawing.SystemColors.Menu
        Me.MenuItem154.MenuBarItemGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.MenuItem154.OwnerDraw = True
        Me.MenuItem154.PreDefinedHiLiteColors = UltimateMenus.KunalMenuItem.PreDefinedHighLightColors.Khaki
        Me.MenuItem154.PreDefinedHiLiteGradientColors = UltimateMenus.KunalMenuItem.PreDefinedGrHighLightColors.BrownWhite
        Me.MenuItem154.PreDefinedSideBarGradientColour = UltimateMenus.KunalMenuItem.PreDefinedSideBarGradientColors.ShineyBlueYellow
        Me.MenuItem154.ShowBorderAroundMenuBar = False
        Me.MenuItem154.ShowHiliteOverSideBar = False
        Me.MenuItem154.ShowShadowUnderMenuBar = True
        Me.MenuItem154.SideBarGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.MenuItem154.SideBarStyle = UltimateMenus.KunalMenuItem.SideBarDrawStyle.DefaultGradient
        Me.MenuItem154.Text = "Loan Statement"
        '
        'MenuItem155
        '
        Me.MenuItem155.CheckedImageIndex = 0
        Me.MenuItem155.CheckedMenuItemBackColor = System.Drawing.SystemColors.Control
        Me.MenuItem155.CheckedMenuItemBorderColor = System.Drawing.SystemColors.Control
        Me.MenuItem155.CheckedMenuItemDisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(197, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(184, Byte), Integer))
        Me.MenuItem155.CheckedMenuItemIconShadowColor = System.Drawing.Color.Gray
        Me.MenuItem155.CheckedMenuItemStyle = UltimateMenus.KunalMenuItem.CheckedMenuStyles.CheckedItemDefault
        Me.MenuItem155.CheckedMenuItemTickMarkColor = System.Drawing.SystemColors.Control
        Me.MenuItem155.FillMenuBarItem = False
        Me.MenuItem155.HighLightForeColor = System.Drawing.SystemColors.HighlightText
        Me.MenuItem155.HighLightScheme = UltimateMenus.KunalMenuItem.HighLightColorDrawStyle.DefaultScheme
        Me.MenuItem155.HiliteGradientColor1 = System.Drawing.Color.WhiteSmoke
        Me.MenuItem155.HiliteGradientColor2 = System.Drawing.Color.CornflowerBlue
        Me.MenuItem155.HiLiteGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.MenuItem155.IconShadowColor = System.Drawing.Color.Gray
        Me.MenuItem155.ImageIndex = 0
        Me.MenuItem155.Index = 5
        Me.MenuItem155.MakeCheckedMenuItemIconTransparent = False
        Me.MenuItem155.MakeTransparentIcon = False
        Me.MenuItem155.MenuBarItemBorderColor = System.Drawing.Color.Black
        Me.MenuItem155.MenuBarItemFillColor = System.Drawing.SystemColors.Menu
        Me.MenuItem155.MenuBarItemFillingStyle = UltimateMenus.KunalMenuItem.MenuBarFillStyles.FillColor
        Me.MenuItem155.MenuBarItemGradientColor1 = System.Drawing.SystemColors.Menu
        Me.MenuItem155.MenuBarItemGradientColor2 = System.Drawing.SystemColors.Menu
        Me.MenuItem155.MenuBarItemGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.MenuItem155.OwnerDraw = True
        Me.MenuItem155.PreDefinedHiLiteColors = UltimateMenus.KunalMenuItem.PreDefinedHighLightColors.Khaki
        Me.MenuItem155.PreDefinedHiLiteGradientColors = UltimateMenus.KunalMenuItem.PreDefinedGrHighLightColors.BrownWhite
        Me.MenuItem155.PreDefinedSideBarGradientColour = UltimateMenus.KunalMenuItem.PreDefinedSideBarGradientColors.ShineyBlueYellow
        Me.MenuItem155.ShowBorderAroundMenuBar = False
        Me.MenuItem155.ShowHiliteOverSideBar = False
        Me.MenuItem155.ShowShadowUnderMenuBar = True
        Me.MenuItem155.SideBarGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.MenuItem155.SideBarStyle = UltimateMenus.KunalMenuItem.SideBarDrawStyle.DefaultGradient
        Me.MenuItem155.Text = "Leadger"
        '
        'MenuItem156
        '
        Me.MenuItem156.CheckedImageIndex = 0
        Me.MenuItem156.CheckedMenuItemBackColor = System.Drawing.SystemColors.Control
        Me.MenuItem156.CheckedMenuItemBorderColor = System.Drawing.SystemColors.Control
        Me.MenuItem156.CheckedMenuItemDisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(197, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(184, Byte), Integer))
        Me.MenuItem156.CheckedMenuItemIconShadowColor = System.Drawing.Color.Gray
        Me.MenuItem156.CheckedMenuItemStyle = UltimateMenus.KunalMenuItem.CheckedMenuStyles.CheckedItemDefault
        Me.MenuItem156.CheckedMenuItemTickMarkColor = System.Drawing.SystemColors.Control
        Me.MenuItem156.FillMenuBarItem = False
        Me.MenuItem156.HighLightForeColor = System.Drawing.SystemColors.HighlightText
        Me.MenuItem156.HighLightScheme = UltimateMenus.KunalMenuItem.HighLightColorDrawStyle.DefaultScheme
        Me.MenuItem156.HiliteGradientColor1 = System.Drawing.Color.WhiteSmoke
        Me.MenuItem156.HiliteGradientColor2 = System.Drawing.Color.CornflowerBlue
        Me.MenuItem156.HiLiteGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.MenuItem156.IconShadowColor = System.Drawing.Color.Gray
        Me.MenuItem156.ImageIndex = 0
        Me.MenuItem156.Index = 6
        Me.MenuItem156.MakeCheckedMenuItemIconTransparent = False
        Me.MenuItem156.MakeTransparentIcon = False
        Me.MenuItem156.MenuBarItemBorderColor = System.Drawing.Color.Black
        Me.MenuItem156.MenuBarItemFillColor = System.Drawing.SystemColors.Menu
        Me.MenuItem156.MenuBarItemFillingStyle = UltimateMenus.KunalMenuItem.MenuBarFillStyles.FillColor
        Me.MenuItem156.MenuBarItemGradientColor1 = System.Drawing.SystemColors.Menu
        Me.MenuItem156.MenuBarItemGradientColor2 = System.Drawing.SystemColors.Menu
        Me.MenuItem156.MenuBarItemGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.MenuItem156.OwnerDraw = True
        Me.MenuItem156.PreDefinedHiLiteColors = UltimateMenus.KunalMenuItem.PreDefinedHighLightColors.Khaki
        Me.MenuItem156.PreDefinedHiLiteGradientColors = UltimateMenus.KunalMenuItem.PreDefinedGrHighLightColors.BrownWhite
        Me.MenuItem156.PreDefinedSideBarGradientColour = UltimateMenus.KunalMenuItem.PreDefinedSideBarGradientColors.ShineyBlueYellow
        Me.MenuItem156.ShowBorderAroundMenuBar = False
        Me.MenuItem156.ShowHiliteOverSideBar = False
        Me.MenuItem156.ShowShadowUnderMenuBar = True
        Me.MenuItem156.SideBarGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.MenuItem156.SideBarStyle = UltimateMenus.KunalMenuItem.SideBarDrawStyle.DefaultGradient
        Me.MenuItem156.Text = "Cash Book"
        '
        'MenuItem157
        '
        Me.MenuItem157.CheckedImageIndex = 0
        Me.MenuItem157.CheckedMenuItemBackColor = System.Drawing.SystemColors.Control
        Me.MenuItem157.CheckedMenuItemBorderColor = System.Drawing.SystemColors.Control
        Me.MenuItem157.CheckedMenuItemDisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(197, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(184, Byte), Integer))
        Me.MenuItem157.CheckedMenuItemIconShadowColor = System.Drawing.Color.Gray
        Me.MenuItem157.CheckedMenuItemStyle = UltimateMenus.KunalMenuItem.CheckedMenuStyles.CheckedItemDefault
        Me.MenuItem157.CheckedMenuItemTickMarkColor = System.Drawing.SystemColors.Control
        Me.MenuItem157.FillMenuBarItem = False
        Me.MenuItem157.HighLightForeColor = System.Drawing.SystemColors.HighlightText
        Me.MenuItem157.HighLightScheme = UltimateMenus.KunalMenuItem.HighLightColorDrawStyle.DefaultScheme
        Me.MenuItem157.HiliteGradientColor1 = System.Drawing.Color.WhiteSmoke
        Me.MenuItem157.HiliteGradientColor2 = System.Drawing.Color.CornflowerBlue
        Me.MenuItem157.HiLiteGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.MenuItem157.IconShadowColor = System.Drawing.Color.Gray
        Me.MenuItem157.ImageIndex = 0
        Me.MenuItem157.Index = 7
        Me.MenuItem157.MakeCheckedMenuItemIconTransparent = False
        Me.MenuItem157.MakeTransparentIcon = False
        Me.MenuItem157.MenuBarItemBorderColor = System.Drawing.Color.Black
        Me.MenuItem157.MenuBarItemFillColor = System.Drawing.SystemColors.Menu
        Me.MenuItem157.MenuBarItemFillingStyle = UltimateMenus.KunalMenuItem.MenuBarFillStyles.FillColor
        Me.MenuItem157.MenuBarItemGradientColor1 = System.Drawing.SystemColors.Menu
        Me.MenuItem157.MenuBarItemGradientColor2 = System.Drawing.SystemColors.Menu
        Me.MenuItem157.MenuBarItemGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.MenuItem157.OwnerDraw = True
        Me.MenuItem157.PreDefinedHiLiteColors = UltimateMenus.KunalMenuItem.PreDefinedHighLightColors.Khaki
        Me.MenuItem157.PreDefinedHiLiteGradientColors = UltimateMenus.KunalMenuItem.PreDefinedGrHighLightColors.BrownWhite
        Me.MenuItem157.PreDefinedSideBarGradientColour = UltimateMenus.KunalMenuItem.PreDefinedSideBarGradientColors.ShineyBlueYellow
        Me.MenuItem157.ShowBorderAroundMenuBar = False
        Me.MenuItem157.ShowHiliteOverSideBar = False
        Me.MenuItem157.ShowShadowUnderMenuBar = True
        Me.MenuItem157.SideBarGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.MenuItem157.SideBarStyle = UltimateMenus.KunalMenuItem.SideBarDrawStyle.DefaultGradient
        Me.MenuItem157.Text = "Day Book"
        '
        'MenuItem171
        '
        Me.MenuItem171.CheckedImageIndex = 0
        Me.MenuItem171.CheckedMenuItemBackColor = System.Drawing.SystemColors.Control
        Me.MenuItem171.CheckedMenuItemBorderColor = System.Drawing.SystemColors.Control
        Me.MenuItem171.CheckedMenuItemDisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(197, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(184, Byte), Integer))
        Me.MenuItem171.CheckedMenuItemIconShadowColor = System.Drawing.Color.Gray
        Me.MenuItem171.CheckedMenuItemStyle = UltimateMenus.KunalMenuItem.CheckedMenuStyles.CheckedItemDefault
        Me.MenuItem171.CheckedMenuItemTickMarkColor = System.Drawing.SystemColors.Control
        Me.MenuItem171.FillMenuBarItem = False
        Me.MenuItem171.HighLightForeColor = System.Drawing.SystemColors.HighlightText
        Me.MenuItem171.HighLightScheme = UltimateMenus.KunalMenuItem.HighLightColorDrawStyle.DefaultScheme
        Me.MenuItem171.HiliteGradientColor1 = System.Drawing.Color.WhiteSmoke
        Me.MenuItem171.HiliteGradientColor2 = System.Drawing.Color.CornflowerBlue
        Me.MenuItem171.HiLiteGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.MenuItem171.IconShadowColor = System.Drawing.Color.Gray
        Me.MenuItem171.ImageIndex = 0
        Me.MenuItem171.Index = 8
        Me.MenuItem171.MakeCheckedMenuItemIconTransparent = False
        Me.MenuItem171.MakeTransparentIcon = False
        Me.MenuItem171.MenuBarItemBorderColor = System.Drawing.Color.Black
        Me.MenuItem171.MenuBarItemFillColor = System.Drawing.SystemColors.Menu
        Me.MenuItem171.MenuBarItemFillingStyle = UltimateMenus.KunalMenuItem.MenuBarFillStyles.FillColor
        Me.MenuItem171.MenuBarItemGradientColor1 = System.Drawing.SystemColors.Menu
        Me.MenuItem171.MenuBarItemGradientColor2 = System.Drawing.SystemColors.Menu
        Me.MenuItem171.MenuBarItemGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.MenuItem171.OwnerDraw = True
        Me.MenuItem171.PreDefinedHiLiteColors = UltimateMenus.KunalMenuItem.PreDefinedHighLightColors.Khaki
        Me.MenuItem171.PreDefinedHiLiteGradientColors = UltimateMenus.KunalMenuItem.PreDefinedGrHighLightColors.BrownWhite
        Me.MenuItem171.PreDefinedSideBarGradientColour = UltimateMenus.KunalMenuItem.PreDefinedSideBarGradientColors.ShineyBlueYellow
        Me.MenuItem171.ShowBorderAroundMenuBar = False
        Me.MenuItem171.ShowHiliteOverSideBar = False
        Me.MenuItem171.ShowShadowUnderMenuBar = True
        Me.MenuItem171.SideBarGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.MenuItem171.SideBarStyle = UltimateMenus.KunalMenuItem.SideBarDrawStyle.DefaultGradient
        Me.MenuItem171.Text = "Loan Defaulters"
        '
        'MenuItem172
        '
        Me.MenuItem172.CheckedImageIndex = 0
        Me.MenuItem172.CheckedMenuItemBackColor = System.Drawing.SystemColors.Control
        Me.MenuItem172.CheckedMenuItemBorderColor = System.Drawing.SystemColors.Control
        Me.MenuItem172.CheckedMenuItemDisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(197, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(184, Byte), Integer))
        Me.MenuItem172.CheckedMenuItemIconShadowColor = System.Drawing.Color.Gray
        Me.MenuItem172.CheckedMenuItemStyle = UltimateMenus.KunalMenuItem.CheckedMenuStyles.CheckedItemDefault
        Me.MenuItem172.CheckedMenuItemTickMarkColor = System.Drawing.SystemColors.Control
        Me.MenuItem172.FillMenuBarItem = False
        Me.MenuItem172.HighLightForeColor = System.Drawing.SystemColors.HighlightText
        Me.MenuItem172.HighLightScheme = UltimateMenus.KunalMenuItem.HighLightColorDrawStyle.DefaultScheme
        Me.MenuItem172.HiliteGradientColor1 = System.Drawing.Color.WhiteSmoke
        Me.MenuItem172.HiliteGradientColor2 = System.Drawing.Color.CornflowerBlue
        Me.MenuItem172.HiLiteGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.MenuItem172.IconShadowColor = System.Drawing.Color.Gray
        Me.MenuItem172.ImageIndex = 0
        Me.MenuItem172.Index = 9
        Me.MenuItem172.MakeCheckedMenuItemIconTransparent = False
        Me.MenuItem172.MakeTransparentIcon = False
        Me.MenuItem172.MenuBarItemBorderColor = System.Drawing.Color.Black
        Me.MenuItem172.MenuBarItemFillColor = System.Drawing.SystemColors.Menu
        Me.MenuItem172.MenuBarItemFillingStyle = UltimateMenus.KunalMenuItem.MenuBarFillStyles.FillColor
        Me.MenuItem172.MenuBarItemGradientColor1 = System.Drawing.SystemColors.Menu
        Me.MenuItem172.MenuBarItemGradientColor2 = System.Drawing.SystemColors.Menu
        Me.MenuItem172.MenuBarItemGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.MenuItem172.OwnerDraw = True
        Me.MenuItem172.PreDefinedHiLiteColors = UltimateMenus.KunalMenuItem.PreDefinedHighLightColors.Khaki
        Me.MenuItem172.PreDefinedHiLiteGradientColors = UltimateMenus.KunalMenuItem.PreDefinedGrHighLightColors.BrownWhite
        Me.MenuItem172.PreDefinedSideBarGradientColour = UltimateMenus.KunalMenuItem.PreDefinedSideBarGradientColors.ShineyBlueYellow
        Me.MenuItem172.ShowBorderAroundMenuBar = False
        Me.MenuItem172.ShowHiliteOverSideBar = False
        Me.MenuItem172.ShowShadowUnderMenuBar = True
        Me.MenuItem172.SideBarGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.MenuItem172.SideBarStyle = UltimateMenus.KunalMenuItem.SideBarDrawStyle.DefaultGradient
        Me.MenuItem172.Text = "Clearing Bill"
        '
        'MenuItem173
        '
        Me.MenuItem173.CheckedImageIndex = 0
        Me.MenuItem173.CheckedMenuItemBackColor = System.Drawing.SystemColors.Control
        Me.MenuItem173.CheckedMenuItemBorderColor = System.Drawing.SystemColors.Control
        Me.MenuItem173.CheckedMenuItemDisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(197, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(184, Byte), Integer))
        Me.MenuItem173.CheckedMenuItemIconShadowColor = System.Drawing.Color.Gray
        Me.MenuItem173.CheckedMenuItemStyle = UltimateMenus.KunalMenuItem.CheckedMenuStyles.CheckedItemDefault
        Me.MenuItem173.CheckedMenuItemTickMarkColor = System.Drawing.SystemColors.Control
        Me.MenuItem173.FillMenuBarItem = False
        Me.MenuItem173.HighLightForeColor = System.Drawing.SystemColors.HighlightText
        Me.MenuItem173.HighLightScheme = UltimateMenus.KunalMenuItem.HighLightColorDrawStyle.DefaultScheme
        Me.MenuItem173.HiliteGradientColor1 = System.Drawing.Color.WhiteSmoke
        Me.MenuItem173.HiliteGradientColor2 = System.Drawing.Color.CornflowerBlue
        Me.MenuItem173.HiLiteGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.MenuItem173.IconShadowColor = System.Drawing.Color.Gray
        Me.MenuItem173.ImageIndex = 0
        Me.MenuItem173.Index = 10
        Me.MenuItem173.MakeCheckedMenuItemIconTransparent = False
        Me.MenuItem173.MakeTransparentIcon = False
        Me.MenuItem173.MenuBarItemBorderColor = System.Drawing.Color.Black
        Me.MenuItem173.MenuBarItemFillColor = System.Drawing.SystemColors.Menu
        Me.MenuItem173.MenuBarItemFillingStyle = UltimateMenus.KunalMenuItem.MenuBarFillStyles.FillColor
        Me.MenuItem173.MenuBarItemGradientColor1 = System.Drawing.SystemColors.Menu
        Me.MenuItem173.MenuBarItemGradientColor2 = System.Drawing.SystemColors.Menu
        Me.MenuItem173.MenuBarItemGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.MenuItem173.OwnerDraw = True
        Me.MenuItem173.PreDefinedHiLiteColors = UltimateMenus.KunalMenuItem.PreDefinedHighLightColors.Khaki
        Me.MenuItem173.PreDefinedHiLiteGradientColors = UltimateMenus.KunalMenuItem.PreDefinedGrHighLightColors.BrownWhite
        Me.MenuItem173.PreDefinedSideBarGradientColour = UltimateMenus.KunalMenuItem.PreDefinedSideBarGradientColors.ShineyBlueYellow
        Me.MenuItem173.ShowBorderAroundMenuBar = False
        Me.MenuItem173.ShowHiliteOverSideBar = False
        Me.MenuItem173.ShowShadowUnderMenuBar = True
        Me.MenuItem173.SideBarGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.MenuItem173.SideBarStyle = UltimateMenus.KunalMenuItem.SideBarDrawStyle.DefaultGradient
        Me.MenuItem173.Text = "Trial Balance"
        '
        'MenuItem174
        '
        Me.MenuItem174.CheckedImageIndex = 0
        Me.MenuItem174.CheckedMenuItemBackColor = System.Drawing.SystemColors.Control
        Me.MenuItem174.CheckedMenuItemBorderColor = System.Drawing.SystemColors.Control
        Me.MenuItem174.CheckedMenuItemDisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(197, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(184, Byte), Integer))
        Me.MenuItem174.CheckedMenuItemIconShadowColor = System.Drawing.Color.Gray
        Me.MenuItem174.CheckedMenuItemStyle = UltimateMenus.KunalMenuItem.CheckedMenuStyles.CheckedItemDefault
        Me.MenuItem174.CheckedMenuItemTickMarkColor = System.Drawing.SystemColors.Control
        Me.MenuItem174.FillMenuBarItem = False
        Me.MenuItem174.HighLightForeColor = System.Drawing.SystemColors.HighlightText
        Me.MenuItem174.HighLightScheme = UltimateMenus.KunalMenuItem.HighLightColorDrawStyle.DefaultScheme
        Me.MenuItem174.HiliteGradientColor1 = System.Drawing.Color.WhiteSmoke
        Me.MenuItem174.HiliteGradientColor2 = System.Drawing.Color.CornflowerBlue
        Me.MenuItem174.HiLiteGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.MenuItem174.IconShadowColor = System.Drawing.Color.Gray
        Me.MenuItem174.ImageIndex = 0
        Me.MenuItem174.Index = 11
        Me.MenuItem174.MakeCheckedMenuItemIconTransparent = False
        Me.MenuItem174.MakeTransparentIcon = False
        Me.MenuItem174.MenuBarItemBorderColor = System.Drawing.Color.Black
        Me.MenuItem174.MenuBarItemFillColor = System.Drawing.SystemColors.Menu
        Me.MenuItem174.MenuBarItemFillingStyle = UltimateMenus.KunalMenuItem.MenuBarFillStyles.FillColor
        Me.MenuItem174.MenuBarItemGradientColor1 = System.Drawing.SystemColors.Menu
        Me.MenuItem174.MenuBarItemGradientColor2 = System.Drawing.SystemColors.Menu
        Me.MenuItem174.MenuBarItemGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.MenuItem174.OwnerDraw = True
        Me.MenuItem174.PreDefinedHiLiteColors = UltimateMenus.KunalMenuItem.PreDefinedHighLightColors.Khaki
        Me.MenuItem174.PreDefinedHiLiteGradientColors = UltimateMenus.KunalMenuItem.PreDefinedGrHighLightColors.BrownWhite
        Me.MenuItem174.PreDefinedSideBarGradientColour = UltimateMenus.KunalMenuItem.PreDefinedSideBarGradientColors.ShineyBlueYellow
        Me.MenuItem174.ShowBorderAroundMenuBar = False
        Me.MenuItem174.ShowHiliteOverSideBar = False
        Me.MenuItem174.ShowShadowUnderMenuBar = True
        Me.MenuItem174.SideBarGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.MenuItem174.SideBarStyle = UltimateMenus.KunalMenuItem.SideBarDrawStyle.DefaultGradient
        Me.MenuItem174.Text = "Profit and Loss"
        '
        'MenuItem175
        '
        Me.MenuItem175.CheckedImageIndex = 0
        Me.MenuItem175.CheckedMenuItemBackColor = System.Drawing.SystemColors.Control
        Me.MenuItem175.CheckedMenuItemBorderColor = System.Drawing.SystemColors.Control
        Me.MenuItem175.CheckedMenuItemDisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(197, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(184, Byte), Integer))
        Me.MenuItem175.CheckedMenuItemIconShadowColor = System.Drawing.Color.Gray
        Me.MenuItem175.CheckedMenuItemStyle = UltimateMenus.KunalMenuItem.CheckedMenuStyles.CheckedItemDefault
        Me.MenuItem175.CheckedMenuItemTickMarkColor = System.Drawing.SystemColors.Control
        Me.MenuItem175.FillMenuBarItem = False
        Me.MenuItem175.HighLightForeColor = System.Drawing.SystemColors.HighlightText
        Me.MenuItem175.HighLightScheme = UltimateMenus.KunalMenuItem.HighLightColorDrawStyle.DefaultScheme
        Me.MenuItem175.HiliteGradientColor1 = System.Drawing.Color.WhiteSmoke
        Me.MenuItem175.HiliteGradientColor2 = System.Drawing.Color.CornflowerBlue
        Me.MenuItem175.HiLiteGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.MenuItem175.IconShadowColor = System.Drawing.Color.Gray
        Me.MenuItem175.ImageIndex = 0
        Me.MenuItem175.Index = 12
        Me.MenuItem175.MakeCheckedMenuItemIconTransparent = False
        Me.MenuItem175.MakeTransparentIcon = False
        Me.MenuItem175.MenuBarItemBorderColor = System.Drawing.Color.Black
        Me.MenuItem175.MenuBarItemFillColor = System.Drawing.SystemColors.Menu
        Me.MenuItem175.MenuBarItemFillingStyle = UltimateMenus.KunalMenuItem.MenuBarFillStyles.FillColor
        Me.MenuItem175.MenuBarItemGradientColor1 = System.Drawing.SystemColors.Menu
        Me.MenuItem175.MenuBarItemGradientColor2 = System.Drawing.SystemColors.Menu
        Me.MenuItem175.MenuBarItemGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.MenuItem175.OwnerDraw = True
        Me.MenuItem175.PreDefinedHiLiteColors = UltimateMenus.KunalMenuItem.PreDefinedHighLightColors.Khaki
        Me.MenuItem175.PreDefinedHiLiteGradientColors = UltimateMenus.KunalMenuItem.PreDefinedGrHighLightColors.BrownWhite
        Me.MenuItem175.PreDefinedSideBarGradientColour = UltimateMenus.KunalMenuItem.PreDefinedSideBarGradientColors.ShineyBlueYellow
        Me.MenuItem175.ShowBorderAroundMenuBar = False
        Me.MenuItem175.ShowHiliteOverSideBar = False
        Me.MenuItem175.ShowShadowUnderMenuBar = True
        Me.MenuItem175.SideBarGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.MenuItem175.SideBarStyle = UltimateMenus.KunalMenuItem.SideBarDrawStyle.DefaultGradient
        Me.MenuItem175.Text = "Income and Expenditure"
        '
        'MenuItem176
        '
        Me.MenuItem176.CheckedImageIndex = 0
        Me.MenuItem176.CheckedMenuItemBackColor = System.Drawing.SystemColors.Control
        Me.MenuItem176.CheckedMenuItemBorderColor = System.Drawing.SystemColors.Control
        Me.MenuItem176.CheckedMenuItemDisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(197, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(184, Byte), Integer))
        Me.MenuItem176.CheckedMenuItemIconShadowColor = System.Drawing.Color.Gray
        Me.MenuItem176.CheckedMenuItemStyle = UltimateMenus.KunalMenuItem.CheckedMenuStyles.CheckedItemDefault
        Me.MenuItem176.CheckedMenuItemTickMarkColor = System.Drawing.SystemColors.Control
        Me.MenuItem176.FillMenuBarItem = False
        Me.MenuItem176.HighLightForeColor = System.Drawing.SystemColors.HighlightText
        Me.MenuItem176.HighLightScheme = UltimateMenus.KunalMenuItem.HighLightColorDrawStyle.DefaultScheme
        Me.MenuItem176.HiliteGradientColor1 = System.Drawing.Color.WhiteSmoke
        Me.MenuItem176.HiliteGradientColor2 = System.Drawing.Color.CornflowerBlue
        Me.MenuItem176.HiLiteGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.MenuItem176.IconShadowColor = System.Drawing.Color.Gray
        Me.MenuItem176.ImageIndex = 0
        Me.MenuItem176.Index = 13
        Me.MenuItem176.MakeCheckedMenuItemIconTransparent = False
        Me.MenuItem176.MakeTransparentIcon = False
        Me.MenuItem176.MenuBarItemBorderColor = System.Drawing.Color.Black
        Me.MenuItem176.MenuBarItemFillColor = System.Drawing.SystemColors.Menu
        Me.MenuItem176.MenuBarItemFillingStyle = UltimateMenus.KunalMenuItem.MenuBarFillStyles.FillColor
        Me.MenuItem176.MenuBarItemGradientColor1 = System.Drawing.SystemColors.Menu
        Me.MenuItem176.MenuBarItemGradientColor2 = System.Drawing.SystemColors.Menu
        Me.MenuItem176.MenuBarItemGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.MenuItem176.OwnerDraw = True
        Me.MenuItem176.PreDefinedHiLiteColors = UltimateMenus.KunalMenuItem.PreDefinedHighLightColors.Khaki
        Me.MenuItem176.PreDefinedHiLiteGradientColors = UltimateMenus.KunalMenuItem.PreDefinedGrHighLightColors.BrownWhite
        Me.MenuItem176.PreDefinedSideBarGradientColour = UltimateMenus.KunalMenuItem.PreDefinedSideBarGradientColors.ShineyBlueYellow
        Me.MenuItem176.ShowBorderAroundMenuBar = False
        Me.MenuItem176.ShowHiliteOverSideBar = False
        Me.MenuItem176.ShowShadowUnderMenuBar = True
        Me.MenuItem176.SideBarGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.MenuItem176.SideBarStyle = UltimateMenus.KunalMenuItem.SideBarDrawStyle.DefaultGradient
        Me.MenuItem176.Text = "Receipts and Payments"
        '
        'MenuItem177
        '
        Me.MenuItem177.CheckedImageIndex = 0
        Me.MenuItem177.CheckedMenuItemBackColor = System.Drawing.SystemColors.Control
        Me.MenuItem177.CheckedMenuItemBorderColor = System.Drawing.SystemColors.Control
        Me.MenuItem177.CheckedMenuItemDisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(197, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(184, Byte), Integer))
        Me.MenuItem177.CheckedMenuItemIconShadowColor = System.Drawing.Color.Gray
        Me.MenuItem177.CheckedMenuItemStyle = UltimateMenus.KunalMenuItem.CheckedMenuStyles.CheckedItemDefault
        Me.MenuItem177.CheckedMenuItemTickMarkColor = System.Drawing.SystemColors.Control
        Me.MenuItem177.FillMenuBarItem = False
        Me.MenuItem177.HighLightForeColor = System.Drawing.SystemColors.HighlightText
        Me.MenuItem177.HighLightScheme = UltimateMenus.KunalMenuItem.HighLightColorDrawStyle.DefaultScheme
        Me.MenuItem177.HiliteGradientColor1 = System.Drawing.Color.WhiteSmoke
        Me.MenuItem177.HiliteGradientColor2 = System.Drawing.Color.CornflowerBlue
        Me.MenuItem177.HiLiteGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.MenuItem177.IconShadowColor = System.Drawing.Color.Gray
        Me.MenuItem177.ImageIndex = 0
        Me.MenuItem177.Index = 14
        Me.MenuItem177.MakeCheckedMenuItemIconTransparent = False
        Me.MenuItem177.MakeTransparentIcon = False
        Me.MenuItem177.MenuBarItemBorderColor = System.Drawing.Color.Black
        Me.MenuItem177.MenuBarItemFillColor = System.Drawing.SystemColors.Menu
        Me.MenuItem177.MenuBarItemFillingStyle = UltimateMenus.KunalMenuItem.MenuBarFillStyles.FillColor
        Me.MenuItem177.MenuBarItemGradientColor1 = System.Drawing.SystemColors.Menu
        Me.MenuItem177.MenuBarItemGradientColor2 = System.Drawing.SystemColors.Menu
        Me.MenuItem177.MenuBarItemGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.MenuItem177.OwnerDraw = True
        Me.MenuItem177.PreDefinedHiLiteColors = UltimateMenus.KunalMenuItem.PreDefinedHighLightColors.Khaki
        Me.MenuItem177.PreDefinedHiLiteGradientColors = UltimateMenus.KunalMenuItem.PreDefinedGrHighLightColors.BrownWhite
        Me.MenuItem177.PreDefinedSideBarGradientColour = UltimateMenus.KunalMenuItem.PreDefinedSideBarGradientColors.ShineyBlueYellow
        Me.MenuItem177.ShowBorderAroundMenuBar = False
        Me.MenuItem177.ShowHiliteOverSideBar = False
        Me.MenuItem177.ShowShadowUnderMenuBar = True
        Me.MenuItem177.SideBarGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.MenuItem177.SideBarStyle = UltimateMenus.KunalMenuItem.SideBarDrawStyle.DefaultGradient
        Me.MenuItem177.Text = "Balance Sheet"
        '
        'MenuItem183
        '
        Me.MenuItem183.Index = 15
        Me.MenuItem183.Text = ""
        '
        'MenuItem150
        '
        Me.MenuItem150.CheckedImageIndex = 0
        Me.MenuItem150.CheckedMenuItemBackColor = System.Drawing.SystemColors.Control
        Me.MenuItem150.CheckedMenuItemBorderColor = System.Drawing.SystemColors.Control
        Me.MenuItem150.CheckedMenuItemDisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(197, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(184, Byte), Integer))
        Me.MenuItem150.CheckedMenuItemIconShadowColor = System.Drawing.Color.Gray
        Me.MenuItem150.CheckedMenuItemStyle = UltimateMenus.KunalMenuItem.CheckedMenuStyles.CheckedItemDefault
        Me.MenuItem150.CheckedMenuItemTickMarkColor = System.Drawing.SystemColors.Control
        Me.MenuItem150.FillMenuBarItem = False
        Me.MenuItem150.HighLightForeColor = System.Drawing.SystemColors.HighlightText
        Me.MenuItem150.HighLightScheme = UltimateMenus.KunalMenuItem.HighLightColorDrawStyle.DefaultScheme
        Me.MenuItem150.HiliteGradientColor1 = System.Drawing.Color.WhiteSmoke
        Me.MenuItem150.HiliteGradientColor2 = System.Drawing.Color.CornflowerBlue
        Me.MenuItem150.HiLiteGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.MenuItem150.IconShadowColor = System.Drawing.Color.Gray
        Me.MenuItem150.ImageIndex = 0
        Me.MenuItem150.Index = 11
        Me.MenuItem150.MakeCheckedMenuItemIconTransparent = False
        Me.MenuItem150.MakeTransparentIcon = False
        Me.MenuItem150.MenuBarItemBorderColor = System.Drawing.Color.Black
        Me.MenuItem150.MenuBarItemFillColor = System.Drawing.SystemColors.Menu
        Me.MenuItem150.MenuBarItemFillingStyle = UltimateMenus.KunalMenuItem.MenuBarFillStyles.FillColor
        Me.MenuItem150.MenuBarItemGradientColor1 = System.Drawing.SystemColors.Menu
        Me.MenuItem150.MenuBarItemGradientColor2 = System.Drawing.SystemColors.Menu
        Me.MenuItem150.MenuBarItemGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.MenuItem150.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem169})
        Me.MenuItem150.OwnerDraw = True
        Me.MenuItem150.PreDefinedHiLiteColors = UltimateMenus.KunalMenuItem.PreDefinedHighLightColors.Khaki
        Me.MenuItem150.PreDefinedHiLiteGradientColors = UltimateMenus.KunalMenuItem.PreDefinedGrHighLightColors.BrownWhite
        Me.MenuItem150.PreDefinedSideBarGradientColour = UltimateMenus.KunalMenuItem.PreDefinedSideBarGradientColors.ShineyBlueYellow
        Me.MenuItem150.ShowBorderAroundMenuBar = False
        Me.MenuItem150.ShowHiliteOverSideBar = False
        Me.MenuItem150.ShowShadowUnderMenuBar = True
        Me.MenuItem150.SideBarGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.MenuItem150.SideBarStyle = UltimateMenus.KunalMenuItem.SideBarDrawStyle.DefaultGradient
        Me.MenuItem150.Text = "Help"
        Me.MenuItem150.Visible = False
        '
        'MenuItem169
        '
        Me.MenuItem169.CheckedImageIndex = 0
        Me.MenuItem169.CheckedMenuItemBackColor = System.Drawing.SystemColors.Control
        Me.MenuItem169.CheckedMenuItemBorderColor = System.Drawing.SystemColors.Control
        Me.MenuItem169.CheckedMenuItemDisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(197, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(184, Byte), Integer))
        Me.MenuItem169.CheckedMenuItemIconShadowColor = System.Drawing.Color.Gray
        Me.MenuItem169.CheckedMenuItemStyle = UltimateMenus.KunalMenuItem.CheckedMenuStyles.CheckedItemDefault
        Me.MenuItem169.CheckedMenuItemTickMarkColor = System.Drawing.SystemColors.Control
        Me.MenuItem169.FillMenuBarItem = False
        Me.MenuItem169.HighLightForeColor = System.Drawing.SystemColors.HighlightText
        Me.MenuItem169.HighLightScheme = UltimateMenus.KunalMenuItem.HighLightColorDrawStyle.DefaultScheme
        Me.MenuItem169.HiliteGradientColor1 = System.Drawing.Color.WhiteSmoke
        Me.MenuItem169.HiliteGradientColor2 = System.Drawing.Color.CornflowerBlue
        Me.MenuItem169.HiLiteGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.MenuItem169.IconShadowColor = System.Drawing.Color.Gray
        Me.MenuItem169.ImageIndex = 0
        Me.MenuItem169.Index = 0
        Me.MenuItem169.MakeCheckedMenuItemIconTransparent = False
        Me.MenuItem169.MakeTransparentIcon = False
        Me.MenuItem169.MenuBarItemBorderColor = System.Drawing.Color.Black
        Me.MenuItem169.MenuBarItemFillColor = System.Drawing.SystemColors.Menu
        Me.MenuItem169.MenuBarItemFillingStyle = UltimateMenus.KunalMenuItem.MenuBarFillStyles.FillColor
        Me.MenuItem169.MenuBarItemGradientColor1 = System.Drawing.SystemColors.Menu
        Me.MenuItem169.MenuBarItemGradientColor2 = System.Drawing.SystemColors.Menu
        Me.MenuItem169.MenuBarItemGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.MenuItem169.OwnerDraw = True
        Me.MenuItem169.PreDefinedHiLiteColors = UltimateMenus.KunalMenuItem.PreDefinedHighLightColors.Khaki
        Me.MenuItem169.PreDefinedHiLiteGradientColors = UltimateMenus.KunalMenuItem.PreDefinedGrHighLightColors.BrownWhite
        Me.MenuItem169.PreDefinedSideBarGradientColour = UltimateMenus.KunalMenuItem.PreDefinedSideBarGradientColors.ShineyBlueYellow
        Me.MenuItem169.ShowBorderAroundMenuBar = False
        Me.MenuItem169.ShowHiliteOverSideBar = False
        Me.MenuItem169.ShowShadowUnderMenuBar = True
        Me.MenuItem169.SideBarGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.MenuItem169.SideBarStyle = UltimateMenus.KunalMenuItem.SideBarDrawStyle.DefaultGradient
        Me.MenuItem169.Text = "Loans "
        '
        'BalloonToolTip1
        '
        Me.BalloonToolTip1.BackColor = System.Drawing.SystemColors.Info
        Me.BalloonToolTip1.ForeColor = System.Drawing.SystemColors.InfoText
        Me.BalloonToolTip1.Title = ""
        '
        'pnlQuickLaunch
        '
        Me.pnlQuickLaunch.BackColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.BalloonToolTip1.SetBalloonText(Me.pnlQuickLaunch, Nothing)
        Me.pnlQuickLaunch.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pnlQuickLaunch.Controls.Add(Me.btnLogOff)
        Me.pnlQuickLaunch.Controls.Add(Me.btnCalculator)
        Me.pnlQuickLaunch.Controls.Add(Me.NewButton4)
        Me.pnlQuickLaunch.Controls.Add(Me.btnReports)
        Me.pnlQuickLaunch.Controls.Add(Me.btnAccounts)
        Me.pnlQuickLaunch.Controls.Add(Me.btnLoans)
        Me.pnlQuickLaunch.Controls.Add(Me.btnDeposits)
        Me.pnlQuickLaunch.Controls.Add(Me.btnSavings)
        Me.pnlQuickLaunch.Controls.Add(Me.btnShares)
        Me.pnlQuickLaunch.Controls.Add(Me.btnMembers)
        Me.pnlQuickLaunch.Controls.Add(Me.btnExit)
        Me.pnlQuickLaunch.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlQuickLaunch.Font = New System.Drawing.Font("Georgia", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pnlQuickLaunch.Location = New System.Drawing.Point(0, 0)
        Me.pnlQuickLaunch.Name = "pnlQuickLaunch"
        Me.pnlQuickLaunch.Size = New System.Drawing.Size(1026, 72)
        Me.pnlQuickLaunch.TabIndex = 5
        '
        'btnLogOff
        '
        Me.BalloonToolTip1.SetBalloonText(Me.btnLogOff, "Logoff and Login as different User")
        Me.btnLogOff.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLogOff.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnLogOff.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogOff.GotFocusColour = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(142, Byte), Integer), CType(CType(198, Byte), Integer))
        Me.btnLogOff.Image = Global.BAS.Resources.Perspective_Button_Logoff_icon
        Me.btnLogOff.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnLogOff.Location = New System.Drawing.Point(784, 0)
        Me.btnLogOff.LostFocusColour = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.btnLogOff.Name = "btnLogOff"
        Me.btnLogOff.Size = New System.Drawing.Size(88, 64)
        Me.btnLogOff.TabIndex = 11
        Me.btnLogOff.Text = "LogOff"
        Me.btnLogOff.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'btnCalculator
        '
        Me.BalloonToolTip1.SetBalloonText(Me.btnCalculator, "Calculator")
        Me.btnCalculator.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCalculator.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnCalculator.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalculator.GotFocusColour = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(142, Byte), Integer), CType(CType(198, Byte), Integer))
        Me.btnCalculator.Image = CType(resources.GetObject("btnCalculator.Image"), System.Drawing.Image)
        Me.btnCalculator.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnCalculator.Location = New System.Drawing.Point(696, 0)
        Me.btnCalculator.LostFocusColour = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.btnCalculator.Name = "btnCalculator"
        Me.btnCalculator.Size = New System.Drawing.Size(88, 64)
        Me.btnCalculator.TabIndex = 10
        Me.btnCalculator.Text = "Calculator"
        Me.btnCalculator.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'NewButton4
        '
        Me.BalloonToolTip1.SetBalloonText(Me.NewButton4, "Help")
        Me.NewButton4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.NewButton4.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.NewButton4.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NewButton4.GotFocusColour = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(142, Byte), Integer), CType(CType(198, Byte), Integer))
        Me.NewButton4.Image = Global.BAS.Resources.printericon
        Me.NewButton4.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.NewButton4.Location = New System.Drawing.Point(608, 0)
        Me.NewButton4.LostFocusColour = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.NewButton4.Name = "NewButton4"
        Me.NewButton4.Size = New System.Drawing.Size(88, 64)
        Me.NewButton4.TabIndex = 9
        Me.NewButton4.Text = "Pass Book"
        Me.NewButton4.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'btnReports
        '
        Me.BalloonToolTip1.SetBalloonText(Me.btnReports, "Reports")
        Me.btnReports.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnReports.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnReports.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReports.GotFocusColour = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(142, Byte), Integer), CType(CType(198, Byte), Integer))
        Me.btnReports.Image = CType(resources.GetObject("btnReports.Image"), System.Drawing.Image)
        Me.btnReports.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnReports.Location = New System.Drawing.Point(528, 0)
        Me.btnReports.LostFocusColour = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.btnReports.Name = "btnReports"
        Me.btnReports.Size = New System.Drawing.Size(88, 64)
        Me.btnReports.TabIndex = 8
        Me.btnReports.Text = "Reports"
        Me.btnReports.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'btnAccounts
        '
        Me.BalloonToolTip1.SetBalloonText(Me.btnAccounts, Nothing)
        Me.btnAccounts.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAccounts.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnAccounts.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAccounts.GotFocusColour = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(142, Byte), Integer), CType(CType(198, Byte), Integer))
        Me.btnAccounts.Image = CType(resources.GetObject("btnAccounts.Image"), System.Drawing.Image)
        Me.btnAccounts.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnAccounts.Location = New System.Drawing.Point(440, 0)
        Me.btnAccounts.LostFocusColour = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.btnAccounts.Name = "btnAccounts"
        Me.btnAccounts.Size = New System.Drawing.Size(88, 64)
        Me.btnAccounts.TabIndex = 7
        Me.btnAccounts.Text = "Accounts"
        Me.btnAccounts.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'btnLoans
        '
        Me.BalloonToolTip1.SetBalloonText(Me.btnLoans, "Loan List")
        Me.btnLoans.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLoans.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnLoans.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLoans.GotFocusColour = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(142, Byte), Integer), CType(CType(198, Byte), Integer))
        Me.btnLoans.Image = CType(resources.GetObject("btnLoans.Image"), System.Drawing.Image)
        Me.btnLoans.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnLoans.Location = New System.Drawing.Point(352, 0)
        Me.btnLoans.LostFocusColour = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.btnLoans.Name = "btnLoans"
        Me.btnLoans.Size = New System.Drawing.Size(88, 64)
        Me.btnLoans.TabIndex = 6
        Me.btnLoans.Text = "Loans"
        Me.btnLoans.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'btnDeposits
        '
        Me.BalloonToolTip1.SetBalloonText(Me.btnDeposits, "FD List")
        Me.btnDeposits.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDeposits.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnDeposits.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDeposits.GotFocusColour = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(142, Byte), Integer), CType(CType(198, Byte), Integer))
        Me.btnDeposits.Image = CType(resources.GetObject("btnDeposits.Image"), System.Drawing.Image)
        Me.btnDeposits.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnDeposits.Location = New System.Drawing.Point(264, 0)
        Me.btnDeposits.LostFocusColour = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.btnDeposits.Name = "btnDeposits"
        Me.btnDeposits.Size = New System.Drawing.Size(88, 64)
        Me.btnDeposits.TabIndex = 5
        Me.btnDeposits.Text = "Deposits"
        Me.btnDeposits.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'btnSavings
        '
        Me.BalloonToolTip1.SetBalloonText(Me.btnSavings, "SB Account List")
        Me.btnSavings.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSavings.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSavings.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSavings.GotFocusColour = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(142, Byte), Integer), CType(CType(198, Byte), Integer))
        Me.btnSavings.Image = CType(resources.GetObject("btnSavings.Image"), System.Drawing.Image)
        Me.btnSavings.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnSavings.Location = New System.Drawing.Point(176, 0)
        Me.btnSavings.LostFocusColour = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.btnSavings.Name = "btnSavings"
        Me.btnSavings.Size = New System.Drawing.Size(88, 64)
        Me.btnSavings.TabIndex = 4
        Me.btnSavings.Text = "Savings "
        Me.btnSavings.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'btnShares
        '
        Me.BalloonToolTip1.SetBalloonText(Me.btnShares, "Shares List")
        Me.btnShares.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnShares.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnShares.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnShares.GotFocusColour = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(142, Byte), Integer), CType(CType(198, Byte), Integer))
        Me.btnShares.Image = CType(resources.GetObject("btnShares.Image"), System.Drawing.Image)
        Me.btnShares.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnShares.Location = New System.Drawing.Point(88, 0)
        Me.btnShares.LostFocusColour = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.btnShares.Name = "btnShares"
        Me.btnShares.Size = New System.Drawing.Size(88, 64)
        Me.btnShares.TabIndex = 3
        Me.btnShares.Text = "Members"
        Me.btnShares.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'btnMembers
        '
        Me.btnMembers.BackColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.BalloonToolTip1.SetBalloonText(Me.btnMembers, "Members")
        Me.btnMembers.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnMembers.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnMembers.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMembers.GotFocusColour = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(142, Byte), Integer), CType(CType(198, Byte), Integer))
        Me.btnMembers.Image = CType(resources.GetObject("btnMembers.Image"), System.Drawing.Image)
        Me.btnMembers.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnMembers.Location = New System.Drawing.Point(0, 0)
        Me.btnMembers.LostFocusColour = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.btnMembers.Name = "btnMembers"
        Me.btnMembers.Size = New System.Drawing.Size(88, 64)
        Me.btnMembers.TabIndex = 2
        Me.btnMembers.Text = "Customer"
        Me.btnMembers.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnMembers.UseVisualStyleBackColor = False
        '
        'btnExit
        '
        Me.BalloonToolTip1.SetBalloonText(Me.btnExit, "Exit from the System")
        Me.btnExit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnExit.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.GotFocusColour = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(142, Byte), Integer), CType(CType(198, Byte), Integer))
        Me.btnExit.Image = CType(resources.GetObject("btnExit.Image"), System.Drawing.Image)
        Me.btnExit.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnExit.Location = New System.Drawing.Point(872, 0)
        Me.btnExit.LostFocusColour = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(88, 64)
        Me.btnExit.TabIndex = 10
        Me.btnExit.Text = "E&xit"
        Me.btnExit.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'timerLoad
        '
        Me.timerLoad.Enabled = True
        Me.timerLoad.Interval = 1000
        '
        'tmrSnooze
        '
        Me.tmrSnooze.Enabled = True
        Me.tmrSnooze.Interval = 1000
        '
        'MainMenu2
        '
        Me.MainMenu2.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem117})
        '
        'MenuItem117
        '
        Me.MenuItem117.CheckedImageIndex = 0
        Me.MenuItem117.CheckedMenuItemBackColor = System.Drawing.SystemColors.Control
        Me.MenuItem117.CheckedMenuItemBorderColor = System.Drawing.SystemColors.Control
        Me.MenuItem117.CheckedMenuItemDisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(197, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(184, Byte), Integer))
        Me.MenuItem117.CheckedMenuItemIconShadowColor = System.Drawing.Color.Gray
        Me.MenuItem117.CheckedMenuItemStyle = UltimateMenus.KunalMenuItem.CheckedMenuStyles.CheckedItemDefault
        Me.MenuItem117.CheckedMenuItemTickMarkColor = System.Drawing.SystemColors.Control
        Me.MenuItem117.FillMenuBarItem = False
        Me.MenuItem117.HighLightForeColor = System.Drawing.SystemColors.HighlightText
        Me.MenuItem117.HighLightScheme = UltimateMenus.KunalMenuItem.HighLightColorDrawStyle.DefaultScheme
        Me.MenuItem117.HiliteGradientColor1 = System.Drawing.Color.WhiteSmoke
        Me.MenuItem117.HiliteGradientColor2 = System.Drawing.Color.CornflowerBlue
        Me.MenuItem117.HiLiteGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.MenuItem117.IconShadowColor = System.Drawing.Color.Gray
        Me.MenuItem117.ImageIndex = 0
        Me.MenuItem117.Index = 0
        Me.MenuItem117.MakeCheckedMenuItemIconTransparent = False
        Me.MenuItem117.MakeTransparentIcon = False
        Me.MenuItem117.MenuBarItemBorderColor = System.Drawing.Color.Black
        Me.MenuItem117.MenuBarItemFillColor = System.Drawing.SystemColors.Menu
        Me.MenuItem117.MenuBarItemFillingStyle = UltimateMenus.KunalMenuItem.MenuBarFillStyles.FillColor
        Me.MenuItem117.MenuBarItemGradientColor1 = System.Drawing.SystemColors.Menu
        Me.MenuItem117.MenuBarItemGradientColor2 = System.Drawing.SystemColors.Menu
        Me.MenuItem117.MenuBarItemGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.MenuItem117.OwnerDraw = True
        Me.MenuItem117.PreDefinedHiLiteColors = UltimateMenus.KunalMenuItem.PreDefinedHighLightColors.Khaki
        Me.MenuItem117.PreDefinedHiLiteGradientColors = UltimateMenus.KunalMenuItem.PreDefinedGrHighLightColors.BrownWhite
        Me.MenuItem117.PreDefinedSideBarGradientColour = UltimateMenus.KunalMenuItem.PreDefinedSideBarGradientColors.ShineyBlueYellow
        Me.MenuItem117.ShowBorderAroundMenuBar = False
        Me.MenuItem117.ShowHiliteOverSideBar = False
        Me.MenuItem117.ShowShadowUnderMenuBar = True
        Me.MenuItem117.SideBarGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.MenuItem117.SideBarStyle = UltimateMenus.KunalMenuItem.SideBarDrawStyle.DefaultGradient
        Me.MenuItem117.Text = ""
        '
        'frmMain
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1026, 669)
        Me.Controls.Add(Me.pnlQuickLaunch)
        Me.Controls.Add(Me.StatusBar1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.MaximizeBox = False
        Me.Menu = Me.MainMenu1
        Me.Name = "frmMain"
        Me.Text = "Main Page"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.Status, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Role, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ComapanyName, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateTime, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlQuickLaunch.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region "Code to Create Instance Object"

    Private Shared m_FormDefInstance As frmMain
    Private Shared m_InitializingDefInstance As Boolean

    Public Shared Property DefInstance() As frmMain
        Get
            If m_FormDefInstance Is Nothing OrElse m_FormDefInstance.IsDisposed Then
                m_InitializingDefInstance = True
                m_FormDefInstance = New frmMain
                m_InitializingDefInstance = False
            End If
            DefInstance = m_FormDefInstance
        End Get
        Set(ByVal Value As frmMain)
            m_FormDefInstance = Value
        End Set
    End Property

#End Region

#Region "Form Global Variables"
    Public IntCounter As Integer
    Private Const SND_ASYNC As Int32 = &H2
    Dim count As Integer = 1
#End Region

#Region "Functions"

    Public Function fnLoadData()

        Dim objfrmSample As New frmSample
        objfrmSample = frmSample.DefInstance
        ' objfrmSample.MdiParent = Me
        objfrmSample.Show()
        objfrmSample.Refresh()
        objfrmSample = Nothing

    End Function

#End Region

#Region "Events"

    'Private Sub frmMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    '    Dim User As String
    '    If User = "ravi" Then
    '        Me.MenuItem1.Visible = False
    '    End If
    '    'timerLoad.Start()

    'End Sub

    'Private Sub frmMain_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
    '    'sndPlaySound("Windows XP Shutdown.wav", SND_ASYNC)
    '    End
    'End Sub
    '***************  Members List

    '*************** Caste

    Private Sub MenuItem66_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem66.Click
        'Dim objCaste As New frmCaste
        'objCaste.MdiParent = Me
        'objCaste.Show()
        'objCaste = Nothing
    End Sub

    '***************
    Private Sub MenuItem73_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem73.Click
        'Dim objfrmMasters As New frmMasters
        'objfrmMasters.MdiParent = Me
        'objfrmMasters.Show()
        'objfrmMasters = Nothing

    End Sub

    '*************** EXIT 
    Private Sub MenuItem10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem10.Click, btnExit.Click

        If MsgBox("Are you sure you want to EXIT/CLOSE the application?", MsgBoxStyle.Question + MsgBoxStyle.YesNo + MsgBoxStyle.DefaultButton2, "Confirm Exit") = MsgBoxResult.Yes Then
            Application.Exit()
            'sndPlaySound("Windows XP Shutdown.wav", SND_ASYNC)
        End If

    End Sub

    '*************** Log Details
    Private Sub MenuItem62_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem62.Click
        Dim objfrmLogDetails As frmLogDetails
        objfrmLogDetails = frmLogDetails.DefInstance
        objfrmLogDetails.BringToFront()
        objfrmLogDetails.MdiParent = Me
        objfrmLogDetails.Show()
        objfrmLogDetails = Nothing
    End Sub

    '*************** Calculator
    Private Sub btnCalculator_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalculator.Click, MenuItem58.Click

        Shell("calc.exe")
        ' Shell("C:\Program Files\MySQL\MySQL Tools for 5.0")

    End Sub

    '***************
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Me.StatusBar1.Panels(3).Text = Format(Date.Now, "dd-MMM-yyyy hh:mm:ss tt")
    End Sub

    '***************
    Private Sub MenuItem9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem9.Click, btnLogOff.Click
        Dim objfrmLogin As New frmLogin
        'Me.Close()
        objfrmLogin.ShowDialog(Me)
        objfrmLogin = Nothing
    End Sub

    '***************
    Private Sub MenuItem90_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem90.Click
        System.Diagnostics.Process.Start("Notepad.exe")
    End Sub

    '***************
    Private Sub MenuItem92_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem92.Click
        Dim objfrmSample As frmSample
        objfrmSample = frmSample.DefInstance
        If MenuItem92.Checked = True Then
            ' objfrmSample.Visible = False  'rajakumar


            objfrmSample.Close()
            MenuItem92.Checked = False
        Else
            objfrmSample.Visible = True  'rajakumar

            MenuItem92.Checked = True
            objfrmSample.MdiParent = Me
            objfrmSample.Show()
            objfrmSample = Nothing
        End If
    End Sub

    '***************
    Private Sub MenuItem91_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem91.Click
        If MenuItem91.Checked = True Then
            pnlQuickLaunch.Visible = False
            MenuItem91.Checked = False
        Else
            pnlQuickLaunch.Visible = True
            MenuItem91.Checked = True
        End If
    End Sub

    '*************** timerLoad
    Private Sub timerLoad_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles timerLoad.Tick

        'IntCounter += 1
        'If IntCounter = 4 Then
        '    fnLoadData()
        'End If

    End Sub

    Private Sub Timer3_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs)
        count += 1
        If count = 10 Or count = 20 Or count = 30 Then
            Dim objSnoozeDisplayFrm As New Snooze
            objSnoozeDisplayFrm.Show()
            objSnoozeDisplayFrm = Nothing
        End If
    End Sub

    '***************  Bank Details
    Private Sub MenuItem85_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem85.Click
        Dim objfrmBankDetails As frmBankDetails
        objfrmBankDetails = frmBankDetails.DefInstance
        objfrmBankDetails.BringToFront()
        objfrmBankDetails.MdiParent = Me
        objfrmBankDetails.Show()
        objfrmBankDetails = Nothing
    End Sub

    '***************Religion
    Private Sub MenuItem67_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem67.Click
        'Dim objfrmReligion As New frmReligion
        'objfrmReligion = frmReligion.DefInstance
        'objfrmReligion.MdiParent = Me
        'objfrmReligion.BringToFront()
        'objfrmReligion.Show()
        'objfrmReligion = Nothing
    End Sub

    '***************




    Private Sub frmMain_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Activated
        timerLoad.Start()
    End Sub

#End Region


#Region "Member And Shares Detail"


    '***************  Member Creation
    Private Sub MenuItem11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem11.Click
        Dim objfrmMemberCreation As frmMemberCreation
        objfrmMemberCreation = frmMemberCreation.DefInstance
        objfrmMemberCreation.MdiParent = Me
        objfrmMemberCreation.BringToFront()
        objfrmMemberCreation.Show()
        objfrmMemberCreation = Nothing
    End Sub

    '*************** View Shares
    Private Sub mnuViewShares_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuViewShares.Click
        Dim objfrmViewShare As New frmViewShares
        objfrmViewShare = frmViewShares.DefInstance
        objfrmViewShare.BringToFront()
        objfrmViewShare.MdiParent = Me
        objfrmViewShare.Show()
        objfrmViewShare = Nothing
    End Sub

    '*************** Shares Transaction
    Private Sub smnuViewShares_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles smnuViewShares.Click
        Dim objfrmShareTran As New frmSharesTransaction
        objfrmShareTran = frmSharesTransaction.DefInstance
        objfrmShareTran.MdiParent = Me
        objfrmShareTran.Show()
        objfrmShareTran = Nothing
    End Sub

    '*************** Share Dividend
    Private Sub smnuDividend_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles smnuDividend.Click
        Dim objfrmShareDividend As New frmShareDividend
        objfrmShareDividend.ShowDialog(Me)
        objfrmShareDividend = Nothing
    End Sub
    '***************  Remit Shares
    Private Sub MenuItem14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem14.Click

        Dim objfrmRemitShares As New frmRemitShares
        objfrmRemitShares.ShowDialog(Me)
        objfrmRemitShares = Nothing

    End Sub
    '*************** Refund Shares
    Private Sub MenuItem15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem15.Click

        Dim objfrmRefundShares As New frmRefundShares
        objfrmRefundShares.ShowDialog(Me)
        objfrmRefundShares = Nothing

    End Sub

    '*************** Transfer Shares
    Private Sub smnuTransferShares_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles smnuTransferShares.Click
        Dim objTransferShares As frmTransferShares
        objTransferShares.ShowDialog(Me)
        objTransferShares = Nothing
    End Sub

    '*************** Member Close
    Private Sub smnuCloseMembership_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles smnuCloseMembership.Click
        Dim objMemberList As New frmMemberClose
        objMemberList.ShowDialog(Me)
        objMemberList = Nothing
    End Sub

#End Region

#Region "ShortCut Buttion"

    '*************** Loan Appliers
    Private Sub btnLoans_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLoans.Click
        Dim objfrmLoanAppliers As frmLoanAppliers
        objfrmLoanAppliers = frmLoanAppliers.DefInstance
        objfrmLoanAppliers.BringToFront()
        objfrmLoanAppliers.MdiParent = Me
        objfrmLoanAppliers.Show()
        objfrmLoanAppliers = Nothing
    End Sub

    '*************** View Shares
    Private Sub btnShares_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnShares.Click
        'Dim objViewShares As frmViewShares
        'objViewShares = frmViewShares.DefInstance
        'objViewShares.MdiParent = Me
        'objViewShares.BringToFront()
        'objViewShares.Show()
        'objViewShares = Nothing

        Dim objMemberList As frmMembersList
        objMemberList = frmMembersList.DefInstance
        objMemberList.BringToFront()
        objMemberList.MdiParent = Me
        objMemberList.Show()
        objMemberList = Nothing

    End Sub

    '*************** FD List
    Private Sub btnDeposits_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDeposits.Click, MenuItem37.Click
        Dim objfrmFDList As frmFDList
        objfrmFDList = frmFDList.DefInstance
        objfrmFDList.MdiParent = Me
        objfrmFDList.BringToFront()
        objfrmFDList.Show()
        objfrmFDList = Nothing
    End Sub

    '*************** SB Account List
    Private Sub btnSavings_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSavings.Click

        Dim objfrmSBAccList As frmSBAccList
        objfrmSBAccList = frmSBAccList.DefInstance
        objfrmSBAccList.BringToFront()
        objfrmSBAccList.MdiParent = Me
        objfrmSBAccList.Show()
        objfrmSBAccList = Nothing

    End Sub

    '***************  Reports
    Private Sub btnReports_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReports.Click
        Dim objReport As New frmReport
        objReport = frmReport.DefInstance
        objReport.MdiParent = Me
        objReport.BringToFront()
        objReport.Show()
        objReport = Nothing
    End Sub

    '*************** Members List
    Private Sub btnMembers_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMembers.Click
        'Dim objMemberList As frmMembersList
        'objMemberList = frmMembersList.DefInstance
        'objMemberList.MdiParent = Me
        'objMemberList.BringToFront()
        'objMemberList.Show()
        'objMemberList = Nothing

        Dim objCustormerList As New frmCustormerList
        objCustormerList = frmCustormerList.DefInstance
        objCustormerList.MdiParent = Me
        objCustormerList.BringToFront()
        objCustormerList.Show()
        objCustormerList = Nothing

    End Sub

#End Region

#Region " Deposits"

    '*************** FD Closure
    Private Sub MenuItem36_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem36.Click
        Dim objfrmFDClosure As frmFDClosure
        objfrmFDClosure = frmFDClosure.DefInstance
        objfrmFDClosure.MdiParent = Me
        objfrmFDClosure.BringToFront()
        objfrmFDClosure.Show()
        objfrmFDClosure = Nothing
    End Sub

    '*************** FD Creation
    Private Sub MenuItem32_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem32.Click
        Dim objfrmFDCreation As frmFDCreation
        objfrmFDCreation = frmFDCreation.DefInstance
        objfrmFDCreation.MdiParent = Me
        objfrmFDCreation.BringToFront()
        objfrmFDCreation.Show()
        objfrmFDCreation = Nothing
    End Sub

    '*************** FD Renewal
    Private Sub MenuItem35_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem35.Click
        Dim objFDRenewal As New frmFDRenewal
        objFDRenewal = frmFDRenewal.DefInstance
        'objFDRenewal.MdiParent = Me
        'objFDRenewal.BringToFront()
        objFDRenewal.ShowDialog()
        objFDRenewal = Nothing
    End Sub

    '*************** DuplicateFD
    Private Sub smnuDuplicateFD_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles smnuDuplicateFD.Click
        Dim objDuplicateFD As New frmDuplicateFD
        objDuplicateFD = frmDuplicateFD.DefInstance
        objDuplicateFD.ShowDialog()
        objDuplicateFD = Nothing
    End Sub

    '*************** FD Premature
    Private Sub smnuFDPremature_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles smnuFDPremature.Click
        Dim objFDPremature As New frmFDPremature
        'objFDPremature = frmFDPremature.DefInstance
        objFDPremature.ShowDialog()
        objFDPremature = Nothing
    End Sub

    '*************** FD Payments
    Private Sub MenuItem33_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem33.Click
        Dim objFrmFDPay As New frmFDPayments
        ' objFrmFDPay = frmFDPayments.DefInstance
        objFrmFDPay.ShowDialog()
        objFrmFDPay = Nothing


    End Sub

    '*************** Pigmy Account Creation
    Private Sub MenuItem44_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem44.Click

        Dim objfrmPGAcc As New frmPigmyAccCreation
        objfrmPGAcc = frmPigmyAccCreation.DefInstance
        objfrmPGAcc.BringToFront()
        objfrmPGAcc.MdiParent = Me
        objfrmPGAcc.Show()
        objfrmPGAcc = Nothing

    End Sub

    '*************** Pigmy List
    Private Sub MenuItem46_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem46.Click

        Dim objPigmyList As New frmPigmyList
        objPigmyList = frmPigmyList.DefInstance
        objPigmyList.BringToFront()
        objPigmyList.MdiParent = Me
        objPigmyList.Show()
        objPigmyList = Nothing

    End Sub

    '*************** Pigmy Closure
    Private Sub MenuItem45_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem45.Click

        Dim objPigmyClosure As New frmPigmyClosure
        objPigmyClosure = frmPigmyClosure.DefInstance
        objPigmyClosure.BringToFront()
        objPigmyClosure.MdiParent = Me
        objPigmyClosure.Show()
        objPigmyClosure = Nothing

    End Sub

    '*************** RD Account Creation
    Private Sub MenuItem38_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem38.Click

        Dim objfrmRD As New frmRDAccCreation
        objfrmRD = frmRDAccCreation.DefInstance
        objfrmRD.BringToFront()
        objfrmRD.MdiParent = Me
        objfrmRD.Show()
        objfrmMain = Nothing

    End Sub

    '*************** RD List
    Private Sub MenuItem43_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem43.Click

        Dim objFrmRDList As New frmRDList
        objFrmRDList = frmRDList.DefInstance
        objFrmRDList.BringToFront()
        objFrmRDList.MdiParent = Me
        objFrmRDList.Show()
        objFrmRDList = Nothing

    End Sub

    '*************** RD Closure
    Private Sub smnuRDClosure_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles smnuRDClosure.Click

        Dim objFrmRDClosure As New frmRDClosure
        objFrmRDClosure = frmRDClosure.DefInstance
        objFrmRDClosure.BringToFront()
        objFrmRDClosure.MdiParent = Me
        objFrmRDClosure.Show()
        objFrmRDClosure = Nothing

    End Sub

#End Region

#Region "Administration"

    '*************** Chainge password
    Private Sub MenuItem81_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem81.Click
        Dim objfrmChangePassword As New frmChangePassword
        objfrmChangePassword.ShowDialog(Me)
        objfrmChangePassword = Nothing
    End Sub
    '*************** Permission Setting
    Private Sub MenuItem65_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem65.Click
        Dim objfrmPerm As frmPermission
        objfrmPerm = frmPermission.DefInstance
        objfrmPerm.BringToFront()
        objfrmPerm.MdiParent = Me
        objfrmPerm.Show()
        objfrmPerm = Nothing
    End Sub

    '********** View User
    Private Sub MenuItem64_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem64.Click

        Dim objviewuser As New frmViewUser
        objviewuser.ShowDialog(Me)
        objviewuser = Nothing

    End Sub

    '*************** User Creation
    Private Sub MenuItem16_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem16.Click
        Dim objUserCreation As New frmUserCreation
        objUserCreation.ShowDialog(Me)
        objUserCreation = Nothing
    End Sub


#End Region

#Region "Accounting System"

    '*************** Voucher Entry
    Private Sub MenuItem57_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem57.Click

        Dim objfrmVocuherEntry As New frmVoucherEntry
        objfrmVocuherEntry.ShowDialog()
        objfrmVocuherEntry = Nothing

    End Sub

    '*************** Group Creation
    Private Sub MenuItem51_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem51.Click
        Dim objfrmGroupCreation As frmGroupCreation
        objfrmGroupCreation = frmGroupCreation.DefInstance
        objfrmGroupCreation.BringToFront()
        objfrmGroupCreation.MdiParent = Me
        objfrmGroupCreation.Show()
        objfrmGroupCreation = Nothing
    End Sub

    '*************** Ledger Creation
    Private Sub MenuItem53_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem53.Click
        Dim objfrmLedgerCreation As frmLedgerCreation
        objfrmLedgerCreation = frmLedgerCreation.DefInstance
        objfrmLedgerCreation.BringToFront()
        objfrmLedgerCreation.MdiParent = Me
        objfrmLedgerCreation.Show()
        objfrmLedgerCreation = Nothing
    End Sub

    '*************** Ledger Details
    Private Sub MenuItem76_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem76.Click
        Dim objfrmLwdgerDetails As frmLedgerDetails
        objfrmLwdgerDetails = frmLedgerDetails.DefInstance
        objfrmLwdgerDetails.BringToFront()
        objfrmLwdgerDetails.MdiParent = Me
        objfrmLwdgerDetails.Show()
        objfrmLwdgerDetails = Nothing
    End Sub

    '***************Trial Balance
    Private Sub MenuItem59_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem59.Click
        'Dim objfrmBalanceSheet As frmBalanceSheet
        'Dim objfrmBalanceSheet As BSheet
        'objfrmBalanceSheet = BSheet.DefInstance


        'objfrmBalanceSheet = frmBalanceSheet.DefInstance
        'objfrmBalanceSheet.BringToFront()
        'objfrmBalanceSheet.MdiParent = Me
        'objfrmBalanceSheet.Show()
        'objfrmBalanceSheet = Nothing

        '******************Actual Code of Balance Sheet*********************8
        'Dim objfrmBalanceSheet1 As TrialBalanceSheet
        'objfrmBalanceSheet1 = TrialBalanceSheet.DefInstance
        'objfrmBalanceSheet1.BringToFront()
        'objfrmBalanceSheet1.MdiParent = Me
        'objfrmBalanceSheet1.Show()
        'objfrmBalanceSheet1 = Nothing



    End Sub

    '*************** Day Book
    Private Sub MenuItem88_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem88.Click
        Dim objfrmDayBook As frmDayBook
        objfrmDayBook = frmDayBook.DefInstance
        objfrmDayBook.BringToFront()
        objfrmDayBook.MdiParent = Me
        objfrmDayBook.Show()
        objfrmDayBook = Nothing
    End Sub

    '*************** Income Expenditure
    Private Sub MenuItem60_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem60.Click
        Dim objfrmIncomeExp As frmIncomeExpenditure
        objfrmIncomeExp = frmIncomeExpenditure.DefInstance
        objfrmIncomeExp.BringToFront()
        objfrmIncomeExp.MdiParent = Me
        objfrmIncomeExp.Show()
        objfrmIncomeExp = Nothing
    End Sub

    '***************Balance sheet
    Private Sub MenuItem52_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem52.Click
        'Dim objfrmBalanceSheet As frmPaymentReceipt
        'objfrmBalanceSheet = frmPaymentReceipt.DefInstance()
        'objfrmBalanceSheet.BringToFront()
        'objfrmBalanceSheet.MdiParent = Me
        'objfrmBalanceSheet.Show()
        'objfrmBalanceSheet = Nothing

        Dim objfrmBalanceSheet1 As TrialBalanceSheet
        objfrmBalanceSheet1 = TrialBalanceSheet.DefInstance
        objfrmBalanceSheet1.BringToFront()
        objfrmBalanceSheet1.MdiParent = Me
        objfrmBalanceSheet1.Show()
        objfrmBalanceSheet1 = Nothing
    End Sub

    '*************** Purchase And Sales
    Private Sub MenuItem93_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem93.Click
        Dim obj As frmSalesPurchase
        obj = frmSalesPurchase.DefInstance
        obj.BringToFront()
        obj.MdiParent = Me
        obj.Show()
        obj = Nothing
    End Sub

    '*************** Cash Book
    Private Sub MenuItem89_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem89.Click
        Dim objfrmDayBook As frmCashBook
        objfrmDayBook = frmCashBook.DefInstance
        objfrmDayBook.BringToFront()
        objfrmDayBook.MdiParent = Me
        objfrmDayBook.Show()
        objfrmDayBook = Nothing
    End Sub

    '*************** Scroll Book
    Private Sub MenuItem103_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem103.Click
        Dim odjfrmScrollBook As frmScrollBook
        odjfrmScrollBook = frmScrollBook.DefInstance
        odjfrmScrollBook.BringToFront()
        odjfrmScrollBook.MdiParent = Me
        odjfrmScrollBook.Show()
        odjfrmScrollBook = Nothing
    End Sub

#End Region

#Region "Master Settings"

    '*************** Shares Configuration
    Private Sub MenuItem98_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem98.Click
        Dim objSharesConfig As New frmShareConfiguration
        objSharesConfig = frmShareConfiguration.DefInstance
        ' objSharesConfig.MdiParent = Me
        'objSharesConfig.BringToFront()
        objSharesConfig.Show()
        objSharesConfig = Nothing
    End Sub

    '*************** SB Master Settings
    Private Sub MenuItem106_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem106.Click
        Dim objfrmMasterSettings As New frmSBMasterSettings
        objfrmMasterSettings = frmSBMasterSettings.DefInstance
        'objfrmMasterSettings.MdiParent = Me
        objfrmMasterSettings.BringToFront()
        objfrmMasterSettings.Show()
        objfrmMasterSettings = Nothing
    End Sub

    '*************** FD Master Setting
    Private Sub MenuItem107_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem107.Click
        Dim objFDMaster As New frmFDMaster
        objFDMaster = frmFDMaster.DefInstance
        objFDMaster.MdiParent = Me
        objFDMaster.BringToFront()
        objFDMaster.Show()
        objFDMaster = Nothing
    End Sub

    '*************** RD Configure
    Private Sub MenuItem108_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem108.Click
        Dim objFrmRDConfig As New frmRDConfigure
        objFrmRDConfig = frmRDConfigure.DefInstance
        objFrmRDConfig.BringToFront()
        objFrmRDConfig.MdiParent = Me
        objFrmRDConfig.Show()
        objFrmRDConfig = Nothing
    End Sub

    '*************** RD Master Intrest Settings
    Private Sub MenuItem109_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem109.Click
        Dim objFrmRDMaster As New frmRDMasterIntSettings
        objFrmRDMaster = frmRDMasterIntSettings.DefInstance
        objFrmRDMaster.MdiParent = Me
        objFrmRDMaster.Show()
        objFrmRDMaster = Nothing
    End Sub

    '*************** Pigmy Configuration
    Private Sub MenuItem110_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem110.Click
        Dim objPigmyPeriod As New frmPigmyPeriod
        objPigmyPeriod = frmPigmyPeriod.DefInstance
        '        objPigmyPeriod.BringToFront()
        '       objPigmyPeriod.MdiParent = Me
        objPigmyPeriod.ShowDialog()
        objPigmyPeriod = Nothing
    End Sub

    '*************** Loan Intrest Setting
    Private Sub MenuItem100_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem100.Click
        'Dim objLoanSettings As New frmLoanInterest
        'objLoanSettings = frmLoanInterest.DefInstance
        Dim objLoanSettings As New frmLoanIntrestSettins
        objLoanSettings = frmLoanIntrestSettins.DefInstance
        'objLoanSettings.MdiParent = Me
        'objLoanSettings.BringToFront()
        objLoanSettings.ShowDialog()
        objLoanSettings = Nothing
    End Sub

    '************ CA Master Setting
    Private Sub MenuItem105_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem105.Click
        Dim objfrmMasterSettings As New frmCAMasterSetting
        objfrmMasterSettings = frmCAMasterSetting.DefInstance
        'objfrmMasterSettings.MdiParent = Me
        objfrmMasterSettings.BringToFront()
        objfrmMasterSettings.Show()
        objfrmMasterSettings = Nothing
    End Sub

#End Region

#Region "Savings Bank Account"

    '************   New SB Account
    Private Sub MenuItem13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem13.Click
        Dim objSBAccCreation As frmSBAccCreation
        objSBAccCreation = frmSBAccCreation.DefInstance
        objSBAccCreation.MdiParent = Me
        objSBAccCreation.BringToFront()
        objSBAccCreation.Show()
        objSBAccCreation = Nothing
    End Sub

    '************   Deposit Cheque
    Private Sub MenuItem19_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem19.Click
        Dim objfrmSBChequeDeposit As New frmSBChequeDeposit
        objfrmSBChequeDeposit.ShowDialog(Me)
        objfrmSBChequeDeposit = Nothing
    End Sub

    '************   Cheque Details
    Private Sub MenuItem20_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem20.Click
        Dim objsbChequeDet As New frmSBChequeStatusDetails
        objsbChequeDet = frmSBChequeStatusDetails.DefInstance
        objsbChequeDet.MdiParent = Me
        objsbChequeDet.BringToFront()
        objsbChequeDet.Show()
        objsbChequeDet = Nothing
    End Sub

    '************   Close SB Account
    Private Sub MenuItem23_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem23.Click
        Dim objfrmSBClosure As New frmSBClouser
        objfrmSBClosure = frmSBClouser.DefInstance
        'objfrmSBClosure.BringToFront()
        'objfrmSBClosure.MdiParent = Me
        objfrmSBClosure.ShowDialog()
        objfrmSBClosure = Nothing
    End Sub

    '************   View SB Account
    Private Sub MenuItem24_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem24.Click
        Dim objfrmSBAccList As frmSBAccList
        objfrmSBAccList = frmSBAccList.DefInstance
        objfrmSBAccList.BringToFront()
        objfrmSBAccList.MdiParent = Me
        objfrmSBAccList.Show()
        objfrmSBAccList = Nothing
    End Sub

    '************  SB Intrest Calculation
    Private Sub MenuItem25_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem25.Click
        Dim objsbInterestCal As New frmSBinterestCalculation
        'objsbInterestCal = frmSBinterestCalculation.DefInstance
        ' objsbInterestCal.MdiParent = Me
        ' objsbInterestCal.BringToFront()
        objsbInterestCal.ShowDialog()
        objsbInterestCal = Nothing
    End Sub

    '************    SB Transaction View
    Private Sub MenuItem26_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem26.Click
        Dim objSBActStmt As New frmSBStmtOfAccount
        objSBActStmt.ShowDialog()
    End Sub

    '************    SB ChequeStopPay
    Private Sub MenuItem28_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem28.Click
        Dim objStopCheque As New frmStopCheque
        objStopCheque = frmStopCheque.DefInstance
        objStopCheque.ShowDialog()
        objStopCheque = Nothing
    End Sub

    '************    SB Cheque Withdraw
    Private Sub MenuItem55_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem55.Click
        Dim objfrmSBChqWithDraw As New frmSBChequeWithdraw
        objfrmSBChqWithDraw = frmSBChequeWithdraw.DefInstance
        'objfrmShareDividend.MdiParent = Me
        'objfrmShareDividend.BringToFront()
        objfrmSBChqWithDraw.Show()
        objfrmSBChqWithDraw = Nothing
    End Sub

    '************   SB Reports
    Private Sub MenuItem101_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem101.Click
        Dim objFrmSbreports As New frmSBReports
        objFrmSbreports.ShowDialog(Me)

    End Sub

    '************   SB ChequeBookIssueReports
    Private Sub MenuItem21_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem21.Click
        Dim objfrmSBIssueChequeBook As New frmSBChequeBookIssue
        objfrmSBIssueChequeBook.ShowDialog(Me)
        objfrmSBIssueChequeBook = Nothing
    End Sub

#End Region

#Region "Current Account"

    '************   New CA Account
    Private Sub MenuItem102_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem102.Click
        Dim objCAAccCreation As frmCAccCreation
        objCAAccCreation = frmCAccCreation.DefInstance
        objCAAccCreation.BringToFront()
        objCAAccCreation.MdiParent = Me
        objCAAccCreation.Show()
        objCAAccCreation = Nothing
    End Sub

    '************  View CA Account
    Private Sub MenuItem104_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem104.Click
        Dim objCAAccList As frmCAcclist
        objCAAccList = frmCAcclist.DefInstance()
        objCAAccList.BringToFront()
        objCAAccList.MdiParent = Me
        objCAAccList.Show()
        objCAAccList = Nothing
    End Sub

#End Region

#Region "Loans"

    '*************** Gold Loan
    Private Sub MenuItem94_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem94.Click
        Dim objFrmGoldLoan As frmGoldLoanDetails
        objFrmGoldLoan = frmGoldLoanDetails.DefInstance
        objFrmGoldLoan.BringToFront()
        objFrmGoldLoan.MdiParent = Me
        objFrmGoldLoan.Show()
        objFrmGoldLoan = Nothing
    End Sub

    '**************** Vehicle Loan
    Private Sub MenuItem95_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem95.Click
        Dim objFrmVehicleLoan As New frmVehicleLoanDetails
        objFrmVehicleLoan = frmVehicleLoanDetails.DefInstance
        objFrmVehicleLoan.BringToFront()
        objFrmVehicleLoan.MdiParent = Me
        objFrmVehicleLoan.Show()
        objFrmVehicleLoan = Nothing
    End Sub

    '*************** MediumTerm Loan
    Private Sub MenuItem97_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ' Dim objFrmMediumTermLoan As frmMediumTermLoan
        ' objFrmMediumTermLoan = frmMediumTermLoan.DefInstance
        'objFrmMediumTermLoan.BringToFront()
        'objFrmMediumTermLoan.MdiParent = Me
        'objFrmMediumTermLoan.Show()
        'objFrmMediumTermLoan = Nothing
    End Sub
    '*************** OD Loan
    'Private Sub MenuItem99_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem138.Click
    '    Dim objfrmODLoanDetails As New frmODLoanDetails
    '    objfrmODLoanDetails = frmODLoanDetails.DefInstance
    '    objfrmODLoanDetails.MdiParent = Me
    '    objfrmODLoanDetails.BringToFront()
    '    objfrmODLoanDetails.Show()
    '    objfrmODLoanDetails = Nothing
    'End Sub
    Private Sub MenuItem99_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem138.Click
        Dim objfrmODLoanDetails As New frmODLoanDetails
        objfrmODLoanDetails = frmODLoanDetails.DefInstance
        objfrmODLoanDetails.MdiParent = Me
        objfrmODLoanDetails.BringToFront()
        objfrmODLoanDetails.Show()
        objfrmODLoanDetails = Nothing
    End Sub
    '***************Loan Defaulters
    Private Sub smnuDefaulters_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles smnuDefaulters.Click
        Dim objfrmDefaulter As New frmDefaulters
        objfrmDefaulter = frmDefaulters.DefInstance
        objfrmDefaulter.MdiParent = Me
        objfrmDefaulter.BringToFront()
        objfrmDefaulter.Show()
        objfrmDefaulter = Nothing
    End Sub
#End Region

    Private Sub MenuItem68_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem68.Click
        'Dim objfrmoccupation As New frmOccupation
        'objfrmoccupation.MdiParent = Me
        'objfrmoccupation.Show()
        'objfrmoccupation = Nothing
    End Sub

    Private Sub MenuItem112_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem112.Click
        Dim objVillage As New frmCityArea
        objVillage.MdiParent = Me
        objVillage.Show()
        objVillage = Nothing
    End Sub

    Private Sub MenuItem111_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem111.Click
        Dim objfrmoccupation As New frmOccupation
        'objfrmoccupation.MdiParent = Me
        objfrmoccupation.ShowDialog()
        objfrmoccupation = Nothing
    End Sub

    Private Sub MenuItem96_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem96.Click
        Dim objfrmReligion As New frmReligion
        objfrmReligion = frmReligion.DefInstance
        'objfrmReligion.MdiParent = Me
        objfrmReligion.BringToFront()
        objfrmReligion.ShowDialog()
        objfrmReligion = Nothing
    End Sub

    Private Sub MenuItem113_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem113.Click
        Dim objCaste As New frmCaste
        ' objCaste.MdiParent = Me
        objCaste.ShowDialog()
        objCaste = Nothing
    End Sub

    Private Sub MenuItem114_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem114.Click
        Dim objfrmSBWithdraw As New frmCashTransaction
        objfrmSBWithdraw.ShowDialog(Me)
        objfrmSBWithdraw = Nothing
    End Sub

    Private Sub MenuItem115_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem115.Click
        Dim objfrmDayBook As frmTransferScroll
        objfrmDayBook = frmTransferScroll.DefInstance
        objfrmDayBook.BringToFront()
        objfrmDayBook.MdiParent = Me
        objfrmDayBook.Show()
        objfrmDayBook = Nothing
    End Sub

    Private Sub MenuItem116_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem116.Click
        Dim objfrmCACashTransaction As New frmCACashTransaction
        objfrmCACashTransaction.ShowDialog(Me)
        objfrmCACashTransaction = Nothing
    End Sub

    Private Sub MenuItem118_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem118.Click
        Dim objFrmRDDeposit As New frmRDDeposit

        objFrmRDDeposit.ShowDialog()
    End Sub

    Private Sub MenuItem119_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem119.Click
        Dim objFrmRDPremature As New frmRDPreMature
        objFrmRDPremature.ShowDialog()
    End Sub

    Private Sub MenuItem120_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem120.Click
        Dim objfrmCHandLoan As frmColleteralHandLoanDetail
        objfrmCHandLoan = frmColleteralHandLoanDetail.DefInstance
        objfrmCHandLoan.BringToFront()
        objfrmCHandLoan.MdiParent = Me
        objfrmCHandLoan.Show()
        objfrmCHandLoan = Nothing
    End Sub

    Private Sub MenuItem121_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem121.Click
        Dim objfrmSuretyLoan As frmSuretyLoanDetails
        objfrmSuretyLoan = frmSuretyLoanDetails.DefInstance
        objfrmSuretyLoan.BringToFront()
        objfrmSuretyLoan.MdiParent = Me
        objfrmSuretyLoan.Show()
        objfrmSuretyLoan = Nothing
    End Sub

    Private Sub MenuItem122_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem122.Click
        Dim objfrmHandLoan As frmHandLoan
        objfrmHandLoan = frmHandLoan.DefInstance
        objfrmHandLoan.BringToFront()
        objfrmHandLoan.MdiParent = Me
        objfrmHandLoan.Show()
        objfrmHandLoan = Nothing
    End Sub

    Private Sub MenuItem123_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem123.Click
        Dim objfrmLoansOnDeposit As frmLoanAgainstDepositDetails
        objfrmLoansOnDeposit = frmLoanAgainstDepositDetails.DefInstance
        objfrmLoansOnDeposit.BringToFront()
        objfrmLoansOnDeposit.MdiParent = Me
        objfrmLoansOnDeposit.Show()
        objfrmLoansOnDeposit = Nothing
    End Sub

    Private Sub MenuItem124_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem124.Click
        Dim objfrmDRLoan As frmDailyRecoveryLoan
        objfrmDRLoan = frmDailyRecoveryLoan.DefInstance
        objfrmDRLoan.BringToFront()
        objfrmDRLoan.MdiParent = Me
        objfrmDRLoan.Show()
        objfrmDRLoan = Nothing
    End Sub

    Private Sub MenuItem125_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem125.Click
        Dim objfrmCAIntPosting As frmCAinterestPosting
        objfrmCAIntPosting = frmCAinterestPosting.DefInstance
        objfrmCAIntPosting.BringToFront()
        objfrmCAIntPosting.ShowDialog(Me)
        objfrmCAIntPosting = Nothing
    End Sub


    Private Sub MenuItem84_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem84.Click
        Dim objFrmDayEnd As New frmDayEnd
        ' objFrmDayEnd.MdiParent = Me
        objFrmDayEnd.BringToFront()
        objFrmDayEnd.ShowDialog(Me)
        objFrmDayEnd = Nothing

        'objfrmSBCashdeposit.ShowDialog(Me)
        'objfrmSBCashdeposit = Nothing


        'Dim objCaste As New frmCaste
        'objCaste.MdiParent = Me
        'objCaste.Show()
        'objCaste = Nothing

        'objSBAccCreation = frmSBAccCreation.DefInstance
        'objSBAccCreation.MdiParent = Me
        'objSBAccCreation.BringToFront()
        'objSBAccCreation.Show()
        'objSBAccCreation = Nothing

        'Dim objfrmChequeStopPay As New frmSBChequeStopPay
        'objfrmChequeStopPay.ShowDialog()

    End Sub


    Private Sub MenuItem126_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem126.Click
        Dim objLoanRepaymentTool As New frmLoanRepayment
        objLoanRepaymentTool.BringToFront()
        objLoanRepaymentTool.ShowDialog(Me)
        objLoanRepaymentTool = Nothing

    End Sub

    Private Sub MenuItem79_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem79.Click

        Dim objDBBackUp As New frmDBbackup
        objDBBackUp.BringToFront()
        objDBBackUp.ShowDialog(Me)
        objDBBackUp = Nothing

    End Sub

    Private Sub MenuItem127_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem127.Click
        Dim objCAActStmt As New frmCAStmt
        objCAActStmt.ShowDialog()
        objCAActStmt = Nothing
    End Sub

    Private Sub MenuItem129_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem129.Click

        Dim objCBPCreation As frmCBPCreation
        objCBPCreation = frmCBPCreation.DefInstance
        objCBPCreation.MdiParent = Me
        objCBPCreation.BringToFront()
        objCBPCreation.Show()
        objCBPCreation = Nothing

    End Sub

    Private Sub MenuItem130_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem130.Click

        Dim objfrmSBAccList As frmCBPLIst
        objfrmSBAccList = frmCBPLIst.DefInstance
        objfrmSBAccList.BringToFront()
        objfrmSBAccList.MdiParent = Me
        objfrmSBAccList.Show()
        objfrmSBAccList = Nothing
    End Sub

    Private Sub MenuItem131_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem131.Click
        Dim objCBPTransaction As New frmCBPClearing
        objCBPTransaction.ShowDialog()
        objCBPTransaction = Nothing
    End Sub

    Private Sub frmMain_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        End
    End Sub

    Private Sub MenuItem134_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem134.Click
        Dim objCAChequeDetail As frmChequeDepositDetail
        objCAChequeDetail = frmChequeDepositDetail.DefInstance()
        objCAChequeDetail.BringToFront()
        objCAChequeDetail.MdiParent = Me
        objCAChequeDetail.Show()
        objCAChequeDetail = Nothing

    End Sub

    Private Sub MenuItem132_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem132.Click
        Dim objChequeDeposit As New frmCAChequeDeposit
        objChequeDeposit.ShowDialog()
        objChequeDeposit = Nothing
    End Sub

    Private Sub MenuItem133_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem133.Click
        Dim objChequeWithdraw As New frmCAChequeWithdraw
        objChequeWithdraw.ShowDialog()
        objChequeWithdraw = Nothing
    End Sub

    Private Sub MenuItem135_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem135.Click
        Dim objChequeBook As New frmCAchequeBookIssue
        objChequeBook.ShowDialog()
        objChequeBook = Nothing
    End Sub

    Private Sub MenuItem77_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem77.Click
        Dim objPGDeposit As New frmPigmyDeposit
        objPGDeposit.ShowDialog()
        objPGDeposit = Nothing
    End Sub

    Private Sub MenuItem97_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem97.Click
        Dim objPigmyWithDrawl As New frmPigmyPreMature
        objPigmyWithDrawl.ShowDialog()
        objPigmyWithDrawl = Nothing

    End Sub

    Private Sub MenuItem136_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem136.Click
        Dim objAgentList As New frmPigmyAgent
        objAgentList.ShowDialog()
        objAgentList = Nothing

    End Sub

    Private Sub MenuItem137_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        Dim objfrmBalanceSheet1 As TrialBalanceSheet
        objfrmBalanceSheet1 = TrialBalanceSheet.DefInstance
        objfrmBalanceSheet1.BringToFront()
        objfrmBalanceSheet1.MdiParent = Me
        objfrmBalanceSheet1.Show()
        objfrmBalanceSheet1 = Nothing

    End Sub

    Private Sub MenuItem139_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem139.Click
        Dim objfrmODList As New frmODList
        objfrmODList = frmODList.DefInstance
        objfrmODList.MdiParent = Me
        objfrmODList.BringToFront()
        objfrmODList.Show()
        objfrmODList = Nothing
    End Sub

    Private Sub MenuItem140_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem140.Click
        Dim objfrmBranch As New frmBranchIntCal
        objfrmBranch = frmBranchIntCal.DefInstance
        objfrmBranch.ShowDialog(Me)
        objfrmBranch = Nothing
    End Sub

    Private Sub MenuItem141_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem141.Click
        Dim objCustomer As New frmCustomer
        objCustomer = frmCustomer.DefInstance
        objCustomer.MdiParent = Me
        objCustomer.BringToFront()
        objCustomer.Show()
        objCustomer = Nothing
    End Sub

    Private Sub MenuItem142_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem142.Click
        Dim objCustormerList As New frmCustormerList
        objCustormerList = frmCustormerList.DefInstance
        objCustormerList.MdiParent = Me
        objCustormerList.BringToFront()
        objCustormerList.Show()
        objCustormerList = Nothing
    End Sub

    Private Sub MenuItem143_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem143.Click
        Dim objFDTrasnaction As New frmFDInterestTransaction
        objFDTrasnaction.ShowDialog(Me)
        objFDTrasnaction = Nothing
    End Sub

    Private Sub MenuItem144_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem144.Click
        Dim objfrmRepay As New frmRepay
        objfrmRepay.ShowDialog(Me)
        objfrmRepay = Nothing
    End Sub

    Private Sub MenuItem145_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem145.Click
        Dim objfrmoddayend As New frmoddayend
        objfrmoddayend.ShowDialog()
        objfrmoddayend = Nothing
        'Dim objfrmoddayend As frmoddayend
        'objfrmoddayend = frmoddayend.DefInstance
        'objfrmoddayend.BringToFront()
        'objfrmoddayend.ShowDialog(Me)
        'objfrmoddayend = Nothing
    End Sub

    Private Sub MenuItem146_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem146.Click
        Dim objRDProvision As New frmProvisionPayments
        objRDProvision.dtpDate.Value = Date.Now
        objRDProvision.ShowDialog()
    End Sub

    Private Sub MenuItem147_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem147.Click
        Dim objCustomer As New frmBnncToBnnd

        objCustomer.ShowDialog()
    End Sub

    Private Sub MenuItem148_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem148.Click
        Dim objCustomer As New fmAgentsCustomers

        objCustomer.ShowDialog()
    End Sub

    Private Sub MenuItem149_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem149.Click
        Dim objCustomer As New frmAgentsPerCaliculation

        objCustomer.ShowDialog()
    End Sub

    Private Sub MenuItem27_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem27.Click
        Dim objfrmMembersList As New frmMembersList
        objfrmMembersList = frmMembersList.DefInstance
        objfrmMembersList.MdiParent = Me
        objfrmMembersList.BringToFront()
        objfrmMembersList.Show()
        objfrmMembersList = Nothing

    End Sub

    Private Sub MenuItem86_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem86.Click

    End Sub
    '*****Receipt and Payments
    Private Sub MenuItem61_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem61.Click
        'Dim objfrmBalanceSheet1 As TrialBalanceSheet
        'objfrmBalanceSheet1 = TrialBalanceSheet.DefInstance
        'objfrmBalanceSheet1.BringToFront()
        'objfrmBalanceSheet1.MdiParent = Me
        'objfrmBalanceSheet1.Show()
        'objfrmBalanceSheet1 = Nothing

        Dim objfrmBalanceSheet As frmPaymentReceipt
        objfrmBalanceSheet = frmPaymentReceipt.DefInstance()
        objfrmBalanceSheet.BringToFront()
        objfrmBalanceSheet.MdiParent = Me
        objfrmBalanceSheet.Show()
        objfrmBalanceSheet = Nothing


    End Sub

    Private Sub MenuItem137_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem137.Click
        Dim objCustormerList As New frmCustormerList
        objCustormerList = frmCustormerList.DefInstance
        objCustormerList.MdiParent = Me
        objCustormerList.BringToFront()
        objCustormerList.Show()
        objCustormerList = Nothing
    End Sub

    Private Sub frmMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Dim objfrmNotifyFdMature As New frmNotifyFdMature
        'objfrmNotifyFdMature = frmNotifyFdMature.DefInstance
        'objfrmNotifyFdMature.MdiParent = Me
        'objfrmNotifyFdMature.BringToFront()
        'objfrmNotifyFdMature.Show()
        'objfrmNotifyFdMature = Nothing


        ''Dim objSnooze As New Snooze
        ' '' objSnooze = Snooze.DefInstance
        ' ''objSnooze.MdiParent = Me
        ' ''objSnooze.BringToFront()
        ''objSnooze.ShowDialog()
        ''objSnooze = Nothing


    End Sub

    Private Sub MenuItem151_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem151.Click
        Dim objSBStmtOfAccount As New frmSBStmtOfAccount
        objSBStmtOfAccount = frmSBStmtOfAccount.DefInstance
        objSBStmtOfAccount.MdiParent = Me
        objSBStmtOfAccount.BringToFront()
        objSBStmtOfAccount.Show()
        objSBStmtOfAccount = Nothing
    End Sub

    Private Sub MenuItem152_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem152.Click
        Dim objCAStmt As New frmCAStmt
        objCAStmt = frmCAStmt.DefInstance
        objCAStmt.MdiParent = Me
        objCAStmt.BringToFront()
        objCAStmt.Show()
        objCAStmt = Nothing
    End Sub

    Private Sub MenuItem172_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem172.Click
        Dim objCBPLIst As New frmCBPLIst
        objCBPLIst = frmCBPLIst.DefInstance
        objCBPLIst.MdiParent = Me
        objCBPLIst.BringToFront()
        objCBPLIst.Show()
        objCBPLIst = Nothing
    End Sub

    Private Sub MenuItem171_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem171.Click
        Dim objDefaulters As New frmDefaulters
        objDefaulters = frmDefaulters.DefInstance
        objDefaulters.MdiParent = Me
        objDefaulters.BringToFront()
        objDefaulters.Show()
        objDefaulters = Nothing
    End Sub

    Private Sub MenuItem155_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem155.Click
        Dim objLedgerDetails As New frmLedgerDetails
        objLedgerDetails = frmLedgerDetails.DefInstance
        objLedgerDetails.MdiParent = Me
        objLedgerDetails.BringToFront()
        objLedgerDetails.Show()
        objLedgerDetails = Nothing

    End Sub

    Private Sub MenuItem157_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem157.Click
        Dim objDayBook As New frmDayBook
        objDayBook = frmDayBook.DefInstance
        objDayBook.MdiParent = Me
        objDayBook.BringToFront()
        objDayBook.Show()
        objDayBook = Nothing
    End Sub

    Private Sub MenuItem156_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem156.Click
        Dim objCashBook As New frmCashBook
        objCashBook = frmCashBook.DefInstance
        objCashBook.MdiParent = Me
        objCashBook.BringToFront()
        objCashBook.Show()
        objCashBook = Nothing
    End Sub

    Private Sub MenuItem173_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem173.Click
        Dim objBalanceSheet As New frmBalanceSheet
        objBalanceSheet = frmBalanceSheet.DefInstance
        objBalanceSheet.MdiParent = Me
        objBalanceSheet.BringToFront()
        objBalanceSheet.Show()
        objBalanceSheet = Nothing
    End Sub

    Private Sub MenuItem176_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem176.Click
        Dim objBalanceSheet As New frmPaymentReceipt
        objBalanceSheet = frmPaymentReceipt.DefInstance
        objBalanceSheet.MdiParent = Me
        objBalanceSheet.BringToFront()
        objBalanceSheet.Show()
        objBalanceSheet = Nothing
    End Sub

    Private Sub MenuItem175_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem175.Click
        Dim objIncomeExpienditure As New IncomeExpinditure
        objIncomeExpienditure = IncomeExpinditure.DefInstance
        objIncomeExpienditure.MdiParent = Me
        objIncomeExpienditure.BringToFront()
        objIncomeExpienditure.Show()
        objIncomeExpienditure = Nothing
    End Sub

    Private Sub MenuItem177_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem177.Click
        Dim objBalanceSheet As New TrialBalanceSheet
        objBalanceSheet = TrialBalanceSheet.DefInstance
        objBalanceSheet.MdiParent = Me
        objBalanceSheet.BringToFront()
        objBalanceSheet.Show()
        objBalanceSheet = Nothing
    End Sub

    Private Sub MenuItem154_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem154.Click
        Dim objLoanAppliers As New frmLoanAppliers
        objLoanAppliers = frmLoanAppliers.DefInstance
        objLoanAppliers.MdiParent = Me
        objLoanAppliers.BringToFront()
        objLoanAppliers.Show()
        objLoanAppliers = Nothing
    End Sub

    Private Sub MenuItem42_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem42.Click
        Dim objLoanAppliers As New frmODTransaction
        objLoanAppliers = frmODTransaction.DefInstance
        objLoanAppliers.MdiParent = Me
        objLoanAppliers.BringToFront()
        objLoanAppliers.Show()
        objLoanAppliers = Nothing

    End Sub

    Private Sub MenuItem163_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem163.Click
        Dim objTransaction As New PendingBiils
        objTransaction = PendingBiils.DefInstance
        objTransaction.MdiParent = Me
        objTransaction.BringToFront()
        objTransaction.Show()
        objTransaction = Nothing
    End Sub

    Private Sub MenuItem164_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem164.Click
        Dim objSMTLLoanDetails As New frmSMTLLoanDetails
        objSMTLLoanDetails = frmSMTLLoanDetails.DefInstance
        objSMTLLoanDetails.MdiParent = Me
        objSMTLLoanDetails.BringToFront()
        objSMTLLoanDetails.Show()
        objSMTLLoanDetails = Nothing
    End Sub

    Private Sub MenuItem49_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem49.Click
        Dim objfrmBankCharges As New frmBankCharges
        objfrmBankCharges = frmBankCharges.DefInstance
        objfrmBankCharges.MdiParent = Me
        objfrmBankCharges.BringToFront()
        objfrmBankCharges.Show()
        objfrmBankCharges = Nothing
    End Sub

    Private Sub MenuItem167_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem167.Click
        Dim objfrmRenewalFDList As New frmRenewalFDList
        objfrmRenewalFDList = frmRenewalFDList.DefInstance
        objfrmRenewalFDList.MdiParent = Me
        objfrmRenewalFDList.BringToFront()
        objfrmRenewalFDList.Show()
        objfrmRenewalFDList = Nothing
    End Sub

    Private Sub MenuItem168_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem168.Click
        Dim objfrmDoubleThriable As New frmDoubleThriable
        objfrmDoubleThriable = frmDoubleThriable.DefInstance
        objfrmDoubleThriable.MdiParent = Me
        objfrmDoubleThriable.BringToFront()
        objfrmDoubleThriable.Show()
        objfrmDoubleThriable = Nothing

    End Sub

    Private Sub MenuItem166_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem166.Click
        Dim objfrmSMTLdayend As New frmSMTLdayend
        objfrmSMTLdayend.ShowDialog()
        objfrmSMTLdayend = Nothing
    End Sub

    Private Sub MenuItem165_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem165.Click
        Dim objfrmSMTLList As New frmSMTLList
        objfrmSMTLList = frmSMTLList.DefInstance()
        objfrmSMTLList.MdiParent = Me
        objfrmSMTLList.BringToFront()
        objfrmSMTLList.Show()
        objfrmSMTLList = Nothing
    End Sub

    Private Sub MenuItem169_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem169.Click
        Dim objfrmSMTLList As New Instructions
        objfrmSMTLList = Instructions.DefInstance()
        objfrmSMTLList.MdiParent = Me
        objfrmSMTLList.BringToFront()
        objfrmSMTLList.Show()
        objfrmSMTLList = Nothing
    End Sub

    Private Sub MenuItem170_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem170.Click

        Dim objMemberCashChequeDeposit As New MemberCashChequeDeposit
        'objMemberCashChequeDeposit = MemberCashChequeDeposit.DefInstance()
        'objMemberCashChequeDeposit.MdiParent = Me
        'objMemberCashChequeDeposit.BringToFront()
        objMemberCashChequeDeposit.ShowDialog()
        objMemberCashChequeDeposit = Nothing
    End Sub

    Private Sub MenuItem178_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem178.Click

        Dim objRelation As New frmRelation
        'objMemberCashChequeDeposit = MemberCashChequeDeposit.DefInstance()
        'objMemberCashChequeDeposit.MdiParent = Me
        'objMemberCashChequeDeposit.BringToFront()
        objRelation.ShowDialog()
        objRelation = Nothing
    End Sub

    Private Sub MenuItem179_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem179.Click
        Dim objfrmautobackup As New frmautobackup
        'objfrmautobackup = frmautobackup.DefInstance()
        'objfrmautobackup.MdiParent = Me
        objfrmautobackup.BringToFront()
        objfrmautobackup.ShowDialog()
        objfrmautobackup = Nothing
    End Sub

   
    Private Sub NewButton4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewButton4.Click
        Dim objfrmPassBookPrint As New frmPassBookPrint
        objfrmPassBookPrint.ShowDialog()
        objfrmPassBookPrint = Nothing
    End Sub

    Private Sub MenuItem180_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem180.Click
        Dim objPigmyMachine As New PigmyMachine
        objPigmyMachine.ShowDialog()
        objPigmyMachine = Nothing
    End Sub

    Private Sub MenuItem181_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem181.Click
        Dim objfrmMemberAddressPrinting As New frmMemberAddressPrinting
        objfrmMemberAddressPrinting.ShowDialog(Me)
        objfrmMemberAddressPrinting = Nothing
    End Sub

    Private Sub MenuItem182_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem182.Click
        Dim objfrmMemberEmail As New frmMemberEmail
        objfrmMemberEmail.ShowDialog(Me)

    End Sub

    Private Sub MenuItem184_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) 
        Dim objfrmVocuherEntry As New frmVoucherEntry
        objfrmVocuherEntry.ShowDialog()
        objfrmVocuherEntry = Nothing

        'Dim objfrmPaymentVoucher As New frmPaymentVoucher
        'objfrmPaymentVoucher.ShowDialog()
        'objfrmPaymentVoucher = Nothing

    End Sub

    'Private Sub MenuItem185_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem185.Click
    '    Dim objfrmReceiptVoucher As New frmReceiptVoucher
    '    objfrmReceiptVoucher.ShowDialog()
    '    objfrmReceiptVoucher = Nothing

    'End Sub

    'Private Sub MenuItem186_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem186.Click
    '    Dim objfrmTransferVoucher As frmTransferVoucher
    '    objfrmTransferVoucher.ShowDialog()
    '    objfrmTransferVoucher = Nothing

    'End Sub

    'Private Sub MenuItem187_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem187.Click
    '    Dim objfrmContravoucher As New frmContraVoucher
    '    objfrmContravoucher.ShowDialog()
    '    objfrmContravoucher = Nothing

    'End Sub

    
    
    'Private Sub MenuItem184_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem184.Click

    '    Dim objfrmPaymentVocuher As New frmPaymentVoucher
    '    objfrmPaymentVocuher.ShowDialog()
    '    objfrmPaymentVocuher = Nothing
    'End Sub

    'Private Sub MenuItem185_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem185.Click
    '    Dim objfrmReceiptVoucher As New frmReceiptVoucher
    '    objfrmReceiptVoucher.ShowDialog()
    '    objfrmReceiptVoucher = Nothing


    'End Sub

    'Private Sub MenuItem186_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem186.Click
    '    Dim objfrmTransferVoucher As New frmTransferVoucher
    '    objfrmTransferVoucher.ShowDialog()
    '    objfrmTransferVoucher = Nothing


    'End Sub

    'Private Sub MenuItem187_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem187.Click
    '    Dim objfrmContraVoucher As New frmContraVoucher
    '    objfrmContraVoucher.ShowDialog()
    '    objfrmContraVoucher = Nothing
    'End Sub



End Class
