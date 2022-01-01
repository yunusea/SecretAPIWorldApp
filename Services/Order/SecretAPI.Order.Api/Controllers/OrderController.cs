using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SecretAPI.Order.Infrastructure.Interfaces;
using SecretAPI.Order.Models.DTOs;

namespace SecretAPI.Order.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly IOrderService orderService;

        public OrderController(IOrderService OrderService)
        {
            orderService = OrderService;
        }

        [HttpGet("{OrderId}")]
        public OrderDTO Order(int OrderId)
        {
            return orderService.GetOrderById(OrderId);
        }
    }
}
