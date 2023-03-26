using System.Reflection;
using Core.Domain;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Persistance.Contexts
{
    public class MessageContext : DbContext
  {
    public MessageContext(DbContextOptions<MessageContext> options) : base(options) { }

    public DbSet<Message> Messages { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
      modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
    }
  }
}