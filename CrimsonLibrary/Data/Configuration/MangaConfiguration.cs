using CrimsonLibrary.Data.Models.Domain;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

using System;

namespace CrimsonLibrary.Data.Configuration
{
    public class MangaConfiguration : IEntityTypeConfiguration<Manga>
    {
        public void Configure(EntityTypeBuilder<Manga> builder)
        {
            builder.HasData(new Manga
            {
                Name = "Kengan Omega",
                CoverImage = "None",
                Description = "Successor series to Kengan Azura",
                Authors = "Daromeon",
                Artists = "Daromeon",
                Genre = "Martial arts",
                SubGenres = "Action, Drama",
                IsReading = true,
                Completed = false,
                Rating = 9,
                DatePublished = new DateTime(2019)
            },
            new Manga
            {
                Name = "Berserk",
                CoverImage = "None",
                Description = "Gats and friends",
                Authors = "Kintarou miora",
                Artists = "Kintarou miora",
                Genre = "Fantasy",
                SubGenres = "Action, Drama",
                IsReading = true,
                Completed = false,
                Rating = 9,
                DatePublished = new DateTime(2019)
            },
            new Manga
            {
                Name = "Shuumatsu no Valkyrie",
                CoverImage = "None",
                Description = "Successor series to Kengan Azura",
                Authors = "Fukui takumi",
                Artists = "Fukui takumi",
                Genre = "Martial arts",
                SubGenres = "Action, Drama",
                IsReading = true,
                Completed = false,
                Rating = 9,
                DatePublished = new DateTime(2019)
            });
        }
    }
}
