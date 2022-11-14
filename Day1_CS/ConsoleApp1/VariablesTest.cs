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
        //static int N = 10;

        static void Main(string[] args)
        {
            int N = 144;

            WriteLine("--- Vars Test ---");
            WriteLine("1: N=" + N);
            Write("2: N={0}\n", N);
            string Nmsg = String.Format("3: N={0}", N);
            WriteLine(Nmsg);
            WriteLine();
            WriteLine($"4: N={N}");

            WriteLine("--- ---------------------  ---");
            byte b1 = 0b1010_0101;
            WriteLine(b1);
            //Byte b2 = 0x14;
            Byte b2 = 0x2;
            sbyte b3;
            checked
            {
                b3 = (sbyte)(b2 * 35);
            }

            WriteLine($"b3={b3}");

            //---------------------------
            short sh1 = (1 << 15) - 1 ;
            WriteLine($"sh1 = {sh1}, MAX short = {short.MaxValue}"); 

            ushort sh2 = (1 << 16) - 1 ;
            WriteLine($"sh2 = {sh2}, MAX short = {ushort.MaxValue}");

            //---------------------------
            unchecked
            {
                int i1 = (1 << 31) - 1;
                WriteLine($"i1 = {i1}, MAX int = {int.MaxValue}");
            }

            unchecked
            {
                long long1 = (1 << 63) - 1;
                WriteLine($"long1 = {long1}, MAX int = {long.MaxValue}");
                long long2 = 1234_5678_9012_3456L;
                WriteLine($"long2 = {long2}.");
            }

            byte b5 = 0b1010_0101;
             byte m = 0b1100_0001;
            byte b6 = (byte) (b5 | m);

            WriteLine($"b5={Convert.ToString(b5, 2)}");

            WriteLine($"m ={Convert.ToString(m, 2)}");
            WriteLine($"b6={Convert.ToString(b6, 2)}");
            ++b2;
            int res = 2*b2;
            --b2;
            WriteLine($"res={res}, b2={b2}");

        }
    }
}
