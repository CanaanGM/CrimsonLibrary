using System;

namespace CrimsonLibrary.Data.Models.Dtos
{
    public class BookCreateDto
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
        public bool IsRead { get; set; } = true;
        public double Pages { get; set; } = 0;
    }

    public class BookDto : BookCreateDto
    {
        public Guid Id { get; set; }

        // database specific
        public DateTime DateModified { get; set; } = DateTime.UtcNow;

        public DateTime DateAddedToDatabase { get; } = DateTime.UtcNow;
    }
}