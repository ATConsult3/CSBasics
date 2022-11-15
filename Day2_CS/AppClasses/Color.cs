using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace andestech.learning.cs2022.game
{
    public class Color : Object
    {
        private static readonly int MAX = 255, MIN = 0;

        public int R { get; private set; }
        public int G { get; private set; }
        public int B { get; private set; }

        public override string ToString()
        {
            return $"({R},{G},{B})";
        }

        public Color(int r=0, int g=0, int b=0)
        {
            if ((r <= MAX && r >= MIN) &&
                (g <= MAX && g >= MIN) &&
                (b <= MAX && b >= MIN)
                )
            {
                R = r;
                G = g;
                B = b;
            }
            else throw new Exception($"Wrong color numbers: {r}:{g}:{b}");


        }   
    }
}
