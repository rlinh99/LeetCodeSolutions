public class Solution
{
    public int RemoveDuplicates(int[] nums)
    {
        int head = 1;
        for (int i = 1; i < nums.Length; i++)
        {
            if (nums[i] != nums[i - 1])
            {
                head++;
                nums[head - 1] = nums[i];
            }
        }
        return head;
    }
}