using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AmabilisWeb.Migrations
{
    public partial class AddRoupas : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Roupas(Nome, Tamanho, Descricao, Preco, Favorito, Disponivel, CategoriaId) VALUES('Vestido 3 Cores', '4', 'Vestido azul amarelo e rosa', 80, 1, 1, 1)");
            migrationBuilder.Sql("INSERT INTO Roupas(Nome, Tamanho, Descricao, Preco, Favorito, Disponivel, CategoriaId) VALUES('Camisa Bordada', '2', 'Camisa com arco iris', 50, 0, 1, 2)");
            migrationBuilder.Sql("INSERT INTO Roupas(Nome, Tamanho, Descricao, Preco, Favorito, Disponivel, CategoriaId) VALUES('Short Com Pregas', '6', 'Short zul com preguinhas', 50, 1, 0, 3)");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE * FROM Poupas");
        }
    }
}
