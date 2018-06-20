Imports System.IO
Public Class frmSBSignPhoto
    Inherits System.Windows.Forms.Form

#Region "Form Global Variables"
    Dim objSBAccount As New clsSavingsBank
#End Region

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
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnClose As BankControls.NewButton
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents NewButton1 As BankControls.NewButton
    Friend WithEvents picSignature As System.Windows.Forms.PictureBox
    Friend WithEvents lblSignature As System.Windows.Forms.Label
    Friend WithEvents picPhoto As System.Windows.Forms.PictureBox
    Friend WithEvents lblPhoto As System.Windows.Forms.Label
    Friend WithEvents NewButton2 As BankControls.NewButton
    Friend WithEvents NewButton4 As BankControls.NewButton
    Friend WithEvents NewButton3 As BankControls.NewButton
    Friend WithEvents btnSearch As BankControls.NewButton
    Friend WithEvents txtAccno As BankControls.TextControl
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtName As BankControls.TextControl
    Friend WithEvents picDummy As System.Windows.Forms.PictureBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmSBSignPhoto))
        Me.txtAccno = New BankControls.TextControl
        Me.Label1 = New System.Windows.Forms.Label
        Me.btnClose = New BankControls.NewButton
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.picDummy = New System.Windows.Forms.PictureBox
        Me.NewButton1 = New BankControls.NewButton
        Me.picSignature = New System.Windows.Forms.PictureBox
        Me.lblSignature = New System.Windows.Forms.Label
        Me.picPhoto = New System.Windows.Forms.PictureBox
        Me.lblPhoto = New System.Windows.Forms.Label
        Me.NewButton2 = New BankControls.NewButton
        Me.NewButton4 = New BankControls.NewButton
        Me.NewButton3 = New BankControls.NewButton
        Me.btnSearch = New BankControls.NewButton
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtName = New BankControls.TextControl
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtAccno
        '
        Me.txtAccno.AlphaNumeric = True
        Me.txtAccno.BackColor = System.Drawing.Color.White
        Me.txtAccno.BlankSpace = True
        Me.txtAccno.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtAccno.Location = New System.Drawing.Point(112, 16)
        Me.txtAccno.LostFocusColour = System.Drawing.Color.White
        Me.txtAccno.Mandatory = False
        Me.txtAccno.Name = "txtAccno"
        Me.txtAccno.ReadOnly = True
        Me.txtAccno.Size = New System.Drawing.Size(128, 20)
        Me.txtAccno.SpecialChar = False
        Me.txtAccno.TabIndex = 0
        Me.txtAccno.Text = ""
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(16, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(92, 19)
        Me.Label1.TabIndex = 44
        Me.Label1.Text = "Account No :"
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.Color.FromArgb(CType(217, Byte), CType(251, Byte), CType(249, Byte))
        Me.btnClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClose.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.ForeColor = System.Drawing.Color.Teal
        Me.btnClose.GotFocusColour = System.Drawing.Color.FromArgb(CType(255, Byte), CType(128, Byte), CType(128, Byte))
        Me.btnClose.Location = New System.Drawing.Point(571, 329)
        Me.btnClose.LostFocusColour = System.Drawing.Color.FromArgb(CType(217, Byte), CType(251, Byte), CType(249, Byte))
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(80, 32)
        Me.btnClose.TabIndex = 5
        Me.btnClose.Text = "&Close"
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.picDummy)
        Me.Panel1.Controls.Add(Me.NewButton1)
        Me.Panel1.Controls.Add(Me.picSignature)
        Me.Panel1.Controls.Add(Me.lblSignature)
        Me.Panel1.Controls.Add(Me.picPhoto)
        Me.Panel1.Controls.Add(Me.lblPhoto)
        Me.Panel1.Controls.Add(Me.NewButton2)
        Me.Panel1.Controls.Add(Me.NewButton4)
        Me.Panel1.Controls.Add(Me.NewButton3)
        Me.Panel1.Location = New System.Drawing.Point(8, 48)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(648, 272)
        Me.Panel1.TabIndex = 4
        '
        'picDummy
        '
        Me.picDummy.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picDummy.Image = CType(resources.GetObject("picDummy.Image"), System.Drawing.Image)
        Me.picDummy.Location = New System.Drawing.Point(271, 95)
        Me.picDummy.Name = "picDummy"
        Me.picDummy.Size = New System.Drawing.Size(104, 80)
        Me.picDummy.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picDummy.TabIndex = 69
        Me.picDummy.TabStop = False
        Me.picDummy.Visible = False
        '
        'NewButton1
        '
        Me.NewButton1.BackColor = System.Drawing.Color.FromArgb(CType(217, Byte), CType(251, Byte), CType(249, Byte))
        Me.NewButton1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.NewButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.NewButton1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NewButton1.ForeColor = System.Drawing.Color.Black
        Me.NewButton1.GotFocusColour = System.Drawing.Color.FromArgb(CType(0, Byte), CType(192, Byte), CType(192, Byte))
        Me.NewButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.NewButton1.Location = New System.Drawing.Point(88, 216)
        Me.NewButton1.LostFocusColour = System.Drawing.Color.FromArgb(CType(217, Byte), CType(251, Byte), CType(249, Byte))
        Me.NewButton1.Name = "NewButton1"
        Me.NewButton1.Size = New System.Drawing.Size(80, 32)
        Me.NewButton1.TabIndex = 67
        Me.NewButton1.Text = "Load"
        Me.NewButton1.Visible = False
        '
        'picSignature
        '
        Me.picSignature.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picSignature.Image = CType(resources.GetObject("picSignature.Image"), System.Drawing.Image)
        Me.picSignature.Location = New System.Drawing.Point(408, 24)
        Me.picSignature.Name = "picSignature"
        Me.picSignature.Size = New System.Drawing.Size(160, 184)
        Me.picSignature.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picSignature.TabIndex = 64
        Me.picSignature.TabStop = False
        '
        'lblSignature
        '
        Me.lblSignature.AutoSize = True
        Me.lblSignature.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSignature.Location = New System.Drawing.Point(320, 24)
        Me.lblSignature.Name = "lblSignature"
        Me.lblSignature.Size = New System.Drawing.Size(81, 19)
        Me.lblSignature.TabIndex = 63
        Me.lblSignature.Text = "Signature :"
        '
        'picPhoto
        '
        Me.picPhoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picPhoto.Image = CType(resources.GetObject("picPhoto.Image"), System.Drawing.Image)
        Me.picPhoto.Location = New System.Drawing.Point(88, 24)
        Me.picPhoto.Name = "picPhoto"
        Me.picPhoto.Size = New System.Drawing.Size(160, 184)
        Me.picPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picPhoto.TabIndex = 62
        Me.picPhoto.TabStop = False
        '
        'lblPhoto
        '
        Me.lblPhoto.AutoSize = True
        Me.lblPhoto.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPhoto.Location = New System.Drawing.Point(24, 24)
        Me.lblPhoto.Name = "lblPhoto"
        Me.lblPhoto.Size = New System.Drawing.Size(54, 19)
        Me.lblPhoto.TabIndex = 61
        Me.lblPhoto.Text = "Photo :"
        '
        'NewButton2
        '
        Me.NewButton2.BackColor = System.Drawing.Color.FromArgb(CType(217, Byte), CType(251, Byte), CType(249, Byte))
        Me.NewButton2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.NewButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.NewButton2.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NewButton2.ForeColor = System.Drawing.Color.Black
        Me.NewButton2.GotFocusColour = System.Drawing.Color.FromArgb(CType(255, Byte), CType(128, Byte), CType(128, Byte))
        Me.NewButton2.Location = New System.Drawing.Point(168, 216)
        Me.NewButton2.LostFocusColour = System.Drawing.Color.FromArgb(CType(217, Byte), CType(251, Byte), CType(249, Byte))
        Me.NewButton2.Name = "NewButton2"
        Me.NewButton2.Size = New System.Drawing.Size(80, 32)
        Me.NewButton2.TabIndex = 68
        Me.NewButton2.Text = "Cancel"
        Me.NewButton2.Visible = False
        '
        'NewButton4
        '
        Me.NewButton4.BackColor = System.Drawing.Color.FromArgb(CType(217, Byte), CType(251, Byte), CType(249, Byte))
        Me.NewButton4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.NewButton4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.NewButton4.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NewButton4.ForeColor = System.Drawing.Color.Black
        Me.NewButton4.GotFocusColour = System.Drawing.Color.FromArgb(CType(255, Byte), CType(128, Byte), CType(128, Byte))
        Me.NewButton4.Location = New System.Drawing.Point(488, 216)
        Me.NewButton4.LostFocusColour = System.Drawing.Color.FromArgb(CType(217, Byte), CType(251, Byte), CType(249, Byte))
        Me.NewButton4.Name = "NewButton4"
        Me.NewButton4.Size = New System.Drawing.Size(80, 32)
        Me.NewButton4.TabIndex = 65
        Me.NewButton4.Text = "Cancel"
        Me.NewButton4.Visible = False
        '
        'NewButton3
        '
        Me.NewButton3.BackColor = System.Drawing.Color.FromArgb(CType(217, Byte), CType(251, Byte), CType(249, Byte))
        Me.NewButton3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.NewButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.NewButton3.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NewButton3.ForeColor = System.Drawing.Color.Black
        Me.NewButton3.GotFocusColour = System.Drawing.Color.FromArgb(CType(0, Byte), CType(192, Byte), CType(192, Byte))
        Me.NewButton3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.NewButton3.Location = New System.Drawing.Point(408, 216)
        Me.NewButton3.LostFocusColour = System.Drawing.Color.FromArgb(CType(217, Byte), CType(251, Byte), CType(249, Byte))
        Me.NewButton3.Name = "NewButton3"
        Me.NewButton3.Size = New System.Drawing.Size(80, 32)
        Me.NewButton3.TabIndex = 66
        Me.NewButton3.Text = "Load"
        Me.NewButton3.Visible = False
        '
        'btnSearch
        '
        Me.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSearch.Enabled = False
        Me.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSearch.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearch.ForeColor = System.Drawing.Color.Black
        Me.btnSearch.GotFocusColour = System.Drawing.Color.FromArgb(CType(120, Byte), CType(128, Byte), CType(171, Byte))
        Me.btnSearch.Image = CType(resources.GetObject("btnSearch.Image"), System.Drawing.Image)
        Me.btnSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSearch.Location = New System.Drawing.Point(248, 13)
        Me.btnSearch.LostFocusColour = System.Drawing.SystemColors.Control
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(24, 24)
        Me.btnSearch.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(376, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 19)
        Me.Label2.TabIndex = 44
        Me.Label2.Text = "Name :"
        '
        'txtName
        '
        Me.txtName.AlphaNumeric = True
        Me.txtName.BackColor = System.Drawing.Color.White
        Me.txtName.BlankSpace = True
        Me.txtName.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtName.Location = New System.Drawing.Point(424, 16)
        Me.txtName.LostFocusColour = System.Drawing.Color.White
        Me.txtName.Mandatory = False
        Me.txtName.Name = "txtName"
        Me.txtName.ReadOnly = True
        Me.txtName.Size = New System.Drawing.Size(128, 20)
        Me.txtName.SpecialChar = False
        Me.txtName.TabIndex = 3
        Me.txtName.Text = ""
        '
        'frmSBSignPhoto
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.FromArgb(CType(217, Byte), CType(251, Byte), CType(249, Byte))
        Me.CancelButton = Me.btnClose
        Me.ClientSize = New System.Drawing.Size(662, 371)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.txtAccno)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtName)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmSBSignPhoto"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Photo and Signature"
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region "Events"
    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        Dim objSBAccSearch As New frmSBAccSearch
        objSBAccSearch.strSBAccountNo = String.Empty
        objSBAccSearch.ShowDialog(Me)
        If objSBAccSearch.strSBAccountNo <> String.Empty Then
            txtAccno.Text = objSBAccSearch.strSBAccountNo
            txtName.Text = objSBAccSearch.lvSBAccs.SelectedItems(0).SubItems(1).Text
            sbLoadSBAccDetails()
        End If
        objSBAccSearch.Dispose()
    End Sub

    Private Sub frmSignPhoto_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If Trim(txtAccno.Text) <> String.Empty Then
            sbLoadSBAccDetails()
        End If
    End Sub

