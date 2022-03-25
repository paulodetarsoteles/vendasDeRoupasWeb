using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AmabilisWeb.Models
{
    [Table("Roupas")]
    public class Roupa
    {
        public int RoupaId { get; set; }
        [Required(ErrorMessage ="Campo Obrigatório")]
        [Display(Name ="Nome da Roupa")]
        public string Nome { get; set; }
        [Required(ErrorMessage = "Campo Obrigatório")]
        [MaxLength(3, ErrorMessage ="Digite P, M, G ou a Idade")]
        public string Tamanho { get; set; }
        [Required(ErrorMessage = "Campo Obrigatório")]
        [Display(Name ="Descrição")]
        public string Descricao { get; set; }
        [Required(ErrorMessage = "Campo Obrigatório")]
        public double Preco { get; set; }
        public string ImgUrl { get; set; }
        public string ImgThUrl { get; set; }
        public bool Favorito { get; set; }
        public bool Disponivel { get; set; }
        [Required]
        public int CategoriaId { get; set; } 
        public virtual Categoria Categoria { get; set; } 
    }
}