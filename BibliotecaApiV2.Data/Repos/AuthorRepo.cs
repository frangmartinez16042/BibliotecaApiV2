using BibliotecaApiV2.Core;
using BibliotecaApiV2.Core.Data;
using Microsoft.EntityFrameworkCore;

namespace BibliotecaApiV2.Data.Repos
{
    public class AuthorRepo : BaseRepo<string, Author>, IAuthorRepo
    {
        public AuthorRepo(BibliotecaDbContext context) : base(context)
        {
        }

        public async Task AddAsync(Author author)
        {
            await _context.AddAsync(author);
        }

        public async Task<Author?> GetById(string id)
        {
            return _context.Authors.FirstOrDefault(x => x.Id == id);
        }

        public async override Task<Author?> GetByIdAsync(string id)
        {
            return await _context.Authors.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task SaveChanges()
        {
            await _context.SaveChangesAsync();
        }
    }
}
