using System;

namespace CrimsonLibrary.Data.Models.Domain
{
    public class Wishlist
    {

        public Guid Id { get; set; }
        public string Title { get; set; } = "";
        public string Description { get; set; } = "";
        public DateTime DateModified { get; set; }
        public DateTime DateAddedToDatabase { get; set; }


        public double Price { get; set; }
        public string URL { get; set; } = "";
        public string Category { get; set; } = "";

    }
}
