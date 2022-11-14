using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace andestech.learning.cs2022
{
    internal class FlowAndCastTest
    {
        public static void Main(string[] args)
        {

            String a = "123a", b="123";
            WriteLine("Calculator - summator, press \"x\" to exit. ");
            while (true)
            {
                Write("Введите а:"); a = ReadLine();
                if (a == "x") break;

                Write("Введите b:"); b = ReadLine();
                if (b == "x") break;


                int a1 = int.Parse(a);
                int b1 = int.Parse(b);

                WriteLine($"{a1} + {b1} = {a1 + b1}\n");
            }
            WriteLine("Thank you.");



        }

    }

    internal class FlowAndCast2Test
    {
        public static void Main(string[] args)
        {

            String a = "123a", b = "123";
            WriteLine("Calculator - summator, press \"x\" to exit. ");
            while (true)
            {
                Write("Введите а:"); a = ReadLine();
                if (a == "x") break;

                Write("Введите b:"); b = ReadLine();
                if (b == "x") break;


                int a1,b1;

                if (int.TryParse(a, out a1) && int.TryParse(b, out b1))
                {
                    checked { WriteLine($"{a1} + {b1} = {a1 + b1}\n"); } 
                }
                else
                {
                    WriteLine("Wrong number format, try again.\n");
                }
            }
            WriteLine("Thank you.");



        }

    }

}
