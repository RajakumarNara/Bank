Imports System.Math

Public Class frmBalanceSheet
    Inherits System.Windows.Forms.Form

#Region "Global Variables"
    Dim objGroup As New clsGroups
    Dim objLedger As New clsLedger
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
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents lvLiability As System.Windows.Forms.ListView
    Friend WithEvents btnClose As BankControls.NewButton
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lvAsset As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtLiabilityTotal As BankControls.TextControl
    Friend WithEvents txtAssetTotal As BankControls.TextControl
    Friend WithEvents btnPrint As BankControls.NewButton
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader6 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader7 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader8 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader9 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader10 As System.Windows.Forms.ColumnHeader
    Friend WithEvents lblMessage As System.Windows.Forms.Label
    Friend WithEvents ColumnHeader11 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader12 As System.Windows.Forms.ColumnHeader
    Friend WithEvents btnMode As BankControls.NewButton
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmBalanceSheet))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.txtLiabilityTotal = New BankControls.TextControl
        Me.txtAssetTotal = New BankControls.TextControl
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.lblMessage = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.lvLiability = New System.Windows.Forms.ListView
        Me.ColumnHeader8 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader5 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader11 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader1 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader2 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader7 = New System.Windows.Forms.ColumnHeader
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.Label21 = New System.Windows.Forms.Label
        Me.lvAsset = New System.Windows.Forms.ListView
        Me.ColumnHeader10 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader6 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader12 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader3 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader4 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader9 = New System.Windows.Forms.ColumnHeader
        Me.Label1 = New System.Windows.Forms.Label
        Me.btnClose = New BankControls.NewButton
        Me.btnPrint = New BankControls.NewButton
        Me.btnMode = New BankControls.NewButton
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.GroupBox3)
        Me.GroupBox1.Controls.Add(Me.lblMessage)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.lvLiability)
        Me.GroupBox1.Controls.Add(Me.PictureBox1)
        Me.GroupBox1.Controls.Add(Me.Label21)
        Me.GroupBox1.Controls.Add(Me.lvAsset)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.btnClose)
        Me.GroupBox1.Controls.Add(Me.btnPrint)
        Me.GroupBox1.Controls.Add(Me.btnMode)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1000, 616)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.txtLiabilityTotal)
        Me.GroupBox3.Controls.Add(Me.txtAssetTotal)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Location = New System.Drawing.Point(16, 512)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(968, 40)
        Me.GroupBox3.TabIndex = 77
        Me.GroupBox3.TabStop = False
        '
        'txtLiabilityTotal
        '
        Me.txtLiabilityTotal.AlphaNumeric = True
        Me.txtLiabilityTotal.BackColor = System.Drawing.Color.FromArgb(CType(226, Byte), CType(252, Byte), CType(233, Byte))
        Me.txtLiabilityTotal.BlankSpace = False
        Me.txtLiabilityTotal.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtLiabilityTotal.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLiabilityTotal.GotFocusColour = System.Drawing.Color.FromArgb(CType(226, Byte), CType(252, Byte), CType(233, Byte))
        Me.txtLiabilityTotal.Location = New System.Drawing.Point(344, 16)
        Me.txtLiabilityTotal.LostFocusColour = System.Drawing.Color.FromArgb(CType(226, Byte), CType(252, Byte), CType(233, Byte))
        Me.txtLiabilityTotal.Mandatory = False
        Me.txtLiabilityTotal.MaxLength = 10
        Me.txtLiabilityTotal.Name = "txtLiabilityTotal"
        Me.txtLiabilityTotal.ReadOnly = True
        Me.txtLiabilityTotal.Size = New System.Drawing.Size(120, 16)
        Me.txtLiabilityTotal.SpecialChar = True
        Me.txtLiabilityTotal.TabIndex = 18
        Me.txtLiabilityTotal.Text = ""
        Me.txtLiabilityTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtAssetTotal
        '
        Me.txtAssetTotal.AlphaNumeric = True
        Me.txtAssetTotal.BackColor = System.Drawing.Color.FromArgb(CType(226, Byte), CType(252, Byte), CType(233, Byte))
        Me.txtAssetTotal.BlankSpace = False
        Me.txtAssetTotal.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtAssetTotal.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAssetTotal.GotFocusColour = System.Drawing.Color.FromArgb(CType(226, Byte), CType(252, Byte), CType(233, Byte))
        Me.txtAssetTotal.Location = New System.Drawing.Point(832, 16)
        Me.txtAssetTotal.LostFocusColour = System.Drawing.Color.FromArgb(CType(226, Byte), CType(252, Byte), CType(233, Byte))
        Me.txtAssetTotal.Mandatory = False
        Me.txtAssetTotal.MaxLength = 10
        Me.txtAssetTotal.Name = "txtAssetTotal"
        Me.txtAssetTotal.ReadOnly = True
        Me.txtAssetTotal.Size = New System.Drawing.Size(120, 16)
        Me.txtAssetTotal.SpecialChar = True
        Me.txtAssetTotal.TabIndex = 17
        Me.txtAssetTotal.Text = ""
        Me.txtAssetTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(64, Byte), CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(280, 15)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 19)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "Total :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(64, Byte), CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(768, 15)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 19)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "Total :"
        '
        'lblMessage
        '
        Me.lblMessage.AutoSize = True
        Me.lblMessage.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMessage.ForeColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(64, Byte), CType(0, Byte))
        Me.lblMessage.Location = New System.Drawing.Point(448, 32)
        Me.lblMessage.Name = "lblMessage"
        Me.lblMessage.Size = New System.Drawing.Size(0, 19)
        Me.lblMessage.TabIndex = 19
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.FromArgb(CType(172, Byte), CType(223, Byte), CType(184, Byte))
        Me.Label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label7.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(64, Byte), CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(8, 64)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(488, 32)
        Me.Label7.TabIndex = 18
        Me.Label7.Text = "Liabilities"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lvLiability
        '
        Me.lvLiability.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lvLiability.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lvLiability.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader8, Me.ColumnHeader5, Me.ColumnHeader11, Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader7})
        Me.lvLiability.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvLiability.FullRowSelect = True
        Me.lvLiability.GridLines = True
        Me.lvLiability.HideSelection = False
        Me.lvLiability.Location = New System.Drawing.Point(8, 96)
        Me.lvLiability.Name = "lvLiability"
        Me.lvLiability.Size = New System.Drawing.Size(488, 408)
        Me.lvLiability.TabIndex = 15
        Me.lvLiability.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader8
        '
        Me.ColumnHeader8.Text = "Sl No."
        Me.ColumnHeader8.Width = 30
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "GNo"
        Me.ColumnHeader5.Width = 0
        '
        'ColumnHeader11
        '
        Me.ColumnHeader11.Text = "LNo"
        Me.ColumnHeader11.Width = 0
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Particulars"
        Me.ColumnHeader1.Width = 240
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Balance"
        Me.ColumnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader2.Width = 100
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "Total"
        Me.ColumnHeader7.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader7.Width = 100
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(8, 16)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(48, 40)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 14
        Me.PictureBox1.TabStop = False
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.BackColor = System.Drawing.Color.FromArgb(CType(226, Byte), CType(252, Byte), CType(233, Byte))
        Me.Label21.Font = New System.Drawing.Font("Georgia", 14.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.ForeColor = System.Drawing.Color.Green
        Me.Label21.Location = New System.Drawing.Point(64, 16)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(128, 25)
        Me.Label21.TabIndex = 13
        Me.Label21.Text = "Balance Sheet"
        Me.Label21.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lvAsset
        '
        Me.lvAsset.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lvAsset.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lvAsset.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader10, Me.ColumnHeader6, Me.ColumnHeader12, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader9})
        Me.lvAsset.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvAsset.FullRowSelect = True
        Me.lvAsset.GridLines = True
        Me.lvAsset.HideSelection = False
        Me.lvAsset.Location = New System.Drawing.Point(504, 96)
        Me.lvAsset.Name = "lvAsset"
        Me.lvAsset.Size = New System.Drawing.Size(488, 408)
        Me.lvAsset.TabIndex = 15
        Me.lvAsset.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader10
        '
        Me.ColumnHeader10.Text = "Sl No."
        Me.ColumnHeader10.Width = 30
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "GNo"
        Me.ColumnHeader6.Width = 0
        '
        'ColumnHeader12
        '
        Me.ColumnHeader12.Text = "LNo"
        Me.ColumnHeader12.Width = 0
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Particulars"
        Me.ColumnHeader3.Width = 240
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Balance"
        Me.ColumnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader4.Width = 100
        '
        'ColumnHeader9
        '
        Me.ColumnHeader9.Text = "Total"
        Me.ColumnHeader9.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader9.Width = 100
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(172, Byte), CType(223, Byte), CType(184, Byte))
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label1.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(64, Byte), CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(504, 64)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(488, 32)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "Assets"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnClose
        '
        Me.btnClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnClose.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.GotFocusColour = System.Drawing.Color.FromArgb(CType(255, Byte), CType(128, Byte), CType(128, Byte))
        Me.btnClose.Image = CType(resources.GetObject("btnClose.Image"), System.Drawing.Image)
        Me.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnClose.Location = New System.Drawing.Point(872, 560)
        Me.btnClose.LostFocusColour = System.Drawing.Color.FromArgb(CType(226, Byte), CType(252, Byte), CType(233, Byte))
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(104, 40)
        Me.btnClose.TabIndex = 17
        Me.btnClose.Text = "&Close"
        '
        'btnPrint
        '
        Me.btnPrint.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPrint.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnPrint.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrint.GotFocusColour = System.Drawing.Color.FromArgb(CType(152, Byte), CType(220, Byte), CType(166, Byte))
        Me.btnPrint.Image = CType(resources.GetObject("btnPrint.Image"), System.Drawing.Image)
        Me.btnPrint.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnPrint.Location = New System.Drawing.Point(24, 560)
        Me.btnPrint.LostFocusColour = System.Drawing.Color.FromArgb(CType(226, Byte), CType(252, Byte), CType(233, Byte))
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(104, 40)
        Me.btnPrint.TabIndex = 17
        Me.btnPrint.Text = "&Print"
        '
        'btnMode
        '
        Me.btnMode.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnMode.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnMode.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnMode.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMode.GotFocusColour = System.Drawing.Color.FromArgb(CType(152, Byte), CType(220, Byte), CType(166, Byte))
        Me.btnMode.Image = CType(resources.GetObject("btnMode.Image"), System.Drawing.Image)
        Me.btnMode.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnMode.Location = New System.Drawing.Point(144, 560)
        Me.btnMode.LostFocusColour = System.Drawing.Color.FromArgb(CType(226, Byte), CType(252, Byte), CType(233, Byte))
        Me.btnMode.Name = "btnMode"
        Me.btnMode.Size = New System.Drawing.Size(104, 40)
        Me.btnMode.TabIndex = 17
        Me.btnMode.Text = "Compact"
        Me.btnMode.Visible = False
        '
        'frmBalanceSheet
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(7, 15)
        Me.BackColor = System.Drawing.Color.FromArgb(CType(226, Byte), CType(252, Byte), CType(233, Byte))
        Me.CancelButton = Me.btnClose
        Me.ClientSize = New System.Drawing.Size(1018, 631)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "frmBalanceSheet"
        Me.ShowInTaskbar = False
        Me.Text = "Balance Sheet"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region "Code to Create Instance Object"

    Private Shared m_FormDefInstance As frmBalanceSheet
    Private Shared m_InitializingDefInstance As Boolean

    Public Shared Property DefInstance() As frmBalanceSheet
        Get
            If m_FormDefInstance Is Nothing OrElse m_FormDefInstance.IsDisposed Then
                m_InitializingDefInstance = True
                m_FormDefInstance = New frmBalanceSheet
                m_InitializingDefInstance = False
            End If
            DefInstance = m_FormDefInstance
        End Get
        Set(ByVal Value As frmBalanceSheet)
            m_FormDefInstance = Value
        End Set
    End Property

