using SecretAPI.Order.Infrastructure.Interfaces;
using SecretAPI.Order.Models.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecretAPI.Order.Services.Services
{
    public class OrderService : IOrderService
    {
        public OrderDTO GetOrderById(int OrderId)
        {
            return new OrderDTO()
            {
                Id = new Random().Next(100),
                TotalOrderAmount = new Random().Next(10000),
                OrderCreationDate = DateTime.Now,
                OrderFinallyingDate = DateTime.Now.AddDays(7),
                OrderId = OrderId
            };
        }
    }
}
