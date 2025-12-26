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
        public DateTime? LastAccessed { get; set; }
        public Technology Technology { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; } = null!;
        public List<Tag> Tags { get; set; } = new();
    }
}
