using System.ComponentModel.DataAnnotations;

namespace Bank_System.Dtos
{
    public class CustomerDto
    {
        public int CustomerId { get; set; }
        [Required]
        public string CustomerName { get; set; }
        [Required]
        public string CustomerEmail { get; set; }
        [Phone]
        public string CustomerPhoneNumber { get; set; }
    }
}
