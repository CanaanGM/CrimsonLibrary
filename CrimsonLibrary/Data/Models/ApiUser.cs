using Microsoft.AspNetCore.Identity;

namespace CrimsonLibrary.Data.Models
{
    public class ApiUser : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

    }
}
