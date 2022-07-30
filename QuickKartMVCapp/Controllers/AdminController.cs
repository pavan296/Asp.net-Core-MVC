using Microsoft.AspNetCore.Mvc;

namespace QuickKartMVCapp.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult AdminHome()
        {
            return View();
        }
    }
}
