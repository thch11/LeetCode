public class Solution
{
    public int FindMaxConsecutiveOnes(int[] nums)
    {
        int maxOnes = 0;

        int currOnes = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] == 1)
            {
                currOnes = currOnes + 1;
                if (currOnes > maxOnes)
                    maxOnes = currOnes;
            }
            else
                currOnes = 0;
        }

        return maxOnes;
    }
}
//https://leetcode.com/problems/max-consecutive-ones
