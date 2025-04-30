<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/441553347/24.2.1%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T1055592)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
[![](https://img.shields.io/badge/💬_Leave_Feedback-feecdd?style=flat-square)](#does-this-example-address-your-development-requirementsobjectives)
<!-- default badges end -->
# Reporting for WinForms - How to Use MailKit to Email a Report

This example demonstrates how to email a report with the [MailKit](http://www.mimekit.net/docs/html/Introduction.htm) email client library. Run the application, enter the SMTP host name, port, smtp credentials if needed, and click **Send** to email a document to the address you specified earlier in the report export options.

To specify the report export options for email, use the report's [ExportOptions.Email](https://docs.devexpress.com/CoreLibraries/DevExpress.XtraPrinting.ExportOptions.Email) property.

Before you click **Send**, you can choose from two mail options:

- Send a report in HTML format in the email message body and in the attached PDF file. The [ExportToMail](https://docs.devexpress.com/XtraReports/DevExpress.XtraReports.UI.XtraReport.ExportToMail(System.String-System.String-System.String)) method creates HTML part of [MailMessage](https://learn.microsoft.com/en-us/dotnet/api/system.net.mail.mailmessage) object, the [ExportToPdf](https://docs.devexpress.com/XtraReports/DevExpress.XtraReports.UI.XtraReport.ExportToPdf(System.IO.Stream-DevExpress.XtraPrinting.PdfExportOptions)) method creates a PDF stream attached to the [MailMessage](https://learn.microsoft.com/en-us/dotnet/api/system.net.mail.mailmessage) instance. After converting the message into a [MimeMessage](http://www.mimekit.net/docs/html/T_MimeKit_MimeMessage.htm) object, the **MailKit**'s [SmtpClient](http://www.mimekit.net/docs/html/T_MailKit_Net_Smtp_SmtpClient.htm) object calls the [SendAsync](http://www.mimekit.net/docs/html/M_MailKit_MailTransport_SendAsync_3.htm) method to send the message.
- Send a report as PDF attachment. The [ExportToPdf](https://docs.devexpress.com/XtraReports/DevExpress.XtraReports.UI.XtraReport.ExportToPdf(System.IO.Stream-DevExpress.XtraPrinting.PdfExportOptions)) method creates a PDF stream that the [BoduyBuilder](http://www.mimekit.net/docs/html/T_MimeKit_BodyBuilder.htm) class uses to create an attachment for the [MimeMessage](http://www.mimekit.net/docs/html/T_MimeKit_MimeMessage.htm) object. The **MailKit**'s [SmtpClient](http://www.mimekit.net/docs/html/T_MailKit_Net_Smtp_SmtpClient.htm) object calls the [SendAsync](http://www.mimekit.net/docs/html/M_MailKit_MailTransport_SendAsync_3.htm) method to send the message.

The following image shows an email in which the report is included both in the HTML body and as a PDF attachment.

![App Screenshot](Images/screenshot.png)


## Files to Review
- [Form1.cs](CS/Form1.cs) ([Form1.vb](VB/Form1.vb))

## Documentation

- [Email Reports](https://docs.devexpress.com/XtraReports/17634/detailed-guide-to-devexpress-reporting/store-and-distribute-reports/export-reports/email-reports)
- [MailKit](http://www.mimekit.net/docs/html/Introduction.htm)

## More Examples

- [Reporting for ASP.NET MVC - How to Email a Report from the Document Viewer](https://github.com/DevExpress-Examples/reporting-web-mvc-email-report)
- [Reporting for Blazor - Email a Report from the Native Blazor Report Viewer](https://github.com/DevExpress-Examples/reporting-blazor-email-report)

<!-- feedback -->
## Does this example address your development requirements/objectives?

[<img src="https://www.devexpress.com/support/examples/i/yes-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=reporting-winforms-mailkit-email-report-pdf&~~~was_helpful=yes) [<img src="https://www.devexpress.com/support/examples/i/no-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=reporting-winforms-mailkit-email-report-pdf&~~~was_helpful=no)

(you will be redirected to DevExpress.com to submit your response)
<!-- feedback end -->
