using OnlineRetailApp.Models;
using OnlineRetailApp.Models.ViewModel;
using OnlineRetailApp.Repository.EntityModel;
using System;
using System.Collections.Generic;

namespace OnlineRetailApp.Services.Interface
{
    public interface IOrderService
    {
        List<Order> Get();
        void PlaceOrder(OrderViewModel orderViewModel);
        Order GetOrderDetail(Guid OrderId);
        void Delete(Order order);




    }
}
