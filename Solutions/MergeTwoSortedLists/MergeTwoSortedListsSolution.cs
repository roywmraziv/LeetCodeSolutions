namespace LeetCodeSolutions.Solutions.MergeTwoSortedLists;

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
public class MergeTwoSortedListsSolution
{
    public ListNode MergeTwoLists(ListNode list1, ListNode list2) {
        
        ListNode newList = new ListNode(); // this stays fixed so we have an easy reference to head
        ListNode current = newList;
        
        // edge cases
        if(list1 == null && list2 == null)
        {
            return newList.next;
        }
        else if(list1 == null)
        {
            return list2;
        }
        else if(list2 == null)
        {
            return list1;
        }
        
        while(list1 != null && list2 != null)
        {
            if(list1.val < list2.val)
            {
                current.next = list1;
                list1 = list1.next;
            }
            else
            {
                current.next = list2;
                list2 = list2.next;
            }
            current = current.next;
        }

        if(list1 != null)
        {
            current.next = list1;
        }
        if(list2 != null)
        {
            current.next = list2;
        }

        return newList.next;
    }
}