using System;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {
            int currentHours = 14;
            int currentMinutes = 34;
            int currentSeconds = 42;

            // Write a program that prints the remaining seconds (as an integer) from a
            // day if the current time is represented by the variables
            double remainingHours = 23 - currentHours;
            double remaininMinutes = remainingHours * 60 + (60 - currentMinutes);
            double remainingSeconds = remaininMinutes * 60 + (60-currentSeconds);

            Console.WriteLine("The remaining second of the day are " + remainingSeconds);
            Console.Read();
        }
    }
}