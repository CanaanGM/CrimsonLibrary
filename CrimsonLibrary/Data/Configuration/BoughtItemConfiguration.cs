using CrimsonLibrary.Data.Models.Domain;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CrimsonLibrary.Data.Configuration
{
    public class BoughtItemConfiguration : IEntityTypeConfiguration<BoughtItem>
    {
        public void Configure(EntityTypeBuilder<BoughtItem> builder)
        {
            builder.HasData(
                new BoughtItem
                {
                    Name = "Elden Ring",
                    Price_Dollar = 60,
                    Price_JOD = 38.851,
                    DateBought = new System.DateTime(2022, 2, 24),
                    Description = "Elden ring the game",
                    Quantity = 1,
                    StoreBoughtFrom = "CD Keys via PayPall",
                    Tags = "Game"
                }
                );
        }
    }
}
