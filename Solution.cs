﻿using System;
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
            List<int> values = new List<int>();

            foreach (var item in nums)
            {
                if (values.Contains(item))
                {
                    return true;
                }
                values.Add(item);
            }
            return false;

        }
    }
}
