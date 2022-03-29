using AmabilisWeb.Models;

namespace AmabilisWeb.Repositories.Interfaces
{
    public interface IRoupaRepository
    {
        IEnumerable<Roupa> Roupas { get;  }
        IEnumerable<Roupa> RoupasFavoritas { get; }
        Roupa GetRoupaById(int roupaId); 
    }
}