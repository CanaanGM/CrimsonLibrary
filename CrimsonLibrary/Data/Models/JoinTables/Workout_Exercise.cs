using CrimsonLibrary.Data.Models.Domain;

using System;

namespace CrimsonLibrary.Data.Models.JoinTables
{
    public class Workout_Exercise
    {
        public Guid Id { get; set; }
        public Guid Workout_Id { get; set; }
        public Guid Excercise_Id { get; set; }

        public Workout_BodyBuilding Workout { get; set; }
        public Exercise Exercise { get; set; }
    }
}
