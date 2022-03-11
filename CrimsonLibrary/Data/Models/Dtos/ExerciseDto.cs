using System;
using System.Collections.Generic;

namespace CrimsonLibrary.Data.Models.Dtos
{
    public class ExerciseCreateDto
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Reps { get; set; }
        public string Picture { get; set; }
        public string Type { get; set; }
        public double Sets { get; internal set; }
        public double WeightKG { get; set; }
        public int TimesDone { get; set; }
    }

    public class ExerciseDto : ExerciseCreateDto
    {
        public Guid Id { get; set; }
        public virtual IList<WorkoutDto> Workouts { get; set; }
    }
}