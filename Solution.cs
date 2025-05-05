using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    public class Solution
    {
        public bool ContainsDuplicate(int[] nums)
        {
            List<int> list = new List<int>();

            foreach (var item in nums)
            {
                if(list.Contains(item))
                {
                    return true;
                }
                list.Add(item);
            }
            return false;

        }
    }
}
