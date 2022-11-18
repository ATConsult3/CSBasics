
using static System.Console;
using System;


namespace andestech.learning.cs2022
{
    internal class Store2 : IDisposable
    {
        //

        public Store2() {
            WriteLine("+++ ctor Store2, " + GetHashCode());
        }

        public void Dispose()
        {
            WriteLine("--- dsp Store2, " + GetHashCode());
        }

        ~Store2()
        {
            WriteLine("--- dtor Store2, " + GetHashCode());
        }
    }



    internal class Store
    {
        private int[] boxes;
        public Store(uint size) {
            boxes = new int[size];
            for(int i=0; i<size; i++) boxes[i] = i;
            WriteLine("+++ ctor, " + GetHashCode());
        
        }

        ~Store() {
            WriteLine("--- dtor, " + GetHashCode());
        }
    
    }

    internal class GCtest
    {
        static void Main(string[] args)
        {
            int N = 2000;
            
            Store[] st = new Store[N];
            using (Store2 s = new Store2())
            {
                WriteLine(s);
            }

            ReadKey();

            //for (int i = 0; i < N; i++)
            //{
            //    Write(i + " -> ");
            //    new Store(10_000_000);
            //    if (i % 30 == 0) GC.Collect();
            //}

            WriteLine("End of Main");
        }
    }
}
