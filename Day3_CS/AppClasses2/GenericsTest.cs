using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace andestech.learning.cs2022
{
    class Container<T>
    { 
     public T Value { get; set; }
    }

    class ContainerDatas<T>
    {
        public T[] Data { get; private set; }
        private uint Length;

        public ContainerDatas(uint N = 10)
        {
            Length = N;
            Data = new T[N];
        } 

        public T this[int i]
        {
            get { return Data[i]; }
            set { Data[i] = value; }    
        }

        public T this[string i]
        {
            get {
                switch (i.ToLower().Trim()) {
                    case "zero": return Data[0];
                    case "one": return Data[1];
                    case "two": return Data[2];

                    default:
                        throw new IndexOutOfRangeException($"string index '{i}' is not valid");
                }
                
            }
            set {
                switch (i.ToLower().Trim())
                {
                    case "zero": Data[0]=value; break;
                    case "one":  Data[1]=value; break;
                    case "two":  Data[2]=value; break;

                    default:
                        throw new IndexOutOfRangeException($"string index '{i}' is not valid");
                }


            }
            
        }


    }



    internal class GenericsTest
    {

        public static void swap<TT>(ref TT a, ref TT b) => (a, b) = (b, a);
        public static void swap(ref object a, ref object b) => (a, b) = (b, a);

        public static void Main()
        {
            A a1 = new A { Data = -111 };
            A a2 = new A { Data =  222 };

            WriteLine($"{a1} ---- {a2}");
            WriteLine($"{a1.GetHashCode()} ---- {a2.GetHashCode()}");
            swap<A>(ref a1, ref a2); 
            WriteLine($"{a1} ---- {a2}");
            WriteLine($"{a1.GetHashCode()} ---- {a2.GetHashCode()}");

            Container<int> c1 = new Container<int> { Value = 11122233 }; //Value = "1.2222"; }
            Container<A> a3 = new Container<A> { Value = new A() };

            ContainerDatas<A> datas = new ContainerDatas<A>(5);
            (datas[0], datas[1], datas[2]) = (new A { Data = 00 }, new A { Data = 11 }, new A { Data=22});

            datas["ONE"] = new A { Data = 11111 };

            foreach (var v in datas.Data) WriteLine(v);
            WriteLine(datas["twO 11"]);


        }

    }
}
