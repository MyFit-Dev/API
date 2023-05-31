using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using MyFit_API.Exceptions.LogException;
using MyFit_API.Services;
using MyFit_Libs.Models;

namespace MyFit_API.Controllers
{

    [EnableCors]
    [ApiController]
    [Route("/api/Log")]
    public class LogController : ControllerBase
    {

        private LogService _logService;

        public LogController(LogService logService)
        {
            _logService = logService;
        }

        [Route("getAll")]
        [HttpGet]
        public IActionResult GetAllLogs()
        {
            try
            {
                return Ok(_logService.GetAllLogs());
            }
            catch (LogNotFoundException ex)
            {
                return NotFound(ex.Message);
            }
        }

        [Route("get")]
        [HttpGet]
        public IActionResult GetLog(long id)
        {
            try
            {
                return Ok(_logService.GetLog(id));
            }
            catch (LogNotFoundException ex)
            {
                return NotFound(ex.Message);
            }
        }

        [Route("getText")]
        [HttpGet]
        public IActionResult GetLogText(long id)
        {
            try
            {
                return Ok(_logService.GetLogText(id));
            }
            catch (LogNotFoundException ex)
            {
                return NotFound(ex.Message);
            }
        }

        [Route("getScope")]
        [HttpGet]
        public IActionResult GetLogScope(long id)
        {
            try
            {
                return Ok(_logService.GetLogScope(id));
            }
            catch (LogNotFoundException ex)
            {
                return NotFound(ex.Message);
            }
        }

        [Route("getDate")]
        [HttpGet]
        public IActionResult GetLogDate(long id)
        {
            try
            {
                return Ok(_logService.GetLogDate(id));
            }
            catch (LogNotFoundException ex)
            {
                return NotFound(ex.Message);
            }
        }

        [Route("getIdUser")]
        [HttpGet]
        public IActionResult GetLogIdUser(long id)
        {
            try
            {
                return Ok(_logService.GetLogIdUser(id));
            }
            catch (LogNotFoundException ex)
            {
                return NotFound(ex.Message);
            }
        }

        [Route("getValue")]
        [HttpGet]
        public IActionResult GetLogValue(long id)
        {
            try
            {
                return Ok(_logService.GetLogValue(id));
            }
            catch (LogNotFoundException ex)
            {
                return NotFound(ex.Message);
            }
        }

        [Route("add")]
        [HttpPost]
        public IActionResult AddLog(Log log)
        {
            if (log == null)
                return BadRequest("Log is null");

            _logService.AddLog(log);
            return Ok();
        }

        [Route("setText")]
        [HttpPut]
        public IActionResult SetLogText(long id, string text)
        {
            if (text == null)
                return BadRequest("Text is null");

            try
            {
                _logService.SetLogText(id, text);
                return Ok();
            }
            catch (LogNotFoundException ex)
            {
                return NotFound(ex.Message);
            }
        }

        [Route("setScope")]
        [HttpPut]
        public IActionResult SetLogScope(long id, string scope)
        {
            if (scope == null)
                return BadRequest("Scope is null");

            try
            {
                _logService.SetLogScope(id, scope);
                return Ok();
            }
            catch (LogNotFoundException ex)
            {
                return NotFound(ex.Message);
            }
        }

        [Route("setIdUser")]
        [HttpPut]
        public IActionResult SetLogIdUser(long id, long? idUser)
        {
            if (idUser == null)
                return BadRequest("IdUser is null");

            try
            {
                _logService.SetLogIdUser(id, idUser);
                return Ok();
            }
            catch (LogNotFoundException ex)
            {
                return NotFound(ex.Message);
            }
        }

        [Route("setValue")]
        [HttpPut]
        public IActionResult SetLogValue(long id, byte? value)
        {
            if (value == null)
                return BadRequest("Value is null"); 

            try
            {
                _logService.SetLogValue(id, value);
                return Ok();
            }
            catch (LogNotFoundException ex)
            {
                return NotFound(ex.Message);
            }
        }

        [Route("delete")]
        [HttpDelete]
        public IActionResult DeleteLog(long id)
        {
            try
            {
                _logService.DeleteLog(id);
                return Ok();
            }
            catch (LogNotFoundException ex)
            {
                return NotFound(ex.Message);
            }
        }

        [Route("deleteUserLogs")]
        [HttpDelete]
        public IActionResult DeleteUserLogs(long idUser)
        {
            _logService.DeleteUserLogs(idUser);
            return Ok();
        }

        [Route("deleteBefore")]
        [HttpDelete]
        public IActionResult DeleteLogsBeforeDate(DateTime date)
        {
            _logService.DeleteLogsBeforeDate(date);
            return Ok();
        }

        [Route("deleteBetween")]
        [HttpDelete]
        public IActionResult DeleteLogsBetweenDates(DateTime date1, DateTime date2)
        {
            _logService.DeleteLogsBetweenDates(date1, date2);
            return Ok();
        }

        [Route("deleteByValue")]
        [HttpDelete]
        public IActionResult DeleteLogsByValue(byte value)
        {
            _logService.DeleteLogsByValue(value);
            return Ok();
        }



        


    }
}
