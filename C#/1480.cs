/*
Running Sum of 1d Array

Easy
*/

public class Solution
{
    public int[] RunningSum(int[] nums)
    {
        int[] preSum = new int[nums.Length];
        preSum[0] = nums[0];

        for (int i = 1; i < nums.Length; i++)
            preSum[i] = preSum[i - 1] + nums[i];

        return preSum;
    }
}