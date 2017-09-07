using System;

namespace ConvertToRoman
{
    public class ConvertToRoman
    {
        public string ToRomanNumber(int input)
        {
            var result = "";

            if (input <= 0)
                throw new ArgumentOutOfRangeException("Roman numerals are only positive numbers, greater than zero.");

            int remeinder = input;

            while (remeinder > 0)
            {
                if (remeinder >= 1)
                {
                    result += "I";
                    remeinder--;
                }
                else
                {
                    throw new Exception("Something went wrong.");
                }
            }
            return result;
        }
    }
}
