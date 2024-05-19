using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Reflection.Metadata.BlobBuilder;

namespace StructIndexer
{
    public class Library
    {
        Book[] Books = { };

        public void AddBook(Book book)
        {
            Array.Resize(ref Books, Books.Length + 1);
            Books[Books.Length - 1] = book;
        }



        public Book[] FindAllBooksByName(string value)
        {
            Book[] findName = new Book[] { };

            for (int i = 0; i < Books.Length; i++)
            {
                if (Books[i].Name == value)
                {
                    Array.Resize(ref findName, findName.Length + 1);
                    findName[findName.Length - 1] = Books[i];
                }
            }
            return findName;
        }
        public Book[] SearchBooks(string value) 
         {

            Book[] searchBooks = new Book[] { };
            for (int i = 0; i < Books.Length; i++)
            {
                if (Books[i].Name == value)
                {
                    Array.Resize(ref searchBooks, searchBooks.Length + 1);
                    searchBooks[searchBooks.Length - 1] = Books[i];
                }
            }
            return searchBooks;

        }

        public Book[] RemoveAllBooksByName(string value)
        {
            Book[] removeBooks = new Book[] { };
            for (int i = 0; i < Books.Length; i++)
            {
                if (Books[i].Name == value)
                {
                    Array.Resize(ref removeBooks, removeBooks.Length + 1);
                    removeBooks[removeBooks.Length - 1] = Books[i];
                }


            }
            return removeBooks;

        }

    
        public Book[] ShowAllBooks()
        {
            return Books;
        }


    }
}