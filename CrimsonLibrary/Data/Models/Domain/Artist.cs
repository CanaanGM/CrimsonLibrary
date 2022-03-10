using System;

namespace CrimsonLibrary.Data.Models.Domain
{
    public class Artist
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Url { get; set; }
        public string Image { get; set; }
        // works -> M2M with books/tracks/manga/movies
    }
}
