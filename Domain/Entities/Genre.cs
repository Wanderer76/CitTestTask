using Shared.Domain;

namespace Domain.Entities
{
    public class Genre : BaseEntity
    {
        public required string Name { get; set; }
        public List<Game> Games { get; set; } = new();
    }
}
