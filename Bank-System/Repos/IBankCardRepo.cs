using Bank_System.Dtos;

namespace Bank_System.Repos
{
    public interface IBankCardRepo
    {
        public void AddBankCard(BankCardDto bankCardDto);
    }
}
