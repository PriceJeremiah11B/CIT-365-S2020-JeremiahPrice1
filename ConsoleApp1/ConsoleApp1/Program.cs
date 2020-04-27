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

            DateTime today = DateTime.Today;
            Console.WriteLine("Today is " + today);
            Console.ReadLine();

            DateTime date1 = new DateTime(2020, 12, 25);
            DateTime date2 = DateTime.Today;
            int daysDiff = ((TimeSpan)(date2 - date1)).Days;
            Console.WriteLine("Days until Christmas: " + daysDiff);
            Console.ReadLine();


        }

        private static void GlazerApp() { 
        
            double width, height, woodLength, glassArea; 
            string widthString, heightString;

            widthString = Console.ReadLine();   
            width = double.Parse(widthString);

            heightString = Console.ReadLine();   
            height = double.Parse(heightString);

            woodLength = 2 * (width + height ) * 3.25 ; 
 
            glassArea = 2 * (width* height ) ; 
 
            Console.WriteLine( "The length of the wood is " +     woodLength + " feet" ) ;
            Console.WriteLine("The area of the glass is " + glassArea + " square metres"); 
            Console.ReadLine();
        }
}
}
