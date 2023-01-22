using Microsoft.AspNetCore.SignalR;

namespace PingFederateQRCode.Server
{
    public class QrCodeHub : Hub<IQRCode>
    {
        public async Task SendTimeToClients(DateTime dateTime)
        {
            await Clients.All.ShowTime(dateTime);
        }
    }
}
