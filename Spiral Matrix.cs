public class Solution
{
    public int[][] GenerateMatrix(int n)
    {
        int[][] CopyMatrix = new int[n][];
        for (int i = 0; i < CopyMatrix.Length; i++)
        {
            CopyMatrix[i] = new int[n];
        }
        int column = 0;
        int count = 1;
        int loopcount = n;
        int row = 0;

        int right = n - 1;

        while (count <= loopcount * loopcount)
        {
            for (int i = row; i <= right; i++)
            {
                CopyMatrix[column][i] = count++;
            }
            column++;
            for (int i = column; i <= right; i++)
            {
                CopyMatrix[i][right] = count++;
            }
            right--;
            for (int i = right; i >= row; i--)
            {
                CopyMatrix[right + 1][i] = count++;
            }
            for (int i = right; i >= column; i--)
            {
                CopyMatrix[i][row] = count++;
            }
            row++;
        }
        return CopyMatrix;
    }

//https://leetcode.com/problems/spiral-matrix-ii/
}
