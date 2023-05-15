using Microsoft.AspNetCore.Mvc;
using MyFit_API.Services;
using MyFit_Libs.Models;

namespace MyFit_API.Controllers
{

    [ApiController]
    [Route("/api/User")]
    public class UserController : ControllerBase
    {
        private UserService _userService;

        public UserController(UserService userService)
        {
            this._userService = userService;
        }

        [Route("getUserById")]
        [HttpGet]
        public IActionResult GetUserById(long id)
        {
            User user = _userService.GetUserById(id);

            if (user == null)
            {
                return NotFound("User not found");
            }

            return Ok(user);
        }


    }
}
