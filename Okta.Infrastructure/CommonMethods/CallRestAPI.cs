using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Okta.Infrastructure.CommonMethods
{
    public class CallRestAPI
    {
        public static string AuthorizeData = "";
        public string CallGetAPI(string Url)
        {
            var client = new RestClient(Url);
            var request = new RestRequest(Method.GET);
            request.AddHeader("Accept", "application/json");
            request.AddHeader("Content-Type", "application/json");
            if(!string.IsNullOrEmpty(AuthorizeData))
                request.AddHeader("Authorization", AuthorizeData);
            IRestResponse response = client.Execute(request);
            return response.Content;
        }
    }
}
