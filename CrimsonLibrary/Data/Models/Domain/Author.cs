using System;

namespace CrimsonLibrary.Data.Models.Domain
{
    public class Author
    {
        public Guid Id { get; set; }
        public string Name { get; set; }

        public string Url { get; set; }
    }
}
