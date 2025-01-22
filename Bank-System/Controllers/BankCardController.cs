using Bank_System.Dtos;
using Bank_System.Repos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Bank_System.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BankCardController : ControllerBase
    {
        private readonly IBankCardRepo _repo;

        public BankCardController(IBankCardRepo repo)
        {
            _repo = repo;
        }
        [HttpPost]
        public  IActionResult AddBankCard(BankCardDto bankCard)
        {
            _repo.AddBankCard(bankCard);
            return Ok();
        }
    }
}
