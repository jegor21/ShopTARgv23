namespace ShopTARgv23.Core.Dto
{
    internal class FileToApiDto
    {

        public Guid Id { get; set; }
        public string ExistingFilePath { get; set; }
        public Guid? SpaceshipId { get; set; }
    }
}