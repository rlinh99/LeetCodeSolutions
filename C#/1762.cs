/*
    1762. Building with Ocean View

    Explanation:
    Monotonic Decreasig Stack

    Medium
*/


public class Solution1762
{
    public int[] FindBuildings(int[] heights)
    {
        Stack<int> stk = new();
        int n = heights.Length;

        for (int i = 0; i < n; i++)
        {
            while (stk.Count > 0 && heights[stk.Peek()] <= heights[i])
                stk.Pop();
            stk.Push(i);
        }

        return stk.Reverse().ToArray();
    }
}