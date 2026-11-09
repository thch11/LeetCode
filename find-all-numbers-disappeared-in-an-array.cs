public class Solution
{
    public IList<int> FindDisappearedNumbers(int[] nums)
    {
        HashSet<int> numbers = new HashSet<int>(nums);

        List<int> returnList = new List<int>();

        for (int i = 1; i < nums.Length + 1; i++)
        {
            if (!numbers.Contains(i))
                returnList.Add(i);

        }
        return returnList;

    }
}
//https://leetcode.com/problems/find-all-numbers-disappeared-in-an-array/
