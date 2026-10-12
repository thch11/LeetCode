public class Solution
{
    public int LongestConsecutive(int[] nums)
    {
        if (nums.Length == 0)
            return 0;
        int HighestCount = 1;
        int count = 1;
        HashSet<int> seen = new HashSet<int>(nums);
        List<int> numblist = seen.ToList();

        for (int i = 0; i < numblist.Count; i++)
        {
            int MyNumb = numblist[i];
            if (!seen.Contains(MyNumb - 1))
            {
                for (int j = 0; j < seen.Count; j++)
                {
                    if (seen.Contains(MyNumb + (j + 1)))
                    {
                        count++;
                    }
                    else
                    {
                        break;
                    }
                }
                if (count >= HighestCount)
                    HighestCount = count;
                count = 1; 
            }
        }
        return HighestCount;
    }
}
//https://leetcode.com/problems/longest-consecutive-sequence
