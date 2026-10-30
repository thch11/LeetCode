public class Solution
{
    public char FindTheDifference(string s, string t)
    {
        List<char> sString = new List<char>(s);
        sString.Sort();
        List<char> tString = new List<char>(t);
        tString.Sort();
        for(int i = 0; i < sString.Count; i++)
        {
            if (sString[i] != tString[i])
                return tString[i];
        }
        return tString[tString.Count - 1];
    }
}
//https://leetcode.com/problems/find-the-difference/
