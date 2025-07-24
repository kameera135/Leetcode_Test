using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    public class Solution
    {
        public bool IsAnagram(string s, string t)
        {
            char[] chars = s.ToCharArray();
            char[] chars2 = t.ToCharArray();

            if(chars.Length != chars2.Length)
            {
                return false;
            }

            Array.Sort(chars);
            Array.Sort(chars2);

            return chars.SequenceEqual(chars2);
                
        }
    }
}
