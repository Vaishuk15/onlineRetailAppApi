using OnlineRetailApp.Repository.EntityModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineRetailApp.Repository.Interface
{
   public  interface IOrderRepository
    {
        public List<Order> Get();
        public void PlaceOrder(Order order);
        Order GetOrderDetail(Guid orderId);
        void Delete(Order order);
    }
}
