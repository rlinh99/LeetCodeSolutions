/*
    377. Combination Sum IV

    Explanation:
    DP. It's actually a permutation problem. 
    Just need to find how many ways for current dp to add up from previous left dp.

    Medium
*/

public class Solution {
    public int CombinationSum4(int[] nums, int target) {
        int[] dp = new int[target +1];
        dp[0] = 1;
        
        for(int i = 1; i < dp.Length; i++){
            foreach(var num in nums){
                if(i - num >= 0)
                    dp[i] += dp[i - num];
            }
        }
        return dp[target];
    }
}