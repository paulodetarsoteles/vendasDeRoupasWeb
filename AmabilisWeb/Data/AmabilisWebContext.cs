using AmabilisWeb.Models;
using Microsoft.EntityFrameworkCore;

namespace AmabilisWeb.Data
{
    public class AmabilisWebContext : DbContext
    {
        public AmabilisWebContext(DbContextOptions<AmabilisWebContext> options) : base(options) { }
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Roupa> Roupas { get; set; }
    }
}