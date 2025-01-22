using Bank_System.Dtos;
using Bank_System.Models;

namespace Bank_System.Repos
{
    public class BranchRepo : IBranchRepo
    {
        private readonly AppDbContext _context;

        public BranchRepo(AppDbContext context)
        {
            _context = context;
        }
        public void AddBranch(BranchDto branch)
        {
            Branch branch1 = new Branch
            {
                BranchName = branch.BranchName,
                BranchLocation = branch.BranchLocation
            };
            _context.branches.Add(branch1);
            _context.SaveChanges();
        }
        public List<Branch> GetBranchEmployee()
        {
            var s = _context.branches.Select(i => new Branch
            {
                BranchId = i.BranchId,
                BranchName = i.BranchName,
                BranchLocation = i.BranchLocation,
                employees = i.employees.Select(i => new Employee
                {
                    EmployeeId = i.EmployeeId,
                    EmployeeName = i.EmployeeName,
                    EmployeePosition = i.EmployeePosition
                }).ToList()
            }).ToList();
            return s;
        }
        public void DeleteBranch(int id)
        {
            var s = _context.branches.FirstOrDefault(i => i.BranchId == id);
            _context.branches.Remove(s);
            _context.SaveChanges();
        }
    }
}
