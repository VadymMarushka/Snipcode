using Microsoft.EntityFrameworkCore;
using Snipcode.Core.Entities;
using Snipcode.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Snipcode.Data.Services
{
    // CRUD-сервіс для роботи з сутностями з SnipcodeContext
    public class SnipcodeDataService : ISnipcodeDataService
    {
        private readonly IDbContextFactory<SnipcodeContext> _contextFactory;
        public SnipcodeDataService(IDbContextFactory<SnipcodeContext> contextFactory)
        {
            _contextFactory = contextFactory;
        }
        // CREATE
        public async Task AddSnippetAsync(Snippet snippet)
        {
            using var context = await _contextFactory.CreateDbContextAsync();
            context.Snippets.Add(snippet);
            await context.SaveChangesAsync();
        }

        // READ
        public async Task<List<Snippet>> GetAllSnippetsAsync()
        {
            using var context = await _contextFactory.CreateDbContextAsync();
            return await context.Snippets
                .Include(s => s.Category) // відбувається через описаний у SnipetContext OnModelCreating зв'язок
                .Include(s => s.Tags) // аналогічно підтягне теги через ту проміжну таблицю в БД
                .AsNoTracking() // Ця штука покращує продуктивність при читанні, коли не планується оновлення
                                // EF core за замовчуванням відстежує зміни у завантажених сутностях, що додає накладні витрати
                .ToListAsync(); // Зводжу ло списку
        }
        public async Task<Snippet?> GetSnippetByIdAsync(int id)
        {
            using var context = await _contextFactory.CreateDbContextAsync();

            var snippet = await context.Snippets
                .Include(s => s.Category)
                .Include(s => s.Tags)
                .FirstOrDefaultAsync(s => s.Id == id);

            if (snippet != null)
            {
                snippet.LastAccessed = DateTime.Now;
                await context.SaveChangesAsync();
            }

            return snippet;
        }
        // Get Recently Opened Snippets
        public async Task<List<Snippet>> GetRecentlyOpenedAsync(int count = 10)
        {
            using var context = await _contextFactory.CreateDbContextAsync();

            return await context.Snippets
                .Where(s => s.LastAccessed != null)       // Тільки ті, що відкривались
                .OrderByDescending(s => s.LastAccessed)   // Спочатку найновіші
                .Take(count)                              // Беремо перші 10
                .Include(s => s.Category)
                .AsNoTracking()
                .ToListAsync();
        }
        // UPDATE
        public async Task UpdateSnippetAsync(Snippet snippet)
        {
            using var context = await _contextFactory.CreateDbContextAsync();
            context.Snippets.Update(snippet);
            await context.SaveChangesAsync();
        }

        // DELETE
        public async Task DeleteSnippetAsync(int id)
        {
            using var context = await _contextFactory.CreateDbContextAsync();
            var snippet = await context.Snippets.FindAsync(id);
            if (snippet != null)
            {
                context.Snippets.Remove(snippet);
                await context.SaveChangesAsync();
            }
        }
        // CATEGORIES
        public async Task<List<Category>> GetAllCategoriesAsync()
        {
            using var context = await _contextFactory.CreateDbContextAsync();
            return await context.Categories.AsNoTracking().ToListAsync();
        }

        public async Task AddCategoryAsync(Category category)
        {
            using var context = await _contextFactory.CreateDbContextAsync();
            context.Categories.Add(category);
            await context.SaveChangesAsync();
        }

        // TAGS
        public async Task<List<Tag>> GetAllTagsAsync()
        {
            using var context = await _contextFactory.CreateDbContextAsync();
            return await context.Tags.AsNoTracking().ToListAsync();
        }

        public async Task AddTagAsync(Tag tag)
        {
            using var context = await _contextFactory.CreateDbContextAsync();
            var existingTag = await context.Tags.FirstOrDefaultAsync(t => t.Name == tag.Name);
            if (existingTag == null)
            {
                context.Tags.Add(tag);
                await context.SaveChangesAsync();
            }
        }
    }
}
