using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmailNotifier.Interfaces
{
    public interface IDataHelper
    {
        string GetApiCall(string endPoint, string parameters = null);

        string GetBaseUrl();

        Dictionary<string, int> GetEmails();
    }
}
