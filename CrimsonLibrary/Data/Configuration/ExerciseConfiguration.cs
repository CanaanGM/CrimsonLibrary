using CrimsonLibrary.Data.Models.Domain;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

using System;

namespace CrimsonLibrary.Data.Configuration
{
    public class ExerciseConfiguration : IEntityTypeConfiguration<Exercise>
    {
        public void Configure(EntityTypeBuilder<Exercise> builder)
        {
            builder.HasData(new Exercise
            {
                Name = "Squatted Calf Raise w/ Dumbbell",
                Description = "Done till failure",
                Sets = 4.0,
                Reps = "Failure",
                Type = "Legs"


            },
            new Exercise
            {
                Name = "Hip Thrusts + Sumo Deadlifts",
                Sets = 3,
                Reps = "50 reps / 20 reps",
                Type = "Legs"

            },
            new Exercise
            {
                Name = "GIANT SET - Slow High Bar Squat \"feet close\" + Dumbbell Sissy Squat \"lean back on the way up\" + Modified Pistol Squat + Extreme Sissy Squat",
                Sets = 3,
                Reps = "30 Reps / 20 Reps / 20 Reps Each / Failure",
                Type = "Legs"
            },
            new Exercise
            {
                Name = "Century Squats \"100 Reps\"",
                Sets = 2,
                Reps = "100",
                Type = "Legs"
            },
            new Exercise
            {
                Name = "180 Continuous Walking Lunges \"Long Stride / Drag Back Leg\"",
                Sets = 1,
                Reps = "180",
                Type = "Legs"
            });
        }
    }
}
