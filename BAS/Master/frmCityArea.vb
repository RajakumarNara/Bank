Public Class frmCityArea
    Inherits System.Windows.Forms.Form

#Region " form Global variables (object)"
    Dim objVillage As New clsVillage
    Dim dvVillage As DataView
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
    Friend WithEvents btnOk As System.Windows.Forms.Button
    Friend WithEvents lblCasteShortName As System.Windows.Forms.Label
    Friend WithEvents lblCasteName As System.Windows.Forms.Label
    Friend WithEvents lblCaste As System.Windows.Forms.Label
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents txtShortName As System.Windows.Forms.TextBox
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents txtCode As System.Windows.Forms.TextBox
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents lvVillage As System.Windows.Forms.ListView
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.lvVillage = New System.Windows.Forms.ListView
        Me.ColumnHeader1 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader2 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader3 = New System.Windows.Forms.ColumnHeader
        Me.btnOk = New System.Windows.Forms.Button
        Me.txtShortName = New System.Windows.Forms.TextBox
        Me.txtName = New System.Windows.Forms.TextBox
        Me.txtCode = New System.Windows.Forms.TextBox
        Me.lblCasteShortName = New System.Windows.Forms.Label
        Me.lblCasteName = New System.Windows.Forms.Label
        Me.lblCaste = New System.Windows.Forms.Label
        Me.btnCancel = New System.Windows.Forms.Button
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.lvVillage)
        Me.Panel1.Controls.Add(Me.btnOk)
        Me.Panel1.Controls.Add(Me.txtShortName)
        Me.Panel1.Controls.Add(Me.txtName)
        Me.Panel1.Controls.Add(Me.txtCode)
        Me.Panel1.Controls.Add(Me.lblCasteShortName)
        Me.Panel1.Controls.Add(Me.lblCasteName)
        Me.Panel1.Controls.Add(Me.lblCaste)
        Me.Panel1.Controls.Add(Me.btnCancel)
        Me.Panel1.Location = New System.Drawing.Point(8, 6)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(424, 344)
        Me.Panel1.TabIndex = 23
        '
        'lvVillage
        '
        Me.lvVillage.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3})
        Me.lvVillage.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.lvVillage.GridLines = True
        Me.lvVillage.Location = New System.Drawing.Point(8, 126)
        Me.lvVillage.Name = "lvVillage"
        Me.lvVillage.Size = New System.Drawing.Size(408, 208)
        Me.lvVillage.TabIndex = 4
        Me.lvVillage.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Code"
        Me.ColumnHeader1.Width = 54
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Name"
        Me.ColumnHeader2.Width = 201
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Short Name"
        Me.ColumnHeader3.Width = 118
        '
        'btnOk
        '
        Me.btnOk.Location = New System.Drawing.Point(56, 89)
        Me.btnOk.Name = "btnOk"
        Me.btnOk.Size = New System.Drawing.Size(72, 24)
        Me.btnOk.TabIndex = 3
        Me.btnOk.Text = "&Save"
        '
        'txtShortName
        '
        Me.txtShortName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtShortName.Location = New System.Drawing.Point(120, 56)
        Me.txtShortName.MaxLength = 20
        Me.txtShortName.Name = "txtShortName"
        Me.txtShortName.Size = New System.Drawing.Size(112, 20)
        Me.txtShortName.TabIndex = 2
        Me.txtShortName.Text = ""
        '
        'txtName
        '
        Me.txtName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtName.Location = New System.Drawing.Point(120, 32)
        Me.txtName.MaxLength = 50
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(112, 20)
        Me.txtName.TabIndex = 1
        Me.txtName.Text = ""
        '
        'txtCode
        '
        Me.txtCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCode.Location = New System.Drawing.Point(120, 8)
        Me.txtCode.Name = "txtCode"
        Me.txtCode.Size = New System.Drawing.Size(72, 20)
        Me.txtCode.TabIndex = 0
        Me.txtCode.Text = ""
        '
        'lblCasteShortName
        '
        Me.lblCasteShortName.AutoSize = True
        Me.lblCasteShortName.Location = New System.Drawing.Point(32, 56)
        Me.lblCasteShortName.Name = "lblCasteShortName"
        Me.lblCasteShortName.Size = New System.Drawing.Size(74, 16)
        Me.lblCasteShortName.TabIndex = 2
        Me.lblCasteShortName.Text = "Short Name  :"
        '
        'lblCasteName
        '
        Me.lblCasteName.AutoSize = True
        Me.lblCasteName.Location = New System.Drawing.Point(32, 32)
        Me.lblCasteName.Name = "lblCasteName"
        Me.lblCasteName.Size = New System.Drawing.Size(93, 16)
        Me.lblCasteName.TabIndex = 1
        Me.lblCasteName.Text = "City Area Name  :"
        '
        'lblCaste
        '
        Me.lblCaste.AutoSize = True
        Me.lblCaste.Location = New System.Drawing.Point(32, 8)
        Me.lblCaste.Name = "lblCaste"
        Me.lblCaste.Size = New System.Drawing.Size(90, 16)
        Me.lblCaste.TabIndex = 0
        Me.lblCaste.Text = "City/Area Code  :"
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(168, 89)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(72, 24)
        Me.btnCancel.TabIndex = 3
        Me.btnCancel.Text = "&cancel"
        '
        'frmCityArea
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(440, 357)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "frmCityArea"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "City Area Master"
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region



