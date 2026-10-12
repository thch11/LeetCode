public class Solution {
    public int[] Intersection(int[] nums1, int[] nums2) 
    {
        HashSet<int> seennums1 = new HashSet<int>();
        HashSet<int> output = new HashSet<int>();
        for(int i = 0; i < nums1.Length; i++)
        {
            seennums1.Add(nums1[i]);
        }
        for(int i = 0; i < nums2.Length; i++)
        {
            if(seennums1.Contains(nums2[i]))
                output.Add(nums2[i]);
        }
        return output.ToArray();

    }
}

//https://leetcode.com/problems/intersection-of-two-arrays/
