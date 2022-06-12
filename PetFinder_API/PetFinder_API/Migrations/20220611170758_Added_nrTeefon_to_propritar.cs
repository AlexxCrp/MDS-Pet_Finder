using Microsoft.EntityFrameworkCore.Migrations;

namespace PetFinder_API.Migrations
{
    public partial class Added_nrTeefon_to_propritar : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "nrTelefon",
                table: "Proprietari",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "nrTelefon",
                table: "Proprietari");
        }
    }
}
