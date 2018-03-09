using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmailNotifier.Interfaces;
using ApiLibrary.Interfaces;

namespace EmailNotifier.Models
{
    public class Email
    {
        private readonly IConfigurationHelper _configurationHelper;

        public Email(IConfigurationHelper configurationHelper)
        {
            _configurationHelper = configurationHelper;
        }

        public string ToAddress { get; set; }

        public string Body { get; set; }

        public string Subject { get; set; }

        public string Password => _configurationHelper.EmailPassword;

        public string FromAddress => _configurationHelper.FromAddress;
    }
}
