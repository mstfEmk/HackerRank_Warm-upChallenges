using System;
using System.Collections.Generic;
using System.IO;

namespace SockMerchant
{
    class Solution
    {

        // Complete the sockMerchant function below.
        static int sockMerchant(int n, int[] ar)
        {
            int pairCount = 0;

            Dictionary<int, int> sockCount = new Dictionary<int, int>();

            foreach (int i in ar)
            {
                if (sockCount.ContainsKey(i))
                {
                    sockCount[i] = sockCount[i] + 1;
                }
                else
                {
                    sockCount.Add(i, 1);
                }
            }

            foreach(int i in sockCount.Keys)
            {
                if (sockCount[i] / 2 > 0) 
                {
                    pairCount += sockCount[i] / 2;
                }
            }

            return pairCount;
        }

        static void Main(string[] args)
        {
            TextWriter textWriter = new StreamWriter("./../../output.txt");

            int n = Convert.ToInt32(Console.ReadLine());

            int[] ar = Array.ConvertAll(Console.ReadLine().Trim().Split(' '), arTemp => Convert.ToInt32(arTemp));
            int result = sockMerchant(n, ar);

            textWriter.WriteLine(result);

            textWriter.Flush();
            textWriter.Close();
        }
    }
}
