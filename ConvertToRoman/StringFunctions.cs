using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace ConvertToRoman
{
    public class StringFunctions
    {
        public Tuple<string, int> ReplaceStrings(string input)
        {
            var convert = new ConvertToRoman();
            var words = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();
            var pairs = new List<Tuple<int, string>>();
            var result = "";

            foreach (var item in words)
            {
                var number = Regex.Match(item, "[0-9]+");
                if (number.Value != "")
                {
                    var romanNumber = convert.ToRomanNumber(int.Parse(number.ToString()));
                    pairs.Add(Tuple.Create(int.Parse(number.ToString()), romanNumber));
                }
            }

            return Tuple.Create(result, pairs.Count);
        }
    }
}
