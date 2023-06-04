using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using MyFit_API.Exceptions.StaffException;
using MyFit_API.Services;

namespace MyFit_API.Controllers
{
    [EnableCors]
    [ApiController]
    [Route("/api/StaffType")]
    public class StaffTypeController : ControllerBase
    {

        private StaffTypeService _staffTypeService;

        public StaffTypeController(StaffTypeService staffTypeService)
        {
            _staffTypeService = staffTypeService;
        }

        [HttpGet]
        [Route("getAll")]
        public IActionResult GetAllStaffType()
        {
            try
            {
                return Ok(_staffTypeService.GetAllStaffType());
            }
            catch (StaffNotFoundException ex)
            {
                return NotFound(ex.Message);
            }
        }

        [HttpGet]
        [Route("get")]
        public IActionResult GetStaffType(byte id)
        {
            try
            {
                return Ok(_staffTypeService.GetStaffType(id));
            }
            catch (StaffNotFoundException ex)
            {
                return NotFound(ex.Message);
            }
        }

        [HttpGet]
        [Route("getName")]
        public IActionResult GetStaffTypeName(byte id)
        {
            try
            {
                return Ok(_staffTypeService.GetStaffTypeName(id));
            }
            catch (StaffNotFoundException ex)
            {
                return NotFound(ex.Message);
            }
        }

        [HttpPost]
        [Route("add")]
        public IActionResult AddStaffType([FromBody] MyFit_Libs.Models.StaffType staffType)
        {
            _staffTypeService.AddStaffType(staffType);

            return Ok();
        }

        [HttpPost]
        [Route("setName")]
        public IActionResult SetStaffTypeName(byte id, string name)
        {
            try
            {
                _staffTypeService.SetStaffTypeName(id, name);
                return Ok();
            }
            catch (StaffNotFoundException ex)
            {
                return NotFound(ex.Message);
            }
        }

        [HttpDelete]
        [Route("delete")]
        public IActionResult DeleteStaffType(byte id)
        {
            try
            {
                _staffTypeService.DeleteStaffType(id);
                return Ok();
            }
            catch (StaffNotFoundException ex)
            {
                return NotFound(ex.Message);
            }
        }

    }
}
