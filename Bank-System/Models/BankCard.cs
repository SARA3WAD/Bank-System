using System.ComponentModel.DataAnnotations;

namespace Bank_System.Models
{
    public class BankCard
    {
        public int BankCardId { get; set; }
        [Required]
        public string CardNumber { get; set; }
        [Required]
        public DateTime ExpiryDate { get; set; }
        public Customer Customer { get; set; }
        public int CustomerId { get; set; }
    }
}
