using System;
using System.Collections.Generic;

namespace EcoPowerAPI.Models
{
    public partial class Order
    {
        public Order()
        {
            OrderDetails = new HashSet<OrderDetail>();
        }

        public Guid OrderId { get; set; }
        public DateTime OrderDate { get; set; }
        public Guid CustomerId { get; set; }
        public string DeliveryAddress { get; set; } = "";

        public  Customer Customer { get; set; } 
        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
    }
}
