Public Class frmSBReports
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
    Friend WithEvents btnBalanceStatements As BankControls.NewButton
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmSBReports))
        Me.btnBalanceStatements = New BankControls.NewButton
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnBalanceStatements
        '
        Me.btnBalanceStatements.BackColor = System.Drawing.Color.FromArgb(CType(217, Byte), CType(251, Byte), CType(249, Byte))
        Me.btnBalanceStatements.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBalanceStatements.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnBalanceStatements.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBalanceStatements.ForeColor = System.Drawing.Color.Black
        Me.btnBalanceStatements.GotFocusColour = System.Drawing.Color.FromArgb(CType(0, Byte), CType(192, Byte), CType(192, Byte))
        Me.btnBalanceStatements.Image = CType(resources.GetObject("btnBalanceStatements.Image"), System.Drawing.Image)
        Me.btnBalanceStatements.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBalanceStatements.Location = New System.Drawing.Point(40, 32)
        Me.btnBalanceStatements.LostFocusColour = System.Drawing.Color.FromArgb(CType(234, Byte), CType(244, Byte), CType(198, Byte))
        Me.btnBalanceStatements.Name = "btnBalanceStatements"
        Me.btnBalanceStatements.Size = New System.Drawing.Size(176, 40)
        Me.btnBalanceStatements.TabIndex = 27
        Me.btnBalanceStatements.Text = "Balance Statements"
        Me.btnBalanceStatements.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnBalanceStatements)
        Me.GroupBox1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(0, 8)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(256, 432)
        Me.GroupBox1.TabIndex = 28
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Reports"
        '
        'frmSBReports
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.FromArgb(CType(217, Byte), CType(251, Byte), CType(249, Byte))
        Me.ClientSize = New System.Drawing.Size(618, 447)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmSBReports"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SB Reports"
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region "Code to Create Instance Object"

    Private Shared m_FormDefInstance As frmSBReports
    Private Shared m_InitializingDefInstance As Boolean

    Public Shared Property DefInstance() As frmSBReports
        Get
            If m_FormDefInstance Is Nothing OrElse m_FormDefInstance.IsDisposed Then
                m_InitializingDefInstance = True
                m_FormDefInstance = New frmSBReports
                m_InitializingDefInstance = False
            End If
            DefInstance = m_FormDefInstance
        End Get
        Set(ByVal Value As frmSBReports)
            m_FormDefInstance = Value
        End Set
    End Property

#End Region

    Private Sub btnBalanceStatements_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBalanceStatements.Click

        Dim objReportViewer As New frmReportViewer
        Dim dateRange As String
        Dim txtobj As New CrystalDecisions.Shared.ParameterField
        objReportViewer.CrystalReportViewer1.ReportSource = Application.StartupPath & "/../Reports/SBAccountBalance.rpt"
        objReportViewer.ShowDialog()

    End Sub

End Class
