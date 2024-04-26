using MongoDB.Bson.Serialization.Attributes;

namespace BG.Shared
{
    public class Game
    {
        [BsonId]
        [BsonRepresentation(MongoDB.Bson.BsonType.ObjectId)]
        public string Id { get; set; }
        public string Title { get; set; } = String.Empty;
        public string Description { get; set; } = String.Empty;
        public string ImageUrl { get; set; } = String.Empty;
        public int MaxPlayers { get; set; }
        public int Price { get; set; }
    }
}
