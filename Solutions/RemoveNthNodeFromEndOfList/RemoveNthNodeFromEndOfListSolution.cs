namespace LeetCodeSolutions.Solutions.RemoveNthNodeFromEndOfList;
public class ListNode
{
    public int val;
    public ListNode next;
    public ListNode(int x) { val = x; }

    public ListNode(int val = 0, ListNode next = null)
    {
        this.val = val;
        this.next = next;
    }
}
public class RemoveNthNodeFromEndOfListSolution
{
    public ListNode RemoveNthFromEnd(ListNode head, int n) {
        if(head.next == null && n == 1) return null;
        ListNode current = head;
        int length = 0;
        
        while(current != null)
        {
            length++;
            current = current.next;
        }

        if(length == n)
        {
            head = head.next;
            return head;
        }
        
        length -= n;
        ListNode toRemove = head;
        ListNode previous = toRemove;


        while(length > 0)
        {
            previous = toRemove;
            toRemove = toRemove.next;
            length--;
        }
        previous.next = toRemove.next;
        return head;
    }
}