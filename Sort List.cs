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
    public ListNode SortList(ListNode head) 
    {
        List<int> MyList = new List<int>();
        ListNode runner = head;
        while(runner != null)
        {
            MyList.Add(runner.val);
            runner = runner.next;
        }
        int[] arr = MyList.ToArray();
        Array.Sort(arr);
        int index = 0;
        runner = head;
        while(runner != null)
        {
            runner.val = arr[index++];
            runner = runner.next;
        }
        return head;
    }
}
//https://leetcode.com/problems/sort-list
//Løst på under 5 minutter.. Pretty good shiiiit
