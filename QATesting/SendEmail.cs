using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Net.Mail;
using System.Net;

namespace QATesting
{
    [TestClass]
    public class SendEmail
    {
        [TestMethod]
        public void SendEmailMethod()
        {
            try
            {
                MailMessage mail = new MailMessage();
                SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");
                mail.From = new MailAddress("bogdan.ponocko@gmail.com");
                mail.To.Add("bogdan.ponocko@gmail.com");
                mail.Subject = "Test Mail - 1";
                mail.Body = "mail with attachment";

                System.Net.Mail.Attachment attachment;
                attachment = new System.Net.Mail.Attachment("D:/textfile.txt");
                mail.Attachments.Add(attachment);

                SmtpServer.Port = 587;
                SmtpServer.Credentials = new System.Net.NetworkCredential("mail@gmail.com", "password2020");
                SmtpServer.EnableSsl = true;

                SmtpServer.Send(mail);
            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("sent");
            }
        }
    }
}
