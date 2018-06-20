Public Class Snooze
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
    Friend WithEvents NtyIconReminder As System.Windows.Forms.NotifyIcon
    Friend WithEvents timAdd As System.Windows.Forms.Timer
    Friend WithEvents timSnoozeDisplay As System.Windows.Forms.Timer
    Friend WithEvents CustomPanel1 As CSharpCustomPanelControl.CustomPanel
    Friend WithEvents txtCustomerName As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtTelephoneNo As System.Windows.Forms.TextBox
    Friend WithEvents lblSnoozeId As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents CmbMinutes As System.Windows.Forms.ComboBox
    Friend WithEvents lblRemainder As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents txtCustomerNotes As System.Windows.Forms.TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Snooze))
        Me.NtyIconReminder = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.timAdd = New System.Windows.Forms.Timer(Me.components)
        Me.timSnoozeDisplay = New System.Windows.Forms.Timer(Me.components)
        Me.CustomPanel1 = New CSharpCustomPanelControl.CustomPanel
        Me.txtCustomerName = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtTelephoneNo = New System.Windows.Forms.TextBox
        Me.lblSnoozeId = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.btnDelete = New System.Windows.Forms.Button
        Me.CmbMinutes = New System.Windows.Forms.ComboBox
        Me.lblRemainder = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.btnAdd = New System.Windows.Forms.Button
        Me.txtCustomerNotes = New System.Windows.Forms.TextBox
        Me.CustomPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'NtyIconReminder
        '
        Me.NtyIconReminder.Icon = CType(resources.GetObject("NtyIconReminder.Icon"), System.Drawing.Icon)
        Me.NtyIconReminder.Text = "Reminder"
        Me.NtyIconReminder.Visible = True
        '
        'timAdd
        '
        '
        'timSnoozeDisplay
        '
        Me.timSnoozeDisplay.Enabled = True
        '
        'CustomPanel1
        '
        Me.CustomPanel1.BackColor = System.Drawing.Color.White
        Me.CustomPanel1.BackColor2 = System.Drawing.Color.Empty
        Me.CustomPanel1.Controls.Add(Me.txtCustomerName)
        Me.CustomPanel1.Controls.Add(Me.Label2)
        Me.CustomPanel1.Controls.Add(Me.txtTelephoneNo)
        Me.CustomPanel1.Controls.Add(Me.lblSnoozeId)
        Me.CustomPanel1.Controls.Add(Me.Label3)
        Me.CustomPanel1.Controls.Add(Me.Label1)
        Me.CustomPanel1.Controls.Add(Me.btnDelete)
        Me.CustomPanel1.Controls.Add(Me.CmbMinutes)
        Me.CustomPanel1.Controls.Add(Me.lblRemainder)
        Me.CustomPanel1.Controls.Add(Me.Label4)
        Me.CustomPanel1.Controls.Add(Me.btnAdd)
        Me.CustomPanel1.Controls.Add(Me.txtCustomerNotes)
        Me.CustomPanel1.GradientMode = CSharpCustomPanelControl.LinearGradientMode.Vertical
        Me.CustomPanel1.Location = New System.Drawing.Point(0, 0)
        Me.CustomPanel1.Name = "CustomPanel1"
        Me.CustomPanel1.Size = New System.Drawing.Size(296, 272)
        Me.CustomPanel1.TabIndex = 0
        '
        'txtCustomerName
        '
        Me.txtCustomerName.BackColor = System.Drawing.Color.White
        Me.txtCustomerName.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCustomerName.Location = New System.Drawing.Point(152, 56)
        Me.txtCustomerName.Name = "txtCustomerName"
        Me.txtCustomerName.ReadOnly = True
        Me.txtCustomerName.Size = New System.Drawing.Size(128, 21)
        Me.txtCustomerName.TabIndex = 31
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(16, 152)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(128, 24)
        Me.Label2.TabIndex = 30
        Me.Label2.Text = "Notes"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtTelephoneNo
        '
        Me.txtTelephoneNo.BackColor = System.Drawing.Color.White
        Me.txtTelephoneNo.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTelephoneNo.Location = New System.Drawing.Point(152, 100)
        Me.txtTelephoneNo.Name = "txtTelephoneNo"
        Me.txtTelephoneNo.ReadOnly = True
        Me.txtTelephoneNo.Size = New System.Drawing.Size(128, 21)
        Me.txtTelephoneNo.TabIndex = 37
        '
        'lblSnoozeId
        '
        Me.lblSnoozeId.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSnoozeId.Location = New System.Drawing.Point(224, 232)
        Me.lblSnoozeId.Name = "lblSnoozeId"
        Me.lblSnoozeId.Size = New System.Drawing.Size(56, 24)
        Me.lblSnoozeId.TabIndex = 34
        Me.lblSnoozeId.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblSnoozeId.Visible = False
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Verdana", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(16, 16)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(216, 16)
        Me.Label3.TabIndex = 35
        Me.Label3.Text = "U Have A Reminder"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(16, 56)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(128, 24)
        Me.Label1.TabIndex = 29
        Me.Label1.Text = "CustomerName"
        '
        'btnDelete
        '
        Me.btnDelete.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.Location = New System.Drawing.Point(240, 16)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(40, 24)
        Me.btnDelete.TabIndex = 28
        Me.btnDelete.Text = "X"
        '
        'CmbMinutes
        '
        Me.CmbMinutes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbMinutes.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbMinutes.ItemHeight = 14
        Me.CmbMinutes.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "10", "15", "20", "25", "30", "35", "40", "50", "60", "90"})
        Me.CmbMinutes.Location = New System.Drawing.Point(152, 200)
        Me.CmbMinutes.Name = "CmbMinutes"
        Me.CmbMinutes.Size = New System.Drawing.Size(48, 22)
        Me.CmbMinutes.TabIndex = 27
        '
        'lblRemainder
        '
        Me.lblRemainder.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRemainder.Location = New System.Drawing.Point(16, 200)
        Me.lblRemainder.Name = "lblRemainder"
        Me.lblRemainder.Size = New System.Drawing.Size(136, 24)
        Me.lblRemainder.TabIndex = 26
        Me.lblRemainder.Text = "SnoozeAgain After"
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(16, 100)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(128, 24)
        Me.Label4.TabIndex = 36
        Me.Label4.Text = "Telephone No"
        '
        'btnAdd
        '
        Me.btnAdd.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.Location = New System.Drawing.Point(200, 200)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(48, 24)
        Me.btnAdd.TabIndex = 33
        Me.btnAdd.Text = "Ok"
        '
        'txtCustomerNotes
        '
        Me.txtCustomerNotes.BackColor = System.Drawing.Color.White
        Me.txtCustomerNotes.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCustomerNotes.Location = New System.Drawing.Point(152, 152)
        Me.txtCustomerNotes.Name = "txtCustomerNotes"
        Me.txtCustomerNotes.ReadOnly = True
        Me.txtCustomerNotes.Size = New System.Drawing.Size(128, 21)
        Me.txtCustomerNotes.TabIndex = 32
        '
        'Snooze
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.SystemColors.HighlightText
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(292, 273)
        Me.Controls.Add(Me.CustomPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Snooze"
        Me.Text = "Snooze"
        Me.CustomPanel1.ResumeLayout(False)
        Me.CustomPanel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region "Variables"
    'Dim objSnooze As New ClsSnooze

#End Region


    Private Sub Snooze_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        NtyIconReminder.Visible = True
        NtyIconReminder.Text = "sample"
    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        ' objSnooze.fnDeleteSnooze()
        timAdd.Start()
    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        timAdd.Start()
        Dim strEx As String
        '  objSnooze.CustomerName = txtCustomerName.Text
        ' objSnooze.Notes = txtCustomerNotes.Text
        '  strEx = strEx.Format(TimeOfDay.Now.AddMinutes(CmbMinutes.SelectedItem))
        ' objSnooze.SnoozeTime = strEx
        ' objSnooze.FnUpdateSnooze()
    End Sub

    Private Sub timSnoozeDisplay_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles timSnoozeDisplay.Tick
        'If objSnooze.fnGetSnooze = True Then
        'fnLoadData()
        Me.Top -= 10
        Me.Opacity += 0.05
        If Me.Top <= 527 Then
            timSnoozeDisplay.Stop()
        End If
        'End If
    End Sub

    Private Sub FrmSnoozeDisplay_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Resize
        Me.Top = 735
        Me.Left = 733
        Me.Opacity = 0
        timSnoozeDisplay.Start()
    End Sub

    Private Sub timAdd_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles timAdd.Tick
        Me.Top += 10
        Me.Opacity -= 0.05
        If Me.Top = 735 Then
            timAdd.Stop()
            Me.Close()
        End If
    End Sub

    Private Sub NtyIconReminder_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles NtyIconReminder.Click
        Me.BringToFront()
    End Sub

End Class
