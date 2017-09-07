using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace ConvertToRoman
{
    public class StringFunctions
    {
        public Tuple<string, int> ReplaceStrings(string input)
        {
            var convert = new ConvertToRoman();
            //break the string into words and put them to List
            var words = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();
            //store last character of the last word
            var lastChar = words.Last().Substring(words.Last().Length - 1, 1).ToCharArray();
            //create a tuple for number pairs
            var pairs = new List<Tuple<int, string>>();
            StringBuilder result = new StringBuilder();
            var ending = "";

            //if last character of the last word is not a digit, assign the value of "lastChar" to variable "ending"
            if (!char.IsDigit(lastChar[0]))
            {
                var last = words.Last().Remove(words.Last().Length - 1, 1);
                for (int i = words.Count; i == words.Count; i++)
                {
                    words[i - 1] = last;
                }
                ending = lastChar[0].ToString();
            }

            //assign roman number to each arabic number in list of words and save the pair into a tuple
            foreach (var item in words)
            {
                var number = Regex.Match(item, "[0-9]+");
                if (number.Value != "")
                {
                    if (int.Parse(number.ToString()) >= 1 && int.Parse(number.ToString()) <= 3999)
                    {
                        var romanNumber = convert.ToRomanNumber(int.Parse(number.ToString()));
                        //make space after every two roman numerals
                        for (int i = romanNumber.Length - 2; i >= 0; i -= 2)
                        {
                            romanNumber = romanNumber.Insert(i, " ");
                        }
                        pairs.Add(Tuple.Create(int.Parse(number.ToString()), romanNumber));
                    }
                }
            }

            //go through all words and if any of them is an arabic number, replace it with roman number
            //concatinate every word into a string
            for (int i = 0; i < words.Count; i++)
            {
                var word = words[i];

                for (int j = 0; j < pairs.Count; j++)
                {
                    if (int.TryParse(words[i], out int intinput) && intinput == pairs[j].Item1)
                    {
                        word = pairs[j].Item2;
                    }
                }
                result.Append(word + " ");
            }

            //remove any unwanted spaces
            var cleanedResult = Regex.Replace(result.ToString(), @"\s+", " ");

            //return cleaned string and a number of replacements as a tuple
            return Tuple.Create(cleanedResult.TrimEnd() + ending, pairs.Count);
        }
    }
}
