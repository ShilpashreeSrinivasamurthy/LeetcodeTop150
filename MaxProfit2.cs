// https://leetcode.com/problems/best-time-to-buy-and-sell-stock-ii/description/?envType=study-plan-v2&envId=top-interview-150
 static int MaxProfit2(int[] prices)
        {
            int i = 0;
            int buy = 0;
            int sell = 0;
            int profit = 0;

            while(i < prices.Length - 1)
            {
                while (i < prices.Length - 1 && prices [i + 1] <= prices[i])
                {
                    i++;
                }
                buy = prices[i];

                while (i < prices.Length - 1 && prices[i + 1] > prices[i])
                {
                    i++;
                }
                sell = prices[i];

                profit += (sell - buy);
            }
            return profit;
        }
        // Time Complexity : O(n)
        // Space Complexity : O(1)
