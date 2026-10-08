public class Solution
{
    public int[] Merge(int[] nums1, int m, int[] nums2, int n)
    {
        if (nums1.Length == m)
            return nums1;
        int[] nums1Copy = (int[])nums1.Clone();
        int nums1Tracker = 0;
        int nums2Tracker = 0;
        int returnTracker = 0;

        while(nums1Tracker + nums2Tracker < m + n)
        {
            if (nums1Tracker == m)
            {
                nums1[returnTracker] = nums2[nums2Tracker];
                nums2Tracker++;
                returnTracker++;
            }
            else if (nums2Tracker == n || nums1Copy[nums1Tracker] <= nums2[nums2Tracker])
            {
                nums1[returnTracker] = nums1Copy[nums1Tracker];
                nums1Tracker++;
                returnTracker++;
            }
            else
            {
                nums1[returnTracker] = nums2[nums2Tracker];
                nums2Tracker++;
                returnTracker++;
            }
        }
        return nums1;
    }
}
