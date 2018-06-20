Imports System.IO
Public Class frmCASignPhoto
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
    Friend WithEvents btnSearch As BankControls.NewButton
    Friend WithEvents txtAccno As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents GrpMan As System.Windows.Forms.GroupBox
    Friend WithEvents Grpfir As System.Windows.Forms.GroupBox
    Friend WithEvents Grpsec As System.Windows.Forms.GroupBox
    Friend WithEvents lblPhoto As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents picPhoto1 As System.Windows.Forms.PictureBox
    Friend WithEvents picSign1 As System.Windows.Forms.PictureBox
    Friend WithEvents picSign2 As System.Windows.Forms.PictureBox
    Friend WithEvents picphoto2 As System.Windows.Forms.PictureBox
    Friend WithEvents picSign3 As System.Windows.Forms.PictureBox
    Friend WithEvents picphoto3 As System.Windows.Forms.PictureBox
    Friend WithEvents btnClose As BankControls.NewButton
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtName1 As BankControls.TextControl
    Friend WithEvents txtName2 As BankControls.TextControl
    Friend WithEvents txtName3 As BankControls.TextControl
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmCASignPhoto))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.btnClose = New BankControls.NewButton
        Me.Grpsec = New System.Windows.Forms.GroupBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.txtName3 = New BankControls.TextControl
        Me.Label6 = New System.Windows.Forms.Label
        Me.picSign3 = New System.Windows.Forms.PictureBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.picphoto3 = New System.Windows.Forms.PictureBox
        Me.Grpfir = New System.Windows.Forms.GroupBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.txtName2 = New BankControls.TextControl
        Me.Label4 = New System.Windows.Forms.Label
        Me.picSign2 = New System.Windows.Forms.PictureBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.picphoto2 = New System.Windows.Forms.PictureBox
        Me.btnSearch = New BankControls.NewButton
        Me.txtAccno = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtName = New System.Windows.Forms.TextBox
        Me.GrpMan = New System.Windows.Forms.GroupBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.txtName1 = New BankControls.TextControl
        Me.Label3 = New System.Windows.Forms.Label
        Me.picSign1 = New System.Windows.Forms.PictureBox
        Me.lblPhoto = New System.Windows.Forms.Label
        Me.picPhoto1 = New System.Windows.Forms.PictureBox
        Me.GroupBox1.SuspendLayout()
        Me.Grpsec.SuspendLayout()
        Me.Grpfir.SuspendLayout()
        Me.GrpMan.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnClose)
        Me.GroupBox1.Controls.Add(Me.Grpsec)
        Me.GroupBox1.Controls.Add(Me.Grpfir)
        Me.GroupBox1.Controls.Add(Me.btnSearch)
        Me.GroupBox1.Controls.Add(Me.txtAccno)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtName)
        Me.GroupBox1.Controls.Add(Me.GrpMan)
        Me.GroupBox1.Location = New System.Drawing.Point(0, 8)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(720, 384)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.Color.FromArgb(CType(238, Byte), CType(253, Byte), CType(248, Byte))
        Me.btnClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnClose.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.ForeColor = System.Drawing.Color.Black
        Me.btnClose.GotFocusColour = System.Drawing.Color.FromArgb(CType(255, Byte), CType(128, Byte), CType(128, Byte))
        Me.btnClose.Location = New System.Drawing.Point(624, 352)
        Me.btnClose.LostFocusColour = System.Drawing.Color.FromArgb(CType(238, Byte), CType(253, Byte), CType(248, Byte))
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(56, 24)
        Me.btnClose.TabIndex = 6
        Me.btnClose.Text = "&Close"
        '
        'Grpsec
        '
        Me.Grpsec.Controls.Add(Me.Label10)
        Me.Grpsec.Controls.Add(Me.txtName3)
        Me.Grpsec.Controls.Add(Me.Label6)
        Me.Grpsec.Controls.Add(Me.picSign3)
        Me.Grpsec.Controls.Add(Me.Label7)
        Me.Grpsec.Controls.Add(Me.picphoto3)
        Me.Grpsec.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Grpsec.Location = New System.Drawing.Point(488, 48)
        Me.Grpsec.Name = "Grpsec"
        Me.Grpsec.Size = New System.Drawing.Size(224, 304)
        Me.Grpsec.TabIndex = 5
        Me.Grpsec.TabStop = False
        Me.Grpsec.Text = "Second Auxiliary Signatories   "
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(8, 32)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(50, 19)
        Me.Label10.TabIndex = 96
        Me.Label10.Text = "Name:"
        '
        'txtName3
        '
        Me.txtName3.AlphaNumeric = False
        Me.txtName3.AutoSize = False
        Me.txtName3.BlankSpace = True
        Me.txtName3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtName3.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtName3.Location = New System.Drawing.Point(64, 32)
        Me.txtName3.LostFocusColour = System.Drawing.SystemColors.Window
        Me.txtName3.Mandatory = False
        Me.txtName3.MaxLength = 30
        Me.txtName3.Name = "txtName3"
        Me.txtName3.ReadOnly = True
        Me.txtName3.Size = New System.Drawing.Size(152, 24)
        Me.txtName3.SpecialChar = True
        Me.txtName3.TabIndex = 6
        Me.txtName3.Text = ""
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(8, 200)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(79, 18)
        Me.Label6.TabIndex = 60
        Me.Label6.Text = "Signature:  "
        '
        'picSign3
        '
        Me.picSign3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picSign3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.picSign3.Location = New System.Drawing.Point(88, 192)
        Me.picSign3.Name = "picSign3"
        Me.picSign3.Size = New System.Drawing.Size(96, 100)
        Me.picSign3.TabIndex = 59
        Me.picSign3.TabStop = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(24, 80)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(45, 18)
        Me.Label7.TabIndex = 58
        Me.Label7.Text = "Photo:"
        '
        'picphoto3
        '
        Me.picphoto3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picphoto3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.picphoto3.Location = New System.Drawing.Point(88, 72)
        Me.picphoto3.Name = "picphoto3"
        Me.picphoto3.Size = New System.Drawing.Size(96, 100)
        Me.picphoto3.TabIndex = 57
        Me.picphoto3.TabStop = False
        '
        'Grpfir
        '
        Me.Grpfir.Controls.Add(Me.Label9)
        Me.Grpfir.Controls.Add(Me.txtName2)
        Me.Grpfir.Controls.Add(Me.Label4)
        Me.Grpfir.Controls.Add(Me.picSign2)
        Me.Grpfir.Controls.Add(Me.Label5)
        Me.Grpfir.Controls.Add(Me.picphoto2)
        Me.Grpfir.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Grpfir.Location = New System.Drawing.Point(248, 48)
        Me.Grpfir.Name = "Grpfir"
        Me.Grpfir.Size = New System.Drawing.Size(224, 304)
        Me.Grpfir.TabIndex = 4
        Me.Grpfir.TabStop = False
        Me.Grpfir.Text = "First Auxiliary Signatories    "
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(8, 32)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(50, 19)
        Me.Label9.TabIndex = 92
        Me.Label9.Text = "Name:"
        '
        'txtName2
        '
        Me.txtName2.AlphaNumeric = False
        Me.txtName2.AutoSize = False
        Me.txtName2.BlankSpace = True
        Me.txtName2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtName2.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtName2.Location = New System.Drawing.Point(64, 32)
        Me.txtName2.LostFocusColour = System.Drawing.SystemColors.Window
        Me.txtName2.Mandatory = False
        Me.txtName2.MaxLength = 30
        Me.txtName2.Name = "txtName2"
        Me.txtName2.ReadOnly = True
        Me.txtName2.Size = New System.Drawing.Size(152, 24)
        Me.txtName2.SpecialChar = True
        Me.txtName2.TabIndex = 5
        Me.txtName2.Text = ""
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(8, 200)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(79, 18)
        Me.Label4.TabIndex = 60
        Me.Label4.Text = "Signature:  "
        '
        'picSign2
        '
        Me.picSign2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picSign2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.picSign2.Location = New System.Drawing.Point(88, 192)
        Me.picSign2.Name = "picSign2"
        Me.picSign2.Size = New System.Drawing.Size(96, 100)
        Me.picSign2.TabIndex = 59
        Me.picSign2.TabStop = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(24, 80)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(45, 18)
        Me.Label5.TabIndex = 58
        Me.Label5.Text = "Photo:"
        '
        'picphoto2
        '
        Me.picphoto2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picphoto2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.picphoto2.Location = New System.Drawing.Point(88, 72)
        Me.picphoto2.Name = "picphoto2"
        Me.picphoto2.Size = New System.Drawing.Size(96, 100)
        Me.picphoto2.TabIndex = 57
        Me.picphoto2.TabStop = False
        '
        'btnSearch
        '
        Me.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSearch.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearch.ForeColor = System.Drawing.Color.Black
        Me.btnSearch.GotFocusColour = System.Drawing.Color.FromArgb(CType(120, Byte), CType(128, Byte), CType(171, Byte))
        Me.btnSearch.Image = CType(resources.GetObject("btnSearch.Image"), System.Drawing.Image)
        Me.btnSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSearch.Location = New System.Drawing.Point(248, 16)
        Me.btnSearch.LostFocusColour = System.Drawing.SystemColors.Control
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(24, 24)
        Me.btnSearch.TabIndex = 1
        '
        'txtAccno
        '
        Me.txtAccno.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAccno.Location = New System.Drawing.Point(112, 16)
        Me.txtAccno.Name = "txtAccno"
        Me.txtAccno.Size = New System.Drawing.Size(128, 23)
        Me.txtAccno.TabIndex = 0
        Me.txtAccno.Text = ""
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(16, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(86, 19)
        Me.Label1.TabIndex = 102
        Me.Label1.Text = "Account No."
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(400, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 19)
        Me.Label2.TabIndex = 103
        Me.Label2.Text = "Name"
        '
        'txtName
        '
        Me.txtName.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtName.Location = New System.Drawing.Point(456, 16)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(128, 23)
        Me.txtName.TabIndex = 2
        Me.txtName.Text = ""
        '
        'GrpMan
        '
        Me.GrpMan.Controls.Add(Me.Label8)
        Me.GrpMan.Controls.Add(Me.txtName1)
        Me.GrpMan.Controls.Add(Me.Label3)
        Me.GrpMan.Controls.Add(Me.picSign1)
        Me.GrpMan.Controls.Add(Me.lblPhoto)
        Me.GrpMan.Controls.Add(Me.picPhoto1)
        Me.GrpMan.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GrpMan.Location = New System.Drawing.Point(8, 48)
        Me.GrpMan.Name = "GrpMan"
        Me.GrpMan.Size = New System.Drawing.Size(224, 304)
        Me.GrpMan.TabIndex = 3
        Me.GrpMan.TabStop = False
        Me.GrpMan.Text = "Mandatory Signatories    "
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(8, 32)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(50, 19)
        Me.Label8.TabIndex = 90
        Me.Label8.Text = "Name:"
        '
        'txtName1
        '
        Me.txtName1.AlphaNumeric = False
        Me.txtName1.AutoSize = False
        Me.txtName1.BlankSpace = True
        Me.txtName1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtName1.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtName1.Location = New System.Drawing.Point(64, 32)
        Me.txtName1.LostFocusColour = System.Drawing.SystemColors.Window
        Me.txtName1.Mandatory = False
        Me.txtName1.MaxLength = 30
        Me.txtName1.Name = "txtName1"
        Me.txtName1.ReadOnly = True
        Me.txtName1.Size = New System.Drawing.Size(152, 24)
        Me.txtName1.SpecialChar = True
        Me.txtName1.TabIndex = 4
        Me.txtName1.Text = ""
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(8, 200)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(75, 18)
        Me.Label3.TabIndex = 56
        Me.Label3.Text = "Signature: "
        '
        'picSign1
        '
        Me.picSign1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picSign1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.picSign1.Location = New System.Drawing.Point(88, 192)
        Me.picSign1.Name = "picSign1"
        Me.picSign1.Size = New System.Drawing.Size(96, 100)
        Me.picSign1.TabIndex = 55
        Me.picSign1.TabStop = False
        '
        'lblPhoto
        '
        Me.lblPhoto.AutoSize = True
        Me.lblPhoto.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPhoto.Location = New System.Drawing.Point(16, 80)
        Me.lblPhoto.Name = "lblPhoto"
        Me.lblPhoto.Size = New System.Drawing.Size(45, 18)
        Me.lblPhoto.TabIndex = 54
        Me.lblPhoto.Text = "Photo:"
        '
        'picPhoto1
        '
        Me.picPhoto1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picPhoto1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.picPhoto1.Location = New System.Drawing.Point(88, 72)
        Me.picPhoto1.Name = "picPhoto1"
        Me.picPhoto1.Size = New System.Drawing.Size(96, 100)
        Me.picPhoto1.TabIndex = 0
        Me.picPhoto1.TabStop = False
        '
        'frmCASignPhoto
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.FromArgb(CType(217, Byte), CType(251, Byte), CType(249, Byte))
        Me.CancelButton = Me.btnClose
        Me.ClientSize = New System.Drawing.Size(720, 399)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmCASignPhoto"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmCASignPhoto"
        Me.GroupBox1.ResumeLayout(False)
        Me.Grpsec.ResumeLayout(False)
        Me.Grpfir.ResumeLayout(False)
        Me.GrpMan.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region "Global Variables"
    Dim objsignatory As New clsSignatories
    Dim msStream As MemoryStream
    Dim msStream1 As MemoryStream
#End Region

#Region " subroutines"
    Sub caloadsignatorydetails()
        Dim objDT As DataTable
        Dim DtRow As DataRow
        Dim intcounter As Integer = 1
        If objsignatory.fnGetSignatories(txtAccno.Text) Then
            objDT = objsignatory.SignatoryTable
            For Each DtRow In objDT.Rows
                If Not IsDBNull(DtRow("Photo")) Then
                    If DtRow("Photo").length > 0 Then
                        FnDisplayPhoto(DtRow)
                    End If
                End If
                If Not IsDBNull(DtRow("Signature")) Then
                    If DtRow("Signature").length > 0 Then
                        FnDisplaySign(DtRow)
                    End If
                End If
            Next
        End If
    End Sub
    Function FnDisplayPhoto(ByVal Row As DataRow) As Boolean
        msStream = New MemoryStream(Row("Photo"), True)
        msStream.Write(Row("Photo"), 0, Row.Item("Photo").length)

        If Row.Item("No") = 1 Then
            picPhoto1.Image = Image.FromStream(msStream)
            picPhoto1.SizeMode = PictureBoxSizeMode.StretchImage
            txtName1.Text = Row.Item("SignName")
            msStream.Close()
            Return True
        ElseIf Row.Item("No") = 2 Then
            picphoto2.Image = Image.FromStream(msStream)
            picphoto2.SizeMode = PictureBoxSizeMode.StretchImage
            txtName2.Text = Row.Item("SignName")
            msStream.Close()
            Return True
        ElseIf Row.Item("No") = 3 Then
            picphoto3.Image = Image.FromStream(msStream)
            picphoto3.SizeMode = PictureBoxSizeMode.StretchImage
            txtName3.Text = Row.Item("SignName")
            msStream.Close()
            Return True
        Else
            Return False
        End If
    End Function

    Function FnDisplaySign(ByVal Row As DataRow) As Boolean
        msStream = New MemoryStream(Row("Signature"), True)
        msStream.Write(Row("Signature"), 0, Row.Item("Signature").length)

        If Row.Item("No") = 1 Then
            picSign1.Image = Image.FromStream(msStream)
            picSign1.SizeMode = PictureBoxSizeMode.StretchImage
            txtName1.Text = Row.Item("SignName")
            msStream.Close()
            Return True
        ElseIf Row.Item("No") = 2 Then
            picSign2.Image = Image.FromStream(msStream)
            picSign2.SizeMode = PictureBoxSizeMode.StretchImage
            txtName2.Text = Row.Item("SignName")
            msStream.Close()
            Return True
        ElseIf Row.Item("No") = 3 Then
            picSign3.Image = Image.FromStream(msStream)
            picSign3.SizeMode = PictureBoxSizeMode.StretchImage
            txtName3.Text = Row.Item("SignName")
            msStream.Close()
            Return True
        Else
            Return False
        End If
    End Function

    Sub sbclear()
        picPhoto1.Image = Nothing
        picphoto2.Image = Nothing
        picphoto3.Image = Nothing
        picSign1.Image = Nothing
        picSign2.Image = Nothing
        picSign3.Image = Nothing
    End Sub


#End Region

    Private Sub frmCASignPhoto_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If txtAccno.Text <> String.Empty Then
            caloadsignatorydetails()
        End If
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub


End Class
