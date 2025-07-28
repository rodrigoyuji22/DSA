namespace DataStructureAndAlgorithms.DataStructures;

public class MiddleOfLinkedList
{
    public class ReverseSinglyLinkedList
    {
        //ex do leetcode 876
        public class ListNode
        {
            public int val;
            public ListNode next;

            public ListNode(int val = 0, ListNode next = null)
            {
                this.val = val;
                this.next = next;
            }
        }
        public ListNode MiddleNode(ListNode head) {
            ListNode ahead = head;

            while(ahead != null && ahead.next != null)
            {
                ahead = ahead.next.next;
                head = head.next;
            }
            return head;
        }
        
    }
    
    
}