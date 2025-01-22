using Bank_System.Dtos;
using Bank_System.Models;

namespace Bank_System.Repos
{
    public class EmployeeRepo:IEmployeeRepo
    {
        private readonly AppDbContext _context;

        public EmployeeRepo(AppDbContext context)
        {
            _context = context;
        }
        public void AddEmloyeeWithBranch(EmployeeSec employeeDto)
        {
            Employee employee = new Employee
            {
                EmployeeName = employeeDto.EmployeeName,
                EmployeePosition = employeeDto.EmployeePosition,
                branches = employeeDto.branches.Select(i => new Branch
                {
                    BranchName = i.BranchName,
                    BranchLocation = i.BranchLocation,
                }).ToList()
            };
            _context.employees.Add(employee);
            _context.SaveChanges();
        }
        public List<EmployeeSec> GetEmployeeWithBranches()
        {
            var s = _context.employees.Select(i => new EmployeeSec
            {
                EmployeeId = i.EmployeeId,
                EmployeeName = i.EmployeeName,
                EmployeePosition = i.EmployeePosition,
                branches = i.branches.Select(i => new BranchDto
                {
                    BranchId = i.BranchId,
                    BranchName = i.BranchName,
                    BranchLocation = i.BranchLocation
                }).ToList()
            }).ToList();
            return s;
        }
        public void UpdateEmployee(EmployeeDto employeeDto,int id)
        {
            var s = _context.employees.FirstOrDefault(i => i.EmployeeId == id);
            s.EmployeeName = employeeDto.EmployeeName;
            s.EmployeePosition = employeeDto.EmployeePosition;
            _context.employees.Update(s);
            _context.SaveChanges();
        }
    }
}
