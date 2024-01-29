using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace primenumber_checker
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string again;
            do { 
            Console.Write("Enter a number: ");
                int num;
               

                while (!int.TryParse(Console.ReadLine(), out num) || num <= 0)
                {
                    Console.WriteLine("Invalid input. Please enter a valid number : ");
                }


                if (prime(num))
            {
                Console.WriteLine($"{num} is a prime number.");

            }
            else
            {
                Console.WriteLine($"{num} is not a prime number.");
              
            }
                Console.Write("Do you want to check another number? (Y/N): ");
                again = Console.ReadLine();

                while (!(again.ToUpper() == "Y" || again.ToUpper() == "N"))
                {
                    Console.Write("Invalid input. Please enter Y or N: ");
                    again = Console.ReadLine();
                }

                if (again.ToUpper() == "N")
                {
                    Console.WriteLine("Please press enter key to end...");
                    Console.ReadLine();
                }

            } while (again.ToUpper() == "Y");         
        }

        static bool prime(int n)
        {
            if (n <= 1)
            {
                return false;
            }

            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0)
                {
                    return false;
                }
            }

            return true;

            
        }
    }
}
