using Microsoft.AspNetCore.Mvc;
using ShopTARgv23.Core.Dto.FreeToPlayGamesRootDto;
using ShopTARgv23.Core.ServiceInterface;
using ShopTARgv23.Models.FreeToPlayGames;
namespace ShopTARgv23.Controllers
{
    public class FreeToPlayGamesController : Controller
    {
        private readonly IFreeToPlayGamesServices _freeToPlayGamesServices;
        public FreeToPlayGamesController
            (
                IFreeToPlayGamesServices freeToPlayGamesServices
            )
        {
            _freeToPlayGamesServices = freeToPlayGamesServices;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult SearchFreeToPlayGames(FreeToPlayGamesViewModel model)
        {
            return RedirectToAction(nameof(Games));
        }
        [HttpGet]
        public async IActionResult Games()
        {
            FreeToPlayGamesResultDto dto = new();
            _freeToPlayGamesServices.FreeToPlayGamesResult();
            List<FreeToPlayGamesViewModel> vm = new();

            foreach (var freetoplaygames in vm)
            {
                freetoplaygames.Id = dto.Id;
                freetoplaygames.Title = dto.Title;
                freetoplaygames.Thumbnail = dto.Thumbnail;
                freetoplaygames.Short_description = dto.Short_description;
                freetoplaygames.Game_url = dto.Game_url;
                freetoplaygames.Genre = dto.Genre;
                freetoplaygames.Platform = dto.Platform;
                freetoplaygames.Publisher = dto.Publisher;
                freetoplaygames.Developer = dto.Developer;
                freetoplaygames.Release_date = dto.Release_date;
                freetoplaygames.Freetogame_profile_url = dto.Freetogame_profile_url;
            }
            

            return View(vm);
        }
    }
}