using System;
using System.Linq;

namespace ObjectApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] A = new int[] {3, 1, 2, 4, 3};
            Console.WriteLine(solution(A));
        }

        public static int solution(int[] A)
        {
            int leftSum = A[0];
            int rightSum = A.Sum() - A[0];
            int minDifference = Math.Abs(leftSum - rightSum);
            for (int i = 1; i < A.Length - 1; i++)
            {
                leftSum += A[i];
                rightSum -= A[i];
                if (Math.Abs(leftSum - rightSum) < minDifference)
                {
                    minDifference = Math.Abs(leftSum - rightSum);
                }
            }
            return minDifference;
        }
    }
}

