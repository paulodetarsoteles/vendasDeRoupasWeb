using AmabilisWeb.Data;
using AmabilisWeb.Models;
using AmabilisWeb.Repositories.Interfaces;

namespace AmabilisWeb.Repositories
{
    public class CategoriaRepository : ICategoriaRepository
    {
        private readonly AmabilisWebContext _context;

        public CategoriaRepository(AmabilisWebContext context)
        {
            _context = context;
        }

        public IEnumerable<Categoria> Categorias => _context.Categorias;
    }
}