using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace Sithec.Humano.Dominio.cnContext
{
    public partial class HDbContext : DbContext
    {
        public HDbContext()
        {
        }

        public HDbContext(DbContextOptions<HDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Humano> Humanos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("server = FINLPT0074\\SQL2016; database = DBHUMANO; User Id = sa; Password = FINASIST; timeout = 900; Current language = español;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Modern_Spanish_CI_AS");

            modelBuilder.Entity<Humano>(entity =>
            {
                entity.ToTable("Humano");

                entity.Property(e => e.Altura).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(70);

                entity.Property(e => e.Peso).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Sexo)
                    .IsRequired()
                    .HasMaxLength(1);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
