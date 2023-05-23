using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using MyFit_API.Exceptions.ExerciseException;
using MyFit_API.Services;
using MyFit_Libs.Models;

namespace MyFit_API.Controllers
{
    [EnableCors]
    [ApiController]
    [Route("/api/CustomExercise")]
    public class CustomExerciseController : ControllerBase
    {

        private CustomExerciseService _customExerciseService;

        public CustomExerciseController(CustomExerciseService customExerciseService)
        {
            _customExerciseService = customExerciseService;
        }

        [Route("getAll")]
        [HttpGet]
        public IActionResult GetAllCustomExercises()
        {
            return Ok(_customExerciseService.GetAllCustomExercises);
        }

        [Route("countUserExercises")]
        [HttpGet]
        public IActionResult CountUserCustomExercises(long idUser)
        {
            return Ok(_customExerciseService.CountUserCustomExercise(idUser));
        }

        [Route("get")]
        [HttpGet]
        public IActionResult GetCustomExercise(long id)
        {
            try
            {
                return Ok(_customExerciseService.GetCustomExercise(id));
            }
            catch (ExerciseException ex)
            {
                return NotFound(ex.Message);
            }
        }

        [Route("getUserExercises")]
        [HttpGet]
        public IActionResult GetUserCustomExercises(long idUser)
        {
            try
            {
                return Ok(_customExerciseService.GetUserCustomExercises(idUser));
            }
            catch (ExerciseException ex)
            {
                return NotFound(ex.Message);
            }
        }

        [Route("getName")]
        [HttpGet]
        public IActionResult GetCustomExerciseName(long id)
        {
            try
            {
                return Ok(_customExerciseService.GetCustomExerciseName(id));
            }
            catch (ExerciseException ex)
            {
                return NotFound(ex.Message);
            }
        }

        [Route("getDescription")]
        [HttpGet]
        public IActionResult GetCustomExerciseDescription(long id)
        {
            try
            {
                return Ok(_customExerciseService.GetCustomExerciseDescription(id));
            }
            catch (ExerciseException ex)
            {
                return NotFound(ex.Message);
            }
        }

        [Route("getMethod")]
        [HttpGet]
        public IActionResult GetCustomExerciseMethod(long id)
        {
            try
            {
                return Ok(_customExerciseService.GetCustomExerciseMethod(id));
            }
            catch (ExerciseException ex)
            {
                return NotFound(ex.Message);
            }
        }

        [Route("getImage")]
        [HttpGet]
        public IActionResult GetCustomExerciseImage(long id)
        {
            try
            {
                return Ok(_customExerciseService.GetCustomExerciseImage(id));
            }
            catch (ExerciseException ex)
            {
                return NotFound(ex.Message);
            }
        }

        [Route("getVideo")]
        [HttpGet]
        public IActionResult GetCustomExerciseVideo(long id)
        {
            try
            {
                return Ok(_customExerciseService.GetCustomExerciseVideo(id));
            }
            catch (ExerciseException ex)
            {
                return NotFound(ex.Message);
            }
        }

        [Route("getDuration")]
        [HttpGet]
        public IActionResult GetCustomExerciseDuration(long id)
        {
            try
            {
                return Ok(_customExerciseService.GetCustomExerciseDuration(id));
            }
            catch (ExerciseException ex)
            {
                return NotFound(ex.Message);
            }
        }

        [Route("getDifficulty")]
        [HttpGet]
        public IActionResult GetCustomExerciseDifficulty(long id)
        {
            try
            {
                return Ok(_customExerciseService.GetCustomExerciseDifficulty(id));
            }
            catch (ExerciseException ex)
            {
                return NotFound(ex.Message);
            }
        }

        [Route("getCalories")]
        [HttpGet]
        public IActionResult GetCustomExerciseCalories(long id)
        {
            try
            {
                return Ok(_customExerciseService.GetCustomExerciseCalories(id));
            }
            catch (ExerciseException ex)
            {
                return NotFound(ex.Message);
            }
        }

        [Route("getTarget")]
        [HttpGet]
        public IActionResult GetCustomExerciseTarget(long id)
        {
            try
            {
                return Ok(_customExerciseService.GetCustomExerciseTarget(id));
            }
            catch (ExerciseException ex)
            {
                return NotFound(ex.Message);
            }
        }

