using Nancy.Json;
using ShopTARgv23.Core.Dto.FreeToPlayGamesRootDto;
using ShopTARgv23.Core.ServiceInterface;
using System.Net;
using System.Text.Json;
namespace ShopTARgv23.ApplicationServices.Services
{
    public class FreeToPlayGamesServices : IFreeToPlayGamesServices
    {
        public async Task<List<FreeToPlayGamesRootDto>> FreeToPlayGamesResult()
        {
            var url = "https://www.freetogame.com/api/games";
            List<FreeToPlayGamesRootDto> list = new List<FreeToPlayGamesRootDto>();

            using (WebClient client = new WebClient())
            {
                string json = client.DownloadString(url);
                var result = JsonSerializer.Deserialize<List<FreeToPlayGamesRootDto>>(json);

                if (result != null)
                {
                    list.AddRange(result);

                }
            }
            return list;
        }
    }
}