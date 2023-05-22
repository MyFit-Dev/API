using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using MyFit_API.Exceptions.GymException;
using MyFit_API.Exceptions.PlanException;
using MyFit_API.Exceptions.UserException;
using MyFit_API.Services;
using MyFit_Libs.Models;

namespace MyFit_API.Controllers
{

    [EnableCors("DefaultPolicy")]
    [ApiController]
    [Route("/api/User")]
    public class UserController : ControllerBase
    {
        private UserService _userService;

        public UserController(UserService userService)
        {
            this._userService = userService;
        }

        [Route("getAll")]
        [HttpGet]
        public IActionResult GetAllUsers()
        {
            return Ok(_userService.GetAllUsers());
        }

        [Route("countAll")]
        [HttpGet]
        public IActionResult CountAllUsers()
        {
            return Ok(_userService.CountUsers());
        }

        [Route("getById")]
        [HttpGet]
        public IActionResult GetUserById(long id)
        {
            try
            {
                User user = _userService.GetUserById(id);
                return Ok(user);

            }
            catch (UserNotFoundException ex)
            {
                return NotFound(ex.Message);
            }
        }

        [Route("getByMail")]
        [HttpGet]
        public IActionResult GetUserByMail(string mail)
        {
            try
            {
                User user = _userService.GetUserByMail(mail);
                return Ok(user);

            }
            catch (UserNotFoundException ex)
            {
                return NotFound(ex.Message);
            }
        }

        [Route("getPlan")]
        [HttpGet]
        public IActionResult GetUserPlan(long id)
        {
            try
            {
                Plan plan = _userService.GetUserPlan(id);
                return Ok(plan);

            }
            catch (PlanNotFoundException ex)
            {
                return NotFound(ex.Message);
            }
        }

        [Route("getGym")]
        [HttpGet]
        public IActionResult GetUserGym(long id)
        {
            try
            {
                Gym gym = _userService.GetUserGym(id);
                return Ok(gym);

            }
            catch (GymNotFoundException ex)
            {
                return NotFound(ex.Message);
            }
        }

        [Route("user/getFoodListOnDate")]
        [HttpGet]
        public IActionResult GetUserFoodListOnDate(long id, DateTime date)
        {
            string? foodList = _userService.GetUserFoodListOnDate(id, date);

            if (foodList == null)
                return NotFound();

            return Ok(foodList);
        }

        [Route("isOnIntermittentFasting")]
        [HttpGet]
        public IActionResult IsUserOnIntermittentFasting(long id)
        {
            bool intermittentFasting = _userService.IsUserOnIntermittentFasting(id);

            if (!intermittentFasting)
                return NotFound(intermittentFasting);
            else
                return Ok(intermittentFasting);
        }

        [Route("add")]
        [HttpPost]
        public IActionResult AddUser(User? user)
        {
            if (user == null)
                return BadRequest("{User} is null");

            try
            {
                _userService.AddUser(user);
                return Ok();
            }
            catch (UserAlredyFoundException ex)
            {
                return NotFound(ex.Message);
            }
        }

        [Route("setName")]
        [HttpPut]
        public IActionResult SetUserName(long id, string? name)
        {
            if (name == null)
                return BadRequest("{Name} is null");

            try
            {
                _userService.SetUserName(id, name);
                return Ok();
            }
            catch (UserNotFoundException ex)
            {
                return NotFound(ex.Message);
            }
        }

        [Route("setSurname")]
        [HttpPut]
        public IActionResult SetUserSurname(long id, string? surname)
        {
            if (surname == null)
                return BadRequest("{Surname} is null");

            try
            {
                _userService.SetUserSurname(id, surname);
                return Ok();
            }
            catch (UserNotFoundException ex)
            {
                return NotFound(ex.Message);
            }
        }

        [Route("setMail")]
        [HttpPut]
        public IActionResult SetUserMail(long id, string? mail)
        {
            if (mail == null)
                return BadRequest("{Mail} is null");

            try
            {
                _userService.SetUserMail(id, mail);
                return Ok();
            }
            catch (UserNotFoundException ex)
            {
                return NotFound(ex.Message);
            }
        }

        [Route("setState")]
        [HttpPut]
        public IActionResult SetUserState(long id, string? state)
        {
            if (state == null)
                return BadRequest("{State} is null");

            try
            {
                _userService.SetUserState(id, state);
                return Ok();
            }
            catch (UserNotFoundException ex)
            {
                return NotFound(ex.Message);
            }
        }

        [Route("setCity")]
        [HttpPut]
        public IActionResult SetUserCity(long id, string? city)
        {
            if (city == null)
                return BadRequest("{City} is null");

            try
            {
                _userService.SetUserCity(id, city);
                return Ok();
            }
            catch (UserNotFoundException ex)
            {
                return NotFound(ex.Message);
            }
        }

        [Route("setPlan")]
        [HttpPut]
        public IActionResult SetUserSurname(long id, int? idPlan)
        {
            if (idPlan == null || idPlan < 0)
                return BadRequest("{idPlan} is invalid");

            try
            {
                _userService.SetUserPlan(id, idPlan);
                return Ok();
            }
            catch (UserNotFoundException ex)
            {
                return NotFound(ex.Message);
            }
        }

        [Route("setGym")]
        [HttpPut]
        public IActionResult SetUserGym(long id, int? idGym)
        {

            try
            {
                _userService.SetUserGym(id, idGym);
                return Ok(idGym != null ? "Updated" : "Reset");
            }
            catch (UserNotFoundException ex)
            {
                return NotFound(ex.Message);
            }
        }

        [Route("setIntermittentFasting")]
        [HttpPut]
        public IActionResult SetUserIntermittentFasting(long id, bool? intermittentFasting)
        {
            if (intermittentFasting == null)
                return BadRequest("{IntermittentFasting} is invalid");

            try
            {
                _userService.SetUserIntermittentFasting(id, intermittentFasting);
                return Ok(intermittentFasting == true ? "Started" : "Stopped");
            }
            catch (UserNotFoundException ex)
            {
                return NotFound(ex.Message);
            }
        }

        [Route("deleteById")]
        [HttpDelete]
        public IActionResult DeleteUserById(long id)
        {
            try
            {
                _userService.DeleteUserById(id);
                return Ok();
            }
            catch (UserNotFoundException ex)
            {
                return NotFound(ex.Message);
            }
        }

        [Route("deleteByMail")]
        [HttpDelete]
        public IActionResult DeleteUserById(string? mail)
        {
            if (mail == null)
                return BadRequest("{Mail} is null");

            try
            {
                _userService.DeleteUserByMail(mail);
                return Ok();
            }
            catch (UserNotFoundException ex)
            {
                return NotFound(ex.Message);
            }
        }

    }
}
