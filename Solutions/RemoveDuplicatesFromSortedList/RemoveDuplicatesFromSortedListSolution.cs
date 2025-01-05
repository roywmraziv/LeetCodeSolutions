namespace LeetCodeSolutions.Solutions.RemoveDuplicatesFromSortedList;

public class RemoveDuplicatesFromSortedListSolution
{
    public ListNode DeleteDuplicates(ListNode head) {
        if(head==null){return null;}
        ListNode dummy = head;

        ListNode current = head;
        
        while(current != null){

            if(current.next != null && current.val == (current.next).val){
                if((current.next).next != null){
                    current.next = (current.next).next;
                    //current = current.next;
                }
                else
                {
                    current.next = null;
                    //current = current.next;
                }
                
            }
            else{
                current = current.next;
            }
        }
        return dummy;
    }
}

//Definition for singly-linked list.
public class ListNode {
    public int val;
    public ListNode next;
    public ListNode(int val=0, ListNode next=null) {
        this.val = val;
        this.next = next;
    }
}
