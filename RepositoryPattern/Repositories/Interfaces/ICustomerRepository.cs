using RepositoryPattern.Models;

namespace RepositoryPattern.Repositories.Interfaces
{
    public interface ICustomerRepository
    {
        void Save(Customer customer);
    }
}
