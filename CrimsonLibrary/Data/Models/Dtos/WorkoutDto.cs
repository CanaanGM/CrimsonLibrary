using CrimsonLibrary.Data.Models.JoinTables;
using System.Collections.Generic;
using System;

namespace CrimsonLibrary.Data.Models.Dtos
{


    public class WorkoutCreateDto
    {
        public string Week { get; set; }
        public string Part { get; set; }
        public string CycleType { get; set; } // scientific name goes here
        public virtual IList<ExerciseDto> Excersises { get; set; }
        public double Duration { get; set; }
        public string Day { get; internal set; }

    }

    public class WorkoutDto : WorkoutCreateDto
    {
        public Guid Id { get; set; }
    }
}
