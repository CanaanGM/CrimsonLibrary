using System;

namespace CrimsonLibrary.Data.Models.Domain
{
    public class Anime
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
        public bool IsWatched { get; set; } = true;
        public DateTime DateReleased { get; set; }
        public DateTime DateWatched { get; set; }
    }
}
