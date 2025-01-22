using System.ComponentModel.DataAnnotations;

namespace Bank_System.Dtos
{
    public class BranchDto
    {
        public int BranchId { get; set; }
        [Required]
        public string BranchName { get; set; }
        [Required]
        public string BranchLocation { get; set; }
    }
}
