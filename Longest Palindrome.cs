public class Solution
{
    public int LongestPalindrome(string s)
    {
        Dictionary<char, int> Collection = new Dictionary<char, int>();
        for(int i = 0; i < s.Length; i++)
        {
            if (Collection.ContainsKey(s[i]))
            {
                Collection[s[i]]++;
            }
            else
            {
                Collection.Add(s[i], 1);
            }
        }

        int palSum = 0;

        var items = Collection.ToList();

        for (int i = 0; i < items.Count; i++)
        {
            char key = items[i].Key;
            int value = items[i].Value;
            if (value % 2 == 0)
                palSum += value;
            else if (value > 2)
                palSum += value - 1;
        }

        if (palSum < s.Length)
            palSum++;

        return palSum;
    }
}
//https://leetcode.com/problems/longest-palindrome
