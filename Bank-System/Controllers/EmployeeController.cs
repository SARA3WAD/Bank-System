using Bank_System.Dtos;
using Bank_System.Repos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Bank_System.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeRepo _repo;

        public EmployeeController(IEmployeeRepo repo)
        {
            _repo = repo;
        }
        [HttpPost]
        public IActionResult PostEmployee_Branch(EmployeeSec employeeDto)
        {
            _repo.AddEmloyeeWithBranch(employeeDto);
            return Ok();
        }
        [HttpGet]
        public IActionResult GetEmployee_Branch()
        {
            var s = _repo.GetEmployeeWithBranches();
            return Ok(s);
        }
        [HttpPut]
        public IActionResult UpdateEmployee(EmployeeDto employeeDto,int id)
        {
            _repo.UpdateEmployee(employeeDto, id);
            return Accepted();
        }
    }
}
