using System;
using Unit3examples;
namespace ComITLibrary
{ 
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            /* LibraryPatron lib = new LibraryPatron(1);
            Console.WriteLine(lib.BooksCheckedOut);
            Console.WriteLine(lib.PatronId); */ 

            // lib.BooksCheckedOut = -99;
            // lib.FinesOwing = -0;
            
            // LibraryPatron lib = new LibraryPatron();
            // LibraryPatron lib = new LibraryPatron(1);
            // lib.PatronId=1;

            LibrarySystem theLibrary = new LibrarySystem();
            Console.WriteLine("Welcome to the ComIT Library!");

            while(true)
            {
                Console.WriteLine("s- search, c- checkout, r-return, q-quit");
                string userInput = Console.ReadLine();
                // Checkout/Issue Book
                if(userInput=="c")
                {
                    Console.WriteLine("Enter PatronID");
                    string patronIdInput = Console.ReadLine();
                    long patronId = Convert.ToInt64(patronIdInput);

                    Console.WriteLine("Enter BookID");
                    string bookIdInput = Console.ReadLine();
                    long bookId = Convert.ToInt64(bookIdInput);
                    
                    bool success = theLibrary.CheckoutBook(patronId,bookId);
                    if(success) 
                    {
                        Console.WriteLine("Book has been checked out!");
                    } else 
                    {
                        Console.WriteLine("Something went wrong. Could not check out book");
                    }
                }
                if(userInput=="r")
                {

                    theLibrary.ReturnBook();
                }
                if(userInput=="s")
                {
                    Console.WriteLine("What is the title you want to search for?");
                    string titleToSearch = Console.ReadLine();
                    Book result = theLibrary.SearchForBook(titleToSearch);
                    if (result == null) 
                    {
                        Console.WriteLine("Book was not found");
                    } 
                    else 
                    {
                        Console.WriteLine($"Found a book with Id: {result.Id} ");
                    }

                }
                // Quit
                if(userInput=="q")
                {
                    break;
                }

            }
        }
    }
}
