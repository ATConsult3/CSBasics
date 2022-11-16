using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace andestech.learning.cs2022
{
    internal class Base //: Object
    {
        public int Data { get; set; }

    }

    class A : Base, ICloneable, IComparable<A> {
        public int DataA { get; set; }

        public object Clone()
        {
            //....
            A a = new A {Data = this.Data, DataA = this.DataA};
            return a;
           // return MemberwiseClone();
        }

        public int CompareTo(A obj)
        {
            return this.Data - obj.Data ;
        }

        public override string ToString()
        {
            return $"A: {Data},{DataA}.";
        }

    }
    class B : Base {
        public int DataB { get; set; }
    }

    struct C 
    {
        public int Data { get; set; }

    }

    struct D 
    {
        public int Data { get; set; }

      
    }

}
