using CrimsonLibrary.Data.Models.Domain;

using System.Collections.Generic;
using System.Threading.Tasks;

namespace CrimsonLibrary.Data.DataAccess
{
    public interface IDbContext
    {

        public List<Game> GetAllGames();
        public Task<Game> CreateNewGame(Game game);
    }
}
