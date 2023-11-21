using API_REST.Entities;
using Microsoft.EntityFrameworkCore;

namespace API_REST
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions options): base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Query> Queries => Set<Query>();
    }
}
