using System;
using System.Linq;

namespace ObjectApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arrayElements = new int[] {3, 4, 4, 6, 1, 4, 4};
            int intNumber = 5;
            Console.WriteLine(MaxCounter(intNumber, arrayElements));
        }

        public static int[] MaxCounter(int intNumber, int[] arrayElements)
        {
            int[] arrayCounters = new int[intNumber];
            int arrayElementsLength = arrayElements.Length;

            for (int i = 0; i < arrayElementsLength; i++)
            {
                int counter = arrayElements[i];
                
                if (counter >= 1 && counter <= intNumber)
                {
                    arrayCounters[counter - 1] = arrayCounters[counter - 1] + 1;
                }

                if (counter == intNumber + 1)
                {
                    int tempMaxCounter = arrayCounters.Max();
                    int arrayCountersLength = arrayCounters.Length;
                
                    for (int j = 0; j < arrayCountersLength; j++)
                    {
                        arrayCounters[j] = tempMaxCounter;
                    }
                }
            }

            return arrayCounters;
        }
    }
}