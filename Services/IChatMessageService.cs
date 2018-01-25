using System.Collections.Generic;
using lightning_talk_signalr_dotnetcore.Models;

namespace lightning_talk_signalr_dotnetcore.Services
{
    public interface IChatMessageService
    {
        IEnumerable<ChatMessage> GetAll();
        
        void Add(ChatMessage message);
    }
}