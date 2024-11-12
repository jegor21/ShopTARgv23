using Nancy.Json;
using ShopTARgv23.Core.Dto.FreeToPlayGamesRootDto;
using ShopTARgv23.Core.ServiceInterface;
using System.Net;
namespace ShopTARgv23.ApplicationServices.Services
{
    public class FreeToPlayGamesServices : IFreeToPlayGamesServices
    {
        public async Task<FreeToPlayGamesResultDto> FreeToPlayGamesResult(FreeToPlayGamesResultDto dto)
        {
            var url = "https://www.freetogame.com/api/games";
            using (WebClient client = new WebClient())
            {
                string json = client.DownloadString(url);
                FreeToPlayGamesRootDto freeToPlayGamesResult = new JavaScriptSerializer().Deserialize<FreeToPlayGamesRootDto>(json);
                

                dto.Id = freeToPlayGamesResult.Id;
                dto.Title = freeToPlayGamesResult.Title;
                dto.Thumbnail = freeToPlayGamesResult.Thumbnail;
                dto.Short_description = freeToPlayGamesResult.Short_description;
                dto.Game_url = freeToPlayGamesResult.Game_url;
                dto.Genre = freeToPlayGamesResult.Genre;
                dto.Platform = freeToPlayGamesResult.Platform;
                dto.Publisher = freeToPlayGamesResult.Publisher;
                dto.Developer = freeToPlayGamesResult.Developer;
                dto.Release_date = freeToPlayGamesResult.Release_date;
                dto.Freetogame_profile_url = freeToPlayGamesResult.Freetogame_profile_url;
            }
            return dto;
        }
    }
}