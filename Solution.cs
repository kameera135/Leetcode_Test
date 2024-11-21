using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    internal class Solution
    {
        public int[] TwoSums(int[] nums, int target)
        {
            int[] result = new int[nums.Length];

            for(int i = 0; i < nums.Length-1; i++)
            {
                if (nums[i] + nums[i + 1] == target)
                {
                    Console.WriteLine(nums.Length);
                }
            }

            return result;
        }
    }
}
