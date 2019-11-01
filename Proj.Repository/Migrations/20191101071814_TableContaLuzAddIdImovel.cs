using Microsoft.EntityFrameworkCore.Migrations;

namespace Proj.Repository.Migrations
{
    public partial class TableContaLuzAddIdImovel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "idimovel",
                table: "ContasLuz",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "idimovel",
                table: "ContasLuz");
        }
    }
}
