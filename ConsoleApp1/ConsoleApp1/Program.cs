using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            String message = "Jeremiah";
            String message1 = "Idaho";

            Console.WriteLine("My name is " + message + ", and I am from " + message1);
            Console.ReadLine();
        }

        private static void GlazerApp()
        {
            string widthString, heightString;

            string Jeremiahstring, IdahoString;

            Console.WriteLine("Type the width (feet): ");
            widthString = Console.ReadLine();
            width = double.Parse(widthString);

            Console.WriteLine("Type the height (meters): ");
            heightString = Console.ReadLine();
            height = double.Parse(heightString);

            woodLength = 2 * (width + height) * 3.25;
            glassArea = 2 * (width * height);

            Console.WriteLine("The length of the wood is " + woodLength + " feet");
            Console.WriteLine("The area of the glass is " + glassArea + " square metres");
            Console.ReadLine();
        }
    }
}
