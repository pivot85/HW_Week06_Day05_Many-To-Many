﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodeFirstApp.Models
{
    public class Product_Order
    {
        public int ProductId { get; set; }
        public ProductModel Product { get; set; }

        public int OrderId { get; set; }
        public OrderModel Order { get; set; }
    }
}