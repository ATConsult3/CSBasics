using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using static andestech.learning.cs2022.utils.Utils;
using System.Collections.ObjectModel;
using System.Globalization;
using System.Threading;

namespace andestech.learning.cs2022.library
{

    public delegate void NewBookHandler(string message);

    [LibraryType(LibraryType.Gov)]
    public class Library
    {
        public event NewBookHandler NewBook;
        public List<Book> Books { get; private set; } = new List<Book>();

        public void AddBook(Book book)
        { 
          Books.Add(book);
          NewBook?.Invoke($"Новый ресурс \"{book}\" поступил в библиотеку!"); 
        }



        //............



    }
}
