using System.ComponentModel.DataAnnotations;

namespace Bank_System.Models
{
    public class Customer
    {
        public int CustomerId { get; set; }
        [Required]
        public string CustomerName { get; set; }
        [Required]
        public string CustomerEmail { get; set; }
        [Phone]
        public string CustomerPhoneNumber { get; set; }
        public List<Account> accounts { get; set; }
        public BankCard BankCard { get; set; }
    }
}
