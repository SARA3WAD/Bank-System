using Bank_System.Dtos;

namespace Bank_System.Repos
{
    public interface ICustomerRepo
    {
        public void AddCustomer(CustomerDto customerDto);
        public List<CustomerSec> GetCustomer_Account_BankCard();
        public CustomerSec GetById(int id);
    }
}
