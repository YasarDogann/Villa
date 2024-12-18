using Microsoft.AspNetCore.Mvc;

namespace Villa_WebUI.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
