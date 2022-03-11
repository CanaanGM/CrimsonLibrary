using System;

namespace CrimsonLibrary.Data.Models.Domain
{
    public class Book : BaseEntity
    {
        public bool IsRead { get; set; } = true;
        public double Pages { get; set; } = 0;
    }
}
