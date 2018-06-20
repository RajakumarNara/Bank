Public Class frmOccupation
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
    Friend WithEvents ShortName As System.Windows.Forms.ColumnHeader
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btnOk As System.Windows.Forms.Button
    Friend WithEvents lblCasteShortName As System.Windows.Forms.Label
    Friend WithEvents lblCasteName As System.Windows.Forms.Label
    Friend WithEvents lblCaste As System.Windows.Forms.Label
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents OccupationCode As System.Windows.Forms.ColumnHeader
    Friend WithEvents OccupationName As System.Windows.Forms.ColumnHeader
    Friend WithEvents txtOccupationShortName As System.Windows.Forms.TextBox
    Friend WithEvents txtOccupationName As System.Windows.Forms.TextBox
    Friend WithEvents lvOccupation As System.Windows.Forms.ListView
    Friend WithEvents txtOccupationCode As System.Windows.Forms.TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.ShortName = New System.Windows.Forms.ColumnHeader
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.lvOccupation = New System.Windows.Forms.ListView
        Me.OccupationCode = New System.Windows.Forms.ColumnHeader
        Me.OccupationName = New System.Windows.Forms.ColumnHeader
        Me.btnOk = New System.Windows.Forms.Button
        Me.txtOccupationShortName = New System.Windows.Forms.TextBox
        Me.txtOccupationName = New System.Windows.Forms.TextBox
        Me.txtOccupationCode = New System.Windows.Forms.TextBox
        Me.lblCasteShortName = New System.Windows.Forms.Label
        Me.lblCasteName = New System.Windows.Forms.Label
        Me.lblCaste = New System.Windows.Forms.Label
        Me.btnCancel = New System.Windows.Forms.Button
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ShortName
        '
        Me.ShortName.Text = "Short Name"
        Me.ShortName.Width = 111
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.lvOccupation)
        Me.Panel1.Controls.Add(Me.btnOk)
        Me.Panel1.Controls.Add(Me.txtOccupationShortName)
        Me.Panel1.Controls.Add(Me.txtOccupationName)
        Me.Panel1.Controls.Add(Me.txtOccupationCode)
        Me.Panel1.Controls.Add(Me.lblCasteShortName)
        Me.Panel1.Controls.Add(Me.lblCasteName)
        Me.Panel1.Controls.Add(Me.lblCaste)
        Me.Panel1.Controls.Add(Me.btnCancel)
        Me.Panel1.Location = New System.Drawing.Point(8, 6)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(424, 384)
        Me.Panel1.TabIndex = 22
        '
        'lvOccupation
        '
        Me.lvOccupation.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.OccupationCode, Me.OccupationName, Me.ShortName})
        Me.lvOccupation.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvOccupation.FullRowSelect = True
        Me.lvOccupation.GridLines = True
        Me.lvOccupation.Location = New System.Drawing.Point(8, 152)
        Me.lvOccupation.Name = "lvOccupation"
        Me.lvOccupation.Size = New System.Drawing.Size(408, 216)
        Me.lvOccupation.TabIndex = 4
        Me.lvOccupation.View = System.Windows.Forms.View.Details
        '
        'OccupationCode
        '
        Me.OccupationCode.Text = "Code"
        Me.OccupationCode.Width = 50
        '
        'OccupationName
        '
        Me.OccupationName.Text = " Name"
        Me.OccupationName.Width = 189
        '
        'btnOk
        '
        Me.btnOk.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOk.Location = New System.Drawing.Point(192, 120)
        Me.btnOk.Name = "btnOk"
        Me.btnOk.Size = New System.Drawing.Size(72, 24)
        Me.btnOk.TabIndex = 3
        Me.btnOk.Text = "&Save"
        '
        'txtOccupationShortName
        '
        Me.txtOccupationShortName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtOccupationShortName.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOccupationShortName.Location = New System.Drawing.Point(168, 88)
        Me.txtOccupationShortName.MaxLength = 20
        Me.txtOccupationShortName.Name = "txtOccupationShortName"
        Me.txtOccupationShortName.Size = New System.Drawing.Size(152, 23)
        Me.txtOccupationShortName.TabIndex = 2
        Me.txtOccupationShortName.Text = ""
        '
        'txtOccupationName
        '
        Me.txtOccupationName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtOccupationName.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOccupationName.Location = New System.Drawing.Point(168, 56)
        Me.txtOccupationName.MaxLength = 50
        Me.txtOccupationName.Name = "txtOccupationName"
        Me.txtOccupationName.Size = New System.Drawing.Size(152, 23)
        Me.txtOccupationName.TabIndex = 1
        Me.txtOccupationName.Text = ""
        '
        'txtOccupationCode
        '
        Me.txtOccupationCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtOccupationCode.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOccupationCode.Location = New System.Drawing.Point(168, 24)
        Me.txtOccupationCode.Name = "txtOccupationCode"
        Me.txtOccupationCode.Size = New System.Drawing.Size(96, 23)
        Me.txtOccupationCode.TabIndex = 0
        Me.txtOccupationCode.Text = ""
        '
        'lblCasteShortName
        '
        Me.lblCasteShortName.AutoSize = True
        Me.lblCasteShortName.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCasteShortName.Location = New System.Drawing.Point(24, 88)
        Me.lblCasteShortName.Name = "lblCasteShortName"
        Me.lblCasteShortName.Size = New System.Drawing.Size(101, 19)
        Me.lblCasteShortName.TabIndex = 2
        Me.lblCasteShortName.Text = "Short Name  :"
        '
        'lblCasteName
        '
        Me.lblCasteName.AutoSize = True
        Me.lblCasteName.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCasteName.Location = New System.Drawing.Point(24, 56)
        Me.lblCasteName.Name = "lblCasteName"
        Me.lblCasteName.Size = New System.Drawing.Size(139, 19)
        Me.lblCasteName.TabIndex = 1
        Me.lblCasteName.Text = "Occupation Name  :"
        '
        'lblCaste
        '
        Me.lblCaste.AutoSize = True
        Me.lblCaste.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCaste.Location = New System.Drawing.Point(24, 24)
        Me.lblCaste.Name = "lblCaste"
        Me.lblCaste.Size = New System.Drawing.Size(138, 19)
        Me.lblCaste.TabIndex = 0
        Me.lblCaste.Text = "Occupation  Code  :"
        '
        'btnCancel
        '
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.Location = New System.Drawing.Point(288, 120)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(72, 24)
        Me.btnCancel.TabIndex = 3
        Me.btnCancel.Text = "&cancel"
        '
        'frmOccupation
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(7, 16)
        Me.CancelButton = Me.btnCancel
        Me.ClientSize = New System.Drawing.Size(440, 397)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmOccupation"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Occupation Master"
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region
    Dim objOccupation As New clsOccupation
    Dim dvOccupation As New DataView


