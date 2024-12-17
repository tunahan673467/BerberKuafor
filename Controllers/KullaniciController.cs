using Microsoft.AspNetCore.Mvc;

namespace BerberKuafor.Controllers
{
    public class KullaniciController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
