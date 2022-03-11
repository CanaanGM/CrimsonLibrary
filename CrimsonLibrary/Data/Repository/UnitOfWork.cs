using CrimsonLibrary.Data.DataAccess;
using CrimsonLibrary.Data.IReopsitory;
using CrimsonLibrary.Data.Models.Domain;

using System;
using System.Threading.Tasks;

namespace CrimsonLibrary.Data.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly DatabaseContext _databaseContext;

        private IGenericRepository<Anime> _anime;
        private IGenericRepository<Book> _books;
        private IGenericRepository<BoughtItem> _boughtItems;
        private IGenericRepository<Exercise> _exercises;
        private IGenericRepository<Game> _games;
        private IGenericRepository<Manga> _manga;
        private IGenericRepository<MusicTrack> _musicTracks;
        private IGenericRepository<Workout_BodyBuilding> _workouts;

        public UnitOfWork(DatabaseContext databaseContext)
        {
            _databaseContext = databaseContext;
        }

        public IGenericRepository<Anime> Anime => _anime ??= new GenericRepository<Anime>(_databaseContext);
        public IGenericRepository<Book> Books => _books ??= new GenericRepository<Book>(_databaseContext);
        public IGenericRepository<BoughtItem> BoughtItems => _boughtItems ??= new GenericRepository<BoughtItem>(_databaseContext);
        public IGenericRepository<Exercise> Exercises => _exercises ??= new GenericRepository<Exercise>(_databaseContext);
        public IGenericRepository<Game> Games => _games ??= new GenericRepository<Game>(_databaseContext);
        public IGenericRepository<Manga> Manga => _manga ??= new GenericRepository<Manga>(_databaseContext);
        public IGenericRepository<MusicTrack> MusicTracks => _musicTracks ??= new GenericRepository<MusicTrack>(_databaseContext);
        public IGenericRepository<Workout_BodyBuilding> Workouts => _workouts ??= new GenericRepository<Workout_BodyBuilding>(_databaseContext);


        public void Dispose()
        {
            _databaseContext.Dispose();
            GC.SuppressFinalize(this);
        }

        public async Task Save()
        {
           await _databaseContext.SaveChangesAsync();
        }
    }
}
