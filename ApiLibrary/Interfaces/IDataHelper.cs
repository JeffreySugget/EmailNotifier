using System;
using System.Collections.Generic;
using System.Text;

namespace ApiLibrary.Interfaces
{
    public interface IDataHelper
    {
        string GetApiCall(string endPoint, string parameters = null);

        string GetBaseUrl();

        IEnumerable<string> GetEmails();
    }
}
