//using System;
using static System.Console;
using andestech.learning.cs2022.datas;

namespace andestech.learning.cs2022
{
    class Program
    {
        static void DebugTest() {

            WriteLine("Salute from Debug test!");

        }


        static void Main(string[] args)
        {
            //Console.WriteLine("HI all!");
            //System.Console.WriteLine("HI all!");

            WriteLine("HI all !!!");

            WriteLine("Step 1, HI all !!!");
            DebugTest();
            // datas.DataFuncs.DebugTest2();
            DataFuncs.DebugTest2();

            WriteLine("Step 2, all !!!");

        }
    }
}
