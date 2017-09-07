using System;

namespace ConvertToRoman
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                var convert = new ConvertToRoman();
                Console.Write("Arabic to roman numeral converter.\nEnter a string: ");
                var input = Console.ReadLine();

                if (int.TryParse(input, out int intinput))
                {
                    Console.WriteLine("Input was: " + input);
                    Console.WriteLine("Roman is: " + convert.ToRomanNumber(intinput));
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Input was not a number.");
                    Console.ReadLine();
                }
            }
        }
    }
}
