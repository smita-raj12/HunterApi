using System.Collections.Generic;
using MvcHunterApiCall.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace MvcHunterApiCall
{
    public class Job
    {
        //public string Type { get; set; }
        public string FirstName { get; set; }

    // public string LastName { get; set; }
    [System.Obsolete]
    public static Dictionary<string, List<Job>> GetJobs(string api_key, string domain)
    {
      var apiCallTask = ApiHelper.ApiCall(api_key, domain);
      var result = apiCallTask.Result;
      
      JObject jsonResponse = JsonConvert.DeserializeObject<JObject>(result);
      
      Dictionary<string, List<Job>> jobList = JsonConvert.DeserializeObject<Dictionary<string, List<Job>>>(jsonResponse["data"]["emails"].ToString());
      return jobList;
      
    }
  }
}    