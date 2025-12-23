using Snipcode.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Snipcode.Data.Interfaces
{
    public interface ISnipcodeDataService
    {
        Task AddSnippetAsync(Snippet snippet);
        Task<List<Snippet>> GetAllSnippetsAsync();
        Task UpdateSnippetAsync(Snippet snippet);
        Task DeleteSnippetAsync(int id);
    }
}
