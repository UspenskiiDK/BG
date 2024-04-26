using BG.Server.Configuration;
using Microsoft.Extensions.Options;
using MongoDB.Driver;

namespace BG.Server.Data
{
    public class MongoDbContext
    {
        private readonly IMongoDatabase _database;

        public MongoDbContext(IOptions<MongoConfiguration> configuration)
        {
            var client = new MongoClient(configuration.Value.ConnectionString);
            _database = client.GetDatabase(configuration.Value.DataBaseName);
        }

        public IMongoCollection<Game> GetGamesCollection => _database.GetCollection<Game>("Games");
    }
}
