using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using System.Diagnostics;

namespace andestech.learning.cs2022
{
    internal class CollectionTest
    {

        public static void echo<T>(IEnumerable<T> coll)
        { 
          Write("{");
          foreach(T item in coll) Write(item + ", ");
          WriteLine("\b\b}.");
        }

        public static void Main() {


            ArrayList arrayList = new ArrayList {
             1,"data",-3.44, new A()};

            arrayList.Add(100);
            arrayList.AddRange(new double[] { 1.22, 2.33, .44 });
            arrayList.RemoveAt(2);

            WriteLine($"{arrayList.Capacity} --- {arrayList.Count}");
            arrayList.Add("Last");
            WriteLine($"{arrayList.Capacity} --- {arrayList.Count}");
            arrayList.Add("Last2");
            WriteLine($"{arrayList.Capacity} --- {arrayList.Count}");

            WriteLine("----------------- Gen Collection Test ----------------");

            List<int> list = new List<int> {1,-20,3,12,0,-8,100,55};
            echo(list);
            list.Sort(); list.Reverse();
            echo(list);

            var res = from el in list
                      where el >=10
                      orderby el 
                      select el;
            echo(res);

            var res2 = from el in list
                      //where el >= 10
                      orderby Math.Abs(el)
                      select el;
            echo(res2);
            WriteLine("----------------- Collection Comparers Test ----------------");
            // list.Sort(new MyCompare());
            // Func<int,int,int> lam1 = (x, y) => Math.Abs(x) - Math.Abs(y);
            Comparison<int> lam2 = (x, y) => Math.Abs(x) - Math.Abs(y);

            list.Sort( (a,b) => b - a );
            // list.Sort((x, y) => Math.Abs(x) - Math.Abs(y));
            list.Sort(lam2);
            echo(list);

            List<A> listA = new List<A> {
            new A{Data=1},
            new A{Data=-10},
            new A{Data=3}
            };

            //listA.Sort( (a,b) => a.Data - b.Data );
            listA.Sort();
            echo(listA);


        }


        class MyCompare : IComparer<int>
        {
            public int Compare(int x, int y)
            {
                return Math.Abs(x) - Math.Abs(y);
            }
        }

    }
    

}
