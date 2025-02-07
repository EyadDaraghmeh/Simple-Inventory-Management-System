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


        public void Show()
        {
            foreach (Product product in _products)
            {
                Console.WriteLine(product.Name);
            }
        }
    }
}
