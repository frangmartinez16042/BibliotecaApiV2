using BibliotecaApiV2.Core;
using BibliotecaApiV2.Core.Data;

namespace BibliotecaApiV2.Data.Repos
{
    public class AuthorRepo : IAuthorRepo
    {
        private readonly BibliotecaDbContext _context;

        public AuthorRepo(BibliotecaDbContext context)
        {
            _context = context;
        }

        public async Task AddAsync(Author author)
        {
            await _context.AddAsync(author);
        }

        public async Task<Author?> GetById(string id)
        {
            return _context.Authors.FirstOrDefault(x => x.Id == id);
        }

        public async Task SaveChanges()
        {
            await _context.SaveChangesAsync();
        }
    }
}
