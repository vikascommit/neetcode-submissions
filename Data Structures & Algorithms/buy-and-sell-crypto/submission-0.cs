public class Solution {
    public int MaxProfit(int[] prices) {
        int left = 0;
        int right = 1;
        int profit = 0;
        while(right < prices.Length)
        {
            if(prices[left]>prices[right])
            {
                left = right;
            }
            else
            {
                profit = Math.Max(profit,(prices[right]-prices[left]));
            }

            right++;
        }
        return profit;
    }
}
