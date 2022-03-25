namespace AmabilisWeb.Models
{
    public class Roupa
    {
        public int RoupaId { get; set; }
        public string Nome { get; set; }
        public string Tamanho { get; set; }
        public string Descricao { get; set; }
        public double Preco { get; set; }
        public string ImgUrl { get; set; }
        public string ImgThUrl { get; set; }
        public bool Favorito { get; set; }
        public bool Disponivel { get; set; }
        public int CategoriaId { get; set; } //ForeignKey da Relacao
        public virtual Categoria Categoria { get; set; } //Relacao com a classe categoria (um pra muitos)
    }
}