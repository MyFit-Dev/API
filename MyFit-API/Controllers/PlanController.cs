﻿using Microsoft.AspNetCore.Mvc;
using MyFit_API.Exceptions.PlanException;
using MyFit_API.Services;
using MyFit_Libs.Models;

namespace MyFit_API.Controllers
{

    [ApiController]
    [Route("/api/Plan")]
    public class PlanController : ControllerBase
    {
        private PlanService _planService;

        public PlanController(PlanService planService)
        {
            _planService = planService;
        }


        [Route("getAll")]
        [HttpGet]
        public IActionResult GetAllUsers()
        {
            return Ok(_planService.GetAllPlans());
        }

        [Route("countAll")]
        [HttpGet]
        public IActionResult CountAllPlans()
        {
            return Ok(_planService.CountPlans());
        }

        [Route("countHowManyBought")]
        [HttpGet]
        public IActionResult CountHowManyPlans(byte id)
        {
            return Ok(_planService.CountHowManyPlansById(id));
        }

        [Route("get")]
        [HttpGet]
        public IActionResult GetPlan(byte id)
        {
            try
            {
                Plan plan = _planService.GetPlanById(id);
                return Ok(plan);
            }
            catch (PlanNotFoundException ex)
            {
                return NotFound(ex.Message);
            }
        }

        [Route("getName")]
        [HttpGet]
        public IActionResult GetPlanName(byte id)
        {
            try
            {
                string planName = _planService.GetPlanName(id);
                return Ok(planName);
            }
            catch (PlanNotFoundException ex)
            {
                return NotFound(ex.Message);
            }
        }

        [Route("getValue")]
        [HttpGet]
        public IActionResult GetPlanValue(byte id)
        {
            try
            {
                byte planValue = _planService.GetPlanValue(id);
                return Ok(planValue);
            }
            catch (PlanNotFoundException ex)
            {
                return NotFound(ex.Message);
            }
        }

        [Route("getPrice")]
        [HttpGet]
        public IActionResult GetPlanPrice(byte id)
        {
            try
            {
                float planPrice = _planService.GetPlanPrice(id);
                return Ok(planPrice);
            }
            catch (PlanNotFoundException ex)
            {
                return NotFound(ex.Message);
            }
        }

        [Route("getDescription")]
        [HttpGet]
        public IActionResult GetPlanDescription(byte id)
        {
            try
            {
                string? planDescription = _planService.GetPlanDescription(id);
                return Ok(planDescription);
            }
            catch (PlanNotFoundException ex)
            {
                return NotFound(ex.Message);
            }
        }

        [Route("add")]
        [HttpPost]
        public IActionResult GetPlan(Plan plan)
        {
            _planService.AddPlan(plan);
            return Ok(plan);
        }

        [Route("setName")]
        [HttpPut]
        public IActionResult SetPlanName(byte id, string name)
        {
            try
            {
                _planService.SetPlanName(id, name);
                return Ok();
            }
            catch (PlanNotFoundException ex)
            {
                return NotFound(ex.Message);
            }
        }

        [Route("setValue")]
        [HttpPut]
        public IActionResult SetPlanValue(byte id, byte value)
        {
            try
            {
                _planService.SetPlanValue(id, value);
                return Ok();
            }
            catch (PlanNotFoundException ex)
            {
                return NotFound(ex.Message);
            }
        }

        [Route("setPrice")]
        [HttpPut]
        public IActionResult SetPlanPrice(byte id, float price)
        {
            try
            {
                _planService.SetPlanPrice(id, price);
                return Ok();
            }
            catch (PlanNotFoundException ex)
            {
                return NotFound(ex.Message);
            }
        }

        [Route("setDescription")]
        [HttpPut]
        public IActionResult SetPlanDescription(byte id, string description)
        {
            try
            {
                _planService.SetPlanDescription(id, description);
                return Ok();
            }
            catch (PlanNotFoundException ex)
            {
                return NotFound(ex.Message);
            }
        }

        [Route("delete")]
        [HttpDelete]
        public IActionResult DeletePlanById(byte id)
        {
            try
            {
                _planService.DeletePlanById(id);
                return Ok();
            }
            catch (PlanNotFoundException ex)
            {
                return NotFound(ex.Message);
            }
        }

    }
}