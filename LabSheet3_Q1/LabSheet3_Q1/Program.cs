using LabSheet3_Q1;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LabSheet3_Q1
{
    //class- Course
    public class Course
    {
        //properties- private
        private string courseName;
        private string instructorName;
        private double grade;

        //properties- public
        public string getCourseName ()
        {
            return courseName;
        }

        public double getGrade ()
        {
            return grade;
        }

        //method
        public void SetCourseName(string courseN)
        {
            if (string.IsNullOrWhiteSpace(courseN))
            {
                throw new ArgumentException("Course name cannot be empty.");
            }
            else
            {
                courseName = courseN;
            }
        }

        public void SetInstructorName(string instructorN)
        {
            if (string.IsNullOrWhiteSpace(instructorN))
            {
                throw new ArgumentException("Instructor name cannot be empty.");
            }
            else
            {
                instructorName = instructorN;
            }
        }

        public void SetGrade(double G)
        {
            if (G < 0 || G > 100)
            {
                throw new ArgumentOutOfRangeException("Grade must be between 0 and 100.");
            }

            else
            {
                grade = G;
            }
        }

        //calculate grade - private
        private string CalculateLetterGrade(double g)
        {
            if (g >= 75)
            {
                return "A";
            }
            else if (g >= 65)
            {
                return "B";
            }
            else if (g >= 55)
            {
                return "C";
            }
            else if (g >= 45)
            {
                return "D";
            }
            else
            {
                return "F";
            }
        }

        //pirntCourseInfo - public
        public void pirntCourseInfo()
        {
            Console.WriteLine("\nCourse Name is: " + courseName);
            Console.WriteLine("Instructor is: " + instructorName);
            Console.WriteLine("Grade: " + CalculateLetterGrade(grade));
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //excepton handling
            try
            {
                //object
                Course course = new Course();

                course.SetCourseName("C#");
                course.SetInstructorName("Himasha");
                course.SetGrade(86);

                Console.WriteLine("Grade Marks: " + course.getGrade());
                course.pirntCourseInfo();
            }

            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
            Console.ReadLine();
        }
    }
}

/*
OutPut-

Grade Marks: 86

Course Name is: C#
Instructor is: Himasha
Grade: A
*/