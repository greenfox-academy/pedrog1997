using System;

namespace AppendAFunc
{
    class Program
    {
        static void Main(string[] args)
        {
            // - Create a string variable named `am` and assign the value `kuty` to it
            // - Write a function called `appendA` that gets a string as an input,
            //   appends an 'a' character to its end and returns with a string
            // - Print the result of `appendAFunc(am)`

            string am = "kuty";
            Console.WriteLine(AppendA(am));
            Console.ReadLine();
        }

        static string AppendA(string input)
        {
            return input + "a";
        }
    }
}