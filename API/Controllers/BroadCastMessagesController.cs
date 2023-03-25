using System.Collections.Generic;
using System.Threading.Tasks;
using Infrastructure.Data;
using Core.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers
{
  [ApiController]
  [Route("api/[controller]")]
  public class BroadCastMessagesController : ControllerBase
  {
    private readonly MessageContext _context;

    public BroadCastMessagesController(MessageContext context)
    {
      _context = context;

    }

    [HttpGet]
    public async Task<ActionResult<IList<Message>>> GetMessages()
    {
      var messages = await _context.Messages.ToListAsync();
      return Ok(messages);
    }

    [HttpPost("message")]
    public async Task<ActionResult> AddNewMessage([FromBody] Message message)
    {
      if (message == null)
      {
        return BadRequest();
      }

      _context.Messages.Add(message);
      await _context.SaveChangesAsync();

      return Ok();
    }

  }
}