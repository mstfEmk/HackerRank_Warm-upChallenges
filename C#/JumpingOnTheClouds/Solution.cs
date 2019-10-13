using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JumpingOnTheClouds
{
    class Solution
    {
        // Complete the jumpingOnClouds function below.
        static int jumpingOnClouds(int[] c)
        {
            int step = 0;
            for (int i = 0; i < c.Length; i++)
            {
                if (i + 2 <= c.Length - 1)
                {
                    if (c[i + 2] == 0)
                    {
                        i++;
                    }
                    step++;
                }
                else if (i + 1 <= c.Length - 1)
                {
                    if (c[i + 1] == 0)
                    {
                        step++;
                    }
                }
            }

            return step;
        }

        static void Main(string[] args)
        {
            // 7 | 0 0 1 0 0 1 0 => 4
            int n = Convert.ToInt32(Console.ReadLine());

            int[] c = Array.ConvertAll(Console.ReadLine().Split(' '), cTemp => Convert.ToInt32(cTemp));
            int result = jumpingOnClouds(c);

            Console.WriteLine(result);
        }
    }
}
