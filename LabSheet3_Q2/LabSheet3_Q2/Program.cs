using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static LabSheet3_Q2.Program;

namespace LabSheet3_Q2
{
    //class- Employee
    public class Employee
    {
        //variables - private
        private int employeeId;
        private string FullName;
        private double Salary;

        //get- id
        public int GetEmpolyeeId()
        {
            return employeeId;
        }

        //get, set - fullname
        public string Fullname
        {
            get { return FullName; }
            set { FullName = value; }
        }

        //get- id
        public double Getsallary()
        {
            return Salary;
        }

        //constructor
        public Employee(int employeeID, string fullName, double SalAry)
        {
            employeeId = employeeID;
            FullName = fullName;
            Salary = SalAry;
        }

        //method
        public void DisplayEmployeeInfo()
        {
            Console.WriteLine("\nEmployee ID: " + employeeId);
            Console.WriteLine("Employee Name: " + FullName);
            Console.WriteLine("Salary: " + Salary);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //object
            Employee employee = new Employee(101, "John Doe", 50000.00);

            // b) Access and display the employee ID using the read-only property
            Console.WriteLine("Employee ID: " +employee.GetEmpolyeeId());

            // c) Update the full name of the employee using the read-write property
            employee.Fullname = "Jane Smith";
            Console.WriteLine($"Updated Full Name: {employee.Fullname}");

            employee.DisplayEmployeeInfo();

            // d) employee.Getsalary = 60000;

            Console.ReadLine();
        }
    }
}

/*
OutPUT -

Employee ID: 101
Updated Full Name: Jane Smith

Employee ID: 101
Employee Name: Jane Smith
Salary: 50000
*/