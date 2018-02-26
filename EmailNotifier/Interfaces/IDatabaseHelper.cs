using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmailNotifier.Interfaces
{
    public interface IDatabaseHelper
    {
        void CreateDatabase();

        string GetApiCall(string endPoint, string parameters = null);
    }
}
