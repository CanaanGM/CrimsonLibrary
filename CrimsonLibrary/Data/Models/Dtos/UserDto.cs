using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CrimsonLibrary.Data.Models.Dtos
{
    public class UserLoginDto
    {
        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [StringLength(15, ErrorMessage = "Password should be between 2 and 15 characters.")]
        public string Password { get; set; }

    }
    public class UserDto : UserLoginDto
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public ICollection<string> Roles { get; set; }

       
    }
}
