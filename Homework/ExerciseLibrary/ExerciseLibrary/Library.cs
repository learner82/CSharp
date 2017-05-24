using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseLibrary
{
    public class Library
    {
        class BookAvailiable
        {
            public int totalCopies;
            public int availCopies;
        }

        private List<User> AuthenticUsers;
        private List<Book> books;
        private List<BookAvailiable> availiable;

        public Library()
        {
            AuthenticUsers = new List<User>();
            books = new List<Book>();
            availiable = new List<BookAvailiable>();
        }

        public bool IsAuthenticUser(User user)
        {
            if (AuthenticUsers.Contains(user))
            {
                return true;
            }
            return false;
        }

        public void AddUser(User user)
        {
            if (AuthenticUsers.Contains(user))
            {
                return;
            }
            AuthenticUsers.Add(user);
        }

        public void AddBook(Book book, int copies)
        {
            if (books.Contains(book))
            {
                int index = books.IndexOf(book);
                availiable[index].totalCopies += copies;
                availiable[index].availCopies += copies;
                return;
            }
            books.Add(book);

            availiable.Add(new BookAvailiable
            {
                totalCopies = copies,
                availCopies = copies
            });
        }
            public bool RentBook(Book b)
            {
                if (books.Contains(b))
                {
                    int index = books.IndexOf(b);
                    availiable[index].availCopies -= 1;
                    return true;
                }
                else return false;
            }

            public bool ReturnBook(Book b)
            {
                if (books.Contains(b))
                {
                    int index = books.IndexOf(b);
                    availiable[index].availCopies += 1;
                    return true;
                }
                else return false;
            }

            public override string ToString()
            {
                string result = string.Format("{0, -40} | {1} \n\n", "Books", "Availiable Copies");
                for(int i=0; i<books.Count; i++)
                {
                 result += string.Format("{0, -40} | {1} \n", books[i], availiable[i].availCopies, availiable);

                }
            return result;
            }
    }
    }
}
