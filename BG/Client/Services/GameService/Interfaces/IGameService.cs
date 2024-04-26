using BG.Shared;

namespace BG.Client.Services.GameService.Interfaces
{
    public interface IGameService
    {
        List<Game> Games { get; set; }
        Task GetGames();
        Task<ServiceResponse<Game>> GetGame(string id);
    }
}
