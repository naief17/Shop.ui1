﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Shop.Domain.Models
{
   public class Stock
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public int Qty { get; set; }
        public String Description { get; set; }
    public Product Product  { get; set; }



}
}
