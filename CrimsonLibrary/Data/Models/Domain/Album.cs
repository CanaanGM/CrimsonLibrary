
using System;

namespace CrimsonLibrary.Data.Models.Domain
{
    public class Album
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Url { get; set; }
        public string Image { get; set; }
    }
}
