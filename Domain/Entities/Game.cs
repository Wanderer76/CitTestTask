using Shared.Domain;

namespace Domain.Entities
{
    public class Game : BaseEntity
    {
        public required string Name { get; set; }
        public required string Developer { get; set; }
        public List<Genre> Genres { get; set; } = new();

    }
}
