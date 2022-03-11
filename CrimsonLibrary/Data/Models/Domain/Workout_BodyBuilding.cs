using CrimsonLibrary.Data.Models.JoinTables;

using System;
using System.Collections.Generic;

namespace CrimsonLibrary.Data.Models.Domain
{
    public class Workout_BodyBuilding
    {
        public Guid Id { get; set; }
        public string Week { get; set; }
        public string Part { get; set; }
        public string CycleType { get; set; } // scientific name goes here
        public List<Workout_Exercise> Excersises { get; set; }
        public double Duration { get; set; }
        public string Day { get; internal set; }
    }


}
