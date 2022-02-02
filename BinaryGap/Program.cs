using System;

namespace ObjectApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var S = new Solution();
            int Number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\r");
            Console.WriteLine("Number introduced: " + Number);
            Console.WriteLine("Longest binary gap = " + S.BinaryGap(Number));
        }
    }
}