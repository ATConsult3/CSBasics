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
    [Serializable]
    public class Book
    {
      private static Random r = new Random((int)DateTime.Now.Ticks);
      private int _id = r.Next(0, 4_000_000_00);

      //[JsonIgnore]  
      public int ID { get => _id; }

      
      public string Author { get; set; } 
      public string Title { get; set; }
        //.. todo

        public override string ToString()
        {
            return $"Книга '{Title}', {Author}, ID:{ID}.";
        }

       

    }

    public class Book2
    {
        private static Random r = new Random((int)DateTime.Now.Ticks);
        private int _id = r.Next(0, 4_000_000_00);
        public int ID { get => _id; }

        public Book2(string author, string title)
        {
            Author = author; Title = title;
        }

        public string Author { get; private set; }
        public string Title { get; private set; }
        //.. todo

        public override string ToString()
        {
            return $"Книга '{Title}', {Author}.";
        }

    }
}
