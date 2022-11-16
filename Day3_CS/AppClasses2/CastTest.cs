using static System.Console;

namespace andestech.learning.cs2022
{
    class CastTest
    {
        public static void Main() { 
        
            A a = new A { DataA = 1, Data=10 };
            Base b = a;
            object o = a;
            object o2 = new B { Data=2, DataB=222};

            A a2 = (A)o;
            A a3 = o as A;
            WriteLine("A.DataA=" + a2.DataA);
            WriteLine("A.DataA=" + a3.DataA);

            //-----------------------
            WriteLine(" ------------------------ ");
           // A a21 = (A)o2;
            A a31 = o2 as A;
           // WriteLine("A.DataA=" + a21.DataA);
            WriteLine("A.DataA=" + a31?.Data);


        }
    }
}
