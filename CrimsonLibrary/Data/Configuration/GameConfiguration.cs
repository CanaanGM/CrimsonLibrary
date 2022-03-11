using CrimsonLibrary.Data.Models.Domain;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

using System;

namespace CrimsonLibrary.Data.Configuration
{
    public class GameConfiguration : IEntityTypeConfiguration<Game>
    {
        public void Configure(EntityTypeBuilder<Game> builder)
        {
            builder.HasData(new Game
            {
                Name = " Monster hunter wolrd",
                DonePlaying = false,
                IsPlaying = true,
                Description = "Most Awesome monster hunter game",
                Genre = "Action",
                CoverImage = String.Empty,
                Series = "Monster Hunter",
                Tags = "monster hunter, hack'n'slash",
                IsFavorite = true,
                SubGenres = "Action, Adventure, RPG",
                Rating = 9,
                DatePublished = new DateTime(2018, 8, 9),
                Authors = "Capcom"

            },
            new Game
            {
                Name = " Devil may cry 4 se",
                DonePlaying = true,
                IsPlaying = false,
                Description = "best styled devil may cry game",
                Genre = "Action",
                CoverImage = String.Empty,
                Series = "Devil may cry",
                Tags = "devil may cry, hack'n'slash",
                IsFavorite = true,
                SubGenres = "Action, Adventure, RPG",
                Rating = 9,
                DatePublished = new DateTime(2015, 2, 23),
                Authors = "Capcom"

            }
          );
        }
    }
}
