using Microsoft.AspNetCore.SignalR;
using System.Threading.Tasks;

namespace SignalRz.Hubs
{
    public class ChatHub : Hub
    {
      public async Task NewMessage(long username, string message)
        {
            await Clients.All.SendAsync("messageReceived", username, message);
        }
    }
}
