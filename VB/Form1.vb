Imports MailKit.Net.Smtp
Imports MailKit.Security
Imports MimeKit
Imports System
Imports System.IO
Imports System.Threading.Tasks

Namespace SendReportWithMailKit
    Partial Public Class Form1
        Inherits DevExpress.XtraEditors.XtraForm

        Public Sub New()
            Me.InitializeComponent()
        End Sub

        Private Shared Function CreateMimeMessage(ByVal stream As MemoryStream) As MimeMessage
            ' Instantiate a report. 
            ' Email export options are already specified at design time.                
            Dim report As XtraReport1 = New XtraReport1()
            Dim message = New MimeMessage()
            message.From.Add(New MailboxAddress("Someone", "someone@somewhere.com"))
            message.To.Add(New MailboxAddress(report.ExportOptions.Email.RecipientName, report.ExportOptions.Email.RecipientAddress))
            message.Subject = report.ExportOptions.Email.Subject
            Dim builder = New BodyBuilder()
            builder.TextBody = "This is a test e-mail message sent by an application."
            ' Create a new attachment and add the PDF document.
            report.ExportToPdf(stream)
            stream.Seek(0, SeekOrigin.Begin)
            builder.Attachments.Add("TestReport.pdf", stream.ToArray(), New ContentType("application", "pdf"))
            message.Body = builder.ToMessageBody()
            Return message
        End Function

        Private Async Sub btnSend_Click(ByVal sender As Object, ByVal e As EventArgs)
            Dim SmtpHost As String = Me.edtHost.EditValue.ToString()
            Dim SmtpPort As Integer = Integer.Parse(Me.edtPort.EditValue.ToString())
            Dim SmtpUserName As String = Me.edtUsername.EditValue.ToString()
            Dim SmtpUserPassword As String = Me.edtPassword.EditValue.ToString()
            Me.lblProgress.Text = "Sending mail..."
            Me.lblProgress.Text = Await SendAsync(SmtpHost, SmtpPort, SmtpUserName, SmtpUserPassword)
        End Sub

        Private Shared Async Function SendAsync(ByVal smtpHost As String, ByVal smtpPort As Integer, ByVal userName As String, ByVal password As String) As Task(Of String)
            Dim result = "OK"
            ' Create a new memory stream and export the report in PDF.
            Using stream As MemoryStream = New MemoryStream()

                Using mail = CreateMimeMessage(stream)

                    Using client = New SmtpClient()

                        Try
                            client.Connect(smtpHost, smtpPort, SecureSocketOptions.StartTls)
                            client.Authenticate(userName, password)
                            Await client.SendAsync(mail)
                        Catch ex As Exception
                            result = ex.Message
                        End Try

                        client.Disconnect(True)
                    End Using
                End Using
            End Using

            Return result
        End Function
    End Class
End Namespace
