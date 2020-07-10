using System;
using System.Security.Cryptography.X509Certificates;

namespace Studio
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the radius of the circle:");
            string input = Console.ReadLine();
            double radius = double.Parse(input);
            Console.WriteLine("The area of the circle is: " + Circle.GetArea(radius));
            Console.WriteLine("The circumference of the circle is: " + Circle.GetCircum(radius));
            Console.WriteLine("The diameter of the circle is: " + Circle.GetDiameter(radius));
            Console.WriteLine("Enter the MPG of the car:");
            input = Console.ReadLine();
            double mpg = double.Parse(input);
            Console.WriteLine("It would require " + Circle.GetGallons(radius, mpg) + " gallons to drive around the circumference of the circle.");



        }


    }
}
