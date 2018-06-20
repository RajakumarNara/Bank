<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmNotifyFdMature
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmNotifyFdMature))
        Me.btnFDClosure = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.TimeReminderDisplay = New System.Windows.Forms.Timer(Me.components)
        Me.Label2 = New System.Windows.Forms.Label
        Me.NumericUpDown1 = New System.Windows.Forms.NumericUpDown
        Me.btnOk = New System.Windows.Forms.Button
        Me.lvFdReminder = New System.Windows.Forms.ListView
        Me.ColumnHeader1 = New System.Windows.Forms.ColumnHeader
        Me.TimeAdd = New System.Windows.Forms.Timer(Me.components)
        Me.NotifyIconReminder = New System.Windows.Forms.NotifyIcon(Me.components)
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnFDClosure
        '
        Me.btnFDClosure.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFDClosure.Location = New System.Drawing.Point(38, 229)
        Me.btnFDClosure.Name = "btnFDClosure"
        Me.btnFDClosure.Size = New System.Drawing.Size(163, 23)
        Me.btnFDClosure.TabIndex = 0
        Me.btnFDClosure.Text = "Click to Close Matured FD"
        Me.btnFDClosure.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(76, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(101, 23)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Reminder"
        '
        'TimeReminderDisplay
        '
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 270)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(114, 14)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Remind Me after:"
        '
        'NumericUpDown1
        '
        Me.NumericUpDown1.Location = New System.Drawing.Point(126, 268)
        Me.NumericUpDown1.Maximum = New Decimal(New Integer() {10, 0, 0, 0})
        Me.NumericUpDown1.Name = "NumericUpDown1"
        Me.NumericUpDown1.Size = New System.Drawing.Size(56, 20)
        Me.NumericUpDown1.TabIndex = 4
        Me.NumericUpDown1.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'btnOk
        '
        Me.btnOk.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOk.Location = New System.Drawing.Point(188, 266)
        Me.btnOk.Name = "btnOk"
        Me.btnOk.Size = New System.Drawing.Size(45, 23)
        Me.btnOk.TabIndex = 5
        Me.btnOk.Text = "OK"
        Me.btnOk.UseVisualStyleBackColor = True
        '
        'lvFdReminder
        '
        Me.lvFdReminder.AllowColumnReorder = True
        Me.lvFdReminder.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lvFdReminder.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lvFdReminder.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1})
        Me.lvFdReminder.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvFdReminder.FullRowSelect = True
        Me.lvFdReminder.GridLines = True
        Me.lvFdReminder.HideSelection = False
        Me.lvFdReminder.Location = New System.Drawing.Point(38, 45)
        Me.lvFdReminder.MultiSelect = False
        Me.lvFdReminder.Name = "lvFdReminder"
        Me.lvFdReminder.Size = New System.Drawing.Size(167, 178)
        Me.lvFdReminder.Sorting = System.Windows.Forms.SortOrder.Ascending
        Me.lvFdReminder.TabIndex = 6
        Me.lvFdReminder.UseCompatibleStateImageBehavior = False
        Me.lvFdReminder.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Account No"
        Me.ColumnHeader1.Width = 154
        '
        'NotifyIconReminder
        '
        Me.NotifyIconReminder.Icon = CType(resources.GetObject("NotifyIconReminder.Icon"), System.Drawing.Icon)
        Me.NotifyIconReminder.Text = "FD Reminder"
        Me.NotifyIconReminder.Visible = True
        '
        'frmNotifyFdMature
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(245, 308)
        Me.Controls.Add(Me.lvFdReminder)
        Me.Controls.Add(Me.btnOk)
        Me.Controls.Add(Me.NumericUpDown1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnFDClosure)
        Me.Name = "frmNotifyFdMature"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Notify Fd Mature"
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnFDClosure As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TimeReminderDisplay As System.Windows.Forms.Timer
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents NumericUpDown1 As System.Windows.Forms.NumericUpDown
    Friend WithEvents btnOk As System.Windows.Forms.Button
    Friend WithEvents lvFdReminder As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents TimeAdd As System.Windows.Forms.Timer
    Friend WithEvents NotifyIconReminder As System.Windows.Forms.NotifyIcon
End Class
