using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CrimsonLibrary.Migrations
{
    public partial class workoutRelations : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BodyBuilding_Ecersise_ExcersiseAId",
                table: "BodyBuilding");

            migrationBuilder.DropForeignKey(
                name: "FK_BodyBuilding_Ecersise_ExcersiseBId",
                table: "BodyBuilding");

            migrationBuilder.DropForeignKey(
                name: "FK_BodyBuilding_Ecersise_ExcersiseCId",
                table: "BodyBuilding");

            migrationBuilder.DropForeignKey(
                name: "FK_BodyBuilding_Ecersise_ExcersiseDId",
                table: "BodyBuilding");

            migrationBuilder.DropForeignKey(
                name: "FK_BodyBuilding_Ecersise_ExcersiseEId",
                table: "BodyBuilding");

            migrationBuilder.DropForeignKey(
                name: "FK_BodyBuilding_Ecersise_ExcersiseFId",
                table: "BodyBuilding");

            migrationBuilder.DropForeignKey(
                name: "FK_BodyBuilding_Ecersise_ExcersiseGId",
                table: "BodyBuilding");

            migrationBuilder.DropTable(
                name: "Ecersise");

            migrationBuilder.DropIndex(
                name: "IX_BodyBuilding_ExcersiseAId",
                table: "BodyBuilding");

            migrationBuilder.DropIndex(
                name: "IX_BodyBuilding_ExcersiseBId",
                table: "BodyBuilding");

            migrationBuilder.DropIndex(
                name: "IX_BodyBuilding_ExcersiseCId",
                table: "BodyBuilding");

            migrationBuilder.DropIndex(
                name: "IX_BodyBuilding_ExcersiseDId",
                table: "BodyBuilding");

            migrationBuilder.DropIndex(
                name: "IX_BodyBuilding_ExcersiseEId",
                table: "BodyBuilding");

            migrationBuilder.DropIndex(
                name: "IX_BodyBuilding_ExcersiseFId",
                table: "BodyBuilding");

            migrationBuilder.DropIndex(
                name: "IX_BodyBuilding_ExcersiseGId",
                table: "BodyBuilding");

            migrationBuilder.DropColumn(
                name: "ExcersiseAId",
                table: "BodyBuilding");

            migrationBuilder.DropColumn(
                name: "ExcersiseBId",
                table: "BodyBuilding");

            migrationBuilder.DropColumn(
                name: "ExcersiseCId",
                table: "BodyBuilding");

            migrationBuilder.DropColumn(
                name: "ExcersiseDId",
                table: "BodyBuilding");

            migrationBuilder.DropColumn(
                name: "ExcersiseEId",
                table: "BodyBuilding");

            migrationBuilder.DropColumn(
                name: "ExcersiseFId",
                table: "BodyBuilding");

            migrationBuilder.DropColumn(
                name: "ExcersiseGId",
                table: "BodyBuilding");

            migrationBuilder.AddColumn<string>(
                name: "CycleType",
                table: "BodyBuilding",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Exercises",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Picture = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Reps = table.Column<double>(type: "float", nullable: false),
                    WeightKG = table.Column<double>(type: "float", nullable: false),
                    TimesDone = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Exercises", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Workout_Exercises",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Workout_Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Excercise_Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Workout_Exercises", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Workout_Exercises_BodyBuilding_Excercise_Id",
                        column: x => x.Excercise_Id,
                        principalTable: "BodyBuilding",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Workout_Exercises_Exercises_Workout_Id",
                        column: x => x.Workout_Id,
                        principalTable: "Exercises",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Workout_Exercises_Excercise_Id",
                table: "Workout_Exercises",
                column: "Excercise_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Workout_Exercises_Workout_Id",
                table: "Workout_Exercises",
                column: "Workout_Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Workout_Exercises");

            migrationBuilder.DropTable(
                name: "Exercises");

            migrationBuilder.DropColumn(
                name: "CycleType",
                table: "BodyBuilding");

            migrationBuilder.AddColumn<Guid>(
                name: "ExcersiseAId",
                table: "BodyBuilding",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "ExcersiseBId",
                table: "BodyBuilding",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "ExcersiseCId",
                table: "BodyBuilding",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "ExcersiseDId",
                table: "BodyBuilding",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "ExcersiseEId",
                table: "BodyBuilding",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "ExcersiseFId",
                table: "BodyBuilding",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "ExcersiseGId",
                table: "BodyBuilding",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Ecersise",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Reps = table.Column<double>(type: "float", nullable: false),
                    TimesDone = table.Column<int>(type: "int", nullable: false),
                    WeightKG = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ecersise", x => x.Id);
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

            migrationBuilder.AddForeignKey(
                name: "FK_BodyBuilding_Ecersise_ExcersiseAId",
                table: "BodyBuilding",
                column: "ExcersiseAId",
                principalTable: "Ecersise",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_BodyBuilding_Ecersise_ExcersiseBId",
                table: "BodyBuilding",
                column: "ExcersiseBId",
                principalTable: "Ecersise",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_BodyBuilding_Ecersise_ExcersiseCId",
                table: "BodyBuilding",
                column: "ExcersiseCId",
                principalTable: "Ecersise",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_BodyBuilding_Ecersise_ExcersiseDId",
                table: "BodyBuilding",
                column: "ExcersiseDId",
                principalTable: "Ecersise",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_BodyBuilding_Ecersise_ExcersiseEId",
                table: "BodyBuilding",
                column: "ExcersiseEId",
                principalTable: "Ecersise",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_BodyBuilding_Ecersise_ExcersiseFId",
                table: "BodyBuilding",
                column: "ExcersiseFId",
                principalTable: "Ecersise",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_BodyBuilding_Ecersise_ExcersiseGId",
                table: "BodyBuilding",
                column: "ExcersiseGId",
                principalTable: "Ecersise",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
