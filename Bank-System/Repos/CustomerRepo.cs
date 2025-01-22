using Bank_System.Dtos;
using Bank_System.Models;

namespace Bank_System.Repos
{
    public class CustomerRepo:ICustomerRepo
    {
        private readonly AppDbContext _context;

        public CustomerRepo(AppDbContext context)
        {
            _context = context;
        }
        public void AddCustomer(CustomerDto customerDto)
        {
            Customer customer = new Customer
            {
                CustomerName = customerDto.CustomerName,
                CustomerEmail = customerDto.CustomerEmail,
                CustomerPhoneNumber = customerDto.CustomerPhoneNumber
            };
            _context.customers.Add(customer);
            _context.SaveChanges();
        }
        public List<CustomerSec> GetCustomer_Account_BankCard()
        {
            var s = _context.customers.Select(i => new CustomerSec
            {
                CustomerId = i.CustomerId,
                CustomerName = i.CustomerName,
                CustomerEmail = i.CustomerEmail,
                CustomerPhoneNumber = i.CustomerPhoneNumber,
                accounts = i.accounts.Select(i => new AccountDto
                {
                    AccountId = i.AccountId,
                    AccountNumber = i.AccountNumber,
                    AccountBalance = i.AccountBalance
                }).ToList(),
                BankCard = new BankCardDto
                {
                    BankCardId = i.BankCard.BankCardId,
                    CardNumber = i.BankCard.CardNumber,
                    ExpiryDate = i.BankCard.ExpiryDate
                }

            }).ToList();
            return s;
        }
        public CustomerSec GetById(int id)
        {
            var s = _context.customers.Where(i => i.CustomerId == id)
                .Select(i => new CustomerSec
                {
                    CustomerId = i.CustomerId,
                    CustomerName = i.CustomerName,
                    CustomerPhoneNumber = i.CustomerPhoneNumber,
                    CustomerEmail = i.CustomerEmail,
                    accounts = i.accounts.Select(i => new AccountDto
                    {
                        AccountId = i.AccountId,
                        AccountBalance = i.AccountBalance,
                        AccountNumber = i.AccountNumber
                    }).ToList(),
                    BankCard = new BankCardDto
                    {
                        BankCardId = i.BankCard.BankCardId,
                        CardNumber = i.BankCard.CardNumber,
                        ExpiryDate = i.BankCard.ExpiryDate,
                    }
                }).FirstOrDefault();
            return s;
        }
    }
}
