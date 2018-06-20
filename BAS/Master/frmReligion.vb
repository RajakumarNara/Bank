Public Class frmReligion
    Inherits System.Windows.Forms.Form
#Region " Form Global varibles(object)"
    Dim objReligion As New clsReligion
    Dim regView As DataView
#End Region

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()
        If m_FormDefInstance Is Nothing Then
            If m_InitializingDefInstance Then
                'm_FormDefInstance = 
            End If
        End If
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
    Friend WithEvents txtRegShortName As System.Windows.Forms.TextBox
    Friend WithEvents txtRegName As System.Windows.Forms.TextBox
    Friend WithEvents txtRegCode As System.Windows.Forms.TextBox
    Friend WithEvents lvReligion As System.Windows.Forms.ListView
    Friend WithEvents ReligionName As System.Windows.Forms.ColumnHeader
    Friend WithEvents ShortName As System.Windows.Forms.ColumnHeader
    Friend WithEvents ReligionCode As System.Windows.Forms.ColumnHeader
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.lvReligion = New System.Windows.Forms.ListView
        Me.ReligionCode = New System.Windows.Forms.ColumnHeader
        Me.ReligionName = New System.Windows.Forms.ColumnHeader
        Me.ShortName = New System.Windows.Forms.ColumnHeader
        Me.btnOk = New System.Windows.Forms.Button
        Me.txtRegShortName = New System.Windows.Forms.TextBox
        Me.txtRegName = New System.Windows.Forms.TextBox
        Me.txtRegCode = New System.Windows.Forms.TextBox
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
        Me.Panel1.Controls.Add(Me.lvReligion)
        Me.Panel1.Controls.Add(Me.btnOk)
        Me.Panel1.Controls.Add(Me.txtRegShortName)
        Me.Panel1.Controls.Add(Me.txtRegName)
        Me.Panel1.Controls.Add(Me.txtRegCode)
        Me.Panel1.Controls.Add(Me.lblCasteShortName)
        Me.Panel1.Controls.Add(Me.lblCasteName)
        Me.Panel1.Controls.Add(Me.lblCaste)
        Me.Panel1.Controls.Add(Me.btnCancel)
        Me.Panel1.Location = New System.Drawing.Point(8, 8)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(424, 384)
        Me.Panel1.TabIndex = 22
        '
        'lvReligion
        '
        Me.lvReligion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lvReligion.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ReligionCode, Me.ReligionName, Me.ShortName})
        Me.lvReligion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvReligion.FullRowSelect = True
        Me.lvReligion.GridLines = True
        Me.lvReligion.Location = New System.Drawing.Point(8, 152)
        Me.lvReligion.Name = "lvReligion"
        Me.lvReligion.Size = New System.Drawing.Size(408, 216)
        Me.lvReligion.TabIndex = 4
        Me.lvReligion.View = System.Windows.Forms.View.Details
        '
        'ReligionCode
        '
        Me.ReligionCode.Text = "Code"
        Me.ReligionCode.Width = 50
        '
        'ReligionName
        '
        Me.ReligionName.Text = "Name"
        Me.ReligionName.Width = 231
        '
        'ShortName
        '
        Me.ShortName.Text = "Short Name"
        Me.ShortName.Width = 95
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
        'txtRegShortName
        '
        Me.txtRegShortName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtRegShortName.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRegShortName.Location = New System.Drawing.Point(136, 88)
        Me.txtRegShortName.MaxLength = 20
        Me.txtRegShortName.Name = "txtRegShortName"
        Me.txtRegShortName.Size = New System.Drawing.Size(176, 23)
        Me.txtRegShortName.TabIndex = 2
        Me.txtRegShortName.Text = ""
        '
        'txtRegName
        '
        Me.txtRegName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtRegName.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRegName.Location = New System.Drawing.Point(136, 56)
        Me.txtRegName.MaxLength = 50
        Me.txtRegName.Name = "txtRegName"
        Me.txtRegName.Size = New System.Drawing.Size(176, 23)
        Me.txtRegName.TabIndex = 1
        Me.txtRegName.Text = ""
        '
        'txtRegCode
        '
        Me.txtRegCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtRegCode.Location = New System.Drawing.Point(136, 24)
        Me.txtRegCode.Name = "txtRegCode"
        Me.txtRegCode.Size = New System.Drawing.Size(96, 23)
        Me.txtRegCode.TabIndex = 0
        Me.txtRegCode.Text = ""
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
        Me.lblCasteName.Size = New System.Drawing.Size(117, 19)
        Me.lblCasteName.TabIndex = 1
        Me.lblCasteName.Text = "Religion Name  :"
        '
        'lblCaste
        '
        Me.lblCaste.AutoSize = True
        Me.lblCaste.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCaste.Location = New System.Drawing.Point(24, 24)
        Me.lblCaste.Name = "lblCaste"
        Me.lblCaste.Size = New System.Drawing.Size(112, 19)
        Me.lblCaste.TabIndex = 0
        Me.lblCaste.Text = "Religion Code  :"
        '
        'btnCancel
        '
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.Location = New System.Drawing.Point(288, 120)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(72, 24)
        Me.btnCancel.TabIndex = 4
        Me.btnCancel.Text = "&cancel"
        '
        'frmReligion
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(7, 16)
        Me.CancelButton = Me.btnCancel
        Me.ClientSize = New System.Drawing.Size(440, 397)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmReligion"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Religion Master"
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region "Code to Create Instance Object"

    Private Shared m_FormDefInstance As frmReligion
    Private Shared m_InitializingDefInstance As Boolean

    Public Shared Property DefInstance() As frmReligion
        Get
            If m_FormDefInstance Is Nothing OrElse m_FormDefInstance.IsDisposed Then
                m_InitializingDefInstance = True
                m_FormDefInstance = New frmReligion
                m_InitializingDefInstance = False
            End If
            DefInstance = m_FormDefInstance
        End Get
        Set(ByVal Value As frmReligion)
            m_FormDefInstance = Value
        End Set
    End Property

