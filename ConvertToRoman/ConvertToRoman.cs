﻿using System;
using System.Text;

namespace ConvertToRoman
{
    public class ConvertToRoman
    {
        public string ToRomanNumber(int input)
        {
            var result = new StringBuilder();

            //Roman numerals do not represent digits that are zero.
            //Input values are known to be in the range 1..3999.
            if (input <= 0 || input > 3999)
                throw new ArgumentOutOfRangeException("Roman numerals are only positive numbers between 1 and 3999.");
           
            int remainder = input;

            //Roman numerals consist of the letters I (1), V (5), X (10), L (50), C (100), D (500), M (1000)
            while (remainder > 0)
            {
                if (remainder >= 4)
                {
                    result.Append("IV");
                    remainder -= 4;
                }
                else if (remainder >= 1)
                {
                    result.Append("I");
                    remainder--;
                }
                else
                {
                    throw new Exception("Something went wrong.");
                }
            }
            return result.ToString();
        }
    }
}
