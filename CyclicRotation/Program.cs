using System;

namespace ObjectApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arrayElements = {3, 8, 9, 7, 6};
            int numRotation = 2;
            var S = new Solution();
            Console.WriteLine("New Array = " + S.CyclicRotation(arrayElements, numRotation));
        }
    }
}