using System.ComponentModel.DataAnnotations.Schema;

namespace AmabilisWeb.Models
{
    [Table("Categorias")]
    public class Categoria
    {
        public int CategoriaId { get; set; }
        public string CategoriaNome { get; set; }
        public List<Roupa> Roupas { get; set; }
    }
}