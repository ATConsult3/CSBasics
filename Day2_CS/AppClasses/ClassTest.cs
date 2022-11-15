using andestech.learning.cs2022.classes;
using andestech.learning.cs2022.game;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace andestech.learning.cs2022
{
    //public class A { }

    class ClassTest
    {
        static void Main(string[] args)
        {
            //  foreach (string arg in args) WriteLine(arg);
            //classes.A a = new classes.A();
            classes.A a = new classes.A();
            a.data = 2222;

            A a1 = new A{ data = 111 };
            A a2 = new A{ data = 123, adata = new A {data=456} };

            WriteLine(a2.adata.data);

            // Sprite class
            Sprite sprite1 = new Sprite { x = 0, y = 12, color = 15 };
            sprite1.y = 15;

            Sprite sprite2 = new Sprite();
            sprite2.y = 1;
            sprite2.x = -12;
            sprite2.color = 5;

            //-----------------
            // Sprite2 s2 = new Sprite2() { Color = 12, X = 12, Y = 0 }; // need Color
            Sprite2 s2 = new Sprite2();
            s2.X = 15;
            s2.Y = 70;
            s2.echo();
            Sprite2 s21 = new Sprite2(color:15);
            s21.echo();
            WriteLine("MAX_Y=" + Sprite2.MAX_Y);
            Sprite2 s22 =  new Sprite2(color:5,x:15,y:125);
            s22.echo();


        }
    }
}