#End Region

#Region "Sub  Routines"
    Sub sbLoadSBAccDetails()
        Dim objDT As DataTable
        Dim msStream As MemoryStream

        If objSBAccount.fnGetSBAccountDetails(txtAccno.Text) Then
            sbclear()
            objDT = objSBAccount.SBAccTable
            If Not IsDBNull(objDT.Rows(0).Item("Photo")) Then
                If objDT.Rows(0).Item("Photo").length > 0 Then
                    msStream = New MemoryStream(objDT.Rows(0).Item("Photo"), True)
                    msStream.Write(objDT.Rows(0).Item("Photo"), 0, objDT.Rows(0).Item("Photo").length)
                    picPhoto.Image = Image.FromStream(msStream)
                    picPhoto.SizeMode = PictureBoxSizeMode.StretchImage
                    msStream.Close()
                End If
            End If

            If Not IsDBNull(objDT.Rows(0).Item("Signature")) Then
                If objDT.Rows(0).Item("Signature").length > 0 Then
                    msStream = New MemoryStream(objDT.Rows(0).Item("Signature"), True)
                    msStream.Write(objDT.Rows(0).Item("Signature"), 0, objDT.Rows(0).Item("Signature").length)
                    picSignature.Image = Image.FromStream(msStream)
                    picSignature.SizeMode = PictureBoxSizeMode.StretchImage
                    msStream.Close()
                End If
            End If
        End If
        txtName.Focus()
    End Sub
    Sub sbclear()
        picPhoto.Image = picDummy.Image
        picSignature.Image = picDummy.Image
    End Sub
#End Region

    Private Sub NewButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewButton1.Click

    End Sub

    Private Sub NewButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewButton2.Click

    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click

    End Sub
End Class
