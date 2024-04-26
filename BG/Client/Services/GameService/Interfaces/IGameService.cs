using BG.Shared;

namespace BG.Client.Services.GameService.Interfaces
{
    public interface IGameService
    {
        IEnumerable<Game> Games { get; set; }
        Task GetGames();
    }
}
