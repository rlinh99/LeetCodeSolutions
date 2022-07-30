public class Solution33
{
    public int Search(int[] nums, int target)
    {
        int m = nums.Length;
        if (nums.Length == 1)
            return nums[0] == target ? 0 : -1;
        int offset = 0;
        for (int i = 1; i < nums.Length; i++)
        {
            if (nums[i - 1] > nums[i])
            {
                offset = i;
                break;
            }
        }
        int left = 0,
            right = nums.Length - 1;
        while (left <= right)
        {
            int mid = left + (right - left) / 2;
            int realMid = mid + offset > m - 1 ? mid + offset - m : mid + offset;
            if (nums[realMid] < target)
                left = mid + 1;
            else if (nums[realMid] > target)
                right = mid - 1;
            else
                return realMid;
        }
        return -1;
    }
}
