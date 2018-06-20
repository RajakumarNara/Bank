Public Class frmPigmyPeriod
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
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cmbPeriod As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnApply As BankControls.NewButton
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnClose As BankControls.NewButton
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtBankCharges As BankControls.NumericControl
    Friend WithEvents txtROI As BankControls.NumericControl
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmPigmyPeriod))
        Me.Label4 = New System.Windows.Forms.Label
        Me.btnApply = New BankControls.NewButton
        Me.cmbPeriod = New System.Windows.Forms.ComboBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.btnClose = New BankControls.NewButton
        Me.Label19 = New System.Windows.Forms.Label
        Me.txtBankCharges = New BankControls.NumericControl
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtROI = New BankControls.NumericControl
        Me.SuspendLayout()
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(16, 64)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(124, 19)
        Me.Label4.TabIndex = 90
        Me.Label4.Text = "Minimum Period :"
        '
        'btnApply
        '
        Me.btnApply.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnApply.BackColor = System.Drawing.Color.FromArgb(CType(220, Byte), CType(224, Byte), CType(182, Byte))
        Me.btnApply.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnApply.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnApply.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnApply.GotFocusColour = System.Drawing.Color.FromArgb(CType(233, Byte), CType(244, Byte), CType(196, Byte))
        Me.btnApply.Image = CType(resources.GetObject("btnApply.Image"), System.Drawing.Image)
        Me.btnApply.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnApply.Location = New System.Drawing.Point(268, 128)
        Me.btnApply.LostFocusColour = System.Drawing.Color.FromArgb(CType(220, Byte), CType(224, Byte), CType(182, Byte))
        Me.btnApply.Name = "btnApply"
        Me.btnApply.Size = New System.Drawing.Size(112, 40)
        Me.btnApply.TabIndex = 91
        Me.btnApply.Text = "Co&nfigure"
        Me.btnApply.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmbPeriod
        '
        Me.cmbPeriod.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.cmbPeriod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbPeriod.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbPeriod.Items.AddRange(New Object() {"0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12"})
        Me.cmbPeriod.Location = New System.Drawing.Point(136, 64)
        Me.cmbPeriod.Name = "cmbPeriod"
        Me.cmbPeriod.Size = New System.Drawing.Size(88, 24)
        Me.cmbPeriod.TabIndex = 93
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(232, 64)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(88, 16)
        Me.Label1.TabIndex = 94
        Me.Label1.Text = "(In Months)"
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label2.Font = New System.Drawing.Font("Georgia", 14.25!, System.Drawing.FontStyle.Underline)
        Me.Label2.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label2.Location = New System.Drawing.Point(56, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(372, 24)
        Me.Label2.TabIndex = 95
        Me.Label2.Text = "Select the Minimum Period  for BNN  Deposit"
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label3.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Maroon
        Me.Label3.Location = New System.Drawing.Point(12, 192)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(488, 23)
        Me.Label3.TabIndex = 96
        Me.Label3.Text = "NOTE :- Minimum BNN  Period Has To Be Modified  In Presence Of Manager"
        '
        'btnClose
        '
        Me.btnClose.CausesValidation = False
        Me.btnClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnClose.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.GotFocusColour = System.Drawing.Color.FromArgb(CType(255, Byte), CType(128, Byte), CType(128, Byte))
        Me.btnClose.Image = CType(resources.GetObject("btnClose.Image"), System.Drawing.Image)
        Me.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnClose.Location = New System.Drawing.Point(400, 128)
        Me.btnClose.LostFocusColour = System.Drawing.Color.FromArgb(CType(220, Byte), CType(224, Byte), CType(182, Byte))
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(80, 40)
        Me.btnClose.TabIndex = 97
        Me.btnClose.Text = "&Close"
        Me.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(16, 104)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(114, 19)
        Me.Label19.TabIndex = 128
        Me.Label19.Text = "Bank Charges  :"
        '
        'txtBankCharges
        '
        Me.txtBankCharges.AfterDecimal = 2
        Me.txtBankCharges.BackColor = System.Drawing.Color.White
        Me.txtBankCharges.BeforeDecimal = 7
        Me.txtBankCharges.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBankCharges.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtBankCharges.Location = New System.Drawing.Point(136, 104)
        Me.txtBankCharges.LostFocusColour = System.Drawing.Color.Empty
        Me.txtBankCharges.MaxLength = 10
        Me.txtBankCharges.MaxValue = 0
        Me.txtBankCharges.MinValue = 0
        Me.txtBankCharges.Name = "txtBankCharges"
        Me.txtBankCharges.Size = New System.Drawing.Size(88, 23)
        Me.txtBankCharges.TabIndex = 127
        Me.txtBankCharges.Text = ""
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(16, 144)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(46, 19)
        Me.Label5.TabIndex = 130
        Me.Label5.Text = "ROI  :"
        '
        'txtROI
        '
        Me.txtROI.AfterDecimal = 2
        Me.txtROI.BackColor = System.Drawing.Color.White
        Me.txtROI.BeforeDecimal = 7
        Me.txtROI.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtROI.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtROI.Location = New System.Drawing.Point(136, 144)
        Me.txtROI.LostFocusColour = System.Drawing.Color.Empty
        Me.txtROI.MaxLength = 10
        Me.txtROI.MaxValue = 0
        Me.txtROI.MinValue = 0
        Me.txtROI.Name = "txtROI"
        Me.txtROI.Size = New System.Drawing.Size(88, 23)
        Me.txtROI.TabIndex = 129
        Me.txtROI.Text = ""
        '
        'frmPigmyPeriod
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.FromArgb(CType(220, Byte), CType(224, Byte), CType(182, Byte))
        Me.CancelButton = Me.btnClose
        Me.ClientSize = New System.Drawing.Size(504, 221)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtROI)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.txtBankCharges)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmbPeriod)
        Me.Controls.Add(Me.btnApply)
        Me.Controls.Add(Me.Label4)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmPigmyPeriod"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "BNN Configure"
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region "Code to Create Instance Object"

    Private Shared m_FormDefInstance As frmPigmyPeriod
    Private Shared m_InitializingDefInstance As Boolean

    Public Shared Property DefInstance() As frmPigmyPeriod
        Get
            If m_FormDefInstance Is Nothing OrElse m_FormDefInstance.IsDisposed Then
                m_InitializingDefInstance = True
                m_FormDefInstance = New frmPigmyPeriod
                m_InitializingDefInstance = False
            End If
            DefInstance = m_FormDefInstance
        End Get
        Set(ByVal Value As frmPigmyPeriod)
            m_FormDefInstance = Value
        End Set
    End Property

