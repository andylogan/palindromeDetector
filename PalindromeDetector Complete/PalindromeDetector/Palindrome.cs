using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace PalindromeDetector
{
    public class PalindromeDetector
    {
        public bool IsPalindrome(string candidate)
        {
            var result = GroomInput(candidate);
            var x = 0;
            var y = result.Length - 1;

            do
            {
                if (x >= y) return true;
            }
            while (result[x++] == result[y--]);

            return false;
        }

        public string GroomInput(string input)
        {
            var output = "";

            foreach(var character in input)
            {
                if (char.IsLetterOrDigit(character))
                {
                    output += character;
                }
            }
            return output.ToLower();
        }
    }
}
