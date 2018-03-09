using System;
using System.Collections.Generic;
using System.Text;

namespace ApiLibrary.Interfaces
{
    public interface IConfigurationHelper
    {
        string EmailPassword { get; }

        string FromAddress { get; }

        string KaylaShows { get; }

        string ConnectionString { get; }
    }
}
