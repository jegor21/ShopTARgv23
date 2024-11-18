using ShopTARgv23.Core.Dto.FreeToPlayGamesRootDto;


namespace ShopTARgv23.Core.ServiceInterface
{
    public interface IFreeToPlayGamesServices
    {
        Task<List<FreeToPlayGamesRootDto>> FreeToPlayGamesResult();
    }
}