#Region " functions and subroutine"

    'to check all the fields in the caste form are entered
    Function fncheck() As Boolean
        If txtCode.Text = "" Then
            MsgBox("Enter Vilage code")
            txtCode.Focus()
            Return False

        ElseIf txtName.Text = "" Then
            MsgBox("Enter Village Name ")
            txtName.Focus()
            Return False

        ElseIf txtShortName.Text = "" Then
            MsgBox("Enter Village Short Name ")
            txtShortName.Focus()
            Return False
        Else
            Return True

        End If
    End Function


    'To set form control values to Class Properties
    Function fnsetdata() As Boolean
        objVillage.VillageCode = txtCode.Text
        objVillage.VillageName = txtName.Text
        objVillage.VillageShortName = txtShortName.Text

        Return True

    End Function


    Function fnsavedata() As Boolean

        'Check for Member Existance
        If objVillage.fnCheckCaste = False Then

            'ADD new Member  (ADD Mode)
            If objVillage.fnAddVillage() Then
                MessageBox.Show("New Area\City Added Successfully.", " Area\City Module", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.ServiceNotification)
                Return True
            Else
                MessageBox.Show("New  Area\City Addition Failed, because of Internal Error.", " Area\City Module", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1, MessageBoxOptions.ServiceNotification)
                Return False
            End If

        Else

            'Update Details (EDIT Mode)
            If objVillage.fnUpdateVillage Then
                MessageBox.Show(" Area\City Updated Successfully.", " Area\City Module", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.ServiceNotification)
                Return True
            Else
                MessageBox.Show(" Area\City Updation Failed, because of Internal Error.", " Area\City Module", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1, MessageBoxOptions.ServiceNotification)
                Return False
            End If
        End If

    End Function

    Sub sbClear()
        txtCode.ResetText()
        txtName.ResetText()
        txtShortName.ResetText()
    End Sub

    Function fnLoadData() As Boolean
        If objVillage.fnGetVillages = True Then
            dvVillage = New DataView(objVillage.VillageTable)
            Dim intCounter As Integer = 0
            Dim lvItem As ListViewItem
            lvVillage.Items.Clear()
            While intCounter < dvVillage.Count
                lvItem = lvVillage.Items.Add(dvVillage.Item(intCounter).Item(0))
                lvItem.SubItems.Add(dvVillage.Item(intCounter).Item(1))
                lvItem.SubItems.Add(dvVillage.Item(intCounter).Item(2))
                intCounter = intCounter + 1
            End While

            If lvVillage.Items.Count > 0 Then
                lvVillage.Items(0).Selected = True
            End If
        End If
    End Function

#End Region


    Private Sub frmCityArea_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        fnLoadData()
    End Sub



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

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub


    Private Sub lvVillage_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If lvVillage.SelectedItems.Count > 0 Then
            txtCode.Text = lvVillage.SelectedItems(0).SubItems(0).Text
            txtName.Text = lvVillage.SelectedItems(0).SubItems(1).Text
            txtShortName.Text = lvVillage.SelectedItems(0).SubItems(2).Text
        End If
    End Sub
End Class
