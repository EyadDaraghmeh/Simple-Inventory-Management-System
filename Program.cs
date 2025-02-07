
namespace Simple_Inventory_Management_System
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1.Add a product");
            Console.WriteLine("2.View all products");
            Console.WriteLine("3.Edit a product");
            Console.WriteLine("4.Delete a product");
            Console.WriteLine("5.Search for a product");
            Console.WriteLine("6.Exit");

            int ch = 0;
            Inventory inventory = new Inventory();

            while (true)
            {
                ch=int.Parse(Console.ReadLine());
                
                if (ch==1)
                {
                    Product product = new Product();

                    Console.WriteLine("Enter the name of product: ");
                    product.Name = Console.ReadLine();
                    Console.WriteLine("Enter the price of product: ");
                    product.Price =int.Parse( Console.ReadLine());
                    Console.WriteLine("Enter the quntity of product: ");
                    product.Quantity = int.Parse(Console.ReadLine());
                    inventory.AddProduct(product);

                }
                else if(ch==2)
                {
                    inventory.ViewAllProducts();
                }
                else if(ch==3)
                {
                    inventory.EditAProduct();
                }
                else if(ch==4)
                {
                    inventory.DeleteAProduct();
                }
                else if(ch==5)
                {
                    inventory.SearchAProduct();
                }
                else if (ch==6)
                {
                    Console.WriteLine("Exist.................");
                    break;
                }

                else {
                    Console.WriteLine("Valid Option!!!");
                }

            
            }



            

       

            
        }
    }
}
