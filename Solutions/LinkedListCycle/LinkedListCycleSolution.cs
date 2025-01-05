namespace LeetCodeSolutions.Solutions.LinkedListCycle;
//Definition for singly-linked list.
public class ListNode {
     public int val;
     public ListNode next;
     public ListNode(int x) {
         val = x;
         next = null;
     }
}
public class LinkedListCycleSolution
{
    public bool HasCycle(ListNode head) {
        if(head == null || head.next == null){return false;}
        HashSet<ListNode> set = new HashSet<ListNode>();
        ListNode current = head;
        while(current.next != null)
        {
            if(set.Contains(current))
            {
                return true;
            }

            set.Add(current);
            current = current.next;
        }

        return false;
    }
}