using Microsoft.EntityFrameworkCore;
using Sithec.Humano.Persistencia.Config;

namespace Sithec.Humano.Persistencia
{
    public class AppDbContext : DbContext
    {
        public AppDbContext() { }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {}

        public DbSet<Sithec.Humano.Persistencia.Models.Humano> Humano { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) 
        {
            if (!optionsBuilder.IsConfigured)
                optionsBuilder.UseSqlServer(@"server = FINLPT0074\SQL2016; database = DBHUMANO; User Id = sa; Password = FINASIST; timeout = 900; Current language = español; ");
        }

        protected override void OnModelCreating(ModelBuilder builder) 
        {
            base.OnModelCreating(builder);

            new HumanoConfig(builder.Entity<Sithec.Humano.Persistencia.Models.Humano>());
        }
    }
}
