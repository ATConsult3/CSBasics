using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static andestech.learning.cs2022.utils.Utils;
using System.Collections.ObjectModel;
using static System.Console;
using andestech.learning.cs2022.library;

namespace andestech.learning.cs2022
{

    public delegate void GreetsHandler(string name, int exclN=1);

    internal class DelegateLabdaTest
    {

        private static void SayHi(string name, int N=1) => WriteLine($"Hi, {name}{new string('!', N)}");
        private static void SayPrivet(string name, int N=1) => WriteLine($"Привет, {name}{new string('!', N)}");
        private static void SayHDUD(string name, int N=1) => WriteLine($"Как жизнь, {name}?{new string('!', N)}");

        private static void sayAll(Action<string, int> handler, string name, int N = 1)
        { 
         handler(name, N);
         handler(name.ToUpper(), N);


        }


        public static void Main() {
            echo("Delegate test");
            GreetsHandler gh = SayHi;
            gh("Andrei");
            gh = SayPrivet;
            gh("Andrei", 3);

            gh += SayHDUD;
            gh += SayHi;
            gh += SayHi;
            gh -= SayHi;

            gh("Андрей", 3);

            echo();

            Action<string, int> greets2 =
                (name, N) => WriteLine($"Салют, {name}{new string('!', N)}");

            Action<string, int> gh2 = SayHDUD;
            gh2 += SayHi;
            gh2 += SayPrivet;
            gh2 += (name, N) => WriteLine($"Добрый день, {name}{new string('!', N)}");
            gh2 += greets2;
            gh2("Андрей", 5);
            echo("test delegate as argument");
            sayAll(SayHDUD, "Andrei", 2);

            echo("EVENTS",'+');

            Book book1 = new Book { Author = "А.Толстой", Title = "Аэлита" };
            Book book2 = new Book { Author = "J.London", Title = "White silence" };

            Library library = new Library();

            library.NewBook += m => WriteLine($"Subscriber 1: {m}");
            
            library.AddBook(book1);
            library.NewBook += m => WriteLine($"Подписчик 2: {m}");

            library.AddBook(book2);


        }


    }
}
