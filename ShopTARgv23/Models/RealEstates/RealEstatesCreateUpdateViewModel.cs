namespace ShopTARgv23.Models.RealEstates
{
    public class RealEstatesCreateUpdateViewModel
    {
        public Guid? Id { get; set; }
        public double Size { get; set; }
        public string Location { get; set; }
        public int RoomNumber { get; set; }
        public string BuildingType { get; set; }
        public List<IFormFile> Files { get; set; }
        public List<RealEstatesImageViewModel> Image { get; set; }
            = new List<RealEstatesImageViewModel>();
        public DateTime CreatedAt { get; set; }
        public DateTime ModifiedAt { get; set; }
        

    }
}