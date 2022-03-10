using System;

namespace CrimsonLibrary.Data.Models.Domain
{
    public class Command
    {
        public Guid Id { get; set; }
        public string Title { get; set; } = "";
        public string Description { get; set; } = "";
        public DateTime DateModified { get; set; }
        public DateTime DateAddedToDatabase { get; set; }
        public string Platform { get; set; } = "";
        public int ImportanceLevel { get; set; }

    }
}
