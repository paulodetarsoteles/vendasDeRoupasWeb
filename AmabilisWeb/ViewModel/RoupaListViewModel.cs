using AmabilisWeb.Models;

namespace AmabilisWeb.ViewModel
{
    public class RoupaListViewModel
    {
        public IEnumerable<Roupa> Roupas { get; set; }
        public string CategoriaAtual { get; set; }
    }
}