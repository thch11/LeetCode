public class Solution
{
    public string ReverseWords(string s)
    {
        if (s[s.Length - 1] != ' ')
            s += ' ';
        string temp = "";
        string output = "";
        int lastSpace = 0;
        for (int i = 0; i < s.Length; i++)
        {
            if (s[i] == ' ' && s[i - 1] != ' ')
            {
                for (int j = i - 1; j >= lastSpace; j--)
                {
                    output += s[j];
                }
                if(s.Length - 1 != i) 
                    output += ' ';
                lastSpace = i + 1;
            }
        }


        return output;

    }
}
//https://leetcode.com/problems/reverse-words-in-a-string-iii
