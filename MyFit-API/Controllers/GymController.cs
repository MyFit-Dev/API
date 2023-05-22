using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using MyFit_API.Exceptions.GymException;
using MyFit_API.Services;
using MyFit_Libs.Models;

namespace MyFit_API.Controllers
{

    [EnableCors]
    [ApiController]
    [Route("/api/Gym")]
    public class GymController : ControllerBase
    {

        private GymService _gymService;

        public GymController(GymService gymService)
        {
            _gymService = gymService;
        }

        [Route("getAll")]
        [HttpGet]
        public IActionResult GetAllGyms()
        {
            try
            {
                return Ok(_gymService.GetAllGyms());
            }
            catch (GymNotFoundException ex)
            {
                return NotFound(ex.Message);
            }
        }

        [Route("count")]
        [HttpGet]
        public IActionResult CountAllGyms() 
        {
            return Ok(_gymService.CountAllGyms());
        }

        [Route("countStaff")]
        [HttpGet]
        public IActionResult CountGymStaffers(long id) 
        {
            try
            {
                return Ok(_gymService.CountGymStaffers(id));
            }
            catch (GymNotFoundException ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [Route("get")]
        [HttpGet]
        public IActionResult GetGym(long id)
        {
            try
            {
                return Ok(_gymService.GetGym(id));
            }
            catch (GymNotFoundException ex)
            {
                return NotFound(ex.Message);
            }
        }

        [Route("getName")]
        [HttpGet]
        public IActionResult GetGymName(long id)
        {
            try
            {
                return Ok(_gymService.GetGymName(id));
            }
            catch (GymNotFoundException ex)
            {
                return NotFound(ex.Message);
            }
        }

        [Route("getState")]
        [HttpGet]
        public IActionResult GetGymState(long id)
        {
            try
            {
                return Ok(_gymService.GetGymState(id));
            }
            catch (GymNotFoundException ex)
            {
                return NotFound(ex.Message);
            }
        }

        [Route("getCity")]
        [HttpGet]
        public IActionResult GetGymCity(long id)
        {
            try
            {
                return Ok(_gymService.GetGymCity(id));
            }
            catch (GymNotFoundException ex)
            {
                return NotFound(ex.Message);
            }
        }

        [Route("getStreet")]
        [HttpGet]
        public IActionResult GetGymStreet(long id)
        {
            try
            {
                return Ok(_gymService.GetGymStreet(id));
            }
            catch (GymNotFoundException ex)
            {
                return NotFound(ex.Message);
            }
        }

        [Route("getCivicNumber")]
        [HttpGet]
        public IActionResult GetGymCivicNumber(long id)
        {
            try
            {
                return Ok(_gymService.GetGymCivicNumber(id));
            }
            catch (GymNotFoundException ex)
            {
                return NotFound(ex.Message);
            }
        }

        [Route("getCAP")]
        [HttpGet]
        public IActionResult GetGymCAP(long id)
        {
            try
            {
                return Ok(_gymService.GetGymCAP(id));
            }
            catch (GymNotFoundException ex)
            {
                return NotFound(ex.Message);
            }
        }

        [Route("getIdStaff")]
        [HttpGet]
        public IActionResult GetGymIdStaff(long id)
        {
            try
            {
                return Ok(_gymService.GetGymIdStaff(id));
            }
            catch (GymNotFoundException ex)
            {
                return NotFound(ex.Message);
            }
        }

        [Route("add")]
        [HttpPost]
        public IActionResult AddGym(Gym? gym)
        {
            if (gym == null)
                return BadRequest("{Gym} is null");

            _gymService.AddGym(gym);

            return Ok();
        }

        [Route("setName")]
        [HttpPut]
        public IActionResult SetGymName(long id, string? name)
        {
            if (name == null)
                return BadRequest("{Name} is null");

            try
            {
                _gymService.SetGymName(id, name);
                return Ok();
            }
            catch (GymNotFoundException ex)
            {
                return NotFound(ex.Message);
            }
        }

        [Route("setState")]
        [HttpPut]
        public IActionResult SetGymState(long id, string? state)
        {
            if (state == null)
                return BadRequest("{State} is null");

            try
            {
                _gymService.SetGymState(id, state);
                return Ok();
            }
            catch (GymNotFoundException ex)
            {
                return NotFound(ex.Message);
            }
        }

        [Route("setCity")]
        [HttpPut]
        public IActionResult SetGymCity(long id, string? city)
        {
            if (city == null)
                return BadRequest("{City} is null");

            try
            {
                _gymService.SetGymCity(id, city);
                return Ok();
            }
            catch (GymNotFoundException ex)
            {
                return NotFound(ex.Message);
            }
        }

        [Route("setStreet")]
        [HttpPut]
        public IActionResult SetGymStreet(long id, string? street)
        {
            if (street == null)
                return BadRequest("{Street} is null");

            try
            {
                _gymService.SetGymStreet(id, street);
                return Ok();
            }
            catch (GymNotFoundException ex)
            {
                return NotFound(ex.Message);
            }
        }

        [Route("setCivicNumber")]
        [HttpPut]
        public IActionResult SetGymCivicNumber(long id, int civicNumber)
        {
            if (civicNumber < 0)
                return BadRequest("{CivicNumber} is invalid");

            try
            {
                _gymService.SetGymCivicNumber(id, civicNumber);
                return Ok();
            }
            catch (GymNotFoundException ex)
            {
                return NotFound(ex.Message);
            }
        }

        [Route("setCAP")]
        [HttpPut]
        public IActionResult SetGymCAP(long id, int cap)
        {
            if (cap < 0)
                return BadRequest("{CAP} is invalid");

            try
            {
                _gymService.SetGymCAP(id, cap);
                return Ok();
            }
            catch (GymNotFoundException ex)
            {
                return NotFound(ex.Message);
            }
        }

        [Route("delete")]
        [HttpDelete]
        public IActionResult DeleteGym(long id)
        {
            try
            {
                _gymService.DeleteGym(id);
                return Ok();
            }
            catch (GymNotFoundException ex)
            {
                return NotFound(ex.Message);
            }
        }


    }
}
