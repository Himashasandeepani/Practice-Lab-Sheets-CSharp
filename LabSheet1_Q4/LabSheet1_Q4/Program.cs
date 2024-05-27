using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace LabSheet1_Q4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //user inputs
            Console.Write("Enter a positive number : ");
            int n = Convert.ToInt32(Console.ReadLine());

            //check
            if (n <= 0)
            {
                Console.WriteLine("Error, Enter a positive number");
            }

            else
            {
                Console.Write("The first {0} terms of the Fibonacci series are: ", n);

                for (int i = 0; i < n; i++)
                {
                    Console.Write(Fibonacci(i) + "");
                }
            }
            Console.ReadLine();
        }

        static int Fibonacci(int n)
        {
            if (n <= 0)
            {
                return 1;
            }

            else
            {
                return Fibonacci(n - 1) + Fibonacci(n - 2);
            }
        }
    }
}

/*
Output-
Enter a positive number : 5
The first 5 terms of the Fibonacci series are: 12358
*/