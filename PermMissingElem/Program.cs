using System;

namespace ObjectApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] A = new int[] {2,3,1,5};
            Console.WriteLine(solution(A));
        }

        public static int solution(int[] A)
        {
            int n = A.Length + 1;
            long sumOfArrayElements = ((long)n * ((long)n + 1)) / 2;
            int sumValues = 0;
            for (int i = 0; i < A.Length; i++)
                sumValues += A[i];
            long missingValue = sumOfArrayElements - sumValues;
            return (int) missingValue;
        }
    }
}