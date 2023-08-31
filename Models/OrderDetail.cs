using System;
using System.Collections.Generic;

namespace EcoPowerAPI.Models
{
    public partial class OrderDetail
    {
        public Guid OrderDetailsId { get; set; }
        public Guid OrderId { get; set; }
        public Guid ProductId { get; set; }
        public int Quantity { get; set; } 
        public int Discount { get; set; }

        public virtual Order Order { get; set; } = null!;
        public virtual Product Product { get; set; } = null!;
    }
}
