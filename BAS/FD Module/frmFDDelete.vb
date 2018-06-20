Public Class frmFDDelete
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
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents txtFDAccountNo As BankControls.TextControl
    Friend WithEvents btnSearchFD As BankControls.NewButton
    Friend WithEvents btnClose As BankControls.NewButton
    Friend WithEvents cmbDepositType As System.Windows.Forms.ComboBox
    Friend WithEvents Label39 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtName As BankControls.TextControl
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label32 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmFDDelete))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtName = New BankControls.TextControl
        Me.cmbDepositType = New System.Windows.Forms.ComboBox
        Me.Label39 = New System.Windows.Forms.Label
        Me.btnClose = New BankControls.NewButton
        Me.Label18 = New System.Windows.Forms.Label
        Me.txtFDAccountNo = New BankControls.TextControl
        Me.btnSearchFD = New BankControls.NewButton
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.Label32 = New System.Windows.Forms.Label
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.PictureBox1)
        Me.GroupBox1.Controls.Add(Me.Label32)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtName)
        Me.GroupBox1.Controls.Add(Me.cmbDepositType)
        Me.GroupBox1.Controls.Add(Me.Label39)
        Me.GroupBox1.Controls.Add(Me.btnClose)
        Me.GroupBox1.Controls.Add(Me.Label18)
        Me.GroupBox1.Controls.Add(Me.txtFDAccountNo)
        Me.GroupBox1.Controls.Add(Me.btnSearchFD)
        Me.GroupBox1.Location = New System.Drawing.Point(16, 16)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(512, 256)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(48, 144)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(41, 17)
        Me.Label2.TabIndex = 67
        Me.Label2.Text = "Name:"
        '
        'txtName
        '
        Me.txtName.AlphaNumeric = False
        Me.txtName.AutoSize = False
        Me.txtName.BackColor = System.Drawing.SystemColors.Window
        Me.txtName.BlankSpace = True
        Me.txtName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtName.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtName.Location = New System.Drawing.Point(104, 144)
        Me.txtName.LostFocusColour = System.Drawing.SystemColors.Window
        Me.txtName.Mandatory = False
        Me.txtName.MaxLength = 35
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(256, 22)
        Me.txtName.SpecialChar = True
        Me.txtName.TabIndex = 5
        Me.txtName.Text = ""
        '
        'cmbDepositType
        '
        Me.cmbDepositType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbDepositType.DropDownWidth = 100
        Me.cmbDepositType.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbDepositType.Items.AddRange(New Object() {"FD", "ENNVY", "SCC"})
        Me.cmbDepositType.Location = New System.Drawing.Point(104, 72)
        Me.cmbDepositType.Name = "cmbDepositType"
        Me.cmbDepositType.Size = New System.Drawing.Size(128, 24)
        Me.cmbDepositType.TabIndex = 1
        '
        'Label39
        '
        Me.Label39.AutoSize = True
        Me.Label39.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label39.ForeColor = System.Drawing.Color.Black
        Me.Label39.Location = New System.Drawing.Point(16, 72)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(80, 17)
        Me.Label39.TabIndex = 66
        Me.Label39.Text = "Deposit Type:"
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
        Me.btnClose.Location = New System.Drawing.Point(112, 192)
        Me.btnClose.LostFocusColour = System.Drawing.Color.FromArgb(CType(176, Byte), CType(236, Byte), CType(199, Byte))
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(104, 40)
        Me.btnClose.TabIndex = 6
        Me.btnClose.Text = "&Delete"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.Black
        Me.Label18.Location = New System.Drawing.Point(24, 112)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(75, 17)
        Me.Label18.TabIndex = 3
        Me.Label18.Text = "Account No: "
        '
        'txtFDAccountNo
        '
        Me.txtFDAccountNo.AlphaNumeric = True
        Me.txtFDAccountNo.BackColor = System.Drawing.SystemColors.Window
        Me.txtFDAccountNo.BlankSpace = False
        Me.txtFDAccountNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFDAccountNo.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtFDAccountNo.Location = New System.Drawing.Point(104, 112)
        Me.txtFDAccountNo.LostFocusColour = System.Drawing.SystemColors.Window
        Me.txtFDAccountNo.Mandatory = False
        Me.txtFDAccountNo.MaxLength = 10
        Me.txtFDAccountNo.Name = "txtFDAccountNo"
        Me.txtFDAccountNo.Size = New System.Drawing.Size(128, 22)
        Me.txtFDAccountNo.SpecialChar = True
        Me.txtFDAccountNo.TabIndex = 4
        Me.txtFDAccountNo.Text = ""
        '
        'btnSearchFD
        '
        Me.btnSearchFD.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSearchFD.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSearchFD.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearchFD.ForeColor = System.Drawing.Color.Black
        Me.btnSearchFD.GotFocusColour = System.Drawing.Color.FromArgb(CType(123, Byte), CType(202, Byte), CType(141, Byte))
        Me.btnSearchFD.Image = CType(resources.GetObject("btnSearchFD.Image"), System.Drawing.Image)
        Me.btnSearchFD.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSearchFD.Location = New System.Drawing.Point(240, 112)
        Me.btnSearchFD.LostFocusColour = System.Drawing.Color.FromArgb(CType(176, Byte), CType(236, Byte), CType(199, Byte))
        Me.btnSearchFD.Name = "btnSearchFD"
        Me.btnSearchFD.Size = New System.Drawing.Size(24, 24)
        Me.btnSearchFD.TabIndex = 3
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(176, Byte), CType(236, Byte), CType(199, Byte))
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(16, 16)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(48, 40)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 70
        Me.PictureBox1.TabStop = False
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.BackColor = System.Drawing.Color.FromArgb(CType(176, Byte), CType(236, Byte), CType(199, Byte))
        Me.Label32.Font = New System.Drawing.Font("Georgia", 14.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label32.ForeColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(64, Byte), CType(0, Byte))
        Me.Label32.Location = New System.Drawing.Point(72, 16)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(170, 25)
        Me.Label32.TabIndex = 69
        Me.Label32.Text = "Delete Transaction"
        Me.Label32.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'frmFDDelete
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.FromArgb(CType(176, Byte), CType(236, Byte), CType(199, Byte))
        Me.ClientSize = New System.Drawing.Size(544, 285)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmFDDelete"
        Me.Text = "FD Delete"
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region


    Dim objFDAccount As New clsFDAccount

    'To load FD Detailst
    Sub sbLoadFD()

        Dim objDT As DataTable
        Dim objIntTable As DataTable
        Try
            If objFDAccount.fnGetFDDetails(txtFDAccountNo.Text) Then
                sbClear()
                objDT = objFDAccount.FDTable

                txtFDAccountNo.Text = objDT.Rows(0).Item("FDNo")
             
                txtName.Text = objDT.Rows(0).Item("Name")
            End If
        Catch ex As Exception
        End Try

    End Sub
    Sub sbClear()
        txtFDAccountNo.ResetText()
        txtName.ResetText()
    End Sub

    Function fnChech() As Boolean
        If cmbDepositType.SelectedIndex = -1 Then
            MsgBox("Select The Deposit Type ")
            cmbDepositType.Focus()
            Return False
        ElseIf txtFDAccountNo.Text = String.Empty Then
            MsgBox("Select FD number ")
            btnSearchFD.Focus()
            Return False
        ElseIf txtName.Text = String.Empty Then
            MsgBox("Select FD number ")
            btnSearchFD.Focus()
            Return False
        Else
            Return True
        End If

    End Function

    Private Sub btnSearchFD_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearchFD.Click
        If cmbDepositType.SelectedIndex <> -1 Then
            Dim objFDSearch As New frmFDSearch
            objFDSearch.strFDType = Trim(cmbDepositType.SelectedItem)
            objFDSearch.strFDNo = ""
            objFDSearch.ShowDialog(Me)
            If objFDSearch.strFDNo <> "" Then
                txtFDAccountNo.Text = objFDSearch.strFDNo
                sbLoadFD()
                txtName.Focus()
            End If
            objFDSearch.Dispose()
        Else
            MsgBox("Select The Deposit Type ")
            cmbDepositType.Focus()
        End If
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        If fnChech() Then
            If objFDAccount.fnDeleteData(txtFDAccountNo.Text) Then

                Dim intCounter As Integer = 0
                Dim objDT As DataTable

                objDT = objFDAccount.FDTable

                While intCounter < objDT.Rows.Count
                    objFDAccount.fnDeleteMain(objDT.Rows(intCounter).Item("VoucherNo"), CDate(objDT.Rows(intCounter).Item("VDate")))
                    objFDAccount.fnDeleteSub(objDT.Rows(intCounter).Item("VoucherNo"), CDate(objDT.Rows(intCounter).Item("VDate")))
                    intCounter += 1
                End While

                ''objFDAccount.fnDeleteFD(txtFDAccountNo.Text)

                MsgBox("Transaction completed successfully", MsgBoxStyle.Information)

            End If
        End If

    End Sub
End Class
