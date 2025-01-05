namespace LeetCodeSolutions.Solutions.BestTimeToBuyAndSellStock;

public class BestTimeToBuyAndSellStockSolution
{
    public int MaxProfit(int[] prices) {

        int low = prices[0];
        int profit = 0;
        int currentProfit;
        foreach(int price in prices)
        {
            if(price < low)
            {
                low = price;
            }
            
            currentProfit = price - low;
            if(currentProfit > profit)
            {
                profit = currentProfit;
            }
        }
        return profit;
        // int currentProfit = 0;
        // int profit = 0;
        
        // for(int i = 0; i < prices.Length; i++)
        // {
        //     for(int j = 0; j < prices.Length; j++)
        //     {
        //         currentProfit = prices[j] - prices[i];
        //         if(j > i && prices[j] > prices[i])
        //         {
        //             if(currentProfit > profit)
        //             {
        //                 profit = currentProfit;
        //             }
        //         }
        //     }
        // }
        // return profit;
        
    }
}