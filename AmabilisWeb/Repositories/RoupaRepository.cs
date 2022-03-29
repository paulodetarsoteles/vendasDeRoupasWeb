using AmabilisWeb.Data;
using AmabilisWeb.Models;
using AmabilisWeb.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore; 

namespace AmabilisWeb.Repositories
{
    public class RoupaRepository : IRoupaRepository
    {
        private readonly AmabilisWebContext _context;

        public RoupaRepository(AmabilisWebContext context)
        {
            _context = context;
        }

        public IEnumerable<Roupa> Roupas => _context.Roupas
            .Include(c => c.Categoria);

        public IEnumerable<Roupa> RoupasFavoritas => _context.Roupas
            .Where(c => c.Favorito)
            .Include(c => c.Categoria);

        public Roupa GetRoupaById(int roupaId)
        {
            return _context.Roupas
                .FirstOrDefault(c => c.RoupaId == roupaId);
        }
    }
}