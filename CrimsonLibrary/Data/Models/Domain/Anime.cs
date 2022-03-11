namespace CrimsonLibrary.Data.Models.Domain
{
    public class Anime : BaseEntity
    {
        public string FaveCharacter { get; set; } = string.Empty ;
        public bool IsWatched { get; set; } = true ;
        public bool OnGoing { get; set; } = false;


    }
}
