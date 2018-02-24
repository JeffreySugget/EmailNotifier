using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using EmailNotifier.Interfaces;
using RestSharp;

namespace EmailNotifier.Classes
{
    public class ApiHelper : IApiHelper
    {
        public string Get()
        {
            var client = new RestClient
            {
                BaseUrl = new Uri("https://192.168.0.10:8989/api")
            };

            var request = new RestRequest("http://192.168.0.10:8989/api/history?apikey=4446dcfa0a2a487098c8bc65bba6027e&sortKey=date&sortDir=desc", Method.GET);
            //var request = new RestRequest("http://192.168.0.10:8989/api/system/status?apikey=4446dcfa0a2a487098c8bc65bba6027e", Method.GET);
            //var request = new RestRequest("http://192.168.0.10:8989/api/series?apikey=4446dcfa0a2a487098c8bc65bba6027e", Method.GET);

            var response = client.Execute(request);

            if (response.StatusCode != HttpStatusCode.OK)
            {
                throw new Exception("API call failed");
            }

            return response.Content;
        }
    }
}
