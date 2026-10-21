public class Solution
{
    public bool UniqueOccurrences(int[] arr)
    {
        HashSet<int> numbers = new HashSet<int>(arr);
        Dictionary<int, int> numberCounts = new Dictionary<int, int>();
        for (int i = 0; i < arr.Length; i++)
        {
            if (numbers.Contains(arr[i]) && !numberCounts.ContainsKey(arr[i]))
                numberCounts.Add(arr[i], 1);
            else
                numberCounts[arr[i]]++;

        }
        HashSet<int> uniqueValues = new HashSet<int>(numberCounts.Values);
        if (uniqueValues.Count == numberCounts.Count)
            return true;
        else 
            return false;
    }
}
//https://leetcode.com/problems/unique-number-of-occurrences/
