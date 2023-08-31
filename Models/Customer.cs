using System;
using System.Collections.Generic;

namespace EcoPowerAPI.Models
{
    public partial class Customer
    {
       public Customer()
        {
            Orders = new HashSet<Order>();
        }

        public Guid CustomerId { get; set; }
        public string CustomerTitle { get; set; }
        public string CustomerName { get; set; }
        public string CustomerSurname { get; set; }
        public string CellPhone { get; set; }


        public virtual ICollection<Order> Orders { get; set; }
    }
}
