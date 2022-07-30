/*
nlogn - sort
*/
public class Solution
{
    public int FindUnsortedSubarray(int[] nums)
    {
        var sorted = nums.OrderBy(x => x).ToList();
        int start = nums.Length, end = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            if (sorted[i] != nums[i])
            {
                start = Math.Min(i, start);
                end = Math.Max(i, start);
            }
        }
        return end - start >= 0 ? end - start + 1 : 0;
    }
}