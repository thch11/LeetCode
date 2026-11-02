public class Solution
{
    public string[] FindWords(string[] words)
    {
        HashSet<char> row1 = new HashSet<char>("QWERTYUIOPqwertyuiop");
        HashSet<char> row2 = new HashSet<char>("ASDFGHJKLasdfghjkl");
        HashSet<char> row3 = new HashSet<char>("ZXCVBNMzxcvbnm");

        List<string> returnList = new List<string>();

        for (int i = 0; i < words.Length; i++)
        {
            HashSet<char> currentRow = null;
            int j = 0; 
            while(currentRow == null && j < 3)
            {
                if (row1.Contains(words[i][0]))
                    currentRow = row1;
                else if (row2.Contains(words[i][0]))
                    currentRow = row2;
                else if (row3.Contains(words[i][0]))
                    currentRow = row3;
                j++;
            }

            for(int k = 0; k < words[i].Length; k++)
            {
                if (!currentRow.Contains(words[i][k]))
                    break;

                if ((k + 1 == words[i].Length) && (currentRow.Contains(words[i][k])))
                    returnList.Add(words[i]);

            }
        }
        return returnList.ToArray();
    }
}
//https://leetcode.com/problems/keyboard-row/
