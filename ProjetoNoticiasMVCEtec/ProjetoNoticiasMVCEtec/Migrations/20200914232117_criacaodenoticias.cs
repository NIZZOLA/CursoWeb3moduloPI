using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ProjetoNoticiasMVCEtec.Migrations
{
    public partial class criacaodenoticias : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Noticias",
                columns: table => new
                {
                    NoticiaId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Titulo = table.Column<string>(maxLength: 100, nullable: true),
                    DataDaInclusao = table.Column<DateTime>(nullable: false),
                    Descricao = table.Column<string>(nullable: true),
                    NomeDaImagem = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Noticias", x => x.NoticiaId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Noticias");
        }
    }
}
