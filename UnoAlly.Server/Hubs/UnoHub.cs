using Microsoft.AspNetCore.SignalR;
using System.Threading.Tasks;

namespace UnoAlly.Server.Hubs
{
    public class UnoHub : Hub
    {
        public async Task SendMessage(string user, string message)
        {
            await Clients.All.SendAsync("ReceiveMessage", user, message);
        }
    }
}