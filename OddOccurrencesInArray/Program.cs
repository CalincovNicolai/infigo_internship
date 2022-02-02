using System;
using System.Reflection.Metadata.Ecma335;

namespace ObjectApp
{
    class Solution
    {
        public int OddOccurrencesInArray(int[] arrayElements)
        {
            int elementValue = arrayElements[0];
            for (int i = 1; i < arrayElements.Length; i++)
                elementValue = elementValue ^ arrayElements[i];
            return elementValue;
        }
        
        static void Main(string[] args)
        {
            int[] A = {9, 3, 3, 3, 9, 7, 9};
            var S = new Solution();
            int value = S.OddOccurrencesInArray(A);
            Console.WriteLine(value);
        }
    }
}