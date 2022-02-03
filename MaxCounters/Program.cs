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

        /*public static int[] MaxCounter(int intNumber, int[] arrayElements)
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
    }*/
        
        public static int[] MaxCounter(int intNumber, int[] arrayElements)
        {
            int[] arrayCounters = new int[intNumber];
            
            int minValue = 0;
            int maxValue = 0;
            int arrayElementsLength = arrayElements.Length;

            for (int i = 0; i < arrayElementsLength; i++)
            {
                if (arrayElements[i] <= intNumber)
                {
                    if (arrayCounters[arrayElements[i] - 1] < minValue + 1)
                    {
                        arrayCounters[arrayElements[i] - 1] = minValue + 1;
                    }

                    else
                    {
                        arrayCounters[arrayElements[i] - 1]++;
                    }

                    if (arrayCounters[arrayElements[i] - 1] > maxValue)
                    {
                        maxValue = arrayCounters[arrayElements[i] - 1];
                    }
                }
                
                else
                {
                    minValue = maxValue;
                }
            }

            for (int j = 0; j < intNumber; j++)
            {
                if (arrayCounters[j] < minValue)
                {
                    arrayCounters[j] = minValue;
                }
            }
            

            return arrayCounters;
        }
    }
}