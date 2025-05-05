using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    public class Solution
    {
         public int maxProfit(int[] prices)
         {
            int maxProfit = 0;
            int minPrice = int.MaxValue;

            foreach (var price in prices)
            {
                if (price < minPrice)
                {
                    minPrice = price;
                }

                else if(price - minPrice > maxProfit)
                {
                    maxProfit = price - minPrice;
                }
            }

            return maxProfit;
         }
    }
}
