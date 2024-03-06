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
            Me.edtHost.EditValue = "localhost"
            Me.edtPort.EditValue = 25
        End Sub
        Private Function CreateMimeMessage(ByVal stream As MemoryStream) As MimeMessage
            If CBool(Me.radioGroup1.EditValue) Then
                Return CreateMimeMessageExportToMail(stream)
            Else
                Return CreateMimeMessageExportToPdf(stream)
            End If
        End Function

        Private Shared Function CreateMimeMessageExportToPdf(ByVal stream As MemoryStream) As MimeMessage
            ' Instantiate a report. 
            ' Email export options are already specified at design time.                
            Dim report As New XtraReport1()

            Dim message = New MimeMessage()
            message.From.Add(New MailboxAddress("Someone", "someone@test.com"))
            message.To.Add(New MailboxAddress(report.ExportOptions.Email.RecipientName, report.ExportOptions.Email.RecipientAddress))
            message.Subject = report.ExportOptions.Email.Subject
            Dim builder = New BodyBuilder()
            builder.TextBody = "This is a test e-mail message sent by an application."
            ' Create a new attachment and add the PDF document.
            report.ExportToPdf(stream)
            stream.Seek(0, System.IO.SeekOrigin.Begin)
            builder.Attachments.Add("TestReport.pdf", stream.ToArray(), New ContentType("application", "pdf"))
            message.Body = builder.ToMessageBody()
            Return message
        End Function

        Private Shared Function CreateMimeMessageExportToMail(ByVal stream As MemoryStream) As MimeMessage
            ' Instantiate a report. 
            ' Email export options are already specified at design time.                
            Dim report As New XtraReport1()

            Dim mMessage As System.Net.Mail.MailMessage = report.ExportToMail("someone@test.com", report.ExportOptions.Email.RecipientAddress, report.ExportOptions.Email.RecipientName)
            mMessage.Subject = report.ExportOptions.Email.Subject

            ' Create a new attachment and add the PDF document.
            report.ExportToPdf(stream)
            stream.Seek(0, System.IO.SeekOrigin.Begin)
            Dim attachedDoc As New System.Net.Mail.Attachment(stream, "TestReport.pdf", "application/pdf")
            mMessage.Attachments.Add(attachedDoc)

            Dim message = CType(mMessage, MimeMessage)
            Return message
        End Function


        Private Async Sub btnSend_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnSend.Click
            Dim SmtpHost As String = Me.edtHost.EditValue.ToString()
            Dim SmtpPort As Integer = Integer.Parse(Me.edtPort.EditValue.ToString())
            Dim SmtpUserName As String = Me.edtUsername.EditValue.ToString()
            Dim SmtpUserPassword As String = Me.edtPassword.EditValue.ToString()
            Me.lblProgress.Text = "Sending mail..."
            Me.lblProgress.Text = Await SendAsync(SmtpHost, SmtpPort, SmtpUserName, SmtpUserPassword)
        End Sub

        Private Async Function SendAsync(ByVal smtpHost As String, ByVal smtpPort As Integer, ByVal userName As String, ByVal password As String) As Task(Of String)
            Dim result = "OK"
            ' Create a new memory stream and export the report in PDF.
            Using stream As MemoryStream = New MemoryStream()

                Using mail = CreateMimeMessage(stream)

                    Using client = New SmtpClient()

                        Try
                            client.Connect(smtpHost, smtpPort, SecureSocketOptions.Auto)
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
