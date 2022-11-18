using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using System.Runtime.Remoting.Messaging;
using System.Reflection;
using static andestech.learning.cs2022.utils.Utils;
using andestech.learning.cs2022.library;

namespace andestech.learning.cs2022
{
    internal class Program
    {
        static void Main(string[] args)
        {
            echo("Attributes");
            //Library library = new Library();
            //library.AddBook()
            Type type = typeof(Library);
            LibraryTypeAttribute attr = type.GetCustomAttribute<LibraryTypeAttribute>();
            WriteLine("Lib Type: " + attr.LibraryType);  

        }
    }
}
