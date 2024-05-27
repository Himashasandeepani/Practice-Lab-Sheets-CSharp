using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabSheet1_Q6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //inputs
            Console.Write("Enter Your name: ");
            string name = Console.ReadLine();

            Console.Write("Enter Your mark: ");
            int mark;


            bool isValidInput = int.TryParse(Console.ReadLine(), out mark);

            //validation
            if (!isValidInput || mark < 0 || mark > 100)
            {
                Console.WriteLine("ERROR: Please enter valid marks between 0 and 100.");
                return;
            }

            //grade check
            string grade;
            if (mark >= 75 && mark <= 100)
            {
                grade = "Grade A";
            }

            else if (mark >= 60 && mark <= 74)
            {
                grade = "Grade B";
            }

            else if (mark >= 50 && mark <= 59)
            {
                grade = "Grade C";
            }

            else if (mark >= 40 && mark <= 49)
            {
                grade = "Grade D";
            }

            else
            {
                grade = "Failed";
            }

            //output
            Console.WriteLine("\nStudent: {0}, Marks: {1}, Grade: {2}", name, mark, grade);
            Console.ReadLine();
        }
    }
}

/*
Output-

Enter Your name: Himasha
Enter Your mark: 89

Student: Himasha, Marks: 89, Grade: Grade A
*/