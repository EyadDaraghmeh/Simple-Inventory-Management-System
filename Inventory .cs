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
                Console.WriteLine("There's no products");
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

        public void EditAProduct()
        {
            if ( _products.Count == 0)
            {
                Console.WriteLine("There's no products");
            }
            else
            {
                Console.WriteLine("Enter the Name of the product");
                string name = Console.ReadLine();
                Product product = new Product();

                product = Search(name);


                if (product.Name == null)
                {
                    Console.WriteLine("There's no product with this name");
                }
                else
                {
                    Console.WriteLine("Enter Name :");
                    product.Name = Console.ReadLine();
                    Console.WriteLine("Enter price");
                    product.Price = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter quntity");
                    product.Quantity = int.Parse(Console.ReadLine());
                }
                
            }
        }

        public void DeleteAProduct()
        {
            if(_products.Count == 0)
            {
                Console.WriteLine("There's no products");
            }
            else
            {
                Console.WriteLine("Enter the Name of the product");
                string name = Console.ReadLine();
                Product product= new Product();
                product = Search(name);

                if (product.Name == null)
                {
                    Console.WriteLine("There's no product with this name");

                }
                else
                {
                    _products.Remove(product);
                }
            }
        }

        public void SearchAProduct()
        {
            if (_products.Count == 0)
            {
                Console.WriteLine("There's no products");
            }
            else
            {
                Console.WriteLine("Enter the Name of the product");
                string name = Console.ReadLine();
                Product product = new Product();
                product=Search(name);
              
                if (product.Name == null)
                {
                    Console.WriteLine("There's no product with this name");

                }
                else
                {
                    Console.WriteLine($"{product.Name} | {product.Quantity} | {product.Price}");

                }
            }
        }

        public Product Search(string name)
        {
            Product product = new Product();
            foreach (var pro in _products)
            {
                if (pro.Name == name)
                {
                    product = pro;
                }
            }
            return product;
        }
    }
}
