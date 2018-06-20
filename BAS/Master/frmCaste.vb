Public Class frmCaste
    Inherits System.Windows.Forms.Form

#Region " form Global variables (object)"
    Dim objCaste As New clsCaste
    Dim dvcast As DataView
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
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents CasteCode As System.Windows.Forms.ColumnHeader
    Friend WithEvents CasteName As System.Windows.Forms.ColumnHeader
    Friend WithEvents ShortName As System.Windows.Forms.ColumnHeader
    Friend WithEvents lvCaste As System.Windows.Forms.ListView
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents txtCasteCode As System.Windows.Forms.TextBox
    Friend WithEvents txtCasteName As System.Windows.Forms.TextBox
    Friend WithEvents txtCasteShortName As System.Windows.Forms.TextBox
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.btnCancel = New System.Windows.Forms.Button
        Me.lvCaste = New System.Windows.Forms.ListView
        Me.CasteCode = New System.Windows.Forms.ColumnHeader
        Me.CasteName = New System.Windows.Forms.ColumnHeader
        Me.ShortName = New System.Windows.Forms.ColumnHeader
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtCasteShortName = New System.Windows.Forms.TextBox
        Me.txtCasteName = New System.Windows.Forms.TextBox
        Me.txtCasteCode = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Button2 = New System.Windows.Forms.Button
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.btnCancel)
        Me.Panel1.Controls.Add(Me.lvCaste)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.txtCasteShortName)
        Me.Panel1.Controls.Add(Me.txtCasteName)
        Me.Panel1.Controls.Add(Me.txtCasteCode)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Location = New System.Drawing.Point(8, 8)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(424, 384)
        Me.Panel1.TabIndex = 21
        '
        'btnCancel
        '
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.Location = New System.Drawing.Point(288, 120)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(72, 24)
        Me.btnCancel.TabIndex = 5
        Me.btnCancel.Text = "&Cancel"
        '
        'lvCaste
        '
        Me.lvCaste.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.CasteCode, Me.CasteName, Me.ShortName})
        Me.lvCaste.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvCaste.FullRowSelect = True
        Me.lvCaste.GridLines = True
        Me.lvCaste.Location = New System.Drawing.Point(8, 152)
        Me.lvCaste.Name = "lvCaste"
        Me.lvCaste.Size = New System.Drawing.Size(408, 216)
        Me.lvCaste.TabIndex = 4
        Me.lvCaste.View = System.Windows.Forms.View.Details
        '
        'CasteCode
        '
        Me.CasteCode.Text = "Code"
        '
        'CasteName
        '
        Me.CasteName.Text = "Name"
        Me.CasteName.Width = 190
        '
        'ShortName
        '
        Me.ShortName.Text = "Short Name"
        Me.ShortName.Width = 121
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(24, 24)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(96, 19)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Caste Code  :"
        '
        'txtCasteShortName
        '
        Me.txtCasteShortName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCasteShortName.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCasteShortName.Location = New System.Drawing.Point(136, 88)
        Me.txtCasteShortName.MaxLength = 20
        Me.txtCasteShortName.Name = "txtCasteShortName"
        Me.txtCasteShortName.Size = New System.Drawing.Size(144, 23)
        Me.txtCasteShortName.TabIndex = 2
        Me.txtCasteShortName.Text = ""
        '
        'txtCasteName
        '
        Me.txtCasteName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCasteName.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCasteName.Location = New System.Drawing.Point(136, 56)
        Me.txtCasteName.MaxLength = 50
        Me.txtCasteName.Name = "txtCasteName"
        Me.txtCasteName.Size = New System.Drawing.Size(144, 23)
        Me.txtCasteName.TabIndex = 1
        Me.txtCasteName.Text = ""
        '
        'txtCasteCode
        '
        Me.txtCasteCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCasteCode.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCasteCode.Location = New System.Drawing.Point(136, 24)
        Me.txtCasteCode.Name = "txtCasteCode"
        Me.txtCasteCode.Size = New System.Drawing.Size(72, 23)
        Me.txtCasteCode.TabIndex = 0
        Me.txtCasteCode.Text = ""
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(24, 88)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(101, 19)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Short Name  :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(24, 56)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(102, 19)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "Caste Name  :"
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(192, 120)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(72, 24)
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "&Save"
        '
        'frmCaste
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(442, 399)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmCaste"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Caste Master"
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region " Button functions(events)"

    'when Button OK is clicked  
    Private Sub btnOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If fncheck() Then
            If fnsetdata() Then
                If fnsavedata() Then
                    sbClear()
                    fnLoadData()
                End If
            End If
        End If

    End Sub

    'When Button Cancel is clicked
    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub
