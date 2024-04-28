using MicroRabbit.Banking.Application.Interfaces;
using MicroRabbit.Banking.Domain.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Identity.Client;

namespace MicroRabbit.Banking.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BankingController : ControllerBase
    {

        private readonly IAccountService _accountService;            

        private readonly ILogger<BankingController> _logger;

        public BankingController(ILogger<BankingController> logger, IAccountService accountService)
        {
            _logger = logger;
            _accountService = accountService;
        }

        [HttpGet(Name = "GetAccounts")]
        public ActionResult<IEnumerable<Account>> Get()
        {
           return Ok(_accountService.GetAccounts());
        }
    }
}
