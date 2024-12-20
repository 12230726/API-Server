using Microsoft.AspNetCore.Mvc;
using OpenewsBackend.Models;
using OpenewsBackend.Services;

namespace OpenewsBackend.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AuthController : ControllerBase
    {
        private readonly IUserService _userService;

        public AuthController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login([FromBody] LoginRequest request)
        {
            if (await _userService.LoginAsync(request))
                return Ok(new { Message = "Login successful" });

            return Unauthorized(new { Message = "Invalid credentials" });
        }

        [HttpPost("signup")]
        public async Task<IActionResult> Signup([FromBody] User user)
        {
            if (await _userService.SignupAsync(user))
                return Ok(new { Message = "Signup successful" });

            return BadRequest(new { Message = "User already exists" });
        }
    }
}
