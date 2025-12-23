using System;
using System.Collections.Generic;
using System.Text;

namespace Snipcode.Core.Entities
{
    // Реалізовує відношення "багато-до-багатьох" Snippet (*) ---- (*) Tag
    public class Tag
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public List<Snippet> Snippets { get; set; } = new();
    }
}
