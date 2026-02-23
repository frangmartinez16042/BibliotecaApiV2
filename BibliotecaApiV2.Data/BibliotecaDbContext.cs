using BibliotecaApiV2.Core;
using Microsoft.EntityFrameworkCore;

namespace BibliotecaApiV2.Data
{
    public class BibliotecaDbContext : DbContext
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="options"></param>
        public BibliotecaDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Author> Authors { get; set; }
    }
}
