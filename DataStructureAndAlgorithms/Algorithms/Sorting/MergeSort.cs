namespace DataStructureAndAlgorithms.Algorithms.Sorting;

public class MergeSort
{
    public class ListNode
    {
        public int val;
        public ListNode? next;

        public ListNode(int val = 0, ListNode? next = null)
        {
            this.val = val;
            this.next = next;
        }
    }
    
    public ListNode Split(ListNode head)
    {
        ListNode slow = head;
        ListNode prevSlow = null;
        ListNode fast = head;

        while (fast != null && fast.next != null)
        {
            prevSlow = slow;
            fast = fast.next.next;
            slow = slow.next;
        }

        return prevSlow;
    }

    public static ListNode Merge(ListNode l1, ListNode l2)
    {
        var dummy = new ListNode();
        var tail = dummy;

        while (l1 != null && l2 != null)
        {
            if (l1.val < l2.val)
            {
                tail.next = l1;
                l1 = l1.next;
            }
            else
            {
                tail.next = l2;
                l2 = l2.next;
            }
            tail = tail.next;
        }
        if(l1 != null)
            tail.next = l1;
        else if(l2 != null)
            tail.next = l2;

        return dummy.next;
    }

    public ListNode Sort(ListNode head)
    {
        if (head == null || head.next == null)
            return head;
        
        ListNode middle = Split(head);
        ListNode rightStart = middle.next;
        middle.next = null;
        
        ListNode left = Sort(head);
        ListNode right = Sort(rightStart);
        
        return Merge(left, right);
    }
}