        [Route("getPrivate")]
        [HttpGet]
        public IActionResult GetCustomExercisePrivate(long id)
        {
            try
            {
                return Ok(_customExerciseService.GetCustomExercisePrivate(id));
            }
            catch (ExerciseException ex)
            {
                return NotFound(ex.Message);
            }
        }

        [Route("add")]
        [HttpPost]
        public IActionResult AddCustomExercise(CustomExercise customExercise)
        {
            try
            {
                _customExerciseService.AddCustomExercise(customExercise);
                return Ok();
            }
            catch (ExerciseException ex)
            {
                return NotFound(ex.Message);
            }
        }

        [Route("setName")]
        [HttpPut]
        public IActionResult SetCustomExerciseName(long id, string name)
        {
            try
            {
                _customExerciseService.SetCustomExerciseName(id, name);
                return Ok(); }

            catch (ExerciseException ex)
            {
                return NotFound(ex.Message);
            }
        }

        [Route("setDescription")]
        [HttpPut]
        public IActionResult SetCustomExerciseDescription(long id, string description)
        {
            try
            {
                _customExerciseService.SetCustomExerciseDescription(id, description);
                return Ok();}

            catch (ExerciseException ex)
            {
                return NotFound(ex.Message);
            }
        }

        [Route("setMethod")]
        [HttpPut]
        public IActionResult SetCustomExerciseMethod(long id, string method)
        {
            try
            {
                _customExerciseService.SetCustomExerciseMethod(id, method);
                return Ok();
            }
            catch (ExerciseException ex)
            {
                return NotFound(ex.Message);
            }
        }

        [Route("setImage")]
        [HttpPut]
        public IActionResult SetCustomExerciseImage(long id, string image)
        {
            try
            {
               _customExerciseService.SetCustomExerciseImage(id, image);
            return Ok();
            }
            catch (ExerciseException ex)
            {
                return NotFound(ex.Message);
            }
        }

        [Route("setVideo")]
        [HttpPut]
        public IActionResult SetCustomExerciseVideo(long id, string video)
        {
            try
            {
               _customExerciseService.SetCustomExerciseVideo(id, video);
            return Ok();
            }
            catch (ExerciseException ex)
            {
                return NotFound(ex.Message);
            }
        }

        [Route("setDuration")]
        [HttpPut]
        public IActionResult SetCustomExerciseDuration(long id, int duration)
        {
            try
            {
                _customExerciseService.SetCustomExerciseDuration(id, duration);
                return Ok();
            }

            catch (ExerciseException ex)
            {
                return NotFound(ex.Message);
            }
        }

        [Route("setDifficulty")]
        [HttpPut]
        public IActionResult SetCustomExerciseDifficulty(long id, byte difficulty)
        {
            try
            {
                _customExerciseService.SetCustomExerciseDifficulty(id, difficulty);
                return Ok();
            }

            catch (ExerciseException ex)
            {
                return NotFound(ex.Message);
            }
        }

        [Route("setCalories")]
        [HttpPut]
        public IActionResult SetCustomExerciseCalories(long id, int calories)
        {
            try
            {
                _customExerciseService.SetCustomExerciseCalories(id, calories);
                return Ok();
            }

            catch (ExerciseException ex)
            {
                return NotFound(ex.Message);
            }
        }

        [Route("setTarget")]
        [HttpPut]
        public IActionResult SetCustomExerciseTarget(long id, string target)
        {
            try
            {
                _customExerciseService.SetCustomExerciseTarget(id, target);
                return Ok();
            }
            catch (ExerciseException ex)
            {
                return NotFound(ex.Message);
            }
        }

        [Route("setPrivate")]
        [HttpPut]
        public IActionResult SetCustomExercisePrivate(long id, bool privato)
        {
            try
            {
                _customExerciseService.SetCustomExercisePrivate(id, privato);
                return Ok();
            }

            catch (ExerciseException ex)
            {
                return NotFound(ex.Message);
            }
        }

        [Route("delete")]
        [HttpDelete]
        public IActionResult DeleteCustomExercise(long id)
        {
            try
            {
                _customExerciseService.DeleteCustomExercise(id);
                return Ok();
            }

            catch (ExerciseException ex)
            {
                return NotFound(ex.Message);
            }
        }

        [Route("deleteUserExercises")]
        [HttpDelete]
        public IActionResult DeleteUserCustomExercise(long idUser)
        {
            try
            {
                _customExerciseService.DeleteUserCustomExercises(idUser);
                return Ok();
            }

            catch (ExerciseException ex)
            {
                return NotFound(ex.Message);
            }
        }

    }
}
