using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    public class Solution
    {
        public int[] TwoSum(int[] nums, int target)
        {
            Dictionary<int, int> keyValues = new Dictionary<int, int>();

            for(int i=0; i<nums.Length; i++)
            {
                int complement = target - nums[i];

                if (keyValues.ContainsKey(complement))
                {
                    return new int[] {keyValues[complement],i};
                }

                if (!keyValues.ContainsKey(nums[i]))
                {
                    keyValues[nums[i]] = i;
                }
            }

            return new int[] { };

        }
    }
}
