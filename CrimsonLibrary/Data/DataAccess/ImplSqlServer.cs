using CrimsonLibrary.Data.Models.Domain;

using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CrimsonLibrary.Data.DataAccess
{
    public class ImplSqlServer : IDbContext
    {
        public ImplSqlServer(DatabaseContext databaseContext)
        {
            _databaseContext = databaseContext;
        }

        public DatabaseContext _databaseContext { get; }

        public async Task<Game> CreateNewGame(Game game)
        {
            var newGame = game;
            if (newGame == null) return null;

            _databaseContext.Games.Add(newGame);
           await _databaseContext.SaveChangesAsync();
            return newGame;
        }

        public List<Game> GetAllGames()
        {
            return _databaseContext.Games.ToList();
        }
    }
}
