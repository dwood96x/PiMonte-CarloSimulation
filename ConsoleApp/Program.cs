using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {

        }
        public static double CalcHypot(Coordinates coord)
        {
            double hypot = Math.Sqrt(Math.Pow(coord.x, 2) + Math.Pow(coord.y, 2));
            return hypot;
        }
    }
    struct Coordinates
    {
        public double x;
        public double y;
        public Coordinates(double x_, double y_)
        {
            x = x_;
            y = y_;
        }
        /*
        public double GetX()
        {
            return x;
        }
        public double GetY()
        {
            return y;
        }
        */
    }
}
