using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Web;

namespace WebFormv2.Classes
{
    public class OutOperations
    {
        public string SendPassword(Users user)
        {
            string result;

            try
            {
                user.Password = Guid.NewGuid().ToString();
                user.Password = user.Password.Remove(12);
                OMSOperations op = new OMSOperations();
                string res = op.ChangePassword(user.UserID, user.Password, true);
                //user = op.ValidateUser(user.UserName, user.Password);

                MailMessage mail = new MailMessage();
                mail.To.Add(user.Email);
                //mail.To.Add("kdiaz1744@hotmail.com");
                mail.From = new MailAddress("kevin.diaz.dxc@gmail.com");
                mail.Subject = "Your New Password";
                mail.Body = "New password: " + user.Password;
                SmtpClient smtp = new SmtpClient();
                smtp.Host = "smtp.gmail.com";
                smtp.Port = 587;
                smtp.UseDefaultCredentials = false;
                smtp.Credentials = new System.Net.NetworkCredential("kevin.diaz.dxc@gmail.com", "Canela02");
                smtp.EnableSsl = true;

                smtp.Send(mail);
                result = "Done";
            }
            catch (Exception ex)
            {
                result = ex.ToString();
            }

            return result;
        }
        public string NewUser(Users user)
        {
            string result;

            try
            {
                //user.Password = Guid.NewGuid().ToString();
                //user.Password = user.Password.Remove(12);
                OMSOperations op = new OMSOperations();
                string res = op.ChangePassword(user.UserID, user.Password, true);
                //user = op.ValidateUser(user.UserName, user.Password);

                MailMessage mail = new MailMessage();
                mail.To.Add(user.Email);
                //mail.To.Add("kdiaz1744@hotmail.com");
                mail.From = new MailAddress("kevin.diaz.dxc@gmail.com");
                mail.Subject = "Your New Account Password";
                mail.Body = "Account password: " + user.Password;
                SmtpClient smtp = new SmtpClient();
                smtp.Host = "smtp.gmail.com";
                smtp.Port = 587;
                smtp.UseDefaultCredentials = false;
                smtp.Credentials = new System.Net.NetworkCredential("kevin.diaz.dxc@gmail.com", "Canela02");
                smtp.EnableSsl = true;

                smtp.Send(mail);
                result = "Done";
            }
            catch (Exception ex)
            {
                result = ex.ToString();
            }

            return result;
        }

    }
}