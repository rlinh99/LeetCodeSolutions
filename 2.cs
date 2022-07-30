/*
Add Two Numbers
Math

Medium
*/
/*
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
public class Solution
{
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
    {
        ListNode headNode = new ListNode();
        ListNode currentNode = headNode;
        bool carryOver = false;

        var headVal = l1.val + l2.val;
        if (headVal >= 10)
        {
            headVal = headVal - 10;
            carryOver = true;
        }
        headNode.val = headVal;

        l1 = l1.next;
        l2 = l2.next;

        while (l1 != null || l2 != null)
        {
            var value = (l1 == null ? 0 : l1.val) + (l2 == null ? 0 : l2.val);
            if (carryOver == true)
                value += 1;
            
            if (value >= 10)
            {
                value = value - 10;
                carryOver = true;
            }
            else
                carryOver = false;
            var newNode = new ListNode(value);

            if (headNode.next == null)
                headNode.next = newNode;
            else
                currentNode.next = newNode;
            currentNode = newNode;

            if (l1 != null)
                l1 = l1.next;

            if (l2 != null)
                l2 = l2.next;
        }
        
        if (carryOver == true)
        {
            var node = new ListNode(1);
            currentNode.next = node;
        }
        return headNode;
    }
}