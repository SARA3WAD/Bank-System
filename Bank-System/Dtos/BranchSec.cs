using Bank_System.Models;
using System.ComponentModel.DataAnnotations;

namespace Bank_System.Dtos
{
    public class BranchSec
    {
        public int BranchId { get; set; }
        [Required]
        public string BranchName { get; set; }
        [Required]
        public string BranchLocation { get; set; }
        public List<EmployeeDto> employees { get; set; }
    }
}
