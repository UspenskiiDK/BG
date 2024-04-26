namespace BG.Shared
{
    public class Game
    {
        public string Id { get; set; } = String.Empty;
        public string Title { get; set; } = String.Empty;
        public string Description { get; set; } = String.Empty;
        public string ImageUrl { get; set; } = String.Empty;
        public int MaxPlayers { get; set; }
        public int Price { get; set; }
    }
}
