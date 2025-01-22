using Bank_System.Dtos;
using Bank_System.Models;

namespace Bank_System.Repos
{
    public class AccountRepo:IAccountRepo
    {
        private readonly AppDbContext _context;

        public AccountRepo(AppDbContext context)
        {
            _context = context;
        }
        public void AddAccount(AccountDto accountDto)
        {
            Account account = new Account
            {
                AccountNumber = accountDto.AccountNumber,
                AccountBalance = accountDto.AccountBalance,
                CustomerId = accountDto.customer_id,
            };
            _context.accounts.Add(account);
            _context.SaveChanges();
        }
        public void DeleteAccount(int id)
        {
            var s = _context.accounts.FirstOrDefault(i => i.AccountId == id);
            _context.accounts.Remove(s);
            _context.SaveChanges();
        }
    }
}
