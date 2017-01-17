using System;
using LeetCode.Problems;

namespace LeetCode
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Question447 q = new Question447();
            Console.WriteLine(q.TotalHammingDistance(new int[]{4, 14, 2}));
        }
    }
}
