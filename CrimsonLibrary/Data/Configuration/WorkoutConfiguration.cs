using CrimsonLibrary.Data.Models.Domain;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

using System.Collections.Generic;
using System;

namespace CrimsonLibrary.Data.Configuration
{
    public class WorkoutConfiguration : IEntityTypeConfiguration<Workout_BodyBuilding>
    {
        public void Configure(EntityTypeBuilder<Workout_BodyBuilding> builder)
        {
            builder.HasData(new Workout_BodyBuilding
            {
                Week = "4: By Any Means Necessary",
                Day = "5",
                Part = "Leg",
                Duration = 2.5,
                CycleType = "FUCK",
                Excersises = new List<Exercise>()

            });
        }
    }
}
