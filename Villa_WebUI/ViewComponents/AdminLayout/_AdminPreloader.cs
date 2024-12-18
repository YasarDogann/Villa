using Microsoft.AspNetCore.Mvc;

namespace Villa_WebUI.ViewComponents.AdminLayout
{
    public class _AdminPreloader : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
