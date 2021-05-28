﻿using RepositoryPattern.Data;
using RepositoryPattern.Models;
using RepositoryPattern.Repositories.Interfaces;

namespace RepositoryPattern.Repositories
{
    public class OrderRepository : IOrderRepository
    {
        private readonly DataContext _context;

        public OrderRepository(DataContext context)
        {
            _context = context;
        }

        public void Save(Order order)
        {
            _context.Orders.Add(order);
        }
    }
}
