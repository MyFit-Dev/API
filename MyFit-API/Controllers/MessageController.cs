using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using MyFit_API.Exceptions.LogException;
using MyFit_API.Services;
using MyFit_Libs.Models;

namespace MyFit_API.Controllers
{
    [EnableCors]
    [ApiController]
    [Route("/api/Message")]
    public class MessageController : ControllerBase
    {

        private MessageService _messageService;

        public MessageController(MessageService messageService)
        {
            _messageService = messageService;
        }

        [Route("getAll")]
        [HttpGet]
        public IActionResult GetAllMessages()
        {
            try
            { 
                return Ok(_messageService.GetAllMessages());
            }
            catch (LogNotFoundException ex)
            {
                return NotFound(ex.Message);
            }
        }

        [Route("get")]
        [HttpGet]
        public IActionResult GetMessage(long id)
        {
            try
            {
                return Ok(_messageService.GetMessage(id));
            }
            catch (LogNotFoundException ex)
            {
                return NotFound(ex.Message);
            }
        }

        [Route("getBySender")]
        [HttpGet]
        public IActionResult GetMessagesBySender(long idSender)
        {
            try
            {
                return Ok(_messageService.GetMessagesBySender(idSender));
            }
            catch (LogNotFoundException ex)
            {
                return NotFound(ex.Message);
            }
        }

        [Route("getByRecipient")]
        [HttpGet]
        public IActionResult GetMessagesByRecipient(long idRecipient)
        {
            try
            {
                return Ok(_messageService.GetMessagesByRecipient(idRecipient));
            }
            catch (LogNotFoundException ex)
            {
                return NotFound(ex.Message);
            }
        }

        [Route("getBySenderAndRecipient")]
        [HttpGet]
        public IActionResult GetMessagesBySenderAndRecipient(long idSender, long idRecipient)
        {
            try
            {
                return Ok(_messageService.GetMessagesBySenderAndRecipient(idSender, idRecipient));
            }
            catch (LogNotFoundException ex)
            {
                return NotFound(ex.Message);
            }
        }

        [Route("getText")]
        [HttpGet]
        public IActionResult GetTextMessage(long id)
        {
            try
            {
                return Ok(_messageService.GetTextMessage(id));
            }
            catch (LogNotFoundException ex)
            {
                return NotFound(ex.Message);
            }
        }

        [Route("getDate")]
        [HttpGet]
        public IActionResult GetDateMessage(long id)
        {
            try
            {
                return Ok(_messageService.GetDateMessage(id));
            }
            catch (LogNotFoundException ex)
            {
                return NotFound(ex.Message);
            }
        }

        [Route("getIdSender")]
        [HttpGet]
        public IActionResult GetIdSenderMessage(long id)
        {
            try
            {
                return Ok(_messageService.GetIdSenderMessage(id));
            }
            catch (LogNotFoundException ex)
            {
                return NotFound(ex.Message);
            }
        }

        [Route("isRead")]
        [HttpGet]
        public IActionResult IsReadMessage(long id)
        {
            try
            {
                return Ok(_messageService.GetIsReadMessage(id));
            }
            catch (LogNotFoundException ex)
            {
                return NotFound(ex.Message);
            }
        }

        [Route("add")]
        [HttpPost]
        public IActionResult AddMessage(Message message)
        {
            _messageService.AddMessage(message);
            return Ok();
        }

        [Route("setText")]
        [HttpPut]
        public IActionResult SetTextMessage(long id, string text)
        {
            if (text == null)
                return BadRequest("Text is null");

            try
            {
                _messageService.SetTextMessage(id, text);
                return Ok();
            }
            catch (LogNotFoundException ex)
            {
                return NotFound(ex.Message);
            }
        }

        [Route("setDate")]
        [HttpPut]
        public IActionResult SetDateMessage(long id, DateTime date)
        {
            try
            {
                _messageService.SetDateMessage(id, date);
                return Ok();
            }
            catch (LogNotFoundException ex)
            {
                return NotFound(ex.Message);
            }
        }

        [Route("setIdSender")]
        [HttpPut]
        public IActionResult SetIdSenderMessage(long id, long idSender)
        {
            try
            {
                _messageService.SetIdSenderMessage(id, idSender);
                return Ok();
            }
            catch (LogNotFoundException ex)
            {
                return NotFound(ex.Message);
            }
        }

        [Route("setIsRead")]
        [HttpPut]
        public IActionResult SetIsReadMessage(long id, bool isRead)
        {
            try
            {
                _messageService.SetIsReadMessage(id, isRead);
                return Ok();
            }
            catch (LogNotFoundException ex)
            {
                return NotFound(ex.Message);
            }
        }

        [Route("delete")]
        [HttpDelete]
        public IActionResult DeleteMessage(long id)
        {
            try
            {
                _messageService.DeleteMessage(id);
                return Ok();
            }
            catch (LogNotFoundException ex)
            {
                return NotFound(ex.Message);
            }
        }

        [Route("deleteBySender")]
        [HttpDelete]
        public IActionResult DeleteMessagesBySender(long idSender)
        {
            try
            {
                _messageService.DeleteMessagesBySender(idSender);
                return Ok();
            }
            catch (LogNotFoundException ex)
            {
                return NotFound(ex.Message);
            }
        }

        [Route("deleteByRecipient")]
        [HttpDelete]
        public IActionResult DeleteMessagesByRecipient(long idRecipient)
        {
            try
            {
                _messageService.DeleteMessagesByRecipient(idRecipient);
                return Ok();
            }
            catch (LogNotFoundException ex)
            {
                return NotFound(ex.Message);
            }
        }

        [Route("deleteBySenderAndRecipient")]
        [HttpDelete]
        public IActionResult DeleteMessagesBySenderAndRecipient(long idSender, long idRecipient)
        {
            try
            {
                _messageService.DeleteMessagesBySenderAndRecipient(idSender, idRecipient);
                return Ok();
            }
            catch (LogNotFoundException ex)
            {
                return NotFound(ex.Message);
            }
        }

    }
}
