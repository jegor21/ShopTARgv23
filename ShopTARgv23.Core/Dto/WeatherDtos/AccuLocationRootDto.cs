using System.Text.Json.Serialization;

namespace ShopTARgv23.Core.Dto.WeatherDtos
{
    public class AccuLocationRootDto
    {
        public List<City> Citys { get; set; }
    }

    public class City
    {
        [JsonPropertyName("Version")]
        public int Version { get; set; }

        [JsonPropertyName("Key")]
        public string Key { get; set; }

        [JsonPropertyName("Type")]
        public string Type { get; set; }

        [JsonPropertyName("Rank")]
        public int Rank { get; set; }

        [JsonPropertyName("LocalizedName")]
        public string LocalizedName { get; set; }

        [JsonPropertyName("EnglishName")]
        public string EnglishName { get; set; }

        [JsonPropertyName("PrimaryPostalCode")]
        public string PrimaryPostalCode { get; set; }
        public AdministrativeArea AdministrativeArea { get; set; }
        public Country Country { get; set; }
        public Region Region { get; set; }
        public TimeZone TimeZone { get; set; }
        public GeoPosition GeoPosition { get; set; }

        [JsonPropertyName("SupplementalAdminAreas")]
        public List<SupplementalAdminAreas> SupplementalAdminAreas { get; set; }

        [JsonPropertyName("DataSets")]
        public List<string> DataSets { get; set; }

        [JsonPropertyName("IsAlias")]
        public bool IsAlias { get; set; }

    }
    public class Region
    {
        [JsonPropertyName("ID")]
        public string ID { get; set; }

        [JsonPropertyName("LocalizedName")]
        public string LocalizedName { get; set; }

        [JsonPropertyName("EnglishName")]
        public string EnglishName { get; set; }
    }
    public class Country
    {
        [JsonPropertyName("ID")]
        public string ID { get; set; }

        [JsonPropertyName("LocalizedName")]
        public string LocalizedName { get; set; }

        [JsonPropertyName("EnglishName")]
        public string EnglishName { get; set; }
    }
    public class AdministrativeArea
    {
        [JsonPropertyName("ID")]
        public string ID { get; set; }

        [JsonPropertyName("LocalizedName")]
        public string LocalizedName { get; set; }

        [JsonPropertyName("EnglishName")]
        public string EnglishName { get; set; }

        [JsonPropertyName("Level")]
        public int Level { get; set; }

        [JsonPropertyName("LocalizedType")]
        public string LocalizedType { get; set; }

        [JsonPropertyName("EnglishType")]
        public string EnglishType { get; set; }

        [JsonPropertyName("CountryID")]
        public string CountryID { get; set; }
    }
    public class TimeZone
    {
        [JsonPropertyName("Code")]
        public string Code { get; set; }

        [JsonPropertyName("Name")]
        public string Name { get; set; }

        [JsonPropertyName("GmtOffset")]
        public int GmtOffset { get; set; }

        [JsonPropertyName("IsDaylightSaving")]
        public bool IsDaylightSaving { get; set; }

        [JsonPropertyName("NextOffsetChange")]
        public string NextOffsetChange { get; set; }
    }
    public class GeoPosition
    {
        [JsonPropertyName("Latitude")]
        public float Latitude { get; set; }

        [JsonPropertyName("Longitude")]
        public float Longitude { get; set; }
        public Elevation Elevation { get; set; }
    }
    public class SupplementalAdminAreas
    {
        [JsonPropertyName("Level")]
        public int Level { get; set; }

        [JsonPropertyName("LocalizedName")]
        public string LocalizedName { get; set; }

        [JsonPropertyName("EnglishName")]
        public string EnglishName { get; set; }
    }
    public class Elevation
    {
        public Metric Metric { get; set; }
        public Imperial Imperial { get; set; }
    }
    public class Metric
    {
        [JsonPropertyName("Value")]
        public int Value { get; set; }

        [JsonPropertyName("Unit")]
        public string Unit { get; set; }

        [JsonPropertyName("UnitType")]
        public int UnitType { get; set; }
    }
    public class Imperial
    {
        [JsonPropertyName("Value")]
        public int Value { get; set; }

        [JsonPropertyName("Unit")]
        public string Unit { get; set; }

        [JsonPropertyName("UnitType")]
        public int UnitType { get; set; }
    }
}