Imports System.IO
Imports System.Net.Mail
Imports System.Collections.Generic
Imports System.Configuration
Public Class frmMemberEmail
#Region "Form Global Variables"
    Dim objMember As New clsMember
    Dim dvMembers As DataView
    Public strMemberNo As String
    Dim strFilter As String = "Name like '%'"
    Dim status As Boolean = False
    Dim ProgressBar1_max As Integer = 0
    Dim ListLoadStatus As Boolean = True
    Dim MemberInsertConfirm As Boolean = False
#End Region


    Private Sub frmMemberAddressPrinting_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Load_lvAllMembers()
        ListLoadStatus = True
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
#Region "Functions"
    'to load members from database

    Function fnLoadMembers()
        lvAllMembers.Items.Clear()
        Dim intCounter As Integer = 0
        Dim lvItem As New ListViewItem
        If Not dvMembers Is Nothing Then
            lvAllMembers.Refresh()
            ProgressBar1.Maximum = dvMembers.Count
            While intCounter < dvMembers.Count
                lvItem = lvAllMembers.Items.Add(dvMembers.Item(intCounter).Item("MemberNo"))
                'lvItem.UseItemStyleForSubItems = False
                lvItem.SubItems.Add(dvMembers.Item(intCounter).Item("Name"))
                lvItem.SubItems.Add(dvMembers.Item(intCounter).Item("emailid"))
                intCounter += 1
                ProgressBar1.Value += 1

            End While
        End If
        ProgressBar1.Value = 0
    End Function

