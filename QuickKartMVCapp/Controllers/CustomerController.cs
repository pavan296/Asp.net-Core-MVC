using Microsoft.AspNetCore.Mvc;

namespace QuickKartMVCapp.Controllers
{
    public class CustomerController : Controller
    {
        public IActionResult CustomerHome()
        {
            return View();
        }
    }
}
