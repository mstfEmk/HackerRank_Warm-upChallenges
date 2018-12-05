using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountingValleys
{
    class Solution
    {
        // Complete the countingValleys function below.
        static int countingValleys(int n, string s)
        {
            int level = 0;
            bool inValley = false;
            int valleyCount = 0;

            foreach (char c in s)
            {
                if (c == 'U')
                {
                    level++;
                } else if (c == 'D')
                {
                    level--;
                }

                if (level < 0)
                {
                    inValley = true;
                }

                if (inValley == true)
                {
                    if (level == 0)
                    {
                        valleyCount++;
                        inValley = false;
                    }
                }

            }
            return valleyCount;
        }

        static void Main(string[] args)
        {
            // 8 UDDDUDUU => 1
            // 12 DDUUDDUDUUUD => 2

            int n = Convert.ToInt32(Console.ReadLine());

            string s = Console.ReadLine();

            int result = countingValleys(n, s);

            Console.WriteLine(result);

        }
    }
}
