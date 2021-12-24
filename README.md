# How to Use MailKit to Send a Report as a Document in PDF 

This example demonstrates how to email a report with the MailKit email client library. Run the aplication, enter the SMTP host, port, smtp credentials, and click **Send** to email a document to the address specified in the report export options. 

![App Screenshot](Images/screenshot.png)

The project code that sends a report as a PDF attachment includes the following steps:

* Call the [XtraReport.ExportToPdf](https://docs.devexpress.com/XtraReports/DevExpress.XtraReports.UI.XtraReport.ExportToPdf.overloads) method to export a report to a PDF document.
* Attach the PDF document to the [MimeMessage](http://www.mimekit.net/docs/html/T_MimeKit_MimeMessage.htm) object.
* Retrieve the report's [ExportOptions.Email](https://docs.devexpress.com/CoreLibraries/DevExpress.XtraPrinting.EmailOptions) settings and apply them to the MailMessage settings.
* Create the [SmtpClient](http://www.mimekit.net/docs/html/T_MailKit_Net_Smtp_SmtpClient.htm) instance and call its [SendAsync](http://www.mimekit.net/docs/html/M_MailKit_MailTransport_SendAsync_3.htm) method.

<!-- default file list -->

## Files to Look At

- [Form1.cs](CS/Form1.cs) ([Form1.vb](VB/Form1.vb))

<!-- default file list end -->

## Documentation

- [Email Reports](http://docs.devexpress.devx/XtraReports/17634/detailed-guide-to-devexpress-reporting/store-and-distribute-reports/export-reports/email-reports)

## More Examples

- [How to Send a Report as HTML in an Email Body](https://github.com/DevExpress-Examples/Reporting_how-to-send-a-report-as-html-in-an-email-body-t314020)
- [Web Document Viewer - How to send a report via Email from the client side](https://github.com/DevExpress-Examples/Reporting_web-document-viewer-how-to-send-a-report-via-email-from-the-client-side-t566760)
