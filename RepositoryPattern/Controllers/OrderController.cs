using Microsoft.AspNetCore.Mvc;
using RepositoryPattern.Models;
using RepositoryPattern.Repositories.Interfaces;
using RepositoryPattern.Transaction.Interfaces;

namespace RepositoryPattern.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly ICustomerRepository _customerRepository;
        private readonly IOrderRepository _orderRepository;
        private readonly IUnitOfWork _uoW;

        public OrderController(
            ICustomerRepository customerRepository, 
            IOrderRepository orderRepository,
            IUnitOfWork uoW)
        {
            _customerRepository = customerRepository;
            _orderRepository = orderRepository;
            _uoW = uoW;
        }

        [HttpPost]
        [Route("")]
        public Order Post()
        {
            try{
                var customer = new Customer { Name = "Gabriel" };
                var order = new Order
                {
                    Customer = customer,
                    Number = "AB1245"
                };

                _customerRepository.Save(customer);
                _orderRepository.Save(order);

                _uoW.Commit();

                return order;
            }
            catch
            {
                _uoW.Rollback();
                return null;
            }
        }
    }
}