#End Region

#Region " Button functions(events)"
    'When Button OK is clicked 
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
        If txtRegCode.Text = "" Then
            MsgBox("Enter religion code", MsgBoxStyle.Exclamation)
            txtRegCode.Focus()
            Return False
        ElseIf txtRegName.Text = "" Then
            MsgBox("Enter religion name", MsgBoxStyle.Exclamation)
            txtRegName.Focus()
            Return False
        ElseIf txtRegShortName.Text = "" Then
            MsgBox("Enter short name", MsgBoxStyle.Exclamation)
            txtRegShortName.Focus()
            Return False
        Else
            Return True
        End If
    End Function
    'To set form control values to Class Properties
    Function fnsetdata() As Boolean
        objReligion.ReligionCode = txtRegCode.Text
        objReligion.ReligionName = txtRegName.Text
        objReligion.ReligionShtName = txtRegShortName.Text
        Return True
    End Function
    Function fnsavedata() As Boolean
        'Check for Member Existance
        If objReligion.fnCheckReligion = False Then
            'ADD new Member  (ADD Mode)
            If objReligion.fnAddReligion Then
                MessageBox.Show("New religion added successfully", "Religion module", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.ServiceNotification)
                Return True
            Else
                MessageBox.Show("New religion addition failed, because of internal error.", "Religion module", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1, MessageBoxOptions.ServiceNotification)
                Return False
            End If
        Else

            'Update Details (EDIT Mode)
            If objReligion.fnUpdateReligion Then
                MessageBox.Show("Religion updated successfully.", "Caste module", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.ServiceNotification)
                Return True
            Else
                MessageBox.Show("Religion updation failed, because of internal error.", "Caste module", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1, MessageBoxOptions.ServiceNotification)
                Return False
            End If

        End If
    End Function
    Sub sbClear()
        txtRegCode.ResetText()
        txtRegName.ResetText()
        txtRegShortName.ResetText()
    End Sub


    Private Sub frmReligion_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        fnLoadData()

    End Sub
    Function fnLoadData() As Boolean
        If objReligion.fnGetReligions = True Then
            regView = New DataView(objReligion.ReligionTable)
          
            Dim intCounter As Integer = 0
            Dim lvItem As ListViewItem
            lvReligion.Items.Clear()

            While intCounter < regView.Count
                lvItem = lvReligion.Items.Add(regView.Item(intCounter).Item(0))
                lvItem.SubItems.Add(regView.Item(intCounter).Item(1))
                lvItem.SubItems.Add(regView.Item(intCounter).Item(2))
                intCounter = intCounter + 1
            End While
            If lvReligion.Items.Count > 0 Then
                lvReligion.Items(0).Selected = True
            End If
        End If
    End Function
#End Region

  

    Private Sub lvReligion_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles lvReligion.DoubleClick
        If lvReligion.SelectedItems.Count > 0 Then
            txtRegCode.Text = lvReligion.SelectedItems(0).SubItems(0).Text
            txtRegName.Text = lvReligion.SelectedItems(0).SubItems(1).Text
            txtRegShortName.Text = lvReligion.SelectedItems(0).SubItems(2).Text
        End If
    End Sub

End Class
