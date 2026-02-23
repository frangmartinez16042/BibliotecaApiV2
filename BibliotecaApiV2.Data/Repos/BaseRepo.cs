using BibliotecaApiV2.Core.Data;

namespace BibliotecaApiV2.Data.Repos
{
    public abstract class BaseRepo<TKey, TEntity> : IBaseRepo<TKey, TEntity> where TEntity : class
    {
        protected readonly BibliotecaDbContext _context;

        public BaseRepo(BibliotecaDbContext context)
        {
            _context = context;
        }

        public abstract Task<TEntity?> GetByIdAsync(TKey id);

        public async Task SaveChangesAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}
