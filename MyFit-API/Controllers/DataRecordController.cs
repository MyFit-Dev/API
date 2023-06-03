using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using MyFit_API.Exceptions.RecordException;
using MyFit_API.Services;
using MyFit_Libs.Models;

namespace MyFit_API.Controllers
{
    [EnableCors]
    [ApiController]
    [Route("/api/DataRecord")]
    public class DataRecordController : ControllerBase
    {

        private DataRecordService _dataRecordService;

        public DataRecordController(DataRecordService dataRecordService)
        {
            _dataRecordService = dataRecordService;
        }

        [HttpGet]
        [Route("getAll")]
        public IActionResult GetAll()
        {
            try
            {
                return Ok(_dataRecordService.GetAll());
            }
            catch (RecordNotFoundException ex)
            {
                return NotFound(ex.Message);
            }
        }

        [HttpGet]
        [Route("get")]
        public IActionResult GetById(long id)
        {
            try
            {
                return Ok(_dataRecordService.GetById(id));
            }
            catch (RecordNotFoundException ex)
            {
                return NotFound(ex.Message);
            }
        }

        [HttpGet]
        [Route("getByUserId")]
        public IActionResult GetByUserId(long idUser)
        {
            try
            {
                return Ok(_dataRecordService.GetByUserId(idUser));
            }
            catch (RecordNotFoundException ex)
            {
                return NotFound(ex.Message);
            }
        }

        [HttpGet]
        [Route("getByUserIdAndDate")]
        public IActionResult GetByUserIdAndDate(long idUser, DateTime date)
        {
            try
            {
                return Ok(_dataRecordService.GetByUserIdAndDate(idUser, date));
            }
            catch (RecordNotFoundException ex)
            {
                return NotFound(ex.Message);
            }
        }

        [HttpGet]
        [Route("getByUserIdAndDateRange")]
        public IActionResult GetByUserIdAndDateRange(long idUser, DateTime dateFrom, DateTime dateTo)
        {
            try
            {
                return Ok(_dataRecordService.GetByUserIdAndDateRange(idUser, dateFrom, dateTo));
            }
            catch (RecordNotFoundException ex)
            {
                return NotFound(ex.Message);
            }
        }

        [HttpGet]
        [Route("hasUnlockedRecord")]
        public IActionResult HasUnlockedRecord(long idUser, int idRecord)
        {
            return Ok(_dataRecordService.HasUnlockedRecord(idUser, idRecord));
        }

        [HttpGet]
        [Route("getLastUnlockedRecord")]
        public IActionResult GetLastUnlockedRecord(long idUser)
        {
            try
            {
                return Ok(_dataRecordService.GetLastUnlockedRecord(idUser));
            }
            catch (RecordNotFoundException ex)
            {
                return NotFound(ex.Message);
            }
        }

        [HttpGet]
        [Route("getRecordId")]
        public IActionResult GetRecordId(long idUser, int idRecord)
        {
            try
            {
                return Ok(_dataRecordService.GetRecordId(idUser, idRecord));
            }
            catch (RecordNotFoundException ex)
            {
                return NotFound(ex.Message);
            }
        }

        [HttpPost]
        [Route("add")]
        public IActionResult Add(DataRecord dataRecord)
        {
            _dataRecordService.Add(dataRecord);
            return Ok();
        }

        [HttpPut]
        [Route("setDateRecord")]
        public IActionResult SetDateRecord(long id, DateTime date)
        {
            try
            {
                _dataRecordService.SetDataRecordDate(id, date);
                return Ok();
            }
            catch (RecordNotFoundException ex)
            {
                return NotFound(ex.Message);
            }
        }

        [HttpDelete]
        [Route("delete")]
        public IActionResult Delete(long id)
        {
            try
            {
                _dataRecordService.Delete(id);
                return Ok();
            }
            catch (RecordNotFoundException ex)
            {
                return NotFound(ex.Message);
            }
        }

        [HttpDelete]
        [Route("deleteByUserId")]
        public IActionResult DeleteByUserId(long idUser)
        {
            try
            {
                _dataRecordService.DeleteUserDataRecords(idUser);
                return Ok();
            }
            catch (RecordNotFoundException ex)
            {
                return NotFound(ex.Message);
            }
        }

        [HttpDelete]
        [Route("deleteByRecordType")]
        public IActionResult DeleteDataRecordsByRecordType(int idRecord)
        {
            try
            {
                _dataRecordService.DeleteDataRecordsByRecordType(idRecord);
                return Ok();
            }
            catch (RecordNotFoundException ex)
            {
                return NotFound(ex.Message);
            }
        }


    }
}
