Public Class frmAccountSelection
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
    Friend WithEvents btnSBSearch As BankControls.NewButton
    Friend WithEvents cmbType As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblAccount As System.Windows.Forms.Label
    Friend WithEvents txtAccountNo As BankControls.TextControl
    Friend WithEvents btnClose As BankControls.NewButton
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAccountSelection))
        Me.lblAccount = New System.Windows.Forms.Label
        Me.txtAccountNo = New BankControls.TextControl
        Me.btnSBSearch = New BankControls.NewButton
        Me.cmbType = New System.Windows.Forms.ComboBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.btnClose = New BankControls.NewButton
        Me.SuspendLayout()
        '
        'lblAccount
        '
        Me.lblAccount.AutoSize = True
        Me.lblAccount.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAccount.Location = New System.Drawing.Point(16, 53)
        Me.lblAccount.Name = "lblAccount"
        Me.lblAccount.Size = New System.Drawing.Size(53, 16)
        Me.lblAccount.TabIndex = 156
        Me.lblAccount.Text = "SB No:"
        '
        'txtAccountNo
        '
        Me.txtAccountNo.AlphaNumeric = True
        Me.txtAccountNo.BackColor = System.Drawing.Color.White
        Me.txtAccountNo.BlankSpace = True
        Me.txtAccountNo.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAccountNo.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtAccountNo.Location = New System.Drawing.Point(88, 51)
        Me.txtAccountNo.LostFocusColour = System.Drawing.Color.Empty
        Me.txtAccountNo.Mandatory = False
        Me.txtAccountNo.MaxLength = 10
        Me.txtAccountNo.Name = "txtAccountNo"
        Me.txtAccountNo.ReadOnly = True
        Me.txtAccountNo.Size = New System.Drawing.Size(112, 23)
        Me.txtAccountNo.SpecialChar = False
        Me.txtAccountNo.TabIndex = 3
        Me.txtAccountNo.TabStop = False
        '
        'btnSBSearch
        '
        Me.btnSBSearch.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSBSearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSBSearch.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSBSearch.ForeColor = System.Drawing.Color.Black
        Me.btnSBSearch.GotFocusColour = System.Drawing.Color.Gray
        Me.btnSBSearch.Image = CType(resources.GetObject("btnSBSearch.Image"), System.Drawing.Image)
        Me.btnSBSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSBSearch.Location = New System.Drawing.Point(210, 50)
        Me.btnSBSearch.LostFocusColour = System.Drawing.SystemColors.Control
        Me.btnSBSearch.Name = "btnSBSearch"
        Me.btnSBSearch.Size = New System.Drawing.Size(24, 24)
        Me.btnSBSearch.TabIndex = 2
        '
        'cmbType
        '
        Me.cmbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbType.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbType.Items.AddRange(New Object() {"Savings Bank", "Current Account"})
        Me.cmbType.Location = New System.Drawing.Point(88, 12)
        Me.cmbType.Name = "cmbType"
        Me.cmbType.Size = New System.Drawing.Size(152, 24)
        Me.cmbType.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(8, 15)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(81, 16)
        Me.Label2.TabIndex = 158
        Me.Label2.Text = "Search By:"
        '
        'btnClose
        '
        Me.btnClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnClose.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.GotFocusColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnClose.Location = New System.Drawing.Point(208, 84)
        Me.btnClose.LostFocusColour = System.Drawing.Color.Empty
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(64, 32)
        Me.btnClose.TabIndex = 4
        Me.btnClose.Text = "&Close"
        '
        'frmAccountSelection
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.CancelButton = Me.btnClose
        Me.ClientSize = New System.Drawing.Size(278, 123)
        Me.Controls.Add(Me.cmbType)
        Me.Controls.Add(Me.lblAccount)
        Me.Controls.Add(Me.btnSBSearch)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtAccountNo)
        Me.Controls.Add(Me.btnClose)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmAccountSelection"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Account Selection"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

#Region "Global variable"
    Public strAccountNo As String
#End Region

    Private Sub cmbType_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbType.SelectedIndexChanged
        Select Case cmbType.Text
            Case "Savings Bank"
                lblAccount.Text = "SB No:"
            Case "Current Account"
                lblAccount.Text = "CA No:"
        End Select
    End Sub

    Private Sub btnSBSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSBSearch.Click

        Select Case cmbType.Text
            Case "Savings Bank"
                Dim objSBAccSearch As New frmSBAccSearch
                objSBAccSearch.strSBAccountNo = String.Empty
                objSBAccSearch.ShowDialog(Me)
                If objSBAccSearch.strSBAccountNo <> String.Empty Then
                    txtAccountNo.Text = objSBAccSearch.strSBAccountNo
                    strAccountNo = objSBAccSearch.strSBAccountNo
                    objSBAccSearch.Dispose()
                End If
            Case "Current Account"
                Dim objCAccSearch As New frmCAccSearch
                objCAccSearch.strCAccountNo = String.Empty
                objCAccSearch.ShowDialog(Me)
                If objCAccSearch.strCAccountNo <> String.Empty Then
                    txtAccountNo.Text = objCAccSearch.strCAccountNo
                    strAccountNo = objCAccSearch.strCAccountNo
                    objCAccSearch.Dispose()
                End If
        End Select

    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub frmAccountSelection_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Top = 275
        Me.Left = 633
    End Sub
End Class
