using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CrimsonLibrary.Migrations
{
    public partial class workout : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Tracks",
                table: "Tracks");

            migrationBuilder.RenameTable(
                name: "Tracks",
                newName: "MusicTracks");

            migrationBuilder.AddPrimaryKey(
                name: "PK_MusicTracks",
                table: "MusicTracks",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "Ecersise",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Reps = table.Column<double>(type: "float", nullable: false),
                    WeightKG = table.Column<double>(type: "float", nullable: false),
                    TimesDone = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ecersise", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BodyBuilding",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Week = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Part = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ExcersiseAId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ExcersiseBId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ExcersiseCId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ExcersiseDId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ExcersiseEId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ExcersiseFId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ExcersiseGId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Duration = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BodyBuilding", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BodyBuilding_Ecersise_ExcersiseAId",
                        column: x => x.ExcersiseAId,
                        principalTable: "Ecersise",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_BodyBuilding_Ecersise_ExcersiseBId",
                        column: x => x.ExcersiseBId,
                        principalTable: "Ecersise",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_BodyBuilding_Ecersise_ExcersiseCId",
                        column: x => x.ExcersiseCId,
                        principalTable: "Ecersise",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_BodyBuilding_Ecersise_ExcersiseDId",
                        column: x => x.ExcersiseDId,
                        principalTable: "Ecersise",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_BodyBuilding_Ecersise_ExcersiseEId",
                        column: x => x.ExcersiseEId,
                        principalTable: "Ecersise",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_BodyBuilding_Ecersise_ExcersiseFId",
                        column: x => x.ExcersiseFId,
                        principalTable: "Ecersise",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_BodyBuilding_Ecersise_ExcersiseGId",
                        column: x => x.ExcersiseGId,
                        principalTable: "Ecersise",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_BodyBuilding_ExcersiseAId",
                table: "BodyBuilding",
                column: "ExcersiseAId");

            migrationBuilder.CreateIndex(
                name: "IX_BodyBuilding_ExcersiseBId",
                table: "BodyBuilding",
                column: "ExcersiseBId");

            migrationBuilder.CreateIndex(
                name: "IX_BodyBuilding_ExcersiseCId",
                table: "BodyBuilding",
                column: "ExcersiseCId");

            migrationBuilder.CreateIndex(
                name: "IX_BodyBuilding_ExcersiseDId",
                table: "BodyBuilding",
                column: "ExcersiseDId");

            migrationBuilder.CreateIndex(
                name: "IX_BodyBuilding_ExcersiseEId",
                table: "BodyBuilding",
                column: "ExcersiseEId");

            migrationBuilder.CreateIndex(
                name: "IX_BodyBuilding_ExcersiseFId",
                table: "BodyBuilding",
                column: "ExcersiseFId");

            migrationBuilder.CreateIndex(
                name: "IX_BodyBuilding_ExcersiseGId",
                table: "BodyBuilding",
                column: "ExcersiseGId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BodyBuilding");

            migrationBuilder.DropTable(
                name: "Ecersise");

            migrationBuilder.DropPrimaryKey(
                name: "PK_MusicTracks",
                table: "MusicTracks");

            migrationBuilder.RenameTable(
                name: "MusicTracks",
                newName: "Tracks");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Tracks",
                table: "Tracks",
                column: "Id");
        }
    }
}
