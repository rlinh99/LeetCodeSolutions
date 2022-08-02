/*
Sum of Subarray Mins
Monotonic Stack - find decreasing element
Find Boundaries

Medium
*/
public class Solution
{
    public int SumSubarrayMins(int[] arr)
    {
        int n = arr.Length;
        Stack<int> stk = new();

        int i = 0;
        long mod = 1000000007;
        long res = 0;
        
        while (i < n || stk.Count > 0)
        {
            if (stk.Count == 0 || (i < n && arr[i] > arr[stk.Peek()]))
            {
                stk.Push(i++);
            }
            else
            {
                int curr = stk.Pop();
                int start = stk.Count == 0 ? -1 : stk.Peek();
                int end = i;
                res = (res + (long)arr[curr] * (end - curr) * (curr - start)) % mod;
            }
        }

        return (int)res;
    }
}