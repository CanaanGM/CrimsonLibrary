using CrimsonLibrary.Data.Models.Domain;

using System;
using System.Threading.Tasks;

namespace CrimsonLibrary.Data.IReopsitory
{
    public interface IUnitOfWork : IDisposable
    {
        IGenericRepository<Anime> Anime { get; }
        IGenericRepository<Book> Books { get; }
        IGenericRepository<BoughtItem> BoughtItems { get; }
        IGenericRepository<Exercise> Exercises { get; }
        IGenericRepository<Game> Games { get; }
        IGenericRepository<Manga> Manga { get; }
        IGenericRepository<MusicTrack> MusicTracks { get; }
        IGenericRepository<Workout_BodyBuilding> Workouts { get; }

        Task Save();
    }
}