#Region " Button functions(events)"

    'when Button OK is clicked  
    Private Sub btnOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOk.Click
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
        If txtOccupationCode.Text = "" Then
            MsgBox("Enter caste code", MsgBoxStyle.Exclamation)
            txtOccupationCode.Focus()
            Return False

        ElseIf txtOccupationName.Text = "" Then
            MsgBox("Enter caste name ", MsgBoxStyle.Exclamation)
            txtOccupationName.Focus()
            Return False

        ElseIf txtOccupationShortName.Text = "" Then
            MsgBox("Enter caste short name ", MsgBoxStyle.Exclamation)
            txtOccupationShortName.Focus()
            Return False
        Else
            Return True

        End If
    End Function


    'To set form control values to Class Properties
    Function fnsetdata() As Boolean
        objOccupation.OccupationCode = txtOccupationCode.Text
        objOccupation.OccupationName = txtOccupationName.Text
        objOccupation.OccupationShtName = txtOccupationShortName.Text

        Return True

    End Function


    Function fnsavedata() As Boolean

        'Check for Member Existance
        If objOccupation.fnCheckOccupation = False Then

            'ADD new Member  (ADD Mode)
            If objOccupation.fnAddOccupation() Then
                MessageBox.Show("New occupation added successfully.", "Occupation module", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.ServiceNotification)
                Return True
            Else
                MessageBox.Show("New occupation addition failed, because of internal error.", "Occupation module", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1, MessageBoxOptions.ServiceNotification)
                Return False
            End If

        Else

            'Update Details (EDIT Mode)
            If objOccupation.fnUpdateOccupation Then
                MessageBox.Show("Caste updated successfully.", "Occupation module", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.ServiceNotification)
                Return True
            Else
                MessageBox.Show("Caste updation failed, because of internal error.", "Occupation module", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1, MessageBoxOptions.ServiceNotification)
                Return False
            End If
        End If

    End Function

    Sub sbClear()
        txtOccupationCode.ResetText()
        txtOccupationName.ResetText()
        txtOccupationShortName.ResetText()
    End Sub

    Private Sub frmCaste_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        fnLoadData()
    End Sub
    Function fnLoadData() As Boolean
        If objOccupation.fnGetOccupations = True Then
            dvOccupation = New DataView(objOccupation.OccupationTable)

            Dim intCounter As Integer = 0
            Dim lvItem As ListViewItem
            lvOccupation.Items.Clear()

            While intCounter < dvOccupation.Count
                lvItem = lvOccupation.Items.Add(dvOccupation.Item(intCounter).Item(0))
                lvItem.SubItems.Add(dvOccupation.Item(intCounter).Item(1))
                lvItem.SubItems.Add(dvOccupation.Item(intCounter).Item(2))
                intCounter = intCounter + 1
            End While
            If lvOccupation.Items.Count > 0 Then
                lvOccupation.Items(0).Selected = True
            End If
        End If
    End Function
    Private Sub lvOccupation_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles lvOccupation.DoubleClick
        If lvOccupation.SelectedItems.Count > 0 Then
            txtOccupationCode.Text = lvOccupation.SelectedItems(0).SubItems(0).Text
            txtOccupationName.Text = lvOccupation.SelectedItems(0).SubItems(1).Text
            txtOccupationShortName.Text = lvOccupation.SelectedItems(0).SubItems(2).Text
        End If
    End Sub
#End Region

End Class
