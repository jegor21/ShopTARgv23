using Microsoft.AspNetCore.Mvc;

namespace ShopTARgv23.Controllers
{
    public class FreeToPlayGamesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
