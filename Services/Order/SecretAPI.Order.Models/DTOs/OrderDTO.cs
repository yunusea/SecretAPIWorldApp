using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecretAPI.Order.Models.DTOs
{
    public class OrderDTO
    {
        public int Id { get; set; }

        public int OrderId { get; set; }

        public DateTime? OrderCreationDate { get; set; }

        public DateTime? OrderFinallyingDate { get; set; }
        public decimal TotalOrderAmount { get; set; }

    }
}
