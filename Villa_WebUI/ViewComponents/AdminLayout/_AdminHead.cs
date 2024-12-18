using Microsoft.AspNetCore.Mvc;

namespace Villa_WebUI.ViewComponents.AdminLayout
{
    public class _AdminHead:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
