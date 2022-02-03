using System;
using System.Linq;

namespace ObjectApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arrayElements = new int[] {1, 3, 6, 4, 1, 2};
            Console.WriteLine(MissingInteger(arrayElements));
        }

        public static int MissingInteger(int[] arrayElements)
        {
            int arrayLength = arrayElements.Length;
            int minValueFound = 1;
            Array.Sort(arrayElements);

            for (int i = 0; i < arrayLength; i++)
            {
                if (arrayElements[i] <= 0)
                {
                    continue;
                }
                
                else if (arrayElements[i] == minValueFound)
                {
                    minValueFound++;
                }
            }

            return minValueFound;
        }
    }
}