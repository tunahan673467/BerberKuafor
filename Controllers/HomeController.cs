using Microsoft.AspNetCore.Mvc;

namespace BerberKuafor.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
