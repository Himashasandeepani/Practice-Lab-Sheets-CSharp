using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabSheet1_Q3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //input
            Console.Write("Enter a positive integer : ");
            int n = Convert.ToInt32(Console.ReadLine());

            if (n >= 0)
            {
                int sum = 0;
                for (int i = 0; i <= n; i++)
                {
                    sum += i;
                }
                Console.WriteLine("The sum of all numbers from 1 to {0} is: {1}", n, sum);
            }

            else
            {
                Console.WriteLine("Error");
            }
            Console.ReadLine();
        }
    }
}
/*
Output- 

Enter a positive integer : 5
The sum of all numbers from 1 to 5 is: 15
*/