#End Region

#Region " functions and subroutine"

    'to check all the fields in the caste form are entered
    Function fncheck() As Boolean
        If txtCasteCode.Text = "" Then
            MsgBox("Enter caste code", MsgBoxStyle.Exclamation)
            txtCasteCode.Focus()
            Return False

        ElseIf txtCasteName.Text = "" Then
            MsgBox("Enter caste name ", MsgBoxStyle.Exclamation)
            txtCasteName.Focus()
            Return False

        ElseIf txtCasteShortName.Text = "" Then
            MsgBox("Enter caste short name ", MsgBoxStyle.Exclamation)
            txtCasteShortName.Focus()
            Return False
        Else
            Return True

        End If
    End Function


    'To set form control values to Class Properties
    Function fnsetdata() As Boolean
        objCaste.CasteCode = txtCasteCode.Text
        objCaste.CasteName = txtCasteName.Text
        objCaste.CasteShtName = txtCasteShortName.Text

        Return True

    End Function


    Function fnsavedata() As Boolean

        'Check for Member Existance
        If objCaste.fnCheckCaste = False Then

            'ADD new Member  (ADD Mode)
            If objCaste.fnAddCaste() Then
                MessageBox.Show("New caste added successfully.", "Caste module", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.ServiceNotification)
                Return True
            Else
                MessageBox.Show("New caste addition failed, because of internal error.", "caste module", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1, MessageBoxOptions.ServiceNotification)
                Return False
            End If

        Else

            'Update Details (EDIT Mode)
            If objCaste.fnUpdateCaste Then
                MessageBox.Show("Caste updated successfully.", "Caste module", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.ServiceNotification)
                Return True
            Else
                MessageBox.Show("Caste updation failed, because of internal Error.", "Caste Module", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1, MessageBoxOptions.ServiceNotification)
                Return False
            End If
        End If

    End Function

    Sub sbClear()
        txtCasteCode.ResetText()
        txtCasteName.ResetText()
        txtCasteShortName.ResetText()
    End Sub

    Private Sub frmCaste_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        fnLoadData()
    End Sub
    Function fnLoadData() As Boolean
        If objCaste.fnGetCastes = True Then
            dvcast = New DataView(objCaste.CasteTable)

            Dim intCounter As Integer = 0
            Dim lvItem As ListViewItem
            lvCaste.Items.Clear()

            While intCounter < dvcast.Count
                lvItem = lvCaste.Items.Add(dvcast.Item(intCounter).Item(0))
                lvItem.SubItems.Add(dvcast.Item(intCounter).Item(1))
                lvItem.SubItems.Add(dvcast.Item(intCounter).Item(2))
                intCounter = intCounter + 1
            End While
            If lvCaste.Items.Count > 0 Then
                lvCaste.Items(0).Selected = True
            End If
        End If
    End Function
    Private Sub lvCaste_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles lvCaste.DoubleClick
        If lvCaste.SelectedItems.Count > 0 Then
            txtCasteCode.Text = lvCaste.SelectedItems(0).SubItems(0).Text
            txtCasteName.Text = lvCaste.SelectedItems(0).SubItems(1).Text
            txtCasteShortName.Text = lvCaste.SelectedItems(0).SubItems(2).Text
        End If
    End Sub
#End Region

End Class
