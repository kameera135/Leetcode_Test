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
            //int[] result = new int[nums.Length];

            for(int i = 0; i < nums.Length; i++)
            {
                for(int j=i+1; j < nums.Length-1; j++)
                {
                    if (nums[i] + nums[j] == target)
                    {
                        return new int[] { i,j };
                    }
                }
            }

            return new int[] { };
        }
    }
}
