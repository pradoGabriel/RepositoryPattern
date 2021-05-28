using RepositoryPattern.Models;

namespace RepositoryPattern.Repositories.Interfaces
{
    public interface IOrderRepository
    {
        void Save(Order order);
    }
}
