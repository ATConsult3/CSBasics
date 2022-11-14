using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using static System.Console;

namespace andestech.learning.cs2022
{
    internal class VariablesTest
    {
        static int N = 10;

        static void Main(string[] args)
        {
            WriteLine("--- Vars Test ---");
            WriteLine("1: N=" + N);
            Write("2: N={0}\n", N);
            string Nmsg = String.Format("3: N={0}", N);
            WriteLine(Nmsg);
            WriteLine();
            WriteLine($"4: N={N}");



        }
    }
}
