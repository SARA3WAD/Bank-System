using System.ComponentModel.DataAnnotations;

namespace Bank_System.Models
{
    public class Account
    {
        //New Commit
        public int AccountId { get; set; }
        [Required,MaxLength(20)]
        public string AccountNumber { get; set; }
        [Required]
        public int AccountBalance { get; set; }
        public Customer Customer { get; set; }
        public int CustomerId { get; set; }
        public List<Transaction> transactions { get; set; }
    }
}
