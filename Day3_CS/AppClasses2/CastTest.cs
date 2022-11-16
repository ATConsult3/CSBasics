using static System.Console;

namespace andestech.learning.cs2022
{
    class CastTest
    {

        public static void swap(ref int a, ref int b)
        {
            int c = a; a = b; b = c;
        }
        public static void swap(int a, int b)
        {
            int c = a; a = b; b = c;
        }

        public static void Main() { 
        
            A a = new A { DataA = 1, Data=10 };
            Base b = a;
            object o = a;
            object o2 = new B { Data=2, DataB=222};

            A a2 = (A)o;
            A a3 = o as A;
            WriteLine("A.DataA=" + a2.DataA);
            WriteLine("A.DataA=" + a3.DataA);

            //-----------------------+
            WriteLine(" ------------------------ ");
           // A a21 = (A)o2;
            A a31 = o2 as A;
            if (o2.GetType() == typeof(B)) { WriteLine("B!!"); }

            // WriteLine("A.DataA=" + a21.DataA);
            int? data = a31?.Data ?? 0;
            if (a31?.Data is null) { }

            WriteLine("A.DataA=" + a31?.Data);
            WriteLine("A.DataA=" + data);

            // ----------- boxing|unboxing

            int d1 = 100;
            object o3 = d1;
            //-----------
            int d2 = (int)o3;

            // swap test 
            WriteLine(" --------------- SWAP TEST ------------");
            int x = 111, y = 222;
            WriteLine($"{x} -- {y}"); swap(ref x, ref y); WriteLine($"{x} -- {y}");
            WriteLine(" --------------- TRYSWAP TEST ------------");
            WriteLine($"{x} -- {y}"); swap(x, y); WriteLine($"{x} -- {y}");

        }
    }
}
