using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabSheet2_Q4
{
    //class- Product
    public class Product
    {
        //variables- get,set
        public string productName { get; set; }
        public double price { get; set; }

        //constructor
        public Product(string pName, double Price)
        {
            productName = pName;
            price = Price;
        }

        //method
        public void DisplayProductDetails()
        {
            Console.WriteLine($"Product Name : {productName}");
            Console.WriteLine($"Price : {price}");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //oblect
            Product product = new Product("Book", 250.00);

            //display
            product.DisplayProductDetails();
            Console.ReadLine();
        }
    }
}


/*
Output-

Product Name : Book
Price : 250
*/