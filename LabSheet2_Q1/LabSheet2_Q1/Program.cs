using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabSheet2_Q1
{
    //class- Book
    public class Book
    {
        //variables - get, set
        public string title { get; set; }
        public string author { get; set; }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //object
            Book book1 = new Book();

            //called
            book1.title = "madol Duwa";
            book1.author = "Mr.Martin Wikramasinghe";

            //output
            Console.WriteLine("Title : " + book1.title);
            Console.WriteLine("Autor :" + book1.author);
            Console.ReadLine();
        }
    }
}

/*
Output- 

Title : madol Duwa
Autor :Mr.Martin Wikramasinghe
*/
