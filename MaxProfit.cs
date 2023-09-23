// https://leetcode.com/problems/best-time-to-buy-and-sell-stock/description/?envType=study-plan-v2&envId=top-interview-150

int MaxProfit(int[] prices)
        {
            int leastPrice = Int32.MaxValue;
            int maxProfit = 0;
            foreach (int price in prices)
            {
                if (price < leastPrice)
                {
                    leastPrice = price;
                }
                int profit = price - leastPrice;
                if (profit > maxProfit)
                {
                    maxProfit = profit;
                }
            }
            return maxProfit;
        }
        // Time Complexity : O(n)
        // Space Complexity : O(1)
