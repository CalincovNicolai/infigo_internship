using System;

namespace ObjectApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(FrogJmp(10, 85, 30));
        }

        public static int FrogJmp(int X, int Y, int D)
        {
            return (int) Math.Ceiling((double)(Y - X) / D);
        }
    }
}