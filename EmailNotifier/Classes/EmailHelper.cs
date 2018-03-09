using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Mail;
using EmailNotifier.Interfaces;
using EmailNotifier.Models;
using ApiLibrary.Interfaces;

namespace EmailNotifier.Classes
{
    class EmailHelper : IEmailHelper
    {
        private readonly IConfigurationHelper _configurationHelper;

        public EmailHelper(IConfigurationHelper configurationHelper)
        {
            _configurationHelper = configurationHelper;
        }

        public Email CreateEmail(string body, string subject, string toAddress)
        {
            var email = new Email(_configurationHelper)
            {
                Body = body,
                Subject = subject,
                ToAddress = toAddress
            };

            return email;
        }

        public void SendEmail(Email email)
        {
            var smtpClient = CreateSmtpClient(email.Password, email.FromAddress);

            var mailMessage = CreateMailMessage(email);

            smtpClient.Send(mailMessage);
        }

        private MailMessage CreateMailMessage(Email email)
        {
            var mailMessage = new MailMessage
            {
                From = new MailAddress(email.FromAddress),
                Subject = email.Subject,
                Body = email.Body
            };

            mailMessage.To.Add(email.ToAddress);

            return mailMessage;
        }

        private SmtpClient CreateSmtpClient(string password, string address)
        {
            return new SmtpClient("smtp.gmail.com")
            {
                Port = 587,
                EnableSsl = true,
                Credentials = new NetworkCredential(address, password)
            };
        }
    }
}
