using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PingFederateQRCode.Shared;
using System.Reflection;

namespace PingFederateQRCode.Server.Controllers
{
    [Route("api/qrcode")]
    [ApiController]
    public class QRCodeAuthController : ControllerBase
    {

        private readonly ILogger<QRCodeAuthController> _logger;

        public QRCodeAuthController(ILogger<QRCodeAuthController> logger)
        {
            _logger = logger;
        }

        [HttpPost("")]
        public IActionResult Post()
        {
            QRCodeResponse response = new QRCodeResponse
            {
                Summary = "Created"
            };
            return Created("api/qrcode", response);
        }
    }
}
