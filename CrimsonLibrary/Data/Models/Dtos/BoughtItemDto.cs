using System;

namespace CrimsonLibrary.Data.Models.Dtos
{
    public class BoughtItemCreateDto
    {
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string Tags { get; set; } = string.Empty;// separated by ,

        public double Quantity { get; set; } = 1.0;
        public string Price { get; set; } = "50 $"; // depending on the sign convert curreny
        public double Price_Dollar { get; set; }
        public double Price_JOD { get; set; }
        public string Recipt { get; set; } // will be an image
        public string StoreBoughtFrom { get; set; }
        public DateTime DateBought { get; set; }
    }

    public class BoughtItemDto : BoughtItemCreateDto
    {
        public Guid Id { get; set; }

        // database specific
        public DateTime DateModified { get; set; } = DateTime.UtcNow;

        public DateTime DateAddedToDatabase { get; } = DateTime.UtcNow;
    }
}