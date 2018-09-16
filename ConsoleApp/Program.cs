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
            Random random = new Random();
            Console.WriteLine("Welcome to David's Pi calculator. This program utilizes the monte carlo method.");
            Console.WriteLine("\nInput the amount of randomized coordinates that should be created:");
            int userInput = 0;
            while (!int.TryParse(Console.ReadLine(), out userInput))
            {
                Console.WriteLine("Please Enter a valid numerical value!");
                Console.WriteLine("Input the amount of randomized coordinates that should be created:");
            }
            Coordinates[] CoordArray = new Coordinates[userInput];
            for (int i = 0; i < CoordArray.Length; i++)
            {
                CoordArray[i] = new Coordinates(random);
            }
            double InsideCircleCount = 0;
            foreach (var point in CoordArray)
            {
                double TempHypot = CalcHypot(point);
                if (TempHypot <= 1)
                {
                    InsideCircleCount++;
                }
            }
            double EstimatedPi = ((InsideCircleCount / CoordArray.Length) * 4);
            Console.WriteLine($"The estimated value of pi is {EstimatedPi}. The real value of pi is {Math.PI}");
            Console.WriteLine($"The difference between the programs calculation and the real value is {Math.PI - EstimatedPi}");

        }

        // CalcHypot calculates the hypotnuse of the coordinates in a coordinate struct
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
        public Coordinates(Random random)
        {
            x = random.NextDouble();
            y = random.NextDouble();
        }
    }
    /*
Provide answers for the following:
Why do we multiply the value from step 5 above by 4?
Because we are only generating coordinates for one quadrant of the circle/square

What do you observe in the output when running your program with parameters of increasing size?
The difference is more accurate and a larger decimal

If you run the program multiple times with the same parameter, does the output remain the same? Why or why not?
No because the values are randomly generated.

Find a parameter that requires multiple seconds of run time. What is that parameter? How accurate is the estimated value of ?
There is no such parameter on my overclocked homecomputer. But 239,3292 gave me a number that only became inaccurate at the 5th decimal.

Research one other use of Monte-Carlo methods. Record it in your exercise submission and be prepared to discuss it in class.
AI simulation EI: A computer plays out the many outcomes of the various moves he can make.
 */
}