#End Region

#Region "Sub Routines"

    Sub sbLoadCompact()
        Dim objDV As DataView
        Dim objDT As DataTable
        Dim intCounter As Integer = 0
        Dim lvItem As ListViewItem
        Dim dblLiabilityTotal As Double = 0
        Dim dblAssetTotal As Double = 0

        lvLiability.Items.Clear()
        lvAsset.Items.Clear()

        If objGroup.fnGetSubGroups(0) Then
            objDV = New DataView(objGroup.GroupsTable, "", "GroupNo", DataViewRowState.OriginalRows)

            objDV.RowFilter = "Nature='L'"
            While intCounter < objDV.Count
                lvItem = lvLiability.Items.Add(intCounter + 1)
                lvItem.SubItems.Add(objDV.Item(intCounter).Item("GroupNo"))
                lvItem.SubItems.Add("")
                lvItem.SubItems.Add(objDV.Item(intCounter).Item("Name"))
                lvItem.SubItems.Add("")
                lvItem.SubItems.Add(Abs(objDV.Item(intCounter).Item("CurrentBalance")))
                dblLiabilityTotal += Abs(objDV.Item(intCounter).Item("CurrentBalance"))
                intCounter += 1
            End While
            lvItem = lvLiability.Items.Add("")
            lvItem.SubItems.Add("")
            lvItem.SubItems.Add("")

            intCounter = 0
            objDV.RowFilter = "Nature='A'"

            While intCounter < objDV.Count
                lvItem = lvAsset.Items.Add(intCounter + 1)
                lvItem.SubItems.Add(objDV.Item(intCounter).Item("GroupNo"))
                lvItem.SubItems.Add("")
                lvItem.SubItems.Add(objDV.Item(intCounter).Item("Name"))
                lvItem.SubItems.Add("")
                lvItem.SubItems.Add(Abs(objDV.Item(intCounter).Item("CurrentBalance")))
                dblAssetTotal += Abs(objDV.Item(intCounter).Item("CurrentBalance"))
                intCounter += 1
            End While
            lvItem = lvAsset.Items.Add("")
            lvItem.SubItems.Add("")
            lvItem.SubItems.Add("")

        End If

        If objLedger.fnGetLedgerDetails(2) Then
            objDT = objLedger.LedgerTable
            If objDT.Rows(0).Item("CurrentBalance") > 0 Then
                lvItem = lvLiability.Items.Add("")
                lvItem.SubItems.Add("")
                lvItem.SubItems.Add("")
                lvItem.SubItems.Add("Net Profit")
                lvItem.SubItems.Add("")
                lvItem.SubItems.Add(Abs(objDT.Rows(0).Item("CurrentBalance")))
                dblLiabilityTotal += objDT.Rows(0).Item("CurrentBalance")
            ElseIf objDT.Rows(0).Item("CurrentBalance") < 0 Then
                lvItem = lvAsset.Items.Add("")
                lvItem.SubItems.Add("")
                lvItem.SubItems.Add("")
                lvItem.SubItems.Add("Net Loss")
                lvItem.SubItems.Add("")
                lvItem.SubItems.Add(Abs(objDT.Rows(0).Item("CurrentBalance")))
                dblAssetTotal += Abs(objDT.Rows(0).Item("CurrentBalance"))
            End If
        End If

        txtLiabilityTotal.Text = Format(dblLiabilityTotal, "0,00.00")
        txtAssetTotal.Text = Format(dblAssetTotal, "0,00.00")

    End Sub

    Private Overloads Sub sbLoadExpanded()

        Dim dvGroups As DataView
        Dim dvLedgers As DataView
        Dim objDT As DataTable
        Dim intCounter As Integer = 0
        Dim intCountLedgers As Integer = 0
        Dim intSlNo As Integer = 1
        Dim lvItem As ListViewItem
        Dim dblLiabilityTotal As Double = 0
        Dim dblAssetTotal As Double = 0
        Dim dblGroupTotal As Double = 0

        lvLiability.Items.Clear()       'clear both ListView Items
        lvAsset.Items.Clear()

        If objGroup.fnGetGroupsList() Then      'Get Groups List
            dvGroups = New DataView(objGroup.GroupsTable, "", "OrderNo", DataViewRowState.OriginalRows)

            objLedger.fnGetLedgerList()         'Get Ledgers List
            dvLedgers = New DataView(objLedger.LedgerTable, "", "OrderNo", DataViewRowState.OriginalRows)



            '********* Load Liability Groups with its Ledgers **********"

            dvGroups.RowFilter = "Nature='L'"       'Get Liability Groups
            While intCounter < dvGroups.Count       'for each liability group
                dvLedgers.RowFilter = "GroupNo=" & dvGroups.Item(intCounter).Item("GroupNo")    'Get Ledgers within the Group
                If dvLedgers.Count > 0 Then         'if the Group has Ledgers then only display the Group 
                    lvItem = lvLiability.Items.Add(intSlNo)
                    lvItem.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
                    lvItem.SubItems.Add(dvGroups.Item(intCounter).Item("GroupNo"))
                    lvItem.SubItems.Add("")
                    lvItem.SubItems.Add(dvGroups.Item(intCounter).Item("Name"))
                    intCountLedgers = 0
                    dblGroupTotal = 0
                    While intCountLedgers < dvLedgers.Count     'for each Ledger belongs to the Group
                        lvItem = lvLiability.Items.Add("")
                        lvItem.SubItems.Add("")
                        lvItem.SubItems.Add(dvLedgers.Item(intCountLedgers).Item("LedgerNo"))
                        lvItem.SubItems.Add(dvLedgers.Item(intCountLedgers).Item("Name"))
                        lvItem.SubItems.Add(Format(Abs(dvLedgers.Item(intCountLedgers).Item("CurrentBalance")), "0,00.00"))
                        dblLiabilityTotal += Abs(dvLedgers.Item(intCountLedgers).Item("CurrentBalance"))
                        dblGroupTotal += Abs(dvLedgers.Item(intCountLedgers).Item("CurrentBalance"))
                        intCountLedgers += 1
                    End While
                    lvItem.SubItems.Add(Format(dblGroupTotal, "0,00.00"))   'display Group Total

                    '***** a blank line after each GroupName *****
                    lvItem = lvLiability.Items.Add("")
                    lvItem.SubItems.Add("")
                    lvItem.SubItems.Add("")
                    lvItem.SubItems.Add("")

                    intSlNo += 1
                End If
                intCounter += 1
            End While

            '***** a blank line after all Groups *****
            lvItem = lvLiability.Items.Add("")
            lvItem.SubItems.Add("")
            lvItem.SubItems.Add("")
            lvItem.SubItems.Add("")
            '********* Completed display of Liability Groups and Ledgers***********

            '********** Display of Asset Groups with its Ledgers ***********
            intSlNo = 1
            intCounter = 0
            intCountLedgers = 0
            dvGroups.RowFilter = "Nature='A'"       'Get Asset Groups
            While intCounter < dvGroups.Count       'for each Asset group
                dvLedgers.RowFilter = "GroupNo=" & dvGroups.Item(intCounter).Item("GroupNo")    'get Ledgers belong to the Group
                If dvLedgers.Count > 0 Then     'if the Group has Ledgers then only display the Group 
                    lvItem = lvAsset.Items.Add(intSlNo)
                    lvItem.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
                    lvItem.SubItems.Add(dvGroups.Item(intCounter).Item("GroupNo"))
                    lvItem.SubItems.Add("")
                    lvItem.SubItems.Add(dvGroups.Item(intCounter).Item("Name"))
                    intCountLedgers = 0
                    dblGroupTotal = 0
                    While intCountLedgers < dvLedgers.Count     'for each Ledger belong to the Group
                        lvItem = lvAsset.Items.Add("")
                        lvItem.SubItems.Add("")
                        lvItem.SubItems.Add(dvLedgers.Item(intCountLedgers).Item("LedgerNo"))
                        lvItem.SubItems.Add(dvLedgers.Item(intCountLedgers).Item("Name"))
                        lvItem.SubItems.Add(Format(Abs(dvLedgers.Item(intCountLedgers).Item("CurrentBalance")), "0,00.00"))
                        dblAssetTotal += Abs(dvLedgers.Item(intCountLedgers).Item("CurrentBalance"))
                        dblGroupTotal += Abs(dvLedgers.Item(intCountLedgers).Item("CurrentBalance"))
                        intCountLedgers += 1
                    End While
                    lvItem.SubItems.Add(Format(dblGroupTotal, "0,00.00"))     'display Group Total

                    '******** a blank line after each GroupName
                    lvItem = lvAsset.Items.Add("")
                    lvItem.SubItems.Add("")
                    lvItem.SubItems.Add("")
                    lvItem.SubItems.Add("")

                    intSlNo += 1
                End If
                intCounter += 1
            End While
            '***** a blank line after all Groups *****
            lvItem = lvAsset.Items.Add("")
            lvItem.SubItems.Add("")
            lvItem.SubItems.Add("")
            lvItem.SubItems.Add("")
        End If

        '******* completed display of Asset Groups and Ledgers ********


        '******** Net Profit or Net Loss display *********
        If objLedger.fnGetLedgerDetails(2) Then
            '    If objLedger.fnGetLedgerDetails(56) Then
            objDT = objLedger.LedgerTable
            Dim i As Decimal = objDT.Rows(0).Item("CurrentBalance")
            If objDT.Rows(0).Item("CurrentBalance") > 0 Then
                lvItem = lvLiability.Items.Add("")
                lvItem.SubItems.Add("")
                lvItem.SubItems.Add("")
                lvItem.SubItems.Add("Net Profit")
                lvItem.SubItems.Add("")
                ' lvItem.SubItems.Add(objDT.Rows(0).Item("CurrentBalance"))
                lvItem.SubItems.Add(Format(objDT.Rows(0).Item("CurrentBalance"), "0,00.00"))
                dblLiabilityTotal += objDT.Rows(0).Item("CurrentBalance")
            ElseIf objDT.Rows(0).Item("CurrentBalance") < 0 Then
                lvItem = lvAsset.Items.Add("")
                lvItem.SubItems.Add("")
                lvItem.SubItems.Add("")
                lvItem.SubItems.Add("Net Loss")
                lvItem.SubItems.Add("")
                'lvItem.SubItems.Add(Abs(objDT.Rows(0).Item("CurrentBalance")))
                lvItem.SubItems.Add(Format(objDT.Rows(0).Item("CurrentBalance"), "0,00.00"))
                dblAssetTotal += Abs(objDT.Rows(0).Item("CurrentBalance"))
            End If
        End If

        '******* completed display of Net Profit or Loss *********

        '***** display Liability and Asset Totals *******
        txtLiabilityTotal.Text = Format(dblLiabilityTotal, "0,00.00")
        txtAssetTotal.Text = Format(dblAssetTotal, "0,00.00")

    End Sub

