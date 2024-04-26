namespace BG.Server.Services.GameService.Interfaces
{
    public interface IGameService
    {
        Task<ServiceResponse<IEnumerable<Game>>> GetGamesAsync();
    }
}
