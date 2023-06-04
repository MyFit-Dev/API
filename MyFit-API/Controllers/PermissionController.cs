using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using MyFit_API.Exceptions.PermissionException;
using MyFit_API.Services;
using MyFit_Libs.Models;

namespace MyFit_API.Controllers
{

    [EnableCors]
    [ApiController]
    [Route("/api/Permission")]
    public class PermissionController : ControllerBase
    {

        private PermissionService _permissionService;

        public PermissionController(PermissionService permissionService)
        {
            _permissionService = permissionService;
        }

        [HttpGet]
        [Route("getAll")]
        public IActionResult GetAllPermission()
        {
            try
            {
                return Ok(_permissionService.GetAllPermission());
            }
            catch (PermissionNotFoundException ex)
            {
                return NotFound(ex.Message);
            }
        }

        [HttpGet]
        [Route("get")]
        public IActionResult GetPermission(int id)
        {
            try
            {
                return Ok(_permissionService.GetPermission(id));
            }
            catch (PermissionNotFoundException ex)
            {
                return NotFound(ex.Message);
            }
        }

        [HttpGet]
        [Route("getName")]
        public IActionResult GetPermissionName(int id)
        {
            try
            {
                return Ok(_permissionService.GetPermissionName(id));
            }
            catch (PermissionNotFoundException ex)
            {
                return NotFound(ex.Message);
            }
        }

        [HttpGet]
        [Route("getValue")]
        public IActionResult GetPermissionValue(int id)
        {
            try
            {
                return Ok(_permissionService.GetPermissionValue(id));
            }
            catch (PermissionNotFoundException ex)
            {
                return NotFound(ex.Message);
            }
        }

        [HttpPost]
        [Route("add")]
        public IActionResult AddPermission(Permission permission)
        {
            try
            {
                _permissionService.AddPermission(permission);
                return Ok();
            }
            catch (PermissionNotFoundException ex)
            {
                return NotFound(ex.Message);
            }
        }

        [HttpPut]
        [Route("setName")]
        public IActionResult SetPermissionName(int id, string name)
        {
            try
            {
                _permissionService.SetPermissionName(id, name);
                return Ok();
            }
            catch (PermissionNotFoundException ex)
            {
                return NotFound(ex.Message);
            }
        }

        [HttpPut]
        [Route("setValue")]
        public IActionResult SetPermissionValue(int id, byte value)
        {
            try
            {
                _permissionService.SetPermissionValue(id, value);
                return Ok();
            }
            catch (PermissionNotFoundException ex)
            {
                return NotFound(ex.Message);
            }
        }

        [HttpDelete]
        [Route("delete")]
        public IActionResult DeletePermission(int id)
        {
            try
            {
                _permissionService.DeletePermission(id);
                return Ok();
            }
            catch (PermissionNotFoundException ex)
            {
                return NotFound(ex.Message);
            }
        }

    }
}
