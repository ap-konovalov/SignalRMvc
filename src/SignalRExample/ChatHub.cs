using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR;

namespace SignalRExample
{
    // ReSharper disable once ClassNeverInstantiated.Global
    public class ChatHub: Hub
    {
        public Task SendMessage(string user, string message)
        {
            return Clients.All.SendAsync("ReceiveMessage", user, message);
        }
    }
}