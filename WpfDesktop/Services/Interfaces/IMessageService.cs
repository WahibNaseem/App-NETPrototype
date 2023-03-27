using System.Collections.Generic;
using System.Threading.Tasks;
using WpfDesktop.ViewModels;

namespace WpfDesktop.Services
{
    public interface IMessageService
    {
        Task<List<MessageViewModel>> GetAllAsync();
        Task<bool> PostMessage(MessageViewModel message);
    }
}
