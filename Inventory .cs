using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simple_Inventory_Management_System
{
    internal class Inventory
    {
        private List<Product> _products=new List<Product>();



        public void AddProduct(Product product)
        {
            _products.Add(product);
        }


        public void ViewAllProducts()
        {
            if (_products.Count == 0)
            {
                Console.WriteLine("There's no product");
            }
            else
            {
                Console.WriteLine("Name | Quantity | Price");
                foreach (var product in _products)
                {
                    Console.WriteLine($"{product.Name} | {product.Quantity} | {product.Price}");
                }
            }
        }
    }
}
