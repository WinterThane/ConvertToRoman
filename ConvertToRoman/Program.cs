using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace ConvertToRoman
{
    class Program
    {
        static void Main(string[] args)
        {
            var convert = new ConvertToRoman();
            Console.WriteLine();
            Console.Write(" Arabic to roman numeral converter.\n Enter a string: ");
            var input = Console.ReadLine();


            var words = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();
            var pairs = new List<Tuple<int, string>>();

            foreach (var item in words)
            {
                var x = Regex.Match(item, "[0-9]+");
                if (x.Value != "")
                {
                    var y = convert.ToRomanNumber(int.Parse(x.ToString()));
                    pairs.Add(Tuple.Create(int.Parse(x.ToString()), y));
                }
            }

            //foreach (var item in pairs)
            //{
            //    Console.WriteLine(" Arabic: {0}, Roman: {1}", item.Item1, item.Item2);
            //}

            StringBuilder result = new StringBuilder();

            for (int i = 0; i < words.Count; i++)
            {

                var word = words[i];

                for (int j = 0; j < pairs.Count; j++)
                {

                    if (int.TryParse(words[i], out int intinput) && intinput == pairs[j].Item1)
                    {
                        word = pairs[j].Item2;
                    }
                    //Console.WriteLine(" Arabic: {0}, Roman: {1}", pairs[j].Item1, pairs[j].Item2);
                }
                result.Append(word + " ");
            }

            for (int i = result.Length - 2; i >= 0; i -= 2)
            {

                result = result.Insert(i, " ");
            }

            Console.WriteLine(" Result: {0}", result);

            //foreach (var item in xx)
            //{
            //    Console.WriteLine("Number: {0}", item);
            //}
            Console.ReadLine();
            //var x = Regex.Matches(input, "[0-9]+");

            //if(int.TryParse(input, out int intinput) && intinput > 0 && intinput < 4000)
            //{
            //    Console.WriteLine("Input was: " + input);
            //    result = convert.ToRomanNumber(intinput);

            //    for (int i = result.Length - 2; i >= 0; i-=2)
            //    {
            //        result = result.Insert(i, " ");
            //    }

            //    Console.WriteLine("Roman is: " + result);
            //    Console.ReadLine();
            //}
            //else
            //{
            //    Console.WriteLine("Input was not a valid number.");
            //    Console.ReadLine();
            //}
        }
    }
}
