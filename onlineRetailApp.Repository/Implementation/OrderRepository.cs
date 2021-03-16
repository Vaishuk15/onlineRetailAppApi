using OnlineRetailApp.Repository.EntityModel;
using OnlineRetailApp.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;

namespace OnlineRetailApp.Repository.Implementation
{
    public class OrderRepository : IOrderRepository
    {

        private readonly AppDbContext _dbContext;

        public OrderRepository(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public List<Order> Get()
        {
            return _dbContext.Orders.ToList();
        }

        public void PlaceOrder(Order order)
        {

            _dbContext.Add(order);
            _dbContext.SaveChanges();
        }
        public Order GetOrderDetail(Guid OrderId)

        {
            return _dbContext.Orders.FirstOrDefault(o => o.OrderId == OrderId);
        }
        public void Delete(Order order)
        {
            _dbContext.Orders.Remove(order);
            _dbContext.SaveChanges();
        }



    }
}

