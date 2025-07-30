using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    public class Solution
    {
        public IList<IList<string>> GroupAnagrams(string[] strs)
        {
            var result = new Dictionary<string, List<string>>();

            foreach (var value in strs)
            {
                char[] charValue = value.ToCharArray();
                Array.Sort(charValue);

                string sortedString = new string(charValue);

                if(!result.ContainsKey(sortedString))
                {
                    result[sortedString] = new List<string>();
                }

                result[sortedString].Add(value);
            }


            return result.Values.ToList<IList<string>>();
        }
    }
}
