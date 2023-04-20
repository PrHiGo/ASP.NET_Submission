using Microsoft.AspNetCore.Mvc;

namespace ASP.NETSubmission.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
