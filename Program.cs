
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
            Product product = new Product();

            while (ch!=6)
            {
                ch=int.Parse(Console.ReadLine());
                
                if (ch==1)
                {
                    Console.WriteLine("Enter the name of product: ");
                    product.Name = Console.ReadLine();
                    Console.WriteLine("Enter the price of product: ");
                    product.Price =int.Parse( Console.ReadLine());
                    Console.WriteLine("Enter the quntity of product: ");
                    product.Quantity = int.Parse(Console.ReadLine());

                }

            
            }



            

       

            
        }
    }
}
