using System;
using System.Threading.Tasks;
using RestSharp;


namespace MvcHunterApiCall.Models
{
  class ApiHelper
  {
    [Obsolete]
    public static async Task<string> ApiCall(string api_key, string domain)
            {
                RestClient client = new RestClient("https://api.hunter.io/v2/domain-search?");
                RestRequest request = new RestRequest($"domain={domain}&api_key={api_key}", Method.GET);
                
                var response = await client.ExecuteTaskAsync(request);
                return response.Content;
            }
  }
}