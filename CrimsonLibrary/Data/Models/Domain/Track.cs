using System;

namespace CrimsonLibrary.Data.Models.Domain
{
    public class Track
    {

        public Guid Id { get; set; }
        public string Title { get; set; } = "";
        public string Description { get; set; } = "";
        public DateTime DateModified { get; set; }
        public DateTime DateAddedToDatabase { get; set; }
        public string CoverImage { get; set; } = "";
        public string Genre { get; set; } = "";
        public string SubGenres { get; set; } = "";
        public float Rating { get; set; } = 0;
        public string Artists { get; set; } = "";
        public DateTime DateReleased { get; set; }
    }
}
