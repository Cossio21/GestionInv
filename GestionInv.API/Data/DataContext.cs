using GestionInv.Shared.Entidades;
using Microsoft.EntityFrameworkCore;

namespace GestionInv.API.Data
{
    public class DataContext: DbContext
    {
        public DataContext(DbContextOptions<DataContext>options) : base(options) {

        }

        public DbSet<Investigador> Investigadors { get; set; }

        protected override void OnModelCreating (ModelBuilder modelBuilder)
        {
            base.OnModelCreating (modelBuilder);
            modelBuilder.Entity<Investigador>().HasIndex(c => c.Nombre).IsUnique();
        }
    }
}
