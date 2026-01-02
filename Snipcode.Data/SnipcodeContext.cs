using Microsoft.EntityFrameworkCore;
using Snipcode.Core.Entities;

namespace Snipcode.Data
{
    public class SnipcodeContext : DbContext
    {
        // Тут я визначаю DbSet для кожної сутності в Snipcode.Core
        public DbSet<Snippet> Snippets { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public SnipcodeContext(DbContextOptions<SnipcodeContext> options) : base(options) { }

        // Тут я описую зв'язки між сутностями
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Налаштування зв'язку Один-до-Багатьох (Category --- Snippets)
            modelBuilder.Entity<Snippet>()
                .HasOne(s => s.Category)
                .WithMany(c => c.Snippets)
                .HasForeignKey(s => s.CategoryId)
                .OnDelete(DeleteBehavior.Cascade); // Якщо видалити категорію, видаляться і сніпети

            // Налаштування зв'язку Багато-до-Багатьох (Snippet --- Tags)
            modelBuilder.Entity<Snippet>()
                .HasMany(s => s.Tags)
                .WithMany(t => t.Snippets)
                .UsingEntity(j => j.ToTable("SnippetTags")); // Явна назва проміжної таблиці
        }
    }
}
