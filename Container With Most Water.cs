public class Solution
{
    public int MaxArea(int[] height)
    {
        int left = 0;
        int right = height.Length - 1;
        int output = 0;
        for (int i = 0; i < height.Length; i++)
        {
            int LowestHeight = 0;
            if (height[left] == height[right])
                LowestHeight = height[left];
            else
                if (height[left] > height[right])
                    LowestHeight = height[right];
                else
                    LowestHeight = height[left];
            int volume = LowestHeight * (right - left);
            if (volume > output)
                output = volume;
            if (height[right] > height[left])
                left++;
            else
                right--;
        }
        return output;
    }
}
//https://leetcode.com/problems/container-with-most-water/
