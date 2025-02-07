namespace LeetCodeSolutions.Solutions.MergeKSortedLists;
public class ListNode {
    public int val;
    public ListNode next;
    public ListNode(int x) {
        val = x;
        next = null;
    }
}

public class MergeKSortedListsSolution
{
    public ListNode MergeKLists(ListNode[] lists) {
        if(lists.Length == 0) return null;
        if(lists.Length == 1) return lists[0];

        List<ListNode> list = new List<ListNode>(lists);

        list.RemoveAll(item => item == null);

        if(list.Count == 0) return null;

        int minValue = int.MaxValue;
        int minIndex = 0;

        for(int i = 0; i < list.Count; i++)
        {
            if(list[i].val < minValue)
            {
                minIndex = i;
                minValue = list[i].val;
            }
        }

        ListNode head = list[minIndex];
        ListNode current = head;
        

        if(list[minIndex].next == null)
        {
            list.RemoveAt(minIndex);
        }
        else
        {
            list[minIndex] = list[minIndex].next;
        }

        while(list.Count > 0)
        {
            minValue = list[0].val;
            minIndex = 0;

            for(int i = 0; i < list.Count; i++)
            {
                if(list[i].val < minValue)
                {
                    minIndex = i;
                    minValue = list[i].val;
                }
            }

            current.next = list[minIndex];
            current = current.next;
            if(list[minIndex].next == null)
            {
                list.RemoveAt(minIndex);
            }
            else
            {
                list[minIndex] = list[minIndex].next;
            }
        }

        return head;


    }
}