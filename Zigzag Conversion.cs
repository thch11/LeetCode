//Ikke en fuld løsning.. Men jeg gider ikke kigge på det mere, synes min løsning er tæt på.. 

public class Solution
{
    public string Convert(string s, int numRows)
    {
        if (numRows == 0)
            return "";
        if (numRows == 1)
            return s;
        int skip = numRows * 2 - 2;
        int endSkip = skip;
        string output = "";
        int start = 0;
        while(skip > 0)
        {
            bool Skipperinos = true;
            for(int i = start; i < s.Length; i += skip)
            {
                if((start + 1) + i > s.Length)
                {
                    break;
                }
                output = output + s[i];
                if(start > 0 && start * 2 + i < s.Length && !Skipperinos)
                {
                    output = output + s[i + start * 2];
                    i = i + start * 2;
                }
                else
                    Skipperinos = !Skipperinos;
            }
            start++;
            skip -= 2;
        }
        for (int i = numRows - 1; i < s.Length; i += endSkip)
        {
            output = output + s[i];
        }

        return output;
    }
}

//https://leetcode.com/problems/zigzag-conversion
