using System;
using System.Collections.Generic;
using System.Text;

namespace Snipcode.Core.Entities
{
    // Реалізовує відношення "один-до-багатьох" Category (1) ---- (*) Snippet 
    public class Category
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public List<Snippet> Snippets { get; set; } = new();
    }
}
