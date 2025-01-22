using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;

namespace Bank_System.Models
{
    public class Transaction
    {
        public int TransactionId { get; set; }
        [Required]
        public int TransactionAmount { get; set; }
        [Required]
        public DateTime TransactionDate { get; set; }
        public Account Account { get; set; }
        public int AccountId { get; set; }
    }
}
