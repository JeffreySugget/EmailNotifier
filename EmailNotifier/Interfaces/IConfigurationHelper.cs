using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmailNotifier.Interfaces
{
    public interface IConfigurationHelper
    {
        string EmailPassword { get; }

        string FromAddress { get; }
    }
}
