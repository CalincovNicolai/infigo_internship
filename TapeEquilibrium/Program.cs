using System;
using System.Linq;

namespace ObjectApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arrayElements = new int[] {3, 1, 2, 4, 3};
            Console.WriteLine(TapeEquilibrium(arrayElements));
        }
        public static int TapeEquilibrium(int[] arrayElements)
        {
            int leftSum = arrayElements[0];
            int rightSum = arrayElements.Sum() - arrayElements[0];
            int minDifference = Math.Abs(leftSum - rightSum);
            
            for (int i = 1; i < arrayElements.Length - 1; i++)
            {
                leftSum += arrayElements[i];
                rightSum -= arrayElements[i];
                int absValue = Math.Abs(leftSum - rightSum);
                
                if (absValue < minDifference)
                {
                    minDifference = absValue;
                }
            }
            
            return minDifference;
        }
    }
}

