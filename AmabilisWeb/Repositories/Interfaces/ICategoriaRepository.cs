using AmabilisWeb.Models;

namespace AmabilisWeb.Repositories.Interfaces
{
    public interface ICategoriaRepository
    {
        IEnumerable<Categoria> Categorias { get;  }
    }
}