using PotteryWebShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PotteryWebShop.Models
{
    public class OrderDetail
    {
        public int OrderDetailId { get; set; }
        public int OrderId { get; set; }
        public int ProductId { get; set; }
        public int Amount { get; set; }
        public decimal Price { get; set; }
        public PotteryProduct Product { get; set; }
        public Order Order { get; set; }
    }
}
