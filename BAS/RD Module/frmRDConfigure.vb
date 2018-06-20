Public Class frmRDConfigure
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
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmbPeriod As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btnConfigure As BankControls.NewButton
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cmbDays As System.Windows.Forms.ComboBox
    Friend WithEvents btnClose As BankControls.NewButton
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmRDConfigure))
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.cmbPeriod = New System.Windows.Forms.ComboBox
        Me.btnConfigure = New BankControls.NewButton
        Me.Label4 = New System.Windows.Forms.Label
        Me.cmbDays = New System.Windows.Forms.ComboBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.btnClose = New BankControls.NewButton
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label3.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Maroon
        Me.Label3.Location = New System.Drawing.Point(4, 237)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(484, 23)
        Me.Label3.TabIndex = 102
        Me.Label3.Text = "NOTE :- Minimum RD Period Has To Be Modified  In Presence Of Manager Only"
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label2.Font = New System.Drawing.Font("Georgia", 14.25!, System.Drawing.FontStyle.Underline)
        Me.Label2.ForeColor = System.Drawing.Color.Ivory
        Me.Label2.Location = New System.Drawing.Point(56, 13)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(356, 24)
        Me.Label2.TabIndex = 101
        Me.Label2.Text = "Select the Minimum Period  for RD Deposit"
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(136, 56)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 16)
        Me.Label1.TabIndex = 100
        Me.Label1.Text = "In Months"
        '
        'cmbPeriod
        '
        Me.cmbPeriod.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.cmbPeriod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbPeriod.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbPeriod.Items.AddRange(New Object() {"0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12"})
        Me.cmbPeriod.Location = New System.Drawing.Point(128, 88)
        Me.cmbPeriod.Name = "cmbPeriod"
        Me.cmbPeriod.Size = New System.Drawing.Size(88, 24)
        Me.cmbPeriod.TabIndex = 99
        '
        'btnConfigure
        '
        Me.btnConfigure.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnConfigure.BackColor = System.Drawing.Color.FromArgb(CType(200, Byte), CType(206, Byte), CType(176, Byte))
        Me.btnConfigure.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnConfigure.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnConfigure.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConfigure.GotFocusColour = System.Drawing.Color.Beige
        Me.btnConfigure.Location = New System.Drawing.Point(80, 128)
        Me.btnConfigure.LostFocusColour = System.Drawing.Color.FromArgb(CType(200, Byte), CType(206, Byte), CType(176, Byte))
        Me.btnConfigure.Name = "btnConfigure"
        Me.btnConfigure.Size = New System.Drawing.Size(328, 48)
        Me.btnConfigure.TabIndex = 98
        Me.btnConfigure.Text = "Configure"
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(16, 88)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(105, 19)
        Me.Label4.TabIndex = 97
        Me.Label4.Text = "New RD Period"
        '
        'cmbDays
        '
        Me.cmbDays.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.cmbDays.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbDays.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbDays.Items.AddRange(New Object() {"0", "5", "10", "15", "20", "25", "30", "31"})
        Me.cmbDays.Location = New System.Drawing.Point(280, 88)
        Me.cmbDays.Name = "cmbDays"
        Me.cmbDays.Size = New System.Drawing.Size(88, 24)
        Me.cmbDays.TabIndex = 99
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label5.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(288, 56)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(64, 16)
        Me.Label5.TabIndex = 100
        Me.Label5.Text = "In Days"
        '
        'btnClose
        '
        Me.btnClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnClose.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.GotFocusColour = System.Drawing.Color.FromArgb(CType(255, Byte), CType(128, Byte), CType(128, Byte))
        Me.btnClose.Image = CType(resources.GetObject("btnClose.Image"), System.Drawing.Image)
        Me.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnClose.Location = New System.Drawing.Point(352, 184)
        Me.btnClose.LostFocusColour = System.Drawing.Color.FromArgb(CType(176, Byte), CType(236, Byte), CType(199, Byte))
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(104, 40)
        Me.btnClose.TabIndex = 103
        Me.btnClose.Text = "&Close"
        '
        'frmRDConfigure
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.FromArgb(CType(200, Byte), CType(206, Byte), CType(176, Byte))
        Me.CancelButton = Me.btnClose
        Me.ClientSize = New System.Drawing.Size(490, 273)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmbPeriod)
        Me.Controls.Add(Me.btnConfigure)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cmbDays)
        Me.Controls.Add(Me.Label5)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmRDConfigure"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "RDConfigure"
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region "Single instance creation"

    Private Shared m_FormDefInstance As frmRDConfigure
    Private Shared m_InitilizeDefInstance As Boolean

    Public Shared Property DefInstance() As frmRDConfigure
        Get
            If m_FormDefInstance Is Nothing OrElse m_FormDefInstance.IsDisposed Then
                m_InitilizeDefInstance = True
                m_FormDefInstance = New frmRDConfigure
                m_InitilizeDefInstance = False
            End If
            DefInstance = m_FormDefInstance
        End Get
        Set(ByVal Value As frmRDConfigure)
            m_FormDefInstance = Value
        End Set
    End Property

#End Region

#Region "Variables"

    Dim objRDAccount As New clsRDAccount

#End Region

#Region "Functions"

    Public Function fnCheck() As Boolean

        If cmbPeriod.SelectedIndex = -1 Then
            MsgBox("Please select the minium period for RD", MsgBoxStyle.Critical, "RD Module")
            Return False
        Else
            Return True
        End If

    End Function

    Public Function fnSetData() As Boolean

        objRDAccount.MinPeriod = cmbPeriod.SelectedItem
        objRDAccount.MinDays = cmbDays.SelectedItem
        Return True

    End Function

    Public Function fnLoadPeriod()

        If objRDAccount.fnGetMinPeriod Then
            cmbPeriod.SelectedItem = objRDAccount.MinPeriodTable.Rows(0).Item("MinMonth").ToString()
            cmbDays.SelectedItem = objRDAccount.MinPeriodTable.Rows(0).Item("MinDays").ToString()
        End If

    End Function

#End Region

    Private Sub btnConfigure_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConfigure.Click

        If MsgBox("Are you sure, you want to modify minimum period for RD", MsgBoxStyle.YesNo, "RD Module") = MsgBoxResult.Yes Then
            If fnCheck() Then
                If fnSetData() Then
                    If objRDAccount.fnGetMinPeriod Then
                        If objRDAccount.fnUpdateMinPeriod Then
                            MsgBox("RD period updated successfully", MsgBoxStyle.Information, "RD Module")
                        Else
                            MsgBox("RD period cannot be updated due to internal error", MsgBoxStyle.Exclamation, "RD Module")
                        End If
                    Else
                        If objRDAccount.fnInsertMinPeriod Then
                            MsgBox("New RD period configured successfully", MsgBoxStyle.Information, "RD Module")
                        Else
                            MsgBox("RD period cannot be configured due to internal error", MsgBoxStyle.Exclamation, "RD Module")
                        End If
                    End If

                End If
            End If
        End If

    End Sub

    Private Sub frmRDConfigure_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load

        fnLoadPeriod()

    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
End Class
