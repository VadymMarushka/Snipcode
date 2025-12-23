namespace Snipcode.Core.Entities
{
    // Це головний клас для збереження фрагментів коду
    public class Snippet
    {
        public int Id { get; set; }
        public required string Title { get; set; }
        public string Description { get; set; } = string.Empty;
        public required string Code { get; set; }
        public DateOnly CreatedAt { get; set; } = DateOnly.FromDateTime(DateTime.Now);
        public int CategoryId { get; set; }
        public Category Category { get; set; } = null!;
        public List<Tag> Tags { get; set; } = new();
    }
}
