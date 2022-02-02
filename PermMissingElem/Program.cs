using System;

namespace ObjectApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] arrayElements = new int[] {2,3,1,5};
            Console.WriteLine(PermMissingElem(arrayElements));
        }

        public static int PermMissingElem(int[] arrayElements)
        {
            int n = arrayElements.Length + 1;
            long sumOfArrayElements = ((long)n * ((long)n + 1)) / 2;
            int sumValues = 0;

            for (int i = 0; i < arrayElements.Length; i++)
            {
                sumValues += arrayElements[i];
            }
            long missingValue = sumOfArrayElements - sumValues;
            
            return (int) missingValue;
        }
    }
}