using System.ComponentModel.DataAnnotations;

namespace Bank_System.Dtos
{
    public class AccountDto
    {
        public int AccountId { get; set; }
        [Required, MaxLength(20)]
        public string AccountNumber { get; set; }
        [Required]
        public int AccountBalance { get; set; }
        public int customer_id { get; set; }
    }
}
