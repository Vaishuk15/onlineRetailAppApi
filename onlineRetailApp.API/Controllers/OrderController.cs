using Microsoft.AspNetCore.Mvc;
using OnlineRetailApp.Models;
using OnlineRetailApp.Repository.EntityModel;
using OnlineRetailApp.Services.Interface;
using System;

namespace OnlineRetailApp.API.Controllers
{
    
    
        [ApiController]
        [Route("[controller]")]
        public class OrderController : ControllerBase
        {
            private readonly IOrderService _orderService;



            public OrderController(IOrderService orderService)
            {
                _orderService = orderService;
            }
            [HttpGet]
            public IActionResult Get()
            {
                return Ok(_orderService.Get());
            }

            [HttpPost]
            public IActionResult PlaceOrder([FromBody] OrderViewModel orderViewModel)
            {
            _orderService.PlaceOrder(orderViewModel);
                return Ok("product ordered!");
            }
            [HttpDelete("{OrderId}")]
            public IActionResult Delete(Guid OrderId)
            {
                Order order = _orderService.GetOrderDetail(OrderId);
                if (order == null)
                {
                    return NotFound("The product details couldn't be found.");
                }
                _orderService.Delete(order);
                return NoContent();
            }
            [HttpGet("GetOrderDetail/{OrderId}")]
            public IActionResult GetOrderDetail(Guid OrderId)
            {
                Order order = _orderService.GetOrderDetail(OrderId);
                if (order == null)
                {

                    return NotFound("The order details couldn't be found.");
                }
                return Ok(order);
            }


        }
    }



    

