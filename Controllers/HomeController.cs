
using Microsoft.AspNetCore.Mvc;

using MvcHunterApiCall.Models;

namespace MvcHunterApiCall.Controllers
{
  public class HomeController : Controller
    {
    [System.Obsolete]
    public IActionResult Index(string domain)
        {
            var allJobs = Job.GetJobs(EnvironmentVariables.ApiKey, domain);
            return View(allJobs);
        }
    }
}