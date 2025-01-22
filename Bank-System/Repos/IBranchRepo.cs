using Bank_System.Dtos;
using Bank_System.Models;

namespace Bank_System.Repos
{
    public interface IBranchRepo
    {
        public void AddBranch(BranchDto branch);
        public List<Branch> GetBranchEmployee();
        public void DeleteBranch(int id);
    }
}
