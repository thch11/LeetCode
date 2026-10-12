public class Solution
{
    public int[] SumZero(int n)
    {
        int[] array = new int[n];
        bool IsEven = false;
        if (n % 2 == 0)
            IsEven = true;
        int LoopLength = n / 2;
        int arraytracker = 0;
        for (int i = -n / 2; i < 0; i++)
        {
            array[arraytracker] = i;
            arraytracker++;

            if (i + 1 == 0 && !IsEven)
            {
                array[arraytracker] = 0;
                arraytracker++;
            }
        }
        for (int i = 1; i < (n / 2) + 1; i++)
        {
            array[arraytracker] = i;
            arraytracker++;
        }
        return array;

    }
}
//https://leetcode.com/problems/find-n-unique-integers-sum-up-to-zero
