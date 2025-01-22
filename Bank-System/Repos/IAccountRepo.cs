using Bank_System.Dtos;

namespace Bank_System.Repos
{
    public interface IAccountRepo
    {
        public void AddAccount(AccountDto accountDto);
        public void DeleteAccount(int id);
    }
}
