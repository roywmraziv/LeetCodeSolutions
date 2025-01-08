namespace LeetCodeSolutions.Solutions.AddTwoNumbers;
public class ListNode {
    public int val;
    public ListNode next;
    public ListNode(int x) {
        val = x;
        next = null;
    }
}
public class AddTwoNumbersSolution
{
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2) {
        ListNode l3 = new ListNode(0);
        ListNode head = l3;

        int num;
        int x = 0;

        while(l1 != null || l2 != null || x != 0)
        {
            num = 0 + x;

            if(l1 != null && l2 != null)
            {
                num += (l1.val + l2.val);
                
                l1 = l1.next;
                l2 = l2.next;
            }
            else if(l1 == null && l2 == null){}
            else if(l1 == null)
            {
                num += l2.val;
                l2 = l2.next;
            }
            else if(l2 == null)
            {
                num += l1.val;
                l1 = l1.next;
            }

            x = num / 10;
            num = num % 10;
            
            l3.val = num;
            if(l1 != null || l2 != null || x > 0){
                l3.next = new ListNode(0);
                l3 = l3.next;
            }
            // if(l1 == null && l2 == null && x == 0){continue;}
            // l3.next = new ListNode();
            // l3 = l3.next;

        }
        return head;
    
    }
}