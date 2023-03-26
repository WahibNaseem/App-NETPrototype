using System.Collections.Generic;
using System.Threading.Tasks;
using Core.Domain;
using Microsoft.AspNetCore.Mvc;
using Services.Interfaces;
using Services.Dto;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BroadCastMessagesController : ControllerBase
    {
        private readonly IMessageService _msgService;

        public BroadCastMessagesController(IMessageService msgService)
        {
            _msgService=msgService;
        }

        [HttpGet("{sender}")]
        public async Task<ActionResult<IList<Message>>> GetMessages(string sender)
        {
            if(string.IsNullOrEmpty(sender))
            { 
                return BadRequest();
            }
            var messages = await _msgService.GetAllMessageAsync(sender);
            return Ok(messages);
        }

        [HttpPost("message")]
        public async Task<ActionResult> AddNewMessage([FromBody] NewMessageDto message)
        {
            if(message == null)
            {
                return BadRequest();
            }

            await _msgService.AddMessageAsync(message);

            return Ok();
        }

    }
}