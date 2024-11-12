using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace ShopTARgv23.Core.Dto.FreeToPlayGamesRootDto
{
    public class FreeToPlayGamesRootDto
    {
        [JsonPropertyName("id")]
        public string Id { get; set; }
        [JsonPropertyName("title")]
        public string Title { get; set; }
        [JsonPropertyName("thumbnail")]
        public string Thumbnail { get; set; }
        [JsonPropertyName("short_description")]
        public string Short_description { get; set; }
        [JsonPropertyName("game_url")]
        public string Game_url { get; set; }
        [JsonPropertyName("genre")]
        public string Genre { get; set; }
        [JsonPropertyName("platform")]
        public string Platform { get; set; }
        [JsonPropertyName("publisher")]
        public string Publisher { get; set; }
        [JsonPropertyName("developer")]
        public string Developer { get; set; }
        [JsonPropertyName("release_date")]
        public string Release_date { get; set; }
        [JsonPropertyName("freetogame_profile_url")]
        public string Freetogame_profile_url { get; set; }
    }
}
