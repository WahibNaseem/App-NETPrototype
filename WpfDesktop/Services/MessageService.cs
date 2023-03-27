using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using WPFDesktop.Utils;
using WPFDesktop.ViewModels;

namespace WPFDesktop.Services
{
    public class MessageService : IMessageService
  {
    public async Task<List<MessageViewModel>> GetAllAsync()
    {
      /* To make a http used below httpClient handler to avoid ssl certificate*/

      using (var clientHandler = new HttpClientHandler())
      {
        clientHandler.ServerCertificateCustomValidationCallback = (sender, cert, chain, sslPolicyErrors) => { return true; };
        using (var client = new HttpClient(clientHandler))
        {
          client.BaseAddress = new Uri(ApiRoutes.Root);
          client.DefaultRequestHeaders.Accept.Clear();
          client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));


          var response = await client.GetAsync(ApiRoutes.BroadCastMessage.GetAll);
          if (response.IsSuccessStatusCode)
          {
            var messageList = await response.Content.ReadAsAsync<MessageViewModel[]>();
            return messageList.ToList();
          }
        }
        return new List<MessageViewModel>();
      }

    }

    public async Task<bool> PostMessage(MessageViewModel message)
    {
      /*make a http call and used below httpClient handler to avoid ssl certificate*/
      using (var clientHandler = new HttpClientHandler())
      {
        clientHandler.ServerCertificateCustomValidationCallback = (sender, cert, chain, sslPolicyErrors) => { return true; };
        using (var client = new HttpClient(clientHandler))
        {
          client.BaseAddress = new Uri(ApiRoutes.Root);
          client.DefaultRequestHeaders.Accept.Clear();
          client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

          var response = await client.PostAsJsonAsync(ApiRoutes.BroadCastMessage.Post, message);
          if (response.IsSuccessStatusCode)
          {
            return true;
          }
        }
        return false;
      }
    }
  }
}
