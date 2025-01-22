using System.ComponentModel.DataAnnotations;

namespace Bank_System.Dtos
{
    public class BankCardDto
    {
        public int BankCardId { get; set; }
        [Required]
        public string CardNumber { get; set; }
        [Required]
        public DateTime ExpiryDate { get; set; }
        public int customer_id { get; set; }
    }
}
