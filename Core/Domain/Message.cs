using System;
namespace Core.Domain
{
    public class Message
  {
    public Message()
    {
      SentDate = DateTime.Now;
    }
    public int Id { get; set; }
    public string Text { get; set; }
    public string Sender { get; set; }
    public DateTime SentDate { get; set; }


  }
}