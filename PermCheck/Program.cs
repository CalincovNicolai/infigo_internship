using System;
using System.Linq;

namespace ObjectApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arrayElements = new int[] {4, 1, 3, 2};
            Console.WriteLine(PermCheck(arrayElements));
        }

        public static int PermCheck(int[] arrayElements)
        {
            int arrayLength = arrayElements.Length;
            int permutationResult = 1;
            Array.Sort(arrayElements);

            for (int i = 0; i < arrayLength; i++)
            {
                if (arrayElements[i] != (i + 1))
                {
                    permutationResult = 0;
                    break;
                }
            }

            return permutationResult;
        }
    }
}