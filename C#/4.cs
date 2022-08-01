/*
Medium of two sorted array. 
Binary Search for two arrays, divide two array elements as a whole.

Hard
*/
public class Solution
{
    public double FindMedianSortedArrays(int[] nums1, int[] nums2)
    {
        int m = nums1.Length, n = nums2.Length;
        //reverse for easy execution, nums1 always smaller or equal to nums2
        if (nums1.Length > nums2.Length)
            return FindMedianSortedArrays(nums2, nums1);

        int total = (m + n + 1) / 2;
        int left = 0, right = m;
        //num1 i - num2 j -> i+j = total
        while (left < right)
        {
            int mid1 = left + (right - left + 1) / 2;
            //num1[i-1] <= num2[j]
            //num2[j-1] <= num1[i]
            int mid2 = total - mid1;
            if (nums1[mid1 - 1] > nums2[mid2])
                right = mid1 - 1;
            else
                left = mid1;
        }

        int i = left;
        int j = total - i;
        int num1LeftMax = i == 0 ? int.MinValue : nums1[i - 1];
        int num1RightMin = i == m ? int.MaxValue : nums1[i];
        int num2LeftMax = j == 0 ? int.MinValue : nums2[j - 1];
        int num2RightMin = j == n ? int.MaxValue : nums2[j];
        if ((m + n) % 2 == 1)
            return (double)Math.Max(num1LeftMax, num2LeftMax);
        else
            return (double)(Math.Max(num1LeftMax, num2LeftMax)
                            + Math.Min(num1RightMin, num2RightMin)) / 2;

    }
}