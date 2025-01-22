using Bank_System.Dtos;
using Bank_System.Repos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Bank_System.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly IAccountRepo _repo;

        public AccountController(IAccountRepo repo)
        {
            _repo = repo;
        }
        [HttpPost]
        public IActionResult PostAccount(AccountDto account)
        {
            _repo.AddAccount(account);
            return Ok();
        }
        [HttpDelete]
        public IActionResult DeleteAccount(int id) {
            _repo.DeleteAccount(id);
            return Ok("Successful Deleted");
        }
    }
}
