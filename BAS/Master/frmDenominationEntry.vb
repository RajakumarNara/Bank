Public Class frmDenominationEntry
    Inherits System.Windows.Forms.Form

    Dim odjDt As New DataTable

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
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents txtTotal As BankControls.NumericControl
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txtFiftyPai As BankControls.NumericControl
    Friend WithEvents txtOne As BankControls.NumericControl
    Friend WithEvents txtTwo As BankControls.NumericControl
    Friend WithEvents txtFive As BankControls.NumericControl
    Friend WithEvents txtTen As BankControls.NumericControl
    Friend WithEvents txtTwenty As BankControls.NumericControl
    Friend WithEvents txtFifty As BankControls.NumericControl
    Friend WithEvents txtHundread As BankControls.NumericControl
    Friend WithEvents txtFiveHundread As BankControls.NumericControl
    Friend WithEvents txtThousand As BankControls.NumericControl
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents lblFiftyP As System.Windows.Forms.Label
    Friend WithEvents Label37 As System.Windows.Forms.Label
    Friend WithEvents Label39 As System.Windows.Forms.Label
    Friend WithEvents lblOne As System.Windows.Forms.Label
    Friend WithEvents Label33 As System.Windows.Forms.Label
    Friend WithEvents Label35 As System.Windows.Forms.Label
    Friend WithEvents lblTwo As System.Windows.Forms.Label
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents Label31 As System.Windows.Forms.Label
    Friend WithEvents lblFive As System.Windows.Forms.Label
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents lblTen As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents lblTwenty As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents lblFifty As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents lblHundread As System.Windows.Forms.Label
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents Label32 As System.Windows.Forms.Label
    Friend WithEvents lblFivehundread As System.Windows.Forms.Label
    Friend WithEvents Label34 As System.Windows.Forms.Label
    Friend WithEvents Label36 As System.Windows.Forms.Label
    Friend WithEvents lblThousand As System.Windows.Forms.Label
    Friend WithEvents Label38 As System.Windows.Forms.Label
    Friend WithEvents Label40 As System.Windows.Forms.Label
    Friend WithEvents Label41 As System.Windows.Forms.Label
    Friend WithEvents btnDenomination As BankControls.NewButton
    Friend WithEvents dtpDepositDate As System.Windows.Forms.DateTimePicker
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmDenominationEntry))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.Label21 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.dtpDepositDate = New System.Windows.Forms.DateTimePicker
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.txtTotal = New BankControls.NumericControl
        Me.Label26 = New System.Windows.Forms.Label
        Me.Label24 = New System.Windows.Forms.Label
        Me.Label22 = New System.Windows.Forms.Label
        Me.Label20 = New System.Windows.Forms.Label
        Me.Label18 = New System.Windows.Forms.Label
        Me.Label16 = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.txtFiftyPai = New BankControls.NumericControl
        Me.txtOne = New BankControls.NumericControl
        Me.txtTwo = New BankControls.NumericControl
        Me.txtFive = New BankControls.NumericControl
        Me.txtTen = New BankControls.NumericControl
        Me.txtTwenty = New BankControls.NumericControl
        Me.txtFifty = New BankControls.NumericControl
        Me.txtHundread = New BankControls.NumericControl
        Me.txtFiveHundread = New BankControls.NumericControl
        Me.txtThousand = New BankControls.NumericControl
        Me.Label19 = New System.Windows.Forms.Label
        Me.lblFiftyP = New System.Windows.Forms.Label
        Me.Label37 = New System.Windows.Forms.Label
        Me.Label39 = New System.Windows.Forms.Label
        Me.lblOne = New System.Windows.Forms.Label
        Me.Label33 = New System.Windows.Forms.Label
        Me.Label35 = New System.Windows.Forms.Label
        Me.lblTwo = New System.Windows.Forms.Label
        Me.Label29 = New System.Windows.Forms.Label
        Me.Label31 = New System.Windows.Forms.Label
        Me.lblFive = New System.Windows.Forms.Label
        Me.Label25 = New System.Windows.Forms.Label
        Me.Label27 = New System.Windows.Forms.Label
        Me.lblTen = New System.Windows.Forms.Label
        Me.Label15 = New System.Windows.Forms.Label
        Me.Label23 = New System.Windows.Forms.Label
        Me.lblTwenty = New System.Windows.Forms.Label
        Me.Label17 = New System.Windows.Forms.Label
        Me.lblFifty = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label28 = New System.Windows.Forms.Label
        Me.lblHundread = New System.Windows.Forms.Label
        Me.Label30 = New System.Windows.Forms.Label
        Me.Label32 = New System.Windows.Forms.Label
        Me.lblFivehundread = New System.Windows.Forms.Label
        Me.Label34 = New System.Windows.Forms.Label
        Me.Label36 = New System.Windows.Forms.Label
        Me.lblThousand = New System.Windows.Forms.Label
        Me.Label38 = New System.Windows.Forms.Label
        Me.Label40 = New System.Windows.Forms.Label
        Me.Label41 = New System.Windows.Forms.Label
        Me.btnDenomination = New BankControls.NewButton
        Me.GroupBox1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(217, Byte), CType(251, Byte), CType(249, Byte))
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(8, 16)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(40, 24)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 15
        Me.PictureBox1.TabStop = False
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.BackColor = System.Drawing.Color.FromArgb(CType(217, Byte), CType(251, Byte), CType(249, Byte))
        Me.Label21.Font = New System.Drawing.Font("Georgia", 10.25!, System.Drawing.FontStyle.Underline)
        Me.Label21.ForeColor = System.Drawing.Color.Black
        Me.Label21.Location = New System.Drawing.Point(56, 16)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(95, 19)
        Me.Label21.TabIndex = 14
        Me.Label21.Text = "Denomination"
        Me.Label21.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.FromArgb(CType(217, Byte), CType(251, Byte), CType(249, Byte))
        Me.GroupBox1.Controls.Add(Me.dtpDepositDate)
        Me.GroupBox1.Controls.Add(Me.Panel2)
        Me.GroupBox1.Controls.Add(Me.PictureBox1)
        Me.GroupBox1.Controls.Add(Me.Label21)
        Me.GroupBox1.Location = New System.Drawing.Point(0, 8)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(312, 392)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'dtpDepositDate
        '
        Me.dtpDepositDate.CustomFormat = "dd-MMM-yyyy"
        Me.dtpDepositDate.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpDepositDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpDepositDate.Location = New System.Drawing.Point(160, 16)
        Me.dtpDepositDate.Name = "dtpDepositDate"
        Me.dtpDepositDate.Size = New System.Drawing.Size(144, 23)
        Me.dtpDepositDate.TabIndex = 102
        Me.dtpDepositDate.TabStop = False
        Me.dtpDepositDate.Visible = False
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Controls.Add(Me.txtTotal)
        Me.Panel2.Controls.Add(Me.Label26)
        Me.Panel2.Controls.Add(Me.Label24)
        Me.Panel2.Controls.Add(Me.Label22)
        Me.Panel2.Controls.Add(Me.Label20)
        Me.Panel2.Controls.Add(Me.Label18)
        Me.Panel2.Controls.Add(Me.Label16)
        Me.Panel2.Controls.Add(Me.Label14)
        Me.Panel2.Controls.Add(Me.Label12)
        Me.Panel2.Controls.Add(Me.Label11)
        Me.Panel2.Controls.Add(Me.Label13)
        Me.Panel2.Controls.Add(Me.txtFiftyPai)
        Me.Panel2.Controls.Add(Me.txtOne)
        Me.Panel2.Controls.Add(Me.txtTwo)
        Me.Panel2.Controls.Add(Me.txtFive)
        Me.Panel2.Controls.Add(Me.txtTen)
        Me.Panel2.Controls.Add(Me.txtTwenty)
        Me.Panel2.Controls.Add(Me.txtFifty)
        Me.Panel2.Controls.Add(Me.txtHundread)
        Me.Panel2.Controls.Add(Me.txtFiveHundread)
        Me.Panel2.Controls.Add(Me.txtThousand)
        Me.Panel2.Controls.Add(Me.Label19)
        Me.Panel2.Controls.Add(Me.lblFiftyP)
        Me.Panel2.Controls.Add(Me.Label37)
        Me.Panel2.Controls.Add(Me.Label39)
        Me.Panel2.Controls.Add(Me.lblOne)
        Me.Panel2.Controls.Add(Me.Label33)
        Me.Panel2.Controls.Add(Me.Label35)
        Me.Panel2.Controls.Add(Me.lblTwo)
        Me.Panel2.Controls.Add(Me.Label29)
        Me.Panel2.Controls.Add(Me.Label31)
        Me.Panel2.Controls.Add(Me.lblFive)
        Me.Panel2.Controls.Add(Me.Label25)
        Me.Panel2.Controls.Add(Me.Label27)
        Me.Panel2.Controls.Add(Me.lblTen)
        Me.Panel2.Controls.Add(Me.Label15)
        Me.Panel2.Controls.Add(Me.Label23)
        Me.Panel2.Controls.Add(Me.lblTwenty)
        Me.Panel2.Controls.Add(Me.Label17)
        Me.Panel2.Controls.Add(Me.lblFifty)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.Label28)
        Me.Panel2.Controls.Add(Me.lblHundread)
        Me.Panel2.Controls.Add(Me.Label30)
        Me.Panel2.Controls.Add(Me.Label32)
        Me.Panel2.Controls.Add(Me.lblFivehundread)
        Me.Panel2.Controls.Add(Me.Label34)
        Me.Panel2.Controls.Add(Me.Label36)
        Me.Panel2.Controls.Add(Me.lblThousand)
        Me.Panel2.Controls.Add(Me.Label38)
        Me.Panel2.Controls.Add(Me.Label40)
        Me.Panel2.Controls.Add(Me.Label41)
        Me.Panel2.Enabled = False
        Me.Panel2.Location = New System.Drawing.Point(8, 56)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(296, 320)
        Me.Panel2.TabIndex = 101
        '
        'Panel3
        '
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel3.Location = New System.Drawing.Point(8, 264)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(280, 2)
        Me.Panel3.TabIndex = 182
        '
        'txtTotal
        '
        Me.txtTotal.AfterDecimal = 2
        Me.txtTotal.BackColor = System.Drawing.Color.FromArgb(CType(217, Byte), CType(251, Byte), CType(249, Byte))
        Me.txtTotal.BeforeDecimal = 7
        Me.txtTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotal.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtTotal.Location = New System.Drawing.Point(176, 272)
        Me.txtTotal.LostFocusColour = System.Drawing.Color.Empty
        Me.txtTotal.MaxValue = 0
        Me.txtTotal.MinValue = 0
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.ReadOnly = True
        Me.txtTotal.Size = New System.Drawing.Size(96, 22)
        Me.txtTotal.TabIndex = 181
        Me.txtTotal.TabStop = False
        Me.txtTotal.Text = ""
        Me.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label26
        '
        Me.Label26.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.25!)
        Me.Label26.Location = New System.Drawing.Point(104, 272)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(48, 24)
        Me.Label26.TabIndex = 180
        Me.Label26.Text = "Total"
        Me.Label26.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label24
        '
        Me.Label24.BackColor = System.Drawing.Color.FromArgb(CType(217, Byte), CType(251, Byte), CType(249, Byte))
        Me.Label24.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.25!)
        Me.Label24.Location = New System.Drawing.Point(80, 40)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(20, 24)
        Me.Label24.TabIndex = 179
        Me.Label24.Text = "X"
        '
        'Label22
        '
        Me.Label22.BackColor = System.Drawing.Color.FromArgb(CType(217, Byte), CType(251, Byte), CType(249, Byte))
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.25!)
        Me.Label22.Location = New System.Drawing.Point(80, 232)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(20, 24)
        Me.Label22.TabIndex = 178
        Me.Label22.Text = "X"
        '
        'Label20
        '
        Me.Label20.BackColor = System.Drawing.Color.FromArgb(CType(217, Byte), CType(251, Byte), CType(249, Byte))
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.25!)
        Me.Label20.Location = New System.Drawing.Point(80, 208)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(20, 24)
        Me.Label20.TabIndex = 177
        Me.Label20.Text = "X"
        '
        'Label18
        '
        Me.Label18.BackColor = System.Drawing.Color.FromArgb(CType(217, Byte), CType(251, Byte), CType(249, Byte))
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.25!)
        Me.Label18.Location = New System.Drawing.Point(80, 184)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(20, 24)
        Me.Label18.TabIndex = 176
        Me.Label18.Text = "X"
        '
        'Label16
        '
        Me.Label16.BackColor = System.Drawing.Color.FromArgb(CType(217, Byte), CType(251, Byte), CType(249, Byte))
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.25!)
        Me.Label16.Location = New System.Drawing.Point(80, 160)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(20, 24)
        Me.Label16.TabIndex = 175
        Me.Label16.Text = "X"
        '
        'Label14
        '
        Me.Label14.BackColor = System.Drawing.Color.FromArgb(CType(217, Byte), CType(251, Byte), CType(249, Byte))
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.25!)
        Me.Label14.Location = New System.Drawing.Point(80, 136)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(20, 24)
        Me.Label14.TabIndex = 174
        Me.Label14.Text = "X"
        '
        'Label12
        '
        Me.Label12.BackColor = System.Drawing.Color.FromArgb(CType(217, Byte), CType(251, Byte), CType(249, Byte))
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.25!)
        Me.Label12.Location = New System.Drawing.Point(80, 112)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(20, 24)
        Me.Label12.TabIndex = 173
        Me.Label12.Text = "X"
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.Color.FromArgb(CType(217, Byte), CType(251, Byte), CType(249, Byte))
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.25!)
        Me.Label11.Location = New System.Drawing.Point(80, 88)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(20, 24)
        Me.Label11.TabIndex = 172
        Me.Label11.Text = "X"
        '
        'Label13
        '
        Me.Label13.BackColor = System.Drawing.Color.FromArgb(CType(217, Byte), CType(251, Byte), CType(249, Byte))
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.25!)
        Me.Label13.Location = New System.Drawing.Point(80, 64)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(20, 24)
        Me.Label13.TabIndex = 171
        Me.Label13.Text = "X"
        '
        'txtFiftyPai
        '
        Me.txtFiftyPai.AfterDecimal = 2
        Me.txtFiftyPai.BeforeDecimal = 7
        Me.txtFiftyPai.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFiftyPai.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtFiftyPai.Location = New System.Drawing.Point(104, 232)
        Me.txtFiftyPai.LostFocusColour = System.Drawing.Color.Empty
        Me.txtFiftyPai.MaxValue = 0
        Me.txtFiftyPai.MinValue = 0
        Me.txtFiftyPai.Name = "txtFiftyPai"
        Me.txtFiftyPai.Size = New System.Drawing.Size(64, 22)
        Me.txtFiftyPai.TabIndex = 170
        Me.txtFiftyPai.Text = ""
        Me.txtFiftyPai.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtOne
        '
        Me.txtOne.AfterDecimal = 2
        Me.txtOne.BeforeDecimal = 7
        Me.txtOne.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOne.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtOne.Location = New System.Drawing.Point(104, 208)
        Me.txtOne.LostFocusColour = System.Drawing.Color.Empty
        Me.txtOne.MaxValue = 0
        Me.txtOne.MinValue = 0
        Me.txtOne.Name = "txtOne"
        Me.txtOne.Size = New System.Drawing.Size(64, 22)
        Me.txtOne.TabIndex = 169
        Me.txtOne.Text = ""
        Me.txtOne.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtTwo
        '
        Me.txtTwo.AfterDecimal = 2
        Me.txtTwo.BeforeDecimal = 7
        Me.txtTwo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTwo.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtTwo.Location = New System.Drawing.Point(104, 184)
        Me.txtTwo.LostFocusColour = System.Drawing.Color.Empty
        Me.txtTwo.MaxValue = 0
        Me.txtTwo.MinValue = 0
        Me.txtTwo.Name = "txtTwo"
        Me.txtTwo.Size = New System.Drawing.Size(64, 22)
        Me.txtTwo.TabIndex = 168
        Me.txtTwo.Text = ""
        Me.txtTwo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtFive
        '
        Me.txtFive.AfterDecimal = 2
        Me.txtFive.BeforeDecimal = 7
        Me.txtFive.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFive.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtFive.Location = New System.Drawing.Point(104, 160)
        Me.txtFive.LostFocusColour = System.Drawing.Color.Empty
        Me.txtFive.MaxValue = 0
        Me.txtFive.MinValue = 0
        Me.txtFive.Name = "txtFive"
        Me.txtFive.Size = New System.Drawing.Size(64, 22)
        Me.txtFive.TabIndex = 167
        Me.txtFive.Text = ""
        Me.txtFive.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtTen
        '
        Me.txtTen.AfterDecimal = 2
        Me.txtTen.BeforeDecimal = 7
        Me.txtTen.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTen.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtTen.Location = New System.Drawing.Point(104, 136)
        Me.txtTen.LostFocusColour = System.Drawing.Color.Empty
        Me.txtTen.MaxValue = 0
        Me.txtTen.MinValue = 0
        Me.txtTen.Name = "txtTen"
        Me.txtTen.Size = New System.Drawing.Size(64, 22)
        Me.txtTen.TabIndex = 166
        Me.txtTen.Text = ""
        Me.txtTen.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtTwenty
        '
        Me.txtTwenty.AfterDecimal = 2
        Me.txtTwenty.BeforeDecimal = 7
        Me.txtTwenty.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTwenty.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtTwenty.Location = New System.Drawing.Point(104, 112)
        Me.txtTwenty.LostFocusColour = System.Drawing.Color.Empty
        Me.txtTwenty.MaxValue = 0
        Me.txtTwenty.MinValue = 0
        Me.txtTwenty.Name = "txtTwenty"
        Me.txtTwenty.Size = New System.Drawing.Size(64, 22)
        Me.txtTwenty.TabIndex = 165
        Me.txtTwenty.Text = ""
        Me.txtTwenty.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtFifty
        '
        Me.txtFifty.AfterDecimal = 2
        Me.txtFifty.BeforeDecimal = 7
        Me.txtFifty.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFifty.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtFifty.Location = New System.Drawing.Point(104, 88)
        Me.txtFifty.LostFocusColour = System.Drawing.Color.Empty
        Me.txtFifty.MaxValue = 0
        Me.txtFifty.MinValue = 0
        Me.txtFifty.Name = "txtFifty"
        Me.txtFifty.Size = New System.Drawing.Size(64, 22)
        Me.txtFifty.TabIndex = 164
        Me.txtFifty.Text = ""
        Me.txtFifty.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtHundread
        '
        Me.txtHundread.AfterDecimal = 2
        Me.txtHundread.BeforeDecimal = 7
        Me.txtHundread.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHundread.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtHundread.Location = New System.Drawing.Point(104, 64)
        Me.txtHundread.LostFocusColour = System.Drawing.Color.Empty
        Me.txtHundread.MaxValue = 0
        Me.txtHundread.MinValue = 0
        Me.txtHundread.Name = "txtHundread"
        Me.txtHundread.Size = New System.Drawing.Size(64, 22)
        Me.txtHundread.TabIndex = 163
        Me.txtHundread.Text = ""
        Me.txtHundread.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtFiveHundread
        '
        Me.txtFiveHundread.AfterDecimal = 2
        Me.txtFiveHundread.BeforeDecimal = 7
        Me.txtFiveHundread.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFiveHundread.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtFiveHundread.Location = New System.Drawing.Point(104, 40)
        Me.txtFiveHundread.LostFocusColour = System.Drawing.Color.Empty
        Me.txtFiveHundread.MaxValue = 0
        Me.txtFiveHundread.MinValue = 0
        Me.txtFiveHundread.Name = "txtFiveHundread"
        Me.txtFiveHundread.Size = New System.Drawing.Size(64, 22)
        Me.txtFiveHundread.TabIndex = 162
        Me.txtFiveHundread.Text = ""
        Me.txtFiveHundread.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtThousand
        '
        Me.txtThousand.AfterDecimal = 2
        Me.txtThousand.BeforeDecimal = 7
        Me.txtThousand.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtThousand.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtThousand.Location = New System.Drawing.Point(104, 16)
        Me.txtThousand.LostFocusColour = System.Drawing.Color.Empty
        Me.txtThousand.MaxValue = 0
        Me.txtThousand.MinValue = 0
        Me.txtThousand.Name = "txtThousand"
        Me.txtThousand.Size = New System.Drawing.Size(64, 22)
        Me.txtThousand.TabIndex = 161
        Me.txtThousand.Text = ""
        Me.txtThousand.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label19
        '
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.25!)
        Me.Label19.Location = New System.Drawing.Point(16, 184)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(48, 24)
        Me.Label19.TabIndex = 160
        Me.Label19.Text = "2"
        Me.Label19.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblFiftyP
        '
        Me.lblFiftyP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblFiftyP.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.25!)
        Me.lblFiftyP.Location = New System.Drawing.Point(208, 232)
        Me.lblFiftyP.Name = "lblFiftyP"
        Me.lblFiftyP.Size = New System.Drawing.Size(64, 22)
        Me.lblFiftyP.TabIndex = 159
        Me.lblFiftyP.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label37
        '
        Me.Label37.Font = New System.Drawing.Font("Microsoft Sans Serif", 17.25!)
        Me.Label37.Location = New System.Drawing.Point(176, 232)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(20, 24)
        Me.Label37.TabIndex = 158
        Me.Label37.Text = "="
        '
        'Label39
        '
        Me.Label39.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.25!)
        Me.Label39.Location = New System.Drawing.Point(16, 232)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(48, 24)
        Me.Label39.TabIndex = 157
        Me.Label39.Text = "50p"
        Me.Label39.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblOne
        '
        Me.lblOne.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblOne.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.25!)
        Me.lblOne.Location = New System.Drawing.Point(208, 208)
        Me.lblOne.Name = "lblOne"
        Me.lblOne.Size = New System.Drawing.Size(64, 22)
        Me.lblOne.TabIndex = 156
        Me.lblOne.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label33
        '
        Me.Label33.Font = New System.Drawing.Font("Microsoft Sans Serif", 17.25!)
        Me.Label33.Location = New System.Drawing.Point(176, 208)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(20, 24)
        Me.Label33.TabIndex = 155
        Me.Label33.Text = "="
        '
        'Label35
        '
        Me.Label35.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.25!)
        Me.Label35.Location = New System.Drawing.Point(16, 208)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(48, 24)
        Me.Label35.TabIndex = 154
        Me.Label35.Text = "1"
        Me.Label35.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblTwo
        '
        Me.lblTwo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTwo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.25!)
        Me.lblTwo.Location = New System.Drawing.Point(208, 184)
        Me.lblTwo.Name = "lblTwo"
        Me.lblTwo.Size = New System.Drawing.Size(64, 22)
        Me.lblTwo.TabIndex = 153
        Me.lblTwo.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label29
        '
        Me.Label29.Font = New System.Drawing.Font("Microsoft Sans Serif", 17.25!)
        Me.Label29.Location = New System.Drawing.Point(176, 184)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(20, 24)
        Me.Label29.TabIndex = 152
        Me.Label29.Text = "="
        '
        'Label31
        '
        Me.Label31.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.25!)
        Me.Label31.Location = New System.Drawing.Point(16, 160)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(48, 24)
        Me.Label31.TabIndex = 151
        Me.Label31.Text = "5"
        Me.Label31.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblFive
        '
        Me.lblFive.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblFive.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.25!)
        Me.lblFive.Location = New System.Drawing.Point(208, 160)
        Me.lblFive.Name = "lblFive"
        Me.lblFive.Size = New System.Drawing.Size(64, 22)
        Me.lblFive.TabIndex = 150
        Me.lblFive.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label25
        '
        Me.Label25.Font = New System.Drawing.Font("Microsoft Sans Serif", 17.25!)
        Me.Label25.Location = New System.Drawing.Point(176, 160)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(20, 24)
        Me.Label25.TabIndex = 149
        Me.Label25.Text = "="
        '
        'Label27
        '
        Me.Label27.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.25!)
        Me.Label27.Location = New System.Drawing.Point(16, 136)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(48, 24)
        Me.Label27.TabIndex = 148
        Me.Label27.Text = "10"
        Me.Label27.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblTen
        '
        Me.lblTen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTen.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.25!)
        Me.lblTen.Location = New System.Drawing.Point(208, 136)
        Me.lblTen.Name = "lblTen"
        Me.lblTen.Size = New System.Drawing.Size(64, 22)
        Me.lblTen.TabIndex = 147
        Me.lblTen.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label15
        '
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 17.25!)
        Me.Label15.Location = New System.Drawing.Point(176, 136)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(20, 24)
        Me.Label15.TabIndex = 146
        Me.Label15.Text = "="
        '
        'Label23
        '
        Me.Label23.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.25!)
        Me.Label23.Location = New System.Drawing.Point(16, 112)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(48, 24)
        Me.Label23.TabIndex = 145
        Me.Label23.Text = "20 "
        Me.Label23.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblTwenty
        '
        Me.lblTwenty.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTwenty.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.25!)
        Me.lblTwenty.Location = New System.Drawing.Point(208, 112)
        Me.lblTwenty.Name = "lblTwenty"
        Me.lblTwenty.Size = New System.Drawing.Size(64, 22)
        Me.lblTwenty.TabIndex = 144
        Me.lblTwenty.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label17
        '
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 17.25!)
        Me.Label17.Location = New System.Drawing.Point(176, 112)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(20, 24)
        Me.Label17.TabIndex = 143
        Me.Label17.Text = "="
        '
        'lblFifty
        '
        Me.lblFifty.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblFifty.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.25!)
        Me.lblFifty.Location = New System.Drawing.Point(208, 88)
        Me.lblFifty.Name = "lblFifty"
        Me.lblFifty.Size = New System.Drawing.Size(64, 22)
        Me.lblFifty.TabIndex = 142
        Me.lblFifty.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 17.25!)
        Me.Label1.Location = New System.Drawing.Point(176, 88)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(20, 24)
        Me.Label1.TabIndex = 141
        Me.Label1.Text = "="
        '
        'Label28
        '
        Me.Label28.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.25!)
        Me.Label28.Location = New System.Drawing.Point(16, 88)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(48, 24)
        Me.Label28.TabIndex = 140
        Me.Label28.Text = "50"
        Me.Label28.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblHundread
        '
        Me.lblHundread.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblHundread.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.25!)
        Me.lblHundread.Location = New System.Drawing.Point(208, 64)
        Me.lblHundread.Name = "lblHundread"
        Me.lblHundread.Size = New System.Drawing.Size(64, 22)
        Me.lblHundread.TabIndex = 139
        Me.lblHundread.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label30
        '
        Me.Label30.Font = New System.Drawing.Font("Microsoft Sans Serif", 17.25!)
        Me.Label30.Location = New System.Drawing.Point(176, 64)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(20, 24)
        Me.Label30.TabIndex = 138
        Me.Label30.Text = "="
        '
        'Label32
        '
        Me.Label32.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.25!)
        Me.Label32.Location = New System.Drawing.Point(16, 64)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(48, 24)
        Me.Label32.TabIndex = 137
        Me.Label32.Text = "100"
        Me.Label32.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblFivehundread
        '
        Me.lblFivehundread.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblFivehundread.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.25!)
        Me.lblFivehundread.Location = New System.Drawing.Point(208, 40)
        Me.lblFivehundread.Name = "lblFivehundread"
        Me.lblFivehundread.Size = New System.Drawing.Size(64, 22)
        Me.lblFivehundread.TabIndex = 136
        Me.lblFivehundread.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label34
        '
        Me.Label34.Font = New System.Drawing.Font("Microsoft Sans Serif", 17.25!)
        Me.Label34.Location = New System.Drawing.Point(176, 40)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(20, 24)
        Me.Label34.TabIndex = 135
        Me.Label34.Text = "="
        '
        'Label36
        '
        Me.Label36.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.25!)
        Me.Label36.Location = New System.Drawing.Point(16, 40)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(48, 24)
        Me.Label36.TabIndex = 134
        Me.Label36.Text = "500"
        Me.Label36.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblThousand
        '
        Me.lblThousand.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblThousand.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!)
        Me.lblThousand.Location = New System.Drawing.Point(208, 16)
        Me.lblThousand.Name = "lblThousand"
        Me.lblThousand.Size = New System.Drawing.Size(64, 22)
        Me.lblThousand.TabIndex = 133
        Me.lblThousand.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label38
        '
        Me.Label38.Font = New System.Drawing.Font("Microsoft Sans Serif", 17.25!)
        Me.Label38.Location = New System.Drawing.Point(176, 8)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(20, 24)
        Me.Label38.TabIndex = 132
        Me.Label38.Text = "="
        '
        'Label40
        '
        Me.Label40.BackColor = System.Drawing.Color.FromArgb(CType(217, Byte), CType(251, Byte), CType(249, Byte))
        Me.Label40.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.25!)
        Me.Label40.Location = New System.Drawing.Point(80, 8)
        Me.Label40.Name = "Label40"
        Me.Label40.Size = New System.Drawing.Size(20, 24)
        Me.Label40.TabIndex = 131
        Me.Label40.Text = "X"
        '
        'Label41
        '
        Me.Label41.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.25!)
        Me.Label41.Location = New System.Drawing.Point(16, 8)
        Me.Label41.Name = "Label41"
        Me.Label41.Size = New System.Drawing.Size(48, 24)
        Me.Label41.TabIndex = 130
        Me.Label41.Text = "1000 "
        Me.Label41.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'btnDenomination
        '
        Me.btnDenomination.BackColor = System.Drawing.Color.FromArgb(CType(217, Byte), CType(251, Byte), CType(249, Byte))
        Me.btnDenomination.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDenomination.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnDenomination.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDenomination.GotFocusColour = System.Drawing.Color.FromArgb(CType(0, Byte), CType(192, Byte), CType(192, Byte))
        Me.btnDenomination.Location = New System.Drawing.Point(104, 408)
        Me.btnDenomination.LostFocusColour = System.Drawing.Color.FromArgb(CType(217, Byte), CType(251, Byte), CType(249, Byte))
        Me.btnDenomination.Name = "btnDenomination"
        Me.btnDenomination.Size = New System.Drawing.Size(88, 32)
        Me.btnDenomination.TabIndex = 9
        Me.btnDenomination.Visible = False
        '
        'frmDenominationEntry
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.FromArgb(CType(217, Byte), CType(251, Byte), CType(249, Byte))
        Me.ClientSize = New System.Drawing.Size(314, 447)
        Me.Controls.Add(Me.btnDenomination)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "frmDenominationEntry"
        Me.Text = "Denomination Entry"
        Me.GroupBox1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region


    Sub Dispaly()
        Dim dbltotal As Double = 0

        dbltotal = dbltotal + Val(lblFifty.Text)
        dbltotal = dbltotal + Val(lblFiftyP.Text)
        dbltotal = dbltotal + Val(lblFive.Text)
        dbltotal = dbltotal + Val(lblFivehundread.Text)
        dbltotal = dbltotal + Val(lblHundread.Text)
        dbltotal = dbltotal + Val(lblOne.Text)
        dbltotal = dbltotal + Val(lblTen.Text)
        dbltotal = dbltotal + Val(lblThousand.Text)
        dbltotal = dbltotal + Val(lblTwenty.Text)
        dbltotal = dbltotal + Val(lblTwo.Text)
        txtTotal.Text = dbltotal
    End Sub

    Private Sub txtFifty_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        lblFifty.Text = Val(txtFifty.Text) * 50
        Dispaly()
    End Sub

    Private Sub txtFiftyPai_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        lblFiftyP.Text = Val(txtFiftyPai.Text) * 0.5
        Dispaly()
    End Sub

    Private Sub txtFive_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        lblFive.Text = Val(txtFive.Text) * 5
        Dispaly()
    End Sub

    Private Sub txtFiveHundread_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        lblFivehundread.Text = Val(txtFiveHundread.Text) * 500
        Dispaly()

    End Sub

    Private Sub txtHundread_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        lblHundread.Text = Val(txtHundread.Text) * 100
        Dispaly()

    End Sub

    Private Sub txtOne_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        lblOne.Text = txtOne.Text
        Dispaly()

    End Sub

    Private Sub txtTen_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        lblTen.Text = Val(txtTen.Text) * 10
        Dispaly()
    End Sub

    Private Sub txtThousand_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        lblThousand.Text = Val(txtThousand.Text) * 1000
        Dispaly()
    End Sub

    Private Sub txtTwenty_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        lblTwenty.Text = Val(txtTwenty.Text) * 20
        Dispaly()
    End Sub

    Private Sub txtTwo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        lblTwo.Text = Val(txtTwo.Text) * 2
        Dispaly()
    End Sub

End Class
