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

        public List<Game> Games { get; set; } = new List<Game>();
        public Game Game { get; set; } = new Game();

        public async Task<ServiceResponse<Game>> GetGame(string id)
        {
            var response =
                await _httpClient.GetFromJsonAsync<ServiceResponse<Game>>($"api/Game/{id}");

            return response;
        }

        public async Task GetGames()
        {
            var response = 
                await _httpClient.GetFromJsonAsync<ServiceResponse<List<Game>>>("api/Game");

            if (response?.Data != null)
            {
                Games = response.Data;
            }
        }
    }
}
