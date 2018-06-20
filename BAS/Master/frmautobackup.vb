Imports System.IO
Imports System.Data.Odbc
Imports System.ComponentModel
Public Class frmautobackup

    Dim strMySQL, myChk, selectQuery As String
    Dim dtseCt As Integer
    Dim i As Integer = 25


#Region "variables"
    Public BackupPath As String
    Dim tempBool As Boolean
    Dim tmestr As String
    Dim dummyName As String
    Dim bw As BackgroundWorker = New BackgroundWorker

    Shared prog As Integer

#End Region
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        bw.WorkerSupportsCancellation = True
        bw.WorkerReportsProgress = True
        getDatabase()
        Timer1.Start()
        AddHandler bw.DoWork, AddressOf BackgroundWorker1_DoWork
        ''AddHandler bw.ReportProgress, AddressOf BackgroundWorker1_ProgressChanged
        Me.CheckForIllegalCrossThreadCalls = False
    End Sub

    Private Sub getDatabase()
        'Declaration
        Dim conOdbc As New OdbcConnection
        Dim dt As New DataTable

        'Connection String
        myChk = ""
        myChk = MySQLNoDatabaseCon()

        'Open Odbc Connection
        conOdbc = New OdbcConnection(myChk)
        conOdbc.Close()
        conOdbc.Open()

        selectQuery = "SELECT DISTINCT TABLE_SCHEMA FROM information_schema.TABLES "
        Dim odbcAdptr As New OdbcDataAdapter(selectQuery, conOdbc)
        odbcAdptr.Fill(dt)

        dtseCt = 0
        cmbDatabase.Items.Clear()
        cmbDatabase.Items.Add("---Select---")
        While dtseCt < dt.Rows.Count
            cmbDatabase.Items.Add(dt.Rows(dtseCt)(0).ToString())
            dtseCt = dtseCt + 1
        End While
        cmbDatabase.SelectedIndex = 0
    End Sub


    Private Sub gettingPath()
        'Getting MySQL Path
        'Declaration
        Dim conOdbc As New OdbcConnection
        Dim dt As New DataTable
        Dim len As Integer
        Dim tempWorkPath As String = ""

        Try
            'Connection String
            myChk = MySQLNoDatabaseCon()

            'Open Odbc Connection
            conOdbc = New OdbcConnection(myChk)
            conOdbc.Close()
            conOdbc.Open()

            selectQuery = "select @@datadir"
            Dim odbcAdptr As New OdbcDataAdapter(selectQuery, conOdbc)
            odbcAdptr.Fill(dt)

            tempWorkPath = dt.Rows(0)(0).ToString()
            len = tempWorkPath.Length() - 5
            txtWorkingDirectoryPath.Text = tempWorkPath.Substring(0, len) + "bin"

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Function MySQLNoDatabaseCon()
        strMySQL = ""
        strMySQL = "Driver={MySQL ODBC 3.51 Driver};option=0;port=3306;server=localhost;uid=root;password=coherent123"
        Return strMySQL
    End Function
    Function fnBackupCheck() As Boolean
        If cmbDatabase.SelectedIndex = 0 Then
            MessageBox.Show("Please Select Database")
            cmbDatabase.Focus()
            Return False
        End If
        If txtExpImpPath.Text = String.Empty Then
            MessageBox.Show("Please Select Path")
            btnBrowse.Focus()
            Return False
        End If
        Return True
    End Function
    Function fnRestoreCheck() As Boolean
        If cmbDatabase.SelectedIndex = 0 Then
            MessageBox.Show("Please Select Database")
            cmbDatabase.Focus()
            Return False
        Else
            Return True
        End If

    End Function

    Private Sub btnBackup_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBackup.Click
        Try
            Label3.Text = "Back Up Path"
            If (fnBackupCheck()) Then
                Label7.Visible = True

                'Getting Path
                gettingPath()

                'Save Dialog Box
                'sfd.Filter = "SQL Files |.sql"
                'sfd.DefaultExt = ".sql"
                'DialogResult = sfd.ShowDialog()
                'If DialogResult = Windows.Forms.DialogResult.Cancel Then
                '    MessageBox.Show("Backup Creation Failed")
                '    Exit Sub
                'End If
                'txtExpImpPath.Text = sfd.FileName

                'Getting Drives in System
                Dim drives As String() = Environment.GetLogicalDrives()
                Dim drive As String = drives(1) + "Temp.sql"


                'Do Events
                Application.DoEvents()

                'Processing

                Dim myProcess As New Process()
                myProcess.StartInfo.FileName = "cmd.exe"
                myProcess.StartInfo.UseShellExecute = False
                myProcess.StartInfo.WorkingDirectory = txtWorkingDirectoryPath.Text
                myProcess.StartInfo.RedirectStandardInput = True
                myProcess.StartInfo.RedirectStandardOutput = True
                myProcess.StartInfo.CreateNoWindow = True
                myProcess.Start()
                bw.RunWorkerAsync()

                Dim myStreamWriter As StreamWriter = myProcess.StandardInput
                Dim mystreamreader As StreamReader = myProcess.StandardOutput
                myStreamWriter.WriteLine("mysqldump --routines -u root --password=coherent123 " + cmbDatabase.Text + ">" + drive + "")
                myStreamWriter.Close()
                myProcess.WaitForExit()
                bw.CancelAsync()
                prog = 100
                myProcess.Close()
                'Copying File from user selected path to System Created Path
                File.Move(drive, txtExpImpPath.Text)
                Label7.Visible = False
                MessageBox.Show("Backup Created Successfully")
                prog = 0
                Me.Close()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        End Try

    End Sub

    Private Sub btnRestore_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRestore.Click
        Try
            Label3.Text = "Restore Path"
            If (fnRestoreCheck()) Then
                gettingPath()
                Label7.Visible = True
                'open Dialog Box
                Ofd.Filter = "Coherent File|.CT"
                Ofd.FileName = "*.CT"
                DialogResult = Ofd.ShowDialog()
                If DialogResult = Windows.Forms.DialogResult.Cancel Then
                    MessageBox.Show("Restore Failed")
                    Exit Sub
                End If
                txtExpImpPath.Text = Ofd.FileName

                'Getting Drives in System
                Dim drives As String() = Environment.GetLogicalDrives()
                Dim drive As String = txtExpImpPath.Text '+ "Temp.sql"

                'Do Events
                Application.DoEvents()

                'Processing

                Dim myProcess As New Process()
                myProcess.StartInfo.FileName = "cmd.exe"
                myProcess.StartInfo.UseShellExecute = False
                myProcess.StartInfo.WorkingDirectory = txtWorkingDirectoryPath.Text
                myProcess.StartInfo.RedirectStandardInput = True
                myProcess.StartInfo.RedirectStandardOutput = True
                myProcess.StartInfo.CreateNoWindow = True
                myProcess.Start()
                bw.RunWorkerAsync()
                Dim myStreamWriter As StreamWriter = myProcess.StandardInput
                Dim mystreamreader As StreamReader = myProcess.StandardOutput
                myStreamWriter.WriteLine("mysql -u root --password=coherent123 " + cmbDatabase.Text + "<" + drive + "")
                myStreamWriter.Close()
                myProcess.WaitForExit()
                bw.CancelAsync()
                prog = 100
                myProcess.Close()
                'Copying File from user selected path to System Created Path
                Label7.Visible = False
                MessageBox.Show("Database Restore Successfully")
                prog = 0
                Me.Close()
            End If
        Catch ex As Exception
            MessageBox.Show("Database Restore Failed")
        End Try
    End Sub

    Private Sub btnBrowse_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBrowse.Click
        Dim backupTime As String = Format(DateAndTime.Now, "yyyy-MM-dd-hhmmss")
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
                    txtExpImpPath.Text = txtPath.Text & dummyName
                    txtPath.Text = txtPath.Text & tmestr
                    BackupPath = txtPath.Text
                Else
                    txtExpImpPath.Text = txtPath.Text & "\" & dummyName
                    txtPath.Text = txtPath.Text & "\" & tmestr
                    BackupPath = txtPath.Text
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        If tempBool = False Then
            Label4.Text = ""
            tempBool = True
        Else
            Label4.Text = "Note:  Dont Save Target File in Desktop"
            tempBool = False
        End If
    End Sub

    Private Sub BackgroundWorker1_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork
        Try
            Do Until i = 100
                If prog <> 100 Then
                    If BackgroundWorker1.CancellationPending = True Then
                        ProgressTo100()
                        Exit Sub
                    End If
                    i = i + 1
                    BackgroundWorker1.ReportProgress(i)
                    System.Threading.Thread.Sleep(1000)
                Else
                    ProgressTo100()
                    Exit Sub
                End If
            Loop

        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        End Try
    End Sub

    Private Sub BackgroundWorker1_ProgressChanged(ByVal sender As System.Object, ByVal e As System.ComponentModel.ProgressChangedEventArgs) Handles BackgroundWorker1.ProgressChanged
        ProgressBar1.Value = e.ProgressPercentage
    End Sub
    Sub ProgressTo100()
        ProgressBar1.Value = 100
    End Sub

End Class