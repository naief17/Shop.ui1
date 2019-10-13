using System;
using System.Collections.Generic;
using System.Text;

namespace Shop.Domain.Models
{
    public class Order
    {
        public int Id { get; set; }
        public String OrderRef { get; set; }
        public String Adress1 { get; set; }
        public String Adress2 { get; set; }
        public String Adress3 { get; set; }
        public String PostCode { get; set; }

        public ICollection<OrderProduct> OrderProducts { get; set; }
    }
}