#End Region

#Region "Variables"

    Dim objPigmyAccount As New clsPigmyAccount

#End Region

#Region "Functions"

    Public Function fnCheck() As Boolean

        If cmbPeriod.SelectedIndex = -1 Then
            MsgBox("Please select Minimum no of months", MsgBoxStyle.Information)
            cmbPeriod.Focus()
            Return False
        ElseIf txtBankCharges.Text = "" Then
            MsgBox("Enter bank charges", MsgBoxStyle.Information)
            txtBankCharges.Focus()
            Return False
        ElseIf txtROI.Text = "" Then
            MsgBox("Enter rate of interest", MsgBoxStyle.Information)
            txtROI.Focus()
            Return False
        Else
            Return True
        End If

    End Function

    Public Function fnSetData() As Boolean

        objPigmyAccount.MinPeriod = cmbPeriod.SelectedItem
        objPigmyAccount.ROI = txtROI.Text
        objPigmyAccount.OtherCharge = txtBankCharges.Text

        Return True

    End Function

    Public Function fnLoadPeriod()

        Try
            If objPigmyAccount.fnGetMinPeriod Then
                cmbPeriod.Text = objPigmyAccount.MinPeriodtable.Rows(0).Item("MinPeriod").ToString
                txtBankCharges.Text = objPigmyAccount.MinPeriodtable.Rows(0).Item("BankCharges")
                txtROI.Text = objPigmyAccount.MinPeriodtable.Rows(0).Item("ROI")
            End If
        Catch ex As Exception

        End Try
        
    End Function

#End Region

#Region "Events"

    Private Sub btnApply_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnApply.Click

        If fnCheck() Then
            If fnSetData() Then
                If objPigmyAccount.fnGetMinPeriod Then
                    If objPigmyAccount.fnUpdatePeriod Then
                        MsgBox("BNN period updated successfully", MsgBoxStyle.Information, "BNN Module")
                    Else
                        MsgBox("BNN period cannot be updated due to internal error", MsgBoxStyle.Exclamation, "BNN Module")
                    End If
                Else
                    If objPigmyAccount.fnInsertMinPeriod Then
                        MsgBox("New BNN period configured successfully", MsgBoxStyle.Information, "BNN Module")
                    Else
                        MsgBox("BNN period cannot be configured due to internal error", MsgBoxStyle.Exclamation, "BNN Module")
                    End If
                End If
            End If
        End If

    End Sub

    Private Sub frmPigmyPeriod_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load

        fnLoadPeriod()

    End Sub

#End Region

 
    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
End Class
