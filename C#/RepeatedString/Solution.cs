using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepeatedString
{
    class Solution
    {
        // Complete the repeatedString function below.
        static long repeatedString(string s, long n)
        {
            long charCount = 0;
            
            foreach (char c in s)
            {
                if (c == 'a')
                {
                    charCount++;
                }
            }

            long repeatCount = n / s.Length;
            long remain = n % s.Length;
            string remainString = s.Substring(0, Convert.ToInt32(remain));
            charCount = charCount * repeatCount;

            foreach (char c in remainString)
            {
                if (c == 'a')
                {
                    charCount++;
                }
            }

            
            return charCount;
        }

        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            long n = Convert.ToInt64(Console.ReadLine());

            long result = repeatedString(s, n);
            Console.WriteLine(result);
        }
    }
}
