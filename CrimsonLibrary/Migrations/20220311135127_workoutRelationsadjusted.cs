using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CrimsonLibrary.Migrations
{
    public partial class workoutRelationsadjusted : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Workout_Exercises_BodyBuilding_Excercise_Id",
                table: "Workout_Exercises");

            migrationBuilder.DropForeignKey(
                name: "FK_Workout_Exercises_Exercises_Workout_Id",
                table: "Workout_Exercises");

            migrationBuilder.DropIndex(
                name: "IX_Workout_Exercises_Excercise_Id",
                table: "Workout_Exercises");

            migrationBuilder.DropIndex(
                name: "IX_Workout_Exercises_Workout_Id",
                table: "Workout_Exercises");

            migrationBuilder.AddColumn<Guid>(
                name: "ExerciseId",
                table: "Workout_Exercises",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "WorkoutId",
                table: "Workout_Exercises",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "Workout_BodyBuildingId",
                table: "Exercises",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Workout_Exercises_ExerciseId",
                table: "Workout_Exercises",
                column: "ExerciseId");

            migrationBuilder.CreateIndex(
                name: "IX_Workout_Exercises_WorkoutId",
                table: "Workout_Exercises",
                column: "WorkoutId");

            migrationBuilder.CreateIndex(
                name: "IX_Exercises_Workout_BodyBuildingId",
                table: "Exercises",
                column: "Workout_BodyBuildingId");

            migrationBuilder.AddForeignKey(
                name: "FK_Exercises_BodyBuilding_Workout_BodyBuildingId",
                table: "Exercises",
                column: "Workout_BodyBuildingId",
                principalTable: "BodyBuilding",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Workout_Exercises_BodyBuilding_WorkoutId",
                table: "Workout_Exercises",
                column: "WorkoutId",
                principalTable: "BodyBuilding",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Workout_Exercises_Exercises_ExerciseId",
                table: "Workout_Exercises",
                column: "ExerciseId",
                principalTable: "Exercises",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Exercises_BodyBuilding_Workout_BodyBuildingId",
                table: "Exercises");

            migrationBuilder.DropForeignKey(
                name: "FK_Workout_Exercises_BodyBuilding_WorkoutId",
                table: "Workout_Exercises");

            migrationBuilder.DropForeignKey(
                name: "FK_Workout_Exercises_Exercises_ExerciseId",
                table: "Workout_Exercises");

            migrationBuilder.DropIndex(
                name: "IX_Workout_Exercises_ExerciseId",
                table: "Workout_Exercises");

            migrationBuilder.DropIndex(
                name: "IX_Workout_Exercises_WorkoutId",
                table: "Workout_Exercises");

            migrationBuilder.DropIndex(
                name: "IX_Exercises_Workout_BodyBuildingId",
                table: "Exercises");

            migrationBuilder.DropColumn(
                name: "ExerciseId",
                table: "Workout_Exercises");

            migrationBuilder.DropColumn(
                name: "WorkoutId",
                table: "Workout_Exercises");

            migrationBuilder.DropColumn(
                name: "Workout_BodyBuildingId",
                table: "Exercises");

            migrationBuilder.CreateIndex(
                name: "IX_Workout_Exercises_Excercise_Id",
                table: "Workout_Exercises",
                column: "Excercise_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Workout_Exercises_Workout_Id",
                table: "Workout_Exercises",
                column: "Workout_Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Workout_Exercises_BodyBuilding_Excercise_Id",
                table: "Workout_Exercises",
                column: "Excercise_Id",
                principalTable: "BodyBuilding",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Workout_Exercises_Exercises_Workout_Id",
                table: "Workout_Exercises",
                column: "Workout_Id",
                principalTable: "Exercises",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