#End Region

    Private Sub btnAddAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddAll.Click
        Dim intCounter As Integer = 0
        Dim lvItem As New ListViewItem
        lvSelectedMembers.Refresh()
        ProgressBar1_max = lvAllMembers.Items.Count
        ProgressBar1.Maximum = ProgressBar1_max
        'Start the BackgroundWorker.
        ' BackgroundWorker1.RunWorkerAsync()
        If lvAllMembers.Items.Count <> lvSelectedMembers.Items.Count Then
            For Each item As ListViewItem In lvAllMembers.Items
                For Each item1 As ListViewItem In lvSelectedMembers.Items
                    If (item1.Text = item.Text) Then
                        status = True
                        Exit For
                    Else
                        status = False
                    End If
                Next
                If status = False Then
                    lvSelectedMembers.Items.Add(DirectCast(item.Clone(), ListViewItem))
                    ProgressBar1.Value += 1

                    status = True
                End If
                status = False
            Next
            'BackgroundWorker1.CancelAsync()
            lblMessage.Text = Convert.ToString(lvSelectedMembers.Items.Count) + " Members added to list"
        End If
        ProgressBar1.Value = 0
    End Sub

    Private Sub btnRemoveAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRemoveAll.Click
        lvSelectedMembers.Items.Clear()
    End Sub

    Private Sub btnAddSelected_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddSelected.Click
        Dim lvItem As New ListViewItem


        For Each item As ListViewItem In lvAllMembers.SelectedItems
            For Each item1 As ListViewItem In lvSelectedMembers.Items
                If (item1.Text = item.Text) Then
                    status = True
                    Exit For
                Else
                    status = False
                End If
            Next
            If status = False Then
                lvSelectedMembers.Items.Add(DirectCast(item.Clone(), ListViewItem))
                status = True
            End If

            status = False
        Next
        lblMessage.Text = Convert.ToString(lvSelectedMembers.Items.Count) + " Members added to list"
    End Sub

    Private Sub btnRemoveSelected_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRemoveSelected.Click
        If lvSelectedMembers.SelectedItems.Count > 0 Then
            For Each item As ListViewItem In lvSelectedMembers.SelectedItems
                lvSelectedMembers.Items.Remove(item)
            Next
        Else
            MsgBox("Please select an account from selected members box", MsgBoxStyle.Exclamation, "Info")
        End If

    End Sub

    Private Sub BackgroundWorker1_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork

        For i As Integer = 1 To ProgressBar1_max
            ' Wait 100 milliseconds.
            Threading.Thread.Sleep(100)
            ' Report progress.
            BackgroundWorker1.ReportProgress(i)
        Next
    End Sub

    Private Sub BackgroundWorker1_ProgressChanged(ByVal sender As System.Object, ByVal e As System.ComponentModel.ProgressChangedEventArgs) Handles BackgroundWorker1.ProgressChanged
        ' Change the value of the ProgressBar to the BackgroundWorker progress.
        ProgressBar1.Value = e.ProgressPercentage
        ' Set the text.
        Me.Text = e.ProgressPercentage.ToString()
    End Sub

    Private Sub BackgroundWorker1_RunWorkerCompleted(ByVal sender As System.Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BackgroundWorker1.RunWorkerCompleted

    End Sub

    Private Sub rbAllMembers_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbAllMembers.CheckedChanged
        If rbAllMembers.Checked = True And ListLoadStatus = False Then
            Load_lvAllMembers()
        End If
    End Sub

    Private Sub rbActiveMembers_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbActiveMembers.CheckedChanged
        If rbActiveMembers.Checked = True Then
            If objMember.fnGetMembersTableForEmailActive Then

                dvMembers = New DataView(objMember.MemberTable, strFilter, "Name", DataViewRowState.OriginalRows)
                fnLoadMembers()
                ListLoadStatus = False
            End If
        End If
    End Sub

    Private Sub rbInActiveMembers_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbInActiveMembers.CheckedChanged
        If rbInActiveMembers.Checked = True Then
            If objMember.fnGetMembersTableForEmailInActive Then
                dvMembers = New DataView(objMember.MemberTable, strFilter, "Name", DataViewRowState.OriginalRows)
                fnLoadMembers()
                ListLoadStatus = False
            Else
                lvAllMembers.Items.Clear()
            End If

        End If
    End Sub
    Function Load_lvAllMembers()
        If objMember.fnGetMembersTableForEmailAll Then
            dvMembers = New DataView(objMember.MemberTable, strFilter, "Name", DataViewRowState.OriginalRows)
            fnLoadMembers()
        End If
    End Function


    Function InsertTblMemberLabelPrint()
        If lvSelectedMembers.Items.Count > 0 Then
            'Dim lvItem As New ListViewItem
            Dim copiedItems As ListView.ListViewItemCollection
            copiedItems = lvSelectedMembers.Items
            If objMember.fnDeleteMemberLabelPrint Then
                Dim i As Integer
                ProgressBar1.Maximum = copiedItems.Count
                For i = 0 To lvSelectedMembers.Items.Count - 1

                    Dim copy As String = Convert.ToString(copiedItems(i).Text)
                    objMember.fnInsertMemberLabelPrint(copy)
                    If ProgressBar1.Value < ProgressBar1.Maximum Then
                        ProgressBar1.Value += 1
                    End If
                Next
            Else
                MemberInsertConfirm = True
            End If
            ProgressBar1.Value = 0
        End If
    End Function

    Dim Attachments As New List(Of String)
    Function SendEmail(ByVal Recipients As List(Of String), _
                       ByVal FromAddress As String, _
                       ByVal Subject As String, _
                       ByVal Body As String, _
                       ByVal UserName As String, _
                       ByVal Password As String, _
                       Optional ByVal Server As String = "smtp.gmail.com", _
                       Optional ByVal Port As Integer = 587, _
                       Optional ByVal Attachments As List(Of String) = Nothing) As String
        Dim Email As New MailMessage()
        Try
            Dim SMTPServer As New SmtpClient

            For Each row As DataGridViewRow In dgvAttachment.Rows
                If row.Cells("colmFile").Value <> "" Then
                    Attachments.Add(row.Cells("colmFile").Value)
                End If
            Next

            For Each Attachment As String In Attachments
                Email.Attachments.Add(New Attachment(Attachment))
            Next
            Email.From = New MailAddress(FromAddress)
            Dim count As Integer = 0
            For Each Recipient As String In Recipients
                Try
                    Email.To.Add(Recipient)
                    count = count + 1

                Catch ex As Exception
                    Continue For
                End Try

            Next
            Email.Subject = Subject
            Email.Body = Body
            SMTPServer.Host = Server
            SMTPServer.Port = Port
            'SMTPServer.Credentials = New System.Net.NetworkCredential(UserName, Password)
            'SMTPServer.EnableSsl = True
            'SMTPServer.Send(Email)
            'Email.Dispose()
            lblMessage.Text = "Email send to " + Convert.ToString(count) + " Members"
            Return "Email  from " & FromAddress & " was sent."
        Catch ex As SmtpException
            Email.Dispose()
            Return "Sending Email Failed. Smtp Error."
        Catch ex As ArgumentOutOfRangeException
            Email.Dispose()
            Return "Sending Email Failed. Check Port Number."
        Catch Ex As InvalidOperationException
            Email.Dispose()
            Return "Sending Email Failed. Check Port Number."
        End Try
    End Function
    Private Sub BtnSend_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BtnSend.Click

        If fnCheck() Then
            Attachments.Clear()
            Dim Recipients As New List(Of String)
            For Each row As DataGridViewRow In dgvAttachment.Rows
                If row.Cells("colmFile").Value <> "OpenDialog1" Then
                    If row.Cells("colmFile").Value <> "" Then
                        Attachments.Add(row.Cells("colmFile").Value)
                    End If
                End If
            Next
            For Each row As ListViewItem In lvSelectedMembers.Items
                Dim test As String = row.SubItems(2).ToString()
                If row.SubItems(2).ToString() <> "" Then
                    Recipients.Add(row.SubItems(2).ToString())
                End If
            Next
            ' Recipients.Add("Support@coherent.co.in")
            Dim FromEmailAddress As String = System.Configuration.ConfigurationManager.AppSettings.Get("EmailID") 'Recipients(0)
            Dim Subject As String = txtSubject.Text
            Dim Body As String = txtBody.Text '"email body text, if you are reading this from your gmail account, the program worked."
            Dim UserName As String = System.Configuration.ConfigurationManager.AppSettings.Get("username")
            Dim Password As String = System.Configuration.ConfigurationManager.AppSettings.Get("password")
            Dim Port As Integer = 587
            Dim Server As String = "smtp.gmail.com"

            MsgBox(SendEmail(Recipients, FromEmailAddress, Subject, Body, UserName, Password, Server, Port, Attachments))
        End If

    End Sub



    Private Sub dgvAttachment_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvAttachment.CellClick

        If (e.ColumnIndex = 0 Or e.ColumnIndex = 1) Then
            Dim i As Integer
            Dim Status As String = "No"
            i = dgvAttachment.CurrentRow.Index
            If (dgvAttachment.Rows.Count - 1 <= dgvAttachment.CurrentRow.Index) Then
                dgvAttachment.Rows.Add()
            End If
            OpenFileDialog1.ShowDialog()
            Dim CurrentFileName As String = OpenFileDialog1.FileName.ToString()
            For Each row As DataGridViewRow In dgvAttachment.Rows
                Dim a As String = row.Cells("colmFile").Value

                If CurrentFileName = a Then
                    Status = "Yes"
                    Exit For
                End If
            Next

            If Status = "Yes" Then
                MsgBox("File Already Exist,Please Select Another file ", MsgBoxStyle.Exclamation)

                If (dgvAttachment.Rows.Count - 1 >= dgvAttachment.CurrentRow.Index) Then
                    If dgvAttachment.Item(1, dgvAttachment.Rows.Count - 2).Value = "" Then
                        dgvAttachment.Rows.RemoveAt(dgvAttachment.Rows.Count - 2)
                    End If

                End If


            Else
                If CurrentFileName.Contains(".exe") Then
                    MsgBox("Not allowed to attach this file type", MsgBoxStyle.Exclamation)
                    dgvAttachment.Rows.RemoveAt(i)
                Else
                    dgvAttachment.Item(1, i).Value = OpenFileDialog1.FileName.ToString()
                    CurrentFileName = "Nothing123"
                End If

            End If
        Else
            Dim i As Integer
            If e.ColumnIndex = 2 Then
                Try
                    i = dgvAttachment.CurrentRow.Index
                    dgvAttachment.Rows.RemoveAt(i)
                Catch ex As Exception

                End Try

            End If
        End If

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        dgvAttachment.Rows.Clear()
    End Sub

    Function fnCheck() As Boolean
        If lvSelectedMembers.Items.Count <= 0 Then
            MessageBox.Show("Please add Members...!")
            Return False
        ElseIf txtSubject.Text = "" Then
            MessageBox.Show("Please add subject...!")
            txtSubject.Focus()
            Return False
        ElseIf txtBody.Text = "" Then
            MessageBox.Show("Please write somthing in Email body...!")
            txtBody.Focus()
            Return False
        Else
            Return True
        End If
    End Function

    Private Sub dgvAttachment_DataError(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs)

    End Sub

End Class