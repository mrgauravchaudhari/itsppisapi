using Microsoft.Extensions.Configuration;
using System.Net.Mail;
using System.Text;

namespace itsppisapi.Helpers
{
    public class EmailHelper
    {
        private string _host;
        private string _port;
        private string _from;
        public EmailHelper(IConfiguration iConfiguration)
        {
            var smtpSection = iConfiguration.GetSection("SMTP");
            if (smtpSection != null)
            {
                _host = smtpSection.GetSection("Host").Value;
                _port = smtpSection.GetSection("Port").Value;
                _from = smtpSection.GetSection("From").Value;
            }
        }

        public void SendEmail(EmailHelperModel emailModel)
        {
            try
            {
                using (SmtpClient client = new SmtpClient(_host))
                {
                    MailMessage mailMessage = new MailMessage();
                    mailMessage.From = new MailAddress(_from, emailModel.Alias);
                    mailMessage.BodyEncoding = Encoding.UTF8;
                    mailMessage.To.Add(emailModel.To);
                    mailMessage.Body = "<html>" +
                        "<head>" +
                        "<meta http - equiv = 'Content-Type' content = 'text/html; charset=utf-8' />" +
                        "<style type = 'text/css'> body { margin: 0; padding: 0; min - width: 100 % !important; }.content {width: 100%; max-width: 600px;}  </style>" +
                        "</head>" +
                        "<body yahoo bgcolor='#f6f8f1'>" +
                        "<br><table width = '100%' border='0' cellpadding='0' cellspacing='0' bgcolor='#f6f8f1' >" +
                        "<tr><td>" +
                        "<table class='content' align='center' cellpadding='0' cellspacing='0' border='0'><tr><td><br>"
                        +
                            emailModel.Message
                        +
                        "<br><br>Regards, <br> CFCL Team <br>" +
                        "<br><p style='font-size:10px; color:#858585;'>© " + 2020 + " <b>Chambal Fertilisers and Chemicals Limited</b><br>" +
                        "Please don't replay this email, this email are system generated email.<br>Please do not share your password, OTP or any other confidential information with anyone even if he/she claims to be from CFCL. We advise our users to completely ignore such communications." +
                        "</p>" +
                        "</td></tr>" +
                        "</table>" +
                        "</td></tr></table><br>" +
                        "</body>" +
                        "</html>";
                    mailMessage.Subject = emailModel.Subject;
                    mailMessage.IsBodyHtml = emailModel.IsBodyHtml;

                    client.Port = int.Parse(_port);
                    client.UseDefaultCredentials = false;
                    client.Send(mailMessage);
                }
            }
            catch
            {
                throw;
            }
        }
    }
}

//SmtpClient ss = new SmtpClient("<Your Local IP Addres>");
//ss.Port = 25;  
//ss.UseDefaultCredentials = true;  
//ss.Send("<From Mail>", "<To Mail>", "<Subject>", "<Body message>"); 