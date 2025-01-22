using Bank_System.Models;
using System.ComponentModel.DataAnnotations;

namespace Bank_System.Dtos
{
    public class CustomerSec
    {
        public int CustomerId { get; set; }
        [Required]
        public string CustomerName { get; set; }
        [Required]
        public string CustomerEmail { get; set; }
        [Phone]
        public string CustomerPhoneNumber { get; set; }
        public List<AccountDto> accounts { get; set; }
        public BankCardDto BankCard { get; set; }
    }
}
