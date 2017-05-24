using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseLibrary
{
    public class Librarian
    {
        public string Name { get; set; }
        public Library ManagedLibrary { get; private set; }

        public Librarian(string name, Library lib)
        {
            Name = name;
            ManagedLibrary = lib;
        }

        public void AddUser(User user)
        {
            ManagedLibrary.AddUser(user);
        }

        public bool RentBook(User user, Book book, out string reply)
        {
            if (ManagedLibrary.IsAuthenticUser(user))
            {
                if (ManagedLibrary.RentBook(book))
                {
                    reply = "Book rented successfully! Take care of your book.";
                    return true;
                }
                reply = "No copy available!";
                return false;
            }
            reply = "You are not authorized to rent books from this library!";
            return false;
        }
    }

}
