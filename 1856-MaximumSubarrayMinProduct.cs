public class Solution
{
    public int MaxSumMinProduct(int[] nums)
    {
        long[] preSum = new long[nums.Length];
        preSum[0] = nums[0];

        for (int j = 1; j < nums.Length; j++)
            preSum[j] = preSum[j - 1] + nums[j];

        long res = 0;
        Stack<int> stk = new();
        int i = 0;
        while (i < nums.Length || stk.Count > 0)
        {
            if (stk.Count == 0 || (i < nums.Length && nums[i] > nums[stk.Peek()]))
                stk.Push(i++);
            else
            {
                int curr = stk.Pop();
                long start = stk.Count == 0 ? 0 : preSum[stk.Peek()];
                long end = preSum[i - 1];
                res = Math.Max(res, nums[curr] * (end - start));
            }
        }
        return (int)(res % 1000000007);
    }
}