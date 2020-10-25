using System;
using Unit3examples;
namespace ComITLibrary
{ 
    public class Patron
    {
        
        // Constructor
        public Patron(long id, string firstname, string lastname)
        {
            Id = id;
            FirstName= firstname;
            LastName = lastname;
   
        }


        // Data Members
        public long Id { get; }
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        
    }
}
