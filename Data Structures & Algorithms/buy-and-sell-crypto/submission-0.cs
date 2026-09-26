public class Solution {
    public int MaxProfit(int[] prices) {
        int currMin = int.MaxValue;
        int n = prices.Length;
        int maxProf = 0;
        for(int i=0;i<n;i++){
            if(prices[i] < currMin){
                currMin = prices[i];
            }
            int prof = prices[i] - currMin;
            if(prof > maxProf){
                maxProf = prof;
            }
        }
        return maxProf;
    }
}
