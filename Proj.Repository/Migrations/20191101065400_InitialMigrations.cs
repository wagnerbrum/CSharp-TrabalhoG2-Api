using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace Proj.Repository.Migrations
{
    public partial class InitialMigrations : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Imoveis",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    identificacao = table.Column<string>(nullable: true),
                    numero = table.Column<string>(nullable: true),
                    bairro = table.Column<string>(nullable: true),
                    cidade = table.Column<string>(nullable: true),
                    estado = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Imoveis", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "ContasLuz",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    dataLeitura = table.Column<DateTime>(nullable: false),
                    dataPagamento = table.Column<DateTime>(nullable: false),
                    kwGasto = table.Column<int>(nullable: false),
                    valorAPagar = table.Column<double>(nullable: false),
                    mediaConsumo = table.Column<double>(nullable: false),
                    imovelid = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContasLuz", x => x.id);
                    table.ForeignKey(
                        name: "FK_ContasLuz_Imoveis_imovelid",
                        column: x => x.imovelid,
                        principalTable: "Imoveis",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ContasLuz_imovelid",
                table: "ContasLuz",
                column: "imovelid");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ContasLuz");

            migrationBuilder.DropTable(
                name: "Imoveis");
        }
    }
}
