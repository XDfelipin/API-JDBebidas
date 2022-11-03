using Microsoft.EntityFrameworkCore;

namespace JDBEBIDASAPI.Model
{
    public class BebidasMap : DbContext
    {
        public BebidasMap(DbContextOptions<BebidasMap> options) : base(options)
        {
            Database.EnsureCreated();
        }

        public DbSet<Bebida> Bebidas { get; set; }
    }
}
