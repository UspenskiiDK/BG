using BG.Server.Configuration;
using BG.Server.Data;
using BG.Server.Services.GameService.Interfaces;
using Microsoft.Extensions.Options;
using MongoDB.Driver;

namespace BG.Server.Services.GameService
{
    public class GameService : IGameService
    {
        private readonly MongoDbContext _context;

        public GameService(IOptions<MongoConfiguration> configuration)
        {
            _context = new MongoDbContext(configuration);
        }

        public async Task<ServiceResponse<Game>> GetGameAsync(string gameId)
        {
            var response = new ServiceResponse<Game>();
            var game = await _context.GetGamesCollection.Find(item => item.Id == gameId).FirstOrDefaultAsync();

            if (game == null)
            {
                response.Success = false;
                response.Message = "Извините, по вашему запросу не найдено игры";
            }
            else
            {
                response.Data = game;
            }

            return response;
        }

        public async Task<ServiceResponse<IEnumerable<Game>>> GetGamesAsync()
        {
            var response = new ServiceResponse<IEnumerable<Game>>
            {
                Data = await _context.GetGamesCollection.Find(item => true).ToListAsync()
            };

            return response;
        }
    }
}
