using Nancy.Json;
using ShopTARgv23.Core.Dto.WeatherDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ShopTARgv23.ApplicationServices.Services
{
    public class WeatherForecastSevices
    {
        public async Task<AccuLocationWeatherResultDto> AccuWeatherResult(AccuLocationWeatherResultDto dto)
        {
            string accuApiKey = "oqRZLuFEsuaI2sGXWUDHviSAXGbckDF0";
            string url = $"http://datasevice.accuweather.com//locations/v1/cities/search?apikey={accuApiKey}=Tallinn&language=en-US&details=false HTTP/1.1"


            using (WebClient client = new WebClient())
            {
                string json = client.DownloadString(url);

                AccuLocationRootDto accuResult = new JavaScriptSerializer().Deserialize<AccuLocationRootDto>(json);
            }
                return dto;
        }
    }
}
