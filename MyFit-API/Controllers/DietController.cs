using Microsoft.AspNetCore.Mvc;
using MyFit_API.Exceptions.DietException;
using MyFit_API.Exceptions.UserException;
using MyFit_API.Services;
using MyFit_Libs.Models;
using MyFit_Libs.Utils;

namespace MyFit_API.Controllers
{
    [ApiController]
    [Route("/api/Diet")]
    public class DietController : ControllerBase
    {
        private DietService _dietService;

        public DietController(DietService dietService)
        {
            _dietService = dietService;
        }

        [Route("getAll")]
        [HttpGet]
        public IActionResult GetAllDiets()
        {
            try
            {
                return Ok(_dietService.GetAllDiets());
            }
            catch (DietNotFoundException ex) 
            {
                return NotFound(ex.Message);
            }
        }

        [Route("getAllOfUser")]
        [HttpGet]
        public IActionResult GetAllDietsByUserId(long idUser)
        {
            try
            {
                return Ok(_dietService.GetAllUserDiets(idUser));
            }
            catch (DietNotFoundException ex)
            {
                return NotFound(ex.Message);
            }
            catch (UserNotFoundException ex)
            {
                return NotFound(ex.Message);
            }
        }

        [Route("getByDateOfUserer")]
        [HttpGet]
        public IActionResult GetUserDietByDate(long idUser, DateTime date)
        {
            try
            {
                return Ok(_dietService.GetUserDietByDate(idUser, date));
            }
            catch (DietNotFoundException ex)
            {
                return NotFound(ex.Message);
            }
            catch (UserNotFoundException ex)
            {
                return NotFound(ex.Message);
            }
        }

        [Route("get")]
        [HttpGet]
        public IActionResult GetDiet(long id)
        {
            try
            {
                return Ok(_dietService.GetDiet(id));
            }
            catch (DietNotFoundException ex)
            {
                return NotFound(ex.Message);
            }
        }

        [Route("getFoodList")]
        [HttpGet]
        public IActionResult GetFoodList(long id)
        {
            try
            {
                return Ok(_dietService.GetFoodList(id));
            }
            catch (DietNotFoundException ex)
            {
                return NotFound(ex.Message);
            }
        }

        [Route("getAllUserFoodList")]
        [HttpGet]
        public IActionResult GetAllUserFoodList(long idUser)
        {
            try
            {
                return Ok(_dietService.GetAllUserFoodLists(idUser));
            }
            catch (DietNotFoundException ex)
            {
                return NotFound(ex.Message);
            }
            catch (UserNotFoundException ex)
            {
                return NotFound(ex.Message);
            }
        }

        [Route("getUserFoodListByDate")]
        [HttpGet]
        public IActionResult GetUserFoodListByDate(long idUser, DateTime date)
        {
            try
            {
                return Ok(_dietService.GetUserFoodListsByDate(idUser, date));
            }
            catch (DietNotFoundException ex)
            {
                return NotFound(ex.Message);
            }
            catch (UserNotFoundException ex)
            {
                return NotFound(ex.Message);
            }
        }

        [Route("getUserFoodListBetweenDate")]
        [HttpGet]
        public IActionResult GetUserFoodListBetweenDate(long idUser, DateTime startDate, DateTime endDate)
        {
            try
            {
                return Ok(_dietService.GetUserFoodListsBetweenDates(idUser, startDate, endDate));
            }
            catch (DietNotFoundException ex)
            {
                return NotFound(ex.Message);
            }
            catch (UserNotFoundException ex)
            {
                return NotFound(ex.Message);
            }
        }

        [Route("add")]
        [HttpPost]
        public IActionResult AddDiet(Diet diet)
        {
            _dietService.AddDiet(diet);
            return Ok();
        }

        [Route("addFoodToUserFoodList")]
        [HttpPut]
        public IActionResult AddFoodToUserFoodList(long idUser, DateTime date, Meal meal)
        {
            try
            {
                _dietService.AddFoodToFoodListOfUser(idUser, date, meal);
                return Ok();
            }
            catch (DietNotFoundException ex)
            {
                return NotFound(ex.Message);
            }
            catch (UserNotFoundException ex)
            {
                return NotFound(ex.Message);
            }
        }

        [Route("removeFoodToUserFoodList")]
        [HttpPut]
        public IActionResult RemoveFoodToUserFoodList(long idUser, DateTime date, Meal meal)
        {
            try
            {
                _dietService.RemoveFoodToFoodListOfUser(idUser, date, meal);
                return Ok();
            }
            catch (DietNotFoundException ex)
            {
                return NotFound(ex.Message);
            }
            catch (UserNotFoundException ex)
            {
                return NotFound(ex.Message);
            }
        }

        [Route("delete")]
        [HttpDelete]
        public IActionResult DeleteDiet(long id)
        {
            try
            {
                _dietService.DeleteDiet(id);
                return Ok();
            }
            catch (DietNotFoundException ex)
            {
                return NotFound(ex.Message);
            }
        }

        [Route("deleteByUserAndDate")]
        [HttpDelete]
        public IActionResult DeleteDietOfUserByDate(long idUser, DateTime date)
        {
            try
            {
                _dietService.DeleteDietOfUserAndDate(idUser, date);
                return Ok();
            }
            catch (DietNotFoundException ex)
            {
                return NotFound(ex.Message);
            }
            catch (UserNotFoundException ex)
            {
                return NotFound(ex.Message);
            }
        }

        [Route("deleteByUserBetweenDates")]
        [HttpDelete]
        public IActionResult DeleteDietsOfUserBetweenDates(long idUser, DateTime startDate, DateTime endDate)
        {
            try
            {
                _dietService.DeleteDietsOfUserBetweenDate(idUser, startDate, endDate);
                return Ok();
            }
            catch (UserNotFoundException ex)
            {
                return NotFound(ex.Message);
            }
        }

        [Route("deleteAllOfUser")]
        [HttpDelete]
        public IActionResult DeleteDietsOfUser(long idUser)
        {
            try
            {
                _dietService.DeleteDietsOfUser(idUser);
                return Ok();
            }
            catch (UserNotFoundException ex)
            {
                return NotFound(ex.Message);
            }
        }

    }
}
