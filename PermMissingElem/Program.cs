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
            int sumOfArrayElements = (n * (1 + n)) / 2;
            int missingValue = sumOfArrayElements - A.Sum();
            return missingValue;
        }
    }
}