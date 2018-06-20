<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRelation
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
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.btnCancel = New System.Windows.Forms.Button
        Me.lvRelation = New System.Windows.Forms.ListView
        Me.CasteCode = New System.Windows.Forms.ColumnHeader
        Me.CasteName = New System.Windows.Forms.ColumnHeader
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtRelationName = New System.Windows.Forms.TextBox
        Me.txtRelationCode = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.btnSave = New System.Windows.Forms.Button
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.btnCancel)
        Me.Panel1.Controls.Add(Me.lvRelation)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.txtRelationName)
        Me.Panel1.Controls.Add(Me.txtRelationCode)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.btnSave)
        Me.Panel1.Location = New System.Drawing.Point(8, 8)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(424, 384)
        Me.Panel1.TabIndex = 22
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
        'lvRelation
        '
        Me.lvRelation.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.CasteCode, Me.CasteName})
        Me.lvRelation.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvRelation.FullRowSelect = True
        Me.lvRelation.GridLines = True
        Me.lvRelation.Location = New System.Drawing.Point(8, 152)
        Me.lvRelation.Name = "lvRelation"
        Me.lvRelation.Size = New System.Drawing.Size(408, 216)
        Me.lvRelation.TabIndex = 4
        Me.lvRelation.UseCompatibleStateImageBehavior = False
        Me.lvRelation.View = System.Windows.Forms.View.Details
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
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(12, 25)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(114, 16)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Relation Code  :"
        '
        'txtRelationName
        '
        Me.txtRelationName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtRelationName.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRelationName.Location = New System.Drawing.Point(136, 60)
        Me.txtRelationName.MaxLength = 50
        Me.txtRelationName.Name = "txtRelationName"
        Me.txtRelationName.Size = New System.Drawing.Size(144, 23)
        Me.txtRelationName.TabIndex = 1
        '
        'txtRelationCode
        '
        Me.txtRelationCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtRelationCode.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRelationCode.Location = New System.Drawing.Point(136, 25)
        Me.txtRelationCode.Name = "txtRelationCode"
        Me.txtRelationCode.Size = New System.Drawing.Size(72, 23)
        Me.txtRelationCode.TabIndex = 0
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(12, 60)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(71, 16)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "Relation :"
        '
        'btnSave
        '
        Me.btnSave.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.Location = New System.Drawing.Point(192, 120)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(72, 24)
        Me.btnSave.TabIndex = 3
        Me.btnSave.Text = "&Save"
        '
        'frmRelation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(440, 397)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "frmRelation"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Relation master"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents lvRelation As System.Windows.Forms.ListView
    Friend WithEvents CasteCode As System.Windows.Forms.ColumnHeader
    Friend WithEvents CasteName As System.Windows.Forms.ColumnHeader
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtRelationName As System.Windows.Forms.TextBox
    Friend WithEvents txtRelationCode As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents btnSave As System.Windows.Forms.Button
End Class
