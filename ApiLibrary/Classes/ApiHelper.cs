using System;
using System.Net;
using ApiLibrary.Interfaces;
using RestSharp;

namespace ApiLibrary.Classes
{
    public class ApiHelper : IApiHelper
    {
        private readonly IDataHelper _dataHelper;

        public ApiHelper(IDataHelper dataHelper)
        {
            _dataHelper = dataHelper;
        }

        public string Get(string apiCall)
        {
            var client = new RestClient
            {
                BaseUrl = new Uri(_dataHelper.GetBaseUrl())
                // BaseUrl = new Uri("http://192.168.0.10:8989")
            };

            //var request = new RestRequest("http://192.168.0.10:8989/api/history?apikey=4446dcfa0a2a487098c8bc65bba6027e&sortKey=date&sortDir=desc", Method.GET);
            var request = new RestRequest(apiCall, Method.GET);

            var response = client.Execute(request);

            if (response.StatusCode != HttpStatusCode.OK)
            {
                throw new Exception("API call failed");
            }

            return response.Content;
        }
    }
}
