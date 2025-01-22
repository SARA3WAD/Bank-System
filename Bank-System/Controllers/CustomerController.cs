using Bank_System.Dtos;
using Bank_System.Repos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Bank_System.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly ICustomerRepo _repo;

        public CustomerController(ICustomerRepo repo)
        {
            _repo = repo;
        }
        [HttpPost]
        public IActionResult PostCustomer(CustomerDto customer)
        {
            _repo.AddCustomer(customer);
            return Ok();
        }
        [HttpGet]
        public IActionResult GetCustomer_Account_BankCard()
        {
            var s = _repo.GetCustomer_Account_BankCard();
            return Ok(s);
        }
        [HttpGet("id")]
        public IActionResult GetById(int id)
        {
            var s = _repo.GetById(id);
            return Ok(s);
        } 
    }
}
