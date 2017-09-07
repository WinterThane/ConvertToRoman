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
                var result = "";

                if (int.TryParse(input, out int intinput) && intinput > 0 && intinput < 4000)
                {
                    Console.WriteLine("Input was: " + input);

                    result = convert.ToRomanNumber(intinput);

                    for (int i = result.Length - 2; i >= 0; i -= 2)
                    {
                        result = result.Insert(i, " ");
                    }

                    Console.WriteLine("Roman is: " + result);
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Input was not a valid number.");
                    Console.ReadLine();
                }
            }
        }
    }
}
