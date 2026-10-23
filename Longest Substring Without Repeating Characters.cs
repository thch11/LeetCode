public class Solution
{
    public int LengthOfLongestSubstring(string s)
    {
        HashSet<char> CheckIfAllUnique = new HashSet<char>(s);
        if (s.Length == CheckIfAllUnique.Count)
            return s.Length;
        HashSet<char> set = new HashSet<char>();
        int WindowLength = 1;
        int result = 0;
        for (int i = 0; i < s.Length; i++)
        {
            if(WindowLength > set.Count && set.Contains(s[i]) == false)
            {
                set.Add(s[i]);
                WindowLength++;
            }
            else
            {
                if (set.Count > result)
                    result = set.Count;
                i = i - set.Count;
                set.Clear();
            }
            if (set.Count > result)
                result = set.Count;
        }
        return result;
    }
}
//https://leetcode.com/problems/longest-substring-without-repeating-characters/
