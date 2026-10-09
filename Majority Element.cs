public class Solution
{
    public int MajorityElement(int[] nums)
    {
        List<NumbHolder> numbList = new List<NumbHolder>();

        for (int i = 0; i < nums.Length; i++)
        {
            bool NumberAlreadyExists = false;
            for(int j = 0; j  < numbList.Count ; j++)
            {
                if (nums[i] == numbList[j].val)
                {
                    NumberAlreadyExists = true;
                    numbList[j].count++;
                }
            }
            if (!NumberAlreadyExists)
            {
                numbList.Add(new NumbHolder(nums[i]));
            }
        }
        NumbHolder highestCount = numbList[0];
        for(int i = 0; i < numbList.Count ; i++)
        {
            if(highestCount.count < numbList[i].count)
            {
                highestCount = numbList[i];
            }
        }
        return highestCount.val;

    }
}

class NumbHolder
{
    public int count = 0;
    public int val = 0;
    public NumbHolder(int num)
    {
        this.val = num;
        this.count++;
    }
}

// https://leetcode.com/problems/majority-element/
