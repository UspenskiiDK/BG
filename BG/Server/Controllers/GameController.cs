using BG.Server.Configuration;
using BG.Server.Data;
using BG.Server.Services.GameService.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using MongoDB.Driver;
using System.Collections;

namespace BG.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GameController : ControllerBase
    {
        private readonly IGameService _gameService;

        public GameController(IGameService gameService)
        {
            _gameService = gameService;
        }

        [HttpGet]
        public async Task<ActionResult<ServiceResponse<IEnumerable<Game>>>> Get()
        {
            var response = await _gameService.GetGamesAsync();
            
            return Ok(response);
        }

        //[HttpPost]
        //public async Task<IActionResult> Post([FromBody] Game game)
        //{
        //    await _context.GetGamesCollection.InsertOneAsync(game);
        //    return CreatedAtAction("Get", new { id = game.Id }, game);
        //}

        //[HttpGet("{id}")]
        //public async Task<ActionResult<Game>> Get(string id)
        //{
        //    var game = await _context.GetGamesCollection.Find(item => item.Id == id).FirstOrDefaultAsync();

        //    if (game == null)
        //    {
        //        return NotFound();
        //    }

        //    return Ok(game);
        //}

        //[HttpPut("{id}")]
        //public async Task<IActionResult> Put(string id, [FromBody] Game game)
        //{
        //    var gameDb = await _context.GetGamesCollection.Find(item => item.Id == id).FirstOrDefaultAsync();

        //    if (gameDb == null)
        //    {
        //        return NotFound();
        //    }

        //    game.Id = gameDb.Id;
        //    await _context.GetGamesCollection.ReplaceOneAsync(item => item.Id == id, game);
        //    return NoContent();
        //}

        //[HttpDelete("{id}")]
        //public async Task<IActionResult> Delete(string id)
        //{
        //    var game = await _context.GetGamesCollection.Find(item => item.Id == id).FirstOrDefaultAsync();

        //    if (game == null)
        //    {
        //        return NotFound();
        //    }

        //    await _context.GetGamesCollection.DeleteOneAsync(item => item.Id == id);
        //    return NoContent();
        //}
    }
}
