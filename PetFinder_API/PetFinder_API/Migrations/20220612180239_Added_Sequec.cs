using Microsoft.EntityFrameworkCore.Migrations;

namespace PetFinder_API.Migrations
{
    public partial class Added_Sequec : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateSequence(
                name: "IdSequence");

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "Pets",
                type: "nvarchar(450)",
                nullable: false,
                defaultValueSql: "NEXT VALUE FOR IdSequence",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropSequence(
                name: "IdSequence");

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "Pets",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldDefaultValueSql: "NEXT VALUE FOR IdSequence");
        }
    }
}
