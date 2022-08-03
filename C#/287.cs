/*
    Find Duplicate Number
    
    Explanation:
    Array as hashmap

    Medium
*/
public class Solution287
{
    public int FindDuplicate(int[] nums)
    {
        bool[] arr = new bool[nums.Length - 1];
        foreach (var num in nums)
        {
            if (arr[num - 1])
                return num;
            arr[num - 1] = true;
        }

        return -1;
    }
}