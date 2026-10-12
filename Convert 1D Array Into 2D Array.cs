public class Solution {
    public int[][] Construct2DArray(int[] original, int m, int n) 
    {
        int[][] matrix = new int[m][];
        int arraytracker = 0;
        for (int i = 0; i < m; i++)
        {
            matrix[i] = new int[n];
        }
        if(m*n > original.Length || original.Length > m * n)
        {
            matrix = new int[][]{};
            return matrix;
        }
        for(int j = 0; j < m; j++)
        {
            for(int i = 0; i < n; i++)
            {
                matrix[j][i] = original[arraytracker];
                arraytracker++;
            }
        }   
        return matrix;
    }
}
//https://leetcode.com/problems/convert-1d-array-into-2d-array
