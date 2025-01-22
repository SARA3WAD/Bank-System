using Bank_System.Dtos;
using Bank_System.Repos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Bank_System.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BranchController : ControllerBase
    {
        private readonly IBranchRepo _repo;

        public BranchController(IBranchRepo repo)
        {
            _repo = repo;
        }
        [HttpPost]
        public IActionResult PostBranch(BranchDto branchDto)
        {
            _repo.AddBranch(branchDto);
            return Ok();
        }
        [HttpGet]
        public IActionResult GetBranch_Employee()
        {
            var s = _repo.GetBranchEmployee();
            return Ok(s);
        }
        [HttpDelete]
        public IActionResult DeleteBranch(int id)
        {
            _repo.DeleteBranch(id);
            return Ok();
        }
    }
}
