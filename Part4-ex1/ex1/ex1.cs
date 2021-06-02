using System;

namespace Part4.Properties
{
    public class ex1
    {
        public static void Main(string[] args)
        {
            Information information = new Information();
            Console.WriteLine("Please enter your information.");
            Console.WriteLine("Name: ");
            information.name = Console.ReadLine();
            Console.WriteLine("Address: ");
            information.address = Console.ReadLine();
            Console.WriteLine("Phone: ");
            information.phone = Console.ReadLine();
            Console.WriteLine(information.name);
            Console.WriteLine(information.address);
            Console.WriteLine(information.phone);
            
        }
    }
}