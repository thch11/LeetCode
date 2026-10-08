public class Solution
{
    public ListNode DeleteDuplicates(ListNode head)
    {
        if(head == null)
            return head;
        ListNode current = head.next;
        ListNode SaveVal = head;
        ListNode prev = head;
        while (current != null)
        {
            if (prev.val == current.val)
            {
                prev.next = null;
                prev = current;
                current = current.next;
            }
            else
            {
                prev = current;
                SaveVal.next = current;
                SaveVal = current;
                current = current.next;

            }
        }
        return head;

    }
}

//https://leetcode.com/problems/remove-duplicates-from-sorted-list/
