using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using MyFit_API.Exceptions.RecordException;
using MyFit_API.Services;
using MyFit_Libs.Models;

namespace MyFit_API.Controllers
{
    [EnableCors]
    [ApiController]
    [Route("/api/Record")]
    public class RecordController : ControllerBase
    {

        private RecordService _recordService;

        public RecordController(RecordService recordService)
        {
            _recordService = recordService;
        }

        [Route("getAll")]
        [HttpGet]
        public IActionResult GetAll()
        {
            try
            {
                return Ok(_recordService.GetAllRecords());
            }
            catch (RecordNotFoundException ex)
            {
                return NotFound(ex.Message);
            }
        }

        [Route("get")]
        [HttpGet]
        public IActionResult Get(int id)
        {
            try
            {
                return Ok(_recordService.GetRecord(id));
            }
            catch (RecordNotFoundException ex)
            {
                return NotFound(ex.Message);
            }
        }

        [Route("getName")]
        [HttpGet]
        public IActionResult GetName(int id)
        {
            try
            {
                return Ok(_recordService.GetRecordName(id));
            }
            catch (RecordNotFoundException ex)
            {
                return NotFound(ex.Message);
            }
        }

        [Route("getGoal")]
        [HttpGet]
        public IActionResult GetGoal(int id)
        {
            try
            {
                return Ok(_recordService.GetRecordGoal(id));
            }
            catch (RecordNotFoundException ex)
            {
                return NotFound(ex.Message);
            }
        }

        [Route("getReward")]
        [HttpGet]
        public IActionResult GetReward(int id)
        {
            try
            {
                return Ok(_recordService.GetRecordReward(id));
            }
            catch (RecordNotFoundException ex)
            {
                return NotFound(ex.Message);
            }
        }

        [Route("getDifficulty")]
        [HttpGet]
        public IActionResult GetDifficulty(int id)
        {
            try
            {
                return Ok(_recordService.GetRecordDifficulty(id));
            }
            catch (RecordNotFoundException ex)
            {
                return NotFound(ex.Message);
            }
        }

        [Route("add")]
        [HttpPost]
        public IActionResult Add(Record record)
        {
            if (record == null)
                return BadRequest("{Record} is null");
            try
            {
                _recordService.AddRecord(record);
                return Ok();
            }
            catch (RecordNotFoundException ex)
            {
                return NotFound(ex.Message);
            }
        }

        [Route("setName")]
        [HttpPut]
        public IActionResult SetName(int id, string name)
        {
            if (name == null)
                return BadRequest("{Name} is null");
            try
            {
                _recordService.SetRecordName(id, name);
                return Ok();
            }
            catch (RecordNotFoundException ex)
            {
                return NotFound(ex.Message);
            }
        }

        [Route("setGoal")]
        [HttpPut]
        public IActionResult SetGoal(int id, string goal)
        {
            if (goal == null)
                return BadRequest("{Goal} is null");
            try
            {
                _recordService.SetRecordGoal(id, goal);
                return Ok();
            }
            catch (RecordNotFoundException ex)
            {
                return NotFound(ex.Message);
            }
        }

        [Route("setReward")]
        [HttpPut]
        public IActionResult SetReward(int id, string? reward)
        {
            try
            {
                _recordService.SetRecordReward(id, reward);
                return Ok();
            }
            catch (RecordNotFoundException ex)
            {
                return NotFound(ex.Message);
            }
        }

        [Route("setDifficulty")]
        [HttpPut]
        public IActionResult SetDifficulty(int id, int difficulty)
        {
            try
            {
                _recordService.SetRecordDifficulty(id, difficulty);
                return Ok();
            }
            catch (RecordNotFoundException ex)
            {
                return NotFound(ex.Message);
            }
        }

        [Route("delete")]
        [HttpDelete]
        public IActionResult Delete(int id)
        {
            try
            {
                _recordService.DeleteRecord(id);
                return Ok();
            }
            catch (RecordNotFoundException ex)
            {
                return NotFound(ex.Message);
            }
        }
    }
}
