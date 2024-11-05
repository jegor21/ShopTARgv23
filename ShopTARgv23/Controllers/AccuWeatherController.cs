using Microsoft.AspNetCore.Mvc;
using ShopTARgv23.Core.Dto.WeatherDtos;
using ShopTARgv23.Core.ServiceInterface;
using ShopTARgv23.Models.AccuWeather;

namespace ShopTARgv23.Controllers
{
    public class AccuWeatherController : Controller
    {
        private readonly IWeatherForecastServices _weatherForecastServices;
        
        public AccuWeatherController(IWeatherForecastServices weatherForecastServices)
    
        {
            _weatherForecastServices = weatherForecastServices;
        }
        
 
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult SearchCity(AccuWeatherSearchViewModel model)
        {
            if (ModelState.IsValid)
            {
                return RedirectToAction("City", "AccuWeather", new { city = model.CityName});
            }

            return View(model);
            
        }

        [HttpGet]
        public IActionResult City(string city)
        {
            AccuLocationWeatherResultDto dto = new();
            dto.CityName = city;

            _weatherForecastServices.AccuWeatherResult(dto);
            

            return View();
        }
    }
}
