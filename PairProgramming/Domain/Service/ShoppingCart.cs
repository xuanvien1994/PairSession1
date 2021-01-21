using System;
using System.Collections.Generic;
using System.Linq;
using Domain.Product;
using Domain.Product.Items;

namespace Domain.Service
{
    public class ShoppingCart : IShoppingCart
    {
        public List<Product.Product> Products = new List<Product.Product>();

        public void Add(Product.Product product, int count = 1)
        {
            if (product != null)
            {
                for (int i = 0; i < count; i++)
                {
                    Products.Add(product);
                }
            }
        }

        public double  TotalValue()
        {
            double total = 0;

            var jeans = Products.Where(p => p.GetType() == typeof(Jean)).ToList();
            var tshirts = Products.Where(p => p.GetType() == typeof(tshirt)).ToList();

            int jeanCount = jeans.Count;
            int tshirtCount = tshirts.Count;

            while (true)
            {
                if (jeanCount >1 && tshirtCount > 1)
                {
                    jeanCount -= 2;
                    tshirtCount -= 2;

                    total += 45;
                }
                else
                {
                    break;
                }
            }

            if (jeanCount > 0)
            {
                double packOf3Jean = Math.Floor((double) (jeanCount / 3));
                total += packOf3Jean * 3 * jeans[0].Price*(double)((double)2 / (double)3) + (jeanCount - packOf3Jean * 3) * jeans[0].Price;
            }


            foreach (var product in Products)
            {

                if(product.GetType() == typeof(Jean)) continue;

                if (tshirtCount >0)
                {
                    tshirtCount--;
                    total += product.Price;

                }
            }

            return total;
        }
    }
}
