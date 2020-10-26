using System;
using Unit3examples;
using System.Collections.Generic;
namespace ComITLibrary
{ 
    public class LibrarySystem
    {

        // Constructor
        public LibrarySystem()
        {

            _book = new List<Book>();        
            _patron = new List<Patron>();

        // hardcoded some data
        var  book1 = new Book(1,".NET",",NET Author");
        var  book2 = new Book(2,"SQL SERVER",",SQLSERVER Author");
        var  book3 = new Book(3,"C#","C# Author");
        
        // Add books to our book collection
       
        _book.Add(book1);
        _book.Add(book2);
        _book.Add(book3);
        
        
        // hardcoded some data
        var  patron1 = new Patron(11,"Priya","Verma");
        var  patron2 = new Patron(12,"Atul","Verma");
        var  patron3 = new Patron(13,"Gavin","Verma");
        
        // Add patron to our patron collection
       
        _patron.Add(patron1);
        _patron.Add(patron2);
        _patron.Add(patron3);
        
        }


    
    // Data Member to represent collection of books
    private List<Book> _book;
    private List<Patron> _patron;


    // Search Book
    public Book SearchForBook(string titletosearch)
    {
        Console.WriteLine($"Searching for book: {titletosearch}");
        for(int i=0;i<_book.Count;i++)
        {

            Book nextbook = _book[i];
            if (nextbook.Title.ToLower() == titletosearch.ToLower()) 
            {
                    return nextbook
                    ;
            }
        }
        return null; // NULL is absence of book
    } 
    
    // Checkout Book
    public bool CheckoutBook(long patronid, long bookid)
    {

        Console.WriteLine("Checking out Book...");
        bool patronExist = false;
        bool bookExist = false;
        bool result = false;

        // Validate patronid
        for(int i=0;i<_patron.Count;i++)
        {
            var nextpatron = _patron[i];
            if(nextpatron.Id==patronid)
            {
                patronExist = true; 
            }
        }

        // handle if patronid does not exists
        if(!patronExist)
        {
            throw new Exception($"patronid does not exists {patronid}");
        }

        // validate bookid
        for(int i=0;i<_book.Count;i++)
        {
            var nextbook = _book[i];
            if(nextbook.Id == bookid)
            {
                bookExist = true; 
                if(nextbook.Ischeckedout)
                {
                    result = false;
                }
                else
                {
                    
                    result = true;
                    nextbook.Ischeckedout = true;
                }

            }
        } 

        if (!bookExist) 
        {
                throw new Exception($"Book {bookid} does not exist!!");
        }
        return result;
    }

    // Return
    public bool ReturnBook(long patronid, long bookid)
    {

        Console.WriteLine("Return Book...");
        bool patronExist = false;
        bool bookExist = false;
        bool result = false;

        // Validate patronid
        for(int i=0;i<_patron.Count;i++)
        {
            var nextpatron = _patron[i];
            if(nextpatron.Id==patronid)
            {
                patronExist = true; 
            }
        }

        // handle if patronid does not exists
        if(!patronExist)
        {
            throw new Exception($"patronid does not exists {patronid}");
        }

        // validate bookid
        for(int i=0;i<_book.Count;i++)
        {
            var nextbook = _book[i];
            if(nextbook.Id == bookid)
            {
                bookExist = true; 
                result = true;
                nextbook.Ischeckedout = false;
                /* if(nextbook.Ischeckedout)
                {
                    result = false;
                }
                else
                {
                    
                    result = true;
                    nextbook.Ischeckedout = true;
                }*/

            }
        } 

        if (!bookExist) 
        {
                throw new Exception($"Book {bookid} does not exist!!");
        }
        return result;
    }
    
    // end    
    
}

}
