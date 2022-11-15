using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using static System.Console;

namespace andestech.learning.cs2022.game
{
    public class Player : Sprite3
    {
        public int Width { get; private set; }
        public int Height { get; private set; }

        public Player(int x, int y, Color color, int width=5, int height=25) : base(x, y, color)
        {
            WriteLine("+++ ctor Player, hash -->" + GetHashCode());
            Width = width;
            Height = height;    
        }

        public new string getInfo()
        {
            return  $"Player: With={Width}, Height={Height}," + base.getInfo().Substring(6);
        }

        public override void echo() {
            WriteLine(this.getInfo());
        }

        public override void move(int dx, int dy)
        {
            WriteLine($"Player move dx:{dx}, dy:{dy}");
            X += dx;
            Y += dy;
            // rendering code
        }

        public override void rotate(int da)
        {
            WriteLine($"Player rotates delta alpha:{da}");
            Alpha += da;
           
        }
    }
}
