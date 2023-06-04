using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using MyFit_API.Exceptions.StaffException;
using MyFit_API.Services;

namespace MyFit_API.Controllers
{

    [EnableCors]
    [ApiController]
    [Route("/api/Staff")]
    public class StaffController : ControllerBase
    {

        private StaffService _staffService;

        public StaffController(StaffService staffService)
        {
            _staffService = staffService;
        }

        [HttpGet]
        [Route("getAll")]
        public IActionResult GetAllStaff()
        {
            try
            {
                return Ok(_staffService.GetAllStaff());
            }
            catch (StaffNotFoundException ex)
            {
                return NotFound(ex.Message);
            }
        }

        [HttpGet]
        [Route("get")]
        public IActionResult GetStaff(long id)
        {
            try
            {
                return Ok(_staffService.GetStaff(id));
            }
            catch (StaffNotFoundException ex)
            {
                return NotFound(ex.Message);
            }
        }

        [HttpGet]
        [Route("getByGym")]
        public IActionResult GetStaffByGym(long idGym)
        {
            try
            {
                return Ok(_staffService.GetStaffByGym(idGym));
            }
            catch (StaffNotFoundException ex)
            {
                return NotFound(ex.Message);
            }
        }

        [HttpPost]
        [Route("add")]
        public IActionResult AddStaff([FromBody] MyFit_Libs.Models.Staff staff)
        {
            _staffService.AddStaff(staff);

            return Ok();
        }

        [HttpDelete]
        [Route("delete")]
        public IActionResult DeleteStaff(long id)
        {
            try
            {
                _staffService.DeleteStaff(id);

                return Ok();
            }
            catch (StaffNotFoundException ex)
            {
                return NotFound(ex.Message);
            }
        }

        [HttpDelete]
        [Route("deleteByGym")]
        public IActionResult DeleteStaffByGym(long idGym)
        {
            _staffService.DeleteStaffByGym(idGym);
            return Ok();
        }
    }
}
