using CrimsonLibrary.Data.Models.Domain;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

using System;

namespace CrimsonLibrary.Data.Configuration
{
    public class AnimeConfiguration : IEntityTypeConfiguration<Anime>
    {
        public void Configure(EntityTypeBuilder<Anime> builder)
        {
            builder.HasData(
                  new Anime
                  {
                      Id = new Guid(),
                      Name = "Canaan",
                      Description = "Canaan and stuff",
                      CoverImage = "None",
                      Genre = "Action",
                      SubGenres = "Action, Comedy",
                      Rating = 9,
                      IsWatched = true,
                      Consumed = new DateTime(2011, 09, 14),
                      DatePublished = new DateTime(2009, 07, 04)
                  },

                new Anime
                {
                    Id = new Guid(),
                    Name = "Log Horizon",
                    Description = "Databse Database oo ooh~!",
                    CoverImage = "None",
                    Genre = "Action",
                    SubGenres = "Action, Comedy",
                    Rating = 9,
                    IsWatched = true,
                    Consumed = new DateTime(2013, 10, 05),
                    DatePublished = new DateTime(2013, 10, 05)
                },

                new Anime
                {
                    Id = new Guid(),
                    Name = "Hellsing",
                    Description = "Canaan and stuff",
                    CoverImage = "空",
                    Genre = "Action",
                    SubGenres = "Action, Comedy",
                    Rating = 9,
                    IsWatched = false,
                    Consumed = new DateTime(2014, 09, 14),
                    DatePublished = new DateTime(2001, 10, 10)
                }

           );
        }
    }
}
