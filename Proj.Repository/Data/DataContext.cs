using Microsoft.EntityFrameworkCore;
using Proj.Domain.Entities;

namespace Proj.Repository.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        public DbSet<ContaLuz> ContasLuz { get; set; }
        public DbSet<Imovel> Imoveis { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Imovel>()
                .HasMany<ContaLuz>(i => i.contasLuz)
                .WithOne(c => c.imovel)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}