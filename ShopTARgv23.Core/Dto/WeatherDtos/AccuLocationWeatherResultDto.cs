using System.Text.Json.Serialization;

namespace ShopTARgv23.Core.Dto.WeatherDtos
{
    public class AccuLocationWeatherResultDto
    {
        public string CityName { get; set; }
        public string CityCode { get; set; }
        public int Version { get; set; }
        public string Key { get; set; }
        public string Type { get; set; }
        public int Rank { get; set; }
        public string LocalizedName { get; set; }
        public string EnglishName { get; set; }
        public string PrimaryPostalCode { get; set; }
        public string RegionId { get; set; }
        public string RegionLocalizedName { get; set; }
        public string RegionEnglishName { get; set; }
        public string CountryId { get; set; }
        public string CountryLocalizedName { get; set; }
        public string CountryEnglishName { get; set; }
        public string AdministrativeAreaId { get; set; }
        public string AdministrativeAreaLocalizedName { get; set; }
        public string AdministrativeAreaEnglishName { get; set; }
        public int AdministrativeAreaLevel { get; set; }
        public string AdministrativeAreaLocalizedType { get; set; }
        public string AdministrativeAreaEnglishType { get; set; }
        public string AdministrativeAreaCountryID { get; set; }
        public string TimeZoneCode { get; set; }
        public string TimeZoneName { get; set; }
        public float TimeZoneGmtOffset { get; set; }
        public bool TimeZoneIsDaylightSaving { get; set; }
        public DateTime TimeZoneNextOffsetChange { get; set; }
        public double GeoPositionLatitude { get; set; }
        public double GeoPositionLongitude { get; set; }
        public double GeoPositionElevationMetricValue { get; set; }
        public string GeoPositionElevationMetricUnit { get; set; }
        public int GeoPositionElevationMetricUnitType { get; set; }
        public double GeoPositionElevationImperialValue { get; set; }
        public string GeoPositionElevationImperialUnit { get; set; }
        public int GeoPositionElevationImperialUnitType { get; set; }
        public bool IsAlias { get; set; }
        public string ParentCity { get; set; }
        public string ParentCityKey { get; set; }
        public string ParentCityLocalizedName { get; set; }
        public string ParentCityEnglishName { get; set; }
        public int SupplementalAdminAreasLevel { get; set; }
        public string SupplementalAdminAreasLocalizedName { get; set; }
        public string SupplementalAdminAreasEnglishName { get; set; }
        public string DataSets { get; set; }
    }
}
