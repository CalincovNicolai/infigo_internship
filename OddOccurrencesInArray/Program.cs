using System;
using System.Reflection.Metadata.Ecma335;

namespace ObjectApp
{
    class Solution
    {
        public int solution(int[] A)
        {
            int elementValue = A[0];
            for (int i = 1; i < A.Length; i++)
                elementValue = elementValue ^ A[i];
            return elementValue;
        }
        
        static void Main(string[] args)
        {
            int[] A = {9, 3, 3, 3, 9, 7, 9};
            var S = new Solution();
            int value = S.solution(A);
            Console.WriteLine(value);
        }
    }
}