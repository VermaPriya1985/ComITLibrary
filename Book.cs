using System;
using Unit3examples;
namespace ComITLibrary
{ 
    public class Book
    {
        
        // Constructor
        public Book(long id, string title, string author)
        {
            Id = id;
            Title= title;
            Author = author;
            Ischeckedout=false;
        }


        // Data Members
        public long Id { get; }
        public string Title { get; private set; }
        public string Author { get; private set; }
        public bool Ischeckedout { get; set; }

    }
}
