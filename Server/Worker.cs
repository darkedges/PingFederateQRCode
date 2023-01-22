using Microsoft.AspNetCore.SignalR;

namespace PingFederateQRCode.Server
{
    public class Worker : BackgroundService
    {
        private readonly ILogger<Worker> _logger;
        private readonly IHubContext<QrCodeHub, IQRCode> _qrCodeHub;

        public Worker(ILogger<Worker> logger, IHubContext<QrCodeHub, IQRCode> qrCodeHub)
        {
            _logger = logger;
            _qrCodeHub = qrCodeHub;
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            while (!stoppingToken.IsCancellationRequested)
            {
                _logger.LogInformation("Worker running at: {Time}", DateTime.Now);
                await _qrCodeHub.Clients.All.ShowTime(DateTime.Now);
                await Task.Delay(1000, stoppingToken);
            }
        }
    }
}
