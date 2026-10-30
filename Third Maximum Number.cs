public class Solution
{
    public int ThirdMax(int[] nums)
    {
        HashSet<int> coll = new HashSet<int>(nums);
        List<int> Listerinos = coll.ToList();
        Listerinos.Sort();

        if (coll.Count > 2)
            return Listerinos[Listerinos.Count - 3];
        else
            return Listerinos[Listerinos.Count - 1];
    }
}
//https://leetcode.com/problems/third-maximum-number/
