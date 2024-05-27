using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabSheet1_Q5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Input
            Console.Write("Enter a number: ");
            int n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Multiplication table for {0}:", n);

            for (int i = 0;i <= 12; i++)
            {
                int result = n * i;
                Console.WriteLine("{0} * {1} = {2}" , i, n, result);
            }
            Console.ReadLine();
        }
    }
}

/*
Output-

Enter a number: 4
Multiplication table for 4:
0 * 4 = 0
1 * 4 = 4
2 * 4 = 8
3 * 4 = 12
4 * 4 = 16
5 * 4 = 20
6 * 4 = 24
7 * 4 = 28
8 * 4 = 32
9 * 4 = 36
10 * 4 = 40
11 * 4 = 44
12 * 4 = 4
*/