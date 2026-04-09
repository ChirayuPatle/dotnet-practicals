using System;
using System.Collections.Generic;

class Product
{
    public int Id;
    public string Name;
    public double Price;
}

class Program
{
    static void Main()
    {
        List<Product> products = new List<Product>();
        int choice;

        do
        {
            Console.WriteLine("\n1. Add Product");
            Console.WriteLine("2. Show Products");
            Console.WriteLine("3. Delete Product");
            Console.WriteLine("4. Exit");
            Console.Write("Enter choice: ");

            choice = Convert.ToInt32(Console.ReadLine());

            if (choice == 1)
            {
                Product p = new Product();

                Console.Write("Enter ID: ");
                p.Id = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter Name: ");
                p.Name = Console.ReadLine();

                Console.Write("Enter Price: ");
                p.Price = Convert.ToDouble(Console.ReadLine());

                products.Add(p);
            }
            else if (choice == 2)
            {
                Console.WriteLine("\nProducts:");
                foreach (Product p in products)
                {
                    Console.WriteLine(p.Id + " " + p.Name + " ₹" + p.Price);
                }
            }
            else if (choice == 3)
            {
                Console.Write("Enter ID to delete: ");
                int id = Convert.ToInt32(Console.ReadLine());

                Product found = products.Find(x => x.Id == id);

                if (found != null)
                {
                    products.Remove(found);
                    Console.WriteLine("Deleted!");
                }
                else
                {
                    Console.WriteLine("Product not found");
                }
            }

        } while (choice != 4);
    }
}