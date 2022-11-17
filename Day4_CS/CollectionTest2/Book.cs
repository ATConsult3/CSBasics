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
    internal class Book
    {
      public string Author { get; set; } 
      public string Title { get; set; }
        //.. todo

        public override string ToString()
        {
            return $"Книга '{Title}', {Author}.";
        }

    }
}
