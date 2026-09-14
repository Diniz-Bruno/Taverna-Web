using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TavernaWeb.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class InitialMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Fichas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdUsuario = table.Column<int>(type: "int", nullable: false),
                    Sistema = table.Column<int>(type: "int", nullable: false),
                    CriadoEm = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Fichas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FichasOrdem",
                columns: table => new
                {
                    Idficha = table.Column<int>(type: "int", nullable: false),
                    Nex = table.Column<int>(type: "int", nullable: false, defaultValue: 5),
                    Vida = table.Column<int>(type: "int", nullable: false),
                    Pe = table.Column<int>(type: "int", nullable: false),
                    Nome = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    Classe = table.Column<int>(type: "int", nullable: false),
                    SubClasse = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Origem = table.Column<int>(type: "int", nullable: false),
                    Agilidade = table.Column<int>(type: "int", nullable: false, defaultValue: 0),
                    Forca = table.Column<int>(type: "int", nullable: false, defaultValue: 0),
                    Vigor = table.Column<int>(type: "int", nullable: false, defaultValue: 0),
                    Inteligencia = table.Column<int>(type: "int", nullable: false, defaultValue: 0),
                    Presenca = table.Column<int>(type: "int", nullable: false, defaultValue: 0)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FichasOrdem", x => x.Idficha);
                    table.ForeignKey(
                        name: "FK_FichasOrdem_Fichas_Idficha",
                        column: x => x.Idficha,
                        principalTable: "Fichas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Pericias",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Idficha = table.Column<int>(type: "int", nullable: false),
                    Nome = table.Column<int>(type: "int", nullable: false),
                    ValorBonus = table.Column<int>(type: "int", nullable: false, defaultValue: 0)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pericias", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Pericias_FichasOrdem_Idficha",
                        column: x => x.Idficha,
                        principalTable: "FichasOrdem",
                        principalColumn: "Idficha",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Poderes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Idficha = table.Column<int>(type: "int", nullable: false),
                    Nome = table.Column<string>(type: "nvarchar(420)", maxLength: 420, nullable: false),
                    CustoPe = table.Column<int>(type: "int", nullable: false, defaultValue: 0),
                    Descricao = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Poderes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Poderes_FichasOrdem_Idficha",
                        column: x => x.Idficha,
                        principalTable: "FichasOrdem",
                        principalColumn: "Idficha",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Fichas_IdUsuario",
                table: "Fichas",
                column: "IdUsuario");

            migrationBuilder.CreateIndex(
                name: "IX_Pericias_Idficha",
                table: "Pericias",
                column: "Idficha");

            migrationBuilder.CreateIndex(
                name: "IX_Poderes_Idficha",
                table: "Poderes",
                column: "Idficha");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Pericias");

            migrationBuilder.DropTable(
                name: "Poderes");

            migrationBuilder.DropTable(
                name: "FichasOrdem");

            migrationBuilder.DropTable(
                name: "Fichas");
        }
    }
}
