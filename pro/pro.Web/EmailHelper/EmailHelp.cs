using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Web;

namespace pro.Web.EmailHelper
{
    public class EmailHelp
    {
        #region Mail Atma KOD
        public static bool SendEmail(String subject,String body,String from,String fromPassword,String to)
        {
            bool res = true;
            MailMessage email = new MailMessage();
            email.From = new MailAddress(from);
            email.To.Add(to);
            email.Attachments.Add(new Attachment($"C:/Mail/deneme.txt"));
            email.Subject = subject;
            email.Body = body;

            SmtpClient smtp = new SmtpClient();
            smtp.Credentials = new System.Net.NetworkCredential(from, fromPassword);
            smtp.Port = 587;
            smtp.EnableSsl = true;
            object userState = email;

            try
            {
                smtp.Send(email);
            }
            catch (SmtpException ex)
            {

                res = false;
                Console.WriteLine(ex.Message);
            }
            return res;
        }
        #endregion  
    }
}