/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */
public class Solution {
    public ListNode SwapNodes(ListNode head, int k) 
    {
        ListNode runner = head;
        ListNode follower = head;
        ListNode backshots = head;
        int count = 0;
        while(runner != null)
        {
            if(count >= k)
            {
                follower = follower.next;
            }
            runner = runner.next;
            count++;
        }
        count = 1;
        while(count < k)
        {
            backshots = backshots.next;
            count++;
        }
        int temp = backshots.val;
        backshots.val = follower.val;
        follower.val = temp;
        return head;
    }
}
//https://leetcode.com/problems/swapping-nodes-in-a-linked-list/
