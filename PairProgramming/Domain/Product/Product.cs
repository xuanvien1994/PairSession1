using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Product
{
    public class Product
    {
        public Product(double price)
        {
            Price = price;
        }
        public double Price { get; set; }
    }
}
