Public Class permissions
    Inherits System.Windows.Forms.UserControl

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    'UserControl overrides dispose to clean up the component list.
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
    Friend WithEvents txtModule As System.Windows.Forms.TextBox
    Friend WithEvents chkAll As System.Windows.Forms.CheckBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.chkAll = New System.Windows.Forms.CheckBox
        Me.txtModule = New System.Windows.Forms.TextBox
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'chkAll
        '
        Me.chkAll.Location = New System.Drawing.Point(240, 4)
        Me.chkAll.Name = "chkAll"
        Me.chkAll.Size = New System.Drawing.Size(16, 24)
        Me.chkAll.TabIndex = 1
        Me.chkAll.Text = "chkAdmin"
        '
        'txtModule
        '
        Me.txtModule.AutoSize = False
        Me.txtModule.BackColor = System.Drawing.SystemColors.HighlightText
        Me.txtModule.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtModule.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtModule.Location = New System.Drawing.Point(0, 0)
        Me.txtModule.Name = "txtModule"
        Me.txtModule.ReadOnly = True
        Me.txtModule.Size = New System.Drawing.Size(216, 24)
        Me.txtModule.TabIndex = 5
        Me.txtModule.Text = ""
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.txtModule)
        Me.Panel1.Controls.Add(Me.chkAll)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(272, 32)
        Me.Panel1.TabIndex = 6
        '
        'permissions
        '
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Controls.Add(Me.Panel1)
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Name = "permissions"
        Me.Size = New System.Drawing.Size(272, 32)
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region "Variables"
#End Region

#Region "Properties"
    Public Property ModuleName() As TextBox
        Get
            Return txtModule
        End Get
        Set(ByVal Value As TextBox)
            txtModule = Value
        End Set
    End Property
    Public Property chekAll() As CheckBox
        Get
            Return chkAll
        End Get
        Set(ByVal Value As CheckBox)
            chkAll = Value
        End Set
    End Property


#End Region

    'Private Sub Panel1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Panel1.DoubleClick
    '    Dim ht As New Hashtable
    '    lvSModule.Items.Clear()
    '    If lvRoles.SelectedItems.Count > 0 Then
    '        Dim SelectedModule As String
    '        SelectedModule = lvRoles.SelectedItems(0).SubItems(0).Text
    '        objSubModule.fnGetCheckedItem(SelectedModule)
    '        If objSubModule.fnGetSubModule(SelectedModule) Then
    '            ' lvSModule.Items.Clear()
    '            'Me.Label2.Text = objSubModule.ModuleTable.Rows(1).Item(1)
    '            'Me.Label3.Text = objSubModule.MTable.Rows(1).Item(0)
    '            Dim intCounter As Integer = 0
    '            Dim intCounter1 As Integer = objSubModule.ModuleTable.Rows.Count
    '            While intCounter < intCounter1
    '                Dim lvItem As ListViewItem
    '                'If intCounter > 0 Then
    '                'If ht.ContainsValue(objSubModule.ModuleTable.Rows(intCounter).Item(1)) = True Then
    '                'Else
    '                lvItem = lvSModule.Items.Add(objSubModule.ModuleTable.Rows(intCounter).Item(1))
    '                Dim intcou As Integer = 0
    '                Dim intcou1 As Integer = objSubModule.MTable.Rows.Count
    '                While intcou < intcou1
    '                    If objSubModule.ModuleTable.Rows(intCounter).Item(1) = objSubModule.MTable.Rows(intcou).Item(0) Then
    '                        lvSModule.Items(intCounter).Checked = True
    '                    End If
    '                    intcou += 1
    '                End While
    '                ' End If
    '                ' ht.Add(intCounter, objSubModule.ModuleTable.Rows(intCounter).Item(1))

    '                'Else
    '                '    lvItem = lvSModule.Items.Add(objSubModule.ModuleTable.Rows(intCounter).Item(1))
    '                '    Dim intcou11 As Integer = 0
    '                '    Dim intcou12 As Integer = objSubModule.MTable.Rows.Count
    '                '    While intcou11 < intcou12
    '                '        If objSubModule.ModuleTable.Rows(intCounter).Item(1) = objSubModule.MTable.Rows(intcou11).Item(0) Then
    '                '            lvSModule.Items(intCounter).Checked = True
    '                '        End If
    '                '        intcou11 += 1
    '                '    End While
    '                '    ht.Add(intCounter, objSubModule.ModuleTable.Rows(intCounter).Item(1))
    '                ' End If
    '                intCounter += 1
    '            End While
    '        End If


    '    End If
    'End Sub
End Class
