using OnlineRetailApp.Models;
using OnlineRetailApp.Models.ViewModel;
using OnlineRetailApp.Repository.EntityModel;
using OnlineRetailApp.Repository.Implementation;
using OnlineRetailApp.Repository.Interface;
using OnlineRetailApp.Services.Interface;
using System;
using System.Collections.Generic;


namespace OnlineRetailApp.Services.Implementation
{
    public class OrderService : IOrderService
    {

        private readonly IOrderRepository _orderRepository;
        private readonly IProductRepository _productRepository;
        public OrderService(IOrderRepository orderRepository, IProductRepository productRepository)
        {
            _orderRepository = orderRepository;
            _productRepository = productRepository;
        }


        public List<Order> Get()
        {
            return _orderRepository.Get();
        }

        public Order GetOrderDetail(Guid id)
        {
             return   _orderRepository.GetOrderDetail(id);
         }


        public void PlaceOrder(OrderViewModel orderViewModel)
        {

            var order= new Order()
                {
                    //OrderId = orderViewModel.OrderId,
                    ProductId = orderViewModel.ProductId,
                    CustomerId = Guid.NewGuid(),
                    Quantity = orderViewModel.Quantity,
                    OrderedDate = DateTime.UtcNow,
                    ShippingDate = DateTime.UtcNow.AddDays(5)

                };
            _orderRepository.PlaceOrder(order);
            _productRepository.UpdateQuantity(order);


        }

        public void Delete(Order order)
        {
            _orderRepository.Delete(order);
        }
       

    }
}
