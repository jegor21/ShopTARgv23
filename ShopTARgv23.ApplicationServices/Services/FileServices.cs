using Microsoft.Extensions.Hosting;
using ShopTARgv23.Core.Dto;

namespace ShopTARgv23.ApplicationServices.Services
{
    public class FileServices
    {
        private readonly IHostEnvironment _webHost;


        public FileServices
            (
                IHostEnvironment webHost
            )
        {
            _webHost = webHost;
        }




        public void FilesToApi(SpaceshipDto dto, SpaceshipDto spaceship)
        {
            if (dto.Files != null && dto.Files.Count > 0) 
            {
                if (!Directory.Exists(_webHost.ContentRootPath + "\\multipleFileUpload\\"))
                {
                    Directory.CreateDirectory(_webHost.ContentRootPath + "\\multipleFileUpload\\");
                }

                foreach (var image in dto.Files)
                {
                    string uploadsFolder = Path.Combine(_webHost.ContentRootPath, "multipleFileUpload");
                    string uniqueFileName = Guid.NewGuid().ToString() + "_" +image.FileName;
                }
            }
        }
    }
}
