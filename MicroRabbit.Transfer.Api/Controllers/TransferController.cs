using MicroRabbit.Transfer.Application.Interfaces;
using MicroRabbit.Transfer.Domain.Model;
using Microsoft.AspNetCore.Mvc;

namespace MicroRabbit.Transfer.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TransferController : ControllerBase
    {
        private readonly ITransferService _transferService;

        private readonly ILogger<TransferController> _logger;

        public TransferController(ILogger<TransferController> logger, ITransferService transferService)
        {
            _transferService = transferService;
            _logger = logger;
        }

        [HttpGet(Name = "GetTransfer")]
        public ActionResult<IEnumerable<TransferLog>> Get()
        {
            return Ok(_transferService.GetTransferLogs());
        }
    }
}
