
using System;
using System.Collections.Generic;

namespace CrimsonLibrary.Data.Models.Domain
{
    public class Game : BaseEntity
    {
        public string FaveCahracter { get; set; } = string.Empty;
        public bool IsPlaying { get; set; } = false;
        public bool DonePlaying { get; set; } = true;

    }
}
