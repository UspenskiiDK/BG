using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BG.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GameController : ControllerBase
    {
        private static List<Game> games = new List<Game>
        {
            new Game
            {
                Id = new Guid(),
                Title = "Спящие боги",
                Description = "Игра спящие логи описание",
                ImageUrl = "https://hobbygames.ru/image/cache/hobbygames_beta/data/Lavka_Games/Spyashie_Bogi/spyashye_bogi-1024x1024-wm.JPG",
                MaxPlayers = 2,
                Price = 3000
            },
            new Game
            {
                Id = new Guid(),
                Title = "Ужас Аркхэма",
                Description = "Ужас Аркхэма описание",
                ImageUrl = "https://hobbygames.ru/image/cache/hobbygames_beta/data/HobbyWorld/Arkham_Horror/3rd_edition/AH_3ed_box_3D_roznica-1024x1024-wm.jpg",
                MaxPlayers = 4,
                Price = 6000
            },
            new Game
            {
                Id = new Guid(),
                Title = "Манчкин",
                Description = "Бей друзей Бери Сокровища",
                ImageUrl = "https://hobbygames.ru/image/cache/hobbygames_beta/data/HobbyWorld/Munchkin/Munchkin/Munchkin00-1024x1024-wm.jpg",
                MaxPlayers = 2,
                Price = 1000
            }
        };

        [HttpGet]
        public async Task<ActionResult<List<Game>>> GetGames()
        {
            return Ok(games);
        }
    }
}
