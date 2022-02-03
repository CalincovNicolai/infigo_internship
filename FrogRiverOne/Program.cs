using System;
using System.Linq;

namespace ObjectApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arrayElements = new int[] {1, 3, 1, 4, 2, 3, 5, 4};
            int lastPosition = 5;
            Console.WriteLine(FrogRiverOne(lastPosition, arrayElements));
        }

        public static int FrogRiverOne(int lastPosition, int[] arrayElements)
        {
            int[] arrayPositions = new int[lastPosition];
            int leavesFallen = 0;
            
            for (int i = 0; i < arrayElements.Length; i++)
            {
                if (arrayPositions[arrayElements[i] - 1] == 0)
                {
                    arrayPositions[arrayElements[i] - 1]++;
                    leavesFallen++;
                    
                    if (leavesFallen == lastPosition)
                    {
                        return i;
                    }
                }
            }
            
            return -1;
        }
    }
}