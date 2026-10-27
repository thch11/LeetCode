public class Solution {
    public string[] CreateGrid(int m, int n) 
    {
        string[] resultArr = new string[m];
        string first = "";
        for(int i = 0; i < n; i++)
        {
            first += ".";
        }

        resultArr[0] = first;

        for(int j = 1; j < m; j++)
        {
            string output = "";
            for(int i = 0; i < n; i++)
            {
                if(i + 1 == n)
                    output += ".";
                else
                    output += "#";
            }
            resultArr[j] = output;
        }
        return resultArr;
    }
}
//https://leetcode.com/problems/create-grid-with-exactly-one-path
// EZ Clap :)
