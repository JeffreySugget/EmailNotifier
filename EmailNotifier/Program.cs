using EmailNotifier.Classes;
using EmailNotifier.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unity;

namespace EmailNotifier
{
    class Program
    {
        static void Main(string[] args)
        {
            //testpush
            var container = new UnityContainer();
            container.RegisterType<IEmailHelper, EmailHelper>();
            container.RegisterType<IConfigurationHelper, ConfigurationHelper>();

            var emailHelper = container.Resolve<IEmailHelper>();

            var email = emailHelper.CreateEmail("This is a body", "This is a subject", "");

            emailHelper.SendEmail(email);
        }
    }
}
