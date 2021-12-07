using System;

namespace Exercise2Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("What is the area of your circle?");
            var radius = double.Parse(Console.ReadLine());
            AreaOfCircle(radius);

        }

        public static double AreaOfCircle(double radius)
        {
            return Math.PI * radius * radius;
        }
       
    }
}
