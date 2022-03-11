using CrimsonLibrary.Data.Models.Domain;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

using System;

namespace CrimsonLibrary.Data.Configuration
{
    public class MusicTrackConfiguration : IEntityTypeConfiguration<MusicTrack>
    {
        public void Configure(EntityTypeBuilder<MusicTrack> builder)
        {
            builder.HasData(new MusicTrack
            {
                Name = "Go One's own way",
                Description = "Best track in Ken's Rage 2",
                Genre = "Metal",
                Rating = 10,
                SubGenres = "Melodic Death metal, Instrumental",
                CoverImage = "None",
                IsFavorite = true
            },
            new MusicTrack
            {
                Name = "デスリパ666",
                Description = "Ninja Slayer anime soundtrack",
                Genre = "Metal",
                SubGenres = "Heavy Death Metal, Instrumantal",
                CoverImage = "None",
                Rating = 10,
                IsFavorite = true
            });
        }
    }
}
