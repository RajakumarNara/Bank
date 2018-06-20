Public Class frmDBbackup
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
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnClose As BankControls.NewButton
    Friend WithEvents btnBackUp As BankControls.NewButton
    Friend WithEvents btnOpen As BankControls.NewButton
    Friend WithEvents txtPath As BankControls.TextControl
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents txtChangefile As System.Windows.Forms.TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDBbackup))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.txtChangefile = New System.Windows.Forms.TextBox
        Me.btnClose = New BankControls.NewButton
        Me.btnBackUp = New BankControls.NewButton
        Me.btnOpen = New BankControls.NewButton
        Me.txtPath = New BankControls.TextControl
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(252, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.GroupBox1.Controls.Add(Me.txtChangefile)
        Me.GroupBox1.Controls.Add(Me.btnClose)
        Me.GroupBox1.Controls.Add(Me.btnBackUp)
        Me.GroupBox1.Controls.Add(Me.btnOpen)
        Me.GroupBox1.Controls.Add(Me.txtPath)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox1.Location = New System.Drawing.Point(8, 40)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(376, 136)
        Me.GroupBox1.TabIndex = 17
        Me.GroupBox1.TabStop = False
        '
        'txtChangefile
        '
        Me.txtChangefile.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtChangefile.Location = New System.Drawing.Point(16, 32)
        Me.txtChangefile.MaxLength = 200
        Me.txtChangefile.Name = "txtChangefile"
        Me.txtChangefile.Size = New System.Drawing.Size(256, 23)
        Me.txtChangefile.TabIndex = 139
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(252, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.btnClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnClose.Font = New System.Drawing.Font("Verdana", 9.75!)
        Me.btnClose.GotFocusColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnClose.Image = CType(resources.GetObject("btnClose.Image"), System.Drawing.Image)
        Me.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnClose.Location = New System.Drawing.Point(182, 79)
        Me.btnClose.LostFocusColour = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(252, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(80, 32)
        Me.btnClose.TabIndex = 21
        Me.btnClose.Text = "&Close"
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'btnBackUp
        '
        Me.btnBackUp.BackColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(252, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.btnBackUp.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBackUp.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnBackUp.Font = New System.Drawing.Font("Verdana", 9.75!)
        Me.btnBackUp.GotFocusColour = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.btnBackUp.Image = CType(resources.GetObject("btnBackUp.Image"), System.Drawing.Image)
        Me.btnBackUp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBackUp.Location = New System.Drawing.Point(62, 79)
        Me.btnBackUp.LostFocusColour = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(252, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.btnBackUp.Name = "btnBackUp"
        Me.btnBackUp.Size = New System.Drawing.Size(88, 32)
        Me.btnBackUp.TabIndex = 20
        Me.btnBackUp.Text = "&BackUp"
        Me.btnBackUp.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnBackUp.UseVisualStyleBackColor = False
        '
        'btnOpen
        '
        Me.btnOpen.BackColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(252, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.btnOpen.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnOpen.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnOpen.Font = New System.Drawing.Font("Verdana", 9.75!)
        Me.btnOpen.GotFocusColour = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.btnOpen.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnOpen.Location = New System.Drawing.Point(272, 32)
        Me.btnOpen.LostFocusColour = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(252, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.btnOpen.Name = "btnOpen"
        Me.btnOpen.Size = New System.Drawing.Size(80, 24)
        Me.btnOpen.TabIndex = 19
        Me.btnOpen.Text = "Browse"
        Me.btnOpen.UseVisualStyleBackColor = False
        '
        'txtPath
        '
        Me.txtPath.AlphaNumeric = False
        Me.txtPath.BlankSpace = False
        Me.txtPath.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPath.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtPath.Location = New System.Drawing.Point(16, 32)
        Me.txtPath.LostFocusColour = System.Drawing.Color.Empty
        Me.txtPath.Mandatory = False
        Me.txtPath.Name = "txtPath"
        Me.txtPath.Size = New System.Drawing.Size(256, 24)
        Me.txtPath.SpecialChar = False
        Me.txtPath.TabIndex = 18
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(252, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(24, 95)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 16)
        Me.Label1.TabIndex = 138
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Georgia", 14.25!, System.Drawing.FontStyle.Underline)
        Me.Label5.ForeColor = System.Drawing.Color.Green
        Me.Label5.Location = New System.Drawing.Point(8, 8)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(160, 23)
        Me.Label5.TabIndex = 139
        Me.Label5.Text = "Database BackUp"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(252, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.Label2.Font = New System.Drawing.Font("Verdana", 9.75!)
        Me.Label2.ForeColor = System.Drawing.Color.Red
        Me.Label2.Location = New System.Drawing.Point(56, 184)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(270, 16)
        Me.Label2.TabIndex = 140
        Me.Label2.Text = "Note:  Dont save target file on desktop"
        '
        'Timer1
        '
        Me.Timer1.Interval = 500
        '
        'frmDBbackup
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(252, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(408, 213)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmDBbackup"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "DataBase Backup"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

#Region "Varibles"
    Public BackupPath As String
    Dim tempBool As Boolean
    Dim tmestr As String
    Dim dummyName As String
    'tmestr = txtFilename.Text & year & month & day & hour & minute & ms & ".sql"
   
#End Region


    Private Sub btnOpen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOpen.Click
        Dim backupTime As String = Format(DateAndTime.Now, "yyyy-MM-dd-hhmmss")
        'Dim year As Integer = backupTime.Year
        'Dim month As Integer = backupTime.Month.ToString()
        'Dim day As Integer = backupTime.Day
        'Dim hour As Integer = backupTime.Hour
        'Dim minute As Integer = backupTime.Minute
        'Dim second As Integer = backupTime.Second
        'Dim ms As Integer = backupTime.Millisecond
        Dim tmestr As String
        tmestr = "BackAson_" & backupTime & ".sql"
        dummyName = "BackAson_" & backupTime & ".CT"
        Try
            Dim backup As New FolderBrowserDialog
            If backup.ShowDialog() = DialogResult.OK Then

                txtPath.Text = backup.SelectedPath()
            End If
            If Not txtPath.Text = "" Then
                If Len(txtPath.Text) = 3 Then
                    txtChangefile.Text = txtPath.Text & dummyName
                    txtPath.Text = txtPath.Text & tmestr
                    BackupPath = txtPath.Text
                Else
                    txtChangefile.Text = txtPath.Text & "\" & dummyName
                    txtPath.Text = txtPath.Text & "\" & tmestr
                    BackupPath = txtPath.Text
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnBackUp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBackUp.Click
        ' Dim batchFileName As String = ""
        ' Dim argumentsToBatchFile() As String = {"cha", "testingg", BackupPath}
        ' Dim argumentsString As String = String.Empty

        If txtPath.Text = "" Then
            MessageBox.Show("Please enter path")
        Else
            If MsgBox("Database file will be saved at " & txtChangefile.Text & " " & Chr(10) & "Do you want to continue ?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirm Addition") = MsgBoxResult.Yes Then
                ' Dim batchFileName As String = Application.StartupPath & "D:/Projects/Windows_Projects/12Oct2011/BAS/BatchFiles/MySqlBackup.bat" ' "MySqlBackup.bat"
                Dim batchFileName As String = Application.StartupPath & "/../BatchFiles/MySqlBackup.bat" ' "MySqlBackup.bat"

                'Sending parameters to .bat file { Password , Databasename , FilePathandNae  }
                ' Dim argumentsToBatchFile As String() = {"coherent123", "cooperativebankdb", BackupPath}
                Dim argumentsToBatchFile As String() = {"coherent123", "cooperativebankdb", BackupPath}
                Dim argumentsString As String = String.Empty
                Try
                    'Add up all arguments as string with space separator between the arguments
                    If argumentsToBatchFile.Length <> 0 Then
                        Dim count As Integer = 0
                        While count < argumentsToBatchFile.Length
                            argumentsString += " "
                            'argumentsString += "\"";
                            argumentsString += argumentsToBatchFile(count)
                            System.Math.Max(System.Threading.Interlocked.Increment(count), count - 1)
                        End While
                    End If

                    'Create process start information
                    Dim DBProcessStartInfo As New System.Diagnostics.ProcessStartInfo(batchFileName, argumentsString)

                    'Redirect the output to standard window
                    DBProcessStartInfo.RedirectStandardOutput = True

                    'The output display window need not be falshed onto the front.
                    DBProcessStartInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden
                    'DBProcessStartInfo.WindowStyle = DBProcessStartInfo.WindowStyle.Hidden
                    DBProcessStartInfo.UseShellExecute = False

                    'Create the process and run it
                    Dim dbProcess As System.Diagnostics.Process
                    dbProcess = System.Diagnostics.Process.Start(DBProcessStartInfo)


                    'Catch the output text from the console so that if error happens, the output text can be logged.
                    Dim standardOutput As System.IO.StreamReader = dbProcess.StandardOutput

                    ' Wait as long as the DB Backup or Restore or Repair is going on. 
                    '                Ping once in every 2 seconds to check whether process is completed. 

                    While Not dbProcess.HasExited
                        dbProcess.WaitForExit(2000)
                    End While

                    If dbProcess.HasExited Then
                        'TODO - log consoleOutputText to the log file.

                        Dim consoleOutputText As String = standardOutput.ReadToEnd()
                    End If
                    'txtPath.Text = ""
                    'MsgBox("BackUp done successfuly")

                    'return true;
                    'txtFileName.Text = ""

                    Dim fc As System.IO.File

                    Try

                        fc.Copy(txtPath.Text, txtChangefile.Text, True)
                        fc.Delete(txtPath.Text)
                        MsgBox("Backup of data completed successfully." & Chr(13) & "Backup file is available in " & txtChangefile.Text & Chr(13) & Chr(13) & "Thank you for using backup system.", MsgBoxStyle.Information)

                    Catch ex As Exception
                        MsgBox(ex.Message)
                    End Try

                    txtPath.Text = ""

                    'return true;

                    txtChangefile.Text = ""
                Catch
                    ' Catch the exception and throw the customized exception made out of that

                    MessageBox.Show("Disk full or other IO error , unable to backup!")

                End Try
            End If

        End If
    End Sub
    Private Sub Timer1_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        If tempBool = False Then
            Label2.Text = ""
            tempBool = True
        Else
            Label2.Text = "Note:  Dont Save Target File in Desktop"
            tempBool = False
        End If
    End Sub
    Private Sub frmDBbackuo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Timer1.Start()
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
End Class
