using Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data
{
  public class MessageContext : DbContext
  {
    public MessageContext(DbContextOptions<MessageContext> options) : base(options) { }

    public DbSet<Message> Messages { get; set; }
  }
}