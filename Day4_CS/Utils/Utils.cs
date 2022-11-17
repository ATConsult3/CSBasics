using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;


namespace andestech.learning.cs2022.utils
{
    public static class Utils
    {
        public static void echo<T>(IEnumerable<T> coll)
        {
            Write("{");
            foreach (T item in coll) Write(item + ", ");
            WriteLine("\b\b}.");
        }

        public static void echo(string title="-", char symbol='-', uint length=65)
        { 
          string side = new string(symbol, (int)(length - (title.Length + 2))/2);
          WriteLine($"{side} {title} {side}");
        }

        // -------------------- Test STACK ----------------------


    }
}
