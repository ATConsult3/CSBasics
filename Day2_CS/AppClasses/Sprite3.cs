using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace andestech.learning.cs2022.game
{
    public abstract class Sprite3 : IMovable
    {
        public int X { get; set; }
        public int Alpha { get; set; }

        public Color Color { get; private set; }

        private int _y;
        public static readonly int MIN_Y = 0, MAX_Y = 600;
       
        private Sprite3() {
            WriteLine("+++ ctor Sprite3, hash-->" + GetHashCode());
        }

        public Sprite3(Color color):this()
        {
          Color = color;
        }

        public Sprite3(int x, int y, Color color, int alpha=0) : this(color)
        {
            X = x;
            Y = y;
            Alpha = alpha;
        }

        ~Sprite3() {
            WriteLine("--- dtor Sprite3, hash-->" + GetHashCode());

        }

        public abstract void move(int dx, int dy);
        public abstract void rotate(int da);

        //{
        //    WriteLine($"Sprite move dx:{dx}, dy:{dy}");
        //    X += dx;
        //    Y += dy;
        //    // rendering code
        //}

        private static bool isYValid(int y)
        { 
         if(y<=MAX_Y && y>=MIN_Y) return true;
         return false;
        
        }

        public int Y
        {
            get { return this._y; }
            set {

                if (!isYValid(value)) throw new Exception("Y is not valid");
                this._y = value; }
        }

        protected string getInfo() {
            return $"Sprite x={X}, y={Y}, alpha={Alpha}, Color={Color}";
        }

        public virtual void echo() { WriteLine(getInfo()); }

    }
}
