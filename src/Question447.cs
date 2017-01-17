using System;
using System.Linq;

namespace LeetCode.Problems
{
    public class Question447
    {
        //It returns the correct value but requires time optimization.
        public int TotalHammingDistance(int[] nums) {
            int distance = 0;

            if(nums.Length > 1) {
                int[] remaining = new int[nums.Length - 1];

                for(int i=1; i < nums.Length; i++) {
                    distance += GetHammingDistance(nums[0], nums[i]);
                    remaining[i - 1] = nums[i];
                }

                return distance + TotalHammingDistance(remaining);
            } 

            return distance;
        }

        public int GetHammingDistance(int num1, int num2) {
            string xor = Convert.ToString(num1 ^ num2, 2);
            return xor.Replace("0", "").Trim().Length;
        }
    }
}
