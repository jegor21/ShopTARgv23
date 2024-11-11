using Nancy;
using Nancy.Json;
using ShopTARgv23.Core.Dto.WeatherDtos;
using ShopTARgv23.Core.ServiceInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ShopTARgv23.ApplicationServices.Services
{
    public class WeatherForecastSevices : IWeatherForecastServices
    {
        public async Task<AccuLocationWeatherResultDto> AccuWeatherResult(AccuLocationWeatherResultDto dto)
        {
            string accuApiKey = "oqRZLuFEsuaI2sGXWUDHviSAXGbckDF0";
            string url = $"http://dataservice.accuweather.com/locations/v1/cities/search?apikey={accuApiKey}&q={dto.CityName}";

            
            using (WebClient client = new WebClient())
            {
                string json = client.DownloadString(url);

                List<AccuLocationRootDto> accuResult = new JavaScriptSerializer()
                    .Deserialize<List<AccuLocationRootDto>>(json);

                dto.CityName = accuResult[0].Citys[0].LocalizedName;
                dto.CityCode = accuResult[0].Citys[0].Key;
                dto.Rank = accuResult[0].Citys[0].Rank;
            }

            string urlWeather = $"http://dataservice.accuweather.com/forecasts/v1/daily/1day/{dto.CityCode}?apikey={accuApiKey}&metric=true";
               

            using (WebClient client = new WebClient())
            {
                string json = client.DownloadString(urlWeather);
                AccuWeatherRootDto weatherRootDto = new JavaScriptSerializer()
                    .Deserialize<AccuWeatherRootDto>(json);

                dto.EffectiveDate = weatherRootDto.Headline.EffectiveDate;
                dto.EffectiveEpochDate = weatherRootDto.Headline.EffectiveEpochDate;
                dto.Severity = weatherRootDto.Headline.Severity;
                dto.Text = weatherRootDto.Headline.Text;
                dto.Category = weatherRootDto.Headline.Category;
                dto.EndDate = weatherRootDto.Headline.EndDate;
                dto.EndEpochDate = weatherRootDto.Headline.EndEpochDate;
                dto.MobileLink = weatherRootDto.Headline.MobileLink;
                dto.Link = weatherRootDto.Headline.Link;

                dto.Value = weatherRootDto.Maximum.Value;
                dto.Unit = weatherRootDto.Maximum.Unit;
                dto.UnitType = weatherRootDto.Maximum.Type;

                dto.Value = weatherRootDto.Minimum.Value;
                dto.Unit = weatherRootDto.Minimum.Unit;
                dto.UnitType = weatherRootDto.Minimum.UnitType;

                dto.Icon = weatherRootDto.Night.Icon;
                dto.IconPhrase = weatherRootDto.Night.Icon;
                dto.HasPrecipitation = weatherRootDto.Night.HasPrecipitation;

                dto.Minimum = weatherRootDto.Temperature.Minimum;
                dto.Maximum = weatherRootDto.Temperature.Maximum;

            }
            return dto;
        }
    }
}
