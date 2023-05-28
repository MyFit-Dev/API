using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using MyFit_API.Exceptions.FoodException;
using MyFit_API.Services;
using MyFit_Libs.Models;
using System.Xml.Linq;

namespace MyFit_API.Controllers
{
    [EnableCors]
    [Route("/api/Food")]
    [ApiController]
    public class FoodController : ControllerBase
    {
        private FoodService _foodService;

        public FoodController(FoodService foodService)
        {
            _foodService = foodService;
        }

        [Route("getAll")]
        [HttpGet]
        public IActionResult GetAll()
        {
            try
            {
                return Ok(_foodService.GetAllFoods());
            }
            catch (FoodNotFoundException ex)
            {
                return NotFound(ex.Message);
            }
        }

        [Route("getSimilars")]
        [HttpGet]
        public IActionResult GetSimilars(string name, int results)
        {
            if (name == null)
                return BadRequest("Name is null");

            try
            {
                return Ok(_foodService.GetSimilarFoods(name, results));
            }
            catch (FoodNotFoundException ex)
            {
                return NotFound(ex.Message);
            }
        }

        [Route("count")]
        [HttpGet]
        public IActionResult Count()
        { 
            return Ok(_foodService.CountFoods());
        }

        [Route("get")]
        public IActionResult Get(int id)
        {
            try
            {
                return Ok(_foodService.GetFood(id));
            }
            catch (FoodNotFoundException ex)
            {
                return NotFound(ex.Message);
            }
        }

        [Route("add")]
        [HttpPost]
        public IActionResult Add(Food food)
        {
            try
            {
                _foodService.AddFood(food);
                return Ok();
            }
            catch (FoodNotFoundException ex)
            {
                return NotFound(ex.Message);
            }
        }

        [Route("update")]
        [HttpPut]
        public IActionResult Update(Food food, long id)
        {
            try
            {
                _foodService.UpdateFood(food, id);
                return Ok();
            }
            catch (FoodNotFoundException ex)
            {
                return NotFound(ex.Message);
            }
        }

        [Route("delete")]
        [HttpDelete]
        public IActionResult Delete(long id)
        {
            try
            {
                _foodService.DeleteFood(id);
                return Ok();
            }
            catch (FoodNotFoundException ex)
            {
                return NotFound(ex.Message);
            }
        }


    }
}
