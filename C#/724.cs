/*
Find Pivot Index
Explanation:
Simple PreSum

Easy
*/

public class Solution724
{
    public int PivotIndex(int[] nums)
    {
        int[] preSum = new int[nums.Length];
        preSum[0] = nums[0];
        for (int i = 1; i < nums.Length; i++)
            preSum[i] = preSum[i - 1] + nums[i];

        for (int i = 0; i < preSum.Length; i++)
        {
            if (preSum[i] - nums[i] == preSum[preSum.Length - 1] - preSum[i])
            {
                return i;
            }
        }
        return -1;
    }
}