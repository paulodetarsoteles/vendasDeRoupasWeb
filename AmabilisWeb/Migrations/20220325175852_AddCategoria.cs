using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AmabilisWeb.Migrations
{
    public partial class AddCategoria : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Categorias(CategoriaNome) VALUES('Vestido')");
            migrationBuilder.Sql("INSERT INTO Categorias(CategoriaNome) VALUES('Camisa')");
            migrationBuilder.Sql("INSERT INTO Categorias(CategoriaNome) VALUES('Short')");
            migrationBuilder.Sql("INSERT INTO Categorias(CategoriaNome) VALUES('Macacao')");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE * FROM Categorias");
        }
    }
}
