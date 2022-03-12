using AutoMapper;

using CrimsonLibrary.Data.Models;
using CrimsonLibrary.Data.Models.Dtos;
using CrimsonLibrary.Services;

using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

using System.Threading.Tasks;

namespace CrimsonLibrary.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AccountController : ControllerBase
    {
        private readonly UserManager<ApiUser> _userManager;
        private readonly ILogger<AccountController> _logger;
        private readonly IMapper _mapper;
        private readonly IAuthManager _authManager;

        public AccountController(
            UserManager<ApiUser> userManager, ILogger<AccountController> logger, IMapper mapper, IAuthManager authManager)
        {
            _userManager = userManager;
            _logger = logger;
            _mapper = mapper;
            _authManager = authManager;
        }

        [HttpPost]
        [Route("register")]
        public async Task<IActionResult> Register([FromBody] UserDto userDto)
        {
            _logger.LogInformation($"Registeration attempt for {userDto.Email} ");

            if (!ModelState.IsValid) return BadRequest(ModelState);

            var user = _mapper.Map<ApiUser>(userDto);
            user.UserName = user.Email;
            var res = await _userManager.CreateAsync(user, userDto.Password);
            if (!res.Succeeded)
            {
                return BadRequest($"Registeration went wrong, please try again later. \n {res.Errors}");
            }
            await _userManager.AddToRolesAsync(user, userDto.Roles);
            return Accepted();
        }

        [HttpPost]
        [Route("login")]
        public async Task<IActionResult> LogIn([FromBody] UserLoginDto userDto)
        {
            _logger.LogInformation($"Log-in attempt for {userDto.Email} ");

            if (!ModelState.IsValid) return BadRequest(ModelState);

            if (!await _authManager.ValidateUser(userDto)) return Unauthorized(userDto);

            return Accepted(new { Token = await _authManager.CreateToken() });
        }
    }
}