using System;

namespace CrimsonLibrary.Data.Models.Dtos
{
    public class MangaCreateDto
    {
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
        public double Chapters { get; set; } = 1;
        public bool Completed { get; set; } = false;
        public bool ReadToFinish { get; set; } = true;
        public bool IsReading { get; internal set; }
    }

    public class MangaDto : MangaCreateDto
    {
        public Guid Id { get; set; }

        // database specific
        public DateTime DateModified { get; set; } = DateTime.UtcNow;

        public DateTime DateAddedToDatabase { get; } = DateTime.UtcNow;
    }
}