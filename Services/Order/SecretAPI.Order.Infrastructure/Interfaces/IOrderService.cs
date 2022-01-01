using SecretAPI.Order.Models.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecretAPI.Order.Infrastructure.Interfaces
{
    public interface IOrderService
    {
        public OrderDTO GetOrderById(int OrderId);
    }
}
