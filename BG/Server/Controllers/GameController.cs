using BG.Server.Configuration;
using BG.Server.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using MongoDB.Driver;

namespace BG.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GameController : ControllerBase
    {
        private readonly MongoDbContext _context;

        public GameController(IOptions<MongoConfiguration> configuration)
        {
            _context = new MongoDbContext(configuration);
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Game>>> Get()
        {
            var games = await _context.GetGamesCollection.Find(item => true).ToListAsync();
            return Ok(games);
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] Game game)
        {
            await _context.GetGamesCollection.InsertOneAsync(game);
            return CreatedAtAction("Get", new { id = game.Id }, game);
        }
    }
}
