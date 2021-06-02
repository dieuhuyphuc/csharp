using System;

namespace part5
{
    public class part5
    {
        public static void Main(string[] args)
        {
            int i, f=1, number;
            Console.WriteLine("Calculate the factorial:\n");
            Console.WriteLine("----------");

            Console.WriteLine("Please input number: ");
            number = Convert.ToInt32(Console.ReadLine());
            for (i = 1; i <= number; i++)
            { 
                f = f * i;
            }

            Console.WriteLine("Factorial of "+ number+ "\nis:" + f);

        }
    }
}