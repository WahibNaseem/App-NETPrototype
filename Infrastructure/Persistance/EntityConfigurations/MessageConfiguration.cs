using Core.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Persistance.EntityConfigurations
{
    public class MessageConfiguration : IEntityTypeConfiguration<Message>
  {
    public void Configure(EntityTypeBuilder<Message> builder)
    {
      builder.HasKey(x => x.Id);
      builder.Property(x => x.Text).IsRequired().HasMaxLength(36);
      builder.Property(x => x.Sender).IsRequired().HasMaxLength(16);
    }
  }
}