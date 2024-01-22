using Microsoft.AspNetCore.SignalR;

namespace Messenger.Models.Hubs
{
    public class ChatHub:Hub
    {
        public async Task SendMessage(Message message)
            => await Clients.All.SendAsync("receve Message", message);

    }
}
