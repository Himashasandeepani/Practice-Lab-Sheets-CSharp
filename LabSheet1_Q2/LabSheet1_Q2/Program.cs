using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace LabSheet1_Q2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //array for input 10 numbers
            double [] n = new double [10];

            //inputs
            Console.WriteLine("Enter 10 numbers , ");


            for(int i = 0; i< 10; i++)
            {
                Console.Write("Enter a number {0} : " , i+1);
                n[i] = Convert.ToDouble(Console.ReadLine());
            }
            Console.Write("\n");

            for(int i = 0; i< 10; i++)
            {
                if (n[i] % 2 == 0)
                {
                    Console.WriteLine("Enterd number {0} : Even" , n[i]);
                }

                else if (n[i] % 2 != 0)
                {
                    Console.WriteLine("Enterd number {0} : Odd" , n[i]);
                }

                else
                {
                    Console.WriteLine("Error");
                }
            }
            Console.ReadLine();
        }
    }
}

/*
Output-

Enter 10 numbers ,
Enter a number 1 : 23
Enter a number 2 : 34
Enter a number 3 : 56
Enter a number 4 : 78
Enter a number 5 : 89
Enter a number 6 : 00
Enter a number 7 : 67
Enter a number 8 : 45
Enter a number 9 : 1
Enter a number 10 : 34

Enterd number 23 : Odd
Enterd number 34 : Even
Enterd number 56 : Even
Enterd number 78 : Even
Enterd number 89 : Odd
Enterd number 0 : Even
Enterd number 67 : Odd
Enterd number 45 : Odd
Enterd number 1 : Odd
Enterd number 34 : Even
*/
