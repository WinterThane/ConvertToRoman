using System;

namespace ConvertToRoman
{
    class Program
    {
        static void Main(string[] args)
        {
            var convert = new ConvertToRoman();
            var strFunct = new StringFunctions();

            Console.WriteLine();
            Console.Write(" Arabic to roman numeral converter.\n Enter a string: ");

            var input = Console.ReadLine();
            var result = strFunct.ReplaceStrings(input);

            Console.WriteLine("\n Result: {0}\n Number of replacements: {1}", result.Item1, result.Item2);
            Console.ReadLine();
        }
    }
}
