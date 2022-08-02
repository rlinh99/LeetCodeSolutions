/*
132 Pattern
iterate from backward

Medium
*/
public class Solution
{
    public bool Find132pattern(int[] nums)
    {
        if (nums == null || nums.Length < 3)
            return false;

        Stack<int> stk = new Stack<int>();
        int max2 = int.MinValue;

        /*loop from right to left 
            [3,1,4,2] properties of monotonic stack. when keeping the previous element of pos2
            when current num larger than increasing stack.
            whenever there is a value smaller than the recorded min, there must be a 132 pattern.
        */
        for (int j = nums.Length - 1; j >= 0; j--)
        {
            if (nums[j] < max2)
                return true;

            while (stk.Count > 0 && nums[j] > stk.Peek())
                max2 = Math.Max(stk.Pop(), max2);

            stk.Push(nums[j]);
        }
        return false;
    }
}