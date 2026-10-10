public class Solution
{
    public void Rotate(int[][] matrix)
    {
        int[][] CopyMatrix = new int[matrix.Length][];

        for(int i = 0; i < CopyMatrix.Length; i++)
        {
            CopyMatrix[i] = new int[matrix[i].Length];
        }

        for (int i = 0; i < matrix.Length; i++)
        {
            for (int j = 0; j < matrix[i].Length; j++)
            {
                CopyMatrix[i][j] = matrix[i][j];
            }
        }   

        for(int i = 0; i  < CopyMatrix.Length; i++)
        {
            int count = 0;
            for(int j = (CopyMatrix.Length -1); j >= 0; j--)
            {
                matrix[i][count] = CopyMatrix[j][i];
                count++;
            }
        }
    }
}
//https://leetcode.com/problems/rotate-image/description/
