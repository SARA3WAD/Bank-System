using Bank_System.Dtos;
using Bank_System.Models;

namespace Bank_System.Repos
{
    public class BankCardRepo:IBankCardRepo
    {
        private readonly AppDbContext _context;

        public BankCardRepo(AppDbContext context)
        {
            _context = context;
        }
        public void AddBankCard(BankCardDto bankCardDto)
        {
            BankCard bankCard = new BankCard
            {
                CardNumber = bankCardDto.CardNumber,
                ExpiryDate = bankCardDto.ExpiryDate,
                CustomerId = bankCardDto.customer_id
            };
            _context.bankCards.Add(bankCard);
            _context.SaveChanges();
        }
    }
}
