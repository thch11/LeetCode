public class Solution {
    public IList<IList<int>> Subsets(int[] nums) 
    {
        IList<IList<int>> returnList = new List<IList<int>>();

        BackTracking(0, new List<int>());

        void BackTracking(int index, List<int> Listerinos)
        {
            returnList.Add(new List<int>(Listerinos));

            for(int i = index; i < nums.Length; i++)
            {
                Listerinos.Add(nums[i]);
                BackTracking(i + 1, Listerinos);
                Listerinos.Remove(nums[i]);
            }
        }
        return returnList;
    }
}
//https://leetcode.com/problems/subsets
