/*
Can Place Flower
Simulation with prev and next

Easy
*/

public class Solution605
{
    public bool CanPlaceFlowers(int[] flowerbed, int n)
    {
        if (flowerbed == null || flowerbed.Length == 0)
            return false;
        int count = n;

        for (int i = 0; i < flowerbed.Length; i++)
        {
            if (flowerbed[i] == 0)
            {
                int prev = (i == 0) ? 0 : flowerbed[i - 1];
                int next = (i == flowerbed.Length - 1) ? 0 : flowerbed[i + 1];
                if (prev == 0 && next == 0)
                {
                    flowerbed[i] = 1;
                    count--;
                }
            }
        }

        return count <= 0;
    }
}