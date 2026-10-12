public class Solution
{
    public ListNode InsertGreatestCommonDivisors(ListNode head)
    {
        if (head == null || head.next == null)
            return head;
        ListNode curr = head.next;
        ListNode prev = head;
        while (curr != null)
        {
            int divisor = 1;
            int highestval = 0;
            if (prev.val < curr.val)
                highestval = curr.val;
            else
                highestval = prev.val;

            for (int i = highestval; i > 0; i--)
            {
                if (prev.val % i == 0 && curr.val % i == 0)
                {
                    divisor = i;
                    break;
                }
            }
            prev.next = new ListNode(divisor);
            prev.next.next = curr;
            prev = curr;
            curr = curr.next;
        }
        return head;
    }
}
//https://leetcode.com/problems/insert-greatest-common-divisors-in-linked-list/
