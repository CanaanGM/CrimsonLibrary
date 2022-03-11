using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CrimsonLibrary.Migrations
{
    public partial class animeMany2Manyauthors : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "anime_Authors",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Anime_Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Author_Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_anime_Authors", x => x.Id);
                    table.ForeignKey(
                        name: "FK_anime_Authors_Anime_Author_Id",
                        column: x => x.Author_Id,
                        principalTable: "Anime",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_anime_Authors_Authors_Anime_Id",
                        column: x => x.Anime_Id,
                        principalTable: "Authors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_anime_Authors_Anime_Id",
                table: "anime_Authors",
                column: "Anime_Id");

            migrationBuilder.CreateIndex(
                name: "IX_anime_Authors_Author_Id",
                table: "anime_Authors",
                column: "Author_Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "anime_Authors");
        }
    }
}
