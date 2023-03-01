using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace asm2_1651_DTS
{
    public class OrderDetail
    {
        public int Quantity { get; set; }
        public Product Product { get; set; }
        public Order Order { get; set; }
        public OrderDetail(int quantity, Product product, Order order)
        {
            Quantity = quantity;
            Product = product;
            Order = order;
        }
        public OrderDetail()
        {
        }
    }
}