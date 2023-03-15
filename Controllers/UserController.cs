using Microsoft.AspNetCore.Mvc;
using Text_Adventure_2.Data;
using Text_Adventure_2.Models;
using Text_Adventure_2.Services.UserService;

namespace Text_Adventure_2.Controllers

     
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet]
        public async Task<ActionResult<List<User>>> GetAllUsers()
        {
            return Ok(await _userService.GetAllUsers());
        }

        [HttpGet("login")]
        public async Task<ActionResult<User>> LoginUser(string username, string password)
        {
            var tryUserLogin = await _userService.LoginUser(username, password);

            return Ok(tryUserLogin);
        }

    }
}
