using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using MyFit_API.Exceptions.FormException;
using MyFit_API.Exceptions.UserException;
using MyFit_API.Services;
using MyFit_Libs.Models;

namespace MyFit_API.Controllers
{
    [EnableCors]
    [ApiController]
    [Route("/api/Form")]
    public class FormController : ControllerBase
    {
        private FormService _formService;

        public FormController(FormService formService)
        {
            _formService = formService;
        }

        [HttpGet]
        [Route("getAll")]
        public IActionResult GetAllForms()
        {
            return Ok(_formService.GetAllForms());
        }

        [HttpGet]
        [Route("countAll")]
        public IActionResult CountAllForms()
        {
            return Ok(_formService.CountForms());
        }

        [HttpGet]
        [Route("get")]
        public IActionResult GetForm(long id)
        {
            try
            {
                return Ok(_formService.GetForm(id));
            }
            catch (FormNotFoundException ex)
            {
                return NotFound(ex.Message);
            }
        }

        [HttpGet]
        [Route("count")]
        public IActionResult CountUserForms(long idUser)
        {
            try
            {
                return Ok(_formService.CountUserForms(idUser));
            }
            catch (UserNotFoundException ex)
            {
                return NotFound(ex.Message);
            }
        }

        [HttpGet]
        [Route("getAllOfUser")]
        public IActionResult GetUserForms(long idUser)
        {
            try
            {
                return Ok(_formService.GetUserForms(idUser));
            }
            catch (UserNotFoundException ex)
            {
                return NotFound(ex.Message);
            }
        }

        [HttpGet]
        [Route("getGenericExercises")]
        public IActionResult GetGenericExercisesOfForm(long id)
        {
            try
            {
                return Ok(_formService.GetGenericExercisesOfForm(id));
            }
            catch (FormNotFoundException ex)
            {
                return NotFound(ex.Message);
            }
        }

        [HttpGet]
        [Route("getCustomExercises")]
        public IActionResult GetCustomExercisesOfForm(long id)
        {
            try
            {
                return Ok(_formService.GetCustomExercisesOfForm(id));
            }
            catch (FormNotFoundException ex)
            {
                return NotFound(ex.Message);
            }
        }

        [HttpPost]
        [Route("add")]
        public IActionResult AddForm(Form form)
        {
            return Ok(AddForm(form));
        }

        [HttpPut]
        [Route("setGenericExercises")]
        public IActionResult SetGenericExercisesOfForm(long id, string? genericExercises)
        {
            try
            {
                _formService.SetFormGenericExercises(id, genericExercises);
                return Ok();
            }
            catch (FormNotFoundException ex)
            {
                return NotFound(ex.Message);
            }
        }

        [HttpPut]
        [Route("setCustomExercises")]
        public IActionResult SetCustomExercisesOfForm(long id, string? customExercises)
        {
            try
            {
                _formService.SetFormCustomExercises(id, customExercises);
                return Ok();
            }
            catch (FormNotFoundException ex)
            {
                return NotFound(ex.Message);
            }
        }

        [HttpDelete]
        [Route("delete")]
        public IActionResult DeleteForm(long id)
        {
            try
            {
                _formService.DeleteForm(id);
                return Ok();
            }
            catch (FormNotFoundException ex)
            {
                return NotFound(ex.Message);
            }
        }

        [HttpDelete]
        [Route("deleteAllOfUser")]
        public IActionResult DeleteUserForms(long idUser)
        {
            try
            {
                _formService.DeleteUserForms(idUser);
                return Ok();
            }
            catch (FormNotFoundException ex)
            {
                return NotFound(ex.Message);
            }
        }



    }
}
