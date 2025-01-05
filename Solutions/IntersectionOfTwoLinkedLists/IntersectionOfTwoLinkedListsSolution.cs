namespace LeetCodeSolutions.Solutions.IntersectionOfTwoLinkedLists;
public class ListNode {
    public int val;
    public ListNode next;
    public ListNode(int x) {
        val = x;
        next = null;
    }
}
public class IntersectionOfTwoLinkedListsSolution
{
    public ListNode GetIntersectionNode(ListNode headA, ListNode headB) {
        if(headA == null || headB == null){return null;}

        var listA = new List<ListNode>();
        var listB = new List<ListNode>();

        ListNode currentA = headA;
        ListNode currentB = headB;

        while(currentA != null)
        {
            listA.Add(currentA);
            currentA = currentA.next;
        }

        while(currentB != null)
        {
            listB.Add(currentB);
            currentB = currentB.next;
        }

        HashSet<ListNode> set = new HashSet<ListNode>(listA.Intersect(listB));
        if(set.Count == 0){
            return null;
        }
        else{
            return set.First();
        }
        

        // bool intersects = false;
        // if(listA.Count < listB.Count)
        // {
        //     for(int i = 0; i < listA.Count - 1; i++)
        //     {
        //         if(listA[listA.Count -1 - i] != listB[listB.Count-1 - i] && intersects == true)
        //         {
        //             return listA[listA.Count-2 - i];
        //         }

        //         if(listA[listA.Count -1 - i] == listB[listB.Count-1 - i])
        //         {
        //             intersects = true;
        //         }
        //     }
        // }
        // else
        // {
        //     for(int i = 0; i < listB.Count - 1; i++)
        //     {
        //         if(listA[listA.Count -1 - i] != listB[listB.Count - 1 - i] && intersects == true)
        //         {
        //             return listB[listB.Count-2 - i];
        //         }

        //         if(listA[listA.Count -1 - i] == listB[listB.Count -1 - i])
        //         {
        //             intersects = true;
        //         }
        //     }
        // }
        //return null;
    }
}