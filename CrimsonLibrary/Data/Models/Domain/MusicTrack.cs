namespace CrimsonLibrary.Data.Models.Domain
{
    public class MusicTrack : BaseEntity
    {
        public string Album { get; set; }
        public double TracksNum { get; set; }
        public string Band { get; set; }

    }
}
