using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PetFinder_API.Migrations
{
    public partial class Added_Image_Entity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Poza",
                table: "Pets");

            migrationBuilder.CreateTable(
                name: "Imagine",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    PetId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Poza = table.Column<byte[]>(type: "varbinary(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Imagine", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Imagine_Pets_PetId",
                        column: x => x.PetId,
                        principalTable: "Pets",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Imagine_PetId",
                table: "Imagine",
                column: "PetId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Imagine");

            migrationBuilder.AddColumn<string>(
                name: "Poza",
                table: "Pets",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
