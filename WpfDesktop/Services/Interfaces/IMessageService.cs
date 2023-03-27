using System.Collections.Generic;
using System.Threading.Tasks;
using WPFDesktop.ViewModels;

namespace WPFDesktop.Services
{
    public interface IMessageService
    {
        Task<List<MessageViewModel>> GetAllAsync();
        Task<bool> PostMessage(MessageViewModel message);
    }
}
