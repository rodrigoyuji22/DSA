namespace DataStructureAndAlgorithms.DataStructures;

public class ReverseSinglyLinkedList
{
    //ex do leetcode 206
    public class ListNode { 
        public int val; 
        public ListNode next; 
        public ListNode(int val=0, ListNode next=null) {
            this.val = val;
            this.next = next;
            }
    }
    
    public ListNode ReverseList(ListNode head)
    {
        ListNode prev = null;
        ListNode curr = head;

        while (curr != null)
        {
            ListNode tempNext = curr.next;
            curr.next = prev;
            prev = curr;
            curr = tempNext;
        }

        return prev;
    }
}