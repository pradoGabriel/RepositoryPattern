using RepositoryPattern.Data;
using RepositoryPattern.Models;
using RepositoryPattern.Repositories.Interfaces;

namespace RepositoryPattern.Repositories
{
    public class CustomerRepository : ICustomerRepository
    {
        private readonly DataContext _context;

        public CustomerRepository(DataContext context)
        {
            _context = context;
        }

        public void Save(Customer customer)
        {
            _context.Customers.Add(customer);
        }
    }
}
