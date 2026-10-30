public class Solution {
    public bool IsSubsequence(string s, string t) 
    {
        if(s.Length == 0)
            return true;
        if(t.Length == 0)
            return false;
        int index = 0;
        for (int i = 0; i < t.Length; i++)
        {
            if (s.Length > index && s[index] == t[i])
                index++;
        }
        if(index == s.Length)
            return true;
        return false;        
    }
}
//https://leetcode.com/problems/is-subsequence
