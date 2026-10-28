public class Solution {
    public ListNode RemoveNthFromEnd(ListNode head, int n) 
    {
        ListNode runner = head;
        ListNode slow = head;
        int count = 0;

        while(runner != null)
        {
           if(count > n)
           {
               slow = slow.next;
           }
           if(runner.next == null)
           {
               if(count + 1 == n)
               {
                   return head.next;
               }
               slow.next = slow.next.next;
               return head;
           }
           runner = runner.next;
           count++; 
        }
        return head;   
    }
}
//https://leetcode.com/problems/remove-nth-node-from-end-of-list
//Brugte hint der var inde på leetcode siden.
