using System.ComponentModel.DataAnnotations;

namespace Bank_System.Dtos
{
    public class TransactionDto
    {
        public int TransactionId { get; set; }
        [Required]
        public int TransactionAmount { get; set; }
        [Required]
        public DateTime TransactionDate { get; set; }
    }
}
