public class Solution
{
    public int[] KWeakestRows(int[][] mat, int k)
    {
        List<int> rowList = new List<int>();
        List<int> sumList = new List<int>();
        for (int i = 0; i < mat.Length; i++)
        {
            int sum = 0;
            for (int j = 0; j < mat[i].Length; j++)
            {
                sum += mat[i][j];
            }
            for (int h = 0; h < sumList.Count + 1; h++)
            {
                if (sumList.Count == 0)
                {
                    sumList.Add(sum);
                    rowList.Add(i);
                    break;
                }
                else if (sum < sumList[h])
                {
                    sumList.Insert(h, sum);
                    rowList.Insert(h, i);
                    break;
                }
                else if (h + 1 == sumList.Count && sum >= sumList[h])
                {
                    sumList.Add(sum);
                    rowList.Add(i);
                    break;
                }
            }
        }

        int[] arr = new int[k];
        for (int i = 0; i < k; i++)
        {
            arr[i] = rowList[i];
        }
        return arr;
    }
}
//https://leetcode.com/problems/the-k-weakest-rows-in-a-matrix
