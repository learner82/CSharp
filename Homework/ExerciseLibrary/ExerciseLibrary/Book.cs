using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseLibrary
{
    public class Book
    {
        public static int _IDB = 0;
        public string Title { get; private set; }
        public Author Author { get; private set; }
        public int IDB { get; private set; }

        

        public Book(string title, Author author)
        {
            this.Title = title;
            this.Author = author;
            this.IDB = ++_IDB;
        }

        public override string ToString()
        {
            return $"{this.Title} by {this.Author}";

        }

        public override bool Equals(object obj)
        {
            if (!(obj is Book))
            {
                return false;
            }
            return Equals(obj as Book);
        }

        public bool Equals(Book other)
        {
            if (this.IDB == other.IDB)
            {
                return true;
            }
            else { return false; }
        }
        public static bool operator ==(Book b1, Book b2)
        {
            return b1.Equals(b2);
        }

        public static bool operator !=(Book b1, Book b2)
        {
            return !b1.Equals(b2);
        }

        public override int GetHashCode()
        {
            return IDB.GetHashCode();
            
        }

    }
}
