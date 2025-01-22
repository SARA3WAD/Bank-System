namespace Bank_System.Models
{
    public class Employee
    {
        public int EmployeeId { get; set; }
        public string EmployeeName { get; set; }
        public string EmployeePosition { get; set; }
        public List<Branch> branches { get; set; }
    }
}
