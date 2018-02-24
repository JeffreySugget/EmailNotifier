using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmailNotifier.Models;

namespace EmailNotifier.Interfaces
{
    public interface IEmailHelper
    {
        Email CreateEmail(string body, string subject, string toAddress);

        void SendEmail(Email email);
    }
}
