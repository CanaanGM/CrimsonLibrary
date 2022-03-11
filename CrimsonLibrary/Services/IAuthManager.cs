using CrimsonLibrary.Data.Models.Dtos;

using System.Threading.Tasks;

namespace CrimsonLibrary.Services
{
    public interface IAuthManager
    {
        Task<bool> ValidateUser(UserLoginDto userDto);
        Task<string> CreateToken();
    }
}
