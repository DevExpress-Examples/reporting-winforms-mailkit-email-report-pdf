using MailKit.Net.Smtp;
using MailKit.Security;
using MimeKit;
using System;
using System.IO;
using System.Threading.Tasks;

namespace SendReportWithMailKit {
    public partial class Form1 : DevExpress.XtraEditors.XtraForm
    {
        public Form1()
        {
            InitializeComponent();
            this.edtHost.EditValue = "localhost";
            this.edtPort.EditValue = 25;
        }

        private MimeMessage CreateMimeMessage(MemoryStream stream) {
            if ((bool)this.radioGroup1.EditValue)
                return CreateMimeMessageExportToMail(stream);
            else
                return CreateMimeMessageExportToPdf(stream);
        }

        private static MimeMessage CreateMimeMessageExportToPdf(MemoryStream stream)
        {
            // Instantiate a report. 
            // Email export options are already specified at design time.                
            XtraReport1 report = new XtraReport1();

            var message = new MimeMessage();
            message.From.Add(new MailboxAddress("Someone", "someone@test.com"));
            message.To.Add(new MailboxAddress(report.ExportOptions.Email.RecipientName,
                report.ExportOptions.Email.RecipientAddress));
            message.Subject = report.ExportOptions.Email.Subject;
            var builder = new BodyBuilder();
            builder.TextBody = "This is a test e-mail message sent by an application.";
            // Create a new attachment and add the PDF document.
            report.ExportToPdf(stream);
            stream.Seek(0, System.IO.SeekOrigin.Begin);
            builder.Attachments.Add("TestReport.pdf", stream.ToArray(), new ContentType("application","pdf"));
            message.Body = builder.ToMessageBody();
            return message;
        }

        private static MimeMessage CreateMimeMessageExportToMail(MemoryStream stream) {
            // Instantiate a report. 
            // Email export options are already specified at design time.                
            XtraReport1 report = new XtraReport1();

            System.Net.Mail.MailMessage mMessage = report.ExportToMail("someone@test.com",
                        report.ExportOptions.Email.RecipientAddress, report.ExportOptions.Email.RecipientName);
            mMessage.Subject = report.ExportOptions.Email.Subject;

            // Create a new attachment and add the PDF document.
            report.ExportToPdf(stream);
            stream.Seek(0, System.IO.SeekOrigin.Begin);
            System.Net.Mail.Attachment attachedDoc = new System.Net.Mail.Attachment(stream, "TestReport.pdf", "application/pdf");
            mMessage.Attachments.Add(attachedDoc);

            var message = (MimeMessage)mMessage;
            return message;
        }

        private async void btnSend_Click(object sender, EventArgs e)
        {
            string SmtpHost = edtHost.EditValue.ToString();
            int SmtpPort = Int32.Parse(edtPort.EditValue.ToString());
            string SmtpUserName = edtUsername.EditValue.ToString();
            string SmtpUserPassword = edtPassword.EditValue.ToString();
            lblProgress.Text = "Sending mail...";
            lblProgress.Text = await SendAsync(SmtpHost, SmtpPort, SmtpUserName, SmtpUserPassword);
        }

        private async Task<string> SendAsync(string smtpHost, int smtpPort, string userName, string password)
        {
            string result = "OK";
            // Create a new memory stream and export the report in PDF.
            using (MemoryStream stream = new MemoryStream())
            {
                using (MimeMessage mail = CreateMimeMessage(stream))
                {
                    using (var client = new SmtpClient())
                    {
                        try {
                            client.Connect(smtpHost, smtpPort, SecureSocketOptions.Auto);
                            //client.Authenticate(userName, password);
                            await client.SendAsync(mail);
                        }
                        catch (Exception ex) {
                            result = ex.Message;
                        }
                        client.Disconnect(true);
                    }
                }
            }
            return result;
        }
    }
}
