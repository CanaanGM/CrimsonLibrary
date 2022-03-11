using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CrimsonLibrary.Migrations
{
    public partial class simplifiedEvenMore : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CoverImage",
                table: "BoughtItems");

            migrationBuilder.DropColumn(
                name: "Genre",
                table: "BoughtItems");

            migrationBuilder.DropColumn(
                name: "SubGenres",
                table: "BoughtItems");

            migrationBuilder.RenameColumn(
                name: "Favorite",
                table: "Tracks",
                newName: "IsFavorite");

            migrationBuilder.RenameColumn(
                name: "FaveTrack",
                table: "Tracks",
                newName: "Series");

            migrationBuilder.RenameColumn(
                name: "Favorite",
                table: "Manga",
                newName: "IsFavorite");

            migrationBuilder.RenameColumn(
                name: "Favorite",
                table: "Games",
                newName: "IsFavorite");

            migrationBuilder.RenameColumn(
                name: "Favorite",
                table: "Books",
                newName: "IsRead");

            migrationBuilder.RenameColumn(
                name: "Favorite",
                table: "Anime",
                newName: "IsFavorite");

            migrationBuilder.AddColumn<string>(
                name: "Artists",
                table: "Tracks",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Authors",
                table: "Tracks",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "Consumed",
                table: "Tracks",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<double>(
                name: "ConsumedTimes",
                table: "Tracks",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<DateTime>(
                name: "DatePublished",
                table: "Tracks",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<double>(
                name: "Rating",
                table: "Tracks",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<DateTime>(
                name: "Consumed",
                table: "Manga",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<double>(
                name: "ConsumedTimes",
                table: "Manga",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<DateTime>(
                name: "DatePublished",
                table: "Manga",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<double>(
                name: "Rating",
                table: "Manga",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<string>(
                name: "Artists",
                table: "Games",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Authors",
                table: "Games",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "Consumed",
                table: "Games",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<double>(
                name: "ConsumedTimes",
                table: "Games",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<DateTime>(
                name: "DatePublished",
                table: "Games",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<double>(
                name: "Rating",
                table: "Games",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<string>(
                name: "Series",
                table: "Games",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Artists",
                table: "Books",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Authors",
                table: "Books",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "Consumed",
                table: "Books",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<double>(
                name: "ConsumedTimes",
                table: "Books",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<DateTime>(
                name: "DatePublished",
                table: "Books",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<bool>(
                name: "IsFavorite",
                table: "Books",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<double>(
                name: "Rating",
                table: "Books",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<string>(
                name: "Artists",
                table: "Anime",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Authors",
                table: "Anime",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "Consumed",
                table: "Anime",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<double>(
                name: "ConsumedTimes",
                table: "Anime",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<DateTime>(
                name: "DatePublished",
                table: "Anime",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<double>(
                name: "Rating",
                table: "Anime",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<string>(
                name: "Series",
                table: "Anime",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Artists",
                table: "Tracks");

            migrationBuilder.DropColumn(
                name: "Authors",
                table: "Tracks");

            migrationBuilder.DropColumn(
                name: "Consumed",
                table: "Tracks");

            migrationBuilder.DropColumn(
                name: "ConsumedTimes",
                table: "Tracks");

            migrationBuilder.DropColumn(
                name: "DatePublished",
                table: "Tracks");

            migrationBuilder.DropColumn(
                name: "Rating",
                table: "Tracks");

            migrationBuilder.DropColumn(
                name: "Consumed",
                table: "Manga");

            migrationBuilder.DropColumn(
                name: "ConsumedTimes",
                table: "Manga");

            migrationBuilder.DropColumn(
                name: "DatePublished",
                table: "Manga");

            migrationBuilder.DropColumn(
                name: "Rating",
                table: "Manga");

            migrationBuilder.DropColumn(
                name: "Artists",
                table: "Games");

            migrationBuilder.DropColumn(
                name: "Authors",
                table: "Games");

            migrationBuilder.DropColumn(
                name: "Consumed",
                table: "Games");

            migrationBuilder.DropColumn(
                name: "ConsumedTimes",
                table: "Games");

            migrationBuilder.DropColumn(
                name: "DatePublished",
                table: "Games");

            migrationBuilder.DropColumn(
                name: "Rating",
                table: "Games");

            migrationBuilder.DropColumn(
                name: "Series",
                table: "Games");

            migrationBuilder.DropColumn(
                name: "Artists",
                table: "Books");

            migrationBuilder.DropColumn(
                name: "Authors",
                table: "Books");

            migrationBuilder.DropColumn(
                name: "Consumed",
                table: "Books");

            migrationBuilder.DropColumn(
                name: "ConsumedTimes",
                table: "Books");

            migrationBuilder.DropColumn(
                name: "DatePublished",
                table: "Books");

            migrationBuilder.DropColumn(
                name: "IsFavorite",
                table: "Books");

            migrationBuilder.DropColumn(
                name: "Rating",
                table: "Books");

            migrationBuilder.DropColumn(
                name: "Artists",
                table: "Anime");

            migrationBuilder.DropColumn(
                name: "Authors",
                table: "Anime");

            migrationBuilder.DropColumn(
                name: "Consumed",
                table: "Anime");

            migrationBuilder.DropColumn(
                name: "ConsumedTimes",
                table: "Anime");

            migrationBuilder.DropColumn(
                name: "DatePublished",
                table: "Anime");

            migrationBuilder.DropColumn(
                name: "Rating",
                table: "Anime");

            migrationBuilder.DropColumn(
                name: "Series",
                table: "Anime");

            migrationBuilder.RenameColumn(
                name: "Series",
                table: "Tracks",
                newName: "FaveTrack");

            migrationBuilder.RenameColumn(
                name: "IsFavorite",
                table: "Tracks",
                newName: "Favorite");

            migrationBuilder.RenameColumn(
                name: "IsFavorite",
                table: "Manga",
                newName: "Favorite");

            migrationBuilder.RenameColumn(
                name: "IsFavorite",
                table: "Games",
                newName: "Favorite");

            migrationBuilder.RenameColumn(
                name: "IsRead",
                table: "Books",
                newName: "Favorite");

            migrationBuilder.RenameColumn(
                name: "IsFavorite",
                table: "Anime",
                newName: "Favorite");

            migrationBuilder.AddColumn<string>(
                name: "CoverImage",
                table: "BoughtItems",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Genre",
                table: "BoughtItems",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SubGenres",
                table: "BoughtItems",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
