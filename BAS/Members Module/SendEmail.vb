
Imports System.IO
Imports System.Net.Mail
Imports System.Collections.Generic


Public Class SendEmail

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
            For Each Attachment As String In Attachments
                Email.Attachments.Add(New Attachment(Attachment))
            Next
            Email.From = New MailAddress(FromAddress)
            For Each Recipient As String In Recipients
                Email.To.Add(Recipient)
            Next
            Email.Subject = Subject
            Email.Body = Body
            SMTPServer.Host = Server
            SMTPServer.Port = Port
            SMTPServer.Credentials = New System.Net.NetworkCredential(UserName, Password)
            SMTPServer.EnableSsl = True
            SMTPServer.Send(Email)
            Email.Dispose()
            Return "Email to " & Recipients(0) & " from " & FromAddress & " was sent."
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
        Dim Recipients As New List(Of String)
        Recipients.Add("Support@coherent.co.in")
        Dim FromEmailAddress As String = Recipients(0)
        Dim Subject As String = "Test From VB."
        Dim Body As String = "email body text, if you are reading this from your gmail account, the program worked."
        Dim UserName As String = "Teamcoherent"
        Dim Password As String = "*coherent123"
        Dim Port As Integer = 587
        Dim Server As String = "smtp.gmail.com"
        Dim Attachments As New List(Of String)
        MsgBox(SendEmail(Recipients, FromEmailAddress, Subject, Body, UserName, Password, Server, Port, Attachments))
    End Sub

End Class