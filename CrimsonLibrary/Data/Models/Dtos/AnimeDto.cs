using System;
using System.ComponentModel.DataAnnotations;

namespace CrimsonLibrary.Data.Models.Dtos
{
    public class AnimeDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string CoverImage { get; set; } = string.Empty; // for now a string
        public string Genre { get; set; } = string.Empty;
        public string SubGenres { get; set; } = string.Empty; // separated by ,
        public string Tags { get; set; } = string.Empty;// separated by ,

        public string Authors { get; set; } = string.Empty; // separated by ,
        public string Artists { get; set; } = string.Empty; // separated by ,

        public string Series { get; set; } = string.Empty;

        public bool IsFavorite { get; set; } = true;

        public double Rating { get; set; } = 0.0;
        public double ConsumedTimes { get; set; } = 1.0;// read 10 times and 1/2

        public DateTime Consumed { get; set; } // read / watched/ listend
        public DateTime DatePublished { get; set; }

        // database specific
        public DateTime DateModified { get; set; } = DateTime.UtcNow;
        public DateTime DateAddedToDatabase { get; } = DateTime.UtcNow;

        public string FaveCharacter { get; set; } = string.Empty;
        public bool IsWatched { get; set; } = true;
        public bool OnGoing { get; set; } = false;
    }

    public class AnimeCreateDto
    {
        [Required]
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string CoverImage { get; set; } = string.Empty; // for now a string
        public string Genre { get; set; } = string.Empty;
        public string SubGenres { get; set; } = string.Empty; // separated by ,
        public string Tags { get; set; } = string.Empty;// separated by ,
        public string Authors { get; set; } = string.Empty; // separated by ,
        public string Artists { get; set; } = string.Empty; // separated by ,
        public string Series { get; set; } = string.Empty;
        public bool IsFavorite { get; set; } = true;
        public double Rating { get; set; } = 0.0;
        public double ConsumedTimes { get; set; } = 1.0;// read 10 times and 1/2
        public DateTime Consumed { get; set; } // read / watched/ listend
        public DateTime DatePublished { get; set; }
        public string FaveCharacter { get; set; } = string.Empty;
        public bool IsWatched { get; set; } = true;
        public bool OnGoing { get; set; } = false;

    }
}
