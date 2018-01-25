using System.Collections.Generic;
using lightning_talk_signalr_dotnetcore.Models;

namespace lightning_talk_signalr_dotnetcore.Services
{
    public class ChatMessageService : IChatMessageService
    {
        private List<ChatMessage> messages = new List<ChatMessage>();

        public IEnumerable<ChatMessage> GetAll()
        {
            return this.messages;
        }

        public void Add(ChatMessage message)
        {
            this.messages.Add(message);
        }
    }
}