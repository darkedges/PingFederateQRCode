using Microsoft.AspNetCore.SignalR;

namespace PingFederateQRCode.Server.hubs
{
    public class QRCodeHub : Hub
    {
        public async Task SendMessage(string user, string message)
        {
            await Clients.All.SendAsync("ReceiveMessage", user, message);
        }
    }
}
