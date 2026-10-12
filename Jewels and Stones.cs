public class Solution {
    public int NumJewelsInStones(string jewels, string stones) 
    {
        HashSet<char> Jewels = new HashSet<char>(jewels);
        int count = 0;
        for(int i = 0; i < stones.Length; i++)
        {
            if(Jewels.Contains(stones[i]))
                count++;
        }
        return count;
    }
}
//https://leetcode.com/problems/jewels-and-stones/
