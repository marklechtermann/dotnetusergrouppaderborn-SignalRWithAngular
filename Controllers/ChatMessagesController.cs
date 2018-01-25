using System.Collections.Generic;
using lightning_talk_signalr_dotnetcore.Models;
using lightning_talk_signalr_dotnetcore.Services;
using Microsoft.AspNetCore.Mvc;

namespace lightning_talk_signalr_dotnetcore.Controllers
{

    [Route("api/[controller]")]
    public class ChatMessagesController : Controller
    {
        private readonly IChatMessageService service;

        public ChatMessagesController(IChatMessageService service)
        {
            this.service = service;
        }

        [HttpGet]
        public IEnumerable<ChatMessage> Get()
        {
            return this.service.GetAll();
        }

        [HttpPost]
        public void Post([FromBody]ChatMessage message)
        {
            this.service.Add(message);
        }
    }
}