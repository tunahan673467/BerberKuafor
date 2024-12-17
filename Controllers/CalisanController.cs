using Microsoft.AspNetCore.Mvc;

namespace BerberKuafor.Controllers
{
    public class CalisanController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
