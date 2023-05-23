using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using MyFit_API.Exceptions.ExerciseException;
using MyFit_API.Services;
using MyFit_Libs.Models;


namespace MyFit_API.Controllers
{
    [EnableCors]
    [ApiController]
    [Route("/api/GenericExercise")]
    public class GenericExerciseController : ControllerBase
    {

        private GenericExerciseService _GenericExerciseService;

        public GenericExerciseController(GenericExerciseService GenericExerciseService)
        {
            _GenericExerciseService = GenericExerciseService;
        }

        [Route("getAll")]
        [HttpGet]
        public IActionResult GetAllGenericExercises()
        {
            return Ok(_GenericExerciseService.GetAllGenericExercises);
        }

        [Route("get")]
        [HttpGet]
        public IActionResult GetGenericExercise(long id)
        {
            try
            {
                return Ok(_GenericExerciseService.GetGenericExercise(id));
            }
            catch (ExerciseException ex)
            {
                return NotFound(ex.Message);
            }
        }

        [Route("getName")]
        [HttpGet]
        public IActionResult GetGenericExerciseName(long id)
        {
            try
            {
                return Ok(_GenericExerciseService.GetGenericExerciseName(id));
            }
            catch (ExerciseException ex)
            {
                return NotFound(ex.Message);
            }
        }

        [Route("getDescription")]
        [HttpGet]
        public IActionResult GetGenericExerciseDescription(long id)
        {
            try
            {
                return Ok(_GenericExerciseService.GetGenericExerciseDescription(id));
            }
            catch (ExerciseException ex)
            {
                return NotFound(ex.Message);
            }
        }

        [Route("getMethod")]
        [HttpGet]
        public IActionResult GetGenericExerciseMethod(long id)
        {
            try
            {
                return Ok(_GenericExerciseService.GetGenericExerciseMethod(id));
            }
            catch (ExerciseException ex)
            {
                return NotFound(ex.Message);
            }
        }

        [Route("getImage")]
        [HttpGet]
        public IActionResult GetGenericExerciseImage(long id)
        {
            try
            {
                return Ok(_GenericExerciseService.GetGenericExerciseImage(id));
            }
            catch (ExerciseException ex)
            {
                return NotFound(ex.Message);
            }
        }

        [Route("getVideo")]
        [HttpGet]
        public IActionResult GetGenericExerciseVideo(long id)
        {
            try
            {
                return Ok(_GenericExerciseService.GetGenericExerciseVideo(id));
            }
            catch (ExerciseException ex)
            {
                return NotFound(ex.Message);
            }
        }

        [Route("getDuration")]
        [HttpGet]
        public IActionResult GetGenericExerciseDuration(long id)
        {
            try
            {
                return Ok(_GenericExerciseService.GetGenericExerciseDuration(id));
            }
            catch (ExerciseException ex)
            {
                return NotFound(ex.Message);
            }
        }

        [Route("getDifficulty")]
        [HttpGet]
        public IActionResult GetGenericExerciseDifficulty(long id)
        {
            try
            {
                return Ok(_GenericExerciseService.GetGenericExerciseDifficulty(id));
            }
            catch (ExerciseException ex)
            {
                return NotFound(ex.Message);
            }
        }

        [Route("getCalories")]
        [HttpGet]
        public IActionResult GetGenericExerciseCalories(long id)
        {
            try
            {
                return Ok(_GenericExerciseService.GetGenericExerciseCalories(id));
            }
            catch (ExerciseException ex)
            {
                return NotFound(ex.Message);
            }
        }

        [Route("getTarget")]
        [HttpGet]
        public IActionResult GetGenericExerciseTarget(long id)
        {
            try
            {
                return Ok(_GenericExerciseService.GetGenericExerciseTarget(id));
            }
            catch (ExerciseException ex)
            {
                return NotFound(ex.Message);
            }
        }

        [Route("add")]
        [HttpPost]
        public IActionResult AddGenericExercise(GenericExercise GenericExercise)
        {
            try
            {
                _GenericExerciseService.AddGenericExercise(GenericExercise);
                return Ok();
            }
            catch (ExerciseException ex)
            {
                return NotFound(ex.Message);
            }
        }

        [Route("setName")]
        [HttpPut]
        public IActionResult SetGenericExerciseName(long id, string name)
        {
            try
            {
                _GenericExerciseService.SetGenericExerciseName(id, name);
                return Ok();
            }

            catch (ExerciseException ex)
            {
                return NotFound(ex.Message);
            }
        }

        [Route("setDescription")]
        [HttpPut]
        public IActionResult SetGenericExerciseDescription(long id, string description)
        {
            try
            {
                _GenericExerciseService.SetGenericExerciseDescription(id, description);
                return Ok();
            }

            catch (ExerciseException ex)
            {
                return NotFound(ex.Message);
            }
        }

        [Route("setMethod")]
        [HttpPut]
        public IActionResult SetGenericExerciseMethod(long id, string method)
        {
            try
            {
                _GenericExerciseService.SetGenericExerciseMethod(id, method);
                return Ok();
            }
            catch (ExerciseException ex)
            {
                return NotFound(ex.Message);
            }
        }

        [Route("setImage")]
        [HttpPut]
        public IActionResult SetGenericExerciseImage(long id, string image)
        {
            try
            {
                _GenericExerciseService.SetGenericExerciseImage(id, image);
                return Ok();
            }
            catch (ExerciseException ex)
            {
                return NotFound(ex.Message);
            }
        }

        [Route("setVideo")]
        [HttpPut]
        public IActionResult SetGenericExerciseVideo(long id, string video)
        {
            try
            {
                _GenericExerciseService.SetGenericExerciseVideo(id, video);
                return Ok();
            }
            catch (ExerciseException ex)
            {
                return NotFound(ex.Message);
            }
        }

        [Route("setDuration")]
        [HttpPut]
        public IActionResult SetGenericExerciseDuration(long id, int duration)
        {
            try
            {
                _GenericExerciseService.SetGenericExerciseDuration(id, duration);
                return Ok();
            }

            catch (ExerciseException ex)
            {
                return NotFound(ex.Message);
            }
        }

        [Route("setDifficulty")]
        [HttpPut]
        public IActionResult SetGenericExerciseDifficulty(long id, byte difficulty)
        {
            try
            {
                _GenericExerciseService.SetGenericExerciseDifficulty(id, difficulty);
                return Ok();
            }

            catch (ExerciseException ex)
            {
                return NotFound(ex.Message);
            }
        }

        [Route("setCalories")]
        [HttpPut]
        public IActionResult SetGenericExerciseCalories(long id, int calories)
        {
            try
            {
                _GenericExerciseService.SetGenericExerciseCalories(id, calories);
                return Ok();
            }

            catch (ExerciseException ex)
            {
                return NotFound(ex.Message);
            }
        }

        [Route("setTarget")]
        [HttpPut]
        public IActionResult SetGenericExerciseTarget(long id, string target)
        {
            try
            {
                _GenericExerciseService.SetGenericExerciseTarget(id, target);
                return Ok();
            }
            catch (ExerciseException ex)
            {
                return NotFound(ex.Message);
            }
        }

        [Route("delete")]
        [HttpDelete]
        public IActionResult DeleteGenericExercise(long id)
        {
            try
            {
                _GenericExerciseService.DeleteGenericExercise(id);
                return Ok();
            }

            catch (ExerciseException ex)
            {
                return NotFound(ex.Message);
            }
        }

    }
}
