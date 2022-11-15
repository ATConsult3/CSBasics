using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using static System.Console;

namespace andestech.learning.cs2022.game
{
    public class Referee : Sprite3
    {
        public int Width { get; private set; }
        public int Height { get; private set; }

        public Referee(int x, int y, Color color, int width=6, int height=24) : base(x, y, color)
        {
            WriteLine("+++ ctor Player, hash -->" + GetHashCode());
            Width = width;
            Height = height;    
        }

        public new string getInfo()
        {
            return  $"Referee: With={Width}, Height={Height}," + base.getInfo().Substring(6);
        }

        public override void echo() {
            WriteLine(this.getInfo());
        }

        public override void move(int dx, int dy)
        {
            WriteLine($"Referee move dx:{dx}, dy:{dy}");
            X += dx;
            Y += dy;
            // rendering code
        }

        public override void rotate(int da)
        {
            WriteLine($"Referee rotates delta alpha:{da}");
            Alpha += da;

        }

    }
}
