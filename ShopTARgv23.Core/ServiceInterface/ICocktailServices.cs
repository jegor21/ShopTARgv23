using ShopTARgv23.Core.Dto.CocktailDto;

namespace ShopTARgv23.Core.ServiceInterface
{
    public interface ICocktailServices
    {
        Task<List<CocktailRootDto>> GetCocktails();
    }

}
