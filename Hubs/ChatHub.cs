using System.Threading.Tasks;
using lightning_talk_signalr_dotnetcore.Models;
using lightning_talk_signalr_dotnetcore.Services;
using Microsoft.AspNetCore.SignalR;

namespace lightning_talk_signalr_dotnetcore.Hubs
{
    public class ChatHub : Hub
    {
       private readonly IChatMessageService chatMessageService;
        public ChatHub(IChatMessageService chatMessageService)
        {
            this.chatMessageService = chatMessageService;
        }

        public Task Messages(ChatMessage data)
        {
            this.chatMessageService.Add(data);

            return Clients.All.InvokeAsync("Messages", data);
        }
    }
}