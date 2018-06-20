Public Class frmVoucherDetails
    Inherits System.Windows.Forms.Form

    Public VoucherNo As Long
    Public VoucherDate As Date
    Public ReferenceNo As String

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
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader6 As System.Windows.Forms.ColumnHeader
    Friend WithEvents lvVoucherDetails As System.Windows.Forms.ListView
    Friend WithEvents btnClose As BankControls.NewButton
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtNarration As System.Windows.Forms.TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmVoucherDetails))
        Me.lvVoucherDetails = New System.Windows.Forms.ListView
        Me.ColumnHeader1 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader3 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader4 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader5 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader6 = New System.Windows.Forms.ColumnHeader
        Me.btnClose = New BankControls.NewButton
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtNarration = New System.Windows.Forms.TextBox
        Me.SuspendLayout()
        '
        'lvVoucherDetails
        '
        Me.lvVoucherDetails.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lvVoucherDetails.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader6})
        Me.lvVoucherDetails.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvVoucherDetails.FullRowSelect = True
        Me.lvVoucherDetails.GridLines = True
        Me.lvVoucherDetails.Location = New System.Drawing.Point(16, 16)
        Me.lvVoucherDetails.MultiSelect = False
        Me.lvVoucherDetails.Name = "lvVoucherDetails"
        Me.lvVoucherDetails.Size = New System.Drawing.Size(536, 240)
        Me.lvVoucherDetails.TabIndex = 0
        Me.lvVoucherDetails.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Sl No."
        Me.ColumnHeader1.Width = 42
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "By / To"
        Me.ColumnHeader3.Width = 66
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Account"
        Me.ColumnHeader4.Width = 205
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Credit"
        Me.ColumnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader5.Width = 91
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Debit"
        Me.ColumnHeader6.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader6.Width = 90
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
        Me.btnClose.Location = New System.Drawing.Point(440, 272)
        Me.btnClose.LostFocusColour = System.Drawing.SystemColors.Control
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(104, 40)
        Me.btnClose.TabIndex = 2
        Me.btnClose.Text = "&Close"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(16, 264)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(79, 19)
        Me.Label1.TabIndex = 77
        Me.Label1.Text = "Narration :"
        '
        'txtNarration
        '
        Me.txtNarration.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNarration.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNarration.Location = New System.Drawing.Point(96, 264)
        Me.txtNarration.Multiline = True
        Me.txtNarration.Name = "txtNarration"
        Me.txtNarration.ReadOnly = True
        Me.txtNarration.Size = New System.Drawing.Size(336, 48)
        Me.txtNarration.TabIndex = 78
        Me.txtNarration.TabStop = False
        Me.txtNarration.Text = ""
        '
        'frmVoucherDetails
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.CancelButton = Me.btnClose
        Me.ClientSize = New System.Drawing.Size(570, 327)
        Me.Controls.Add(Me.txtNarration)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.lvVoucherDetails)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmVoucherDetails"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Voucher Details"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub frmVoucherDetails_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If VoucherNo <> 0 Then
            Me.Text &= " :   No. " & ReferenceNo & "   Date. " & Format(VoucherDate, "dd-MMM-yyyy")
            sbLoadVoucherDetails()
        End If
    End Sub

    Sub sbLoadVoucherDetails()

        Dim objDT As New DataTable
        Dim intCounter As Integer = 0
        Dim lvItem As ListViewItem
        Dim dblTotalCredit As Double = 0
        Dim dblTotalDebit As Double = 0

        lvVoucherDetails.Items.Clear()
        objDT = fnVoucherGetDetails(VoucherNo, Format(VoucherDate, "dd-MMM-yyyy"))

        If objDT.Rows.Count > 0 Then
            While intCounter < objDT.Rows.Count
                lvItem = lvVoucherDetails.Items.Add(intCounter + 1)
                lvItem.SubItems.Add(objDT.Rows(intCounter).Item("ByTo"))
                lvItem.SubItems.Add(objDT.Rows(intCounter).Item("Account"))
                lvItem.SubItems.Add(IIf(objDT.Rows(intCounter).Item("Credit") = 0, "", objDT.Rows(intCounter).Item("Credit")))
                dblTotalCredit += objDT.Rows(intCounter).Item("Credit")

                lvItem.SubItems.Add(IIf(objDT.Rows(intCounter).Item("Debit") = 0, "", objDT.Rows(intCounter).Item("Debit")))
                dblTotalDebit += objDT.Rows(intCounter).Item("Debit")

                intCounter += 1
            End While

            txtNarration.Text = objDT.Rows(intCounter - 1).Item("Narration")

            lvItem = lvVoucherDetails.Items.Add("")
            lvItem = lvVoucherDetails.Items.Add("")

            lvItem = lvVoucherDetails.Items.Add("")
            lvItem.SubItems.Add("")
            lvItem.SubItems.Add("Total")
            lvItem.SubItems.Add(Format(dblTotalCredit, "0.00"))
            lvItem.SubItems.Add(Format(dblTotalDebit, "0.00"))

        End If
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
End Class
