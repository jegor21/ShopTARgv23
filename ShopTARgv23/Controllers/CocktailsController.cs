using Microsoft.AspNetCore.Mvc;
using ShopTARgv23.Core.Dto.CocktailsDto;
using ShopTARgv23.Core.ServiceInterface;
using ShopTARgv23.Models.Cocktails;
namespace ShopTARgv23.Controllers
{
    public class CocktailsController : Controller
    {
        private readonly ICocktailServices _cocktailsServices;
        public CocktailsController
            (
                ICocktailServices cocktailsServices
            )
        {
            _cocktailsServices = cocktailsServices;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult SearchCocktails(CocktailsViewModel model)
        {
            return RedirectToAction(nameof(Cocktail));
        }
        [HttpGet]
        public IActionResult Cocktail()
        {
            CocktailDto dto = new();
            _cocktailsServices.GetCocktails(dto);
            CocktailsViewModel vm = new();
            vm.idDrink = dto.idDrink;
            vm.strDrink = dto.strDrink;
            vm.strDrinkAlternate = dto.strDrinkAlternate;
            vm.strTags = dto.strTags;
            vm.strCategory = dto.strCategory;
            vm.strIBA = dto.strIBA;
            vm.strAlcoholic = dto.strAlcoholic;
            vm.strGlass = dto.strGlass;
            vm.strInstructions = dto.strInstructions;
            vm.strInstructionsES = dto.strInstructionsES;
            vm.strInstructionsDE = dto.strInstructionsDE;
            vm.strInstructionsFR = dto.strInstructionsFR;
            vm.strInstructionsIT = dto.strInstructionsIT;
            vm.strDrinkThumb = dto.strDrinkThumb;
            vm.strIngredient1 = dto.strIngredient1;
            vm.strIngredient2 = dto.strIngredient2;
            vm.strIngredient3 = dto.strIngredient3;
            vm.strIngredient4 = dto.strIngredient4;
            vm.strIngredient5 = dto.strIngredient5;
            vm.strIngredient6 = dto.strIngredient6;
            vm.strIngredient7 = dto.strIngredient7;
            vm.strIngredient8 = dto.strIngredient8;
            vm.strIngredient9 = dto.strIngredient9;
            vm.strIngredient10 = dto.strIngredient10;
            vm.strIngredient11 = dto.strIngredient11;
            vm.strIngredient12 = dto.strIngredient12;
            vm.strIngredient13 = dto.strIngredient13;
            vm.strIngredient14 = dto.strIngredient14;
            vm.strIngredient15 = dto.strIngredient15;
            vm

            return View(vm);
        }
    }
}