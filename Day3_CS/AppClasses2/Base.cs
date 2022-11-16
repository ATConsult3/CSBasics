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

    class A : Base {
        public int DataA { get; set; }
    }
    class B : Base {
        public int DataB { get; set; }
    }

}
