using Microsoft.AspNetCore.Mvc;
using ShopTARgv23.Models.RealEstates;
using ShopTARgv23.Core.Dto;
using ShopTARgv23.Core.ServiceInterface;
using ShopTARgv23.Data;
using ShopTARgv23.ApplicationServices.Services;
using ShopTARgv23.Models.Spaceships;
using Microsoft.EntityFrameworkCore;


namespace ShopTARgv23.Controllers
{
    public class RealEstatesController : Controller
    {
        

        private readonly ShopTARgv23Context _context;
        private readonly IRealEstateServices _realEstateServices;

        public RealEstatesController
            (
                ShopTARgv23Context context,
                IRealEstateServices realEstateServices
            )
        { 
            _context = context;
            _realEstateServices = realEstateServices;
        }

        public IActionResult Index()
        {
            var result = _context.RealEstates
                .Select(x => new RealEstatesIndexViewModel
                {
                    Id = x.Id,
                    Location = x.Location,
                    Size = x.Size,
                    RoomNumber = x.RoomNumber,
                    BuildingType = x.BuildingType,
                    CreatedAt = x.CreatedAt,
                    ModifiedAt = x.ModifiedAt
                });


            return View(result);
        }

        [HttpGet]
        public IActionResult Create()
        {
            RealEstatesCreateUpdateViewModel realEstates = new();

            return View("CreateUpdate", realEstates);
        }

        [HttpPost]
        public async Task<IActionResult> Create(RealEstatesCreateUpdateViewModel vm)
        {
            var dto = new RealEstateDto()
            {
                Id = vm.Id,
                Size = vm.Size,
                Location = vm.Location,
                RoomNumber = vm.RoomNumber,
                BuildingType = vm.BuildingType,
                CreatedAt = vm.CreatedAt,
                ModifiedAt = vm.ModifiedAt
            };

            var result = await _realEstateServices.Create(dto);

            if (result == null)
            {
                return RedirectToAction(nameof(Index));
            }

            return RedirectToAction(nameof(Index), vm);
        }

        [HttpGet]
        public async Task<IActionResult> Update(Guid id)
        {
            var realestate = await _realEstateServices.DetailsAsync(id);

            if (realestate == null)
            {
                return NotFound();
            }



            var vm = new RealEstatesCreateUpdateViewModel();

            vm.Id = realestate.Id;
            vm.Location = realestate.Location;
            vm.Size = realestate.Size;
            vm.RoomNumber = realestate.RoomNumber;
            vm.BuildingType = realestate.BuildingType;


            return View("CreateUpdate", vm);
        }

        [HttpPost]
        public async Task<IActionResult> Update(RealEstatesCreateUpdateViewModel vm)
        {
            var dto = new RealEstateDto()
            {
                Id = vm.Id,
                Location = vm.Location,
                Size = vm.Size,
                RoomNumber = vm.RoomNumber,
                BuildingType = vm.BuildingType,
            };

            var result = await _realEstateServices.Update(dto);

            if (result == null)
            {
                return RedirectToAction(nameof(Index));
            }

            return RedirectToAction(nameof(Index));
        }

        [HttpGet]
        public async Task<IActionResult> Details(Guid id)
        {
            var realestate = await _realEstateServices.DetailsAsync(id);

            if (realestate == null)
            {
                return NotFound();
            }


            var vm = new RealEstatesDetailsViewModel();

            vm.Id = realestate.Id;
            vm.Size = realestate.Size;
            vm.Location = realestate.Location;
            vm.RoomNumber = realestate.RoomNumber;
            vm.BuildingType = realestate.BuildingType;
            vm.CreatedAt = realestate.CreatedAt;
            vm.ModifiedAt = realestate.ModifiedAt;
            

            return View(vm);
        }

        [HttpGet]
        public async Task<IActionResult> Delete(Guid id)
        {
            var realestate = await _realEstateServices.DetailsAsync(id);

            if (realestate == null)
            {
                return NotFound();
            }


            var vm = new RealEstatesDeleteViewModel();

            vm.Id = realestate.Id;
            vm.Size = realestate.Size;
            vm.Location = realestate.Location;
            vm.RoomNumber = realestate.RoomNumber;
            vm.BuildingType = realestate.BuildingType;
            vm.CreatedAt = realestate.CreatedAt;
            vm.ModifiedAt = realestate.ModifiedAt;

            return View(vm);
        }

        [HttpPost]
        public async Task<IActionResult> DeleteConfirmation(Guid id)
        {
            var realestate = await _realEstateServices.Delete(id);

            if (realestate == null)
            {
                return RedirectToAction(nameof(Index));
            }

            return RedirectToAction(nameof(Index));
        }
    }
}
