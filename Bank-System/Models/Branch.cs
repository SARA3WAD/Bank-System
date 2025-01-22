using System.ComponentModel.DataAnnotations;

namespace Bank_System.Models
{
    public class Branch
    {
        public int BranchId { get; set; }
        [Required]
        public string BranchName { get; set; }
        [Required]
        public string BranchLocation { get; set; }
        public List<Employee> employees { get; set; }

    }
}
