using BG.Client.Services.GameService.Interfaces;
using BG.Shared;
using System.Net.Http.Json;

namespace BG.Client.Services.GameService
{
    public class GameService : IGameService
    {
        private readonly HttpClient _httpClient;

        public GameService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public IEnumerable<Game> Games { get; set; } = new List<Game>();

        public async Task GetGames()
        {
            var response = 
                await _httpClient.GetFromJsonAsync<ServiceResponse<IEnumerable<Game>>>("api/Game");

            if (response?.Data != null)
            {
                Games = response.Data;
            }
        }
    }
}
