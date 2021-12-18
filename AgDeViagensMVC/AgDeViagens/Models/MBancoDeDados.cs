using Microsoft.EntityFrameworkCore;

namespace AgDeViagens.Models
{
    public class MBancoDeDados : DbContext
    {
        public DbSet<Destino> Destinos {  get; set; }
        public DbSet<Promocao> Promocoes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(connectionString: @"Server=(localdb)\mssqllocaldb;Database=AgDeViagens4;Integrated Security=True");
        }
    }
}
