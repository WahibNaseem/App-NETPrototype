using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Entities
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