using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace GateBoys.Models
{
    public class OrdersVM
    {
        [Key]
        public int OId { get; set; }

        public string user { get; set; }

        public int orderId { get; set; }

        public int productId { get; set; }

        public string productName { get; set; }

        public byte[] Image { get; set; }

        public decimal Price { get; set; }

        public decimal TotalOrderCost { get; set; }

        public string DeliveryAddress { get; set; }

        public string orderDate { get; set; }

        public int Quantity { get; set; }

        public string status { get; set; }
    }
}