namespace LeetCode.Problems
{
    public class ListNode {
      public int val;
      public ListNode next;
      public ListNode(int x) { val = x; }
    }

    public class Question2
    {
        public ListNode AddTwoNumbers(ListNode l1, ListNode l2) {
            ListNode head = null;
            ListNode previous = null;
            int quotient = 0;

            while(l1 != null || l2 != null) {
                int val1 = l1 != null ? l1.val: 0;
                int val2 = l2 != null ? l2.val: 0;

                int newVal = (val1 + val2 + quotient) % 10 ;
                quotient = (val1 + val2 + quotient) / 10 ;
                
                ListNode newNode = new ListNode(newVal);

                if(head == null) {
                    head = newNode;
                } else {
                    previous.next = newNode;
                }
                
                previous = newNode;
                
                l1 = l1 != null ? l1.next: null;
                l2 = l2 != null ? l2.next: null;
            }

            if(quotient > 0) {
                previous.next = new ListNode(quotient);;
            }

            return head;
        }
    }
}
