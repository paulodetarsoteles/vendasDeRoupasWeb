using System.ComponentModel.DataAnnotations;

namespace AmabilisWeb.Models
{
    public class CarrinhoCompraItem
    {
        public int CarrinhoCompraItemId { get; set; }
        public Roupa Roupa { get; set; }
        public int Quantidade { get; set; }
        [StringLength(200)]
        public string CarrinhoCompraId { get; set; }
    }
}
