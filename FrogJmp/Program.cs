using System;

namespace ObjectApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Solution(10, 85, 30));
        }

        public static int Solution(int X, int Y, int D)
        {
            int step;
            if ((Y - X) % D == 0)
                step = (Y - X) / D;
            else
                step = (Y - X) / D + 1;
            return step;
        }
    }
}