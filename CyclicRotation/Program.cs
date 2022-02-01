using System;

namespace ObjectApp
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int[] A = {3, 8, 9, 7, 6};
            int K = 2;
            var S = new Solution();
            Console.WriteLine("New Array = " + S.solution(A, K));
        }
    }

    class Solution
    {
        public int[] solution(int[] A, int K)
        {
            int N = A.Length;
            int[] B = new int[N];
            if(N > 0 && K % N != 0 )
            {
                for ( int i = 0; i < N; i++)
                {
                    B[(K + i) % N] = A[i];
                }
            }
            else
            {
                return A;
            }
            return B;
        }
    }
}