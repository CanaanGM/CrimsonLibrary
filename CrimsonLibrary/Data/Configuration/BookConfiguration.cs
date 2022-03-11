using CrimsonLibrary.Data.Models.Domain;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

using System;

namespace CrimsonLibrary.Data.Configuration
{
    public class BookConfiguration : IEntityTypeConfiguration<Book>
    {
        public void Configure(EntityTypeBuilder<Book> builder)
        {
            builder.HasData(new Book
            {
                Name = "Horus Rising",
                Description = "Horus rises",
                CoverImage = "NONE",
                Genre = "Science fiction",
                Authors = "Dan Abbnet",
                Rating = 8.9F,
                IsRead = true,
                Consumed = new DateTime(2013, 07, 13),
                DatePublished = new DateTime(2006, 04, 25),
            },
            new Book
            {
                Name = "Fulgrim",
                Description = "Fulgrim",
                CoverImage = "NONE",
                Genre = "Science fiction",
                Authors = "Dan Abbnet",
                Rating = 9.5F,
                IsRead = true,
                Consumed = new DateTime(2013, 08, 13),
                DatePublished = new DateTime(2007, 07, 02),
            },
            new Book
            {
                Name = "The Lord of the Rings",
                Description = "epic journey",
                CoverImage = "NONE",
                Authors = "J.R.R Tolkin",
                Genre = "Fiction",
                Rating = 0F,
                IsRead = false,
                DatePublished = new DateTime(1954, 07, 29)
             }
            );
        }
    }
}