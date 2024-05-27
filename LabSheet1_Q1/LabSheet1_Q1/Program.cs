using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace LabSheet1_Q1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //User inputs
            Console.Write("Enter the rectangle length : ");
            double length = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the rectangle width : ");
            double width = Convert.ToDouble(Console.ReadLine());

            //calculate area
            double area = length * width;

            //output
            Console.WriteLine("\nArea : " +area);
            Console.ReadLine();
            
        }
    }
}

/*
Output-

Enter the rectangle length : 5
Enter the rectangle width : 3.5

Area : 17.5
*/
