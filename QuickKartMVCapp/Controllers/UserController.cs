using Microsoft.AspNetCore.Mvc;

namespace QuickKartMVCapp.Controllers
{
    public class UserController : Controller
    {
        public IActionResult RegisterUser()
        {
            return View();
        }
    }
}
