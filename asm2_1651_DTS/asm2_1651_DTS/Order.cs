using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace asm2_1651_DTS
{
    public class Order
    {
        List<OrderDetail> orderDetails = new List<OrderDetail>();
        public int OrderId { get; set; }
        public Customer Customer { get; set; }
        public DateTime Date { get; set; }
        internal List<OrderDetail> OrderDetails { get => orderDetails; set => orderDetails = value; }
        public Order(int orderId, Customer customer, DateTime date)
        {
            OrderId = orderId;
            Customer = customer;
            Date = date;
        }
        public Order()
        {
        }
    }
}