#End Region

#Region " Events"

    Private Sub frmBalanceSheet_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lblMessage.Text = "Balance Sheet as on :: " & Date.Now
        objLedger.fnUpdateLedgerBalances()
        'objLedger.fnUpdateInterestPayable(Date.Now)
        sbLoadExpanded()

    End Sub

    Private Sub btnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrint.Click
        '
        Dim objReportViewer As New frmReportViewer
        'objReportViewer.CrystalReportViewer1.ReportSource = Application.StartupPath & "/../Reports/BalanceSheetPav.rpt" 'BalanceSheet.rpt")
        objReportViewer.CrystalReportViewer1.ReportSource = Application.StartupPath & "/Reports/CrystalReport2.rpt" 'BalanceSheet.rpt")
        objReportViewer.ShowDialog()
        objReportViewer = Nothing

    End Sub

    Private Sub btnClose_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub lvLiability_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles lvLiability.DoubleClick
        If lvLiability.SelectedItems.Count > 0 Then
            If lvLiability.SelectedItems(0).SubItems(1).Text <> "" Then
                Dim objfrmGroupSummary As frmGroupSummary
                objfrmGroupSummary = frmGroupSummary.DefInstance
                objfrmGroupSummary.BringToFront()
                objfrmGroupSummary.MdiParent = Me.MdiParent
                objfrmGroupSummary.GroupNo = lvLiability.SelectedItems(0).SubItems(1).Text
                objfrmGroupSummary.Show()
                objfrmGroupSummary = Nothing
            ElseIf lvLiability.SelectedItems(0).SubItems(2).Text <> "" Then
                If objLedger.fnGetTransactions(lvLiability.SelectedItems(0).SubItems(2).Text) Then
                    Dim objfrmLedgerDetails As frmLedgerDetails
                    objfrmLedgerDetails = frmLedgerDetails.DefInstance
                    objfrmLedgerDetails.BringToFront()
                    objfrmLedgerDetails.MdiParent = Me.MdiParent
                    objfrmLedgerDetails.LedgerNo = lvLiability.SelectedItems(0).SubItems(2).Text
                    objfrmLedgerDetails.Show()
                    objfrmLedgerDetails = Nothing
                End If
            ElseIf lvLiability.SelectedItems(0).SubItems(3).Text = "Net Profit" Then
                Dim objfrmIncomeExp As frmIncomeExpenditure
                objfrmIncomeExp = frmIncomeExpenditure.DefInstance
                objfrmIncomeExp.BringToFront()
                objfrmIncomeExp.MdiParent = Me.MdiParent
                objfrmIncomeExp.Show()
                objfrmIncomeExp = Nothing
            End If
        Else
            MsgBox("Select Record", MsgBoxStyle.Information, Me.Text)
            lvLiability.Focus()
        End If

    End Sub

    Private Sub lvAsset_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles lvAsset.DoubleClick

        If lvAsset.SelectedItems.Count > 0 Then
            If lvAsset.SelectedItems(0).SubItems(1).Text <> "" Then
                Dim objfrmGroupSummary As frmGroupSummary
                objfrmGroupSummary = frmGroupSummary.DefInstance
                objfrmGroupSummary.BringToFront()
                objfrmGroupSummary.MdiParent = Me.MdiParent
                objfrmGroupSummary.GroupNo = lvAsset.SelectedItems(0).SubItems(1).Text
                objfrmGroupSummary.Show()
                objfrmGroupSummary = Nothing
            ElseIf lvAsset.SelectedItems(0).SubItems(2).Text <> "" Then
                If objLedger.fnGetTransactions(lvAsset.SelectedItems(0).SubItems(2).Text) Then
                    Dim objfrmLedgerDetails As frmLedgerDetails
                    objfrmLedgerDetails = frmLedgerDetails.DefInstance
                    objfrmLedgerDetails.BringToFront()
                    objfrmLedgerDetails.MdiParent = Me.MdiParent
                    objfrmLedgerDetails.LedgerNo = lvAsset.SelectedItems(0).SubItems(2).Text
                    objfrmLedgerDetails.Show()
                    objfrmLedgerDetails = Nothing
                End If
            ElseIf lvAsset.SelectedItems(0).SubItems(3).Text = "Net Loss" Then
                Dim objfrmIncomeExp As frmIncomeExpenditure
                objfrmIncomeExp = frmIncomeExpenditure.DefInstance
                objfrmIncomeExp.BringToFront()
                objfrmIncomeExp.MdiParent = Me.MdiParent
                objfrmIncomeExp.Show()
                objfrmIncomeExp = Nothing
            End If
        Else
            MsgBox("Select Record", MsgBoxStyle.Information, Me.Text)
            lvAsset.Focus()
        End If

    End Sub

    Private Sub lvLiability_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles lvLiability.KeyDown

        If e.KeyData = Keys.Enter Then
            lvLiability_DoubleClick(sender, e)
        ElseIf e.KeyData = Keys.Right Then
            lvAsset.Focus()
        End If

    End Sub

    Private Sub lvAsset_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles lvAsset.KeyDown

        If e.KeyData = Keys.Enter Then
            lvAsset_DoubleClick(sender, e)
        ElseIf e.KeyData = Keys.Left Then
            lvLiability.Focus()
        End If

    End Sub

    Private Sub btnMode_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMode.Click

        If btnMode.Text = "Compact" Then
            btnMode.Text = "Expanded"
            sbLoadCompact()
        Else
            btnMode.Text = "Compact"
            sbLoadExpanded()
        End If
    End Sub

#End Region



End Class
