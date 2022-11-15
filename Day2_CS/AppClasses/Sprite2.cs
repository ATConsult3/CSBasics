using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace andestech.learning.cs2022.game
{
    public class Sprite2
    {
        public int X { get; set; }
        public int Color { get; private set; }

        //private int _x, _y;
        private int _y;
        //private int _color;
        //private const int MAX_Y = 600, MIN_Y = 0;
        //public static int MAX_Y { get; private set; } = 600;
        public static readonly int MIN_Y = 0, MAX_Y = 600;
       


        //public void setX(int x) { this.x = x; }
        // public int getX() { return this.x; }

        public Sprite2() {
            WriteLine("+++ ctor Sprite2, hash-->" + GetHashCode());
        }

        public Sprite2(int color):this()
        {
          Color = color;
        }

        public Sprite2(int x, int y, int color) : this(color)
        {
            X = x;
            Y = y;
        }

        ~Sprite2() {
            WriteLine("--- dtor Sprite2, hash-->" + GetHashCode());

        }


        private static bool isYValid(int y)
        { 
         if(y<=MAX_Y && y>=MIN_Y) return true;
         return false;
        
        }

            

        //public int X { 
        //    get { return _x; } 
        //    set { _x = value; }
        //}

        public int Y
        {
            get { return this._y; }
            set {

                if (!isYValid(value)) throw new Exception("Y is not valid");
                this._y = value; }
        }



        //public int Color
        //{
        //    get { return this._color; }
        //    private set { this._color = value; }
        //}

        private string getInfo() {
            return $"Sprite x={X}, y={Y}, Color={Color}";
        }

        public void echo() { WriteLine(getInfo()); }


        //....


    }
}
