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
            var container = new UnityContainer();
            container.RegisterType<IEmailHelper, EmailHelper>();
            container.RegisterType<IConfigurationHelper, ConfigurationHelper>();
            container.RegisterType<IApiHelper, ApiHelper>();

            var emailHelper = container.Resolve<IEmailHelper>();
            var apiHelper = container.Resolve<IApiHelper>();

            var email = emailHelper.CreateEmail("This is a body", "This is a subject", "");

            var temp = apiHelper.Get();

            emailHelper.SendEmail(email);
        }
    }
}
