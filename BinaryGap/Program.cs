using System;

namespace ObjectApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var S = new Solution();
            int N = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\r");
            Console.WriteLine("Number introduced: " + N);
            Console.WriteLine("Longest binary gap = " + S.solution(N));
        }
    }

    class Solution
    {
        public int solution(int N)
        {
            string bits = Convert.ToString(N, 2);
            int longest = 0;
            int longestReal = 0;
            int curCount = 0;

            for (int i = 0; i < bits.Length; i++)
            {
                if (bits[i] == '0')
                {
                    if (curCount > 0) curCount++;
                    else curCount = 1;
                } else curCount = 0;
                if (curCount > longest) longest = curCount;
                if (bits[i] == '1' && longest > longestReal) longestReal = longest;
            }
            return longestReal;
        }
    }
}