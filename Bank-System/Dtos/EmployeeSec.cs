using Bank_System.Models;

namespace Bank_System.Dtos
{
    public class EmployeeSec
    {
        public int EmployeeId { get; set; }
        public string EmployeeName { get; set; }
        public string EmployeePosition { get; set; }
        public List<BranchDto> branches { get; set; }
    }
}
