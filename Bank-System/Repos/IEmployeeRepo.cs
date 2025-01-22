using Bank_System.Dtos;

namespace Bank_System.Repos
{
    public interface IEmployeeRepo
    {
        public void AddEmloyeeWithBranch(EmployeeSec employeeDto);
        public List<EmployeeSec> GetEmployeeWithBranches();
        public void UpdateEmployee(EmployeeDto employeeDto, int id);
    }
}
