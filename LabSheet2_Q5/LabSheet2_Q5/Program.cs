using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabSheet2_Q5
{
    //class- LibraryBook
    public class LibraryBook
    {
        //variables- get,set
        public string title { get; set; }
        public string author { get; set; }
        public bool available;

        //costructor
        public LibraryBook(string Title, string Author, bool Available)
        {
            title = Title;
            author = Author;
            available = Available;
        }

        //method
        public void BorrowBook()
        {
            if(available)
            {
                available = false;
                Console.WriteLine($"The book \"{title}\" by {author} has been borrowed.");
            }

            else
            {
                Console.WriteLine($"Sorry, The book \"{title}\" by {author} can't borrow.");
            }
        }
        public void displayBookDetails()
        {
            Console.WriteLine($"Title: {title}, Author: {author}, Available: {available}");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //array-object
            LibraryBook[] books = new LibraryBook[3];

            //initiate
            books[0] = new LibraryBook("The Great Gatsby", "F. Scott Fitzgerald",true);
            books[1] = new LibraryBook("1984", "George Orwell", false);
            books[2] = new LibraryBook("To Kill a Mockingbird", "Harper Lee", true);

            // Display library status before borrowing
            Console.WriteLine("Library Status Before Borrowing,\n");
            foreach (var book in books)
            {
                book.displayBookDetails();
            }

            // Borrow a book
            books[0].BorrowBook();

            // Display updated library status
            Console.WriteLine("\nLibrary Status After Borrowing,\n");
            foreach (var book in books)
            {
                book.displayBookDetails();
            }
            Console.ReadLine();
        }
    }
}

/*
Output- 

Library Status Before Borrowing,

Title: The Great Gatsby, Author: F. Scott Fitzgerald, Available: True
Title: 1984, Author: George Orwell, Available: False
Title: To Kill a Mockingbird, Author: Harper Lee, Available: True
The book "The Great Gatsby" by F. Scott Fitzgerald has been borrowed.

Library Status After Borrowing,

Title: The Great Gatsby, Author: F. Scott Fitzgerald, Available: False
Title: 1984, Author: George Orwell, Available: False
Title: To Kill a Mockingbird, Author: Harper Lee, Available: True
*/