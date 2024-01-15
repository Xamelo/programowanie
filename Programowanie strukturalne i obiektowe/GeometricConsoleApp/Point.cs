using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricConsoleApp
{
    public class Point
    {
        private int x, y;

        public int Y
        {
            get
            {
                return y;
            }
            set
            {
                if (value > 0)
                    y = value;
                else
                    throw new ArgumentException("Nie mozna ustawic wartosci ujemnych");
            }
        }

        public void SetX(int a)
        {
            if (a > 0)
                x = a;
            else
                throw new ArgumentException("Nie mozna ustawic wartosci ujemnych");
        }

        public int GetX()
        {
            return x;
        }

        public void Display()
        {
            Console.WriteLine(x.ToString() + ", " + y.ToString());
        }

        public double DistanceFromCenter
        {
            get
            {
                return Math.Sqrt(x * x + y * y);
            }
        }

        #region konstruktory
        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public Point()
        {
            this.x = 0;
            this.y = 0;
        }
        #endregion
    }
}