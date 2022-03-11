namespace CrimsonLibrary.Data.Models.Domain
{
    public class Manga : BaseEntity
    {

        public string FaveCharacter { get; set; }   = string.Empty ;
        public double Chapters { get; set; } = 1;
        public bool Completed { get; set; } = false;
        public bool ReadToFinish { get; set; } = true;
        public bool IsReading { get; internal set; }
    }
}
